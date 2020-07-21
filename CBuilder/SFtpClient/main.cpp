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
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnLogoutClick(TObject *Sender)
{
  clSFtp1->Close();
  lbList->Items->Clear();
  UpdateStatuses();
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
      int size = clSFtp1->GetFileSize(lbList->Items->Strings[lbList->ItemIndex]);
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
    int position = 0;
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
      ProgressBar->Min = 0;
      ProgressBar->Max = stream->Size;
      ProgressBar->Position = position;
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
  ProgressBar->Position = ABytesProceed;
  ProgressBar->Max = ATotalBytes;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1ReceiveResponse(TObject *Sender,
      int AFxpCommand, TStream *ABuffer)
{
  memLog->Lines->Add(Format("S: %s (%d bytes)", ARRAYOFCONST((GetCommandName(AFxpCommand), (int)ABuffer->Size))));
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1SendCommand(TObject *Sender, int AFxpCommand,
      TStream *ABuffer)
{
  memLog->Lines->Add(Format("C: %s (%d bytes)", ARRAYOFCONST((GetCommandName(AFxpCommand), (int)ABuffer->Size))));
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtp1ShowBanner(TObject *Sender,
      const UnicodeString AMessage, const UnicodeString ALanguage)
{
  memLog->Lines->Add("S: " + Trim(AMessage));
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

UnicodeString __fastcall TMainForm::GetCommandName(int AFxp)
{
  switch (AFxp) {
    case SSH_FXP_INIT: return "SSH_FXP_INIT";
    case SSH_FXP_VERSION: return "SSH_FXP_VERSION";
    case SSH_FXP_OPEN: return "SSH_FXP_OPEN";
    case SSH_FXP_CLOSE: return "SSH_FXP_CLOSE";
    case SSH_FXP_READ: return "SSH_FXP_READ";
    case SSH_FXP_WRITE: return "SSH_FXP_WRITE";
    case SSH_FXP_LSTAT: return "SSH_FXP_LSTAT";
    case SSH_FXP_FSTAT: return "SSH_FXP_FSTAT";
    case SSH_FXP_SETSTAT: return "SSH_FXP_SETSTAT";
    case SSH_FXP_FSETSTAT: return "SSH_FXP_FSETSTAT";
    case SSH_FXP_OPENDIR: return "SSH_FXP_OPENDIR";
    case SSH_FXP_READDIR: return "SSH_FXP_READDIR";
    case SSH_FXP_REMOVE: return "SSH_FXP_REMOVE";
    case SSH_FXP_MKDIR: return "SSH_FXP_MKDIR";
    case SSH_FXP_RMDIR: return "SSH_FXP_RMDIR";
    case SSH_FXP_REALPATH: return "SSH_FXP_REALPATH";
    case SSH_FXP_STAT: return "SSH_FXP_STAT";
    case SSH_FXP_RENAME: return "SSH_FXP_RENAME";
    case SSH_FXP_READLINK: return "SSH_FXP_READLINK";
    case SSH_FXP_SYMLINK: return "SSH_FXP_SYMLINK";
    case SSH_FXP_STATUS: return "SSH_FXP_STATUS";
    case SSH_FXP_HANDLE: return "SSH_FXP_HANDLE";
    case SSH_FXP_DATA: return "SSH_FXP_DATA";
    case SSH_FXP_NAME: return "SSH_FXP_NAME";
    case SSH_FXP_ATTRS: return "SSH_FXP_ATTRS";
    case SSH_FXP_EXTENDED: return "SSH_FXP_EXTENDED";
    case SSH_FXP_EXTENDED_REPLY: return "SSH_FXP_EXTENDED_REPLY";
    default: return "UNKNOWN";
  }
}
//---------------------------------------------------------------------------

