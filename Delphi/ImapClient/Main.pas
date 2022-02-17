unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, clTcpClient, clMC, clImap4, clImapUtils, ImgList, clMailMessage,
  MessageFrm, NewFolderDlg, SearchDlg, CopyDlg, clTcpClientTls,
  clTcpCommandClient, DemoBaseFormUnit, ExtCtrls;

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
    btnLogin: TButton;
    btnLogout: TButton;
    tvFolders: TTreeView;
    lvMessages: TListView;
    clImap: TclImap4;
    Images: TImageList;
    clMailMessage: TclMailMessage;
    cbUseSPA: TCheckBox;
    Label3: TLabel;
    edtTimeOut: TEdit;
    GroupBox1: TGroupBox;
    Label7: TLabel;
    edtSubscribed: TEdit;
    edtAll: TEdit;
    Label8: TLabel;
    edtRecent: TEdit;
    Label9: TLabel;
    edtFirstUnseen: TEdit;
    Label10: TLabel;
    Label11: TLabel;
    memLog: TMemo;
    btnNewFolder: TButton;
    btnDeleteFolder: TButton;
    btnFind: TButton;
    btnSubscribe: TButton;
    btnUnsubscribe: TButton;
    btnAppend: TButton;
    btnCopy: TButton;
    btnDelete: TButton;
    btnPurge: TButton;
    procedure btnLoginClick(Sender: TObject);
    procedure btnLogoutClick(Sender: TObject);
    procedure tvFoldersChange(Sender: TObject; Node: TTreeNode);
    procedure lvMessagesDblClick(Sender: TObject);
    procedure btnNewFolderClick(Sender: TObject);
    procedure btnDeleteFolderClick(Sender: TObject);
    procedure btnFindClick(Sender: TObject);
    procedure btnSubscribeClick(Sender: TObject);
    procedure btnUnsubscribeClick(Sender: TObject);
    procedure btnAppendClick(Sender: TObject);
    procedure btnCopyClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnPurgeClick(Sender: TObject);
    procedure clImapReceiveResponse(Sender: TObject; AList: TStrings);
    procedure clImapSendCommand(Sender: TObject; const AText: string);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
  private
    FSubscribeStatus: TStrings;

    procedure GetFolderList;
    procedure UpdateStatuses;
    procedure AddFolderToList(AName: string);
    procedure GetMessageList;
    function GetFolderName(Node: TTreeNode): string;
    function GetSubscribeStatus(const AFolder: string): Boolean;
    procedure SetSubscribeStatus(const AFolder: string; AStatus: Boolean);
  end;

var
  Form1: TForm1;

implementation

const
  SubscribeStatus: array[Boolean] of string = ('No', 'Yes');

{$R *.dfm}

procedure TForm1.btnAppendClick(Sender: TObject);
begin
  if tvFolders.Selected = nil then Exit;

  if (TMessageForm.ComposeMessage(clMailMessage)) then
  begin
    clImap.AppendMessage(GetFolderName(tvFolders.Selected), clMailMessage, []);
    tvFoldersChange(nil, nil);
  end;
end;

procedure TForm1.btnCopyClick(Sender: TObject);
var
  dest: string;
  list: TStrings;
begin
  if lvMessages.SelCount <> 1 then Exit;

  list := TStringList.Create();
  try
    clImap.GetMailBoxes(list);
    dest := TCopyDialog.ShowCopyDialog(list);
    if (dest <> '') then
    begin
      clImap.CopyMessage(StrToInt(lvMessages.Selected.Caption), dest);
      GetFolderList();
    end;
  finally
    list.Free();
  end;
end;

procedure TForm1.btnDeleteClick(Sender: TObject);
begin
  if ((tvFolders.Selected <> nil) and (lvMessages.SelCount = 1)) then
  begin
    clImap.DeleteMessage(StrToInt(lvMessages.Selected.Caption));
    tvFoldersChange(nil, nil);
  end;
end;

procedure TForm1.btnDeleteFolderClick(Sender: TObject);
begin
  if (tvFolders.Selected <> nil) then
  begin
    if (MessageDlg('Do you wish to delete the ' + GetFolderName(tvFolders.Selected) + ' folder ?',
      mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
    begin
      clImap.DeleteMailBox(GetFolderName(tvFolders.Selected));
      GetFolderList();
    end;
  end;
end;

procedure TForm1.btnFindClick(Sender: TObject);
var
  dlg: TSearchDialog;
  list: TStrings;
begin
  if tvFolders.Selected = nil then Exit;

  dlg := nil;
  list := nil;
  try
    dlg := TSearchDialog.Create(nil);
    if (dlg.ShowModal() = mrOk) then
    begin
      list := TStringList.Create();
      clImap.SearchMessages(dlg.GetSearchCriteria(), list);

      if (list.Count = 0) then
      begin
        ShowMessage('No messages found.');
      end else
      begin
        ShowMessage(Format('Found %d message(s).'#13#10
          + ' Message numbers: '#13#10'%s', [list.Count, list.CommaText]));
      end;
    end;
  finally
    list.Free();
    dlg.Free();
  end;
end;

procedure TForm1.btnLoginClick(Sender: TObject);
begin
  if clImap.Active then
  begin
    ShowMessage('You are already connected. Please click Logout to disconnect.');
    Exit;
  end;

  clImap.Server := edtServer.Text;
  clImap.Port := StrToInt(edtPort.Text);
  clImap.UserName := edtUser.Text;
  clImap.Password := edtPassword.Text;
  clImap.UseSasl := cbUseSPA.Checked;
  clImap.TimeOut := StrToInt(edtTimeOut.Text) * 1000;

  clImap.Open();

  GetFolderList();

  UpdateStatuses();
end;

procedure TForm1.GetFolderList;
var
  i: integer;
  mailboxes, subscribed: TStrings;
  item: string;
begin
  mailboxes := nil;
  subscribed := nil;
  tvFolders.Items.BeginUpdate();
  try
    mailboxes := TStringList.Create();
    subscribed := TStringList.Create();

    FSubscribeStatus.Clear();
    tvFolders.Items.Clear();
    lvMessages.Items.Clear();

    edtSubscribed.Text := '';
    edtAll.Text := '';
    edtRecent.Text := '';
    edtFirstUnseen.Text := '';

    clImap.GetMailBoxes(mailboxes);

    clImap.GetSubscribedMailBoxes(subscribed);

    for i := 0 to mailboxes.Count - 1 do
    begin
      item := mailboxes[i];
      AddFolderToList(item);
      SetSubscribeStatus(item, subscribed.IndexOf(item) > -1);
    end;
  finally
    tvFolders.Items.EndUpdate();
    subscribed.Free();
    mailboxes.Free();
  end;
end;

function TForm1.GetFolderName(Node: TTreeNode): string;
begin
  if (Node = nil) then
  begin
    Result := ''
  end else
  begin
    Result := Node.Text;
    while (Node.Parent <> nil) do
    begin
      Node := Node.Parent;
      Result := Node.Text + clImap.MailBoxSeparator + Result;
    end;
  end;
end;

procedure TForm1.AddFolderToList(AName: string);
var
  Papa, N: TTreeNode;
  S: string;
  i: Integer;
begin
  Papa := nil;
  N := tvFolders.Items.GetFirstNode();
  if AName[1] = clImap.MailBoxSeparator then
  begin
    Delete(AName, 1, 1);
  end;

  while True do
  begin
    i := Pos(clImap.MailBoxSeparator, AName);
    if (i = 0) then
    begin
      Papa := tvFolders.Items.AddChild(Papa, AName);
      Papa.ImageIndex := 0;
      Papa.SelectedIndex := 0;
      Break;
    end else
    begin
      S := Copy(AName, 1, i - 1);
      Delete(AName, 1, i);
      while ((N <> nil) and (N.Text <> S)) do
      begin
        N := N.getNextSibling;
      end;
      if (N = nil) then
      begin
        Papa := tvFolders.Items.AddChild(Papa, S);
      end else
      begin
        Papa := N;
      end;
      N := Papa.GetFirstChild();
    end;
  end;
end;

procedure TForm1.btnLogoutClick(Sender: TObject);
begin
  clImap.Close();

  FSubscribeStatus.Clear();
  tvFolders.Items.Clear();
  lvMessages.Items.Clear();

  edtSubscribed.Text := '';
  edtAll.Text := '';
  edtRecent.Text := '';
  edtFirstUnseen.Text := '';

  UpdateStatuses();
end;

procedure TForm1.btnNewFolderClick(Sender: TObject);
var
  dlg: TNewFolderDialog;
begin
  dlg := TNewFolderDialog.Create(nil);
  try
    if (dlg.ShowModal() = mrOk) then
    begin
      if (dlg.cbIsSubfolder.Checked and (tvFolders.Selected <> nil)) then
      begin
        clImap.CreateMailBox(GetFolderName(tvFolders.Selected) + clImap.MailBoxSeparator + dlg.edtName.Text);
      end else
      begin
        clImap.CreateMailBox(dlg.edtName.Text);
      end;

      GetFolderList();
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnPurgeClick(Sender: TObject);
begin
  if tvFolders.Selected = nil then Exit;

  if (MessageDlg('Purge all marked as deleted messages in selected folder ?',
    mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
  begin
    clImap.PurgeMessages();
    tvFoldersChange(nil, nil);
  end;
end;

procedure TForm1.btnSubscribeClick(Sender: TObject);
var
  s: string;
begin
  s := GetFolderName(tvFolders.Selected);
  if (tvFolders.Selected <> nil) and (not GetSubscribeStatus(s)) then
  begin
    clImap.SubscribeMailBox(s);
    SetSubscribeStatus(s, True);
    tvFoldersChange(nil, nil);
    ShowMessage(Format('The folder %s has been subscribed.', [s]));
  end;
end;

procedure TForm1.btnUnsubscribeClick(Sender: TObject);
var
  s: string;
begin
  s := GetFolderName(tvFolders.Selected);
  if (tvFolders.Selected <> nil) and GetSubscribeStatus(s) then
  begin
    clImap.UnsubscribeMailBox(s);
    SetSubscribeStatus(s, False);
    tvFoldersChange(nil, nil);
    ShowMessage(Format('The folder %s has been unsubscribed.', [s]));
  end;
end;

procedure TForm1.clImapReceiveResponse(Sender: TObject; AList: TStrings);
begin
  if (AList.Count > 0) then
  begin
    memLog.Lines.Add(AList[0]);
  end;
end;

procedure TForm1.clImapSendCommand(Sender: TObject; const AText: string);
begin
  memLog.Lines.Add(Trim(AText));
end;

procedure TForm1.tvFoldersChange(Sender: TObject; Node: TTreeNode);
begin
  if clImap.Active and Assigned(tvFolders.Selected) then
  begin
    clImap.SelectMailBox(GetFolderName(tvFolders.Selected));

    edtSubscribed.Text := SubscribeStatus[GetSubscribeStatus(GetFolderName(tvFolders.Selected))];
    edtAll.Text := IntToStr(clImap.CurrentMailBox.ExistsMessages);
    edtRecent.Text := IntToStr(clImap.CurrentMailBox.RecentMessages);
    edtFirstUnseen.Text := IntToStr(clImap.CurrentMailBox.FirstUnseen);

    GetMessageList();
  end;
end;

procedure TForm1.UpdateStatuses;
const
  acaption: array[Boolean] of string = ('IMAP Client', 'IMAP Client - Connected');
var
  enabled: Boolean;
begin
  enabled := clImap.Active;
  Caption := acaption[enabled];
  btnAppend.Enabled := enabled;
  btnCopy.Enabled := enabled;
  btnDelete.Enabled := enabled;
  btnDeleteFolder.Enabled := enabled;
  btnFind.Enabled := enabled;
  btnNewFolder.Enabled := enabled;
  btnPurge.Enabled := enabled;
  btnSubscribe.Enabled := enabled;
  btnUnsubscribe.Enabled := enabled;
end;

procedure TForm1.GetMessageList;
var
  i: Integer;
  Item: TListItem;
  flags: TclMailMessageFlags;
  s: string;
begin
  lvMessages.Items.Clear();

  if not clImap.Active then Exit;

  for i := 1 to clImap.CurrentMailBox.ExistsMessages do
  begin
    try
      clImap.RetrieveHeader(i, clMailMessage);

      Item := lvMessages.Items.Add();
      Item.Caption := IntToStr(i);

      Item.SubItems.Add(clMailMessage.Subject);
      Item.SubItems.Add(clMailMessage.From.FullAddress);

      flags := clImap.GetMessageFlags(i);
      s := '';

      if (mfAnswered in flags) then s := s + 'Answered,';
      if (mfFlagged in flags) then s := s + 'Flagged,';
      if (mfDeleted in flags) then s := s + 'Deleted,';
      if (mfSeen in flags) then s := s + 'Seen,';
      if (mfDraft in flags) then s := s + 'Draft,';
      if (mfRecent in flags) then s := s + 'Recent,';

      Item.SubItems.Add(s);
    except
      on EclTcpClientError do
      begin
        Item := lvMessages.Items.Add();
        Item.Caption := IntToStr(i);

        Item.SubItems.Add('(bad message)');
        Item.SubItems.Add('');
        Item.SubItems.Add('');
      end;
    end;
  end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 547;
  Width := 694;
 {$ENDIF}
  FSubscribeStatus := TStringList.Create();
  UpdateStatuses();
end;

procedure TForm1.FormDestroy(Sender: TObject);
begin
  clImap.Close();
  FSubscribeStatus.Free();
end;

procedure TForm1.lvMessagesDblClick(Sender: TObject);
begin
  if clImap.Active and (lvMessages.Selected <> nil) then
  begin
    clImap.RetrieveMessage(StrToInt(lvMessages.Selected.Caption), clMailMessage);
    clImap.SetMessageFlags(StrToInt(lvMessages.Selected.Caption), fmAdd, [mfSeen]);

    TMessageForm.ShowMessage(clMailMessage);
    tvFoldersChange(nil, nil);
  end;
end;

function TForm1.GetSubscribeStatus(const AFolder: string): Boolean;
var
  ind: Integer;
begin
  ind := FSubscribeStatus.IndexOf(AFolder);
  if (ind >  -1) then
  begin
    Result := Boolean(Integer(FSubscribeStatus.Objects[ind]));
  end else
  begin
    Result := False;
  end;
end;

procedure TForm1.SetSubscribeStatus(const AFolder: string; AStatus: Boolean);
var
  ind: Integer;
begin
  ind := FSubscribeStatus.IndexOf(AFolder);
  if (ind >  -1) then
  begin
    FSubscribeStatus.Objects[ind] := TObject(Integer(AStatus));
  end else
  begin
    FSubscribeStatus.AddObject(AFolder, TObject(Integer(AStatus)))
  end;
end;

end.
