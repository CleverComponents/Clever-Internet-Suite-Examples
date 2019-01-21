//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
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
  clFTP->Port = StrToInt(edtPort->Text);
  clFTP->Server = edtServer->Text;
  clFTP->UserName = edtUser->Text;
  clFTP->Password = edtPassword->Text;
  clFTP->PassiveMode = cbPassiveMode->Checked;
  if(cbAsciiMode->Checked)
    clFTP->TransferType = ttAscii;
  else
    clFTP->TransferType = ttBinary;

  clFTP->ProxySettings->Server = edtProxyServer->Text;
  clFTP->ProxySettings->Port = StrToInt(edtProxyPort->Text);
  clFTP->ProxySettings->UserName = edtProxyUser->Text;
  clFTP->ProxySettings->Password = edtProxyPassword->Text;
  clFTP->ProxySettings->ProxyType = (TclFtpProxyType)cbProxyType->ItemIndex;

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
    if (SaveDialog->Execute()) {
      TStream *stream = new TFileStream(SaveDialog->FileName, fmCreate);
      __try {
        ProgressBar->Min = 0;
        ProgressBar->Max = clFTP->GetFileSize(lbList->Items->Strings[lbList->ItemIndex]);
        ProgressBar->Position = 0;
        clFTP->GetFile(lbList->Items->Strings[lbList->ItemIndex], stream);

        ShowMessage("Done");
      }
      __finally {
        delete stream;
      }
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnUploadClick(TObject *Sender)
{
  if (!clFTP->Active) return;
  if (OpenDialog->Execute()) {
    TStream *stream = new TFileStream(OpenDialog->FileName, fmOpenRead);
    __try {
      ProgressBar->Min = 0;
      ProgressBar->Max = stream->Size;
      ProgressBar->Position = 0;
      clFTP->PutFile(stream, ExtractFileName(OpenDialog->FileName));
      
      ShowMessage("Done");
    }
    __finally {
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
  btnDownload->Enabled = enabled;
  btnUpload->Enabled = enabled;
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

void __fastcall TMainForm::clFTPProgress(TObject *Sender,
	  __int64 ABytesProceed, __int64 ATotalBytes)
{
  ProgressBar->Position = ABytesProceed;
  ProgressBar->Max = ATotalBytes;
}
//---------------------------------------------------------------------------

