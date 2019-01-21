unit main;

interface

uses
  Windows, Messages, SysUtils, Classes, Controls, Forms,
  Dialogs, StdCtrls, clWebUpdate, clUtils, ComCtrls, ExtCtrls, Menus, DemoBaseFormUnit,
  Graphics, Buttons;

type
  TMainForm = class(TclDemoBaseForm)
    StatusBar: TStatusBar;
    clWebUpdate: TclWebUpdate;
    Memo1: TMemo;
    pnlBottom: TPanel;
    btnStartUpdate: TBitBtn;
    btnAbout: TBitBtn;
    btnClose: TBitBtn;
    procedure StatusBarMouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure StatusBarMouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure clWebUpdateError(Sender: TObject; UpdateNo: Integer; const Error: String; ErrorCode: Integer);
    procedure clWebUpdateNoUpdatesFound(Sender: TObject);
    procedure clWebUpdateTerminating(Sender: TObject;
      var CanTerminate: Boolean);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure clWebUpdateRunUpdate(Sender: TObject;
      AUpdateScript: TStrings; ANeedTerminate: Boolean;
      var CanRun: Boolean; var Result: TclRunUpdateResult;
      var AErrors: String);
    procedure clWebUpdateDownloadProgress(Sender: TObject; UpdateNo: Integer; Downloaded, Total: Int64);
    procedure btnStartUpdateClick(Sender: TObject);
    procedure btnAboutClick(Sender: TObject);
    procedure btnCloseClick(Sender: TObject);
  private
    procedure SetStatusBarCaption(const AText: string);
    procedure AddUpdateScript(const AScript: string);
    procedure AddStartAppStatement;
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

const
  starter = 'starter.cmd';

procedure TMainForm.StatusBarMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
  StatusBar.Panels[0].Bevel := pbLowered;
  clWebUpdate.Stop();
end;

procedure TMainForm.StatusBarMouseUp(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
begin
  StatusBar.Panels[0].Bevel := pbRaised;
end;

procedure TMainForm.SetStatusBarCaption(const AText: string);
begin
  StatusBar.Panels[1].Text := AText;
end;

procedure TMainForm.clWebUpdateNoUpdatesFound(Sender: TObject);
begin
  SetStatusBarCaption('There are no new updates available.');
end;

procedure TMainForm.clWebUpdateTerminating(Sender: TObject;
  var CanTerminate: Boolean);
begin
  CanTerminate := (MessageDlg('To apply the update you need to close the application. Do you want to close ?',
    mtConfirmation, [mbYes, mbNo], 0) = mrYes);
end;

procedure TMainForm.AddStartAppStatement;
begin
  AddUpdateScript('start ' + ExtractFileName(ParamStr(0)));
end;

procedure TMainForm.AddUpdateScript(const AScript: string);
var
  list: TStrings;
  s: string;
begin
  list := TStringList.Create();
  try
    s := AddTrailingBackSlash(ExtractFilePath(ParamStr(0))) + starter;
    if FileExists(s) then
    begin
      list.LoadFromFile(s);
    end;
    list.Text := list.Text + AScript;
    list.SaveToFile(s);
  finally
    list.Free();
  end;
end;

procedure TMainForm.FormCreate(Sender: TObject);
begin
  DeleteFile(starter);
end;

procedure TMainForm.FormDestroy(Sender: TObject);
begin
  AddStartAppStatement();
end;

procedure TMainForm.clWebUpdateDownloadProgress(Sender: TObject; UpdateNo: Integer; Downloaded, Total: Int64);
begin
  SetStatusBarCaption(Format('Downloading %d update: %d %% completed...', [UpdateNo + 1, Downloaded * 100 div Total]));
end;

procedure TMainForm.clWebUpdateError(Sender: TObject; UpdateNo: Integer;
  const Error: String; ErrorCode: Integer);
begin
  SetStatusBarCaption('Cannot download data from the web! "' + Error + '" error occured.');
end;

procedure TMainForm.clWebUpdateRunUpdate(Sender: TObject;
  AUpdateScript: TStrings; ANeedTerminate: Boolean; var CanRun: Boolean;
  var Result: TclRunUpdateResult; var AErrors: String);
begin
  if ANeedTerminate then
  begin
    AddUpdateScript(AUpdateScript.Text);
    CanRun := False;
  end;
end;

procedure TMainForm.btnStartUpdateClick(Sender: TObject);
begin
  SetStatusBarCaption('Checking for new updates...');
  clWebUpdate.Start();
end;

procedure TMainForm.btnAboutClick(Sender: TObject);
begin
  ShowMessage('Web Update Demo'#13#10'Clever Components'#13#10'www.clevercomponents.com');
end;

procedure TMainForm.btnCloseClick(Sender: TObject);
begin
  Close();
end;

end.
