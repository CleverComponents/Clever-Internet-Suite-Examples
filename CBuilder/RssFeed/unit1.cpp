//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clRss"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::lbNewsDblClick(TObject *Sender)
{
  if (lbNews->ItemIndex > -1)
  {
    TEditItemForm *dlg = new TEditItemForm(NULL);
    __try
    {
      TclRssItem *item = clRss1->Items->Items[lbNews->ItemIndex];

      LoadItem(dlg, item);

      if (dlg->ShowModal() == mrOk)
      {
        SaveItem(dlg, item);
      }
    }
    __finally
    {
      delete dlg;
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnAddClick(TObject *Sender)
{
  TEditItemForm *dlg = new TEditItemForm(NULL);
  __try
  {
    dlg->dtPubDate->DateTime = Now();

    if (dlg->ShowModal() == mrOk)
    {
      TclRssItem *item = clRss1->Items->Add();
      item->Index = 0;
      SaveItem(dlg, item);
      lbNews->Items->Insert(0, item->Title);
      lbNews->ItemIndex = 0;
    }
  }
  __finally
  {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDeleteClick(TObject *Sender)
{
  if (lbNews->ItemIndex > -1)
  {
    clRss1->Items->Delete(lbNews->ItemIndex);
    lbNews->Items->Delete(lbNews->ItemIndex);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnClearClick(TObject *Sender)
{
  if (MessageDlg("Do you wish to clean news feeds?",
    mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
  {
    clRss1->Clear();
    LoadControls();
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnLoadClick(TObject *Sender)
{
  if (OpenDialog1->Execute())
  {
    TStream *stream = new TFileStream(OpenDialog1->FileName, fmOpenRead);
    __try
    {
      clRss1->Load(stream);

      LoadControls();
    }
    __finally
    {
      delete stream;
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSaveClick(TObject *Sender)
{
  if (SaveDialog1->Execute())
  {
    if ((!FileExists(SaveDialog1->FileName)) || (MessageDlg("File " + SaveDialog1->FileName + " already exists. Do you want to replace?",
      mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes))
    {
      TStream *stream = new TFileStream(SaveDialog1->FileName, fmCreate);
      __try
      {
        SaveControls();

        clRss1->Save(stream);

        ShowMessage("Done");
      }
      __finally
      {
        delete stream;
      }
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::LoadControls()
{
  edtTitle->Text = clRss1->Channel->Title;
  edtLink->Text = clRss1->Channel->Link;
  edtDescription->Text = clRss1->Channel->Description;
  edtCopyright->Text = clRss1->Channel->Copyright;
  edtLanguage->Text = clRss1->Channel->Language;
  edtWebMaster->Text = clRss1->Channel->WebMaster;
  edtGenerator->Text = clRss1->Channel->Generator;

  edtImageUrl->Text = clRss1->Channel->Image->Url;

  lbNews->Items->Clear();
  for (int i = 0; i < clRss1->Items->Count; i++)
  {
    lbNews->Items->Add(clRss1->Items->Items[i]->Title);
  }

  if (lbNews->Items->Count > 0)
  {
    lbNews->ItemIndex = 0;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SaveControls()
{
  clRss1->Channel->Title = edtTitle->Text;
  clRss1->Channel->Link = edtLink->Text;
  clRss1->Channel->Description = edtDescription->Text;
  clRss1->Channel->Copyright = edtCopyright->Text;
  clRss1->Channel->Language = edtLanguage->Text;
  clRss1->Channel->WebMaster = edtWebMaster->Text;
  clRss1->Channel->Generator = edtGenerator->Text;

  clRss1->Channel->Image->Url = edtImageUrl->Text;
  clRss1->Channel->Image->Title = edtTitle->Text;
  clRss1->Channel->Image->Link = edtLink->Text;

  clRss1->Channel->PubDate = Now();
  clRss1->Channel->LastBuildDate = Now();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SaveItem(TEditItemForm *ADlg, TclRssItem *AItem)
{
  AItem->Title = ADlg->edtTitle->Text;
  AItem->Link = ADlg->edtLink->Text;
  AItem->Description = ADlg->edtDescription->Text;
  AItem->Guid->Value = ADlg->edtGuid->Text;
  AItem->PubDate = ADlg->dtPubDate->DateTime;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::LoadItem(TEditItemForm *ADlg, TclRssItem *AItem)
{
  ADlg->edtTitle->Text = AItem->Title;
  ADlg->edtLink->Text = AItem->Link;
  ADlg->edtDescription->Text = AItem->Description;
  ADlg->edtGuid->Text = AItem->Guid->Value;
  ADlg->dtPubDate->DateTime = AItem->PubDate;
}
//---------------------------------------------------------------------------


