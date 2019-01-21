//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "getcert.h"
#include "certlistfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clSMimeMessage"
#pragma link "clCertificateStore"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnAddClick(TObject *Sender)
{
  if(OpenAttach->Execute())
    lbAttachments->Items->Add(OpenAttach->FileName);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnClearClick(TObject *Sender)
{
  lbAttachments->Items->Clear();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnEncryptClick(TObject *Sender)
{
  if(SaveDialog->Execute())
  {
    BuildMessage();
    clSMimeMessage->Encrypt();
    clSMimeMessage->MessageSource->SaveToFile(SaveDialog->FileName);
    ShowMessage("The encrypted message is saved to " + SaveDialog->FileName);
  }
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::btnNewMessageClick(TObject *Sender)
{
  NewMessage();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnSignClick(TObject *Sender)
{
  if(SaveDialog->Execute())
  {
    BuildMessage();
    clSMimeMessage->Sign();
    clSMimeMessage->MessageSource->SaveToFile(SaveDialog->FileName);
    ShowMessage("The signed message is saved to " + SaveDialog->FileName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnSignEncryptClick(TObject *Sender)
{
  if(SaveDialog->Execute())
  {
    BuildMessage();
    clSMimeMessage->Sign();
    clSMimeMessage->Encrypt();
    clSMimeMessage->MessageSource->SaveToFile(SaveDialog->FileName);
    ShowMessage("The encrypted and signed message is saved to " + SaveDialog->FileName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnVerifyClick(TObject *Sender)
{
  if(OpenDialog->Execute())
  {
    NewMessage();
    TStrings *msg = new TStringList();
    __try
    {
      msg->LoadFromFile(OpenDialog->FileName);
      clSMimeMessage->MessageSource = msg;
      clSMimeMessage->Verify();
      FillControls();
      ShowMessage("The signed message " + OpenDialog->FileName + " is verified.");
    }
    __finally
    {
      delete msg;
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDecryptClick(TObject *Sender)
{
  if(OpenDialog->Execute())
  {
    NewMessage();
    TStrings *msg = new TStringList();
    __try
    {
      msg->LoadFromFile(OpenDialog->FileName);
      clSMimeMessage->MessageSource = msg;
      clSMimeMessage->Decrypt();
      FillControls();
      ShowMessage("The encrypted message " + OpenDialog->FileName + " is decrypted.");
    }
    __finally
    {
      delete msg;
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnVerifyDecryptClick(TObject *Sender)
{
  if(OpenDialog->Execute())
  {
    NewMessage();
    TStrings *msg = new TStringList();
    __try
    {
      msg->LoadFromFile(OpenDialog->FileName);
      clSMimeMessage->MessageSource = msg;
      clSMimeMessage->DecryptAndVerify();
      FillControls();
      ShowMessage("The secured message " + OpenDialog->FileName + " is decrypted and verified.");
    }
    __finally
    {
      delete msg;
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::cbDetachedSignatureClick(TObject *Sender)
{
  clSMimeMessage->IsDetachedSignature = cbDetachedSignature->Checked;
  clSMimeMessage->IsIncludeCertificate = cbIncludeCertificate->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCreate(TObject *Sender)
{
  edtFrom->Text = DefaultEmail;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::BuildMessage()
{
  clSMimeMessage->BuildMessage(memText->Lines->Text, memHtml->Lines->Text, NULL, lbAttachments->Items);
  clSMimeMessage->From->FullAddress = edtFrom->Text;
  clSMimeMessage->ToList->EmailAddresses = edtToList->Text;
  clSMimeMessage->Subject = edtSubject->Text;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FillControls()
{
  edtFrom->Text = clSMimeMessage->From->FullAddress;
  clSMimeMessage->ToList->EmailAddresses = edtToList->Text;
  edtSubject->Text = clSMimeMessage->Subject;

  memText->Lines->Clear();
  if (clSMimeMessage->Text != NULL) {
	memText->Lines = clSMimeMessage->Text->Strings;
  }

  memHtml->Lines->Clear();
  if (clSMimeMessage->Html != NULL) {
	memHtml->Lines = clSMimeMessage->Html->Strings;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::NewMessage()
{
  edtFrom->Text = DefaultEmail;
  edtToList->Text = "";
  edtSubject->Text = "";
  memText->Lines->Clear();
  memHtml->Lines->Clear();
  memHtml->Lines->Add("<html>");
  memHtml->Lines->Add("<body>");
  memHtml->Lines->Add("</body>");
  memHtml->Lines->Add("</html>");
  lbAttachments->Items->Clear();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnViewCertificatesClick(TObject *Sender)
{
  TCertListForm::ShowCertificates(clSMimeMessage->Certificates);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSMimeMessageGetEncryptionCertificate(
      TObject *Sender, TclCertificate *&ACertificate,
      TclCertificateList *AExtraCerts, bool &Handled)
{
  TGetCertDialog *dlg = new TGetCertDialog(NULL);
  __try
  {
	dlg->Caption = "Get encryption certificate";
    dlg->edtEmail->Text = edtToList->Text;

    if(dlg->ShowModal() == mrOk)
    {
      clCertificateStore->Open(dlg->edtStore->Text);
      ACertificate = clCertificateStore->CertificateByEmail(dlg->edtEmail->Text);
      Handled = true;
    }
  }
  __finally
  {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSMimeMessageGetSigningCertificate(TObject *Sender,
      TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
      bool &Handled)
{
  TGetCertDialog *dlg = new TGetCertDialog(NULL);
  __try
  {
	dlg->Caption = "Get signing certificate";
	dlg->edtEmail->Text = edtFrom->Text;

    if(dlg->ShowModal() == mrOk)
    {
      clCertificateStore->Open(dlg->edtStore->Text);
      ACertificate = clCertificateStore->CertificateByEmail(dlg->edtEmail->Text);
      Handled = true;
    }
  }
  __finally
  {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clSMimeMessageSaveAttachment(TObject *Sender,
      TclAttachmentBody *ABody, UnicodeString &AFileName, TStream *&AData,
      bool &Handled)
{
  AData = new TMemoryStream();
  Handled = true;
  if(AFileName != "")
	lbAttachments->Items->Add(AFileName);
}
//---------------------------------------------------------------------------

