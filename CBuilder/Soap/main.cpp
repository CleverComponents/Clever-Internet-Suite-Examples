//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include <clXmlUtils.hpp>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clHttpRequest"
#pragma link "clSoapMessage"
#pragma link "clHttp"
#pragma link "clTcpClient"
#pragma link "clXmlUtils"
#pragma link "clSoapMessage"
#pragma link "clTcpClientTls"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnStartClick(TObject *Sender)
{
  edtLatitude->Text = "";
  edtLongitude->Text = "";

  TStrings *msg = new TStringList();
  TStrings *response = new TStringList();
  __try {
    msg->Add("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
    msg->Add("<SOAP-ENV:Envelope xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\" SOAP-ENV:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">");
    msg->Add("<SOAP-ENV:Body><ns1:geocode xmlns:ns1=\"http://rpc.geocoder.us/Geo/Coder/US\">");
	msg->Add("<location>" + TclTranslator::TranslateToUtf8(edtAddress->Text) + "</location>");
    msg->Add("</ns1:geocode></SOAP-ENV:Body></SOAP-ENV:Envelope>");

    clSoapMessage->BuildSoapMessage(msg, "http://rpc.geocoder.us/Geo/Coder/US#geocode");

    clHttp1->Post("http://geocoder.us/service/soap", response);

    ExtractCoordinates(response->Text);
  }
  __finally {
	delete response;
	delete msg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ExtractCoordinates(const UnicodeString AResponse)
{
#if (__CODEGEARC__ >= 0x0640) // C++Builder XE2 and later
  _di_IXMLDOMDocument dom = CoDOMDocument::Create();
  unsigned short res = 0;
  dom->loadXML((wchar_t *)(WideString)AResponse, (short *)res);

  IXMLDOMNode *node = NULL;
  dom->selectSingleNode((wchar_t *)"//geo:lat", &node);
  if (node != NULL) {
	edtLatitude->Text = GetNodeText(node);
  }

  node = NULL;
  dom->selectSingleNode((wchar_t *)"//geo:long", &node);
  if (node != NULL) {
	edtLongitude->Text = GetNodeText(node);
  }
#else
  _di_IXMLDOMDocument dom = CoDOMDocument::Create();
  unsigned short res = 0;
  dom->loadXML((WideString)AResponse, res);

  _di_IXMLDOMNode node = NULL;
  dom->selectSingleNode("//geo:lat", node);
  if (node != NULL) {
	edtLatitude->Text = GetNodeText(node);
  }

  node = NULL;
  dom->selectSingleNode("//geo:long", node);
  if (node != NULL) {
	edtLongitude->Text = GetNodeText(node);
  }
#endif
}
//---------------------------------------------------------------------------

