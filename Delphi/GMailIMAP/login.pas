unit login;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics,
  Controls, Forms, Dialogs, StdCtrls;

type
  TLoginConfirmation = class(TForm)
    Label1: TLabel;
    edtClientID: TEdit;
    Label2: TLabel;
    edtScope: TEdit;
    btnOK: TButton;
    btnCancel: TButton;
    Label3: TLabel;
  private
    { Private declarations }
  public
    class function ShowConfirmation(const AClientID, AScope: string): Boolean;
    { Public declarations }
  end;

var
  LoginConfirmation: TLoginConfirmation;

implementation

{$R *.dfm}

{ TLoginConfirmation }

class function TLoginConfirmation.ShowConfirmation(const AClientID, AScope: string): Boolean;
var
  dlg: TLoginConfirmation;
begin
  dlg := TLoginConfirmation.Create(nil);
  try
    dlg.edtClientID.Text := AClientID;
    dlg.edtScope.Text := AScope;

    Result := dlg.ShowModal() = mrOK;
  finally
    dlg.Free();
  end;
end;

end.
