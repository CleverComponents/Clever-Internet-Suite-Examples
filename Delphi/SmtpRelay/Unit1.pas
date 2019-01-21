unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clTcpClient, clMC, clSmtp, clSmtpRelay, clMailMessage, relayfrm,
  clTcpClientTls, clTcpCommandClient, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    edtDNS: TEdit;
    Label5: TLabel;
    edtSender: TEdit;
    Label6: TLabel;
    edtRecipient: TEdit;
    Label7: TLabel;
    edtSubject: TEdit;
    Label8: TLabel;
    memText: TMemo;
    clSmtpRelay1: TclSmtpRelay;
    btnSend: TButton;
    clMailMessage1: TclMailMessage;
    Label9: TLabel;
    edtDNSTimeOut: TEdit;
    procedure btnSendClick(Sender: TObject);
  private
    procedure ShowResults;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSendClick(Sender: TObject);
begin
  btnSend.Enabled := False;
  try
    clMailMessage1.BuildMessage(memText.Lines.Text, '');
    clMailMessage1.From.FullAddress := edtSender.Text;
    clMailMessage1.ToList.EmailAddresses := edtRecipient.Text;
    clMailMessage1.Subject := edtSubject.Text;

    clSmtpRelay1.DnsServer := edtDNS.Text;
    clSmtpRelay1.TimeOut := StrToInt(edtDNSTimeOut.Text) * 1000;
    clSmtpRelay1.Send(clMailMessage1);

    ShowResults();
  finally
    btnSend.Enabled := True;
  end;
end;

procedure TForm1.ShowResults;
const
  sentStatus: array[Boolean] of string = ('Not Sent', 'Sent');
var
  i: Integer;
  relayStatus: TRelayStatusForm;
begin
  relayStatus := TRelayStatusForm.Create(nil);
  try
    for i := 0 to clSmtpRelay1.StatusList.Count - 1 do
    begin
      relayStatus.Memo1.Lines.Add('======  ' + clSmtpRelay1.StatusList[i].Domain + '  ======');
      relayStatus.Memo1.Lines.Add('Mail server: ' + clSmtpRelay1.StatusList[i].MailServer);
      relayStatus.Memo1.Lines.Add('Status: ' + sentStatus[clSmtpRelay1.StatusList[i].IsSent]);
      relayStatus.Memo1.Lines.Add('Server response: ' + clSmtpRelay1.StatusList[i].ResponseText);
      relayStatus.Memo1.Lines.Add('Error: ' + clSmtpRelay1.StatusList[i].ErrorText);
      relayStatus.Memo1.Lines.Add('');
    end;
    relayStatus.ShowModal();
  finally
    relayStatus.Free();
  end;
end;

end.
