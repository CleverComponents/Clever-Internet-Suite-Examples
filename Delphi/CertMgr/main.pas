unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, clCertificateStore, clCertificate, clCryptAPI,
  exportfrm, importfrm, createfrm, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    cbLocation: TComboBox;
    Label2: TLabel;
    cbName: TComboBox;
    btnLoad: TButton;
    btnExport: TButton;
    btnImport: TButton;
    btnDelete: TButton;
    btnCreateSelfSigned: TButton;
    btnClose: TButton;
    lvCertificates: TListView;
    Label3: TLabel;
    clCertificateStore1: TclCertificateStore;
    btnCreateSigned: TButton;
    btnSignRequest: TButton;
    OpenDialog1: TOpenDialog;
    procedure btnLoadClick(Sender: TObject);
    procedure btnCloseClick(Sender: TObject);
    procedure btnExportClick(Sender: TObject);
    procedure btnImportClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnCreateSelfSignedClick(Sender: TObject);
    procedure btnCreateSignedClick(Sender: TObject);
    procedure btnSignRequestClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    FIsOpened: Boolean;
    procedure CheckButtonsState;
    procedure LoadCertificateList;
    procedure InstallCerts;
    procedure PrepareStore(ADlg: TCreateCertForm);
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.CheckButtonsState;
begin
  btnClose.Enabled := FIsOpened;
  btnSignRequest.Enabled := FIsOpened and (lvCertificates.Items.Count > 0);
  btnCreateSigned.Enabled := FIsOpened and (lvCertificates.Items.Count > 0);
  btnExport.Enabled := lvCertificates.Items.Count > 0;
  btnImport.Enabled := FIsOpened;
  btnDelete.Enabled := lvCertificates.Items.Count > 0;
  btnCreateSelfSigned.Enabled := FIsOpened;
end;

procedure TForm1.btnLoadClick(Sender: TObject);
begin
  btnCloseClick(nil);

  clCertificateStore1.Open(cbName.Text, TclCertificateStoreLocation(cbLocation.ItemIndex));

  LoadCertificateList();
  FIsOpened := True;
  CheckButtonsState;
end;

procedure TForm1.btnSignRequestClick(Sender: TObject);
var
  cert, issuer: TclCertificate;
begin
  if OpenDialog1.Execute() then
  begin
    issuer := TclCertificate(lvCertificates.Items[lvCertificates.ItemIndex].Data);

    cert := clCertificateStore1.SignCSR(issuer, OpenDialog1.FileName, Random(MaxInt));
    clCertificateStore1.Items.Add(cert);

    InstallCerts();

    btnLoadClick(nil);
  end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  Randomize();
  CheckButtonsState;
end;

procedure TForm1.btnCreateSignedClick(Sender: TObject);
var
  dlg: TCreateCertForm;
  cert, issuer: TclCertificate;
begin
  dlg := TCreateCertForm.Create(nil);
  try
    dlg.edtStoreName.Text := cbLocation.Text + '; ' + cbName.Text;

    if dlg.ShowModal() = mrOk then
    begin
      PrepareStore(dlg);

      issuer := TclCertificate(lvCertificates.Items[lvCertificates.ItemIndex].Data);
      cert := clCertificateStore1.CreateSigned(issuer, dlg.BuildSubjectString(), StrToInt(dlg.edtSerial.Text));
      clCertificateStore1.Items.Add(cert);
      cert.FriendlyName := dlg.edtFriendlyName.Text;

      InstallCerts();

      btnLoadClick(nil);
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.LoadCertificateList;
var
  i: Integer;
  item: TListItem;
begin
  lvCertificates.Items.Clear();

  for i := 0 to clCertificateStore1.Items.Count - 1 do
  begin
    item := lvCertificates.Items.Add();

    item.Data := clCertificateStore1.Items[i];
    item.Caption := clCertificateStore1.Items[i].IssuedTo;
    item.SubItems.Add(clCertificateStore1.Items[i].IssuedBy);
    item.SubItems.Add(DateTimeToStr(clCertificateStore1.Items[i].ValidTo));
    item.SubItems.Add(clCertificateStore1.Items[i].FriendlyName);
    item.SubItems.Add(clCertificateStore1.Items[i].Email);
  end;
  CheckButtonsState;
end;

procedure TForm1.btnCloseClick(Sender: TObject);
begin
  clCertificateStore1.Close();
  LoadCertificateList();
  FIsOpened := False;
  CheckButtonsState;
end;

procedure TForm1.btnExportClick(Sender: TObject);
var
  cert: TclCertificate;
  dlg: TExportForm;
begin
  cert := TclCertificate(lvCertificates.Items[lvCertificates.ItemIndex].Data);

  dlg := TExportForm.Create(nil);
  try
    dlg.edtName.Text := cert.FriendlyName;
    if (dlg.edtName.Text = '') then
    begin
      dlg.edtName.Text := cert.IssuedTo;
    end;
    

    if dlg.ShowModal() = mrOk then
    begin
      clCertificateStore1.ExportToPFX(cert, dlg.edtFileName.Text, dlg.edtPassword.Text, dlg.cbIncludeAll.Checked);
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnImportClick(Sender: TObject);
var
  i: Integer;
  dlg: TImportForm;
begin
  dlg := TImportForm.Create(nil);
  try
    dlg.edtStoreName.Text := cbLocation.Text + '; ' + cbName.Text;

    if dlg.ShowModal() = mrOk then
    begin
      clCertificateStore1.ImportFromPFX(dlg.edtFileName.Text, dlg.edtPassword.Text);

      for i := 0 to clCertificateStore1.Items.Count - 1 do
      begin
        if not clCertificateStore1.IsInstalled(clCertificateStore1.Items[i]) then
        begin
          clCertificateStore1.Install(clCertificateStore1.Items[i]);
        end;
      end;

      btnLoadClick(nil);
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.btnDeleteClick(Sender: TObject);
var
  cert: TclCertificate;
begin
  cert := TclCertificate(lvCertificates.Items[lvCertificates.ItemIndex].Data);
  clCertificateStore1.Uninstall(cert);
  clCertificateStore1.Items.Remove(cert);

  btnLoadClick(nil);
end;

procedure TForm1.btnCreateSelfSignedClick(Sender: TObject);
var
  dlg: TCreateCertForm;
  cert: TclCertificate;
begin
  dlg := TCreateCertForm.Create(nil);
  try
    dlg.edtStoreName.Text := cbLocation.Text + '; ' + cbName.Text;

    if dlg.ShowModal() = mrOk then
    begin
      PrepareStore(dlg);

      cert := clCertificateStore1.CreateSelfSigned(dlg.BuildSubjectString(), StrToInt(dlg.edtSerial.Text));
      clCertificateStore1.Items.Add(cert);
      cert.FriendlyName := dlg.edtFriendlyName.Text;

      InstallCerts();

      btnLoadClick(nil);
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.PrepareStore(ADlg: TCreateCertForm);
begin
  clCertificateStore1.ValidFrom := StrToDateTime(ADlg.edtValidFrom.Text);
  clCertificateStore1.ValidTo := StrToDateTime(ADlg.edtValidTo.Text);
  clCertificateStore1.KeyName := ADlg.edtKeyName.Text;
  clCertificateStore1.KeyLength := StrToInt(ADlg.edtKeyLength.Text);

  clCertificateStore1.EnhancedKeyUsage.Clear();

  if ADlg.cbServerAuth.Checked then
    clCertificateStore1.EnhancedKeyUsage.Add(szOID_PKIX_KP_SERVER_AUTH);
  if ADlg.cbClientAuth.Checked then
    clCertificateStore1.EnhancedKeyUsage.Add(szOID_PKIX_KP_CLIENT_AUTH);
  if ADlg.cbCodeSigning.Checked then
    clCertificateStore1.EnhancedKeyUsage.Add(szOID_PKIX_KP_CODE_SIGNING);
  if ADlg.cbEmailProtection.Checked then
    clCertificateStore1.EnhancedKeyUsage.Add(szOID_PKIX_KP_EMAIL_PROTECTION);

  if (not clCertificateStore1.KeyExists(clCertificateStore1.KeyName)) then
    clCertificateStore1.CreateKey(clCertificateStore1.KeyName);
end;

procedure TForm1.InstallCerts;
var
  i: Integer;
begin
  for i := 0 to clCertificateStore1.Items.Count - 1 do
    if not clCertificateStore1.IsInstalled(clCertificateStore1.Items[i]) then
    begin
      clCertificateStore1.Install(clCertificateStore1.Items[i]);
    end;
end;

end.
