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
#include "clDkim.hpp"
#include "clMailMessage.hpp"
#include "clMC.hpp"
#include "clPop3.hpp"
#include "clTcpClient.hpp"
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
#include "clCryptUtils.hpp"
#include "clDkimUtils.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
	TLabel *Label1;
	TEdit *edtServer;
	TLabel *Label2;
	TEdit *edtPort;
	TLabel *Label4;
	TEdit *edtUser;
	TLabel *Label5;
	TEdit *edtPassword;
	TButton *btnCheckMail;
	TListBox *lbMessages;
	TLabel *Label3;
	TclMailMessage *clMailMessage1;
	TclDkim *clDkim1;
	TclPop3 *clPop31;
	void __fastcall btnCheckMailClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
