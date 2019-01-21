//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "clHtmlParser"
#pragma link "DemoBaseFormUnit"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnOpenClick(TObject *Sender)
{
  if(OpenDialog->Execute())
  {
    Screen->Cursor = crHourGlass;
    TStrings *list = new TStringList();
    __try
    {
      list->LoadFromFile(OpenDialog->FileName);
      lbText->Lines->Clear();
      clHtmlParser->Parse(list);
      clHtmlParser->Links->AssignList(lbLinks->Items);
      clHtmlParser->Images->AssignList(lbImages->Items);
      clHtmlParser->Forms->AssignList(lbForms->Items);
    }
    __finally
    {
      delete list;
      Screen->Cursor = crDefault;
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::lbLinksClick(TObject *Sender)
{
  edtUrlHref->Text = clHtmlParser->Links->Items[lbLinks->ItemIndex]->Href;
  edtUrlTarget->Text = clHtmlParser->Links->Items[lbLinks->ItemIndex]->Target;
  edtUrlName->Text = clHtmlParser->Links->Items[lbLinks->ItemIndex]->Name;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::lbImagesClick(TObject *Sender)
{
  edtImageSrc->Text = clHtmlParser->Images->Items[lbImages->ItemIndex]->Src;
  edtImageAlt->Text = clHtmlParser->Images->Items[lbImages->ItemIndex]->Alt;
  edtImageWidth->Text = IntToStr(clHtmlParser->Images->Items[lbImages->ItemIndex]->Width);
  edtImageHeight->Text = IntToStr(clHtmlParser->Images->Items[lbImages->ItemIndex]->Height);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::lbFormsClick(TObject *Sender)
{
  edtFormAction->Text = clHtmlParser->Forms->Items[lbForms->ItemIndex]->Action;
  edtFormEncType->Text = clHtmlParser->Forms->Items[lbForms->ItemIndex]->EncType;
  edtFormName->Text = clHtmlParser->Forms->Items[lbForms->ItemIndex]->FormName;
  edtFormMethod->Text = clHtmlParser->Forms->Items[lbForms->ItemIndex]->Method;
  clHtmlParser->Forms->Items[lbForms->ItemIndex]->Controls->AssignList(lbFormControls->Items);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clHtmlParserParseTag(TObject *Sender, TclHtmlTag *ATag)
{
  if(ATag->IsText && (Trim(ATag->Text) != ""))
    lbText->Lines->Add(ATag->Text);
}
//---------------------------------------------------------------------------
