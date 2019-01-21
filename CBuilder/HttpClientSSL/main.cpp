//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "certfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clHtmlParser"
#pragma link "clHttp"
#pragma link "clTcpClient"
#pragma link "clCertificateStore"
#pragma link "clTranslator"
#pragma link "clTcpClientTls"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
  memResult->Lines->Clear();

  TStrings *html = new TStringList();
  __try {
    clHttp1->UserName = edtUser->Text;
    clHttp1->Password = edtPassword->Text;

    clHttp1->Get(edtUrl->Text, html);

    if (cbShowText->Checked) {
      clHtmlParser1->Parse(html);
    }
    else {
      if (SameText("UTF-8", clHttp1->ResponseHeader->CharSet)) {
      memResult->Lines->Text = TclTranslator::TranslateFromUtf8(html->Text);
      }
      else {
        memResult->Lines->Assign(html);
      }
    }
  }
  __finally {
    delete html;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clHtmlParser1ParseTag(TObject *Sender,
      TclHtmlTag *ATag)
{
  if (Trim(ATag->Text) != "") {
    if (SameText("UTF-8", clHttp1->ResponseHeader->CharSet)) {
      memResult->Lines->Add(TclTranslator::TranslateFromUtf8(ATag->Text));
    }
    else {
      memResult->Lines->Add(ATag->Text);
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clHttp1VerifyServer(TObject *Sender,
      TclCertificate *ACertificate, const UnicodeString AStatusText,
      int AStatusCode, bool &AVerified)
{
  if (!AVerified && (MessageDlg(AStatusText + "\r\n Do you wish to view / install the certificate ?",
    mtWarning, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)) {
    if (ViewCertificate(ACertificate))
      AVerified = true;
  }
}
//---------------------------------------------------------------------------

bool __fastcall TForm1::ViewCertificate(TclCertificate *ACertificate)
{
  bool Result;
  TCertForm *dlg = new TCertForm(NULL);
  __try {
    dlg->edtName->Text = ACertificate->FriendlyName;
    dlg->edtIssuedTo->Text = ACertificate->IssuedTo;
    dlg->edtIssuedBy->Text = ACertificate->IssuedBy;
    dlg->edtValidFrom->Text = DateTimeToStr(ACertificate->ValidFrom);
    dlg->edtValidTo->Text = DateTimeToStr(ACertificate->ValidTo);

    dlg->ShowModal();
    Result = (dlg->ModalResult == mrOk) || (dlg->ModalResult == mrYes);

    if (dlg->ModalResult == mrYes) {
      TclCertificate *newInstance = clCertificateStore1->Items->AddFrom(ACertificate);
      clCertificateStore1->StoreName = "CA";
      clCertificateStore1->Install(newInstance);
      ShowMessage("The certificate was installed successfully to Intermediate " \
        "Certification Authorities (CA).\r\nPress OK to continue.");
    }
  }
  __finally {
    delete dlg;
  }
  return Result;
}
//---------------------------------------------------------------------------

