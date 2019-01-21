unit main;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ShellAPI,
  clDC, StdCtrls, ComCtrls, ExtCtrls, clMultiDC, clDCUtils, clMultiUploader, clResourceState, DemoBaseFormUnit;

type
  TUploaderTest = class(TclDemoBaseForm)
    clMultiUploader: TclMultiUploader;
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
    Label2: TLabel;
    edtFile: TEdit;
    Panel1: TPanel;
    btnGetInfo: TButton;
    btnStop: TButton;
    btnUpload: TButton;
    Panel2: TPanel;
    ListView: TListView;
    btnAdd: TButton;
    btnDelete: TButton;
    Label3: TLabel;
    memInfo: TMemo;
    tabOptions: TTabSheet;
    Label7: TLabel;
    edtTimeOut: TEdit;
    cmbPriority: TComboBox;
    Label11: TLabel;
    updTimeOut: TUpDown;
    Bevel1: TBevel;
    Bevel2: TBevel;
    procedure btnAddClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnGetInfoClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure btnUploadClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure PageControlChange(Sender: TObject);
    procedure ListViewChange(Sender: TObject; Item: TListItem; Change: TItemChange);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure edtURLChange(Sender: TObject);
    procedure edtFileChange(Sender: TObject);
    procedure edtUserChange(Sender: TObject);
    procedure edtPasswordChange(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure ListViewDblClick(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure edtTimeOutChange(Sender: TObject);
    procedure clMultiUploaderIsBusyChanged(Sender: TObject);
    procedure clMultiUploaderDataItemProceed(Sender: TObject;
      Item: TclInternetItem; ResourceInfo: TclResourceInfo;
      AStateItem: TclResourceStateItem; CurrentData: PAnsiChar;
      CurrentDataSize: Integer);
    procedure clMultiUploaderGetResourceInfo(Sender: TObject;
      Item: TclInternetItem; ResourceInfo: TclResourceInfo);
    procedure clMultiUploaderStatusChanged(Sender: TObject;
      Item: TclInternetItem; Status: TclProcessStatus);
    procedure clMultiUploaderChanged(Sender: TObject;
      Item: TclInternetItem);
    procedure cmbPriorityChange(Sender: TObject);
  private
    FIsLoading: Boolean;
    function NormalizeName(AName: String): String;
    procedure UpdateControls;
    procedure FillListView;
    procedure FillDetails(AItem: TclInternetItem);
    function GetSelectedItem: TclInternetItem;
    procedure LoadRegistry;
    procedure SaveRegistry;
  public
    procedure MultiUploaderErrorHandler(Sender: TObject; Item: TclInternetItem;
      const Error: String; ErrorCode: Integer);
  end;

var
  UploaderTest: TUploaderTest;

implementation

const
  cUploadingStopConfirm = 'Uploading is in progress. Do you wish to stop the process?';
  cNoResourceInfoAvailable = 'There are no any info available.';
  cUploadStatuses: array[TclProcessStatus] of string = ('Ready', 'Done', 'Failed', 'Errors', 'Process', 'Stopped');
  cUnknown = 'Undefined';
  cRegistryPath = '\Software\Clever Components\Clever Internet Suite\MultiUploader';
  cSiteNewsKey = 'News';

{$R *.DFM}

{ TUploaderTest }

procedure TUploaderTest.btnAddClick(Sender: TObject);
var
  ListItem: TListItem;
begin
  ListItem := ListView.Items.Add();
  ListItem.Caption := NormalizeName('');
  ListItem.Data := clMultiUploader.UploadList.Add();
  ListItem.SubItems.Add('');
  ListItem.SubItems.Add(cUploadStatuses[psUnknown]);
  ListView.Selected := ListItem;
  ListViewDblClick(nil);
end;

procedure TUploaderTest.btnDeleteClick(Sender: TObject);
begin
  GetSelectedItem().Free();
  ListView.Selected.Free();
  UpdateControls();
end;

procedure TUploaderTest.btnGetInfoClick(Sender: TObject);
begin
  clMultiUploader.GetResourceInfo(GetSelectedItem(), True);
  UpdateControls();
end;

procedure TUploaderTest.btnStopClick(Sender: TObject);
begin
  clMultiUploader.Stop(GetSelectedItem());
  UpdateControls();
end;

procedure TUploaderTest.btnUploadClick(Sender: TObject);
begin
  clMultiUploader.Start(GetSelectedItem(), True);
  UpdateControls();
end;

procedure TUploaderTest.FillListView;
var
  i: Integer;
  Item: TclInternetItem;
  ListItem: TListItem;
begin
  ListView.Items.BeginUpdate();
  try
    ListView.Items.Clear();
    for i := 0 to clMultiUploader.UploadList.Count - 1 do
    begin
      Item := clMultiUploader.UploadList[i];
      ListItem := ListView.Items.Add();
      ListItem.Caption := NormalizeName(Item.LocalFile);
      ListItem.Data := Item;
      ListItem.SubItems.Add('');
      ListItem.SubItems.Add(cUploadStatuses[psUnknown]);
    end;
  finally
    ListView.Items.EndUpdate();
  end;
end;

procedure TUploaderTest.FormShow(Sender: TObject);
begin
  FIsLoading := True;
  try
    PageControl.ActivePage := tabTasks;
    FillListView();
  finally
    FIsLoading := False;
  end;
  UpdateControls();
end;

function TUploaderTest.GetSelectedItem: TclInternetItem;
begin
  if (ListView.Selected <> nil) then
  begin
    Result := TclInternetItem(ListView.Selected.Data);
  end else
  begin
    Result := nil;
  end;
end;

procedure TUploaderTest.PageControlChange(Sender: TObject);
begin
  FillDetails(GetSelectedItem());
  UpdateControls();
end;

procedure TUploaderTest.UpdateControls;
var
  b: Boolean;
  Item: TclInternetItem;
begin
  Item := GetSelectedItem();
  b := (Item <> nil);
  btnGetInfo.Enabled := b and (not Item.IsBusy);
  btnStop.Enabled := b and Item.IsBusy;
  btnUpload.Enabled := b and (not Item.IsBusy);
  if (PageControl.ActivePage = tabTasks) then
  begin
    btnDelete.Enabled := b and (not Item.IsBusy);
  end else
  if (PageControl.ActivePage = tabDetails) then
  begin
    edtURL.Enabled := b;
    edtFile.Enabled := b;
    edtUser.Enabled := b;
    edtPassword.Enabled := b;
    memInfo.Enabled := b;
    memErrors.Enabled := b;
    cmbPriority.Enabled := b;
  end else
  if (PageControl.ActivePage = tabOptions) then
  begin
    btnGetInfo.Enabled := False;
    btnStop.Enabled := False;
    btnUpload.Enabled := False;
  end;
end;

procedure TUploaderTest.ListViewChange(Sender: TObject; Item: TListItem; Change: TItemChange);
begin
  UpdateControls();
end;

procedure TUploaderTest.FillDetails(AItem: TclInternetItem);
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
      memInfo.Lines.Clear();
      if (AItem.ResourceInfo <> nil) then
      begin
        memInfo.Lines.Add('Resource ' + AItem.ResourceInfo.Name);
        memInfo.Lines.Add('Size ' + IntToStr(AItem.ResourceInfo.Size));
        memInfo.Lines.Add('Date ' + DateTimeToStr(AItem.ResourceInfo.Date));
        memInfo.Lines.Add('Type ' + AItem.ResourceInfo.ContentType);
      end else
      begin
        memInfo.Lines.Add(cNoResourceInfoAvailable);
      end;
      memErrors.Lines.Text := AItem.Errors.Text;
    end else
    begin
      edtURL.Text := '';
      edtFile.Text := '';
      edtUser.Text := '';
      edtPassword.Text := '';
      cmbPriority.ItemIndex := - 1;
      memInfo.Lines.Clear();
      memErrors.Lines.Clear();
    end;
  finally
    FIsLoading := False;
  end;
end;

procedure TUploaderTest.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clMultiUploader.IsBusy;
  if not CanClose then
  begin
    CanClose := (MessageBox(0, cUploadingStopConfirm, 'Warning', MB_OKCANCEL) = IDOK);
    if CanClose then
    begin
      clMultiUploader.Stop();
      while clMultiUploader.IsBusy do
        Application.ProcessMessages();
    end;
  end;
end;

procedure TUploaderTest.edtURLChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.URL := edtURL.Text;
  end;
end;

procedure TUploaderTest.edtFileChange(Sender: TObject);
var
  Item: TclInternetItem;
begin
  if FIsLoading then Exit;
  Item := GetSelectedItem();
  if (Item <> nil) then
  begin
    Item.LocalFile := edtFile.Text;
    ListView.Selected.Caption := NormalizeName(Item.LocalFile);
  end;
end;

procedure TUploaderTest.edtUserChange(Sender: TObject);
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

procedure TUploaderTest.edtPasswordChange(Sender: TObject);
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

procedure TUploaderTest.FormCreate(Sender: TObject);
begin
  clMultiUploader.OnError := MultiUploaderErrorHandler;
  LoadRegistry();
end;

function TUploaderTest.NormalizeName(AName: String): String;
begin
  Result := AName;
  if (Trim(Result) = '') then
  begin
    Result := cUnknown;
  end;
end;

procedure TUploaderTest.ListViewDblClick(Sender: TObject);
begin
  FIsLoading := True;
  try
    PageControl.ActivePage := tabDetails;
  finally
    FIsLoading := False;
  end;
  PageControlChange(nil);
end;

procedure TUploaderTest.FormDestroy(Sender: TObject);
begin
  SaveRegistry();
end;

procedure TUploaderTest.edtTimeOutChange(Sender: TObject);
begin
  if FIsLoading then Exit;
  clMultiUploader.TimeOut := updTimeOut.Position * 1000;
end;

procedure TUploaderTest.cmbPriorityChange(Sender: TObject);
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

procedure TUploaderTest.LoadRegistry;
begin
  clMultiUploader.ReadRegistry(cRegistryPath);
end;

procedure TUploaderTest.SaveRegistry;
begin
  clMultiUploader.WriteRegistry(cRegistryPath);
end;

procedure TUploaderTest.clMultiUploaderIsBusyChanged(Sender: TObject);
begin
  UpdateControls();
end;

procedure TUploaderTest.clMultiUploaderDataItemProceed(Sender: TObject;
  Item: TclInternetItem; ResourceInfo: TclResourceInfo;
  AStateItem: TclResourceStateItem; CurrentData: PAnsiChar;
  CurrentDataSize: Integer);
var
  ListItem: TListItem;
  s: String;
  old: Boolean;
begin
  old := FIsLoading;
  FIsLoading := True;
  try
    ListItem := ListView.FindData(- 1, Item, False, False);
    if (ListItem <> nil) then
    begin
      s := IntToStr(AStateItem.ResourceState.BytesProceed);
      if (ResourceInfo <> nil) then
      begin
        s := s + ' of ' + IntToStr(ResourceInfo.Size);
      end;
      ListItem.SubItems[0] := s;
    end;
  finally
    FIsLoading := old;
  end;
end;

procedure TUploaderTest.clMultiUploaderGetResourceInfo(Sender: TObject;
  Item: TclInternetItem; ResourceInfo: TclResourceInfo);
begin
  FillDetails(Item);
end;

procedure TUploaderTest.MultiUploaderErrorHandler(Sender: TObject; Item: TclInternetItem;
  const Error: String; ErrorCode: Integer);
begin
  FillDetails(Item);
end;

procedure TUploaderTest.clMultiUploaderStatusChanged(Sender: TObject;
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
      ListItem.SubItems[1] := cUploadStatuses[Status];
    end;
  finally
    FIsLoading := old;
  end;
end;

procedure TUploaderTest.clMultiUploaderChanged(Sender: TObject;
  Item: TclInternetItem);
begin
  FillDetails(Item);
  if FIsLoading then Exit;
  FIsLoading := True;
  try
    updTimeOut.Position := clMultiUploader.TimeOut div 1000;
  finally
    FIsLoading := False;
  end;
end;

end.
