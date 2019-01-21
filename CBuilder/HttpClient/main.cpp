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


