unit getcert;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TGetCertDialog = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    edtEmail: TEdit;
    edtStore: TEdit;
    btnOK: TButton;
    btnMessage: TButton;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
  private
  public
  end;

var
  GetCertDialog: TGetCertDialog;
  DefaultEmail: string = 'myname@mycompany.com';

implementation

{$R *.dfm}

procedure TGetCertDialog.FormCreate(Sender: TObject);
begin
  edtEmail.Text := DefaultEmail;
end;

procedure TGetCertDialog.FormDestroy(Sender: TObject);
begin
  DefaultEmail := edtEmail.Text;
end;

end.
