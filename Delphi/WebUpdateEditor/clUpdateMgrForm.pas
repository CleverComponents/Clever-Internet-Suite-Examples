unit clUpdateMgrForm;

interface

uses
  Windows, Messages, SysUtils{$IFDEF VER140}, Variants{$ENDIF}, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, Buttons, clWebUpdate, clUtils;

type
  TclUpdateMgrFrm = class(TForm)
    memScript: TMemo;
    Label1: TLabel;
    lbUpdates: TListBox;
    Label2: TLabel;
    edtUpdateVersion: TEdit;
    Label3: TLabel;
    edtURL: TEdit;
    Label4: TLabel;
    edtSize: TEdit;
    cbNeedTerminate: TCheckBox;
    Label5: TLabel;
    btnAdd: TButton;
    btnDelete: TButton;
    btnOk: TButton;
    btnCancel: TButton;
    Bevel1: TBevel;
    btnUp: TBitBtn;
    btnDown: TBitBtn;
    procedure lbUpdatesClick(Sender: TObject);
    procedure btnAddClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure edtUpdateVersionChange(Sender: TObject);
    procedure edtURLChange(Sender: TObject);
    procedure edtSizeChange(Sender: TObject);
    procedure cbNeedTerminateClick(Sender: TObject);
    procedure memScriptChange(Sender: TObject);
    procedure btnUpClick(Sender: TObject);
    procedure btnDownClick(Sender: TObject);
  private
    FUpdating: Boolean;
    FUpdateInfo: TclUpdateInfoList;
    procedure LoadUpdateInfo(AUpdateInfo: TclUpdateInfoList);
    procedure FillListbox(ASelectedIndex: Integer);
    procedure StoreUpdateInfo(AUpdateInfo: TclUpdateInfoList);
    function GetCurrentItem: TclUpdateInfoItem;
    function GetListboxItemName(AUpdateInfoItem: TclUpdateInfoItem): string;
    procedure UpdateControls;
  public
    constructor Create(AOwner: TComponent); override;
    destructor Destroy; override;
    class function ShowEditor(AUpdateInfo: TclUpdateInfoList): Boolean;
  end;

implementation

{$R *.dfm}

{ TclUpdateMgrFrm }

class function TclUpdateMgrFrm.ShowEditor(AUpdateInfo: TclUpdateInfoList): Boolean;
var
  dlg: TclUpdateMgrFrm;
begin
  dlg := TclUpdateMgrFrm.Create(nil);
  try
    dlg.LoadUpdateInfo(AUpdateInfo);
    Result := (dlg.ShowModal() = mrOK);
    if Result then
    begin
      dlg.StoreUpdateInfo(AUpdateInfo);
    end;
  finally
    dlg.Free();
  end;
end;

procedure TclUpdateMgrFrm.LoadUpdateInfo(AUpdateInfo: TclUpdateInfoList);
begin
  FUpdateInfo.Assign(AUpdateInfo);
  FillListbox(0);
end;

procedure TclUpdateMgrFrm.StoreUpdateInfo(AUpdateInfo: TclUpdateInfoList);
begin
  AUpdateInfo.Assign(FUpdateInfo);
end;

constructor TclUpdateMgrFrm.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
  FUpdateInfo := TclUpdateInfoList.Create();
end;

destructor TclUpdateMgrFrm.Destroy;
begin
  FUpdateInfo.Free();
  inherited Destroy();
end;

procedure TclUpdateMgrFrm.lbUpdatesClick(Sender: TObject);
var
  item: TclUpdateInfoItem;
begin
  if lbUpdates.ItemIndex < 0 then Exit;
  FUpdating := True;
  try
    item := GetCurrentItem();
    edtUpdateVersion.Text := item.Version;
    edtURL.Text := item.URL;
    edtSize.Text := item.Size;
    cbNeedTerminate.Checked := item.NeedTerminate;
    memScript.Lines.Assign(item.UpdateScript);
  finally
    FUpdating := False;
  end;
end;

procedure TclUpdateMgrFrm.btnAddClick(Sender: TObject);
begin
  FUpdateInfo.Add();
  FillListbox(FUpdateInfo.Count - 1);
end;

procedure TclUpdateMgrFrm.FillListbox(ASelectedIndex: Integer);
var
  i: Integer;
begin
  lbUpdates.Items.Clear();
  for i := 0 to FUpdateInfo.Count - 1 do
  begin
    lbUpdates.Items.AddObject(GetListboxItemName(FUpdateInfo[i]), FUpdateInfo[i]);
  end;
  if (lbUpdates.Items.Count > ASelectedIndex) then
  begin
    lbUpdates.ItemIndex := ASelectedIndex;
  end;
  UpdateControls();
  lbUpdatesClick(nil);
end;

procedure TclUpdateMgrFrm.btnDeleteClick(Sender: TObject);
var
  ind: Integer;
begin
  ind := lbUpdates.ItemIndex;
  if ind < 0 then Exit;
  FUpdateInfo.Delete(ind);
  if (ind > 0) then
  begin
    Dec(ind);
  end;
  FillListbox(ind);
end;

procedure TclUpdateMgrFrm.edtUpdateVersionChange(Sender: TObject);
begin
  if FUpdating then Exit;
  GetCurrentItem().Version := edtUpdateVersion.Text;
  lbUpdates.Items[lbUpdates.ItemIndex] := GetListboxItemName(GetCurrentItem());
end;

procedure TclUpdateMgrFrm.edtURLChange(Sender: TObject);
begin
  if FUpdating then Exit;
  GetCurrentItem().URL := edtURL.Text;
  lbUpdates.Items[lbUpdates.ItemIndex] := GetListboxItemName(GetCurrentItem());
end;

procedure TclUpdateMgrFrm.edtSizeChange(Sender: TObject);
begin
  if FUpdating then Exit;
  GetCurrentItem().Size := edtSize.Text;
end;

procedure TclUpdateMgrFrm.cbNeedTerminateClick(Sender: TObject);
begin
  if FUpdating then Exit;
  GetCurrentItem().NeedTerminate := cbNeedTerminate.Checked;
end;

procedure TclUpdateMgrFrm.memScriptChange(Sender: TObject);
begin
  if FUpdating then Exit;
  GetCurrentItem().UpdateScript.Assign(memScript.Lines);
end;

function TclUpdateMgrFrm.GetCurrentItem: TclUpdateInfoItem;
begin
  if (lbUpdates.ItemIndex < 0) then
  begin
    Result := nil;
  end else
  begin
    Result := TclUpdateInfoItem(lbUpdates.Items.Objects[lbUpdates.ItemIndex]);
  end;
end;

procedure TclUpdateMgrFrm.UpdateControls;
var
  disable: Boolean;
begin
  disable := (lbUpdates.Items.Count < 1);
  memScript.ReadOnly := disable;
  edtUpdateVersion.ReadOnly := disable;
  edtURL.ReadOnly := disable;
  edtSize.ReadOnly := disable;
  cbNeedTerminate.Enabled := not disable;
end;

function TclUpdateMgrFrm.GetListboxItemName(
  AUpdateInfoItem: TclUpdateInfoItem): string;
var
  ind: Integer;
begin
  Result := 'Unspecified';
  ind := RTextPos('/', AUpdateInfoItem.URL);
  if (ind > 0) then
  begin
    Result := Copy(AUpdateInfoItem.URL, ind, 1000);
  end else
  if (AUpdateInfoItem.URL <> '') then
  begin
    Result := AUpdateInfoItem.URL;
  end;
  if (AUpdateInfoItem.Version <> '') then
  begin
    Result := ' - ' + Result;
  end;
  Result := AUpdateInfoItem.Version + Result;
end;

procedure TclUpdateMgrFrm.btnUpClick(Sender: TObject);
var
  ind: Integer;
begin
  ind := lbUpdates.ItemIndex;
  if ind < 1 then Exit;
  FUpdateInfo[ind].Index := ind - 1;
  FillListbox(ind - 1);
end;

procedure TclUpdateMgrFrm.btnDownClick(Sender: TObject);
var
  ind: Integer;
begin
  ind := lbUpdates.ItemIndex;
  if (ind < 0) or (ind = FUpdateInfo.Count - 1) then Exit;
  FUpdateInfo[ind].Index := ind + 1;
  FillListbox(ind + 1);
end;

end.
