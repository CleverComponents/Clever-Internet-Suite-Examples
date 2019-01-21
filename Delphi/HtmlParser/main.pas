unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, clHtmlParser, DemoBaseFormUnit, ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    btnOpen: TButton;
    OpenDialog: TOpenDialog;
    clHtmlParser: TclHtmlParser;
    PageControl: TPageControl;
    tabLinks: TTabSheet;
    tabImages: TTabSheet;
    tabForms: TTabSheet;
    tabText: TTabSheet;
    lbLinks: TListBox;
    edtUrlHref: TEdit;
    edtUrlTarget: TEdit;
    edtUrlName: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    lbImages: TListBox;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    edtImageSrc: TEdit;
    edtImageWidth: TEdit;
    edtImageAlt: TEdit;
    edtImageHeight: TEdit;
    Label10: TLabel;
    lbForms: TListBox;
    Label11: TLabel;
    edtFormAction: TEdit;
    Label12: TLabel;
    edtFormEncType: TEdit;
    Label13: TLabel;
    edtFormName: TEdit;
    Label14: TLabel;
    edtFormMethod: TEdit;
    lbFormControls: TListBox;
    Label15: TLabel;
    lbText: TRichEdit;
    procedure btnOpenClick(Sender: TObject);
    procedure lbLinksClick(Sender: TObject);
    procedure lbImagesClick(Sender: TObject);
    procedure lbFormsClick(Sender: TObject);
    procedure clHtmlParserParseTag(Sender: TObject; ATag: TclHtmlTag);
  private
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnOpenClick(Sender: TObject);
var
  list: TStrings;
begin
  if OpenDialog.Execute() then
  begin
    Screen.Cursor := crHourGlass;
    list := TStringList.Create();
    try
      list.LoadFromFile(OpenDialog.FileName);
      lbText.Lines.Clear();
      clHtmlParser.Parse(list);
      clHtmlParser.Links.AssignList(lbLinks.Items);
      clHtmlParser.Images.AssignList(lbImages.Items);
      clHtmlParser.Forms.AssignList(lbForms.Items);
    finally
      list.Free();
      Screen.Cursor := crDefault;
    end;
  end;
end;

procedure TMainForm.lbLinksClick(Sender: TObject);
begin
  edtUrlHref.Text := clHtmlParser.Links[lbLinks.ItemIndex].Href;
  edtUrlTarget.Text := clHtmlParser.Links[lbLinks.ItemIndex].Target;
  edtUrlName.Text := clHtmlParser.Links[lbLinks.ItemIndex].Name;
end;

procedure TMainForm.lbImagesClick(Sender: TObject);
begin
  edtImageSrc.Text := clHtmlParser.Images[lbImages.ItemIndex].Src;
  edtImageAlt.Text := clHtmlParser.Images[lbImages.ItemIndex].Alt;
  edtImageWidth.Text := IntToStr(clHtmlParser.Images[lbImages.ItemIndex].Width);
  edtImageHeight.Text := IntToStr(clHtmlParser.Images[lbImages.ItemIndex].Height);
end;

procedure TMainForm.lbFormsClick(Sender: TObject);
begin
  edtFormAction.Text := clHtmlParser.Forms[lbForms.ItemIndex].Action;
  edtFormEncType.Text := clHtmlParser.Forms[lbForms.ItemIndex].EncType;
  edtFormName.Text := clHtmlParser.Forms[lbForms.ItemIndex].FormName;
  edtFormMethod.Text := clHtmlParser.Forms[lbForms.ItemIndex].Method;
  clHtmlParser.Forms[lbForms.ItemIndex].Controls.AssignList(lbFormControls.Items);
end;

procedure TMainForm.clHtmlParserParseTag(Sender: TObject;
  ATag: TclHtmlTag);
begin
  if (ATag.IsText and (Trim(ATag.Text) <> '')) then
    lbText.Lines.Add(ATag.Text);
end;

end.
