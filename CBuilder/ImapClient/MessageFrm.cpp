//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "MessageFrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TMessageForm *MessageForm;
//---------------------------------------------------------------------------
__fastcall TMessageForm::TMessageForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMessageForm::ShowMessage(TclMailMessage *AMsg)
{
  TMessageForm *dlg = new TMessageForm(NULL);
  __try {
    dlg->btnAppend->Visible = false;
    dlg->btnCancel->Caption = "Close";

    dlg->edtFrom->ReadOnly = true;
    dlg->edtTo->ReadOnly = true;
    dlg->edtSubject->ReadOnly = true;
    dlg->memBody->ReadOnly = true;

    dlg->edtFrom->Color = clWindow;
    dlg->edtTo->Color = clWindow;
    dlg->edtSubject->Color = clWindow;
    dlg->memBody->Color = clWindow;

    dlg->edtFrom->Text = AMsg->From->FullAddress;
    dlg->edtTo->Text = AMsg->ToList->EmailAddresses;
    dlg->edtSubject->Text = AMsg->Subject;
    dlg->memBody->Lines = AMsg->MessageText;

    dlg->ShowModal();
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

bool __fastcall TMessageForm::ComposeMessage(TclMailMessage *AMsg)
{
  bool res = false;
  TMessageForm *dlg = new TMessageForm(NULL);
  __try {
    dlg->btnAppend->Visible = true;
    dlg->btnCancel->Caption = "Cancel";

    dlg->edtFrom->ReadOnly = false;
    dlg->edtTo->ReadOnly = false;
    dlg->edtSubject->ReadOnly = false;
    dlg->memBody->ReadOnly = false;

    dlg->edtFrom->Text = "clevertester@company.mail";
    dlg->edtTo->Text = "clevertester@company.mail";
    dlg->edtSubject->Text = "Test Subject";
    dlg->memBody->Text = "Test Body";

    res = (dlg->ShowModal() == mrOk);

    if (res) {
      AMsg->BuildMessage(dlg->memBody->Lines->Text, "");
      AMsg->From->FullAddress = dlg->edtFrom->Text;
      AMsg->ToList->EmailAddresses = dlg->edtTo->Text;
      AMsg->Subject = dlg->edtSubject->Text;
    }
  }
  __finally {
    delete dlg;
  }
  return res;
}
