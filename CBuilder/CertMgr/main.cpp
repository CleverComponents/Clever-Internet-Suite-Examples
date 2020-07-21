//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "exportfrm.h"
#include "importfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clCertificate"
#pragma link "clCertificateStore"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::LoadCertificateList()
{
  lvCertificates->Items->Clear();

  TListItem *item;

  for (int i = 0; i < clCertificateStore1->Items->Count; i++) {
	item = lvCertificates->Items->Add();

	item->Data = clCertificateStore1->Items->Items[i];
	item->Caption = clCertificateStore1->Items->Items[i]->IssuedTo;
	item->SubItems->Add(clCertificateStore1->Items->Items[i]->IssuedBy);
	item->SubItems->Add(DateTimeToStr(clCertificateStore1->Items->Items[i]->ValidTo));
	item->SubItems->Add(clCertificateStore1->Items->Items[i]->FriendlyName);
	item->SubItems->Add(clCertificateStore1->Items->Items[i]->Email);
  }
  CheckButtonsState();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnLoadClick(TObject *)
{
  Clcryptapi::HCERTSTORE store;

  btnCloseClick(NULL);

  clCertificateStore1->Open(cbName->Text, (TclCertificateStoreLocation)cbLocation->ItemIndex);

  LoadCertificateList();
  FIsOpened = true;
  CheckButtonsState();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCloseClick(TObject *)
{
  clCertificateStore1->Close();
  LoadCertificateList();
  FIsOpened = false;
  CheckButtonsState();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnExportClick(TObject *)
{
  if (lvCertificates->Selected == NULL) return;

  TclCertificate *cert = (TclCertificate*)lvCertificates->Selected->Data;

  TExportForm *dlg = new TExportForm(NULL);
  __try {
    dlg->edtName->Text = cert->FriendlyName;
    if (dlg->edtName->Text == "")
    {
      dlg->edtName->Text = cert->IssuedTo;
    }

    if (dlg->ShowModal() == mrOk) {
      clCertificateStore1->ExportToPFX(cert, dlg->edtFileName->Text, dlg->edtPassword->Text, dlg->cbIncludeAll->Checked);
      ShowMessage("Done");
    }
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnImportClick(TObject *)
{
  if (!FIsOpened) return;

  TImportForm *dlg = new TImportForm(NULL);
  __try {
    dlg->edtStoreName->Text = cbLocation->Text + "; " + cbName->Text;

    if (dlg->ShowModal() == mrOk) {
      clCertificateStore1->ImportFromPFX(dlg->edtFileName->Text, dlg->edtPassword->Text);

      InstallCerts();
      btnLoadClick(NULL);
    }
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDeleteClick(TObject *)
{
  if (lvCertificates->Selected == NULL) return;

  TclCertificate *cert = (TclCertificate*)lvCertificates->Selected->Data;
  clCertificateStore1->Uninstall(cert);
  clCertificateStore1->Items->Remove(cert);

  btnLoadClick(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCreateSelfSignedClick(TObject *)
{
  if (!FIsOpened) return;

  TCreateCertForm *dlg = new TCreateCertForm(NULL);
  __try {
    dlg->edtStoreName->Text = cbLocation->Text + "; " + cbName->Text;

    if (dlg->ShowModal() == mrOk) {
      PrepareStore(dlg);

      TclCertificate *cert = clCertificateStore1->CreateSelfSigned(dlg->BuildSubjectString(), StrToInt(dlg->edtSerial->Text));
      clCertificateStore1->Items->Add(cert);
      cert->FriendlyName = dlg->edtFriendlyName->Text;

      InstallCerts();
      btnLoadClick(NULL);
    }
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
  cbLocation->ItemIndex = 0;
  cbName->ItemIndex = 0;
  Randomize();
  CheckButtonsState();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::CheckButtonsState()
{
  btnClose->Enabled = FIsOpened;
  btnSignRequest->Enabled = FIsOpened && (lvCertificates->Items->Count > 0);
  btnCreateSigned->Enabled = FIsOpened && (lvCertificates->Items->Count > 0);
  btnExport->Enabled = lvCertificates->Items->Count > 0;
  btnImport->Enabled = FIsOpened;
  btnDelete->Enabled = lvCertificates->Items->Count > 0;
  btnCreateSelfSigned->Enabled = FIsOpened;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCreateSignedClick(TObject *)
{
  if (lvCertificates->Selected == NULL) return;

  if (!FIsOpened) return;

  TCreateCertForm *dlg = new TCreateCertForm(NULL);
  __try
  {
    dlg->edtStoreName->Text = cbLocation->Text + "; " + cbName->Text;

    if (dlg->ShowModal() == mrOk)
    {
      PrepareStore(dlg);

      TclCertificate *issuer = (TclCertificate*)lvCertificates->Selected->Data;
      TclCertificate *cert = clCertificateStore1->CreateSigned(issuer, dlg->BuildSubjectString(), StrToInt(dlg->edtSerial->Text));
      clCertificateStore1->Items->Add(cert);
      cert->FriendlyName = dlg->edtFriendlyName->Text;

      InstallCerts();
      btnLoadClick(NULL);
    }
  }
  __finally
  {
    delete dlg;
  }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::InstallCerts()
{
  for (int i = 0; i < clCertificateStore1->Items->Count; i++) {
    if (!clCertificateStore1->IsInstalled(clCertificateStore1->Items->Items[i])) {
      clCertificateStore1->Install(clCertificateStore1->Items->Items[i]);
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::PrepareStore(TCreateCertForm *ADlg)
{
  clCertificateStore1->ValidFrom = StrToDateTime(ADlg->edtValidFrom->Text);
  clCertificateStore1->ValidTo = StrToDateTime(ADlg->edtValidTo->Text);
  clCertificateStore1->KeyName = ADlg->edtKeyName->Text;
  clCertificateStore1->KeyLength = StrToInt(ADlg->edtKeyLength->Text);

  clCertificateStore1->EnhancedKeyUsage->Clear();

  if (ADlg->cbServerAuth->Checked)
    clCertificateStore1->EnhancedKeyUsage->Add(szOID_PKIX_KP_SERVER_AUTH);
  if (ADlg->cbClientAuth->Checked)
    clCertificateStore1->EnhancedKeyUsage->Add(szOID_PKIX_KP_CLIENT_AUTH);
  if (ADlg->cbCodeSigning->Checked)
    clCertificateStore1->EnhancedKeyUsage->Add(szOID_PKIX_KP_CODE_SIGNING);
  if (ADlg->cbEmailProtection->Checked)
    clCertificateStore1->EnhancedKeyUsage->Add(szOID_PKIX_KP_EMAIL_PROTECTION);

  if (!clCertificateStore1->KeyExists(clCertificateStore1->KeyName))
    clCertificateStore1->CreateKey(clCertificateStore1->KeyName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSignRequestClick(TObject *)
{
  if (lvCertificates->Selected == NULL) return;

  if (!FIsOpened) return;

  if (OpenDialog1->Execute()) {
	TclCertificate *issuer = (TclCertificate*)lvCertificates->Selected->Data;

	TclCertificate *cert = clCertificateStore1->SignCSR(issuer, OpenDialog1->FileName, Random(MaxInt));
	clCertificateStore1->Items->Add(cert);

	InstallCerts();
	btnLoadClick(NULL);
  }
}
//---------------------------------------------------------------------------

