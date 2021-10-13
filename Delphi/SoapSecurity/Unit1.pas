unit Unit1;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, clHttpRequest, clSoapMessage, StdCtrls, clCertificateStore, clXmlUtils,
  clSoapUtils, clSoapSecurity, clCertificate, getcert, certlistfrm, DemoBaseFormUnit,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    clSoapMessage1: TclSoapMessage;
    Label4: TLabel;
    memWSDLParams: TMemo;
    Label5: TLabel;
    memWSDLParamValues: TMemo;
    Label6: TLabel;
    Label15: TLabel;
    memSOAPMessage: TMemo;
    btnSignEncrypt: TButton;
    btnDecryptVerify: TButton;
    btnCertificates: TButton;
    clCertificateStore1: TclCertificateStore;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    GroupBox1: TGroupBox;
    GroupBox2: TGroupBox;
    GroupBox3: TGroupBox;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    edtTimeStampID: TEdit;
    edtTimeStampExpires: TEdit;
    edtTimestampCreated: TEdit;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    edtAddressID: TEdit;
    edtAddressValue: TEdit;
    edtAddressName: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    edtMethod: TEdit;
    edtMethodURI: TEdit;
    Label7: TLabel;
    edtBodyID: TEdit;
    procedure btnSignEncryptClick(Sender: TObject);
    procedure clSoapMessage1GetEncryptionCertificate(Sender: TObject;
      AKeyInfo: TclXmlKeyInfo; var ACertificate: TclCertificate;
      AExtraCerts: TclCertificateList; var AStoreName: String;
      var AStoreLocation: TclCertificateStoreLocation;
      var Handled: Boolean);
    procedure clSoapMessage1GetSigningCertificate(Sender: TObject;
      AKeyInfo: TclXmlKeyInfo; var ACertificate: TclCertificate;
      AExtraCerts: TclCertificateList; var Handled: Boolean);
    procedure btnDecryptVerifyClick(Sender: TObject);
    procedure btnCertificatesClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    FSecuring: Boolean;
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSignEncryptClick(Sender: TObject);
var
  sig: TclSoapSignatureInfo;
begin
  if not SaveDialog1.Execute() then Exit;

  FSecuring := True;

  memSOAPMessage.Lines.Clear();

  clSoapMessage1.BuildSoapWSDL(edtMethodURI.Text, edtMethod.Text, memWSDLParams.Lines, memWSDLParamValues.Lines);
  clSoapMessage1.BodyID := edtBodyID.Text;

  clSoapMessage1.Timestamp.Created := edtTimestampCreated.Text;
  clSoapMessage1.Timestamp.Expires := edtTimeStampExpires.Text;
  clSoapMessage1.Timestamp.ID := edtTimeStampID.Text;

  clSoapMessage1.Addressing.Clear();
  clSoapMessage1.Addressing.AddItem(edtAddressName.Text, edtAddressID.Text, edtAddressValue.Text);

  clSoapMessage1.Signatures.Clear();
  sig := clSoapMessage1.Signatures.Add();
  sig.References.Add(Id2UriReference(clSoapMessage1.Timestamp.ID));
  sig.References.Add(Id2UriReference(clSoapMessage1.BodyID));

  clSoapMessage1.EncryptedKey.References.Clear();
  clSoapMessage1.EncryptedKey.References.Add(Id2UriReference(clSoapMessage1.BodyID));

  clSoapMessage1.Sign();
  clSoapMessage1.Encrypt();

  clSoapMessage1.SaveRequest(SaveDialog1.FileName);
  ShowMessage('The signed and encrypted message was saved to ' + SaveDialog1.FileName);
end;

procedure TForm1.btnDecryptVerifyClick(Sender: TObject);
begin
  if not OpenDialog1.Execute() then Exit;

  FSecuring := False;

  clSoapMessage1.Clear();

  memSOAPMessage.Lines.Clear();

  edtMethodURI.Text := '';
  edtMethod.Text := '';
  memWSDLParams.Lines.Clear();
  memWSDLParamValues.Lines.Clear();
  edtBodyID.Text := '';

  edtTimestampCreated.Text := '';
  edtTimeStampExpires.Text := '';
  edtTimeStampID.Text := '';

  edtAddressName.Text := '';
  edtAddressID.Text := '';
  edtAddressValue.Text := '';

  clSoapMessage1.LoadRequest(OpenDialog1.FileName);

  clSoapMessage1.Decrypt();
  clSoapMessage1.Verify();

  edtBodyID.Text := clSoapMessage1.BodyID;

  edtTimestampCreated.Text := clSoapMessage1.Timestamp.Created;
  edtTimeStampExpires.Text := clSoapMessage1.Timestamp.Expires;
  edtTimeStampID.Text := clSoapMessage1.Timestamp.ID;

  if (clSoapMessage1.Addressing.Count > 0) then
  begin
    edtAddressName.Text := clSoapMessage1.Addressing[0].Name;
    edtAddressID.Text := clSoapMessage1.Addressing[0].ID;
    edtAddressValue.Text := clSoapMessage1.Addressing[0].Value;
  end;

  memSOAPMessage.Lines := clSoapMessage1.RequestSource;

  ShowMessage('The signed and encrypted message ' + OpenDialog1.FileName + ' was decrypted and verified.');
end;

procedure TForm1.btnCertificatesClick(Sender: TObject);
begin
  TCertListForm.ShowCertificates(clSoapMessage1.Certificates);
end;

procedure TForm1.clSoapMessage1GetEncryptionCertificate(Sender: TObject;
  AKeyInfo: TclXmlKeyInfo; var ACertificate: TclCertificate;
  AExtraCerts: TclCertificateList; var AStoreName: String;
  var AStoreLocation: TclCertificateStoreLocation; var Handled: Boolean);
var
  dlg: TGetCertDialog;
begin
  dlg := TGetCertDialog.Create(nil);
  try
    if FSecuring then
    begin
      dlg.Caption := 'Get recipient''s public certificate';
    end else
    begin
      dlg.Caption := 'Get own certificate with private key';
    end;
    dlg.btnMessage.Enabled := False;

    if (dlg.ShowModal() = mrOK) then
    begin
      clCertificateStore1.Open(dlg.edtStore.Text);
      ACertificate := clCertificateStore1.CertificateByEmail(dlg.edtEmail.Text);
      AStoreName := dlg.edtStore.Text;
      AStoreLocation := slCurrentUser;
      Handled := True;
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.clSoapMessage1GetSigningCertificate(Sender: TObject;
  AKeyInfo: TclXmlKeyInfo; var ACertificate: TclCertificate;
  AExtraCerts: TclCertificateList; var Handled: Boolean);
var
  dlg: TGetCertDialog;
begin
  dlg := TGetCertDialog.Create(nil);
  try
    if FSecuring then
    begin
      dlg.Caption := 'Get own certificate with private key';
      dlg.btnMessage.Enabled := False;
    end else
    begin
      dlg.Caption := 'Get recipient''s public certificate';
      dlg.btnMessage.Enabled := True;
    end;

    if (dlg.ShowModal() = mrOK) then
    begin
      clCertificateStore1.Open(dlg.edtStore.Text);
      ACertificate := clCertificateStore1.CertificateByEmail(dlg.edtEmail.Text);
    end;
    Handled := True;

  finally
    dlg.Free();
  end;
end;

procedure TForm1.FormCreate(Sender: TObject);
var
  d: TDateTime;
begin
  d := Now();
  edtTimestampCreated.Text := DateTimeToSoapTime(d);
  edtTimeStampExpires.Text := DateTimeToSoapTime(d + EncodeTime(0, 30, 0, 0));

  edtTimeStampID.Text := 'TimeStamp-' + Copy(GenerateUniqueID(), 1, 3);
  edtAddressID.Text := 'Address-' + Copy(GenerateUniqueID(), 1, 3);
  edtBodyID.Text := 'Body-' + Copy(GenerateUniqueID(), 1, 3);
end;

procedure TForm1.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 608;
 {$ENDIF}
end;

end.
