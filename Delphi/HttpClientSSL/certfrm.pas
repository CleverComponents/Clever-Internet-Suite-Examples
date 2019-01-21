unit certfrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TCertForm = class(TForm)
    Label1: TLabel;
    edtName: TEdit;
    Label2: TLabel;
    edtIssuedTo: TEdit;
    Label3: TLabel;
    edtIssuedBy: TEdit;
    Label4: TLabel;
    edtValidFrom: TEdit;
    Label5: TLabel;
    edtValidTo: TEdit;
    btnInstall: TButton;
    btnContinue: TButton;
    btnCancel: TButton;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

implementation

{$R *.dfm}

end.
