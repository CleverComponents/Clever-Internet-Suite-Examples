//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clFtpServer.hpp>
#include <clTcpServer.hpp>
#include <clFtpFileHandler.hpp>
#include <clCertificateStore.hpp>
#include <clTcpCommandServer.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
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
  TclFtpServer *clFtpServer1;
  TLabel *Label3;
  TEdit *edtRootDir;
  TclFtpFileHandler *clFtpFileHandler1;
  TclCertificateStore *clCertificateStore1;
  TLabel *Label4;
  TLabel *Label5;
  TLabel *Label6;
  TComboBox *cbUseTls;
  TLabel *Label7;
  void __fastcall clFtpServer1Start(TObject *Sender);
  void __fastcall clFtpServer1Stop(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
        void __fastcall clFtpServer1AcceptConnection(TObject *Sender,
          TclUserConnection *AConnection, bool &Handled);
        void __fastcall clFtpServer1Authenticate(TObject *Sender,
          TclFtpCommandConnection *AConnection,
          TclFtpUserAccountItem *&Account, const UnicodeString AUserName,
          const UnicodeString APassword, bool &IsAuthorized, bool &Handled);
        void __fastcall clFtpServer1CloseConnection(TObject *Sender,
          TclUserConnection *AConnection);
        void __fastcall clFtpServer1GetCertificate(TObject *Sender,
          TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
          bool &Handled);
        void __fastcall clFtpServer1ReceiveCommand(TObject *Sender,
          TclCommandConnection *AConnection,
          TclTcpCommandParams *ACommandParams);
        void __fastcall clFtpServer1SendResponse(TObject *Sender,
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
