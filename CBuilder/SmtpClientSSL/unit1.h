//---------------------------------------------------------------------------

#ifndef unit1H
#define unit1H
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
#include <clSmtp.hpp>
#include <clTcpClient.hpp>
#include <ComCtrls.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TLabel *Label1;
    TEdit *edtServer;
    TLabel *Label2;
    TEdit *edtPort;
    TLabel *Label3;
    TEdit *edtUser;
    TLabel *Label4;
    TEdit *edtPassword;
    TLabel *Label5;
    TEdit *edtFrom;
    TLabel *Label6;
    TEdit *edtTo;
    TLabel *Label7;
    TEdit *edtSubject;
    TMemo *memBody;
    TCheckBox *cbUseTLS;
    TButton *btnSend;
    TclSmtp *clSmtp1;
    TclMailMessage *clMailMessage1;
  void __fastcall btnSendClick(TObject *Sender);
  void __fastcall clSmtp1VerifyServer(TObject *Sender,
          TclCertificate *ACertificate, const UnicodeString AStatusText,
          int AStatusCode, bool &AVerified);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
