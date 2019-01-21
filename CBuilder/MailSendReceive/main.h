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
#include <clSmtp.hpp>
#include <clTcpClient.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtPop3Server;
  TLabel *Label2;
  TEdit *edtUser;
  TLabel *Label3;
  TEdit *edtPassword;
  TclSmtp *clSMTP1;
  TclPop3 *clPOP31;
  TclMailMessage *clMailMessage1;
  TButton *btnComposeMail;
  TButton *btnCheckMail;
  TListBox *lbMessages;
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtSmtpServer;
  void __fastcall btnCheckMailClick(TObject *Sender);
  void __fastcall btnComposeMailClick(TObject *Sender);
  void __fastcall lbMessagesDblClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
