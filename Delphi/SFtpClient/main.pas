unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, clUtils, newDlg, fileDlg, clTcpClient, clSFtp,
  clSFtpUtils, DemoBaseFormUnit, ExtCtrls, clTcpClientSsh;

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
    lbList: TListBox;
    Label7: TLabel;
    OpenDialog: TOpenDialog;
    SaveDialog: TSaveDialog;
    clSFtp1: TclSFtp;
    procedure btnLoginClick(Sender: TObject);
    procedure btnLogoutClick(Sender: TObject);
    procedure btnOpenDirClick(Sender: TObject);
    procedure btnGoUpClick(Sender: TObject);
    procedure btnMakeDirClick(Sender: TObject);
    procedure btnRemoveDirClick(Sender: TObject);
    procedure btnDeleteFileClick(Sender: TObject);
    procedure btnRenameClick(Sender: TObject);
    procedure btnDownloadClick(Sender: TObject);
    procedure btnUploadClick(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure clSFtp1Progress(Sender: TObject; ABytesProceed,
      ATotalBytes: Int64);
    procedure clSFtp1ReceiveResponse(Sender: TObject; AFxpCommand: Integer;
      ABuffer: TStream);
    procedure clSFtp1SendCommand(Sender: TObject; AFxpCommand: Integer;
      ABuffer: TStream);
    procedure clSFtp1ShowBanner(Sender: TObject; const AMessage,
      ALanguage: string);
    procedure clSFtp1DirectoryListing(Sender: TObject; const AFileName: string;
      AFileAttrs: TclSFtpFileAttrs);
    procedure FormShow(Sender: TObject);
    procedure clSFtp1VerifyServer(Sender: TObject; const AHost, AKeyType,
      AFingerPrint, AHostKey: String; var AVerified: Boolean);
  private
    function GetProgressBarPos(APosition, ASize: Int64): Integer;
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
  states: array[Boolean] of string = ('SFTP Client (Sample)', 'SFTP Client - Connected (Sample)');
var
  enabled: Boolean;
begin
  enabled := clSFtp1.Active;
  Caption := states[enabled];
  btnOpenDir.Enabled := enabled;
  btnGoUp.Enabled := enabled;
  btnMakeDir.Enabled := enabled;
  btnRemoveDir.Enabled := enabled;
  btnDeleteFile.Enabled := enabled;
  btnRename.Enabled := enabled;
  btnDownload.Enabled := enabled;
  btnUpload.Enabled := enabled;
end;

procedure TMainForm.btnLoginClick(Sender: TObject);
begin
  if clSFtp1.Active then
  begin
    ShowMessage('You are already connected. Please click Logout to disconnect.');
    Exit;
  end;

  clSFtp1.Port := StrToInt(edtPort.Text);
  clSFtp1.Server := edtServer.Text;
  clSFtp1.UserName := edtUser.Text;
  clSFtp1.Password := edtPassword.Text;
  clSFtp1.Open();
  if (edtStartDir.Text = '') then
  begin
    edtStartDir.Text := clSFtp1.CurrentDir;
  end;
  if (edtStartDir.Text <> '') and (edtStartDir.Text[1] = '/') then
  begin
    DoOpenDir(edtStartDir.Text);
  end;
  UpdateStatuses();

  ProgressBar.Position := 0;
end;

procedure TMainForm.btnLogoutClick(Sender: TObject);
begin
  clSFtp1.Close();
  lbList.Items.Clear();
  UpdateStatuses();
  ProgressBar.Position := 0;
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
  clSFtp1.ChangeCurrentDir('/');
  clSFtp1.ChangeCurrentDir(dir);
  FillDirList();
end;

procedure TMainForm.FillDirList;
begin
  lbList.Items.BeginUpdate();
  try
    lbList.Items.Clear();
    clSFtp1.DirectoryListing();
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
    DoOpenDir(clSFtp1.CurrentDir + lbList.Items[lbList.ItemIndex]);
  end;
end;

procedure TMainForm.btnGoUpClick(Sender: TObject);
begin
  clSFtp1.ChangeToParentDir();
  FillDirList();
end;

procedure TMainForm.btnMakeDirClick(Sender: TObject);
var
  s: string;
begin
  s := TNewDialog.ShowNewDialog('New Dir Name', 'NewName');
  if (s <> '') then
  begin
    clSFtp1.MakeDir(s);
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
      clSFtp1.RemoveDir(clSFtp1.CurrentDir + lbList.Items[lbList.ItemIndex]);
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
      clSFtp1.Delete(lbList.Items[lbList.ItemIndex]);
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
      clSFtp1.Rename(lbList.Items[lbList.ItemIndex], s);
      FillDirList();
    end;
  end;
end;

procedure TMainForm.btnDownloadClick(Sender: TObject);
var
  size, position: Int64;
  fileExistsResult: Integer;
  stream: TStream;
begin
  if (lbList.ItemIndex > -1) and
    (lbList.Items[lbList.ItemIndex] <> '') and
    (lbList.Items[lbList.ItemIndex][1] <> '/') then
  begin
    SaveDialog.FileName := lbList.Items[lbList.ItemIndex];
    if SaveDialog.Execute() then
    begin
      size := clSFtp1.GetFileSize(lbList.Items[lbList.ItemIndex]);
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
              FreeAndNil(stream);
              stream := TFileStream.Create(SaveDialog.FileName, fmCreate);
            end;
          end;
        end else
        begin
          stream := TFileStream.Create(SaveDialog.FileName, fmCreate);
        end;
        ProgressBar.Position := GetProgressBarPos(position, size);

        clSFtp1.GetFile(lbList.Items[lbList.ItemIndex], stream, position, size);
      finally
        stream.Free();
      end;

      ShowMessage('Done');
    end;
  end;
end;

procedure TMainForm.btnUploadClick(Sender: TObject);
var
  position: Int64;
  fileExistsResult: Integer;
  stream: TStream;
  fileName: string;
begin
  if OpenDialog.Execute() then
  begin
    position := 0;
    stream := TFileStream.Create(OpenDialog.FileName, fmOpenRead);
    try
      fileName := ExtractFileName(OpenDialog.FileName);
      if clSFtp1.FileExists(fileName) then
      begin
        fileExistsResult := TFileExistsDialog.ShowFileDialog(fileName);
        if (fileExistsResult = mrCancel) then Exit;

        if (fileExistsResult = mrNo) then
        begin
          position := clSFtp1.GetFileSize(fileName);
          if (stream.Size <= position) then
          begin
            position := 0;
          end;
        end;
      end;
      ProgressBar.Position := GetProgressBarPos(position, stream.Size);

      clSFtp1.PutFile(stream, fileName, position, stream.Size - position);
    finally
      stream.Free();
    end;

    FillDirList();

    ShowMessage('Done');
  end;
end;

procedure TMainForm.clSFtp1DirectoryListing(Sender: TObject;
  const AFileName: string; AFileAttrs: TclSFtpFileAttrs);
const
  dirPrefix: array[Boolean] of string = ('', '/');
begin
  lbList.Items.Add(dirPrefix[AFileAttrs.IsDir] + AFileName);
end;

procedure TMainForm.clSFtp1Progress(Sender: TObject; ABytesProceed, ATotalBytes: Int64);
begin
  ProgressBar.Position := GetProgressBarPos(ABytesProceed, ATotalBytes);
end;

procedure TMainForm.clSFtp1ReceiveResponse(Sender: TObject; AFxpCommand: Integer; ABuffer: TStream);
begin
  if not (AFxpCommand in [SSH_FXP_READ, SSH_FXP_WRITE, SSH_FXP_READDIR]) then
  begin
    memLog.Lines.Add(Format('S: %s (%d bytes)', [GetSFtpCommandName(AFxpCommand), ABuffer.Size]));
  end;
end;

procedure TMainForm.clSFtp1SendCommand(Sender: TObject; AFxpCommand: Integer; ABuffer: TStream);
begin
  if not (AFxpCommand in [SSH_FXP_READ, SSH_FXP_WRITE, SSH_FXP_READDIR]) then
  begin
    memLog.Lines.Add(Format('C: %s (%d bytes)', [GetSFtpCommandName(AFxpCommand), ABuffer.Size]));
  end;
end;

procedure TMainForm.clSFtp1ShowBanner(Sender: TObject; const AMessage, ALanguage: string);
begin
  memLog.Lines.Add('Server Banner: ' + Trim(AMessage));
end;

procedure TMainForm.clSFtp1VerifyServer(Sender: TObject; const AHost,
  AKeyType, AFingerPrint, AHostKey: String; var AVerified: Boolean);
begin
  AVerified := (MessageDlg(Format('You are trying to connect to ''%s'' host,'#13#10
    + 'Key Type: %s'#13#10
    + 'Finger Print: %s'#13#10#13#10
    + 'Do you wish to proceed ?', [AHost, AKeyType, AFingerPrint]),
    mtWarning, [mbYes, mbNo], 0) = mrYes);
end;

procedure TMainForm.FormShow(Sender: TObject);
begin
  UpdateStatuses();
end;

procedure TMainForm.FormDestroy(Sender: TObject);
begin
  clSFtp1.Close();
end;

function TMainForm.GetProgressBarPos(APosition, ASize: Int64): Integer;
begin
  if (APosition = 0) or (ASize = 0) then
  begin
    Result := 0;
  end else
  begin
    Result := Round(APosition / ASize * 100);
  end;
end;

end.
