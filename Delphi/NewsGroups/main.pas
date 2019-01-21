unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clNNTP, ComCtrls, clMailMessage, MessageForm,
  clTcpClient, clTcpClientTls, clTcpCommandClient, DemoBaseFormUnit,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtNewsServer: TEdit;
    btnConnect: TButton;
    clNNTP: TclNNTP;
    tvArticles: TTreeView;
    memBody: TMemo;
    cbNewsGroup: TComboBox;
    Label2: TLabel;
    btnPostNew: TButton;
    btnReply: TButton;
    btnGetArticles: TButton;
    clMailMessage: TclMailMessage;
    procedure btnConnectClick(Sender: TObject);
    procedure btnGetArticlesClick(Sender: TObject);
    procedure tvArticlesDeletion(Sender: TObject; Node: TTreeNode);
    procedure tvArticlesChange(Sender: TObject; Node: TTreeNode);
    procedure btnPostNewClick(Sender: TObject);
    procedure btnReplyClick(Sender: TObject);
    procedure clNNTPGroupOverview(Sender: TObject; ArticleInfo: TclArticleInfo);
  private
    FIsLoading: Boolean;
    function FindNodeByMessageID(const AMessageID: string): TTreeNode;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnConnectClick(Sender: TObject);
begin
  cbNewsGroup.Enabled := False;
  btnGetArticles.Enabled := False;
  btnPostNew.Enabled := False;
  btnReply.Enabled := False;
  tvArticles.Enabled := False;
  memBody.Enabled := False;

  clNNTP.Close();
  clNNTP.Server := edtNewsServer.Text;
  clNNTP.Open();

  clNNTP.GetGroups(cbNewsGroup.Items);

  cbNewsGroup.Enabled := True;
  btnGetArticles.Enabled := True;
  btnPostNew.Enabled := True;
  btnReply.Enabled := True;
  tvArticles.Enabled := True;
  memBody.Enabled := True;
end;

procedure TForm1.btnGetArticlesClick(Sender: TObject);
var
  list: TStrings;
begin
  btnGetArticles.Enabled := False;
  btnPostNew.Enabled := False;
  btnReply.Enabled := False;
  tvArticles.Enabled := False;
  memBody.Enabled := False;

  FIsLoading := True;
  list := TStringList.Create();
  try
    tvArticles.Items.Clear();
    memBody.Lines.Clear();

    clNNTP.SelectGroup(cbNewsGroup.Text);
    clNNTP.GroupOverview();
  finally
    list.Free();
    FIsLoading := False;

    btnGetArticles.Enabled := True;
    btnPostNew.Enabled := True;
    btnReply.Enabled := True;
    tvArticles.Enabled := True;
    memBody.Enabled := True;
  end;
end;

function TForm1.FindNodeByMessageID(const AMessageID: string): TTreeNode;
var
  i: Integer;
begin
  for i := 0 to tvArticles.Items.Count - 1 do
  begin
    Result := tvArticles.Items[i];
    if (string(PChar(Result.Data)) = AMessageID) then Exit;
  end;
  Result := nil;
end;

procedure TForm1.tvArticlesDeletion(Sender: TObject; Node: TTreeNode);
begin
  FreeMem(Node.Data);
end;

procedure TForm1.tvArticlesChange(Sender: TObject; Node: TTreeNode);
var
  messageID: string;
begin
  if FIsLoading or (Node = nil) then Exit;
  FIsLoading := True;
  try
    messageID := string(PChar(Node.Data));

    clNNTP.GetBody(messageID, memBody.Lines);
  finally
    FIsLoading := False;
  end;
end;

procedure TForm1.btnPostNewClick(Sender: TObject);
begin
  if TclMessageForm.PostNew(clMailMessage) then
  begin
    clNNTP.PostArticle(clMailMessage, '', cbNewsGroup.Text);
  end;
end;

procedure TForm1.btnReplyClick(Sender: TObject);
var
  messageID: string;
begin
  if tvArticles.Selected = nil then
  begin
    ShowMessage('Select article first');
    Exit;
  end;
  messageID := string(PChar(tvArticles.Selected.Data));

  clNNTP.GetArticle(messageID, clMailMessage);

  if TclMessageForm.ReplyTo(clMailMessage) then
  begin
    clNNTP.PostArticle(clMailMessage, messageID, cbNewsGroup.Text);
  end;
end;

procedure TForm1.clNNTPGroupOverview(Sender: TObject;
  ArticleInfo: TclArticleInfo);
var
  node: TTreeNode;
  p: PChar;
begin
  GetMem(p, Length(ArticleInfo.MessageId) + 1);
  CopyMemory(p, PChar(ArticleInfo.MessageId), Length(ArticleInfo.MessageId));
  p[Length(ArticleInfo.MessageId)] := #0;

  node := nil;

  if (ArticleInfo.References.Count > 0) then
  begin
    node := FindNodeByMessageID(ArticleInfo.References[ArticleInfo.References.Count - 1]);
  end;

  if (node <> nil) and (ArticleInfo.References.Count > 0) then
  begin
    tvArticles.Items.AddChildObject(node, ArticleInfo.Subject + ' from ' + ArticleInfo.From.FullAddress, p);
  end else
  begin
    tvArticles.Items.AddObject(node, ArticleInfo.Subject + ' from ' + ArticleInfo.From.FullAddress, p);
  end;
end;

end.
