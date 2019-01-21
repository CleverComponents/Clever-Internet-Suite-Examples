unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, clMailMessage, clTcpClient, clMC, clPop3,
  clCertificate, clTcpClientTls, clTcpCommandClient, DemoBaseFormUnit,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    Label2: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    edtServer: TEdit;
    edtPort: TEdit;
    edtUser: TEdit;
    edtPassword: TEdit;
    btnConnect: TButton;
    cbUseTLS: TCheckBox;
    lvMessages: TListView;
    Label3: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    edtFrom: TEdit;
    edtSubject: TEdit;
    memBody: TMemo;
    btnDelete: TButton;
    clPop: TclPop3;
    clMailMessage: TclMailMessage;
    btnDisconnect: TButton;
    btnView: TButton;
    procedure btnConnectClick(Sender: TObject);
    procedure btnDisconnectClick(Sender: TObject);
    procedure clPopVerifyServer(Sender: TObject;
      ACertificate: TclCertificate; const AStatusText: String;
      AStatusCode: Integer; var AVerified: Boolean);
    procedure btnViewClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
  private
    FCertificateVerified: Boolean;
    procedure FillMessages;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnConnectClick(Sender: TObject);
begin
  if clPop.Active then Exit;

  FCertificateVerified := False;

  clPop.Server := edtServer.Text;
  clPop.Port := StrToInt(edtPort.Text);
  clPop.UserName := edtUser.Text;
  clPop.Password := edtPassword.Text;

  if cbUseTLS.Checked then
  begin
    clPop.UseTLS := ctAutomatic;
  end else
  begin
    clPop.UseTLS := ctNone;
  end;

  clPop.Open();

  FillMessages();
end;

procedure TForm1.FillMessages;
var
  i: Integer;
  item: TListItem;
begin
  lvMessages.Items.BeginUpdate();
  try
    lvMessages.Items.Clear();

    for i := 1 to clPop.MessageCount do
    begin
      clPop.RetrieveHeader(i, clMailMessage);

      item := lvMessages.Items.Add();
      item.Caption := clMailMessage.From.FullAddress;
      item.SubItems.Add(clMailMessage.Subject);
      item.SubItems.Add(DateTimeToStr(clMailMessage.Date));
      item.SubItems.Add(clPop.GetUID(i));
      item.Data := Pointer(i);
    end;
  finally
    lvMessages.Items.EndUpdate();
  end;
end;

procedure TForm1.btnDisconnectClick(Sender: TObject);
begin
  lvMessages.Items.Clear();
  edtFrom.Text := '';
  edtSubject.Text := '';
  memBody.Lines.Clear();

  clPop.Close();
end;

procedure TForm1.clPopVerifyServer(Sender: TObject;
  ACertificate: TclCertificate; const AStatusText: String;
  AStatusCode: Integer; var AVerified: Boolean);
begin
  if not AVerified then
  begin
    AVerified := FCertificateVerified;
  end;
  if not AVerified and (MessageDlg(AStatusText + #13#10' Do you wish to proceed ?',
    mtWarning, [mbYes, mbNo], 0) = mrYes) then
  begin
    AVerified := True;
    FCertificateVerified := True;
  end;
end;

procedure TForm1.btnViewClick(Sender: TObject);
begin
  if (lvMessages.Selected = nil) then Exit;

  clPop.Retrieve(Integer(lvMessages.Selected.Data), clMailMessage);

  edtFrom.Text := clMailMessage.From.FullAddress;
  edtSubject.Text := clMailMessage.Subject;
  memBody.Lines := clMailMessage.MessageText;
end;

procedure TForm1.btnDeleteClick(Sender: TObject);
begin
  if (lvMessages.Selected = nil) then Exit;
  clPop.Delete(Integer(lvMessages.Selected.Data));
  lvMessages.Items.Delete(lvMessages.Selected.Index);
end;

end.
