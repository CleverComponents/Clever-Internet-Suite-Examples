unit DemoBaseFormUnit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls;

type
  TclDemoBaseForm = class(TForm)
    pnlMain: TPanel;
    pnlLogo: TPanel;
    imLogoLeft: TImage;
    imLogoMiggle: TImage;
    imLogoRight: TImage;
    procedure imLogoLeftClick(Sender: TObject);
  protected
    function GetLink: string; virtual;
  end;

var
  clDemoBaseForm: TclDemoBaseForm;

implementation

uses
  ShellAPI;

{$R *.dfm}

procedure TclDemoBaseForm.imLogoLeftClick(Sender: TObject);
begin
  ShellExecute(0, 'open', PChar(GetLink), nil, nil, SW_RESTORE);
end;

function TclDemoBaseForm.GetLink: string;
begin
  Result := 'https://www.clevercomponents.com/support/index.asp';
end;

end.
