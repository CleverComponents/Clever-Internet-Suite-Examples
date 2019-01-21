unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clTcpClient, clHttp, clWebDav, ComCtrls, ViewProps,
  ModifyProps, CopyMove, clTcpClientTls, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtHost: TEdit;
    Label2: TLabel;
    btnOpen: TButton;
    clWebDav1: TclWebDav;
    Label3: TLabel;
    Label4: TLabel;
    edtUser: TEdit;
    edtPassword: TEdit;
    lvResources: TListView;
    btnGetAllProps: TButton;
    btnModifyProp: TButton;
    btnMakeDir: TButton;
    btnDelete: TButton;
    btnLock: TButton;
    btnUnlock: TButton;
    btnCopyMove: TButton;
    btnDownload: TButton;
    btnUpload: TButton;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    Label5: TLabel;
    cbDepth: TComboBox;
    btnCapabilities: TButton;
    btnGoUp: TButton;
    procedure btnOpenClick(Sender: TObject);
    procedure btnGetAllPropsClick(Sender: TObject);
    procedure btnLockClick(Sender: TObject);
    procedure btnUnlockClick(Sender: TObject);
    procedure btnMakeDirClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnModifyPropClick(Sender: TObject);
    procedure btnCopyMoveClick(Sender: TObject);
    procedure btnDownloadClick(Sender: TObject);
    procedure btnUploadClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnCapabilitiesClick(Sender: TObject);
    procedure btnGoUpClick(Sender: TObject);
    procedure lvResourcesDblClick(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
  private
    FCurrentDir: string;
    FResources: TStrings;
    FLocks: TStrings;
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnOpenClick(Sender: TObject);
var
  i: Integer;
  item: TListItem;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;

  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);
  clWebDav1.ListDir(edtHost.Text);
  FCurrentDir := edtHost.Text;

  lvResources.Items.Clear();

  for i := 0 to clWebDav1.ResourceProperties.Count - 1 do
  begin
    item := lvResources.Items.Add();
    item.Caption := clWebDav1.ResourceProperties[i].Uri;
  end;
end;

procedure TForm1.btnGetAllPropsClick(Sender: TObject);
var
  dlg: TViewPropsForm;
  i: Integer;
  url: string;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;

  if (cbDepth.ItemIndex = 0) then
  begin
    clWebDav1.Depth := wdResourceOnly;
  end else
  begin
    clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);
  end;

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;
  clWebDav1.GetAllProperties(url);

  clWebDav1.GetActiveLocks(url);

  dlg := TViewPropsForm.Create(nil);
  try
    dlg.Memo1.Clear();
    dlg.Memo1.Lines.Add(url);
    dlg.Memo1.Lines.Add('');
    dlg.Memo1.Lines.Add('Properties:');

    for i := 0 to clWebDav1.ResourceProperties.Count - 1 do
    begin
      dlg.Memo1.Lines.Add(clWebDav1.ResourceProperties[i].Name + ' = ' + clWebDav1.ResourceProperties[i].Value);
    end;

    dlg.Memo1.Lines.Add('');
    dlg.Memo1.Lines.Add('Active Locks:');

    for i := 0 to clWebDav1.ActiveLocks.Count - 1 do
    begin
      dlg.Memo1.Lines.Add('Owner: '+ clWebDav1.ActiveLocks[i].Owner);
      dlg.Memo1.Lines.Add('Lock Token: ' + clWebDav1.ActiveLocks[i].LockToken);
      dlg.Memo1.Lines.Add('Lock Type: ' + clWebDav1.ActiveLocks[i].LockType);
      dlg.Memo1.Lines.Add('Lock Timeout: ' + clWebDav1.ActiveLocks[i].TimeOut);
    end;

    dlg.ShowModal();
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnLockClick(Sender: TObject);
var
  url, lockToken: string;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;

  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);
  clWebDav1.LockOwner := 'WebDAV tester';
  clWebDav1.LockScope := wsExclusive;

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;
  lockToken := clWebDav1.Lock(url);
  FResources.Add(url);
  FLocks.Add(lockToken);

  ShowMessage('The ' + url + ' resource has been locked successfully.'#13#10#13#10' Lock Token = ' + lockToken);
end;

procedure TForm1.btnUnlockClick(Sender: TObject);
var
  url: string;
  i: Integer;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;

  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);
  clWebDav1.LockOwner := 'WebDAV tester';
  clWebDav1.LockScope := wsExclusive;

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;

  Assert(FResources.Count = FLocks.Count);

  for i := 0 to FResources.Count - 1 do
  begin
    if SameText(FResources[i], url) then
    begin
      clWebDav1.Unlock(url, FLocks[i]);
    end;
  end;

  ShowMessage('The ' + url + ' resource has been unlocked.');
end;

procedure TForm1.btnMakeDirClick(Sender: TObject);
var
  newDir: string;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;
  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);

  if (lvResources.Selected <> nil) then
  begin
    newDir := lvResources.Selected.Caption;
  end else
  begin
    newDir := edtHost.Text;
  end;

  if InputQuery('Make new directory', 'Enter a name for new directory', newDir) then
  begin
    clWebDav1.MakeDir(newDir);
    btnOpenClick(nil);
  end;
end;

procedure TForm1.btnDeleteClick(Sender: TObject);
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;
  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);

  if (lvResources.Selected = nil) then
  begin
    raise Exception.Create('Please select a resource');
  end;

  if (MessageDlg('Do you want to delete ' + lvResources.Selected.Caption + ' ?',
    mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
  begin
    clWebDav1.Delete(lvResources.Selected.Caption);
    btnOpenClick(nil);
  end;
end;

procedure TForm1.btnModifyPropClick(Sender: TObject);
var
  dlg: TModifyPropForm;
  url: string;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;
  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;

  dlg := TModifyPropForm.Create(nil);
  try
    dlg.lblResource.Caption := url;
    case dlg.ShowModal() of
      mrYes:
        begin
          clWebDav1.SetProperties(url, [dlg.edtName.Text], [dlg.edtValue.Text]);
          ShowMessage('Property ''' + dlg.edtName.Text + ''' added / modified.');
        end;
      mrNo:
        begin
          clWebDav1.RemoveProperties(url, [dlg.edtName.Text]);
          ShowMessage('Property ''' + dlg.edtName.Text + ''' removed.');
        end;
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnCopyMoveClick(Sender: TObject);
var
  dlg: TCopyMoveForm;
  url: string;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;
  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;

  dlg := TCopyMoveForm.Create(nil);
  try
    dlg.edtSource.Text := url;
    if dlg.ShowModal() = mrOK then
    begin
      if dlg.cbIsMove.Checked then
      begin
        clWebDav1.Move(dlg.edtSource.Text, dlg.edtDestination.Text);
      end else
      begin
        clWebDav1.Copy(dlg.edtSource.Text, dlg.edtDestination.Text);
      end;

      btnOpenClick(nil);
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnDownloadClick(Sender: TObject);
var
  url: string;
  dst: TStream;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;
  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;

  if SaveDialog1.Execute() then
  begin
    dst := TFileStream.Create(SaveDialog1.FileName, fmCreate);
    try
      clWebDav1.Get(url, dst);
    finally
      dst.Free();
    end;
    ShowMessage('The resource has been downloaded and stored in to ' + SaveDialog1.FileName);
  end;
end;

procedure TForm1.btnUploadClick(Sender: TObject);
var
  url: string;
  src: TStream;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;
  clWebDav1.Depth := TclWebDavDepth(cbDepth.ItemIndex);

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;

  if OpenDialog1.Execute() then
  begin
    src := TFileStream.Create(OpenDialog1.FileName, fmOpenRead);
    try
      clWebDav1.Put(url + '/' + ExtractFileName(OpenDialog1.FileName), src);
    finally
      src.Free();
    end;
    btnOpenClick(nil);
    ShowMessage('The file has been uploaded in to ' + url);
  end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 530;
 {$ENDIF}
  FResources := TStringList.Create();
  FLocks := TStringList.Create();
  cbDepth.ItemIndex := 0;
end;

procedure TForm1.FormDestroy(Sender: TObject);
begin
  FLocks.Free();
  FResources.Free();
end;

procedure TForm1.btnCapabilitiesClick(Sender: TObject);
var
  dlg: TViewPropsForm;
  url: string;
begin
  clWebDav1.UserName := edtUser.Text;
  clWebDav1.Password := edtPassword.Text;

  if (lvResources.Selected <> nil) then
  begin
    url := lvResources.Selected.Caption;
  end else
  begin
    url := edtHost.Text;
  end;

  clWebDav1.GetCapabilities(url);

  dlg := TViewPropsForm.Create(nil);
  try
    dlg.Caption := 'WebDAV Capabilities';
    dlg.Memo1.Lines.Add('WebDav Class: ' + clWebDav1.Capabilities.WebDavClass);

    dlg.Memo1.Lines.Add('');
    dlg.Memo1.Lines.Add('Allowed Methods:');
    dlg.Memo1.Lines.AddStrings(clWebDav1.Capabilities.AllowedMethods);

    dlg.Memo1.Lines.Add('');
    dlg.Memo1.Lines.Add('Public Methods:');
    dlg.Memo1.Lines.AddStrings(clWebDav1.Capabilities.PublicMethods);

    dlg.ShowModal();
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnGoUpClick(Sender: TObject);
var
  ind: Integer;
  s: string;
begin
  s := edtHost.Text;
  if (s = '') then Exit;

  if (s[Length(s)] = '/') then
  begin
    s := Copy(s, 1, Length(s) - 1);
  end;
  ind := LastDelimiter('/', s);
  s := Copy(s, 1, ind);
  edtHost.Text := s;
  FCurrentDir := edtHost.Text;
  btnOpenClick(nil);
end;

procedure TForm1.lvResourcesDblClick(Sender: TObject);
begin
  if (lvResources.Selected <> nil) then
  begin
    edtHost.Text := lvResources.Selected.Caption;
  end;
  btnOpenClick(nil);
end;

end.
