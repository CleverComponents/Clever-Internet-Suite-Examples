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
#pragma link "clXmlUtils"
#pragma link "clTcpClient"
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

String __fastcall TForm1::ExtractResponse(const String AResponse, const String AXPath)
{
#if (__CODEGEARC__ >= 0x0640) // C++Builder XE2 and later
  _di_IXMLDOMDocument dom = CoDOMDocument::Create();
  unsigned short res = 0;
  dom->loadXML((wchar_t *)(WideString)AResponse, (short *)res);

  IXMLDOMNode *node = NULL;
  dom->selectSingleNode((wchar_t *)(WideString)AXPath, &node);
#else
  _di_IXMLDOMDocument dom = CoDOMDocument::Create();
  unsigned short res = 0;
  dom->loadXML((WideString)AResponse, res);

  _di_IXMLDOMNode node = NULL;
  dom->selectSingleNode((WideString)AXPath, node);
#endif

  if (node != NULL)
  {
	return GetNodeText(node);
  }
  return "";
}

//---------------------------------------------------------------------------

void __fastcall TForm1::btnC2FClick(TObject *Sender)
{
  edtFahrenheit->Text = "";

  if (rbUseSoapWsdl->Checked)
  {
	TStrings *paramNames = new TStringList();
	TStrings *paramValues = new TStringList();
	__try
	{
	  paramNames->Add("Celsius");
	  paramValues->Add(edtCelsius->Text);

	  clSoapMessage1->BuildSoapWSDL(
		"https://www.w3schools.com/xml/",
		"CelsiusToFahrenheit",
		paramNames,
		paramValues);
	}
	__finally
	{
	  delete paramValues;
	  delete paramNames;
	}
  }
  else
  {
	String request = String("") +
	  "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
	  "<soap12:Envelope xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">" +
	  "  <soap12:Body>" +
	  "    <CelsiusToFahrenheit xmlns=\"https://www.w3schools.com/xml/\">" +
	  "      <Celsius>" + edtCelsius->Text + "</Celsius>" +
	  "    </CelsiusToFahrenheit>" +
	  "  </soap12:Body>" +
	  "</soap12:Envelope>";

	clSoapMessage1->BuildSoapMessage(request);
  }

  String response = clHttp1->Post("https://www.w3schools.com/xml/tempconvert.asmx", clSoapMessage1);

  edtFahrenheit->Text = ExtractResponse(response, "//CelsiusToFahrenheitResult");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnF2CClick(TObject *Sender)
{
  edtCelsius->Text = "";

  if (rbUseSoapWsdl->Checked)
  {
	TStrings *paramNames = new TStringList();
	TStrings *paramValues = new TStringList();
	__try
	{
	  paramNames->Add("Fahrenheit");
	  paramValues->Add(edtFahrenheit->Text);

	  clSoapMessage1->BuildSoapWSDL(
		"https://www.w3schools.com/xml/",
		"FahrenheitToCelsius",
		paramNames,
		paramValues);
	}
	__finally
	{
	  delete paramValues;
	  delete paramNames;
	}
  }
  else
  {
	String request = String("") +
	  "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
	  "<soap12:Envelope xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">" +
	  "  <soap12:Body>" +
	  "    <FahrenheitToCelsius xmlns=\"https://www.w3schools.com/xml/\">" +
	  "      <Fahrenheit>" + edtFahrenheit->Text + "</Fahrenheit>" +
	  "    </FahrenheitToCelsius>" +
	  "  </soap12:Body>" +
	  "</soap12:Envelope>";

	clSoapMessage1->BuildSoapMessage(request);
  }

  String response = clHttp1->Post("https://www.w3schools.com/xml/tempconvert.asmx", clSoapMessage1);

  edtCelsius->Text = ExtractResponse(response, "//FahrenheitToCelsiusResult");
}
//---------------------------------------------------------------------------


