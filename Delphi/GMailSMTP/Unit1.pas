unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMailMessage, clTcpClient, clTcpClientTls, clMC, clSmtp, clCertificate,
  clTcpCommandClient, clOAuth, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
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
    clOAuth1: TclOAuth;
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

  clOAuth1.AuthUrl := 'https://accounts.google.com/o/oauth2/auth';
  clOAuth1.TokenUrl := 'https://accounts.google.com/o/oauth2/token';
  clOAuth1.RedirectUrl := 'http://localhost';
  clOAuth1.ClientID := '421475025220-6khpgoldbdsi60fegvjdqk2bk4v19ss2.apps.googleusercontent.com';
  clOAuth1.ClientSecret := '_4HJyAVUmH_iVrPB8pOJXjR1';
  clOAuth1.Scope := 'https://mail.google.com/';

  clSmtp1.Server := 'smtp.gmail.com';
  clSmtp1.Port := 587;
  clSmtp1.UseTLS := ctExplicit;

  clSmtp1.UserName := edtFrom.Text;

  clSmtp1.Authorization := clOAuth1.GetAuthorization();

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
