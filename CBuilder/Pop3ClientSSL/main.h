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
#include <clMailMessage.hpp>
#include <clMC.hpp>
#include <clPop3.hpp>
#include <clTcpClient.hpp>
#include <ComCtrls.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtServer;
  TEdit *edtPort;
  TEdit *edtUser;
  TEdit *edtPassword;
  TButton *btnConnect;
  TCheckBox *cbUseTLS;
  TListView *lvMessages;
  TLabel *Label3;
  TLabel *Label6;
  TLabel *Label7;
  TEdit *edtFrom;
  TEdit *edtSubject;
  TMemo *memBody;
  TButton *btnDelete;
  TclPop3 *clPop;
  TclMailMessage *clMailMessage;
  TButton *btnDisconnect;
  TButton *btnView;
  void __fastcall btnConnectClick(TObject *Sender);
  void __fastcall btnDisconnectClick(TObject *Sender);
  void __fastcall btnViewClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall clPopVerifyServer(TObject *Sender,
          TclCertificate *ACertificate, const UnicodeString AStatusText,
          int AStatusCode, bool &AVerified);
private:	// User declarations
  bool FCertificateVerified;
  void __fastcall FillMessages(void);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
