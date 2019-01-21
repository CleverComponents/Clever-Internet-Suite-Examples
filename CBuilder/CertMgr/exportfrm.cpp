//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "exportfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TExportForm *ExportForm;
//---------------------------------------------------------------------------
__fastcall TExportForm::TExportForm(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------
