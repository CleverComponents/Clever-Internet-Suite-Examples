unit NewFolderDlg;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TNewFolderDialog = class(TForm)
    Label1: TLabel;
    edtName: TEdit;
    cbIsSubfolder: TCheckBox;
    Button1: TButton;
    Button2: TButton;
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  NewFolderDialog: TNewFolderDialog;

implementation

{$R *.dfm}

procedure TNewFolderDialog.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := (ModalResult <> mrOk) or (edtName.Text <> '');
  if not CanClose then
  begin
    ShowMessage('The value can not be empty');
  end;
end;

end.
