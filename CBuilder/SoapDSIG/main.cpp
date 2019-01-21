//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clHttpRequest"
#pragma link "clSoapMessage"
#pragma link "clCertificateStore"
#pragma link "clSoapMessage"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnSignClick(TObject *Sender)
{
  clSoapMessage->BuildSoapMessage(memSource->Lines, "");

  clSoapMessage->Signatures->Clear();
  TclSoapSignatureInfo* sig = clSoapMessage->Signatures->Add();

  for (int i = 0; i < memReferences->Lines->Count; i++) {
	  sig->References->Add(memReferences->Lines->Strings[i]);
  }

  clSoapMessage->Sign();
  memResult->Lines->Assign(clSoapMessage->RequestSource);
}
//---------------------------------------------------------------------------


void __fastcall TForm1::btnBrowseClick(TObject *Sender)
{
  if(OpenDialog->Execute())
    edtCertFile->Text = OpenDialog->FileName;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::clSoapMessageGetSigningCertificate(TObject *Sender,
      TclXmlKeyInfo *AKeyInfo, TclCertificate *&ACertificate,
      TclCertificateList *AExtraCerts, bool &Handled)
{
  clCertificateStore->ImportFromPFX(edtCertFile->Text, edtCertPassword->Text);
  ACertificate = clCertificateStore->Items->Items[0];
}
//---------------------------------------------------------------------------


