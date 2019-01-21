unit createfrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TCreateCertForm = class(TForm)
    btnOK: TButton;
    btnCancel: TButton;
    Label3: TLabel;
    edtStoreName: TEdit;
    Label1: TLabel;
    edtCN: TEdit;
    Label2: TLabel;
    Label4: TLabel;
    edtSerial: TEdit;
    edtValidFrom: TEdit;
    edtValidTo: TEdit;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    edtO: TEdit;
    edtOU: TEdit;
    edtL: TEdit;
    edtC: TEdit;
    edtE: TEdit;
    Label11: TLabel;
    edtKeyName: TEdit;
    Label12: TLabel;
    edtKeyLength: TEdit;
    Label13: TLabel;
    cbServerAuth: TCheckBox;
    cbClientAuth: TCheckBox;
    cbCodeSigning: TCheckBox;
    cbEmailProtection: TCheckBox;
    Label14: TLabel;
    edtFriendlyName: TEdit;
    cbAll: TCheckBox;
    procedure FormCreate(Sender: TObject);
    procedure cbServerAuthClick(Sender: TObject);
    procedure cbAllClick(Sender: TObject);
  private
    FInProgress: Boolean;
  public
    function BuildSubjectString: string;
  end;

implementation

{$R *.dfm}

function TCreateCertForm.BuildSubjectString: string;
begin
  Result := '';
  if (edtCN.Text <> '') then
  begin
    Result := Result + ',CN=' + edtCN.Text;
  end;
  if (edtOU.Text <> '') then
  begin
    Result := Result + ',OU=' + edtOU.Text;
  end;
  if (edtO.Text <> '') then
  begin
    Result := Result + ',O=' + edtO.Text;
  end;
  if (edtL.Text <> '') then
  begin
    Result := Result + ',L=' + edtL.Text;
  end;
  if (edtC.Text <> '') then
  begin
    Result := Result + ',C=' + edtC.Text;
  end;
  if (edtE.Text <> '') then
  begin
    Result := Result + ',E=' + edtE.Text;
  end;
  if (Result <> '') then
  begin
    Delete(Result, 1, 1);
  end;
end;

procedure TCreateCertForm.cbAllClick(Sender: TObject);
begin
  FInProgress := True;
  if cbAll.Checked then
  begin
    cbServerAuth.Checked := False;
    cbClientAuth.Checked := False;
    cbCodeSigning.Checked := False;
    cbEmailProtection.Checked := False;
  end;
  FInProgress := False;
end;

procedure TCreateCertForm.cbServerAuthClick(Sender: TObject);
begin
  if not FInProgress then
  begin
    cbAll.Checked := False;
  end;
end;

procedure TCreateCertForm.FormCreate(Sender: TObject);
begin
  edtValidFrom.Text := DateToStr(Date());
  edtValidTo.Text := DateToStr(Date() + 365);
end;

end.
