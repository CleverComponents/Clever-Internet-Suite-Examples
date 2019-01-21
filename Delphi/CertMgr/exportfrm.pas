unit exportfrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TExportForm = class(TForm)
    Label1: TLabel;
    edtFileName: TEdit;
    Label2: TLabel;
    edtPassword: TEdit;
    cbIncludeAll: TCheckBox;
    btnOK: TButton;
    btnCancel: TButton;
    edtName: TEdit;
    Label3: TLabel;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

implementation

{$R *.dfm}

end.
