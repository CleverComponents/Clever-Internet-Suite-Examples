unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics,
  Controls, Forms, Dialogs, StdCtrls, clHttpRequest,
  DemoBaseFormUnit, clSoapMessage, clTcpClient, clTcpClientTls, clHttp, msxml,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    clHttp1: TclHttp;
    clSoapMessage1: TclSoapMessage;
    btnC2F: TButton;
    edtCelsius: TEdit;
    edtFahrenheit: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    btnF2C: TButton;
    Label3: TLabel;
    rbUseSoapWsdl: TRadioButton;
    rbUseSoapXml: TRadioButton;
    procedure btnC2FClick(Sender: TObject);
    procedure btnF2CClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnC2FClick(Sender: TObject);
var
  request, response: string;
  dom: IXMLDomDocument;
  node: IXMLDOMNode;
begin
  edtFahrenheit.Text := '';

  if (rbUseSoapWsdl.Checked) then
  begin
    clSoapMessage1.BuildSoapWSDL(
      'https://www.w3schools.com/xml/',
      'CelsiusToFahrenheit',
      ['Celsius'], [edtCelsius.Text]);
  end else
  begin
    request :=
      '<?xml version="1.0" encoding="utf-8"?>' +
      '<soap12:Envelope xmlns:soap12="http://www.w3.org/2003/05/soap-envelope">' +
      '  <soap12:Body>' +
      '    <CelsiusToFahrenheit xmlns="https://www.w3schools.com/xml/">' +
      '      <Celsius>' + edtCelsius.Text + '</Celsius>' +
      '    </CelsiusToFahrenheit>' +
      '  </soap12:Body>' +
      '</soap12:Envelope>';

    clSoapMessage1.BuildSoapMessage(request);
  end;

  response := clHttp1.Post('https://www.w3schools.com/xml/tempconvert.asmx', clSoapMessage1);

  dom := CoDOMDocument.Create();
  dom.loadXML(WideString(response));

  node := dom.selectSingleNode('//CelsiusToFahrenheitResult');
  if (node <> nil) then
  begin
    edtFahrenheit.Text := string(node.text);
  end;
end;

procedure TForm1.btnF2CClick(Sender: TObject);
var
  request, response: string;
  dom: IXMLDomDocument;
  node: IXMLDOMNode;
begin
  edtCelsius.Text := '';

  if (rbUseSoapWsdl.Checked) then
  begin
    clSoapMessage1.BuildSoapWSDL(
      'https://www.w3schools.com/xml/',
      'FahrenheitToCelsius',
      ['Fahrenheit'], [edtFahrenheit.Text]);
  end else
  begin
    request :=
      '<?xml version="1.0" encoding="utf-8"?>' +
      '<soap12:Envelope xmlns:soap12="http://www.w3.org/2003/05/soap-envelope">' +
      '  <soap12:Body>' +
      '    <FahrenheitToCelsius xmlns="https://www.w3schools.com/xml/">' +
      '      <Fahrenheit>' + edtFahrenheit.Text + '</Fahrenheit>' +
      '    </FahrenheitToCelsius>' +
      '  </soap12:Body>' +
      '</soap12:Envelope>';

    clSoapMessage1.BuildSoapMessage(request);
  end;

  response := clHttp1.Post('https://www.w3schools.com/xml/tempconvert.asmx', clSoapMessage1);

  dom := CoDOMDocument.Create();
  dom.loadXML(WideString(response));

  node := dom.selectSingleNode('//FahrenheitToCelsiusResult');
  if (node <> nil) then
  begin
    edtCelsius.Text := string(node.text);
  end;
end;

procedure TForm1.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 294;
 {$ENDIF}
end;

end.
