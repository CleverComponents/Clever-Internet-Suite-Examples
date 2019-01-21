unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMultiDC, clMultiUploader, ComCtrls, DemoBaseFormUnit,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    Label2: TLabel;
    clMultiUploader: TclMultiUploader;
    Label3: TLabel;
    Label4: TLabel;
    edtLocalFolder: TEdit;
    edtFtpDir: TEdit;
    Label5: TLabel;
    Label6: TLabel;
    edtUser: TEdit;
    edtPassword: TEdit;
    cbPassiveMode: TCheckBox;
    btnPublish: TButton;
    btnStop: TButton;
    StatusBar1: TStatusBar;
    Label7: TLabel;
    memLog: TMemo;
    Label8: TLabel;
    edtFileMask: TEdit;
    procedure clMultiUploaderIsBusyChanged(Sender: TObject);
    procedure clMultiUploaderProcessCompleted(Sender: TObject;
      Item: TclInternetItem);
    procedure btnStopClick(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure btnPublishClick(Sender: TObject);
    procedure clMultiUploaderPrepareItemToPublish(Sender: TObject;
      Item: TclUploadItem; var CanProceed, Handled: Boolean);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.clMultiUploaderIsBusyChanged(Sender: TObject);
const
  states: array[Boolean] of string = ('Ready', 'Publishing...');
begin
  StatusBar1.Panels[0].Text := states[clMultiUploader.IsBusy];
end;

procedure TForm1.clMultiUploaderProcessCompleted(Sender: TObject;
  Item: TclInternetItem);
begin
  memLog.Lines.Add(Item.URL);
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
  clMultiUploader.Stop();
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clMultiUploader.IsBusy;
  if (not CanClose) then
  begin
    ShowMessage('Can not close the application. Please press the Stop button to cancel the publishing process.');
  end;
end;

procedure TForm1.btnPublishClick(Sender: TObject);
begin
  if clMultiUploader.IsBusy then Exit;
  memLog.Lines.Clear();

  clMultiUploader.PublishFileMask := edtFileMask.Text;
  clMultiUploader.PassiveFTPMode := cbPassiveMode.Checked;

  clMultiUploader.Publish(edtLocalFolder.Text, edtFtpDir.Text);
end;

procedure TForm1.clMultiUploaderPrepareItemToPublish(Sender: TObject;
  Item: TclUploadItem; var CanProceed, Handled: Boolean);
begin
  Item.UserName := edtUser.Text;
  Item.Password := edtPassword.Text;
  Handled := True;
end;

end.
