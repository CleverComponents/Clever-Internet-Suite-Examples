//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include "ExtCtrls.hpp"
#include "Graphics.hpp"
#include "clDkim.hpp"
#include "clMailMessage.hpp"
#include "clMC.hpp"
#include "clSmtp.hpp"
#include "clTcpClient.hpp"
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
#include <Dialogs.hpp>
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
	TEdit *edtDkimDomain;
	TLabel *Label9;
	TEdit *edtDkimSelector;
	TclDkim *clDkim1;
	TLabel *Label10;
	TMemo *memPrivateKey;
	TButton *btnLoadKey;
	TButton *btnGenerateKey;
	TLabel *Label12;
	TEdit *edtDnsTxtValue;
	TOpenDialog *OpenDialog1;
	TLabel *Label11;
	TEdit *edtSignFields;
	TLabel *Label13;
	TEdit *edtDnsTxtName;
	void __fastcall FormShow(TObject *Sender);
	void __fastcall btnLoadKeyClick(TObject *Sender);
	void __fastcall btnGenerateKeyClick(TObject *Sender);
	void __fastcall btnSendClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
