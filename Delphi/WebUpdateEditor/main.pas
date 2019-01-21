unit main;

interface

{$I ..\Common\Defines.inc}

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clWebUpdate, clUpdateMgrForm, DemoBaseFormUnit,
  ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    edtUpdateFile: TEdit;
    Label1: TLabel;
    btnEdit: TButton;
    clWebUpdate: TclWebUpdate;
    btnClose: TButton;
    procedure btnEditClick(Sender: TObject);
    procedure btnCloseClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnEditClick(Sender: TObject);
begin
  if (edtUpdateFile.Text = '') then
  begin
    raise Exception.Create('The file name must be specified');
  end;
  clWebUpdate.UpdateInfo.LoadFromXml(edtUpdateFile.Text);
  if TclUpdateMgrFrm.ShowEditor(clWebUpdate.UpdateInfo) then
  begin
    clWebUpdate.UpdateInfo.SaveToXml(edtUpdateFile.Text);
    ShowMessage(Format('The %s file has been updated', [edtUpdateFile.Text]));
  end;
end;

procedure TMainForm.btnCloseClick(Sender: TObject);
begin
  Close();
end;

procedure TMainForm.FormShow(Sender: TObject);
begin
 {$IFDEF DELPHIX101}
  Height := 220;
 {$ENDIF}
end;

end.
