//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clHtmlParser"
#pragma link "clHttp"
#pragma link "clTcpClient"
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

    clHttp1->FirewallSettings->Server = "";
    clHttp1->ProxySettings->Server = "";

    if (cbProxyType->ItemIndex == 0) {
      clHttp1->ProxySettings->Server = edtProxyServer->Text;
      clHttp1->ProxySettings->Port = StrToInt(edtProxyPort->Text);
      clHttp1->ProxySettings->UserName = edtProxyUser->Text;
      clHttp1->ProxySettings->Password = edtProxyPassword->Text;
    }
    else {
      if (cbProxyType->ItemIndex == 1) {
        clHttp1->FirewallSettings->FirewallType = ftSocks4;
      }
      else {
        clHttp1->FirewallSettings->FirewallType = ftSocks5;
      }

      clHttp1->FirewallSettings->Server = edtProxyServer->Text;
      clHttp1->FirewallSettings->Port = StrToInt(edtProxyPort->Text);
      clHttp1->FirewallSettings->UserName = edtProxyUser->Text;
      clHttp1->FirewallSettings->Password = edtProxyPassword->Text;
    }

    clHttp1->Get(edtUrl->Text, html);

    if (cbShowText->Checked)
      clHtmlParser1->Parse(html);
    else
      memResult->Lines->Assign(html);
  }
  __finally {
    delete html;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clHtmlParser1ParseTag(TObject *Sender,
      TclHtmlTag *ATag)
{
  if (Trim(ATag->Text) != "")
    memResult->Lines->Add(ATag->Text);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::cbProxyTypeChange(TObject *Sender)
{
  switch (cbProxyType->ItemIndex) {
    case 0: edtProxyPort->Text = "8080"; break;
    case 1:
    case 2: edtProxyPort->Text = "1080"; break;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
  cbProxyType->ItemIndex = 0;
}
//---------------------------------------------------------------------------

