program NewsGroupsReader;

uses
  Forms,
  main in 'main.pas' {Form1},
  MessageForm in 'MessageForm.pas' {clMessageForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
