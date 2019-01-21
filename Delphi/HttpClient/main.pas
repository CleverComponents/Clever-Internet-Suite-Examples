unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, clTcpClient, clHttp, clHtmlParser, clTcpClientTls, DemoBaseFormUnit;

type
  TForm1 = class(TclDemoBaseForm)
    Panel1: TPanel;
    memResult: TMemo;
    Label1: TLabel;
    edtUrl: TEdit;
    Label2: TLabel;
    Button1: TButton;
    clHttp1: TclHttp;
    clHtmlParser1: TclHtmlParser;
    cbShowText: TCheckBox;
    procedure Button1Click(Sender: TObject);
    procedure clHtmlParser1ParseTag(Sender: TObject; ATag: TclHtmlTag);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var
  html: TStrings;
begin
  memResult.Lines.Clear();

  html := TStringList.Create();
  try
    clHttp1.Get(edtUrl.Text, html);

    if cbShowText.Checked then
    begin
      clHtmlParser1.Parse(html);
    end else
    begin
      memResult.Lines.Assign(html);
    end;
  finally
    html.Free();
  end;
end;

procedure TForm1.clHtmlParser1ParseTag(Sender: TObject; ATag: TclHtmlTag);
begin
  if (Trim(ATag.Text) <> '') then
  begin
    memResult.Lines.Add(ATag.Text);
  end;
end;

end.
