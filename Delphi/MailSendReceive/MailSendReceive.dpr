program MailSendReceive;

uses
  Forms,
  main in 'main.pas' {Form1},
  msgfrm in 'msgfrm.pas' {MessageForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
