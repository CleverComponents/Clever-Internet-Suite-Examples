unit SearchDlg;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TSearchDialog = class(TForm)
    Label1: TLabel;
    cbSearchIn: TComboBox;
    Label2: TLabel;
    edtSearchFor: TEdit;
    btnSearch: TButton;
    btnCancel: TButton;
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
    { Private declarations }
  public
    function GetSearchCriteria: string;
    { Public declarations }
  end;

var
  SearchDialog: TSearchDialog;

implementation

{$R *.dfm}

procedure TSearchDialog.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := (ModalResult <> mrOk) or ((cbSearchIn.Text <> '') and (edtSearchFor.Text <> ''));
  if not CanClose then
  begin
    ShowMessage('The search conditions can not be empty');
  end;
end;

function TSearchDialog.GetSearchCriteria: string;
begin
  Result := cbSearchIn.Text + ' ' + edtSearchFor.Text;
end;

end.
