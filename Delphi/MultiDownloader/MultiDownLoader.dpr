program MultiDownLoader;

uses
  Forms,
  main in 'main.pas' {DownLoaderTest},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TDownLoaderTest, DownLoaderTest);
  Application.Run;
end.
