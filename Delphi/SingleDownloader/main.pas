unit main;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, clDownLoader, clWinInet, clDC, clDCUtils, clMultiDC, clSingleDC,
  clProgressBar, clProgressBarDC, ExtCtrls, ComCtrls, clResourceState, clUriUtils,
  DemoBaseFormUnit;

type
  TDownLoaderTest = class(TclDemoBaseForm)
    btnDownLoad: TButton;
    edtURL: TEdit;
    edtFile: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    clDownLoader1: TclDownLoader;
    memPreview: TMemo;
    Label3: TLabel;
    edtStatistic: TEdit;
    btnGetInfo: TButton;
    Label5: TLabel;
    Label4: TLabel;
    memErrors: TMemo;
    Label6: TLabel;
    edtUser: TEdit;
    edtPassword: TEdit;
    btnStop: TButton;
    memInfo: TMemo;
    Label7: TLabel;
    edtDirectory: TEdit;
    Label8: TLabel;
    Label9: TLabel;
    clProgressBar1: TclProgressBarDC;
    Label10: TLabel;
    edtThreadCount: TEdit;
    Label11: TLabel;
    edtBufferSize: TEdit;
    updBufferSize: TUpDown;
    updThreadCount: TUpDown;
    Label12: TLabel;
    Label13: TLabel;
    procedure btnDownLoadClick(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure btnGetInfoClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure edtFileChange(Sender: TObject);
    procedure edtUserChange(Sender: TObject);
    procedure edtPasswordChange(Sender: TObject);
    procedure edtURLChange(Sender: TObject);
    procedure edtDirectoryChange(Sender: TObject);
    procedure clDownLoader1DataItemProceed(Sender: TObject;
      ResourceInfo: TclResourceInfo; AStateItem: TclResourceStateItem;
      CurrentData: PAnsiChar; CurrentDataSize: Integer);
    procedure clDownLoader1StatusChanged(Sender: TObject;
      Status: TclProcessStatus);
    procedure clDownLoader1Changed(Sender: TObject);
    procedure clDownLoader1GetResourceInfo(Sender: TObject;
      ResourceInfo: TclResourceInfo);
    procedure clDownLoader1DataTextProceed(Sender: TObject;
      Text: TStrings);
    procedure clDownLoader1Error(Sender: TObject; const Error: String;
      ErrorCode: Integer);
    procedure edtThreadCountChange(Sender: TObject);
    procedure edtBufferSizeChange(Sender: TObject);
    procedure clDownLoader1UrlParsing(Sender: TObject;
      AURLComponents: TclUrlParser);
  private
    FIsLoading: Boolean;
  end;

var
  DownLoaderTest: TDownLoaderTest;

implementation

{$R *.DFM}

procedure TDownLoaderTest.btnDownLoadClick(Sender: TObject);
begin
  memInfo.Lines.Clear();
  memErrors.Lines.Clear();
  clDownLoader1.Start(True);
end;

procedure TDownLoaderTest.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clDownLoader1.IsBusy;
end;

procedure TDownLoaderTest.btnGetInfoClick(Sender: TObject);
begin
  memInfo.Lines.Clear();
  memErrors.Lines.Clear();
  clDownLoader1.GetResourceInfo(True);
end;

procedure TDownLoaderTest.btnStopClick(Sender: TObject);
begin
  clDownLoader1.Stop();
end;

procedure TDownLoaderTest.edtFileChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.LocalFile := edtFile.Text;
end;

procedure TDownLoaderTest.edtUserChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.UserName := edtUser.Text;
end;

procedure TDownLoaderTest.edtPasswordChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.Password := edtPassword.Text;
end;

procedure TDownLoaderTest.edtURLChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.URL := edtURL.Text;
end;

procedure TDownLoaderTest.edtDirectoryChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.LocalFolder := edtDirectory.Text;
end;

procedure TDownLoaderTest.clDownLoader1DataItemProceed(Sender: TObject;
  ResourceInfo: TclResourceInfo; AStateItem: TclResourceStateItem;
  CurrentData: PAnsiChar; CurrentDataSize: Integer);
var
  State: TclResourceStateList;
begin
  State := AStateItem.ResourceState;
  edtStatistic.Text := Format('%.2n of %.2n Kb proceed, speed %.2n Kb/sec, elapsed %.2n min, remains %.2n min',
    [State.BytesProceed / 1024, State.ResourceSize / 1024, State.Speed / 1024,
    State.ElapsedTime / 60, State.RemainingTime / 60]);
end;

procedure TDownLoaderTest.clDownLoader1StatusChanged(Sender: TObject;
  Status: TclProcessStatus);
var
  s: String;
begin
  case Status of
    psSuccess: MessageBox(0, 'Process completed successfully', 'Message', 0);
    psFailed:
      begin
        s := (Sender as TclDownLoader).Errors.Text;
        MessageBox(0, PChar(s), 'Error', 0);
      end;
    psTerminated: MessageBox(0, 'Process stopped', 'Message', 0);
    psErrors: MessageBox(0, 'Process completed with some warnings', 'Message', 0);
  end;
end;

procedure TDownLoaderTest.clDownLoader1UrlParsing(Sender: TObject;
  AURLComponents: TclUrlParser);
begin
  with AURLComponents do
  begin
    memInfo.Lines.Add('Scheme: ' + Scheme);
    memInfo.Lines.Add('Host: ' + Host);
    memInfo.Lines.Add('User: ' + UserName);
    memInfo.Lines.Add('Path: ' + Path);
    memInfo.Lines.Add('QueryString: ' + QueryString);
  end;
end;

procedure TDownLoaderTest.clDownLoader1Changed(Sender: TObject);
begin
  if FIsLoading then Exit;
  FIsLoading := True;
  try
    edtURL.Text := clDownLoader1.URL;
    edtUser.Text := clDownLoader1.UserName;
    edtPassword.Text := clDownLoader1.Password;
    edtFile.Text := clDownLoader1.LocalFile;
    edtDirectory.Text := clDownLoader1.LocalFolder;
    updThreadCount.Position := clDownLoader1.ThreadCount;
    updBufferSize.Position := clDownLoader1.BatchSize;
  finally
    FIsLoading := False;
  end;
end;

procedure TDownLoaderTest.clDownLoader1GetResourceInfo(Sender: TObject;
  ResourceInfo: TclResourceInfo);
var
  s: String;
begin
  if (ResourceInfo <> nil) then
  begin
    s := 'Resource ' + ResourceInfo.Name + '; Size ' + IntToStr(ResourceInfo.Size)
      + '; Date ' + DateTimeToStr(ResourceInfo.Date)
      + '; Type ' + ResourceInfo.ContentType;
    if ResourceInfo.Compressed then
    begin
      s := s + '; Compressed';
    end;
  end else
  begin
    s := 'There are no any info available.';
  end;
  memInfo.Lines.Add(s);
end;

procedure TDownLoaderTest.clDownLoader1DataTextProceed(Sender: TObject;
  Text: TStrings);
begin
  memPreview.Lines.Assign(Text);
end;

procedure TDownLoaderTest.clDownLoader1Error(Sender: TObject;
  const Error: String; ErrorCode: Integer);
begin
  memErrors.Lines.Text := (Sender as TclDownLoader).Errors.Text;
end;

procedure TDownLoaderTest.edtThreadCountChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.ThreadCount := updThreadCount.Position;
end;

procedure TDownLoaderTest.edtBufferSizeChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clDownLoader1.BatchSize := updBufferSize.Position;
end;

end.
