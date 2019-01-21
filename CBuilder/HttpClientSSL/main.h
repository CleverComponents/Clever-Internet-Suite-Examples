//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clHtmlParser.hpp>
#include <clHttp.hpp>
#include <clTcpClient.hpp>
#include <clTranslator.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clCertificateStore.hpp>
#include "clTcpClientTls.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TPanel *Panel1;
  TMemo *memResult;
  TLabel *Label1;
  TEdit *edtUrl;
  TLabel *Label2;
  TButton *Button1;
  TclHttp *clHttp1;
  TclHtmlParser *clHtmlParser1;
  TCheckBox *cbShowText;
  TLabel *Label3;
  TEdit *edtUser;
  TLabel *Label4;
  TEdit *edtPassword;
  TclCertificateStore *clCertificateStore1;
  void __fastcall Button1Click(TObject *Sender);
  void __fastcall clHtmlParser1ParseTag(TObject *Sender, TclHtmlTag *ATag);
  void __fastcall clHttp1VerifyServer(TObject *Sender,
          TclCertificate *ACertificate, const UnicodeString AStatusText,
          int AStatusCode, bool &AVerified);
private:	// User declarations
  bool __fastcall ViewCertificate(TclCertificate *ACertificate);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
