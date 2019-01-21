//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "newDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TNewDialog *NewDialog;
//---------------------------------------------------------------------------
__fastcall TNewDialog::TNewDialog(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TNewDialog::FormCloseQuery(TObject *, bool &CanClose)
{
  CanClose = (edtName->Text != "") || (ModalResult == mrCancel);
  if(!CanClose)
    ShowMessage("The value can not be empty");
}
//---------------------------------------------------------------------------

UnicodeString __fastcall TNewDialog::ShowNewDialog(const UnicodeString ACaption, const UnicodeString AValue)
{
  UnicodeString result = "";
  TNewDialog *dlg = new TNewDialog(NULL);
  __try
  {
    dlg->Caption = ACaption;
    dlg->lblName->Caption = ACaption;
    dlg->edtName->Text = AValue;
    if(dlg->ShowModal() == mrOk)
      result = dlg->edtName->Text;
  }
  __finally
  {
    delete dlg;
  }
  return result;
}
//---------------------------------------------------------------------------

