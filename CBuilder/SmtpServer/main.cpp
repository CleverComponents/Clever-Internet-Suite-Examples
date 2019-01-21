//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include <IniFiles.hpp>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clSmtpFileHandler"
#pragma link "clSmtpServer"
#pragma link "clTcpServer"
#pragma link "clTcpCommandServer"
#pragma link "clTcpServerTls"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
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

UnicodeString __fastcall TMainForm::GetSettingsFile()
{
  return AddTrailingBackSlash(edtMailboxDir->Text) + "smtp.dat";
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCreate(TObject *Sender)
{
  FSynchronizer = new TCriticalSection();
  TIniFile *ini = new TIniFile(GetSettingsFile());
  __try {
    clSmtpFileHandler1->Counter = ini->ReadInteger("SMTP", "Counter", 1);
  }
  __finally {
    delete ini;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  delete FSynchronizer;
  TIniFile *ini = new TIniFile(GetSettingsFile());
  __try {
    ini->WriteInteger("SMTP", "Counter", clSmtpFileHandler1->Counter);
  }
  __finally {
    delete ini;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  clSmtpServer1->Port = StrToInt(edtPort->Text);
  clSmtpServer1->UseAuth = cbUseLogin->Checked;

  clSmtpFileHandler1->MailBoxDir = edtMailboxDir->Text;
  clSmtpFileHandler1->RelayDir = edtRelayDir->Text;

  ForceFileDirectories(AddTrailingBackSlash(clSmtpFileHandler1->MailBoxDir));
  ForceFileDirectories(AddTrailingBackSlash(clSmtpFileHandler1->RelayDir));

  clSmtpServer1->Start();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStopClick(TObject *Sender)
{
  FIsStop = true;
  __try {
    clSmtpServer1->Stop();
  }
  __finally {
    FIsStop = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1Start(TObject *Sender)
{
  PutLogMessage("==================\r\nStart Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1Stop(TObject *Sender)
{
  PutLogMessage("Stop Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1AcceptConnection(TObject *Sender,
      TclUserConnection *AConnection, bool &Handled)
{
  PutLogMessage("Accept Connection. Host: " + AConnection->PeerIP);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1Authenticate(TObject *Sender,
      TclSmtpCommandConnection *AConnection,
      TclMailUserAccountItem *&Account, const UnicodeString AUserName,
      bool &IsAuthorized, bool &Handled)
{
  if (Account != NULL) {
    PutLogMessage("Authenticate user: " + Account->UserName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1CloseConnection(TObject *Sender,
      TclUserConnection *AConnection)
{
  if (!FIsStop) {
    PutLogMessage("Close Connection. Host: " + AConnection->PeerIP);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1ReceiveCommand(TObject *Sender,
      TclCommandConnection *AConnection,
      TclTcpCommandParams *ACommandParams)
{
  PutLogMessage("Command: " + ACommandParams->Command + " " + ACommandParams->Parameters);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSmtpServer1SendResponse(TObject *Sender,
      TclCommandConnection *AConnection, const UnicodeString ACommand,
      const UnicodeString AResponse)
{
  PutLogMessage("Reply: " + AResponse);
}
//---------------------------------------------------------------------------

