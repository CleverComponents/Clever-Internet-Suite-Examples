//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
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
#include <clSmtpRelay.hpp>
#include <clTcpClient.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TLabel *Label4;
  TEdit *edtDNS;
  TLabel *Label5;
  TEdit *edtSender;
  TLabel *Label6;
  TEdit *edtRecipient;
  TLabel *Label7;
  TEdit *edtSubject;
  TLabel *Label8;
  TMemo *memText;
  TclSmtpRelay *clSmtpRelay1;
  TButton *btnSend;
  TclMailMessage *clMailMessage1;
  TLabel *Label9;
  TEdit *edtDNSTimeOut;
  void __fastcall btnSendClick(TObject *Sender);
private:	// User declarations
  void __fastcall ShowResults(void);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
