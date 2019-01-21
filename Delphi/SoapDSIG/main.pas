unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, clHttpRequest, clSoapMessage, StdCtrls, ExtCtrls, clCertificate, clCryptAPI,
  clCertificateStore, clSoapSecurity, DemoBaseFormUnit;

type
  TForm1 = class(TclDemoBaseForm)
    clSoapMessage: TclSoapMessage;
    memSource: TMemo;
    memResult: TMemo;
    btnSign: TButton;
    Label1: TLabel;
    Label2: TLabel;
    edtCertFile: TEdit;
    edtCertPassword: TEdit;
    Label3: TLabel;
    memReferences: TMemo;
    btnBrowse: TButton;
    Label4: TLabel;
    Label5: TLabel;
    Bevel1: TBevel;
    OpenDialog: TOpenDialog;
    clCertificateStore: TclCertificateStore;
    procedure btnSignClick(Sender: TObject);
    procedure btnBrowseClick(Sender: TObject);
    procedure clSoapMessageGetSigningCertificate(Sender: TObject;
      AKeyInfo: TclXmlKeyInfo; var ACertificate: TclCertificate;
      AExtraCerts: TclCertificateList; var Handled: Boolean);
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSignClick(Sender: TObject);
var
  i: Integer;
  sig: TclSoapSignatureInfo;
begin
  clSoapMessage.BuildSoapMessage(memSource.Lines, '');

  clSoapMessage.Signatures.Clear();
  sig := clSoapMessage.Signatures.Add();

  for i := 0 to memReferences.Lines.Count - 1 do
  begin
    sig.References.Add(memReferences.Lines[i]);
  end;

  clSoapMessage.Sign();
  memResult.Lines.Assign(clSoapMessage.RequestSource);
end;

procedure TForm1.clSoapMessageGetSigningCertificate(Sender: TObject;
  AKeyInfo: TclXmlKeyInfo; var ACertificate: TclCertificate;
  AExtraCerts: TclCertificateList; var Handled: Boolean);
begin
  clCertificateStore.ImportFromPFX(edtCertFile.Text, edtCertPassword.Text);
  ACertificate := clCertificateStore.Items[0];
end;

procedure TForm1.btnBrowseClick(Sender: TObject);
begin
  if OpenDialog.Execute() then
  begin
    edtCertFile.Text := OpenDialog.FileName;
  end;
end;

end.
