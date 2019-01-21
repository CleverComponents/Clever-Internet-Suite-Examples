unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clSMimeMessage, clCertificate, getcert, certlistfrm,
  clMailMessage, clCertificateStore, DemoBaseFormUnit, ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    Label3: TLabel;
    Label4: TLabel;
    memText: TMemo;
    memHtml: TMemo;
    Label5: TLabel;
    lbAttachments: TListBox;
    btnAdd: TButton;
    btnClear: TButton;
    btnEncrypt: TButton;
    btnSign: TButton;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    edtFrom: TEdit;
    edtToList: TEdit;
    edtSubject: TEdit;
    OpenDialog: TOpenDialog;
    clSMimeMessage: TclSMimeMessage;
    SaveDialog: TSaveDialog;
    btnSignEncrypt: TButton;
    btnVerify: TButton;
    btnVerifyDecrypt: TButton;
    btnDecrypt: TButton;
    btnNewMessage: TButton;
    OpenAttach: TOpenDialog;
    cbDetachedSignature: TCheckBox;
    cbIncludeCertificate: TCheckBox;
    btnViewCertificates: TButton;
    clCertificateStore: TclCertificateStore;
    Label1: TLabel;
    Label2: TLabel;
    procedure btnAddClick(Sender: TObject);
    procedure btnClearClick(Sender: TObject);
    procedure btnEncryptClick(Sender: TObject);
    procedure btnNewMessageClick(Sender: TObject);
    procedure btnSignClick(Sender: TObject);
    procedure btnSignEncryptClick(Sender: TObject);
    procedure btnVerifyClick(Sender: TObject);
    procedure btnDecryptClick(Sender: TObject);
    procedure btnVerifyDecryptClick(Sender: TObject);
    procedure cbDetachedSignatureClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnViewCertificatesClick(Sender: TObject);
    procedure clSMimeMessageGetEncryptionCertificate(Sender: TObject;
      var ACertificate: TclCertificate; AExtraCerts: TclCertificateList;
      var Handled: Boolean);
    procedure clSMimeMessageGetSigningCertificate(Sender: TObject;
      var ACertificate: TclCertificate; AExtraCerts: TclCertificateList;
      var Handled: Boolean);
    procedure clSMimeMessageSaveAttachment(Sender: TObject;
      ABody: TclAttachmentBody; var AFileName: string; var AData: TStream;
      var Handled: Boolean);
  private
    procedure BuildMessage;
    procedure FillControls;
    procedure NewMessage;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnAddClick(Sender: TObject);
begin
  if OpenAttach.Execute() then
  begin
    lbAttachments.Items.Add(OpenAttach.FileName);
  end;
end;

procedure TMainForm.btnClearClick(Sender: TObject);
begin
  lbAttachments.Items.Clear();
end;

procedure TMainForm.NewMessage;
begin
  edtFrom.Text := DefaultEmail;
  edtToList.Text := '';
  edtSubject.Text := '';
  memText.Lines.Clear();
  memHtml.Lines.Clear();
  memHtml.Lines.Add('<html>');
  memHtml.Lines.Add('<body>');
  memHtml.Lines.Add('</body>');
  memHtml.Lines.Add('</html>');
  lbAttachments.Items.Clear();
end;

procedure TMainForm.btnNewMessageClick(Sender: TObject);
begin
  NewMessage();
end;

procedure TMainForm.clSMimeMessageGetEncryptionCertificate(Sender: TObject;
  var ACertificate: TclCertificate; AExtraCerts: TclCertificateList; var Handled: Boolean);
var
  dlg: TGetCertDialog;
begin
  dlg := TGetCertDialog.Create(nil);
  try
    dlg.Caption := 'Get encryption certificate';
    dlg.edtEmail.Text := edtToList.Text;
    if (dlg.ShowModal() = mrOK) then
    begin
      clCertificateStore.Open(dlg.edtStore.Text);
      ACertificate := clCertificateStore.CertificateByEmail(dlg.edtEmail.Text);
      Handled := True;
    end;
  finally
    dlg.Free();
  end;
end;

procedure TMainForm.clSMimeMessageGetSigningCertificate(Sender: TObject;
  var ACertificate: TclCertificate; AExtraCerts: TclCertificateList; var Handled: Boolean);
var
  dlg: TGetCertDialog;
begin
  dlg := TGetCertDialog.Create(nil);
  try
    dlg.Caption := 'Get signing certificate';
    dlg.edtEmail.Text := edtFrom.Text;
    if (dlg.ShowModal() = mrOK) then
    begin
      clCertificateStore.Open(dlg.edtStore.Text);
      ACertificate := clCertificateStore.CertificateByEmail(dlg.edtEmail.Text);
      Handled := True;
    end;
  finally
    dlg.Free();
  end;
end;

procedure TMainForm.clSMimeMessageSaveAttachment(Sender: TObject;
  ABody: TclAttachmentBody; var AFileName: string; var AData: TStream; var Handled: Boolean);
begin
  AData := TMemoryStream.Create();
  Handled := True;
  if (AFileName <> '') then
  begin
    lbAttachments.Items.Add(AFileName);
  end;
end;

procedure TMainForm.BuildMessage;
begin
  clSMimeMessage.BuildMessage(memText.Lines.Text, memHtml.Lines.Text, nil, lbAttachments.Items);
  clSMimeMessage.From.FullAddress := edtFrom.Text;
  clSMimeMessage.ToList.EmailAddresses := edtToList.Text;
  clSMimeMessage.Subject := edtSubject.Text;
end;

procedure TMainForm.FillControls;
begin
  edtFrom.Text := clSMimeMessage.From.FullAddress;
  edtToList.Text := clSMimeMessage.ToList.EmailAddresses;
  edtSubject.Text := clSMimeMessage.Subject;

  memText.Lines.Clear();
  if (clSMimeMessage.Text <> nil) then
  begin
    memText.Lines := clSMimeMessage.Text.Strings;
  end;

  memHtml.Lines.Clear();
  if (clSMimeMessage.Html <> nil) then
  begin
    memHtml.Lines := clSMimeMessage.Html.Strings;
  end;
end;

procedure TMainForm.btnEncryptClick(Sender: TObject);
begin
  if SaveDialog.Execute() then
  begin
    BuildMessage();
    clSMimeMessage.Encrypt();
    clSMimeMessage.MessageSource.SaveToFile(SaveDialog.FileName);
    ShowMessage('The encrypted message is saved to ' + SaveDialog.FileName);
  end;
end;

procedure TMainForm.btnSignClick(Sender: TObject);
begin
  if SaveDialog.Execute() then
  begin
    BuildMessage();
    clSMimeMessage.Sign();
    clSMimeMessage.MessageSource.SaveToFile(SaveDialog.FileName);
    ShowMessage('The signed message is saved to ' + SaveDialog.FileName);
  end;
end;

procedure TMainForm.btnSignEncryptClick(Sender: TObject);
begin
  if SaveDialog.Execute() then
  begin
    BuildMessage();
    clSMimeMessage.Sign();
    clSMimeMessage.Encrypt();
    clSMimeMessage.MessageSource.SaveToFile(SaveDialog.FileName);
    ShowMessage('The encrypted and signed message is saved to ' + SaveDialog.FileName);
  end;
end;

procedure TMainForm.btnVerifyClick(Sender: TObject);
var
  msg: TStrings;
begin
  if OpenDialog.Execute() then
  begin
    NewMessage();
    msg := TStringList.Create();
    try
      msg.LoadFromFile(OpenDialog.FileName);
      clSMimeMessage.MessageSource := msg;
      clSMimeMessage.Verify();
      FillControls();
      ShowMessage('The signed message ' + OpenDialog.FileName + ' is verified.');
    finally
      msg.Free();
    end;
  end;
end;

procedure TMainForm.btnDecryptClick(Sender: TObject);
var
  msg: TStrings;
begin
  if OpenDialog.Execute() then
  begin
    NewMessage();
    msg := TStringList.Create();
    try
      msg.LoadFromFile(OpenDialog.FileName);
      clSMimeMessage.MessageSource := msg;
      clSMimeMessage.Decrypt();
      FillControls();
      ShowMessage('The encrypted message ' + OpenDialog.FileName + ' is decrypted.');
    finally
      msg.Free();
    end;
  end;
end;

procedure TMainForm.btnVerifyDecryptClick(Sender: TObject);
var
  msg: TStrings;
begin
  if OpenDialog.Execute() then
  begin
    NewMessage();
    msg := TStringList.Create();
    try
      msg.LoadFromFile(OpenDialog.FileName);
      clSMimeMessage.MessageSource := msg;
      clSMimeMessage.DecryptAndVerify();
      FillControls();
      ShowMessage('The secured message ' + OpenDialog.FileName + ' is decrypted and verified.');
    finally
      msg.Free();
    end;
  end;
end;

procedure TMainForm.cbDetachedSignatureClick(Sender: TObject);
begin
  clSMimeMessage.IsDetachedSignature := cbDetachedSignature.Checked;
  clSMimeMessage.IsIncludeCertificate := cbIncludeCertificate.Checked;
end;

procedure TMainForm.FormCreate(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 552;
 {$ENDIF}
  edtFrom.Text := DefaultEmail;
end;

procedure TMainForm.btnViewCertificatesClick(Sender: TObject);
begin
  TCertListForm.ShowCertificates(clSMimeMessage.Certificates);
end;

end.
