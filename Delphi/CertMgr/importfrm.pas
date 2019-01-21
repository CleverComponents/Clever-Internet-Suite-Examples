unit importfrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TImportForm = class(TForm)
    Label1: TLabel;
    edtFileName: TEdit;
    Label2: TLabel;
    edtPassword: TEdit;
    btnOK: TButton;
    btnCancel: TButton;
    Label3: TLabel;
    edtStoreName: TEdit;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

implementation

{$R *.dfm}

end.
