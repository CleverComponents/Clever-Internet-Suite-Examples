unit EditItemFrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls;

type
  TEditItemForm = class(TForm)
    Label1: TLabel;
    edtTitle: TEdit;
    Label2: TLabel;
    edtLink: TEdit;
    Label3: TLabel;
    edtDescription: TEdit;
    dtPubDate: TDateTimePicker;
    Label4: TLabel;
    Label5: TLabel;
    edtGuid: TEdit;
    Button1: TButton;
    Button2: TButton;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  EditItemForm: TEditItemForm;

implementation

{$R *.dfm}

end.
