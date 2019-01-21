//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "fileDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFileExistsDialog *FileExistsDialog;
//---------------------------------------------------------------------------
__fastcall TFileExistsDialog::TFileExistsDialog(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------

int __fastcall TFileExistsDialog::ShowFileDialog(const UnicodeString AFileName)
{
  int result;
  TFileExistsDialog *dlg = new TFileExistsDialog(NULL);
  __try
  {
    dlg->lblCaption->Caption = Format("File already exists %s", ARRAYOFCONST((AFileName)));
    result = dlg->ShowModal();
  }
  __finally
  {
    delete dlg;
  }
  return result;
}
//---------------------------------------------------------------------------

