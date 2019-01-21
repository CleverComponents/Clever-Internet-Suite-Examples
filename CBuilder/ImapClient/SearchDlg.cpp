//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "SearchDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TSearchDialog *SearchDialog;
//---------------------------------------------------------------------------
__fastcall TSearchDialog::TSearchDialog(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TSearchDialog::FormCloseQuery(TObject *Sender,
      bool &CanClose)
{
  CanClose = (ModalResult != mrOk) || ((cbSearchIn->Text != "") && (edtSearchFor->Text != ""));
  if (!CanClose) {
    ShowMessage("The search conditions can not be empty");
  }
}
//---------------------------------------------------------------------------

UnicodeString __fastcall TSearchDialog::GetSearchCriteria(void)
{
  return cbSearchIn->Text + " " + edtSearchFor->Text;
}
//---------------------------------------------------------------------------


