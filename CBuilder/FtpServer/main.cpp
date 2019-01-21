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
#pragma link "clTcpCommandServer"
#pragma link "clServerGuard"
#pragma link "clTcpServerTls"
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
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  delete FSynchronizer;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  clServerGuard1->ConnectionLimit->Max = StrToInt(edtAllowedConnections->Text);
  clServerGuard1->ConnectionLimit->Period = 60000; //1 minute
  clServerGuard1->BlackIPList->Assign(memBlackList->Lines);
  clServerGuard1->WhiteIPList->Assign(memWhiteList->Lines);
  clServerGuard1->AllowWhiteListOnly = cbWhiteListOnly->Checked;

  clServerGuard1->Reset();

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


