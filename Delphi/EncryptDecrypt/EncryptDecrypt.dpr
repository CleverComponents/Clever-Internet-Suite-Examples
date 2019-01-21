program EncryptDecrypt;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  getcert in 'getcert.pas' {GetCertDialog},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TGetCertDialog, GetCertDialog);
  Application.Run;
end.
