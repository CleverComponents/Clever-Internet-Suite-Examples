unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clTcpServer, clUserMgr, clMailUserMgr, SyncObjs, clUtils,
  clSmtpFileHandler, clSmtpServer, IniFiles, clTcpCommandServer, clTcpServerTls, DemoBaseFormUnit,
  ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    btnStart: TButton;
    btnStop: TButton;
    memLog: TMemo;
    edtPort: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtMailboxDir: TEdit;
    Label4: TLabel;
    Label5: TLabel;
    clSmtpServer1: TclSmtpServer;
    clSmtpFileHandler1: TclSmtpFileHandler;
    Label6: TLabel;
    edtRelayDir: TEdit;
    cbUseLogin: TCheckBox;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clSmtpServer1Start(Sender: TObject);
    procedure clSmtpServer1Stop(Sender: TObject);
    procedure clSmtpServer1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
    procedure clSmtpServer1Authenticate(Sender: TObject; AConnection: TclSmtpCommandConnection;
      var Account: TclMailUserAccountItem; const AUserName: string; var IsAuthorized, Handled: Boolean);
    procedure clSmtpServer1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
    procedure clSmtpServer1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection;
      ACommandParams: TclTcpCommandParams);
    procedure clSmtpServer1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand, AResponse: string);
  private
    FSynchronizer: TCriticalSection;
    FIsStop: Boolean;
    procedure PutLogMessage(const ALogMessage: string);
    function GetSettingsFile: string;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

function TMainForm.GetSettingsFile: string;
begin
  Result := AddTrailingBackSlash(edtMailboxDir.Text) + 'smtp.dat';
end;

procedure TMainForm.FormCreate(Sender: TObject);
var
  ini: TIniFile;
begin
  FSynchronizer := TCriticalSection.Create();
  ini := TIniFile.Create(GetSettingsFile());
  try
    clSmtpFileHandler1.Counter := ini.ReadInteger('SMTP', 'Counter', 1);
  finally
    ini.Free();
  end;
end;

procedure TMainForm.FormDestroy(Sender: TObject);
var
  ini: TIniFile;
begin
  FSynchronizer.Free();
  ini := TIniFile.Create(GetSettingsFile());
  try
    ini.WriteInteger('SMTP', 'Counter', clSmtpFileHandler1.Counter);
  finally
    ini.Free();
  end;
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
  clSmtpServer1.Port := StrToInt(edtPort.Text);
  clSmtpServer1.UseAuth := cbUseLogin.Checked;

  clSmtpFileHandler1.MailBoxDir := edtMailboxDir.Text;
  clSmtpFileHandler1.RelayDir := edtRelayDir.Text;

  ForceFileDirectories(AddTrailingBackSlash(clSmtpFileHandler1.MailBoxDir));
  ForceFileDirectories(AddTrailingBackSlash(clSmtpFileHandler1.RelayDir));

  clSmtpServer1.Start();
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  FIsStop := True;
  try
    clSmtpServer1.Stop();
  finally
    FIsStop := False;
  end;
end;

procedure TMainForm.clSmtpServer1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand,
  AResponse: string);
begin
  PutLogMessage('Reply: ' + AResponse);
end;

procedure TMainForm.clSmtpServer1Start(Sender: TObject);
begin
  PutLogMessage('=================='#13#10'Start Server');
end;

procedure TMainForm.clSmtpServer1Stop(Sender: TObject);
begin
  PutLogMessage('Stop Server');
end;

procedure TMainForm.clSmtpServer1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
begin
  PutLogMessage('Accept Connection. Host: ' + AConnection.PeerIP);
end;

procedure TMainForm.clSmtpServer1Authenticate(Sender: TObject; AConnection: TclSmtpCommandConnection;
  var Account: TclMailUserAccountItem; const AUserName: string; var IsAuthorized, Handled: Boolean);
begin
  if (Account <> nil) then
  begin
    PutLogMessage('Authenticate user: ' + Account.UserName);
  end;
end;

procedure TMainForm.clSmtpServer1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
begin
  if not FIsStop then
  begin
    PutLogMessage('Close Connection. Host: ' + AConnection.PeerIP);
  end;
end;

procedure TMainForm.clSmtpServer1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection;
  ACommandParams: TclTcpCommandParams);
begin
  PutLogMessage('Command: ' + ACommandParams.Command + ' ' + ACommandParams.Parameters);
end;

end.
