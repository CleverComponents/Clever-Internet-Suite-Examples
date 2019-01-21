unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clDnsQuery, clUdpClient, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtDnsServer: TEdit;
    Label2: TLabel;
    cbNameType: TComboBox;
    Label3: TLabel;
    Label4: TLabel;
    edtTimeOut: TEdit;
    edtName: TEdit;
    btnResolve: TButton;
    clDnsQuery1: TclDnsQuery;
    Label5: TLabel;
    memResult: TMemo;
    Label6: TLabel;
    edtPort: TEdit;
    procedure btnResolveClick(Sender: TObject);
  private
    procedure FillMXResult;
    procedure FillHostResult;
    procedure FillNameServerResult;
    procedure FillAliasResult;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnResolveClick(Sender: TObject);
begin
  clDnsQuery1.Server := edtDnsServer.Text;
  clDnsQuery1.Port := StrToInt(edtPort.Text);
  clDnsQuery1.TimeOut := StrToInt(edtTimeOut.Text) * 1000;

  case cbNameType.ItemIndex of
    0: clDnsQuery1.ResolveMX(edtName.Text);
    1: clDnsQuery1.ResolveIP(edtName.Text);
    2: clDnsQuery1.ResolveHost(edtName.Text);
    3: clDnsQuery1.ResolveNS(edtName.Text);
  end;

  edtDnsServer.Text := clDnsQuery1.Server;

  memResult.Lines.Clear();

  FillMXResult();
  FillHostResult();
  FillNameServerResult();
  FillAliasResult();

  ShowMessage('Done');
end;

procedure TForm1.FillMXResult;
var
  i: Integer;
  mx: TclMailServerInfo;
begin
  if (clDnsQuery1.MailServers.Count = 0) then Exit;

  memResult.Lines.Add('====== Mail Servers ======');

  for i := 0 to clDnsQuery1.MailServers.Count - 1 do
  begin
    mx := clDnsQuery1.MailServers[i];
    memResult.Lines.Add(Format('%s, Preference %d, %s', [mx.Name, mx.Preference, mx.IPAddress]));
  end;

  memResult.Lines.Add('');
end;

procedure TForm1.FillHostResult;
var
  i: Integer;
begin
  if (clDnsQuery1.Hosts.Count = 0) then Exit;

  memResult.Lines.Add('====== Hosts ======');

  for i := 0 to clDnsQuery1.Hosts.Count - 1 do
  begin
    memResult.Lines.Add(clDnsQuery1.Hosts[i].Name + ', ' + clDnsQuery1.Hosts[i].IPAddress);
  end;

  memResult.Lines.Add('');
end;

procedure TForm1.FillNameServerResult;
begin
  if (clDnsQuery1.NameServers.Count = 0) then Exit;

  memResult.Lines.Add('====== Name Servers ======');
  memResult.Lines.AddStrings(clDnsQuery1.NameServers);
  memResult.Lines.Add('');
end;

procedure TForm1.FillAliasResult;
begin
  if (clDnsQuery1.Aliases.Count = 0) then Exit;

  memResult.Lines.Add('====== Aliases ======');
  memResult.Lines.AddStrings(clDnsQuery1.Aliases);
  memResult.Lines.Add('');
end;

end.
