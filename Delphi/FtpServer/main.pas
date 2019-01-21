unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, SyncObjs, ExtCtrls, clTcpServer, clFtpServer, clUserMgr,
  clFtpFileHandler, clUtils, clTcpCommandServer, clServerGuard, clTcpServerTls, DemoBaseFormUnit;

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
    Label4: TLabel;
    Label5: TLabel;
    GroupBox1: TGroupBox;
    clServerGuard1: TclServerGuard;
    Label6: TLabel;
    edtAllowedConnections: TEdit;
    Label7: TLabel;
    Label8: TLabel;
    memBlackList: TMemo;
    memWhiteList: TMemo;
    cbWhiteListOnly: TCheckBox;
    procedure clFtpServer1Stop(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clFtpServer1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
    procedure clFtpServer1Authenticate(Sender: TObject; AConnection: TclFtpCommandConnection; var Account: TclFtpUserAccountItem;
      const AUserName, APassword: string; var IsAuthorized, Handled: Boolean);
    procedure clFtpServer1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
    procedure clFtpServer1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection; ACommandParams: TclTcpCommandParams);
    procedure clFtpServer1SendResponse(Sender: TObject; AConnection: TclCommandConnection; const ACommand, AResponse: string);
    procedure clFtpServer1Start(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    FSynchronizer: TCriticalSection;
    FIsStop: Boolean;
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
  clServerGuard1.ConnectionLimit.Max := StrToInt(edtAllowedConnections.Text);
  clServerGuard1.ConnectionLimit.Period := 60000; //1 minute
  clServerGuard1.BlackIPList.Assign(memBlackList.Lines);
  clServerGuard1.WhiteIPList.Assign(memWhiteList.Lines);
  clServerGuard1.AllowWhiteListOnly := cbWhiteListOnly.Checked;

  clServerGuard1.Reset();

  clFtpServer1.Port := StrToInt(edtPort.Text);
  clFtpServer1.RootDir := edtRootDir.Text;
  ForceFileDirectories(AddTrailingBackSlash(clFtpServer1.RootDir));
  clFtpServer1.Start();
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  FIsStop := True;
  try
    clFtpServer1.Stop();
  finally
    FIsStop := False;
  end;
end;

procedure TMainForm.clFtpServer1AcceptConnection(Sender: TObject; AConnection: TclUserConnection; var Handled: Boolean);
begin
  PutLogMessage('Accept Connection. Host: ' + AConnection.PeerIP);
end;

procedure TMainForm.clFtpServer1Authenticate(Sender: TObject; AConnection: TclFtpCommandConnection;
  var Account: TclFtpUserAccountItem; const AUserName, APassword: string; var IsAuthorized, Handled: Boolean);
begin
  if Account <> nil then
  begin
    PutLogMessage('Authenticate user: ' + Account.UserName);
  end;
end;

procedure TMainForm.clFtpServer1CloseConnection(Sender: TObject; AConnection: TclUserConnection);
begin
  if not FIsStop then
  begin
    PutLogMessage('Close Connection. Host: ' + AConnection.PeerIP);
  end;
end;

procedure TMainForm.clFtpServer1ReceiveCommand(Sender: TObject; AConnection: TclCommandConnection;
  ACommandParams: TclTcpCommandParams);
begin
  PutLogMessage('Command: ' + ACommandParams.Command + ' ' + ACommandParams.Parameters);
end;

procedure TMainForm.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 513;
 {$ENDIF}
end;

end.
