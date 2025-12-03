//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "login.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TLoginConfirmation *LoginConfirmation;
//---------------------------------------------------------------------------
__fastcall TLoginConfirmation::TLoginConfirmation(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------

bool __fastcall TLoginConfirmation::ShowConfirmation(const UnicodeString  AClientID, const UnicodeString AScope)
{
  bool result = false;
  TLoginConfirmation *dlg = new TLoginConfirmation(NULL);
  __try
  {
    dlg->edtClientID->Text = AClientID;
    dlg->edtScope->Text = AScope;

    result = (dlg->ShowModal() == mrOk);
  }
  __finally
  {
    delete dlg;
  }

  return result;
}
//---------------------------------------------------------------------------

