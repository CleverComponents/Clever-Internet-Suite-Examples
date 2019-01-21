//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "unit1.h"
#include "getcert.h"
#include "certlistfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clCertificateStore"
#pragma link "clHttpRequest"
#pragma link "clSoapMessage"
#pragma link "clXmlUtils"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSignEncryptClick(TObject *Sender)
{
  if (!SaveDialog1->Execute()) return;

  FSecuring = true;

  memSOAPMessage->Lines->Clear();

  clSoapMessage1->BuildSoapWSDL(edtMethodURI->Text, edtMethod->Text, memWSDLParams->Lines, memWSDLParamValues->Lines);
  clSoapMessage1->BodyID = edtBodyID->Text;

  clSoapMessage1->Timestamp->Created = edtTimestampCreated->Text;
  clSoapMessage1->Timestamp->Expires = edtTimeStampExpires->Text;
  clSoapMessage1->Timestamp->ID = edtTimeStampID->Text;

  clSoapMessage1->Addressing->Clear();
  clSoapMessage1->Addressing->AddItem(edtAddressName->Text, edtAddressID->Text, edtAddressValue->Text);

  clSoapMessage1->Signatures->Clear();
  TclSoapSignatureInfo* sig = clSoapMessage1->Signatures->Add();
  sig->References->Add(Id2UriReference(clSoapMessage1->Timestamp->ID));
  sig->References->Add(Id2UriReference(clSoapMessage1->BodyID));

  clSoapMessage1->EncryptedKey->References->Clear();
  clSoapMessage1->EncryptedKey->References->Add(Id2UriReference(clSoapMessage1->BodyID));

  clSoapMessage1->Sign();
  clSoapMessage1->Encrypt();

  clSoapMessage1->SaveRequest(SaveDialog1->FileName);
  ShowMessage("The signed and encrypted message was saved to " + SaveDialog1->FileName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDecryptVerifyClick(TObject *Sender)
{
  if (!OpenDialog1->Execute()) return;

  FSecuring = false;

  clSoapMessage1->Clear();

  memSOAPMessage->Lines->Clear();

  edtMethodURI->Text = "";
  edtMethod->Text = "";
  memWSDLParams->Lines->Clear();
  memWSDLParamValues->Lines->Clear();
  edtBodyID->Text = "";

  edtTimestampCreated->Text = "";
  edtTimeStampExpires->Text = "";
  edtTimeStampID->Text = "";

  edtAddressName->Text = "";
  edtAddressID->Text = "";
  edtAddressValue->Text = "";

  clSoapMessage1->LoadRequest(OpenDialog1->FileName);

  clSoapMessage1->Decrypt();
  clSoapMessage1->Verify();

  edtBodyID->Text = clSoapMessage1->BodyID;

  edtTimestampCreated->Text = clSoapMessage1->Timestamp->Created;
  edtTimeStampExpires->Text = clSoapMessage1->Timestamp->Expires;
  edtTimeStampID->Text = clSoapMessage1->Timestamp->ID;

  if (clSoapMessage1->Addressing->Count > 0) {
    edtAddressName->Text = clSoapMessage1->Addressing->Items[0]->Name;
	edtAddressID->Text = clSoapMessage1->Addressing->Items[0]->ID;
	edtAddressValue->Text = clSoapMessage1->Addressing->Items[0]->Value;
  }

  memSOAPMessage->Lines = clSoapMessage1->RequestSource;

  ShowMessage("The signed and encrypted message " + OpenDialog1->FileName + " was decrypted and verified.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCertificatesClick(TObject *Sender)
{
  TCertListForm::ShowCertificates(clSoapMessage1->Certificates);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clSoapMessage1GetEncryptionCertificate(TObject *Sender,
	  TclXmlKeyInfo *AKeyInfo, TclCertificate *&ACertificate,
	  TclCertificateList *AExtraCerts, UnicodeString &AStoreName,
	  TclCertificateStoreLocation &AStoreLocation, bool &Handled)
{
  TGetCertDialog *dlg = new TGetCertDialog(NULL);
  __try {
	if (FSecuring)
	  dlg->Caption = "Get recipient's public certificate";
	else
	  dlg->Caption = "Get own certificate with private key";
	dlg->btnMessage->Enabled = false;

	if (dlg->ShowModal() == mrOk) {
	  clCertificateStore1->Open(dlg->edtStore->Text);
	  ACertificate = clCertificateStore1->CertificateByEmail(dlg->edtEmail->Text);
	  AStoreName = dlg->edtStore->Text;
	  AStoreLocation = slCurrentUser;
	  Handled = true;
	}
  }
  __finally {
	delete dlg;
  }
}
//---------------------------------------------------------------------------


void __fastcall TForm1::clSoapMessage1GetSigningCertificate(TObject *Sender,
	  TclXmlKeyInfo *AKeyInfo, TclCertificate *&ACertificate,
	  TclCertificateList *AExtraCerts, bool &Handled)
{
  TGetCertDialog *dlg = new TGetCertDialog(NULL);
  __try {
	if (FSecuring) {
	  dlg->Caption = "Get own certificate with private key";
	  dlg->btnMessage->Enabled = false;
	}
	else {
	  dlg->Caption = "Get recipient's public certificate";
	  dlg->btnMessage->Enabled = true;
	}

	if (dlg->ShowModal() == mrOk) {
	  clCertificateStore1->Open(dlg->edtStore->Text);
	  ACertificate = clCertificateStore1->CertificateByEmail(dlg->edtEmail->Text);
	}
	Handled = true;
  }
  __finally {
	delete dlg;
  }
  //
}
//---------------------------------------------------------------------------

