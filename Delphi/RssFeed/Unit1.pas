unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clRss, EditItemFrm, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtTitle: TEdit;
    Label2: TLabel;
    edtLink: TEdit;
    Label3: TLabel;
    edtDescription: TEdit;
    Label4: TLabel;
    edtCopyright: TEdit;
    Label5: TLabel;
    edtLanguage: TEdit;
    Label6: TLabel;
    edtWebMaster: TEdit;
    Label7: TLabel;
    edtGenerator: TEdit;
    Label9: TLabel;
    edtImageUrl: TEdit;
    lbNews: TListBox;
    btnAdd: TButton;
    btnDelete: TButton;
    btnClear: TButton;
    btnLoad: TButton;
    btnSave: TButton;
    clRss1: TclRss;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    procedure btnAddClick(Sender: TObject);
    procedure btnClearClick(Sender: TObject);
    procedure btnLoadClick(Sender: TObject);
    procedure btnSaveClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure lbNewsDblClick(Sender: TObject);
  private
    procedure LoadControls;
    procedure SaveControls;
    procedure SaveItem(ADlg: TEditItemForm; AItem: TclRssItem);
    procedure LoadItem(ADlg: TEditItemForm; AItem: TclRssItem);
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.LoadControls;
var
  i: Integer;
begin
  edtTitle.Text := clRss1.Channel.Title;
  edtLink.Text := clRss1.Channel.Link;
  edtDescription.Text := clRss1.Channel.Description;
  edtCopyright.Text := clRss1.Channel.Copyright;
  edtLanguage.Text := clRss1.Channel.Language;
  edtWebMaster.Text := clRss1.Channel.WebMaster;
  edtGenerator.Text := clRss1.Channel.Generator;

  edtImageUrl.Text := clRss1.Channel.Image.Url;

  lbNews.Items.Clear();
  for i := 0 to clRss1.Items.Count - 1 do
  begin
    lbNews.Items.Add(clRss1.Items[i].Title);
  end;

  if (lbNews.Items.Count > 0) then
  begin
    lbNews.ItemIndex := 0;
  end;
end;

procedure TForm1.SaveControls;
begin
  clRss1.Channel.Title := edtTitle.Text;
  clRss1.Channel.Link := edtLink.Text;
  clRss1.Channel.Description := edtDescription.Text;
  clRss1.Channel.Copyright := edtCopyright.Text;
  clRss1.Channel.Language := edtLanguage.Text;
  clRss1.Channel.WebMaster := edtWebMaster.Text;
  clRss1.Channel.Generator := edtGenerator.Text;

  clRss1.Channel.Image.Url := edtImageUrl.Text;
  clRss1.Channel.Image.Title := edtTitle.Text;
  clRss1.Channel.Image.Link := edtLink.Text;

  clRss1.Channel.PubDate := Now();
  clRss1.Channel.LastBuildDate := Now();
end;

procedure TForm1.LoadItem(ADlg: TEditItemForm; AItem: TclRssItem);
begin
  ADlg.edtTitle.Text := AItem.Title;
  ADlg.edtLink.Text := AItem.Link;
  ADlg.edtDescription.Text := AItem.Description;
  ADlg.edtGuid.Text := AItem.Guid.Value;
  ADlg.dtPubDate.DateTime := AItem.PubDate;
end;

procedure TForm1.SaveItem(ADlg: TEditItemForm; AItem: TclRssItem);
begin
  AItem.Title := ADlg.edtTitle.Text;
  AItem.Link := ADlg.edtLink.Text;
  AItem.Description := ADlg.edtDescription.Text;
  AItem.Guid.Value := ADlg.edtGuid.Text;
  AItem.PubDate := ADlg.dtPubDate.DateTime;
end;

procedure TForm1.btnAddClick(Sender: TObject);
var
  dlg: TEditItemForm;
  item: TclRssItem;
begin
  dlg := TEditItemForm.Create(nil);
  try
    dlg.dtPubDate.DateTime := Now();

    if (dlg.ShowModal() = mrOk) then
    begin
      item := clRss1.Items.Add();
      item.Index := 0;
      SaveItem(dlg, item);
      lbNews.Items.Insert(0, item.Title);
      lbNews.ItemIndex := 0;
    end;
  finally
    dlg.Free();
  end;
end;

procedure TForm1.lbNewsDblClick(Sender: TObject);
var
  dlg: TEditItemForm;
  item: TclRssItem;
begin
  if (lbNews.ItemIndex > -1) then
  begin
    dlg := TEditItemForm.Create(nil);
    try
      item := clRss1.Items[lbNews.ItemIndex];

      LoadItem(dlg, item);

      if (dlg.ShowModal() = mrOk) then
      begin
        SaveItem(dlg, item);
      end;
    finally
      dlg.Free();
    end;
  end;
end;

procedure TForm1.btnDeleteClick(Sender: TObject);
begin
  if (lbNews.ItemIndex > -1) then
  begin
    clRss1.Items.Delete(lbNews.ItemIndex);
    lbNews.Items.Delete(lbNews.ItemIndex);
  end;
end;

procedure TForm1.btnClearClick(Sender: TObject);
begin
  if (MessageDlg('Do you wish to clean news feeds?',
    mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
  begin
    clRss1.Clear();
    LoadControls();
  end;
end;

procedure TForm1.btnLoadClick(Sender: TObject);
var
  stream: TStream;
begin
  if OpenDialog1.Execute() then
  begin
    stream := TFileStream.Create(OpenDialog1.FileName, fmOpenRead);
    try
      clRss1.Load(stream);

      LoadControls();
    finally
      stream.Free();
    end;
  end;
end;

procedure TForm1.btnSaveClick(Sender: TObject);
var
  stream: TStream;
begin
  if SaveDialog1.Execute() then
  begin
    if (not FileExists(SaveDialog1.FileName)) or (MessageDlg('File ' + SaveDialog1.FileName + ' already exists. Do you want to replace?',
      mtConfirmation, [mbYes, mbNo], 0) = mrYes) then
    begin
      stream := TFileStream.Create(SaveDialog1.FileName, fmCreate);
      try
        SaveControls();

        clRss1.Save(stream);

        ShowMessage('Done');
      finally
        stream.Free();
      end;
    end;
  end;
end;

end.
