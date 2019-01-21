unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, clDC, clMultiDC, clSingleDC, clDownLoader, StdCtrls, clProgressBar, clProgressBarDC,
  clResourceState, IniFiles, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    btnStart: TButton;
    DownLoader: TclDownLoader;
    btnStop: TButton;
    clProgressBar1: TclProgressBarDC;
    Label1: TLabel;
    Label2: TLabel;
    edtFileName: TEdit;
    edtURL: TEdit;
    Label3: TLabel;
    procedure btnStartClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure edtURLChange(Sender: TObject);
    procedure edtFileNameChange(Sender: TObject);
    procedure DownLoaderChanged(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure DownLoaderStatusChanged(Sender: TObject;
      Status: TclProcessStatus);
  private
    FLoading: Boolean;
    FResourceInfoFile: string;
    procedure RestoreResourceInfo;
    procedure StoreResourceInfo;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

const
  ResourceInfoFile = 'settings.ini';

procedure TForm1.StoreResourceInfo();
var
  i: Integer;
  IniFile: TIniFile;
begin
  IniFile := TIniFile.Create(FResourceInfoFile);
  try
    IniFile.WriteString('Download', 'URL', DownLoader.URL);
    IniFile.WriteString('Download', 'LocalFile', DownLoader.LocalFile);
    IniFile.WriteInteger('ResourceState', 'Count', DownLoader.ResourceState.Count);
    IniFile.WriteInteger('ResourceState', 'ResourceSize', DownLoader.ResourceState.ResourceSize);
    for i := 0 to DownLoader.ResourceState.Count - 1 do
    begin
      IniFile.WriteInteger('ResourceStateItem' + IntToStr(i),
        'ResourcePos', DownLoader.ResourceState[i].ResourcePos);
      IniFile.WriteInteger('ResourceStateItem' + IntToStr(i),
        'BytesToProceed', DownLoader.ResourceState[i].BytesToProceed);
      IniFile.WriteInteger('ResourceStateItem' + IntToStr(i),
        'BytesProceed', DownLoader.ResourceState[i].BytesProceed);
    end;
  finally
    IniFile.Free();
  end;
  ShowMessage('Your downloading state has been stored to the "' + FResourceInfoFile + '" file.');
end;

procedure TForm1.RestoreResourceInfo();
var
  i, cnt: Integer;
  IniFile: TIniFile;
  Item: TclResourceStateItem;
begin
  DownLoader.ResourceState.Clear();
  if not FileExists(FResourceInfoFile) then Exit;
  IniFile := TIniFile.Create(FResourceInfoFile);
  try
    DownLoader.URL := IniFile.ReadString('Download', 'URL', DownLoader.URL);
    DownLoader.LocalFile := IniFile.ReadString('Download', 'LocalFile', DownLoader.LocalFile);
    cnt := IniFile.ReadInteger('ResourceState', 'Count', 0);
    DownLoader.ResourceState.ResourceSize := IniFile.ReadInteger('ResourceState', 'ResourceSize', 0);
    for i := 0 to cnt - 1 do
    begin
      Item := DownLoader.ResourceState.Add();
      Item.ResourcePos := IniFile.ReadInteger('ResourceStateItem' + IntToStr(i),
        'ResourcePos', 0);
      Item.BytesToProceed := IniFile.ReadInteger('ResourceStateItem' + IntToStr(i),
        'BytesToProceed', 0);
      Item.BytesProceed := IniFile.ReadInteger('ResourceStateItem' + IntToStr(i),
        'BytesProceed', 0);
    end;
    ShowMessage('The last downloading state has been loaded from the "' + FResourceInfoFile + '" file.');
  finally
    IniFile.Free();
  end;
end;

procedure TForm1.btnStartClick(Sender: TObject);
begin
  DownLoader.Start();
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
  DownLoader.Stop();
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not DownLoader.IsBusy;
  if not CanClose then
  begin
    ShowMessage('Downloading is in progress');
  end;
end;

procedure TForm1.DownLoaderStatusChanged(Sender: TObject;
  Status: TclProcessStatus);
begin
  case Status of
    psSuccess: MessageBox(0,
      'The downloading is completed, there are no reasons to store the downloading info.', 'Message', 0);
    psFailed:
      begin
        MessageBox(0, PChar((Sender as TclDownLoader).Errors.Text), 'Error', 0);
      end;
    psTerminated: MessageBox(0, 'Process stopped', 'Message', 0);
    psErrors: MessageBox(0, 'Process completed with some warnings', 'Message', 0);
  end;
end;

procedure TForm1.edtURLChange(Sender: TObject);
begin
  if FLoading then Exit;
  DownLoader.URL := edtURL.Text;
end;

procedure TForm1.edtFileNameChange(Sender: TObject);
begin
  if FLoading then Exit;
  DownLoader.LocalFile := edtFileName.Text;
end;

procedure TForm1.DownLoaderChanged(Sender: TObject);
begin
  FLoading := True;
  try
    edtURL.Text := DownLoader.URL;
    edtFileName.Text := DownLoader.LocalFile;
  finally
    FLoading := False;
  end;
end;

procedure TForm1.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 298;
 {$ENDIF}
  FResourceInfoFile := ExtractFilePath(ParamStr(0));
  if (FResourceInfoFile <> '') and (FResourceInfoFile[Length(FResourceInfoFile)] <> '\') then
  begin
    FResourceInfoFile := FResourceInfoFile + '\';
  end;
  FResourceInfoFile := FResourceInfoFile + ResourceInfoFile;
  RestoreResourceInfo();
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  if (DownLoader.ResourceState.LastStatus = psSuccess) then
  begin
    DownLoader.ResourceState.Clear();
    DeleteFile(FResourceInfoFile);
  end else
  if (DownLoader.ResourceState.LastStatus <> psUnknown) then
  begin
    StoreResourceInfo();
  end;
end;

end.
