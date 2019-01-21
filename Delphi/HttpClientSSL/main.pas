unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, clTcpClient, clHttp, clHtmlParser, clCertificate,
  clCertificateStore, certfrm, clTranslator, clTcpClientTls, DemoBaseFormUnit;

type
  TForm1 = class(TclDemoBaseForm)
    Panel1: TPanel;
    memResult: TMemo;
    Label1: TLabel;
    edtUrl: TEdit;
    Label2: TLabel;
    Button1: TButton;
    clHttp1: TclHttp;
    clHtmlParser1: TclHtmlParser;
    cbShowText: TCheckBox;
    Label3: TLabel;
    edtUser: TEdit;
    Label4: TLabel;
    edtPassword: TEdit;
    clCertificateStore1: TclCertificateStore;
    procedure Button1Click(Sender: TObject);
    procedure clHtmlParser1ParseTag(Sender: TObject; ATag: TclHtmlTag);
    procedure clHttp1VerifyServer(Sender: TObject;
      ACertificate: TclCertificate; const AStatusText: String;
      AStatusCode: Integer; var AVerified: Boolean);
  private
    function ViewCertificate(ACertificate: TclCertificate): Boolean;
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var
  html: TStrings;
begin
  memResult.Lines.Clear();

  html := TStringList.Create();
  try
    clHttp1.UserName := edtUser.Text;
    clHttp1.Password := edtPassword.Text;
    clHttp1.Get(edtUrl.Text, html);

    if cbShowText.Checked then
    begin
      clHtmlParser1.Parse(html);
    end else
    begin
      if SameText('UTF-8', clHttp1.ResponseHeader.CharSet) then
      begin
        memResult.Lines.Text := TclTranslator.TranslateFromUtf8(html.Text);
      end else
      begin
        memResult.Lines.Assign(html);
      end;
    end;
  finally
    html.Free();
  end;
end;

procedure TForm1.clHtmlParser1ParseTag(Sender: TObject; ATag: TclHtmlTag);
begin
  if (Trim(ATag.Text) <> '') then
  begin
    if SameText('UTF-8', clHttp1.ResponseHeader.CharSet) then
    begin
      memResult.Lines.Add(TclTranslator.TranslateFromUtf8(ATag.Text));
    end else
    begin
      memResult.Lines.Add(ATag.Text);
    end;
  end;
end;

procedure TForm1.clHttp1VerifyServer(Sender: TObject;
  ACertificate: TclCertificate; const AStatusText: String;
  AStatusCode: Integer; var AVerified: Boolean);
begin
  if not AVerified and (MessageDlg(AStatusText + #13#10' Do you wish to view / install the certificate ?',
    mtWarning, [mbYes, mbNo], 0) = mrYes) then
  begin
    if ViewCertificate(ACertificate) then
    begin
      AVerified := True;
    end;
  end;
end;

function TForm1.ViewCertificate(ACertificate: TclCertificate): Boolean;
var
  dlg: TCertForm;
  newInstance: TclCertificate;
begin
  dlg := TCertForm.Create(nil);
  try
    dlg.edtName.Text := ACertificate.FriendlyName;
    dlg.edtIssuedTo.Text := ACertificate.IssuedTo;
    dlg.edtIssuedBy.Text := ACertificate.IssuedBy;
    dlg.edtValidFrom.Text := DateTimeToStr(ACertificate.ValidFrom);
    dlg.edtValidTo.Text := DateTimeToStr(ACertificate.ValidTo);

    dlg.ShowModal();
    Result := (dlg.ModalResult in [mrOk, mrYes]);

    if (dlg.ModalResult = mrYes) then
    begin
      newInstance := clCertificateStore1.Items.AddFrom(ACertificate);
      clCertificateStore1.StoreName := 'CA';
      clCertificateStore1.Install(newInstance);
      ShowMessage('The certificate was installed successfully to '
        + 'Intermediate Certification Authorities (CA).'#13#10'Press OK to continue.');
    end;
  finally
    dlg.Free();
  end;
end;

end.
