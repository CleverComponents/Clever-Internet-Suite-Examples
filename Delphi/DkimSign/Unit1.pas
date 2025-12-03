unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMailMessage, clTcpClient, clTcpClientTls, clMC, clSmtp, clCertificate,
  clTcpCommandClient, clDkim, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtServer: TEdit;
    Label2: TLabel;
    edtPort: TEdit;
    Label3: TLabel;
    edtUser: TEdit;
    Label4: TLabel;
    edtPassword: TEdit;
    Label5: TLabel;
    edtFrom: TEdit;
    Label6: TLabel;
    edtTo: TEdit;
    Label7: TLabel;
    edtSubject: TEdit;
    memBody: TMemo;
    btnSend: TButton;
    clSmtp1: TclSmtp;
    clMailMessage1: TclMailMessage;
    Label8: TLabel;
    edtDkimDomain: TEdit;
    Label9: TLabel;
    edtDkimSelector: TEdit;
    clDkim1: TclDkim;
    Label10: TLabel;
    memPrivateKey: TMemo;
    btnLoadKey: TButton;
    btnGenerateKey: TButton;
    Label12: TLabel;
    edtDnsTxtValue: TEdit;
    OpenDialog1: TOpenDialog;
    Label11: TLabel;
    edtSignFields: TEdit;
    Label13: TLabel;
    edtDnsTxtName: TEdit;
    procedure btnSendClick(Sender: TObject);
    procedure btnLoadKeyClick(Sender: TObject);
    procedure btnGenerateKeyClick(Sender: TObject);
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

procedure TForm1.btnGenerateKeyClick(Sender: TObject);
begin
  clDkim1.Domain := edtDkimDomain.Text;
  clDkim1.Selector := edtDkimSelector.Text;

  clDkim1.GenerateSigningKey(512);

  clDkim1.ExportPrivateKey(memPrivateKey.Lines);

  clDkim1.GenerateDnsRecord();

  edtDnsTxtName.Text := clDkim1.DnsRecord.Name;
  edtDnsTxtValue.Text := clDkim1.DnsRecord.Value;
end;

procedure TForm1.btnLoadKeyClick(Sender: TObject);
begin
  if (OpenDialog1.Execute()) then
  begin
    clDkim1.ImportPrivateKey(OpenDialog1.FileName);

    memPrivateKey.Lines.LoadFromFile(OpenDialog1.FileName);

    edtDnsTxtName.Text := '';
    edtDnsTxtValue.Text := '';
  end;
end;

procedure TForm1.btnSendClick(Sender: TObject);
begin
  if (clSmtp1.Active) then Exit;

  clDkim1.Domain := edtDkimDomain.Text;
  clDkim1.Selector := edtDkimSelector.Text;
  clDkim1.SignedHeaderFields.CommaText := edtSignFields.Text;

  clDkim1.ImportPrivateKey(memPrivateKey.Lines);

  clMailMessage1.BuildMessage(memBody.Text, '');
  clMailMessage1.From.FullAddress := edtFrom.Text;
  clMailMessage1.ToList.EmailAddresses := edtTo.Text;
  clMailMessage1.Subject := edtSubject.Text;

  clSmtp1.Server := edtServer.Text;
  clSmtp1.Port := StrToInt(edtPort.Text);

  clSmtp1.UserName := edtUser.Text;
  clSmtp1.Password := edtPassword.Text;

  clSmtp1.Open();
  try
    clSmtp1.Send(clMailMessage1);
  finally
    clSmtp1.Close();
  end;

  ShowMessage('The signed message was sent successfully.');
end;

procedure TForm1.FormShow(Sender: TObject);
begin
  edtSignFields.Text := clDkim1.SignedHeaderFields.CommaText;
end;

end.
