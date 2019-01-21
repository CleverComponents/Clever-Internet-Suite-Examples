unit main;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ShellAPI,
  clDC, clMultiDownLoader, StdCtrls, ComCtrls, ExtCtrls, clDownLoader, registry,
  clNewsChecker, clMultiDC, clDCUtils, clSingleDC, clProgressBar, clProgressBarDC,
  clResourceState, CommCtrl, Math, DemoBaseFormUnit;

type
  TDownLoaderTest = class(TclDemoBaseForm)
    clMultiDownLoader: TclMultiDownLoader;
    PageControl: TPageControl;
    tabTasks: TTabSheet;
    tabDetails: TTabSheet;
    Label1: TLabel;
    Label6: TLabel;
    Label9: TLabel;
    Label4: TLabel;
    edtURL: TEdit;
    edtUser: TEdit;
    edtPassword: TEdit;
    memErrors: TMemo;
    Label5: TLabel;
    Label2: TLabel;
    edtFile: TEdit;
    memPreview: TMemo;
    Panel1: TPanel;
    Panel2: TPanel;
    ListView: TListView;
    btnAdd: TButton;
    btnDelete: TButton;
    Label3: TLabel;
    memInfo: TMemo;
    tabOptions: TTabSheet;
    Label8: TLabel;
    edtDirectory: TEdit;
    Label7: TLabel;
    edtTimeOut: TEdit;
    edtPreviewCharCount: TEdit;
    Label10: TLabel;
    chkDownLoadNews: TCheckBox;
    edtSiteNewsURL: TEdit;
    btnViewSiteNews: TButton;
    cmbPriority: TComboBox;
    Label11: TLabel;
    updTimeOut: TUpDown;
    updPreviewCount: TUpDown;
    Bevel1: TBevel;
    Bevel2: TBevel;
    clNewsChecker: TclNewsChecker;
    edtThreadCount: TEdit;
    Label12: TLabel;
    updThreadCount: TUpDown;
    chkPassiveFTPMode: TCheckBox;
    Label13: TLabel;
    Label14: TLabel;
    edtHttpProxy: TEdit;
    edtProxyBypass: TEdit;
    clProgressBar: TclProgressBarDC;
    Label15: TLabel;
    edtBatchSize: TEdit;
    updBatchSize: TUpDown;
    btnDownLoad: TButton;
    btnStop: TButton;
    btnExit: TButton;
    btnGetInfo: TButton;
    Bevel3: TBevel;
    btnStop1: TButton;
    btnAdd1: TButton;
    btnDownload1: TButton;
    btnCancel: TButton;
    Label16: TLabel;
    edtReconnectAfter: TEdit;
    updReconnectAfter: TUpDown;
    Label17: TLabel;
    edtTryCount: TEdit;
    updTryCount: TUpDown;
    Label18: TLabel;
    edtProxyUser: TEdit;
    Label19: TLabel;
    edtProxyPassword: TEdit;
    Label20: TLabel;
    edtHttpPort: TEdit;
    Label21: TLabel;
    edtFtpProxy: TEdit;
    Label22: TLabel;
    edtFtpPort: TEdit;
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure btnGetInfoClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure btnDownLoadClick(Sender: TObject);
    procedure btnAddClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure PageControlChange(Sender: TObject);
    procedure ListViewChange(Sender: TObject; Item: TListItem; Change: TItemChange);
    procedure edtURLChange(Sender: TObject);
    procedure edtFileChange(Sender: TObject);
    procedure edtUserChange(Sender: TObject);
    procedure edtPasswordChange(Sender: TObject);
    procedure edtDirectoryChange(Sender: TObject);
    procedure ListViewDblClick(Sender: TObject);
    procedure edtTimeOutChange(Sender: TObject);
    procedure edtPreviewCharCountChange(Sender: TObject);
    procedure chkDownLoadNewsClick(Sender: TObject);
    procedure btnViewSiteNewsClick(Sender: TObject);
    procedure edtThreadCountChange(Sender: TObject);
    procedure chkPassiveFTPModeClick(Sender: TObject);
    procedure edtHttpProxyChange(Sender: TObject);
    procedure edtProxyBypassChange(Sender: TObject);
    procedure edtBatchSizeChange(Sender: TObject);
    procedure clProgressBarChanged(Sender: TObject);
    procedure clMultiDownLoaderChanged(Sender: TObject;
      Item: TclInternetItem);
    procedure clMultiDownLoaderIsBusyChanged(Sender: TObject);
    procedure clMultiDownLoaderGetResourceInfo(Sender: TObject;
      Item: TclInternetItem; ResourceInfo: TclResourceInfo);
    procedure clMultiDownLoaderStatusChanged(Sender: TObject;
      Item: TclInternetItem; Status: TclProcessStatus);
    procedure clNewsCheckerChanged(Sender: TObject);
    procedure clNewsCheckerNewsExist(Sender: TObject);
    procedure ListViewAdvancedCustomDrawSubItem(Sender: TCustomListView;
      Item: TListItem; SubItem: Integer; State: TCustomDrawState;
      Stage: TCustomDrawStage; var DefaultDraw: Boolean);
    procedure btnExitClick(Sender: TObject);
    procedure btnCancelClick(Sender: TObject);
    procedure edtReconnectAfterChange(Sender: TObject);
    procedure edtTryCountChange(Sender: TObject);
    procedure clMultiDownLoaderDataTextProceed(Sender: TObject;
      Item: TclDownLoadItem; Text: TStrings);
    procedure edtProxyUserChange(Sender: TObject);
    procedure edtProxyPasswordChange(Sender: TObject);
    procedure edtHttpPortChange(Sender: TObject);
    procedure edtFtpProxyChange(Sender: TObject);
    procedure edtFtpPortChange(Sender: TObject);
    procedure clMultiDownLoaderDataItemProceed(Sender: TObject;
      Item: TclInternetItem; ResourceInfo: TclResourceInfo;
      AStateItem: TclResourceStateItem; CurrentData: PAnsiChar;
      CurrentDataSize: Integer);
    procedure cmbPriorityChange(Sender: TObject);
  private
    FIsLoading: Boolean;
    FIsNewItem: Boolean;
    function NormalizeName(AName: String): String;
    procedure UpdateControls;
    procedure FillListView;
    procedure FillDetails(AItem: TclInternetItem);
    function GetSelectedItem: TclInternetItem;
    procedure LoadRegistry;
    procedure SaveRegistry;
    procedure DoShowNews(const AFileName: string);
    function GetFormattedTime(ATime: Double): string;
    function GetFormattedBytes(ABytes: Double): string;
  public
    procedure MultiDownLoaderErrorHandler(Sender: TObject; Item: TclInternetItem;
      const Error: String; ErrorCode: Integer);
  end;

var
  DownLoaderTest: TDownLoaderTest;

implementation

const
  cDownLoadingStopConfirm = 'Downloading is in progress. Do you wish to stop the process?';
  cNoResourceInfoAvailable = 'There are no any info available.';
  cDownLoadStatuses: array[TclProcessStatus] of string = ('Ready', 'Done', 'Failed', 'Warnings', 'Process', 'Stopped');
  cUnknown = 'Undefined';
  cRegistryPath = '\Software\Clever Components\Clever Internet Suite\MultiDownLoader';
  cSiteNewsKey = 'News';

{$R *.DFM}

{ TDownLoaderTest }

procedure TDownLoaderTest.btnAddClick(Sender: TObject);
var
  ListItem: TListItem;
begin
  ListItem := ListView.Items.Add();
  ListItem.Caption := NormalizeName('');
  ListItem.Data := clMultiDownLoader.DownLoadList.Add();
  ListItem.SubItems.Add('');
  ListItem.SubItems.Add('');
  ListItem.SubItems.Add('');
  ListItem.SubItems.Add('');
  ListItem.SubItems.Add('');
  ListItem.SubItems.Add(cDownLoadStatuses[psUnknown]);
  ListView.Selected := ListItem;
  FIsNewItem := True;
  ListViewDblClick(nil);
end;

procedure TDownLoaderTest.btnDeleteClick(Sender: TObject);
begin
  GetSelectedItem().Free();
  ListView.Selected.Free();
  UpdateControls();
end;

procedure TDownLoaderTest.btnGetInfoClick(Sender: TObject);
begin
  clMultiDownLoader.GetResourceInfo(GetSelectedItem(), True);
  UpdateControls();
end;

procedure TDownLoaderTest.btnStopClick(Sender: TObject);
begin
  clMultiDownLoader.Stop(GetSelectedItem());
  UpdateControls();
end;

procedure TDownLoaderTest.btnDownLoadClick(Sender: TObject);
begin
  clMultiDownLoader.Start(GetSelectedItem(), True);
  UpdateControls();
end;

procedure TDownLoaderTest.FillListView;
var
  i: Integer;
  Item: TclInternetItem;
  ListItem: TListItem;
begin
  ListView.Items.BeginUpdate();
  try
    ListView.Items.Clear();
    for i := 0 to clMultiDownLoader.DownLoadList.Count - 1 do
    begin
      Item := clMultiDownLoader.DownLoadList[i];
      ListItem := ListView.Items.Add();
      ListItem.Caption := NormalizeName(Item.URL);
      ListItem.Data := Item;
      ListItem.SubItems.Add('');
      ListItem.SubItems.Add('');
      ListItem.SubItems.Add('');
      ListItem.SubItems.Add('');
      ListItem.SubItems.Add('');
      ListItem.SubItems.Add(cDownLoadStatuses[psUnknown]);
    end;
  finally
    ListView.Items.EndUpdate();
  end;
end;

procedure TDownLoaderTest.FormShow(Sender: TObject);
begin
  FIsLoading := True;
  try
    PageControl.ActivePage := tabTasks;
    FillListView();
  finally
    FIsLoading := False;
  end;
  UpdateControls();
  if chkDownLoadNews.Checked then
  begin
    clNewsChecker.Start(True);
  end;
end;

function TDownLoaderTest.GetSelectedItem: TclInternetItem;
begin
  if (ListView.Selected <> nil) then
  begin
    Result := TclInternetItem(ListView.Selected.Data);
  end else
  begin
    Result := nil;
  end;
end;

procedure TDownLoaderTest.PageControlChange(Sender: TObject);
begin
  FillDetails(GetSelectedItem());
  UpdateControls();
end;

procedure TDownLoaderTest.UpdateControls;
var
  b: Boolean;
  Item: TclInternetItem;
begin
  Item := GetSelectedItem();
  if (PageControl.ActivePage = tabTasks) then
  begin
    b := (Item <> nil);
    btnDelete.Enabled := b and (not Item.IsBusy);
    btnDownLoad.Enabled := b and (not Item.IsBusy);
    btnStop.Enabled := b and Item.IsBusy;
  end else
  if (PageControl.ActivePage = tabDetails) then
  begin
    b := (Item <> nil);
    btnGetInfo.Enabled := b and (not Item.IsBusy);
    btnStop1.Enabled := b and Item.IsBusy;
    btnDownLoad1.Enabled := b and (not Item.IsBusy);
    btnCancel.Enabled := b and (not Item.IsBusy) and FIsNewItem;
    b := (Item <> nil) and (not Item.IsBusy);
    edtURL.Enabled := b;
    edtFile.Enabled := b;
    edtUser.Enabled := b;
    edtPassword.Enabled := b;
    memInfo.Enabled := b;
    memPreview.Enabled := b;
    memErrors.Enabled := b;
    cmbPriority.Enabled := b;
    updThreadCount.Enabled := b;
    edtThreadCount.Enabled := b;
  end else
  if (PageControl.ActivePage = tabOptions) then
  begin
    btnViewSiteNews.Enabled := chkDownLoadNews.Checked;
  end;
end;

procedure TDownLoaderTest.ListViewChange(Sender: TObject; Item: TListItem; Change: TItemChange);
begin
  UpdateControls();
end;

procedure TDownLoaderTest.FillDetails(AItem: TclInternetItem);
begin
  if (PageControl.ActivePage <> tabDetails) or FIsLoading then Exit;
  FIsLoading := True;
  try
    if (AItem <> nil) then
    begin
      edtURL.Text := AItem.URL;
      edtFile.Text := AItem.LocalFile;
      edtUser.Text := AItem.UserName;
      edtPassword.Text := AItem.Password;
      cmbPriority.ItemIndex := Integer(AItem.Priority);
      updThreadCount.Position := Integer(AItem.ThreadCount);
      memInfo.Lines.Clear();
      if (AItem.ResourceInfo <> nil) then
      begin
        memInfo.Lines.Add('Resource ' + AItem.ResourceInfo.Name);
        memInfo.Lines.Add(Format('Size %n Bytes', [AItem.ResourceInfo.Size / 1]));
        memInfo.Lines.Add('Date ' + DateTimeToStr(AItem.ResourceInfo.Date));
        memInfo.Lines.Add('Type ' + AItem.ResourceInfo.ContentType);
        if AItem.ResourceInfo.Compressed then
        begin
          memInfo.Lines.Add('Compressed');
        end;
      end else
      begin
        memInfo.Lines.Add(cNoResourceInfoAvailable);
      end;
      if (AItem is TclDownLoadItem) then
      begin
        memPreview.Lines.Assign((AItem as TclDownLoadItem).Preview);
      end else
      begin
        memPreview.Lines.Clear();
      end;
      memErrors.Lines.Text := AItem.Errors.Text;
    end else
    begin
      edtURL.Text := '';
      edtFile.Text := '';
      edtUser.Text := '';
      edtPassword.Text := '';
      cmbPriority.ItemIndex := -1;
      memInfo.Lines.Clear();
      memPreview.Lines.Clear();
      memErrors.Lines.Clear();
      updThreadCount.Position := 0;
    end;
  finally
    FIsLoading := False;
  end;
end;

procedure TDownLoaderTest.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clMultiDownLoader.IsBusy;
  if not CanClose then
  begin
    CanClose := (MessageBox(0, cDownLoadingStopConfirm, 'Warning', MB_OKCANCEL) = IDOK);
    if CanClose then
    begin
      clMultiDownLoader.Stop();
      while clMultiDownLoader.IsBusy do
        Application.ProcessMessages();
    end;
  end;
  if CanClose then
  begin
    clNewsChecker.Stop();
    while clNewsChecker.IsBusy do
      Application.ProcessMessages();
  end;
end;

procedure TDownLoaderTest.edtURLChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.URL := edtURL.Text;
    ListView.Selected.Caption := NormalizeName(Item.URL);
  end;
end;

procedure TDownLoaderTest.edtFileChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.LocalFile := edtFile.Text;
  end;
end;

procedure TDownLoaderTest.edtUserChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.UserName := edtUser.Text;
  end;
end;

procedure TDownLoaderTest.edtPasswordChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.Password := edtPassword.Text;
  end;
end;

procedure TDownLoaderTest.edtThreadCountChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.ThreadCount := updThreadCount.Position;
  end;
end;

procedure TDownLoaderTest.edtDirectoryChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.LocalFolder := edtDirectory.Text;
end;

procedure TDownLoaderTest.chkPassiveFTPModeClick(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.PassiveFTPMode := chkPassiveFTPMode.Checked;
end;

procedure TDownLoaderTest.edtHttpProxyChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.HttpProxySettings.Server := edtHttpProxy.Text;
end;

procedure TDownLoaderTest.edtProxyBypassChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.ProxyBypass.Text := Trim(edtProxyBypass.Text);
end;

procedure TDownLoaderTest.FormCreate(Sender: TObject);
var
  i: TclProcessPriority;
begin
  clMultiDownLoader.OnError := MultiDownLoaderErrorHandler;
  LoadRegistry();
end;

function TDownLoaderTest.NormalizeName(AName: String): String;
begin
  Result := AName;
  if (Trim(Result) = '') then
  begin
    Result := cUnknown;
  end;
end;

procedure TDownLoaderTest.ListViewDblClick(Sender: TObject);
begin
  FIsLoading := True;
  try
    PageControl.ActivePage := tabDetails;
  finally
    FIsLoading := False;
  end;
  PageControlChange(nil);
end;

procedure TDownLoaderTest.FormDestroy(Sender: TObject);
begin
  SaveRegistry();
end;

procedure TDownLoaderTest.edtTimeOutChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.TimeOut := updTimeOut.Position * 1000;
end;

procedure TDownLoaderTest.edtPreviewCharCountChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.PreviewCharCount := updPreviewCount.Position;
end;

procedure TDownLoaderTest.cmbPriorityChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) and (cmbPriority.ItemIndex > - 1) then
  begin
    Item.Priority := TclProcessPriority(cmbPriority.ItemIndex);
  end;
end;

procedure TDownLoaderTest.chkDownLoadNewsClick(Sender: TObject);
begin
  UpdateControls();
end;

procedure TDownLoaderTest.LoadRegistry;
var
  reg: TRegistry;
begin
  clMultiDownLoader.ReadRegistry(cRegistryPath);
  reg := TRegistry.Create();
  try
    if (reg.OpenKey(cRegistryPath, False)) and reg.ValueExists(cSiteNewsKey) then
    begin
      chkDownLoadNews.Checked := reg.ReadBool(cSiteNewsKey);
      reg.CloseKey();
    end;
  finally
    reg.Free();
  end;
end;

procedure TDownLoaderTest.SaveRegistry;
var
  reg: TRegistry;
begin
  clMultiDownLoader.WriteRegistry(cRegistryPath);
  reg := TRegistry.Create();
  try
    if (reg.OpenKey(cRegistryPath, True)) then
    begin
      reg.WriteBool(cSiteNewsKey, chkDownLoadNews.Checked);
      reg.CloseKey();
    end;
  finally
    reg.Free();
  end;
end;

procedure TDownLoaderTest.btnViewSiteNewsClick(Sender: TObject);
begin
  clNewsChecker.Start(False);
  if not clNewsChecker.IsNewsExist then
  begin
    DoShowNews(clNewsChecker.LocalFile);
  end;
end;

procedure TDownLoaderTest.DoShowNews(const AFileName: string);
begin
  ShellExecute(0, 'open', PChar(AFileName), nil, nil, SW_RESTORE);
end;

procedure TDownLoaderTest.clMultiDownLoaderChanged(Sender: TObject;
  Item: TclInternetItem);
begin
  FIsNewItem := False;
  FillDetails(Item);
  if FIsLoading then Exit;
  FIsLoading := True;
  try
    edtDirectory.Text := clMultiDownLoader.LocalFolder;
    updTimeOut.Position := clMultiDownLoader.TimeOut div 1000;
    updPreviewCount.Position := clMultiDownLoader.PreviewCharCount;
    chkPassiveFTPMode.Checked := clMultiDownLoader.PassiveFTPMode;
    edtHttpProxy.Text := clMultiDownLoader.HttpProxySettings.Server;
    edtProxyBypass.Text := Trim(clMultiDownLoader.ProxyBypass.Text);
    edtProxyUser.Text := clMultiDownLoader.HttpProxySettings.UserName;
    edtProxyPassword.Text := clMultiDownLoader.HttpProxySettings.Password;
    edtHttpPort.Text := IntToStr(clMultiDownLoader.HttpProxySettings.Port);
    edtFtpProxy.Text := clMultiDownLoader.FtpProxySettings.Server;
    edtFtpPort.Text := IntToStr(clMultiDownLoader.FtpProxySettings.Port);
    updBatchSize.Position := clMultiDownLoader.BatchSize;
    updReconnectAfter.Position := clMultiDownLoader.ReconnectAfter div 1000;
    updTryCount.Position := clMultiDownLoader.TryCount;
  finally
    FIsLoading := False;
  end;
end;

procedure TDownLoaderTest.clMultiDownLoaderIsBusyChanged(Sender: TObject);
begin
  UpdateControls();
end;

procedure TDownLoaderTest.clMultiDownLoaderGetResourceInfo(Sender: TObject;
  Item: TclInternetItem; ResourceInfo: TclResourceInfo);
begin
  FillDetails(Item);
end;

procedure TDownLoaderTest.MultiDownLoaderErrorHandler(Sender: TObject; Item: TclInternetItem;
  const Error: String; ErrorCode: Integer);
begin
  FillDetails(Item);
end;

procedure TDownLoaderTest.clNewsCheckerChanged(Sender: TObject);
begin
  edtSiteNewsURL.Text := clNewsChecker.URL;
end;

procedure TDownLoaderTest.clNewsCheckerNewsExist(Sender: TObject);
begin
  DoShowNews((Sender as TclNewsChecker).LocalFile);
end;

procedure TDownLoaderTest.clMultiDownLoaderStatusChanged(Sender: TObject;
  Item: TclInternetItem; Status: TclProcessStatus);
var
  ListItem: TListItem;
  old: Boolean;
begin
  old := FIsLoading;
  FIsLoading := True;
  try
    ListItem := ListView.FindData(- 1, Item, False, False);
    if (ListItem <> nil) then
    begin
      ListItem.SubItems[4] := cDownLoadStatuses[Status];
    end;
  finally
    FIsLoading := old;
  end;
end;

function TDownLoaderTest.GetFormattedTime(ATime: Double): string;
var
  d, h, m, s: WORD;
begin
  m := floor(ATime / 60);
  s := floor(ATime - m * 60);
  h := floor(m / 60);
  m := m - h * 60;
  d := floor(h / 24);
  h := h - d * 24;
  Result := '';
  if (d > 0) then
  begin
    Result := Result + Format('%d d ', [d]);
  end;
  if (d > 0) or (h > 0) then
  begin
    Result := Result + Format('%d h ', [h]);
  end;
  Result := Result + Format('%d m %d s', [m, s]);
end;

function TDownLoaderTest.GetFormattedBytes(ABytes: Double): string;
begin
  if (ABytes < 1024) then
  begin
    Result := Format('%.2n b', [ABytes]);
  end else
  begin
    ABytes := (ABytes / 1024);
    if (ABytes < 1024) then
    begin
      Result := Format('%.2n Kb', [ABytes]);
    end else
    begin
      ABytes := (ABytes / 1024);
      Result := Format('%.2n Mb', [ABytes]);
    end;
  end;
end;

procedure TDownLoaderTest.clProgressBarChanged(Sender: TObject);
var
  R: TRect;
  i: Integer;
begin
  for i := 0 to ListView.Items.Count - 1 do
  begin
    ListView_GetSubItemRect(ListView.Handle, i, 4, LVIR_BOUNDS, @R);
    InvalidateRect(ListView.Handle, @R, False);
  end;
end;

procedure TDownLoaderTest.edtBatchSizeChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.BatchSize := updBatchSize.Position;
end;

procedure TDownLoaderTest.ListViewAdvancedCustomDrawSubItem(
  Sender: TCustomListView; Item: TListItem; SubItem: Integer;
  State: TCustomDrawState; Stage: TCustomDrawStage;
  var DefaultDraw: Boolean);
var
  R: TRect;
  InternetItem: TclInternetItem;
  ResourceState: TclResourceStateList;
  canvas: TCanvas;
begin
  InternetItem := TclInternetItem(Item.Data);
  if (InternetItem = nil) or (SubItem <> 4) then Exit;
  ResourceState := InternetItem.ResourceState;
  ListView_GetSubItemRect(Item.Handle, Item.Index, SubItem, LVIR_BOUNDS, @R);

  canvas := TControlCanvas.Create();
  try
    TControlCanvas(canvas).Control := Sender;
    clProgressBar.Draw(ResourceState, canvas, R);
  finally
    canvas.Free();
  end;
  DefaultDraw := False;
end;

procedure TDownLoaderTest.btnExitClick(Sender: TObject);
begin
  Close();
end;

procedure TDownLoaderTest.btnCancelClick(Sender: TObject);
begin
  if FIsNewItem then
  begin
    GetSelectedItem().Free();
    ListView.Selected.Free();
    PageControl.ActivePage := tabTasks;
  end;
end;

procedure TDownLoaderTest.edtReconnectAfterChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.ReconnectAfter := updReconnectAfter.Position * 1000;
end;

procedure TDownLoaderTest.edtTryCountChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.TryCount := updTryCount.Position;
end;

procedure TDownLoaderTest.clMultiDownLoaderDataItemProceed(Sender: TObject;
  Item: TclInternetItem; ResourceInfo: TclResourceInfo;
  AStateItem: TclResourceStateItem; CurrentData: PAnsiChar;
  CurrentDataSize: Integer);
var
  ListItem: TListItem;
  old: Boolean;
  State: TclResourceStateList;
begin
  old := FIsLoading;
  FIsLoading := True;
  try
    ListItem := ListView.FindData(- 1, Item, False, False);
    if (ListItem <> nil) then
    begin
      State := AStateItem.ResourceState;
      ListItem.SubItems[0] := GetFormattedBytes(State.BytesProceed);
      ListItem.SubItems[1] := GetFormattedBytes(State.Speed) + '/s';
      ListItem.SubItems[2] := GetFormattedTime(State.ElapsedTime);
      ListItem.SubItems[4] := GetFormattedTime(State.RemainingTime);
    end;
  finally
    FIsLoading := old;
  end;
end;

procedure TDownLoaderTest.clMultiDownLoaderDataTextProceed(Sender: TObject;
  Item: TclDownLoadItem; Text: TStrings);
begin
  FillDetails(Item);
end;

procedure TDownLoaderTest.edtProxyUserChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.HttpProxySettings.UserName := edtProxyUser.Text;
end;

procedure TDownLoaderTest.edtProxyPasswordChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.HttpProxySettings.Password := edtProxyPassword.Text;
end;

procedure TDownLoaderTest.edtHttpPortChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.HttpProxySettings.Port := StrToInt(edtHttpPort.Text);
end;

procedure TDownLoaderTest.edtFtpProxyChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.FtpProxySettings.Server := edtFtpProxy.Text;
end;

procedure TDownLoaderTest.edtFtpPortChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiDownLoader.FtpProxySettings.Port := StrToInt(edtFtpPort.Text);
end;

end.
