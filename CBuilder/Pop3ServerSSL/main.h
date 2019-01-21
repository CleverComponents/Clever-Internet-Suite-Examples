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
#include <clPop3FileHandler.hpp>
#include <clPop3Server.hpp>
#include <clTcpServer.hpp>
#include <clCertificateStore.hpp>
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
  TLabel *Label6;
  TLabel *Label7;
  TclPop3FileHandler *clPop3FileHandler1;
  TclPop3Server *clPop3Server1;
  TComboBox *cbUseTls;
  TclCertificateStore *clCertificateStore1;
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall clPop3Server1Start(TObject *Sender);
  void __fastcall clPop3Server1Stop(TObject *Sender);
        void __fastcall clPop3Server1AcceptConnection(TObject *Sender,
          TclUserConnection *AConnection, bool &Handled);
        void __fastcall clPop3Server1Authenticate(TObject *Sender,
          TclPop3CommandConnection *AConnection,
          TclMailUserAccountItem *&Account, const UnicodeString AUserName,
          bool &IsAuthorized, bool &Handled);
        void __fastcall clPop3Server1CloseConnection(TObject *Sender,
          TclUserConnection *AConnection);
        void __fastcall clPop3Server1GetCertificate(TObject *Sender,
          TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
          bool &Handled);
        void __fastcall clPop3Server1ReceiveCommand(TObject *Sender,
          TclCommandConnection *AConnection,
          TclTcpCommandParams *ACommandParams);
        void __fastcall clPop3Server1SendResponse(TObject *Sender,
          TclCommandConnection *AConnection, const UnicodeString ACommand,
          const UnicodeString AResponse);
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
