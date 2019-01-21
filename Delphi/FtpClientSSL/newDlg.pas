unit newDlg;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TNewDialog = class(TForm)
    lblName: TLabel;
    edtName: TEdit;
    btnOK: TButton;
    btnCancel: TButton;
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  public
    class function ShowNewDialog(const ACaption, AValue: string): string;
  end;

var
  NewDialog: TNewDialog;

implementation

{$R *.dfm}

{ TNewDialog }

class function TNewDialog.ShowNewDialog(const ACaption, AValue: string): string;
var
  dlg: TNewDialog;
begin
  Result := '';
  dlg := TNewDialog.Create(nil);
  try
    dlg.Caption := ACaption;
    dlg.lblName.Caption := ACaption;
    dlg.edtName.Text := AValue;
    if (dlg.ShowModal() = mrOK) then
    begin
      Result := dlg.edtName.Text;
    end;
  finally
    dlg.Free();
  end;
end;

procedure TNewDialog.FormCloseQuery(Sender: TObject;
  var CanClose: Boolean);
begin
  CanClose := (edtName.Text <> '') or (ModalResult = mrCancel);
  if not CanClose then
  begin
    ShowMessage('The value can not be empty');
  end;
end;

end.
