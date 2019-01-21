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
#include <ExtCtrls.hpp>
#include "clTcpClientTls.hpp"
#include "DemoBaseFormUnit.h"
#include <Graphics.hpp>
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
  TBevel *Bevel1;
  TLabel *Label5;
  TEdit *edtProxyServer;
  TLabel *Label6;
  TEdit *edtProxyPort;
  TLabel *Label7;
  TEdit *edtProxyUser;
  TLabel *Label8;
  TEdit *edtProxyPassword;
  TComboBox *cbProxyType;
  TLabel *Label9;
  void __fastcall Button1Click(TObject *Sender);
  void __fastcall clHtmlParser1ParseTag(TObject *Sender, TclHtmlTag *ATag);
        void __fastcall cbProxyTypeChange(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
