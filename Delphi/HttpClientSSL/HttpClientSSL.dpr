program HttpClientSSL;

uses
  Forms,
  main in 'main.pas' {Form1},
  certfrm in 'certfrm.pas' {CertForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
