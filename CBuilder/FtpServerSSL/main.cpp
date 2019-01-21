//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clFtpServer"
#pragma link "clTcpServer"
#pragma link "clFtpFileHandler"
#pragma link "clCertificateStore"
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

void __fastcall TMainForm::clFtpServer1Start(TObject *Sender)
{
  PutLogMessage("==================\r\nStart Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFtpServer1Stop(TObject *Sender)
{
  PutLogMessage("Stop Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCreate(TObject *Sender)
{
  FSynchronizer = new TCriticalSection();
  cbUseTls->ItemIndex = 1;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  delete FSynchronizer;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  clFtpServer1->UseTLS = (TclServerTlsMode)cbUseTls->ItemIndex;
  clFtpServer1->Port = StrToInt(edtPort->Text);
  clFtpServer1->RootDir = edtRootDir->Text;
  ForceFileDirectories(AddTrailingBackSlash(clFtpServer1->RootDir));
  clFtpServer1->Start();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStopClick(TObject *Sender)
{
  FIsStop = true;
  __try {
    clFtpServer1->Stop();
  }
  __finally {
    FIsStop = false;
  }
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

void __fastcall TMainForm::clFtpServer1AcceptConnection(TObject *Sender,
      TclUserConnection *AConnection, bool &Handled)
{
  PutLogMessage("Accept Connection. Host: " + AConnection->PeerIP);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFtpServer1Authenticate(TObject *Sender,
      TclFtpCommandConnection *AConnection,
      TclFtpUserAccountItem *&Account, const UnicodeString AUserName,
      const UnicodeString APassword, bool &IsAuthorized, bool &Handled)
{
  if (Account != NULL) {
    PutLogMessage("Authenticate user: " + Account->UserName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFtpServer1CloseConnection(TObject *Sender,
      TclUserConnection *AConnection)
{
  if (!FIsStop) {
    PutLogMessage("Close Connection. Host: " + AConnection->PeerIP);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFtpServer1GetCertificate(TObject *Sender,
      TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
      bool &Handled)
{
  if (clCertificateStore1->Items->Count == 0) {
    clCertificateStore1->ValidFrom = Now();
    clCertificateStore1->ValidTo = Now() + 365;
    ACertificate = clCertificateStore1->CreateSelfSigned("CN=CleverTester,O=CleverComponents,E=CleverTester@company.mail", 0);
    clCertificateStore1->Items->Add(ACertificate);
  }
  ACertificate = clCertificateStore1->Items->Items[0];
  Handled = true;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFtpServer1ReceiveCommand(TObject *Sender,
      TclCommandConnection *AConnection,
      TclTcpCommandParams *ACommandParams)
{
  PutLogMessage("Command: " + ACommandParams->Command + " " + ACommandParams->Parameters);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clFtpServer1SendResponse(TObject *Sender,
      TclCommandConnection *AConnection, const UnicodeString ACommand,
      const UnicodeString AResponse)
{
  PutLogMessage("Reply: " + AResponse);
}
//---------------------------------------------------------------------------


