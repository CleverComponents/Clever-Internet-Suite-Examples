program FtpClientProxy;

uses
  Forms,
  main in 'main.pas' {MainForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TMainForm, MainForm);
  Application.Run;
end.
