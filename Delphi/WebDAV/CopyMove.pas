unit CopyMove;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TCopyMoveForm = class(TForm)
    edtDestination: TEdit;
    cbIsMove: TCheckBox;
    Button1: TButton;
    Button2: TButton;
    Label1: TLabel;
    Label2: TLabel;
    edtSource: TEdit;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  CopyMoveForm: TCopyMoveForm;

implementation

{$R *.dfm}

end.
