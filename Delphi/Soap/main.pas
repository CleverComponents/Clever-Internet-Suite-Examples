unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clHttpRequest, clSoapMessage, clTcpClient, clHttp, clTranslator, msxml, clXmlUtils,
  clTcpClientTls, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    Label3: TLabel;
    btnStart: TButton;
    Label4: TLabel;
    edtLatitude: TEdit;
    clSoapMessage: TclSoapMessage;
    Label5: TLabel;
    clHttp1: TclHttp;
    edtAddress: TEdit;
    Label2: TLabel;
    edtLongitude: TEdit;
    procedure btnStartClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    procedure ExtractCoordinates(const AResponse: string);
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.ExtractCoordinates(const AResponse: string);
var
  dom: IXMLDomDocument;
  node: IXMLDOMNode;
begin
  dom := CoDOMDocument.Create();
  dom.loadXML(WideString(AResponse));

  node := dom.selectSingleNode('//geo:lat');
  if (node <> nil) then
  begin
    edtLatitude.Text := GetNodeText(node);
  end;

  node := dom.selectSingleNode('//geo:long');
  if (node <> nil) then
  begin
    edtLongitude.Text := GetNodeText(node);
  end;
end;

procedure TForm1.btnStartClick(Sender: TObject);
var
  msg, response: TStrings;
begin
  edtLatitude.Text := '';
  edtLongitude.Text := '';

  msg := TStringList.Create();
  response := TStringList.Create();
  try
    msg.Add('<?xml version="1.0" encoding="utf-8"?>');
    msg.Add('<SOAP-ENV:Envelope xmlns:SOAP-ENV="http://schemas.xmlsoap.org/soap/envelope/" SOAP-ENV:encodingStyle="http://schemas.xmlsoap.org/soap/encoding/">');
    msg.Add('<SOAP-ENV:Body><ns1:geocode xmlns:ns1="http://rpc.geocoder.us/Geo/Coder/US">');
    msg.Add('<location>' + TclTranslator.TranslateToUtf8(edtAddress.Text) + '</location>');
    msg.Add('</ns1:geocode></SOAP-ENV:Body></SOAP-ENV:Envelope>');

    clSoapMessage.BuildSoapMessage(msg, 'http://rpc.geocoder.us/Geo/Coder/US#geocode');

    clHttp1.Post('http://geocoder.us/service/soap', response);

    ExtractCoordinates(response.Text);
  finally
    response.Free();
    msg.Free();
  end;
end;

procedure TForm1.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 297;
 {$ENDIF}
end;

end.
