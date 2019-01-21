//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "certlistfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TCertListForm *CertListForm;
//---------------------------------------------------------------------------
__fastcall TCertListForm::TCertListForm(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TCertListForm::FillList()
{
  UnicodeString s;
  lbList->Items->Clear();
  for(int i = 0; i < FCertificates->Items->Count; i++)
  {
    s = FCertificates->Items->Items[i]->IssuedTo;
    if(FCertificates->Items->Items[i]->Email != "")
      s += " (" + FCertificates->Items->Items[i]->Email + ")";
    lbList->Items->Add(s);
  }
}
//---------------------------------------------------------------------------
void __fastcall TCertListForm::ShowCertificates(TclCertificateStore *AList)
{
  TCertListForm *dlg = new TCertListForm(NULL);
  __try
  {
    dlg->FCertificates = AList;
    dlg->FillList();
    dlg->ShowModal();
  }
  __finally
  {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TCertListForm::btnInstallClick(TObject *Sender)
{
  if(lbList->ItemIndex > -1)
  {
    FCertificates->Install(FCertificates->Items->Items[lbList->ItemIndex]);
    ShowMessage("The message certificate has been installed.");
  }
}
//---------------------------------------------------------------------------

void __fastcall TCertListForm::btnCloseClick(TObject *Sender)
{
  Close();
}
//---------------------------------------------------------------------------

