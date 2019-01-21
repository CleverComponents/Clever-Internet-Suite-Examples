unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, SyncObjs, ExtCtrls, clTcpServer, clFtpServer, clUserMgr,
  clFtpFileHandler, clCertificate, clUtils, clCertificateStore, clTcpCommandServer, clTcpServerTls, 
  DemoBaseFormUnit;

type
  TMainForm = class(TclDemoBaseForm)
    btnStart: TButton;
    btnStop: TButton;
    memLog: TMemo;
    edtPort: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    clFtpServer1: TclFtpServer;
    Label3: TLabel;
    edtRootDir: TEdit;
    clFtpFileHandler1: TclFtpFileHandler;
    clCertificateStore1: TclCertificateStore;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    cbUseTls: TComboBox;
    Label7: TLabel;
    procedure clFtpServer1Start(Sender: TObject);
    procedure clFtpServer1Stop(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clFtpServer1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
    procedure clFtpServer1Authenticate(Sender: TObject; AConnection: TclFtpCommandConnection; var Account: TclFtpUserAccountItem;
      const AUserName, APassword: string; var IsAuthorized, Handled: Boolean);
    procedure clFtpServer1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
    procedure clFtpServer1GetCertificate(Sender: TObject; var ACertificate: TclCertificate; AExtraCerts: TclCertificateList;
      var Handled: Boolean);
    procedure clFtpServer1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection; ACommandParams: TclTcpCommandParams);
    procedure clFtpServer1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand, AResponse: string);
  private
    FSynchronizer: TCriticalSection;
    FIsStopping: Boolean;
    procedure PutLogMessage(const ALogMessage: string);
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.clFtpServer1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand,
  AResponse: string);
begin
  PutLogMessage('Reply: ' + AResponse);
end;

procedure TMainForm.clFtpServer1Start(Sender: TObject);
begin
  PutLogMessage('=================='#13#10'Start Server');
end;

procedure TMainForm.clFtpServer1Stop(Sender: TObject);
begin
  PutLogMessage('Stop Server');
end;

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
  clFtpServer1.UseTLS := TclServerTlsMode(cbUseTls.ItemIndex);
  clFtpServer1.Port := StrToInt(edtPort.Text);
  clFtpServer1.RootDir := edtRootDir.Text;
  ForceFileDirectories(AddTrailingBackSlash(clFtpServer1.RootDir));
  clFtpServer1.Start();
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  FIsStopping := True;
  try
    clFtpServer1.Stop();
  finally
    FIsStopping := False;
  end;
end;

procedure TMainForm.clFtpServer1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
begin
  PutLogMessage('Accept Connection. Host: ' + AConnection.PeerIP);
end;

procedure TMainForm.clFtpServer1Authenticate(Sender: TObject; AConnection: TclFtpCommandConnection;
  var Account: TclFtpUserAccountItem; const AUserName, APassword: string; var IsAuthorized, Handled: Boolean);
begin
  if (Account <> nil) then
    PutLogMessage('Authenticate user: ' + Account.UserName);
end;

procedure TMainForm.clFtpServer1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
begin
  if not FIsStopping then
    PutLogMessage('Close Connection. Host: ' + AConnection.PeerIP);
end;

procedure TMainForm.clFtpServer1GetCertificate(Sender: TObject; var ACertificate: TclCertificate; AExtraCerts: TclCertificateList; var Handled: Boolean);
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

procedure TMainForm.clFtpServer1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection;
  ACommandParams: TclTcpCommandParams);
begin
  PutLogMessage('Command: ' + ACommandParams.Command + ' ' + ACommandParams.Parameters);
end;

end.
