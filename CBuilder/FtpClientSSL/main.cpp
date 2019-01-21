//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "newDlg.h"
#include "fileDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clFtp"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma link "clTcpCommandClient"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::btnLoginClick(TObject *Sender)
{
  if(clFTP->Active)
  {
    ShowMessage("You are already connected. Please click Logout to disconnect.");
    return;
  }

  FCertificateVerified = false;

  clFTP->Port = StrToInt(edtPort->Text);
  clFTP->Server = edtServer->Text;
  clFTP->UserName = edtUser->Text;
  clFTP->Password = edtPassword->Text;
  clFTP->PassiveMode = cbPassiveMode->Checked;
  if(cbAsciiMode->Checked)
    clFTP->TransferType = ttAscii;
  else
    clFTP->TransferType = ttBinary;

  if(cbUseTLS->Checked)
    clFTP->UseTLS = ctAutomatic;
  else
    clFTP->UseTLS = ctNone;

  clFTP->Open();
  if(edtStartDir->Text == "")
    edtStartDir->Text = clFTP->CurrentDir;

  if((edtStartDir->Text != "") && (edtStartDir->Text[1] == '/'))
  {
    DoOpenDir(edtStartDir->Text);
  }
  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnLogoutClick(TObject *Sender)
{
  clFTP->Close();
  lbList->Items->Clear();
  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnOpenDirClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] == '/'))
  {
    DoOpenDir(clFTP->CurrentDir + lbList->Items->Strings[lbList->ItemIndex]);
  }
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::btnGoUpClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  clFTP->ChangeToParentDir();
  FillDirList();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnMakeDirClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  UnicodeString s = TNewDialog::ShowNewDialog("New Dir Name", "NewName");
  if(s != "")
  {
    clFTP->MakeDir(s);
    FillDirList();
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnRemoveDirClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] == '/'))
  {
    if(MessageDlg("Do you wish to delete the " + lbList->Items->Strings[lbList->ItemIndex] + " directory ?",
      mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
    {
      clFTP->RemoveDir(clFTP->CurrentDir + lbList->Items->Strings[lbList->ItemIndex]);
      FillDirList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDeleteFileClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] != '/'))
  {
    if(MessageDlg("Do you wish to delete the " + lbList->Items->Strings[lbList->ItemIndex] + " file ?",
      mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
    {
      clFTP->Delete(lbList->Items->Strings[lbList->ItemIndex]);
      FillDirList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnRenameClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] != '/'))
  {
    UnicodeString s = TNewDialog::ShowNewDialog("New File Name", lbList->Items->Strings[lbList->ItemIndex]);
    if((s != "") && (s != lbList->Items->Strings[lbList->ItemIndex]))
    {
      clFTP->Rename(lbList->Items->Strings[lbList->ItemIndex], s);
      FillDirList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnAbortClick(TObject *Sender)
{
  if(clFTP->Active)
	clFTP->Abort();
  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDownloadClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] != '/'))
  {
    SaveDialog->FileName = lbList->Items->Strings[lbList->ItemIndex];
    if(SaveDialog->Execute())
    {
      int size = clFTP->GetFileSize(lbList->Items->Strings[lbList->ItemIndex]);
      int position = 0;
      TStream *stream = NULL;
      __try
      {
        if(FileExists(SaveDialog->FileName))
        {
          int fileExistsResult = TFileExistsDialog::ShowFileDialog(SaveDialog->FileName);
          if(fileExistsResult == mrCancel)
            return;
          if(fileExistsResult == mrYes)
          {
            stream = new TFileStream(SaveDialog->FileName, fmCreate);
          } else
          {
            stream = new TFileStream(SaveDialog->FileName, fmOpenReadWrite);
            if(size > stream->Size)
            {
              position = stream->Size;
            } else
            {
              delete stream;
              stream = NULL;
              stream = new TFileStream(SaveDialog->FileName, fmCreate);
            }
          }
        } else
        {
          stream = new TFileStream(SaveDialog->FileName, fmCreate);
        }
        ProgressBar->Min = 0;
        ProgressBar->Max = size;
        ProgressBar->Position = position;
        clFTP->GetFile(lbList->Items->Strings[lbList->ItemIndex], stream, position, -1);
        ShowMessage("Done");
      }
      __finally
      {
        delete stream;
      }
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnUploadClick(TObject *Sender)
{
  if(!clFTP->Active) return;

  if(OpenDialog->Execute())
  {
    int position = 0;
    TStream *stream = new TFileStream(OpenDialog->FileName, fmOpenRead);
    __try
    {
      UnicodeString fileName = ExtractFileName(OpenDialog->FileName);
      if(clFTP->FileExists(fileName))
      {
        int fileExistsResult = TFileExistsDialog::ShowFileDialog(fileName);
        if(fileExistsResult == mrCancel)
          return;
        if(fileExistsResult == mrNo)
        {
          position = clFTP->GetFileSize(fileName);
          if(stream->Size <= position)
            position = 0;
        }
      }
      ProgressBar->Min = 0;
      ProgressBar->Max = stream->Size;
      ProgressBar->Position = position;
      clFTP->PutFile(stream, fileName, position, -1);
      ShowMessage("Done");
    }
    __finally
    {
      delete stream;
    }
    FillDirList();
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::UpdateStatuses()
{
  bool enabled = clFTP->Active;
  if(enabled)
	Caption = "Ftp Client - Connected";
  else
	Caption = "Ftp Client";
  btnOpenDir->Enabled = enabled;
  btnGoUp->Enabled = enabled;
  btnMakeDir->Enabled = enabled;
  btnRemoveDir->Enabled = enabled;
  btnDownload->Enabled = enabled;
  btnUpload->Enabled = enabled;
  btnDeleteFile->Enabled = enabled;
  btnRename->Enabled = enabled;
  btnAbort->Enabled = enabled;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::DoOpenDir(const UnicodeString ADir)
{
  UnicodeString dir = ADir;
  if ((dir.Length() > 1) && (dir[1] == '/') && (dir[2] == '/'))
    dir.Delete(1, 1);

  clFTP->ChangeCurrentDir("/");
  clFTP->ChangeCurrentDir(dir);
  FillDirList();
}

//---------------------------------------------------------------------------
void __fastcall TMainForm::FillDirList()
{
  lbList->Items->BeginUpdate();
  __try
  {
    lbList->Items->Clear();
    clFTP->DirectoryListing("");
  }
  __finally
  {
    lbList->Items->EndUpdate();
  }
  lbList->Sorted = false;
  lbList->Sorted = true;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFTPDirectoryListing(TObject *Sender,
      TclFtpFileInfo *AFileInfo, const UnicodeString Source)
{
  lbList->Items->Add((AFileInfo->IsDirectory ? "/" : "") + AFileInfo->FileName);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFTPReceiveResponse(TObject *Sender,
      TStrings *AList)
{
  memLog->Lines->AddStrings(AList);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFTPSendCommand(TObject *Sender,
      const UnicodeString AText)
{
  memLog->Lines->Add(Trim(AText));
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormShow(TObject *Sender)
{
  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  clFTP->Close();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::cbUseTLSClick(TObject *Sender)
{
  cbPassiveMode->Enabled = !cbUseTLS->Checked;
  if(cbUseTLS->Checked)
    cbPassiveMode->Checked = true;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFTPVerifyServer(TObject *Sender,
      TclCertificate *ACertificate, const UnicodeString AStatusText,
      int AStatusCode, bool &AVerified)
{
  if(!AVerified)
    AVerified = FCertificateVerified;

  if (!AVerified && (MessageDlg(AStatusText + "\r\n Do you wish to proceed ?",
    mtWarning, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)) {
    AVerified = true;
    FCertificateVerified = true;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFTPProgress(TObject *Sender,
      __int64 ABytesProceed, __int64 ATotalBytes)
{
  ProgressBar->Position = ABytesProceed;
  ProgressBar->Max = ATotalBytes;
}
//---------------------------------------------------------------------------

