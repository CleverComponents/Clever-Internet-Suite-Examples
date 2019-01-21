unit Main;

interface

uses
  Windows, SysUtils, Classes, Forms, Dialogs, StdCtrls, clDC, clUploader, clDCUtils,
  clMultiDC, clSingleDC, clProgressBar, Controls, ShellAPI, clMultiUploader,
  clInternetConnection, clHttpRequest, clResourceState, DemoBaseFormUnit,
  Graphics, ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    Label4: TLabel;
    edtFirstName: TEdit;
    btnStart: TButton;
    memResult: TMemo;
    Label1: TLabel;
    Label2: TLabel;
    edtViewPage: TEdit;
    btnView: TButton;
    Label3: TLabel;
    edtLastName: TEdit;
    clMultiUploader: TclMultiUploader;
    Label6: TLabel;
    edtAccount: TEdit;
    Label7: TLabel;
    edtDescription: TEdit;
    Label8: TLabel;
    edtFileName: TEdit;
    clInternetConnection: TclInternetConnection;
    btnStop: TButton;
    rbStep1: TclHttpRequest;
    rbStep2: TclHttpRequest;
    procedure btnStartClick(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure btnViewClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clMultiUploaderProcessCompleted(Sender: TObject;
      Item: TclInternetItem);
  private
    function ProcessStep1: Boolean;
    procedure ProcessStep2;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnStartClick(Sender: TObject);
begin
  if clMultiUploader.IsBusy then
  begin
    ShowMessage('Uploading is in progress');
    Exit;
  end;
  memResult.Lines.Clear();
  clInternetConnection.Close();
  if ProcessStep1() then
  begin
    ProcessStep2();
  end;
end;

function TMainForm.ProcessStep1: Boolean;
var
  Item: TclUploadItem;
begin
  Item := clMultiUploader.UploadList[0];
  rbStep1.FormFields['FirstName'].FieldValue := edtFirstName.Text;
  rbStep1.FormFields['LastName'].FieldValue := edtLastName.Text;
  rbStep1.FormFields['Account'].FieldValue := edtAccount.Text;
  Item.Start(False);
  Result := (Item.ResourceState.LastStatus = psSuccess);
end;

procedure TMainForm.ProcessStep2;
var
  Item: TclUploadItem;
begin
  Item := clMultiUploader.UploadList[1];
  rbStep2.FormFields['Description'].FieldValue := edtDescription.Text;
  (Item.HTTPRequest.Items[1] as TclSubmitFileRequestItem).FileName := edtFileName.Text;
  Item.Start(True);
end;

procedure TMainForm.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clMultiUploader.IsBusy;
  if not CanClose then
  begin
    ShowMessage('Uploading is in progress');
  end;
end;

procedure TMainForm.btnViewClick(Sender: TObject);
begin
  ShellExecute(0, 'open', PChar(edtViewPage.Text), nil, nil, SW_RESTORE);
end;

procedure TMainForm.btnStopClick(Sender: TObject);
begin
  clMultiUploader.Stop();
end;

procedure TMainForm.clMultiUploaderProcessCompleted(Sender: TObject;
  Item: TclInternetItem);
begin
  case Item.ResourceState.LastStatus of
    psSuccess:
    begin
      memResult.Lines.Add(Format('---------- Step %d ------------', [Item.Index + 1]));
      memResult.Lines.AddStrings((Item as TclUploadItem).HttpResponse);

      if (Item.Index > 0) then
      begin
        ShowMessage('Process completed successfully.');
      end;
    end;
    psErrors, psFailed:
      begin
        MessageBox(0, PChar(Item.Errors.Text), 'Error', 0);
      end;
    psTerminated: MessageBox(0, 'Process stopped', 'Message', 0);
  end;
end;

end.
