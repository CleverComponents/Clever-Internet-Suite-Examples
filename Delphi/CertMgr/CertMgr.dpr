program CertMgr;

uses
  Forms,
  main in 'main.pas' {Form1},
  exportfrm in 'exportfrm.pas' {ExportForm},
  importfrm in 'importfrm.pas' {ImportForm},
  createfrm in 'createfrm.pas' {CreateCertForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
