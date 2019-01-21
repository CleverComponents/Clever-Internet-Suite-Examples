unit ModifyProps;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TModifyPropForm = class(TForm)
    Label1: TLabel;
    edtName: TEdit;
    Label2: TLabel;
    edtValue: TEdit;
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    lblResource: TLabel;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  ModifyPropForm: TModifyPropForm;

implementation

{$R *.dfm}

end.
