program SoapSecurity;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  getcert in 'getcert.pas' {GetCertDialog},
  certlistfrm in 'certlistfrm.pas' {CertListForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TGetCertDialog, GetCertDialog);
  Application.CreateForm(TCertListForm, CertListForm);
  Application.Run;
end.
