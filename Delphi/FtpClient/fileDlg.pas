unit fileDlg;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TFileExistsDialog = class(TForm)
    lblCaption: TLabel;
    btnReplace: TButton;
    btnResume: TButton;
    btnCancel: TButton;
  public
    class function ShowFileDialog(const AFileName: string): Integer;
  end;

var
  FileExistsDialog: TFileExistsDialog;

implementation

{$R *.dfm}

{ TFileExistsDialog }

class function TFileExistsDialog.ShowFileDialog(
  const AFileName: string): Integer;
var
  dlg: TFileExistsDialog;
begin
  dlg := TFileExistsDialog.Create(nil);
  try
    dlg.lblCaption.Caption := Format('File already exists %s', [AFileName]);
    Result := dlg.ShowModal();
  finally
    dlg.Free();
  end;
end;

end.
