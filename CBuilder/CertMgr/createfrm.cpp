//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "createfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TCreateCertForm *CreateCertForm;
//---------------------------------------------------------------------------
__fastcall TCreateCertForm::TCreateCertForm(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TCreateCertForm::FormCreate(TObject *)
{
  edtValidFrom->Text = DateToStr(Date());
  edtValidTo->Text = DateToStr(Date() + 365);
}
//---------------------------------------------------------------------------
UnicodeString __fastcall TCreateCertForm::BuildSubjectString()
{
  UnicodeString Result = "";
  if (edtCN->Text != "")
    Result += ",CN=" + edtCN->Text;
  if (edtOU->Text != "")
    Result += ",OU=" + edtOU->Text;
  if (edtO->Text != "")
    Result += ",O=" + edtO->Text;
  if (edtL->Text != "")
    Result += ",L=" + edtL->Text;
  if (edtC->Text != "")
    Result += ",C=" + edtC->Text;
  if (edtE->Text != "")
    Result += ",E=" + edtE->Text;
  if (Result != "")
    Result.Delete(1, 1);
  return Result;
}
//---------------------------------------------------------------------------

void __fastcall TCreateCertForm::cbAllClick(TObject *)
{
  FInProgress = true;
  if (cbAll->Checked) {
	cbServerAuth->Checked = false;
	cbClientAuth->Checked = false;
	cbCodeSigning->Checked = false;
	cbEmailProtection->Checked = false;
  }
  FInProgress = false;
}
//---------------------------------------------------------------------------

void __fastcall TCreateCertForm::cbServerAuthClick(TObject *)
{
  if (!FInProgress) {
	cbAll->Checked = false;
  }
}
//---------------------------------------------------------------------------

