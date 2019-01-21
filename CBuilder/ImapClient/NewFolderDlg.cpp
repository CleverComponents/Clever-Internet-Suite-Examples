//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "NewFolderDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TNewFolderDialog *NewFolderDialog;
//---------------------------------------------------------------------------
__fastcall TNewFolderDialog::TNewFolderDialog(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TNewFolderDialog::FormCloseQuery(TObject *Sender,
      bool &CanClose)
{
  CanClose = (ModalResult != mrOk) || (edtName->Text != "");
  if (!CanClose) {
    ShowMessage("The value can not be empty");
  }
}
//---------------------------------------------------------------------------

