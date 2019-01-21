program ImapClient;

uses
  Forms,
  main in 'main.pas' {Form1},
  SearchDlg in 'SearchDlg.pas' {SearchDialog},
  NewFolderDlg in 'NewFolderDlg.pas' {NewFolderDialog},
  CopyDlg in 'CopyDlg.pas' {CopyDialog},
  MessageFrm in 'MessageFrm.pas' {MessageForm},
  DemoBaseFormUnit in '..\Common\DemoBaseFormUnit.pas' {clDemoBaseForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
