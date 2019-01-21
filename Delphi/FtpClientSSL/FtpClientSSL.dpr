program FtpClientSSL;

uses
  Forms,
  main in 'main.pas' {MainForm},
  newDlg in 'newDlg.pas' {NewDialog},
  fileDlg in 'fileDlg.pas' {FileExistsDialog},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TMainForm, MainForm);
  Application.Run;
end.
