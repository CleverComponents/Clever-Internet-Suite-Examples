//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clPop3FileHandler"
#pragma link "clPop3Server"
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


void __fastcall TMainForm::FormCreate(TObject *Sender)
{
  FSynchronizer = new TCriticalSection();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  delete FSynchronizer;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  clPop3Server1->Port = StrToInt(edtPort->Text);
  clPop3FileHandler1->MailBoxDir = edtRootDir->Text;
  ForceFileDirectories(AddTrailingBackSlash(clPop3FileHandler1->MailBoxDir));
  ForceFileDirectories(AddTrailingBackSlash(clPop3FileHandler1->MailBoxDir) + "CleverTester\\");
  clPop3Server1->Start();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStopClick(TObject *Sender)
{
  FIsStop = true;
  __try {
    clPop3Server1->Stop();
  }
  __finally {
    FIsStop = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1Start(TObject *Sender)
{
  PutLogMessage("==================\r\nStart Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1Stop(TObject *Sender)
{
  PutLogMessage("Stop Server");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1AcceptConnection(TObject *Sender,
      TclUserConnection *AConnection, bool &Handled)
{
  PutLogMessage("Accept Connection. Host: " + AConnection->PeerIP);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1Authenticate(TObject *Sender,
      TclPop3CommandConnection *AConnection,
      TclMailUserAccountItem *&Account, const UnicodeString AUserName,
      bool &IsAuthorized, bool &Handled)
{
  if (Account != NULL) {
    PutLogMessage("Authenticate user: " + Account->UserName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1CloseConnection(TObject *Sender,
      TclUserConnection *AConnection)
{
  if (!FIsStop) {
    PutLogMessage("Close Connection. Host: " + AConnection->PeerIP);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1ReceiveCommand(TObject *Sender,
      TclCommandConnection *AConnection,
      TclTcpCommandParams *ACommandParams)
{
  PutLogMessage("Command: " + ACommandParams->Command + " " + ACommandParams->Parameters);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clPop3Server1SendResponse(TObject *Sender,
      TclCommandConnection *AConnection, const UnicodeString ACommand,
      const UnicodeString AResponse)
{
  PutLogMessage("Reply: " + AResponse);
}
//---------------------------------------------------------------------------

