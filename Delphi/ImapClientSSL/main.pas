unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, clTcpClient, clTcpClientTls, clMC, clImap4, ImgList, clCertificate,
  clMailMessage, clTcpCommandClient, DemoBaseFormUnit, ExtCtrls;

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
    Label6: TLabel;
    Label7: TLabel;
    edtFrom: TEdit;
    edtSubject: TEdit;
    memBody: TMemo;
    Label8: TLabel;
    Label9: TLabel;
    cbUseTLS: TCheckBox;
    clImap: TclImap4;
    Images: TImageList;
    clMailMessage: TclMailMessage;
    procedure btnLoginClick(Sender: TObject);
    procedure btnLogoutClick(Sender: TObject);
    procedure tvFoldersChange(Sender: TObject; Node: TTreeNode);
    procedure lvMessagesClick(Sender: TObject);
    procedure clImapVerifyServer(Sender: TObject; ACertificate: TclCertificate; const AStatusText: string; AStatusCode: Integer;
      var AVerified: Boolean);
  private
    FCertificateVerified: Boolean;
    procedure AddFolderToList(AName: string);
    procedure ClearMessage;
    procedure CheckLoginButtonEnabled;
    procedure FillFolderList;
    procedure FillMessages;
    procedure FillMessage(AItem: TListItem);
    function GetFolderName(Node: TTreeNode): string;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.CheckLoginButtonEnabled;
begin
  btnLogin.Enabled := not clImap.Active;
end;

procedure TForm1.btnLoginClick(Sender: TObject);
begin
  FCertificateVerified := False;

  clImap.Server := edtServer.Text;
  clImap.Port := StrToInt(edtPort.Text);

  if cbUseTLS.Checked then
  begin
    clImap.UseTLS := ctAutomatic;
  end else
  begin
    clImap.UseTLS := ctNone;
  end;

  clImap.UserName := edtUser.Text;
  clImap.Password := edtPassword.Text;

  clImap.Open();

  FillFolderList();

  CheckLoginButtonEnabled;
end;

procedure TForm1.FillFolderList;
var
  i: integer;
  list: TStrings;
begin
  list := TStringList.Create();
  try
    tvFolders.Items.BeginUpdate();
    tvFolders.Items.Clear();

    clImap.GetMailBoxes(list);

    for i := 0 to list.Count - 1 do
    begin
      AddFolderToList(list[i]);
    end;
  finally
    tvFolders.Items.EndUpdate();
    list.Free();
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
  tvFolders.Items.Clear();
  CheckLoginButtonEnabled;
end;

procedure TForm1.tvFoldersChange(Sender: TObject; Node: TTreeNode);
begin
  if clImap.Active and Assigned(tvFolders.Selected) then
  begin
    clImap.SelectMailBox(GetFolderName(tvFolders.Selected));
  end;
  FillMessages();
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

procedure TForm1.FillMessages;
var
  i: Integer;
  Item: TListItem;
begin
  lvMessages.Items.Clear();
  ClearMessage();

  if not clImap.Active then Exit;

  for i := 1 to clImap.CurrentMailBox.ExistsMessages do
  begin
    Item := lvMessages.Items.Add();
    Item.Data := Pointer(i);
    FillMessage(Item);
  end;
end;

procedure TForm1.FillMessage(AItem: TListItem);
var
  Index: Integer;
begin
  Index := Integer(AItem.Data);

  clImap.RetrieveHeader(Index, clMailMessage);

  AItem.Caption := clMailMessage.Subject;
  AItem.SubItems.Clear();

  AItem.SubItems.Add(clMailMessage.From.FullAddress);
  AItem.SubItems.Add(DateTimeToStr(clMailMessage.Date));
  AItem.SubItems.Add(IntToStr(clImap.GetMessageSize(Index)));
end;

procedure TForm1.ClearMessage;
begin
  edtFrom.Text := '';
  edtSubject.Text := '';
  memBody.Lines.Clear();
end;

procedure TForm1.clImapVerifyServer(Sender: TObject; ACertificate: TclCertificate; const AStatusText: string;
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

procedure TForm1.lvMessagesClick(Sender: TObject);
begin
  if clImap.Active and (lvMessages.Selected <> nil) then
  begin
    clImap.RetrieveMessage(Integer(lvMessages.Selected.Data), clMailMessage);

    edtFrom.Text := clMailMessage.From.FullAddress;
    edtSubject.Text := clMailMessage.Subject;
    memBody.Lines := clMailMessage.MessageText;
  end else
  begin
    ClearMessage();
  end;
end;

end.
