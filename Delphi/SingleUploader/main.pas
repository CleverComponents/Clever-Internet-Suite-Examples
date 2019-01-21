unit main;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, clWinInet, clDC, clDCUtils, clUploader, clMultiDC, clSingleDC,
  clProgressBar, clProgressBarDC, clResourceState, DemoBaseFormUnit,
  ExtCtrls, clUriUtils;

type
  TUploaderTest = class(TclDemoBaseForm)
    btnUpload: TButton;
    edtURL: TEdit;
    edtFile: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Edit1: TEdit;
    btnGetInfo: TButton;
    Label4: TLabel;
    memErrors: TMemo;
    Label6: TLabel;
    edtUser: TEdit;
    edtPassword: TEdit;
    btnStop: TButton;
    memInfo: TMemo;
    Label7: TLabel;
    Label9: TLabel;
    clUploader1: TclUploader;
    clProgressBar1: TclProgressBarDC;
    Label5: TLabel;
    Label13: TLabel;
    Label8: TLabel;
    procedure btnUploadClick(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure btnGetInfoClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure edtFileChange(Sender: TObject);
    procedure edtUserChange(Sender: TObject);
    procedure edtPasswordChange(Sender: TObject);
    procedure edtURLChange(Sender: TObject);
    procedure clUploader1Error(Sender: TObject; const Error: String;
      ErrorCode: Integer);
    procedure clUploader1GetResourceInfo(Sender: TObject;
      ResourceInfo: TclResourceInfo);
    procedure clUploader1StatusChanged(Sender: TObject;
      Status: TclProcessStatus);
    procedure clUploader1Changed(Sender: TObject);
    procedure clUploader1DataItemProceed(Sender: TObject;
      ResourceInfo: TclResourceInfo; AStateItem: TclResourceStateItem;
      CurrentData: PAnsiChar; CurrentDataSize: Integer);
    procedure clUploader1UrlParsing(Sender: TObject;
      AURLComponents: TclUrlParser);
  private
    FIsLoading: Boolean;
  end;

var
  UploaderTest: TUploaderTest;

implementation

{$R *.DFM}

procedure TUploaderTest.btnUploadClick(Sender: TObject);
begin
  memInfo.Lines.Clear();
  memErrors.Lines.Clear();
  clUploader1.Start(True);
end;

procedure TUploaderTest.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clUploader1.IsBusy;
end;

procedure TUploaderTest.btnGetInfoClick(Sender: TObject);
begin
  memInfo.Lines.Clear();
  memErrors.Lines.Clear();
  clUploader1.GetResourceInfo(True);
end;

procedure TUploaderTest.btnStopClick(Sender: TObject);
begin
  clUploader1.Stop();
end;

procedure TUploaderTest.edtFileChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clUploader1.LocalFile := edtFile.Text;
end;

procedure TUploaderTest.edtUserChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clUploader1.UserName := edtUser.Text;
end;

procedure TUploaderTest.edtPasswordChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clUploader1.Password := edtPassword.Text;
end;

procedure TUploaderTest.edtURLChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clUploader1.URL := edtURL.Text;
end;

procedure TUploaderTest.clUploader1Error(Sender: TObject;
  const Error: String; ErrorCode: Integer);
begin
  memErrors.Lines.Text := (Sender as TclUploader).Errors.Text;
end;

procedure TUploaderTest.clUploader1GetResourceInfo(Sender: TObject;
  ResourceInfo: TclResourceInfo);
var
  s: String;
begin
  if (ResourceInfo <> nil) then
  begin
    s := 'Resource ' + ResourceInfo.Name + '; Size ' + IntToStr(ResourceInfo.Size)
      + '; Date ' + DateTimeToStr(ResourceInfo.Date)
      + '; Type ' + ResourceInfo.ContentType;
  end else
  begin
    s := 'There are no any info available.';
  end;
  memInfo.Lines.Add(s);
end;

procedure TUploaderTest.clUploader1StatusChanged(Sender: TObject;
  Status: TclProcessStatus);
var
  s: String;
begin
  case Status of
    psSuccess: MessageBox(0, 'Process completed successfully', 'Message', 0);
    psFailed:
      begin
        s := (Sender as TclUploader).Errors.Text;
        MessageBox(0, PChar(s), 'Error', 0);
      end;
    psTerminated: MessageBox(0, 'Process stopped', 'Message', 0);
    psErrors: MessageBox(0, 'Process completed with some errors', 'Message', 0);
  end;
end;

procedure TUploaderTest.clUploader1UrlParsing(Sender: TObject;
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

procedure TUploaderTest.clUploader1Changed(Sender: TObject);
begin
  if FIsLoading then Exit;
  FIsLoading := True;
  try
    edtURL.Text := clUploader1.URL;
    edtUser.Text := clUploader1.UserName;
    edtPassword.Text := clUploader1.Password;
    edtFile.Text := clUploader1.LocalFile;
  finally
    FIsLoading := False;
  end;
end;

procedure TUploaderTest.clUploader1DataItemProceed(Sender: TObject;
  ResourceInfo: TclResourceInfo; AStateItem: TclResourceStateItem;
  CurrentData: PAnsiChar; CurrentDataSize: Integer);
var
  State: TclResourceStateList;
begin
  State := AStateItem.ResourceState;
  Edit1.Text := Format('%n of %n Kb proceed, speed %n Kb/sec, elapsed %n min, remains %n min',
    [State.BytesProceed / 1024, State.ResourceSize / 1024, State.Speed / 1024,
    State.ElapsedTime / 60, State.RemainingTime / 60]);
end;

end.
