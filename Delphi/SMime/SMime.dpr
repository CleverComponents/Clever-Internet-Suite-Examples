program SMime;

uses
  Forms,
  main in 'main.pas' {MainForm},
  getcert in 'getcert.pas' {GetCertDialog},
  certlistfrm in 'certlistfrm.pas' {CertListForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TMainForm, MainForm);
  Application.Run;
end.
