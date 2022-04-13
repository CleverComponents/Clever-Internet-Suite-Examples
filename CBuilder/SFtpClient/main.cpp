//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "newDlg.h"
#include "fileDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "clTcpClient"
#pragma link "DemoBaseFormUnit"
#pragma link "clSFtp"
#pragma link "clTcpClientSsh"
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
  if(clSFtp1->Active)
  {
    ShowMessage("You are already connected. Please click Logout to disconnect.");
    return;
  }
  
  clSFtp1->Port = StrToInt(edtPort->Text);
  clSFtp1->Server = edtServer->Text;
  clSFtp1->UserName = edtUser->Text;
  clSFtp1->Password = edtPassword->Text;
  clSFtp1->Open();
  if(edtStartDir->Text == "")
    edtStartDir->Text = clSFtp1->CurrentDir;

  if((edtStartDir->Text != "") && (edtStartDir->Text[1] == '/'))
  {
    DoOpenDir(edtStartDir->Text);
  }
  UpdateStatuses();
  ProgressBar->Position = 0;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnLogoutClick(TObject *Sender)
{
  clSFtp1->Close();
  lbList->Items->Clear();
  UpdateStatuses();
  ProgressBar->Position = 0;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnOpenDirClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] == '/'))
  {
    DoOpenDir(clSFtp1->CurrentDir + lbList->Items->Strings[lbList->ItemIndex]);
  }
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::btnGoUpClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  clSFtp1->ChangeToParentDir();
  FillDirList();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnMakeDirClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  UnicodeString s = TNewDialog::ShowNewDialog("New Dir Name", "NewName");
  if(s != "")
  {
    clSFtp1->MakeDir(s);
    FillDirList();
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnRemoveDirClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] == '/'))
  {
    if(MessageDlg("Do you wish to delete the " + lbList->Items->Strings[lbList->ItemIndex] + " directory ?",
      mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
    {
      clSFtp1->RemoveDir(clSFtp1->CurrentDir + lbList->Items->Strings[lbList->ItemIndex]);
      FillDirList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDeleteFileClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] != '/'))
  {
    if(MessageDlg("Do you wish to delete the " + lbList->Items->Strings[lbList->ItemIndex] + " file ?",
      mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
    {
      clSFtp1->Delete(lbList->Items->Strings[lbList->ItemIndex]);
      FillDirList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnRenameClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] != '/'))
  {
    UnicodeString s = TNewDialog::ShowNewDialog("New File Name", lbList->Items->Strings[lbList->ItemIndex]);
    if((s != "") && (s != lbList->Items->Strings[lbList->ItemIndex]))
    {
      clSFtp1->Rename(lbList->Items->Strings[lbList->ItemIndex], s);
      FillDirList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDownloadClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  if((lbList->ItemIndex > -1) &&
    (lbList->Items->Strings[lbList->ItemIndex] != "") &&
    (lbList->Items->Strings[lbList->ItemIndex][1] != '/'))
  {
    SaveDialog->FileName = lbList->Items->Strings[lbList->ItemIndex];
    if(SaveDialog->Execute())
    {
      __int64 size = clSFtp1->GetFileSize(lbList->Items->Strings[lbList->ItemIndex]);
      __int64 position = 0;
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
        ProgressBar->Position = GetProgressBarPos(position, size);

        clSFtp1->GetFile(lbList->Items->Strings[lbList->ItemIndex], stream, position, size);
	  }
	  __finally
	  {
		delete stream;
	  }

      ShowMessage("Done");
	}
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnUploadClick(TObject *Sender)
{
  if(!clSFtp1->Active) return;

  if(OpenDialog->Execute())
  {
    __int64 position = 0;
	TStream *stream = new TFileStream(OpenDialog->FileName, fmOpenRead);
    __try
    {
      UnicodeString fileName = ExtractFileName(OpenDialog->FileName);
      if(clSFtp1->FileExists(fileName))
      {
        int fileExistsResult = TFileExistsDialog::ShowFileDialog(fileName);
        if(fileExistsResult == mrCancel)
          return;
        if(fileExistsResult == mrNo)
        {
          position = clSFtp1->GetFileSize(fileName);
          if(stream->Size <= position)
            position = 0;
        }
      }
      ProgressBar->Position = GetProgressBarPos(position, stream->Size);

      clSFtp1->PutFile(stream, fileName, position, stream->Size - position);
	}
	__finally
	{
	  delete stream;
	}

	FillDirList();
	ShowMessage("Done");
  }
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::UpdateStatuses()
{
  bool enabled = clSFtp1->Active;
  if (enabled)
    Caption = "SFTP Client - Connected";
  else
	Caption = "SFTP Client";
  btnOpenDir->Enabled = enabled;
  btnGoUp->Enabled = enabled;
  btnMakeDir->Enabled = enabled;
  btnRemoveDir->Enabled = enabled;
  btnDeleteFile->Enabled = enabled;
  btnRename->Enabled = enabled;
  btnDownload->Enabled = enabled;
  btnUpload->Enabled = enabled;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::DoOpenDir(const UnicodeString ADir)
{
  UnicodeString dir = ADir;
  if ((dir.Length() > 1) && (dir[1] == '/') && (dir[2] == '/'))
    dir.Delete(1, 1);

  clSFtp1->ChangeCurrentDir("/");
  clSFtp1->ChangeCurrentDir(dir);
  FillDirList();
}

//---------------------------------------------------------------------------
void __fastcall TMainForm::FillDirList()
{
  lbList->Items->BeginUpdate();
  __try
  {
    lbList->Items->Clear();
	clSFtp1->DirectoryListing();
  }
  __finally
  {
	lbList->Items->EndUpdate();
  }
  lbList->Sorted = false;
  lbList->Sorted = true;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormShow(TObject *Sender)
{
  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  clSFtp1->Close();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1DirectoryListing(TObject *Sender,
      const UnicodeString AFileName, TclSFtpFileAttrs *AFileAttrs)
{
  lbList->Items->Add((AFileAttrs->IsDir ? "/" : "") + AFileName);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1Progress(TObject *Sender,
      __int64 ABytesProceed, __int64 ATotalBytes)
{
  ProgressBar->Position = GetProgressBarPos(ABytesProceed, ATotalBytes);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1ReceiveResponse(TObject *Sender,
      int AFxpCommand, TStream *ABuffer)
{
  if ((AFxpCommand != SSH_FXP_READ) && (AFxpCommand != SSH_FXP_WRITE) && (AFxpCommand != SSH_FXP_READDIR))
  {
	memLog->Lines->Add(Format("S: %s (%d bytes)", ARRAYOFCONST((GetSFtpCommandName(AFxpCommand), (int)ABuffer->Size))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1SendCommand(TObject *Sender, int AFxpCommand,
      TStream *ABuffer)
{
  if ((AFxpCommand != SSH_FXP_READ) && (AFxpCommand != SSH_FXP_WRITE) && (AFxpCommand != SSH_FXP_READDIR))
  {
	memLog->Lines->Add(Format("C: %s (%d bytes)", ARRAYOFCONST((GetSFtpCommandName(AFxpCommand), (int)ABuffer->Size))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1ShowBanner(TObject *Sender,
      const UnicodeString AMessage, const UnicodeString ALanguage)
{
  memLog->Lines->Add("Server Banner: " + Trim(AMessage));
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1VerifyServer(TObject *Sender, const UnicodeString AHost,
          const UnicodeString AKeyType, const UnicodeString AFingerPrint,
          const UnicodeString AHostKey, bool &AVerified)
{
  AVerified = (MessageDlg(Format("You are trying to connect to \"%s\" host,\r\nKey Type: %s\r\nFinger Print: %s\r\n\r\nDo you wish to proceed ?",
	ARRAYOFCONST((AHost, AKeyType, AFingerPrint))),
	mtWarning, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes);
}
//---------------------------------------------------------------------------

int __fastcall TMainForm::GetProgressBarPos(__int64 APosition, __int64 ASize)
{
  if (APosition == 0 || ASize == 0) return 0;
  return floor((double)APosition / ASize * 100);
}

