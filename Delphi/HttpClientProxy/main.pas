unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, clTcpClient, clHttp, clHtmlParser, clFirewallUtils,
  clTcpClientTls, DemoBaseFormUnit;

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
    Label3: TLabel;
    edtUser: TEdit;
    Label4: TLabel;
    edtPassword: TEdit;
    Bevel1: TBevel;
    Label5: TLabel;
    edtProxyServer: TEdit;
    Label6: TLabel;
    edtProxyPort: TEdit;
    Label7: TLabel;
    edtProxyUser: TEdit;
    Label8: TLabel;
    edtProxyPassword: TEdit;
    cbProxyType: TComboBox;
    Label9: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure clHtmlParser1ParseTag(Sender: TObject; ATag: TclHtmlTag);
    procedure cbProxyTypeChange(Sender: TObject);
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
    clHttp1.UserName := edtUser.Text;
    clHttp1.Password := edtPassword.Text;

    clHttp1.FirewallSettings.Server := '';
    clHttp1.ProxySettings.Server := '';

    if cbProxyType.ItemIndex = 0 then
    begin
      clHttp1.ProxySettings.Server := edtProxyServer.Text;
      clHttp1.ProxySettings.Port := StrToInt(edtProxyPort.Text);
      clHttp1.ProxySettings.UserName := edtProxyUser.Text;
      clHttp1.ProxySettings.Password := edtProxyPassword.Text;
    end else
    begin
      if cbProxyType.ItemIndex = 1 then
      begin
        clHttp1.FirewallSettings.FirewallType := ftSocks4;
      end else
      begin
        clHttp1.FirewallSettings.FirewallType := ftSocks5;
      end;

      clHttp1.FirewallSettings.Server := edtProxyServer.Text;
      clHttp1.FirewallSettings.Port := StrToInt(edtProxyPort.Text);
      clHttp1.FirewallSettings.UserName := edtProxyUser.Text;
      clHttp1.FirewallSettings.Password := edtProxyPassword.Text;
    end;

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

procedure TForm1.cbProxyTypeChange(Sender: TObject);
begin
  case cbProxyType.ItemIndex of
    0: edtProxyPort.Text := '8080';
    1, 2: edtProxyPort.Text := '1080';
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
