unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, clMailMessage, clSMTP, clMC, clPOP3, StdCtrls, clSocket,
  clTcpClient, clTcpClientTls, clTcpCommandClient, DemoBaseFormUnit,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtServer: TEdit;
    edtUser: TEdit;
    edtPassword: TEdit;
    btnSend: TButton;
    btnReceive: TButton;
    clPOP31: TclPOP3;
    clSMTP1: TclSMTP;
    clMailMessage1: TclMailMessage;
    ProgressBar1: TProgressBar;
    Label4: TLabel;
    Label5: TLabel;
    edtFrom: TEdit;
    edtTo: TEdit;
    lblProgress: TLabel;
    btnStop: TButton;
    edtAttachment: TEdit;
    Label6: TLabel;
    btnBrowse: TButton;
    OpenDialog1: TOpenDialog;
    Message: TLabel;
    memBody: TMemo;
    procedure btnSendClick(Sender: TObject);
    procedure btnReceiveClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clMailProgress(Sender: TObject; ABytesProceed,
      ATotalBytes: Int64);
    procedure btnBrowseClick(Sender: TObject);
    procedure clMailMessage1EncodingProgress(Sender: TObject;
      ABody: TclMessageBody; ABytesProceed, ATotalBytes: Int64);
    procedure clMailMessage1SaveAttachment(Sender: TObject;
      ABody: TclAttachmentBody; var AFileName: string; var AData: TStream;
      var Handled: Boolean);
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
  if clSMTP1.Active or clPOP31.Active then
  begin
    raise Exception.Create('Message sending / retrieving is in progress');
  end;

  clMailMessage1.BuildMessage(memBody.Lines.Text, //text body
    '<html><body><p>' + memBody.Lines.Text + '</p></body></html>', //html body
    [], //images
    [edtAttachment.Text]); //attachments

  clMailMessage1.Subject := 'Message Subject';
  clMailMessage1.From.FullAddress := edtFrom.Text;
  clMailMessage1.ToList.EmailAddresses := edtTo.Text;

  ProgressBar1.Position := 0;
  lblProgress.Caption := '%';

  clSMTP1.Server := edtServer.Text;
  clSMTP1.UserName := edtUser.Text;
  clSMTP1.Password := edtPassword.Text;
  clSMTP1.Open();
  try
    clSMTP1.Send(clMailMessage1);
  finally
    clSMTP1.Close();
  end;

  lblProgress.Caption := '100 %';

  ShowMessage('Done');
end;

procedure TForm1.btnReceiveClick(Sender: TObject);
begin
  if clSMTP1.Active or clPOP31.Active then
  begin
    raise Exception.Create('Message sending / retrieving is in progress');
  end;

  ProgressBar1.Position := 0;
  lblProgress.Caption := '%';

  clPOP31.Server := edtServer.Text;
  clPOP31.UserName := edtUser.Text;
  clPOP31.Password := edtPassword.Text;
  clPOP31.Open();
  try
    if clPOP31.MessageCount = 0 then
    begin
      raise Exception.Create('There are no messages in the mailbox');
    end;

    clPOP31.Retrieve(1, clMailMessage1); //retrieve first mail message

    edtFrom.Text := clMailMessage1.From.FullAddress;
    edtTo.Text := clMailMessage1.ToList.EmailAddresses;
    memBody.Lines := clMailMessage1.MessageText;
  finally
    clPOP31.Close();
  end;

  lblProgress.Caption := '100 %';

  ShowMessage('Done');
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
  clPOP31.Close();
  clSMTP1.Close();
end;

procedure TForm1.clMailProgress(Sender: TObject; ABytesProceed, ATotalBytes: Int64);
begin
  ProgressBar1.Max := ATotalBytes;
  ProgressBar1.Position := ABytesProceed;
  lblProgress.Caption := IntToStr(Round(ProgressBar1.Position / ProgressBar1.Max * 100)) + ' %';
end;

procedure TForm1.btnBrowseClick(Sender: TObject);
begin
  if OpenDialog1.Execute() then
  begin
    edtAttachment.Text := OpenDialog1.FileName;
  end;
end;

procedure TForm1.clMailMessage1EncodingProgress(Sender: TObject;
  ABody: TclMessageBody; ABytesProceed, ATotalBytes: Int64);
begin
  Application.ProcessMessages();
end;

procedure TForm1.clMailMessage1SaveAttachment(Sender: TObject;
  ABody: TclAttachmentBody; var AFileName: string; var AData: TStream;
  var Handled: Boolean);
begin
  if ABody is TclAttachmentBody then
  begin
    edtAttachment.Text := ABody.FileName;
  end;
end;

end.
