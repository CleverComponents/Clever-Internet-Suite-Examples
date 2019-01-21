//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clImap4FileHandler.hpp>
#include <clImap4Server.hpp>
#include <clTcpServer.hpp>
#include <clTcpCommandServer.hpp>
#include "clTcpServerTls.hpp"
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnStart;
  TButton *btnStop;
  TMemo *memLog;
  TEdit *edtPort;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *edtRootDir;
  TLabel *Label4;
  TLabel *Label5;
  TclImap4FileHandler *clImap4FileHandler1;
  TclImap4Server *clImap4Server1;
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
        void __fastcall clImap4Server1AcceptConnection(TObject *Sender,
          TclUserConnection *AConnection, bool &Handled);
        void __fastcall clImap4Server1Authenticate(TObject *Sender,
          TclImap4CommandConnection *AConnection,
          TclMailUserAccountItem *&Account, const UnicodeString AUserName,
          bool &IsAuthorized, bool &Handled);
        void __fastcall clImap4Server1CloseConnection(TObject *Sender,
          TclUserConnection *AConnection);
        void __fastcall clImap4Server1ReceiveCommand(TObject *Sender,
          TclCommandConnection *AConnection,
          TclTcpCommandParams *ACommandParams);
        void __fastcall clImap4Server1SendResponse(TObject *Sender,
          TclCommandConnection *AConnection, const UnicodeString ACommand,
          const UnicodeString AResponse);
        void __fastcall clImap4Server1Start(TObject *Sender);
        void __fastcall clImap4Server1Stop(TObject *Sender);
private:	// User declarations
  TCriticalSection *FSynchronizer;
  bool FIsStop;
  void __fastcall PutLogMessage(const UnicodeString ALogMessage);
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
