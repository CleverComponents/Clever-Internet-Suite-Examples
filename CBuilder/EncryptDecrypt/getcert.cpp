//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "getcert.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TGetCertDialog *GetCertDialog;

//---------------------------------------------------------------------------
__fastcall TGetCertDialog::TGetCertDialog(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TGetCertDialog::FormCreate(TObject *Sender)
{
  edtEmail->Text = DefaultEmail;
}
//---------------------------------------------------------------------------

void __fastcall TGetCertDialog::FormDestroy(TObject *Sender)
{
  DefaultEmail = edtEmail->Text;
}
//---------------------------------------------------------------------------
