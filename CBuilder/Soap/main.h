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
  TLabel *Label1;
  TLabel *Label3;
  TButton *btnStart;
  TLabel *Label4;
  TEdit *edtLatitude;
  TclSoapMessage *clSoapMessage;
  TLabel *Label5;
  TclHttp *clHttp1;
  TEdit *edtAddress;
  TLabel *Label2;
  TEdit *edtLongitude;
  void __fastcall btnStartClick(TObject *Sender);
private:	// User declarations
  void __fastcall ExtractCoordinates(const UnicodeString AResponse);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
