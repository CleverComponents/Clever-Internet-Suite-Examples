//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clSFtpServer"
#pragma link "clTcpServer"
#pragma link "clSFtpFileHandler"
#pragma link "clServerGuard"
#pragma link "clTcpServerSsh"
#pragma link "clSshPacket"
#pragma link "clSFtpUtils"
#pragma link "clUtils"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCreate(TObject *Sender)
{
  FSynchronizer = new TCriticalSection();

  pgMain->ActivePage = tabServer;
  lblStatus->Visible = false;

  LoadHostKey();
  LoadDefaultSettings();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::PutLogMessage(const UnicodeString ALogMessage)
{
  if (!ComponentState.Contains(csDestroying))
  {
    FSynchronizer->Enter();
    __try
    {
      memLog->Lines->Add(ALogMessage);
    }
    __finally
    {
      FSynchronizer->Leave();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  delete FSynchronizer;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  if (clSFtpServer1->Active) return;

  LoadHostKey();

  if (!clSFtpServer1->HostKey->HasKey)
  {
    GenerateHostKey();
  }

  AssignSettings();

  clServerGuard1->Reset();
  clSFtpServer1->Start();
  lblStatus->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStopClick(TObject *Sender)
{
  FIsStop = true;
  __try {
    clSFtpServer1->Stop();
    lblStatus->Visible = false;
  }
  __finally {
    FIsStop = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnLoadHostKeyClick(TObject *Sender)
{
  if (clSFtpServer1->Active) return;

  if (!OpenDialog1->Execute()) return;

  edtHostKeyFile->Text = OpenDialog1->FileName;

  LoadHostKey();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnGenerateHostKeyClick(TObject *Sender)
{
  GenerateHostKey();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtpServer1AcceptConnection(TObject *Sender, TclUserConnection *AConnection,
          bool &Handled)
{
  PutLogMessage("Accept Connection. Host: " + AConnection->PeerIP);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtpServer1CloseConnection(TObject *Sender, TclUserConnection *AConnection)

{
  if (!FIsStop)
  {
    PutLogMessage("Close Connection. Host: " + AConnection->PeerIP);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtpServer1ReceiveRequest(TObject *Sender, TclSFtpUserConnection *AConnection,
          BYTE ACommand, DWORD ARequestId, TclSshPacket *APacket)

{
  if ((ACommand != SSH_FXP_READ) && (ACommand != SSH_FXP_WRITE) && (ACommand != SSH_FXP_READDIR))
  {
    memLog->Lines->Add(Format("Command[%d]: %s (%d bytes)", ARRAYOFCONST((ARequestId, GetCommandName(ACommand), APacket->GetLength()))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtpServer1SendResponse(TObject *Sender, TclSFtpUserConnection *AConnection,
          BYTE ACommand, DWORD ARequestId, TclSshPacket *APacket)

{
  if ((ACommand != SSH_FXP_READ) && (ACommand != SSH_FXP_WRITE) && (ACommand != SSH_FXP_READDIR))
  {
    memLog->Lines->Add(Format("Reply[%d]: %s (%d bytes)", ARRAYOFCONST((ARequestId, GetCommandName(ACommand), APacket->GetLength()))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtpServer1Start(TObject *Sender)
{
  PutLogMessage("==================\r\nStart Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSFtpServer1Stop(TObject *Sender)
{
  PutLogMessage("Stop Server");
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

void __fastcall TMainForm::LoadHostKey()
{
  if (clSFtpServer1->Active) return;

  clSFtpServer1->HostKey->Clear();

  clSFtpServer1->HostKey->PrivateKeyFile = edtHostKeyFile->Text;
  clSFtpServer1->HostKey->PassPhrase = edtHostKeyPassPhrase->Text;

  if ((edtHostKeyFile->Text != "") && FileExists(edtHostKeyFile->Text))
  {
    clSFtpServer1->HostKey->Load();
	edtFingerPrint->Text = clSFtpServer1->HostKey->FingerPrint;
  }
  else
  {
	edtFingerPrint->Text = "";
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::GenerateHostKey()
{
  if (clSFtpServer1->Active) return;

  if ((edtHostKeyFile->Text != "") && FileExists(edtHostKeyFile->Text))
  {
    if (MessageDlg("The key file \"" + edtHostKeyFile->Text + "\" already exists. Do you want to replace?",
        mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) != mrYes) return;
  }

  clSFtpServer1->HostKey->KeyLength = StrToInt(edtKeyLength->Text);
  clSFtpServer1->HostKey->Generate();

  if (edtHostKeyFile->Text != "")
  {
    clSFtpServer1->HostKey->Save(edtHostKeyFile->Text);
  }

  edtFingerPrint->Text = clSFtpServer1->HostKey->FingerPrint;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::AssignSettings()
{
  if (clSFtpServer1->Active) return;

  //Server Tab
  clSFtpServer1->Port = StrToInt(edtPort->Text);
  clSFtpServer1->LocalBinding = edtBindingHost->Text;
  clSFtpServer1->UseIpV6 = cbUseIPv6->Checked;
  clSFtpServer1->RootDir = edtRootDir->Text;
  if (clSFtpServer1->RootDir != "")
  {
    ForceFileDirectories(AddTrailingBackSlash(clSFtpServer1->RootDir));
  }

  //Banner Tab
  clSFtpServer1->Banner = edtBannerMessage->Text;
  clSFtpServer1->BannerLanguage = edtBannerLanguage->Text;
  clSFtpServer1->EnableBanner = cbEnableBanner->Checked;

  //Access Control Tab
  clSFtpServer1->UserAccounts->Clear();
  clSFtpServer1->UserAccounts->Add();
  clSFtpServer1->UserAccounts->Items[0]->UserName = edtUserName->Text;
  clSFtpServer1->UserAccounts->Items[0]->Password = edtPassword->Text;
  clSFtpServer1->UserAccounts->Items[0]->RootDir = edtUserRootDir->Text;
  if (clSFtpServer1->UserAccounts->Items[0]->RootDir != "")
  {
    ForceFileDirectories(AddTrailingBackSlash(clSFtpServer1->UserAccounts->Items[0]->RootDir));
  }

  TclSFtpServerPermissions permissions = TclSFtpServerPermissions();
  if (cbCanList->Checked) permissions = permissions << sfpList;
  if (cbCanMakeDir->Checked) permissions = permissions << sfpMakeDir;
  if (cbCanRemoveDir->Checked) permissions = permissions << sfpRemoveDir;
  if (cbCanRead->Checked) permissions = permissions << sfpRead;
  if (cbCanWrite->Checked) permissions = permissions << sfpWrite;
  if (cbCanRename->Checked) permissions = permissions << sfpRename;
  if (cbCanRemove->Checked) permissions = permissions << sfpRemove;
  if (cbCanMakeLink->Checked) permissions = permissions << sfpMakeLink;
  if (cbCanReadLink->Checked) permissions = permissions << sfpReadLink;
  clSFtpServer1->UserAccounts->Items[0]->Permissions = permissions;

  //IP Blocking Tab
  clServerGuard1->ConnectionLimit->Max = StrToInt(edtAllowedConnections->Text);
  clServerGuard1->ConnectionLimit->Period = 60000; //1 minute
  clServerGuard1->BlackIPList->Assign(memBlackList->Lines);
  clServerGuard1->WhiteIPList->Assign(memWhiteList->Lines);
  clServerGuard1->AllowWhiteListOnly = cbWhiteListOnly->Checked;

  //SSH Algorithms Tab
  clSFtpServer1->Config->SetConfig("kex", edtKexAlgs->Text);
  clSFtpServer1->Config->SetConfig("hostkey", edtSignatureAlgs->Text);
  clSFtpServer1->Config->SetConfig("cipher.s2c", edtEncryptionAlgs->Text);
  clSFtpServer1->Config->SetConfig("cipher.c2s", edtEncryptionAlgs->Text);
  clSFtpServer1->Config->SetConfig("mac.s2c", edtDataIntegrityAlgs->Text);
  clSFtpServer1->Config->SetConfig("mac.c2s", edtDataIntegrityAlgs->Text);

  //Additional Settings Tab
  clSFtpServer1->CharSet = edtCharSet->Text;
  clSFtpServer1->MaxReturnFiles = StrToInt(edtMaxReturnFiles->Text);
  clSFtpServer1->BatchSize = StrToInt(edtBatchSize->Text);
  clSFtpServer1->MaxWindowSize = StrToInt(edtMaxWindowSize->Text);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::LoadDefaultSettings()
{
  //Host Key
  edtKeyLength->Text = IntToStr(clSFtpServer1->HostKey->KeyLength);

  //SSH Algorithms Tab
  edtKexAlgs->Text = clSFtpServer1->Config->GetConfig("kex");
  edtSignatureAlgs->Text = clSFtpServer1->Config->GetConfig("hostkey");
  edtEncryptionAlgs->Text = clSFtpServer1->Config->GetConfig("cipher.s2c");
  edtDataIntegrityAlgs->Text = clSFtpServer1->Config->GetConfig("mac.s2c");

  //Additional Settings Tab
  edtCharSet->Text = clSFtpServer1->CharSet;
  edtMaxReturnFiles->Text = IntToStr(clSFtpServer1->MaxReturnFiles);
  edtBatchSize->Text = IntToStr(clSFtpServer1->BatchSize);
  edtMaxWindowSize->Text = IntToStr(clSFtpServer1->MaxWindowSize);
}
//---------------------------------------------------------------------------


