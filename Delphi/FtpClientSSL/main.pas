unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, clFTP, clFTPUtils, clUtils, newDlg, fileDlg,
  clTcpClient, clTcpClientTls, clCertificateStore, clCertificate,
  clTcpCommandClient, DemoBaseFormUnit, ExtCtrls, clFtpFileInfo;

type
  TMainForm = class(TclDemoBaseForm)
    Label3: TLabel;
    memLog: TMemo;
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
    btnMakeDir: TButton;
    btnRemoveDir: TButton;
    btnDownload: TButton;
    btnUpload: TButton;
    btnDeleteFile: TButton;
    btnRename: TButton;
    btnAbort: TButton;
    lbList: TListBox;
    Label7: TLabel;
    clFTP: TclFTP;
    OpenDialog: TOpenDialog;
    SaveDialog: TSaveDialog;
    cbUseTLS: TCheckBox;
    procedure btnLoginClick(Sender: TObject);
    procedure btnLogoutClick(Sender: TObject);
    procedure btnOpenDirClick(Sender: TObject);
    procedure btnGoUpClick(Sender: TObject);
    procedure btnMakeDirClick(Sender: TObject);
    procedure btnRemoveDirClick(Sender: TObject);
    procedure btnDeleteFileClick(Sender: TObject);
    procedure btnRenameClick(Sender: TObject);
    procedure btnAbortClick(Sender: TObject);
    procedure btnDownloadClick(Sender: TObject);
    procedure btnUploadClick(Sender: TObject);
    procedure clFTPDirectoryListing(Sender: TObject;
      AFileInfo: TclFtpFileInfo; const Source: String);
    procedure clFTPReceiveResponse(Sender: TObject; AList: TStrings);
    procedure clFTPProgress(Sender: TObject; ABytesProceed,
      ATotalBytes: Int64);
    procedure clFTPSendCommand(Sender: TObject; const AText: String);
    procedure FormDestroy(Sender: TObject);
    procedure clFTPVerifyServer(Sender: TObject;
      ACertificate: TclCertificate; const AStatusText: String;
      AStatusCode: Integer; var AVerified: Boolean);
    procedure cbUseTLSClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    FCertificateVerified: Boolean;
    procedure UpdateStatuses;
    procedure DoOpenDir(const ADir: string);
    procedure FillDirList;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

{ TMainForm }

procedure TMainForm.UpdateStatuses;
const
  states: array[Boolean] of string = ('Ftp Client Sample', 'Ftp Client Sample - Connected');
var
  enabled: Boolean;
begin
  enabled := clFTP.Active;
  Caption := states[enabled];
  btnOpenDir.Enabled := enabled;
  btnGoUp.Enabled := enabled;
  btnMakeDir.Enabled := enabled;
  btnRemoveDir.Enabled := enabled;
  btnDownload.Enabled := enabled;
  btnUpload.Enabled := enabled;
  btnDeleteFile.Enabled := enabled;
  btnRename.Enabled := enabled;
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

  FCertificateVerified := False;

  clFTP.Port := StrToInt(edtPort.Text);
  clFTP.Server := edtServer.Text;
  clFTP.UserName := edtUser.Text;
  clFTP.Password := edtPassword.Text;
  clFTP.PassiveMode := cbPassiveMode.Checked;
  clFTP.TransferType := transferTypes[cbAsciiMode.Checked];

  if cbUseTLS.Checked then
  begin
    clFTP.UseTLS := ctAutomatic;
  end else
  begin
    clFTP.UseTLS := ctNone;
  end;

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

procedure TMainForm.btnMakeDirClick(Sender: TObject);
var
  s: string;
begin
  s := TNewDialog.ShowNewDialog('New Dir Name', 'NewName');
  if (s <> '') then
  begin
    clFTP.MakeDir(s);
    FillDirList();
  end;
end;

procedure TMainForm.btnRemoveDirClick(Sender: TObject);
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] = '/') then
  begin
    if (MessageDlg('Do you wish to delete the ' + lbList.Items[lbList.ItemIndex] + ' directory ?',
      mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
    begin
      clFTP.RemoveDir(clFTP.CurrentDir + lbList.Items[lbList.ItemIndex]);
      FillDirList();
    end;
  end;
end;

procedure TMainForm.btnDeleteFileClick(Sender: TObject);
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] <> '/') then
  begin
    if (MessageDlg('Do you wish to delete the ' + lbList.Items[lbList.ItemIndex] + ' file ?',
      mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
    begin
      clFTP.Delete(lbList.Items[lbList.ItemIndex]);
      FillDirList();
    end;
  end;
end;

procedure TMainForm.btnRenameClick(Sender: TObject);
var
  s: string;
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] <> '/') then
  begin
    s := TNewDialog.ShowNewDialog('New File Name', lbList.Items[lbList.ItemIndex]);
    if (s <> '') and (s <> lbList.Items[lbList.ItemIndex]) then
    begin
      clFTP.Rename(lbList.Items[lbList.ItemIndex], s);
      FillDirList();
    end;
  end;
end;

procedure TMainForm.btnAbortClick(Sender: TObject);
begin
  clFTP.Abort();
  UpdateStatuses();
end;

procedure TMainForm.btnDownloadClick(Sender: TObject);
var
  size, position, fileExistsResult: Integer;
  stream: TStream;
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] <> '/') then
  begin
    SaveDialog.FileName := lbList.Items[lbList.ItemIndex];
    if SaveDialog.Execute() then
    begin
      size := clFTP.GetFileSize(lbList.Items[lbList.ItemIndex]);
      position := 0;
      stream := nil;
      try
        if FileExists(SaveDialog.FileName) then
        begin
          fileExistsResult := TFileExistsDialog.ShowFileDialog(SaveDialog.FileName);
          if (fileExistsResult = mrCancel) then Exit;
          if (fileExistsResult = mrYes) then
          begin
            stream := TFileStream.Create(SaveDialog.FileName, fmCreate);
          end else
          begin
            stream := TFileStream.Create(SaveDialog.FileName, fmOpenReadWrite);
            if (size > stream.Size) then
            begin
              position := stream.Size;
            end else
            begin
              stream.Free();
              stream := nil; 
              stream := TFileStream.Create(SaveDialog.FileName, fmCreate);
            end;
          end;
        end else
        begin
          stream := TFileStream.Create(SaveDialog.FileName, fmCreate);
        end;
        ProgressBar.Min := 0;
        ProgressBar.Max := size;
        ProgressBar.Position := position;
        clFTP.GetFile(lbList.Items[lbList.ItemIndex], stream, position, -1);
        ShowMessage('Done');
      finally
        stream.Free();
      end;
    end;
  end;
end;

procedure TMainForm.btnUploadClick(Sender: TObject);
var
  position, fileExistsResult: Integer;
  stream: TStream;
  fileName: string;
begin
  if OpenDialog.Execute() then
  begin
    position := 0;
    stream := TFileStream.Create(OpenDialog.FileName, fmOpenRead);
    try
      fileName := ExtractFileName(OpenDialog.FileName);
      if clFTP.FileExists(fileName) then
      begin
        fileExistsResult := TFileExistsDialog.ShowFileDialog(fileName);
        if (fileExistsResult = mrCancel) then Exit;
        if (fileExistsResult = mrNo) then
        begin
          position := clFTP.GetFileSize(fileName);
          if (stream.Size <= position) then
          begin
            position := 0;
          end;
        end;
      end;
      ProgressBar.Min := 0;
      ProgressBar.Max := stream.Size;
      ProgressBar.Position := position;
      clFTP.PutFile(stream, fileName, position, -1);
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

procedure TMainForm.clFTPSendCommand(Sender: TObject; const AText: String);
begin
  memLog.Lines.Add(Trim(AText));
end;

procedure TMainForm.clFTPReceiveResponse(Sender: TObject; AList: TStrings);
begin
  memLog.Lines.AddStrings(AList);
end;

procedure TMainForm.clFTPProgress(Sender: TObject; ABytesProceed,
  ATotalBytes: Int64);
begin
  ProgressBar.Position := ABytesProceed;
  ProgressBar.Max := ATotalBytes;
end;

procedure TMainForm.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 550;
 {$ENDIF}
  UpdateStatuses();
end;

procedure TMainForm.FormDestroy(Sender: TObject);
begin
  clFTP.Close();
end;

procedure TMainForm.clFTPVerifyServer(Sender: TObject;
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

procedure TMainForm.cbUseTLSClick(Sender: TObject);
begin
  cbPassiveMode.Enabled := not cbUseTLS.Checked;
  if cbUseTLS.Checked then
  begin
    cbPassiveMode.Checked := True;
  end;
end;

end.
