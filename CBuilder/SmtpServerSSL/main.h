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
#include <clSmtpFileHandler.hpp>
#include <clSmtpServer.hpp>
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
  TEdit *edtMailboxDir;
  TLabel *Label5;
  TclSmtpServer *clSmtpServer1;
  TclSmtpFileHandler *clSmtpFileHandler1;
  TLabel *Label6;
  TEdit *edtRelayDir;
  TCheckBox *cbUseLogin;
  TclCertificateStore *clCertificateStore1;
  TLabel *Label7;
  TComboBox *cbUseTls;
  TLabel *Label4;
  TLabel *Label8;
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall clSmtpServer1Start(TObject *Sender);
  void __fastcall clSmtpServer1Stop(TObject *Sender);
        void __fastcall clSmtpServer1AcceptConnection(TObject *Sender,
          TclUserConnection *AConnection, bool &Handled);
        void __fastcall clSmtpServer1Authenticate(TObject *Sender,
          TclSmtpCommandConnection *AConnection,
          TclMailUserAccountItem *&Account, const UnicodeString AUserName,
          bool &IsAuthorized, bool &Handled);
        void __fastcall clSmtpServer1CloseConnection(TObject *Sender,
          TclUserConnection *AConnection);
        void __fastcall clSmtpServer1GetCertificate(TObject *Sender,
          TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
          bool &Handled);
        void __fastcall clSmtpServer1ReceiveCommand(TObject *Sender,
          TclCommandConnection *AConnection,
          TclTcpCommandParams *ACommandParams);
        void __fastcall clSmtpServer1SendResponse(TObject *Sender,
          TclCommandConnection *AConnection, const UnicodeString ACommand,
          const UnicodeString AResponse);
private:	// User declarations
  TCriticalSection *FSynchronizer;
  bool FIsStop;
  void __fastcall PutLogMessage(const UnicodeString ALogMessage);
  UnicodeString __fastcall GetSettingsFile();
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
