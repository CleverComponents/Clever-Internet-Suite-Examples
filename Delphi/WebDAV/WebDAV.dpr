program WebDAV;

uses
  Forms,
  main in 'main.pas' {Form1},
  ViewProps in 'ViewProps.pas' {ViewPropsForm},
  ModifyProps in 'ModifyProps.pas' {ModifyPropForm},
  CopyMove in 'CopyMove.pas' {CopyMoveForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
