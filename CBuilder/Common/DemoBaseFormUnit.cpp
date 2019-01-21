//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "DemoBaseFormUnit.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TclDemoBaseForm *clDemoBaseForm;
//---------------------------------------------------------------------------
__fastcall TclDemoBaseForm::TclDemoBaseForm(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------

AnsiString TclDemoBaseForm::GetLink()
{
  return "https://www.clevercomponents.com/support/index.asp";
}

//---------------------------------------------------------------------------
void __fastcall TclDemoBaseForm::imLogoLeftClick(TObject *Sender)
{
  AnsiString s = GetLink();  //use AnsiString
  ShellExecute(0, "open", s.c_str(), NULL, NULL, SW_RESTORE);
}
//---------------------------------------------------------------------------


