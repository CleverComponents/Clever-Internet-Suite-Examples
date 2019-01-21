unit CopyDlg;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TCopyDialog = class(TForm)
    Label1: TLabel;
    cbFolder: TComboBox;
    Button1: TButton;
    Button2: TButton;
  private
    { Private declarations }
  public
    class function ShowCopyDialog(AFolders: TStrings): string;
    { Public declarations }
  end;

var
  CopyDialog: TCopyDialog;

implementation

{$R *.dfm}

{ TCopyDialog }

class function TCopyDialog.ShowCopyDialog(AFolders: TStrings): string;
var
  dlg: TCopyDialog;
begin
  dlg := TCopyDialog.Create(nil);
  try
    dlg.cbFolder.Items := AFolders;
    if (dlg.cbFolder.Items.Count > 0) then
    begin
      dlg.cbFolder.ItemIndex := 0;
    end;

    if (dlg.ShowModal() = mrOk) then
    begin
      Result := dlg.cbFolder.Items[dlg.cbFolder.ItemIndex];
    end else
    begin
      Result := '';
    end;
  finally
    dlg.Free();
  end;
end;

end.
