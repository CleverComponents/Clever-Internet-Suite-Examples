//---------------------------------------------------------------------------

#ifndef unit1H
#define unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clMailMessage.hpp>
#include <clMC.hpp>
#include <clSmtp.hpp>
#include <clTcpClient.hpp>
#include <ComCtrls.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clTcpClientTls.hpp>
#include <clTcpCommandClient.hpp>
#include <clOAuth.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
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
    TclOAuth *clOAuth1;
	TButton *btnCancel;
  void __fastcall btnSendClick(TObject *Sender);
	void __fastcall btnCancelClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
