//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "importfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TImportForm *ImportForm;
//---------------------------------------------------------------------------
__fastcall TImportForm::TImportForm(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------
