unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, clTcpClient, clTcpClientTls, clMC, clImap4, ImgList, clCertificate,
  clMailMessage, clTcpCommandClient, clOAuth, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label4: TLabel;
    edtUser: TEdit;
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
    clImap: TclImap4;
    Images: TImageList;
    clMailMessage: TclMailMessage;
    clOAuth1: TclOAuth;
    procedure btnLoginClick(Sender: TObject);
    procedure btnLogoutClick(Sender: TObject);
    procedure tvFoldersChange(Sender: TObject; Node: TTreeNode);
    procedure lvMessagesClick(Sender: TObject);
  private
    FChanging: Boolean;
    procedure FillFolderList;
    procedure AddFolderToList(AName: string);
    function GetFolderName(Node: TTreeNode): string;
    procedure FillMessages;
    procedure FillMessage(AItem: TListItem);
    procedure ClearMessage;
    procedure EnableControls(AEnabled: Boolean);
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnLoginClick(Sender: TObject);
begin
  if clImap.Active then Exit;

  clOAuth1.AuthUrl := 'https://accounts.google.com/o/oauth2/auth';
  clOAuth1.TokenUrl := 'https://accounts.google.com/o/oauth2/token';
  clOAuth1.RedirectUrl := 'http://localhost';
  clOAuth1.ClientID := '421475025220-6khpgoldbdsi60fegvjdqk2bk4v19ss2.apps.googleusercontent.com';
  clOAuth1.ClientSecret := '_4HJyAVUmH_iVrPB8pOJXjR1';
  clOAuth1.Scope := 'https://mail.google.com/';

  clImap.Server := 'imap.gmail.com';
  clImap.Port := 993;
  clImap.UseTLS := ctImplicit;

  clImap.UserName := edtUser.Text;

  clImap.Authorization := clOAuth1.GetAuthorization();

  clImap.Open();

  FillFolderList();
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
  lvMessages.Clear();
  ClearMessage();
end;

procedure TForm1.tvFoldersChange(Sender: TObject; Node: TTreeNode);
begin
  if (FChanging) then Exit;

  FChanging := True;
  try
    EnableControls(False);
    if clImap.Active and Assigned(tvFolders.Selected) then
    begin
      clImap.SelectMailBox(GetFolderName(tvFolders.Selected));
    end;
    FillMessages();
  finally
    FChanging := False;
    EnableControls(True);
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

procedure TForm1.lvMessagesClick(Sender: TObject);
begin
  if (FChanging) then Exit;

  FChanging := True;
  try
    EnableControls(False);

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
  finally
    FChanging := False;
    EnableControls(True);
  end;
end;

procedure TForm1.EnableControls(AEnabled: Boolean);
begin
  btnLogin.Enabled := AEnabled;
  btnLogout.Enabled := AEnabled;
  tvFolders.Enabled := AEnabled;
  lvMessages.Enabled := AEnabled;
  edtFrom.Enabled := AEnabled;
  edtSubject.Enabled := AEnabled;
  memBody.Enabled := AEnabled;

  if (AEnabled) then
  begin
    Cursor := crArrow;
  end else
  begin
    Cursor := crHourGlass;
  end;
end;

end.
