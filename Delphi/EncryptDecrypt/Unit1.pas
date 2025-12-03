unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, clEncryptor, getcert, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    btnEncrypt: TButton;
    btnDecrypt: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtSource: TEdit;
    btnSource: TButton;
    edtDestination: TEdit;
    btnDestination: TButton;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    ProgressBar1: TProgressBar;
    clEncryptor1: TclEncryptor;
    procedure btnSourceClick(Sender: TObject);
    procedure btnDestinationClick(Sender: TObject);
    procedure btnEncryptClick(Sender: TObject);
    procedure btnDecryptClick(Sender: TObject);
    procedure clEncryptor1Progress(Sender: TObject; ABytesProceed,
      ATotalBytes: Int64);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSourceClick(Sender: TObject);
begin
  if OpenDialog1.Execute() then
  begin
    edtSource.Text := OpenDialog1.FileName;
  end;
end;

procedure TForm1.btnDestinationClick(Sender: TObject);
begin
  if SaveDialog1.Execute() then
  begin
    edtDestination.Text := SaveDialog1.FileName;
  end;
end;

procedure TForm1.btnEncryptClick(Sender: TObject);
var
  dlg: TGetCertDialog;
begin
  dlg := TGetCertDialog.Create(nil);
  try
    dlg.Caption := 'Get encryption certificate';
    if (dlg.ShowModal() = mrOK) then
    begin
      clEncryptor1.EncryptStore := dlg.edtStore.Text;
      clEncryptor1.EncryptCertificate := dlg.edtEmail.Text;
    end;
  finally
    dlg.Free();
  end;

  clEncryptor1.Encrypt(edtSource.Text, edtDestination.Text);

  ShowMessage(Format('The file %s was encrypted and stored to %s', [edtSource.Text, edtDestination.Text]));
end;

procedure TForm1.btnDecryptClick(Sender: TObject);
var
  dlg: TGetCertDialog;
begin
  dlg := TGetCertDialog.Create(nil);
  try
    dlg.Caption := 'Get encryption certificate';
    if (dlg.ShowModal() = mrOK) then
    begin
      clEncryptor1.EncryptStore := dlg.edtStore.Text;
      clEncryptor1.EncryptCertificate := dlg.edtEmail.Text;
    end;
  finally
    dlg.Free();
  end;

  clEncryptor1.Decrypt(edtSource.Text, edtDestination.Text);

  ShowMessage(Format('The file %s was decrypted and stored to %s', [edtSource.Text, edtDestination.Text]));
end;

procedure TForm1.clEncryptor1Progress(Sender: TObject; ABytesProceed, ATotalBytes: Int64);
begin
  ProgressBar1.Max := ATotalBytes;
  ProgressBar1.Position := ABytesProceed;
end;

end.
