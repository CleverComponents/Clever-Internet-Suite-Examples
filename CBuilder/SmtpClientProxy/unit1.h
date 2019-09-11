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
#include <clHttpProxy.hpp>
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
    TButton *btnSend;
    TclSmtp *clSmtp1;
    TclMailMessage *clMailMessage1;
	TLabel *Label8;
	TLabel *Label9;
	TEdit *edtProxyServer;
	TEdit *edtProxyPort;
	TclHttpProxy *clHttpProxy1;
  void __fastcall btnSendClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
