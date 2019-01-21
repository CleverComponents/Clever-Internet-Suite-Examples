program RssFeed;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  EditItemFrm in 'EditItemFrm.pas' {EditItemForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
