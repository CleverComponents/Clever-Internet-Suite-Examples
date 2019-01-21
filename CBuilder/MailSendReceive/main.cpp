//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "msgfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clPop3"
#pragma link "clSmtp"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma link "clTcpCommandClient"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnCheckMailClick(TObject *Sender)
{
  if (clPOP31->Active) return;

  clPOP31->Server = edtPop3Server->Text;
  clPOP31->UserName = edtUser->Text;
  clPOP31->Password = edtPassword->Text;

  int count;
  clPOP31->Open();
  __try {
    lbMessages->Items->Clear();

    count = clPOP31->MessageCount;
    for (int i = 1; i <= count; i++) {
      clPOP31->RetrieveHeader(i, clMailMessage1);
      if (clMailMessage1->Subject == "")
        lbMessages->Items->Add(clMailMessage1->From->FullAddress);
      else
        lbMessages->Items->Add(clMailMessage1->Subject);
    }
  }
  __finally {
    clPOP31->Close();
  }

  ShowMessage(Format("Collecting completed, %d messages in the mailbox", ARRAYOFCONST((count))));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnComposeMailClick(TObject *Sender)
{
  if (clSMTP1->Active) return;


  TMessageForm *dlg = new TMessageForm(NULL);
  __try {
	dlg->edtFrom->Text = edtUser->Text;

	if (dlg->ShowModal() == mrOk) {
      clMailMessage1->BuildMessage(dlg->memBody->Lines->Text, "");
      clMailMessage1->From->FullAddress = dlg->edtFrom->Text;
      clMailMessage1->ToList->EmailAddresses = dlg->edtTo->Text;
      clMailMessage1->Subject = dlg->edtSubject->Text;

      dlg->btnSend->Enabled = true;

      clSMTP1->Server = edtSmtpServer->Text;
      clSMTP1->UserName = edtUser->Text;
      clSMTP1->Password = edtPassword->Text;

      clSMTP1->Open();
      __try {
        clSMTP1->Send(clMailMessage1);
      }
      __finally {
        clSMTP1->Close();
      }

      ShowMessage("The message was sent successfully");
    }
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::lbMessagesDblClick(TObject *Sender)
{
  if (clPOP31->Active || (lbMessages->ItemIndex < 0)) return;

  clPOP31->Server = edtPop3Server->Text;
  clPOP31->UserName = edtUser->Text;
  clPOP31->Password = edtPassword->Text;

  clPOP31->Open();
  TMessageForm *dlg = new TMessageForm(NULL);
  __try {
    clPOP31->Retrieve(lbMessages->ItemIndex + 1, clMailMessage1);

    dlg->edtFrom->Text = clMailMessage1->From->FullAddress;
    dlg->edtTo->Text = Trim(clMailMessage1->ToList->EmailAddresses);
    dlg->edtSubject->Text = clMailMessage1->Subject;

    dlg->memBody->Lines = clMailMessage1->MessageText;

    dlg->edtFrom->ReadOnly = true;
    dlg->edtTo->ReadOnly = true;
    dlg->edtSubject->ReadOnly = true;
    dlg->memBody->ReadOnly = true;
    dlg->btnSend->Enabled = false;

    dlg->ShowModal();
  }
  __finally {
    delete dlg;
    clPOP31->Close();
  }
}
//---------------------------------------------------------------------------

