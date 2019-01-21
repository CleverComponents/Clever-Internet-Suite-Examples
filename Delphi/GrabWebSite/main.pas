unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMultiDC, clMultiDownLoader, ComCtrls, DemoBaseFormUnit,
  ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtRootUrl: TEdit;
    clMultiDownLoader: TclMultiDownLoader;
    GroupBox1: TGroupBox;
    Label4: TLabel;
    edtTargetDir: TEdit;
    cbGrabAll: TCheckBox;
    cbGrabImages: TCheckBox;
    cbGrabData: TCheckBox;
    btnGrab: TButton;
    btnStop: TButton;
    Label5: TLabel;
    memLog: TMemo;
    StatusBar1: TStatusBar;
    edtMaxNestLevel: TEdit;
    Label6: TLabel;
    updMaxNestLevel: TUpDown;
    procedure clMultiDownLoaderIsBusyChanged(Sender: TObject);
    procedure btnGrabClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure clMultiDownLoaderProcessCompleted(Sender: TObject;
      Item: TclInternetItem);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.clMultiDownLoaderIsBusyChanged(Sender: TObject);
const
  status: array[Boolean] of string = ('Ready', 'Grabbing...');
begin
  StatusBar1.Panels[0].Text := status[clMultiDownLoader.IsBusy];
end;

procedure TForm1.btnGrabClick(Sender: TObject);
begin
  if clMultiDownLoader.IsBusy then Exit;
  memLog.Lines.Clear();

  clMultiDownLoader.GrabOptions := [];
  if cbGrabAll.Checked then
    clMultiDownLoader.GrabOptions := clMultiDownLoader.GrabOptions + [gaGrabAll];
  if cbGrabImages.Checked then
    clMultiDownLoader.GrabOptions := clMultiDownLoader.GrabOptions + [gaGrabImages];
  if cbGrabData.Checked then
    clMultiDownLoader.GrabOptions := clMultiDownLoader.GrabOptions + [gaGrabData];

  clMultiDownLoader.LocalFolder := edtTargetDir.Text;
  clMultiDownLoader.GrabWebsite(edtRootUrl.Text, updMaxNestLevel.Position);
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
  clMultiDownLoader.Stop();
end;

procedure TForm1.clMultiDownLoaderProcessCompleted(Sender: TObject;
  Item: TclInternetItem);
begin
  memLog.Lines.Add(Item.URL);
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clMultiDownLoader.IsBusy;
  if not CanClose then
  begin
    ShowMessage('Can not close the application. Please press the Stop button to cancel the grabbing process.');
  end;
end;

end.
