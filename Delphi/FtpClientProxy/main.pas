unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, clFTP, clFTPUtils, clUtils, clTcpClient,
  ExtCtrls, clTcpClientTls, clTcpCommandClient, DemoBaseFormUnit;

type
  TMainForm = class(TclDemoBaseForm)
    ProgressBar: TProgressBar;
    Label1: TLabel;
    Label2: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    edtServer: TEdit;
    edtPort: TEdit;
    edtUser: TEdit;
    edtPassword: TEdit;
    edtStartDir: TEdit;
    cbPassiveMode: TCheckBox;
    cbAsciiMode: TCheckBox;
    btnLogin: TButton;
    btnLogout: TButton;
    btnOpenDir: TButton;
    btnGoUp: TButton;
    btnDownload: TButton;
    btnUpload: TButton;
    btnAbort: TButton;
    lbList: TListBox;
    Label7: TLabel;
    clFTP: TclFTP;
    OpenDialog: TOpenDialog;
    SaveDialog: TSaveDialog;
    Bevel1: TBevel;
    Label3: TLabel;
    Label8: TLabel;
    edtProxyServer: TEdit;
    edtProxyUser: TEdit;
    edtProxyPassword: TEdit;
    edtProxyPort: TEdit;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    cbProxyType: TComboBox;
    procedure btnLoginClick(Sender: TObject);
    procedure btnLogoutClick(Sender: TObject);
    procedure btnOpenDirClick(Sender: TObject);
    procedure btnGoUpClick(Sender: TObject);
    procedure btnAbortClick(Sender: TObject);
    procedure btnDownloadClick(Sender: TObject);
    procedure btnUploadClick(Sender: TObject);
    procedure clFTPDirectoryListing(Sender: TObject;
      AFileInfo: TclFtpFileInfo; const Source: String);
    procedure clFTPProgress(Sender: TObject; ABytesProceed,
      ATotalBytes: Int64);
    procedure FormDestroy(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    procedure UpdateStatuses;
    procedure DoOpenDir(const ADir: string);
    procedure FillDirList;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

{ TMainForm }

procedure TMainForm.FormShow(Sender: TObject);
begin
  UpdateStatuses();
end;

procedure TMainForm.FormDestroy(Sender: TObject);
begin
  clFTP.Close();
end;

procedure TMainForm.UpdateStatuses;
const
  states: array[Boolean] of string = ('Ftp Client Proxy Sample', 'Ftp Client Proxy - Connected');
var
  enabled: Boolean;
begin
  enabled := clFTP.Active;
  Caption := states[enabled];
  btnOpenDir.Enabled := enabled;
  btnGoUp.Enabled := enabled;
  btnDownload.Enabled := enabled;
  btnUpload.Enabled := enabled;
  btnAbort.Enabled := enabled;
end;

procedure TMainForm.btnLoginClick(Sender: TObject);
const
  transferTypes: array[Boolean] of TclFtpTransferType = (ttBinary, ttAscii);
begin
  if clFTP.Active then
  begin
    ShowMessage('You are already connected. Please click Logout to disconnect.');
    Exit;
  end;

  clFTP.Port := StrToInt(edtPort.Text);
  clFTP.Server := edtServer.Text;
  clFTP.UserName := edtUser.Text;
  clFTP.Password := edtPassword.Text;
  clFTP.PassiveMode := cbPassiveMode.Checked;
  clFTP.TransferType := transferTypes[cbAsciiMode.Checked];

  clFTP.ProxySettings.Server := edtProxyServer.Text;
  clFTP.ProxySettings.Port := StrToInt(edtProxyPort.Text);
  clFTP.ProxySettings.UserName := edtProxyUser.Text;
  clFTP.ProxySettings.Password := edtProxyPassword.Text;
  clFTP.ProxySettings.ProxyType := TclFtpProxyType(cbProxyType.ItemIndex);

  clFTP.Open();
  if (edtStartDir.Text = '') then
  begin
    edtStartDir.Text := clFTP.CurrentDir;
  end;
  if (edtStartDir.Text <> '') and (edtStartDir.Text[1] = '/') then
  begin
    DoOpenDir(edtStartDir.Text);
  end;
  UpdateStatuses();
end;

procedure TMainForm.btnLogoutClick(Sender: TObject);
begin
  clFTP.Close();
  lbList.Items.Clear();
  UpdateStatuses();
end;

procedure TMainForm.DoOpenDir(const ADir: string);
var
  dir: string;
begin
  dir := ADir;
  if (Length(dir) > 1) and (dir[1] = '/') and (dir[2] = '/') then
  begin
    system.Delete(dir, 1, 1);
  end;
  clFTP.ChangeCurrentDir('/');
  clFTP.ChangeCurrentDir(dir);
  FillDirList();
end;

procedure TMainForm.FillDirList;
begin
  lbList.Items.BeginUpdate();
  try
    lbList.Items.Clear();
    clFTP.DirectoryListing();
  finally
    lbList.Items.EndUpdate();
  end;
  lbList.Sorted := False;
  lbList.Sorted := True;
end;

procedure TMainForm.btnOpenDirClick(Sender: TObject);
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] = '/') then
  begin
    DoOpenDir(clFTP.CurrentDir + lbList.Items[lbList.ItemIndex]);
  end;
end;

procedure TMainForm.btnGoUpClick(Sender: TObject);
begin
  clFTP.ChangeToParentDir();
  FillDirList();
end;

procedure TMainForm.btnAbortClick(Sender: TObject);
begin
  clFTP.Abort();
  UpdateStatuses();
end;

procedure TMainForm.btnDownloadClick(Sender: TObject);
var
  stream: TStream;
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] <> '/') then
  begin
    SaveDialog.FileName := lbList.Items[lbList.ItemIndex];
    if SaveDialog.Execute() then
    begin
      stream := TFileStream.Create(SaveDialog.FileName, fmCreate);
      try
        ProgressBar.Min := 0;
        ProgressBar.Max := clFTP.GetFileSize(lbList.Items[lbList.ItemIndex]);
        ProgressBar.Position := 0;
        clFTP.GetFile(lbList.Items[lbList.ItemIndex], stream);
        ShowMessage('Done');
      finally
        stream.Free();
      end;
    end;
  end;
end;

procedure TMainForm.btnUploadClick(Sender: TObject);
var
  stream: TStream;
begin
  if OpenDialog.Execute() then
  begin
    stream := TFileStream.Create(OpenDialog.FileName, fmOpenRead);
    try
      ProgressBar.Min := 0;
      ProgressBar.Max := stream.Size;
      ProgressBar.Position := 0;
      clFTP.PutFile(stream, ExtractFileName(OpenDialog.FileName));
      ShowMessage('Done');
    finally
      stream.Free();
    end;
    FillDirList();
  end;
end;

procedure TMainForm.clFTPDirectoryListing(Sender: TObject;
  AFileInfo: TclFtpFileInfo; const Source: String);
const
  dirPrefix: array[Boolean] of string = ('', '/');
begin
  lbList.Items.Add(dirPrefix[AFileInfo.IsDirectory or AFileInfo.IsLink] + AFileInfo.FileName);
end;

procedure TMainForm.clFTPProgress(Sender: TObject; ABytesProceed,
  ATotalBytes: Int64);
begin
  ProgressBar.Position := ABytesProceed;
  ProgressBar.Max := ATotalBytes;
end;

end.
