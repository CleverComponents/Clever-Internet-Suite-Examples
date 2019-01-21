program SmtpRelay;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  relayfrm in 'relayfrm.pas' {RelayStatusForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
