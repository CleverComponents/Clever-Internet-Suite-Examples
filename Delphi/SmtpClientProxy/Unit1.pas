unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMailMessage, clTcpClient, clTcpClientTls, clMC, clSmtp,
  clTcpCommandClient, DemoBaseFormUnit, ExtCtrls, clHttpProxy;

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
    edtProxyServer: TEdit;
    edtProxyPort: TEdit;
    Label8: TLabel;
    Label9: TLabel;
    clHttpProxy1: TclHttpProxy;
    procedure btnSendClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSendClick(Sender: TObject);
begin
  if (clSmtp1.Active) then Exit;

  clHttpProxy1.Server := edtProxyServer.Text;
  clHttpProxy1.Port := StrToInt(edtProxyPort.Text);

  clSmtp1.Proxy := clHttpProxy1;

  clSmtp1.Server := edtServer.Text;
  clSmtp1.Port := StrToInt(edtPort.Text);
  clSmtp1.UserName := edtUser.Text;
  clSmtp1.Password := edtPassword.Text;

  clSmtp1.Open();
  try
    clMailMessage1.BuildMessage(memBody.Text, '');
    clMailMessage1.From.FullAddress := edtFrom.Text;
    clMailMessage1.ToList.EmailAddresses := edtTo.Text;
    clMailMessage1.Subject := edtSubject.Text;

    clSmtp1.Send(clMailMessage1);

    ShowMessage('The message was sent successfully.');
  finally
    clSmtp1.Close();
  end;
end;

end.
