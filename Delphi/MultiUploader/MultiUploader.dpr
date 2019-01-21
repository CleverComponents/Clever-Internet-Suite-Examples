program MultiUploader;

uses
  Forms,
  main in 'main.pas' {UploaderTest},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TUploaderTest, UploaderTest);
  Application.Run;
end.
