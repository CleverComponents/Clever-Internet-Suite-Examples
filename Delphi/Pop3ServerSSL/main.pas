unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clTcpServer, clUserMgr, clMailUserMgr, SyncObjs, clUtils,
  clPop3Server, clPop3FileHandler, clCertificate, clCertificateStore, clTcpCommandServer,
  clTcpServerTls, DemoBaseFormUnit, ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    btnStart: TButton;
    btnStop: TButton;
    memLog: TMemo;
    edtPort: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtRootDir: TEdit;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    clPop3FileHandler1: TclPop3FileHandler;
    clPop3Server1: TclPop3Server;
    cbUseTls: TComboBox;
    clCertificateStore1: TclCertificateStore;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clPop3Server1Start(Sender: TObject);
    procedure clPop3Server1Stop(Sender: TObject);
    procedure clPop3Server1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
    procedure clPop3Server1Authenticate(Sender: TObject; AConnection: TclPop3CommandConnection;
      var Account: TclMailUserAccountItem; const AUserName: string; var IsAuthorized, Handled: Boolean);
    procedure clPop3Server1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
    procedure clPop3Server1GetCertificate(Sender: TObject; var ACertificate: TclCertificate; AExtraCerts: TclCertificateList;
      var Handled: Boolean);
    procedure clPop3Server1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection;
      ACommandParams: TclTcpCommandParams);
    procedure clPop3Server1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand, AResponse: string);
  private
    FSynchronizer: TCriticalSection;
    FIsStop: Boolean;
    procedure PutLogMessage(const ALogMessage: string);
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.FormCreate(Sender: TObject);
begin
  FSynchronizer := TCriticalSection.Create();
end;

procedure TMainForm.FormDestroy(Sender: TObject);
begin
  FSynchronizer.Free();
end;

procedure TMainForm.PutLogMessage(const ALogMessage: string);
begin
  if not (csDestroying in ComponentState) then
  begin
    FSynchronizer.Enter();
    try
      memLog.Lines.Add(ALogMessage);
    finally
      FSynchronizer.Leave();
    end;
  end;
end;

procedure TMainForm.btnStartClick(Sender: TObject);
begin
  clPop3Server1.Port := StrToInt(edtPort.Text);
  clPop3Server1.UseTLS := TclServerTlsMode(cbUseTls.ItemIndex);
  clPop3FileHandler1.MailBoxDir := edtRootDir.Text;
  ForceFileDirectories(AddTrailingBackSlash(clPop3FileHandler1.MailBoxDir));
  ForceFileDirectories(AddTrailingBackSlash(clPop3FileHandler1.MailBoxDir) + 'CleverTester\');
  clPop3Server1.Start();
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  FIsStop := True;
  try
    clPop3Server1.Stop();
  finally
    FIsStop := False;
  end;
end;

procedure TMainForm.clPop3Server1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand,
  AResponse: string);
begin
  PutLogMessage('Reply: ' + AResponse);
end;

procedure TMainForm.clPop3Server1Start(Sender: TObject);
begin
  PutLogMessage('=================='#13#10'Start Server');
end;

procedure TMainForm.clPop3Server1Stop(Sender: TObject);
begin
  PutLogMessage('Stop Server');
end;

procedure TMainForm.clPop3Server1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
begin
  PutLogMessage('Accept Connection. Host: ' + AConnection.PeerIP);
end;

procedure TMainForm.clPop3Server1Authenticate(Sender: TObject; AConnection: TclPop3CommandConnection;
  var Account: TclMailUserAccountItem; const AUserName: string; var IsAuthorized, Handled: Boolean);
begin
  if (Account <> nil) then
  begin
    PutLogMessage('Authenticate user: ' + Account.UserName);
  end;
end;

procedure TMainForm.clPop3Server1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
begin
  if not FIsStop then
  begin
    PutLogMessage('Close Connection. Host: ' + AConnection.PeerIP);
  end;
end;

procedure TMainForm.clPop3Server1GetCertificate(Sender: TObject; var ACertificate: TclCertificate;
  AExtraCerts: TclCertificateList; var Handled: Boolean);
begin
  if clCertificateStore1.Items.Count = 0 then
  begin
    clCertificateStore1.ValidFrom := Now();
    clCertificateStore1.ValidTo := Now() + 365;
    ACertificate := clCertificateStore1.CreateSelfSigned('CN=CleverTester,O=CleverComponents,E=CleverTester@company.mail', 0);
    clCertificateStore1.Items.Add(ACertificate);
  end;
  ACertificate := clCertificateStore1.Items[0];
  Handled := True;
end;

procedure TMainForm.clPop3Server1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection;
  ACommandParams: TclTcpCommandParams);
begin
  PutLogMessage('Command: ' + ACommandParams.Command + ' ' + ACommandParams.Parameters);
end;

end.
