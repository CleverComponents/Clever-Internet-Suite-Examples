//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "CopyDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TCopyDialog *CopyDialog;
//---------------------------------------------------------------------------
__fastcall TCopyDialog::TCopyDialog(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

UnicodeString __fastcall TCopyDialog::ShowCopyDialog(TStrings *AFolders)
{
  UnicodeString res = "";
  
  TCopyDialog *dlg = new TCopyDialog(NULL);
  __try {
    dlg->cbFolder->Items = AFolders;
    if (dlg->cbFolder->Items->Count > 0) {
      dlg->cbFolder->ItemIndex = 0;
    }

    if (dlg->ShowModal() == mrOk) {
      res = dlg->cbFolder->Items->Strings[dlg->cbFolder->ItemIndex];
    }
  }
  __finally {
    delete dlg;
  }

  return res;
}
//---------------------------------------------------------------------------
