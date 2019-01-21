//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "MessageForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
//---------------------------------------------------------------------------
__fastcall TclMessageForm::TclMessageForm(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------

bool __fastcall TclMessageForm::PostNew(TclMailMessage *Article)
{
  bool res;
  TclMessageForm *dlg = new TclMessageForm(NULL);
  __try
  {
    res = (dlg->ShowModal() == mrOk);
    if(res)
    {
      Article->BuildMessage(dlg->memText->Lines->Text, "");
      Article->Subject = dlg->edtSubject->Text;
      Article->From->FullAddress = dlg->edtFrom->Text;
    }
  }
  __finally
  {
    delete dlg;
  }
  return res;
}
//---------------------------------------------------------------------------

bool __fastcall TclMessageForm::ReplyTo(TclMailMessage *Article)
{
  bool res;
  TclMessageForm *dlg = new TclMessageForm(NULL);
  TStrings *src = new TStringList();
  TStrings *refs = new TStringList();
  __try
  {
    src->Assign(Article->MessageText);
    for(int i = 0; i < src->Count; i++)
      src->Strings[i] = "> " + src->Strings[i];
    src->Insert(0, "");
    src->Insert(0, "");
    dlg->memText->Lines->Assign(src);

    if(Article->Subject.Pos("Re:") != 1)
      dlg->edtSubject->Text = "Re: " + Article->Subject;

    refs->Assign(Article->References);

    dlg->btnPost->Caption = "Reply";

    res = (dlg->ShowModal() == mrOk);
    if(res)
    {
      Article->BuildMessage(dlg->memText->Lines->Text, "");
      Article->Subject = dlg->edtSubject->Text;
      Article->From->FullAddress = dlg->edtFrom->Text;
      Article->References->Assign(refs);
    }
  }
  __finally
  {
    delete refs;
    delete src;
    delete dlg;
  }
  return res;
}
//---------------------------------------------------------------------------

