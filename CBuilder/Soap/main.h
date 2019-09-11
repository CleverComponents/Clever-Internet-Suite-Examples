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
#include <clHttpRequest.hpp>
#include <clSoapMessage.hpp>
#include <clHttp.hpp>
#include <clTcpClient.hpp>
#include "clSoapMessage.hpp"
#include "clTcpClientTls.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TclHttp *clHttp1;
  TclSoapMessage *clSoapMessage1;
  TButton *btnC2F;
  TEdit *edtCelsius;
  TEdit *edtFahrenheit;
  TLabel *Label1;
  TLabel *Label2;
  TButton *btnF2C;
  TLabel *Label3;
  TRadioButton *rbUseSoapWsdl;
  TRadioButton *rbUseSoapXml;
	void __fastcall btnC2FClick(TObject *Sender);
	void __fastcall btnF2CClick(TObject *Sender);
private:	// User declarations
  String __fastcall ExtractResponse(const String AResponse, const String AXPath);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
