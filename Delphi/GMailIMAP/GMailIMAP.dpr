program GMailIMAP;

uses
  Forms,
  main in 'main.pas' {Form1},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm},
  login in 'login.pas' {LoginConfirmation};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
