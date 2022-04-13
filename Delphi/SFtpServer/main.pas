unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, SyncObjs, ExtCtrls, ComCtrls, clServerGuard, DemoBaseFormUnit,
  clSFtpFileHandler, clTcpServerSsh, clSFtpServer, clTcpServer, clSshPacket, clSFtpUtils, clUtils;

type
  TMainForm = class(TclDemoBaseForm)
    clServerGuard1: TclServerGuard;
    clSFtpServer1: TclSFtpServer;
    clSFtpFileHandler1: TclSFtpFileHandler;
    pgMain: TPageControl;
    tabServer: TTabSheet;
    tabHostKey: TTabSheet;
    tabAccessControl: TTabSheet;
    tabIPBlocking: TTabSheet;
    tabSSHAlgorithms: TTabSheet;
    Label2: TLabel;
    edtPort: TEdit;
    Label3: TLabel;
    edtRootDir: TEdit;
    btnStart: TButton;
    btnStop: TButton;
    memLog: TMemo;
    Label1: TLabel;
    Label5: TLabel;
    edtBindingHost: TEdit;
    Label4: TLabel;
    tabBanner: TTabSheet;
    Label6: TLabel;
    edtAllowedConnections: TEdit;
    Label7: TLabel;
    memBlackList: TMemo;
    Label8: TLabel;
    memWhiteList: TMemo;
    cbWhiteListOnly: TCheckBox;
    Label9: TLabel;
    edtUserName: TEdit;
    Label10: TLabel;
    cbUseIPv6: TCheckBox;
    Label11: TLabel;
    edtPassword: TEdit;
    Label12: TLabel;
    edtUserRootDir: TEdit;
    gbUserPermissions: TGroupBox;
    cbCanList: TCheckBox;
    cbCanMakeDir: TCheckBox;
    cbCanRemoveDir: TCheckBox;
    cbCanRead: TCheckBox;
    cbCanWrite: TCheckBox;
    cbCanRename: TCheckBox;
    cbCanRemove: TCheckBox;
    cbCanMakeLink: TCheckBox;
    cbCanReadLink: TCheckBox;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    edtBannerMessage: TEdit;
    Label16: TLabel;
    edtBannerLanguage: TEdit;
    cbEnableBanner: TCheckBox;
    Label17: TLabel;
    edtKeyType: TEdit;
    Label18: TLabel;
    edtKeyLength: TEdit;
    Label19: TLabel;
    edtHostKeyFile: TEdit;
    Label20: TLabel;
    edtFingerPrint: TEdit;
    btnGenerateHostKey: TButton;
    btnLoadHostKey: TButton;
    Label21: TLabel;
    Label22: TLabel;
    edtHostKeyPassPhrase: TEdit;
    Label23: TLabel;
    edtKexAlgs: TEdit;
    Label24: TLabel;
    edtSignatureAlgs: TEdit;
    Label25: TLabel;
    edtEncryptionAlgs: TEdit;
    Label26: TLabel;
    edtDataIntegrityAlgs: TEdit;
    Label27: TLabel;
    tabAdditional: TTabSheet;
    Label28: TLabel;
    edtCharSet: TEdit;
    Label29: TLabel;
    edtMaxReturnFiles: TEdit;
    Label30: TLabel;
    edtBatchSize: TEdit;
    Label31: TLabel;
    edtMaxWindowSize: TEdit;
    Label32: TLabel;
    lblStatus: TLabel;
    OpenDialog1: TOpenDialog;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure clSFtpServer1ReceiveRequest(Sender: TObject; AConnection: TclSFtpUserConnection;
      ACommand: Byte; ARequestId: Cardinal; APacket: TclSshPacket);
    procedure clSFtpServer1SendResponse(Sender: TObject; AConnection: TclSFtpUserConnection;
      ACommand: Byte; ARequestId: Cardinal; APacket: TclSshPacket);
    procedure clSFtpServer1Start(Sender: TObject);
    procedure clSFtpServer1Stop(Sender: TObject);
    procedure clSFtpServer1AcceptConnection(Sender: TObject;
      AConnection: TclUserConnection; var Handled: Boolean);
    procedure clSFtpServer1CloseConnection(Sender: TObject;
      AConnection: TclUserConnection);
    procedure btnLoadHostKeyClick(Sender: TObject);
    procedure btnGenerateHostKeyClick(Sender: TObject);
  private
    FSynchronizer: TCriticalSection;
    FIsStop: Boolean;
    procedure PutLogMessage(const ALogMessage: string);
    procedure LoadHostKey;
    procedure GenerateHostKey;
    procedure AssignSettings;
    procedure LoadDefaultSettings;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.clSFtpServer1AcceptConnection(Sender: TObject;
  AConnection: TclUserConnection; var Handled: Boolean);
begin
  PutLogMessage('Accept Connection. Host: ' + AConnection.PeerIP);
end;

procedure TMainForm.clSFtpServer1CloseConnection(Sender: TObject;
  AConnection: TclUserConnection);
begin
  if not FIsStop then
  begin
    PutLogMessage('Close Connection. Host: ' + AConnection.PeerIP);
  end;
end;

procedure TMainForm.clSFtpServer1ReceiveRequest(Sender: TObject; AConnection: TclSFtpUserConnection;
  ACommand: Byte; ARequestId: Cardinal; APacket: TclSshPacket);
begin
  if not (ACommand in [SSH_FXP_READ, SSH_FXP_WRITE, SSH_FXP_READDIR]) then
  begin
    PutLogMessage(Format('Command[%d]: %s (%d bytes)', [ARequestId, GetSFtpCommandName(ACommand), APacket.GetLength()]));
  end;
end;

procedure TMainForm.clSFtpServer1SendResponse(Sender: TObject; AConnection: TclSFtpUserConnection;
  ACommand: Byte; ARequestId: Cardinal; APacket: TclSshPacket);
begin
  if not (ACommand in [SSH_FXP_READ, SSH_FXP_WRITE, SSH_FXP_READDIR]) then
  begin
    PutLogMessage(Format('Reply[%d]: %s (%d bytes)', [ARequestId, GetSFtpCommandName(ACommand), APacket.GetLength()]));
  end;
end;

procedure TMainForm.clSFtpServer1Start(Sender: TObject);
begin
  PutLogMessage('=================='#13#10'Start Server');
end;

procedure TMainForm.clSFtpServer1Stop(Sender: TObject);
begin
  PutLogMessage('Stop Server');
end;

procedure TMainForm.FormCreate(Sender: TObject);
begin
  FSynchronizer := TCriticalSection.Create();
  pgMain.ActivePage := tabServer;
  lblStatus.Visible := False;

  LoadHostKey();
  LoadDefaultSettings();
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

procedure TMainForm.btnGenerateHostKeyClick(Sender: TObject);
begin
  GenerateHostKey();
end;

procedure TMainForm.btnLoadHostKeyClick(Sender: TObject);
begin
  if (clSFtpServer1.Active) then Exit;

  if not OpenDialog1.Execute() then Exit;

  edtHostKeyFile.Text := OpenDialog1.FileName;

  LoadHostKey();
end;

procedure TMainForm.btnStartClick(Sender: TObject);
begin
  if (clSFtpServer1.Active) then Exit;

  LoadHostKey();

  if (not clSFtpServer1.HostKey.HasKey) then
  begin
    GenerateHostKey();
  end;

  AssignSettings();

  clServerGuard1.Reset();
  clSFtpServer1.Start();
  lblStatus.Visible := True;
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  FIsStop := True;
  try
    clSFtpServer1.Stop();
    lblStatus.Visible := False;
  finally
    FIsStop := False;
  end;
end;

procedure TMainForm.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 513;
 {$ENDIF}
end;

procedure TMainForm.LoadHostKey;
begin
  if clSFtpServer1.Active then Exit;

  clSFtpServer1.HostKey.Clear();

  clSFtpServer1.HostKey.PrivateKeyFile := edtHostKeyFile.Text;
  clSFtpServer1.HostKey.PassPhrase := edtHostKeyPassPhrase.Text;

  if (edtHostKeyFile.Text <> '') and FileExists(edtHostKeyFile.Text) then
  begin
    clSFtpServer1.HostKey.Load();
    edtFingerPrint.Text := clSFtpServer1.HostKey.FingerPrint;
  end else
  begin
    edtFingerPrint.Text := '';
  end;
end;

procedure TMainForm.GenerateHostKey;
begin
  if clSFtpServer1.Active then Exit;

  if (edtHostKeyFile.Text <> '') and FileExists(edtHostKeyFile.Text) then
  begin
    if (MessageDlg('The key file "' + edtHostKeyFile.Text + '" already exists. Do you want to replace?',
        mtConfirmation, [mbYes, mbNo], 0) <> mrYes) then  Exit;
  end;

  clSFtpServer1.HostKey.KeyLength := StrToInt(edtKeyLength.Text);
  clSFtpServer1.HostKey.Generate();

  if (edtHostKeyFile.Text <> '') then
  begin
    clSFtpServer1.HostKey.Save(edtHostKeyFile.Text);
  end;

  edtFingerPrint.Text := clSFtpServer1.HostKey.FingerPrint;
end;

procedure TMainForm.LoadDefaultSettings;
begin
  //Host Key
  edtKeyLength.Text := IntToStr(clSFtpServer1.HostKey.KeyLength);

  //SSH Algorithms Tab
  edtKexAlgs.Text := clSFtpServer1.Config.GetConfig('kex');
  edtSignatureAlgs.Text := clSFtpServer1.Config.GetConfig('hostkey');
  edtEncryptionAlgs.Text := clSFtpServer1.Config.GetConfig('cipher.s2c');
  edtDataIntegrityAlgs.Text := clSFtpServer1.Config.GetConfig('mac.s2c');

  //Additional Settings Tab
  edtCharSet.Text := clSFtpServer1.CharSet;
  edtMaxReturnFiles.Text := IntToStr(clSFtpServer1.MaxReturnFiles);
  edtBatchSize.Text := IntToStr(clSFtpServer1.BatchSize);
  edtMaxWindowSize.Text := IntToStr(clSFtpServer1.MaxWindowSize);
end;

procedure TMainForm.AssignSettings;
var
  permissions: TclSFtpServerPermissions;
begin
  if clSFtpServer1.Active then Exit;

  //Server Tab
  clSFtpServer1.Port := StrToInt(edtPort.Text);
  clSFtpServer1.LocalBinding := edtBindingHost.Text;
  clSFtpServer1.UseIpV6 := cbUseIPv6.Checked;
  clSFtpServer1.RootDir := edtRootDir.Text;
  if (clSFtpServer1.RootDir <> '') then
  begin
    ForceFileDirectories(AddTrailingBackSlash(clSFtpServer1.RootDir));
  end;

  //Banner Tab
  clSFtpServer1.Banner := edtBannerMessage.Text;
  clSFtpServer1.BannerLanguage := edtBannerLanguage.Text;
  clSFtpServer1.EnableBanner := cbEnableBanner.Checked;

  //Access Control Tab
  clSFtpServer1.UserAccounts.Clear();
  clSFtpServer1.UserAccounts.Add();
  clSFtpServer1.UserAccounts[0].UserName := edtUserName.Text;
  clSFtpServer1.UserAccounts[0].Password := edtPassword.Text;
  clSFtpServer1.UserAccounts[0].RootDir := edtUserRootDir.Text;
  if (clSFtpServer1.UserAccounts[0].RootDir <> '') then
  begin
    ForceFileDirectories(AddTrailingBackSlash(clSFtpServer1.UserAccounts[0].RootDir));
  end;

  permissions := [];
  if (cbCanList.Checked) then permissions := permissions + [sfpList];
  if (cbCanMakeDir.Checked) then permissions := permissions + [sfpMakeDir];
  if (cbCanRemoveDir.Checked) then permissions := permissions + [sfpRemoveDir];
  if (cbCanRead.Checked) then permissions := permissions + [sfpRead];
  if (cbCanWrite.Checked) then permissions := permissions + [sfpWrite];
  if (cbCanRename.Checked) then permissions := permissions + [sfpRename];
  if (cbCanRemove.Checked) then permissions := permissions + [sfpRemove];
  if (cbCanMakeLink.Checked) then permissions := permissions + [sfpMakeLink];
  if (cbCanReadLink.Checked) then permissions := permissions + [sfpReadLink];
  clSFtpServer1.UserAccounts[0].Permissions := permissions;

  //IP Blocking Tab
  clServerGuard1.ConnectionLimit.Max := StrToInt(edtAllowedConnections.Text);
  clServerGuard1.ConnectionLimit.Period := 60000; //1 minute
  clServerGuard1.BlackIPList.Assign(memBlackList.Lines);
  clServerGuard1.WhiteIPList.Assign(memWhiteList.Lines);
  clServerGuard1.AllowWhiteListOnly := cbWhiteListOnly.Checked;

  //SSH Algorithms Tab
  clSFtpServer1.Config.SetConfig('kex', edtKexAlgs.Text);
  clSFtpServer1.Config.SetConfig('hostkey', edtSignatureAlgs.Text);
  clSFtpServer1.Config.SetConfig('cipher.s2c', edtEncryptionAlgs.Text);
  clSFtpServer1.Config.SetConfig('cipher.c2s', edtEncryptionAlgs.Text);
  clSFtpServer1.Config.SetConfig('mac.s2c', edtDataIntegrityAlgs.Text);
  clSFtpServer1.Config.SetConfig('mac.c2s', edtDataIntegrityAlgs.Text);

  //Additional Settings Tab
  clSFtpServer1.CharSet := edtCharSet.Text;
  clSFtpServer1.MaxReturnFiles := StrToInt(edtMaxReturnFiles.Text);
  clSFtpServer1.BatchSize := StrToInt(edtBatchSize.Text);
  clSFtpServer1.MaxWindowSize := StrToInt(edtMaxWindowSize.Text);
end;

end.
