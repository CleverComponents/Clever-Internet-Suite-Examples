unit Main;

interface

uses
  Windows, SysUtils, Classes, Forms, Dialogs, StdCtrls, clDC, clUploader, clDCUtils,
  clMultiDC, clSingleDC, clProgressBar, clProgressBarDC, Controls, ShellAPI, clHttpRequest,
  clResourceState, DemoBaseFormUnit, Graphics, ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    Label4: TLabel;
    Label5: TLabel;
    edtFile: TEdit;
    btnBrowse: TButton;
    btnStart: TButton;
    edtHost: TEdit;
    OpenDialog1: TOpenDialog;
    clUploader: TclUploader;
    clProgressBar1: TclProgressBarDC;
    Memo1: TMemo;
    Label1: TLabel;
    btnStop: TButton;
    Label2: TLabel;
    edtViewPage: TEdit;
    btnView: TButton;
    clHttpRequest: TclHttpRequest;
    procedure btnBrowseClick(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure clUploaderStatusChanged(Sender: TObject;
      Status: TclProcessStatus);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure btnStopClick(Sender: TObject);
    procedure btnViewClick(Sender: TObject);
    procedure clUploaderProcessCompleted(Sender: TObject);
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnBrowseClick(Sender: TObject);
begin
  if OpenDialog1.Execute then
  begin
    edtFile.Text := OpenDialog1.FileName;
  end;
end;

procedure TMainForm.btnStartClick(Sender: TObject);
begin
  if clUploader.IsBusy then Exit;
  clUploader.URL := edtHost.Text;
  (clUploader.HTTPRequest.Items[0] as TclSubmitFileRequestItem).FileName := edtFile.Text;
  clUploader.Start();
end;

procedure TMainForm.clUploaderStatusChanged(Sender: TObject;
  Status: TclProcessStatus);
var
  s: String;
begin
  case Status of
    psSuccess:
    begin
      ShowMessage('Process completed successfully.');
    end;
    psErrors, psFailed:
      begin
        s := (Sender as TclUploader).Errors.Text;
        MessageBox(0, PChar(s), 'Error', 0);
      end;
    psTerminated: MessageBox(0, 'Process stopped', 'Message', 0);
  end;
end;

procedure TMainForm.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clUploader.IsBusy;
  if not CanClose then
  begin
    ShowMessage('Uploading is in progress');
  end;
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  clUploader.Stop();
end;

procedure TMainForm.btnViewClick(Sender: TObject);
begin
  ShellExecute(0, 'open', PChar(edtViewPage.Text), nil, nil, SW_RESTORE);
end;

procedure TMainForm.clUploaderProcessCompleted(Sender: TObject);
begin
  Memo1.Lines.Assign(clUploader.HttpResponse);
end;

end.
