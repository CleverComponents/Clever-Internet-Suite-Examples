//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMultiDC"
#pragma link "clProgressBar"
#pragma link "clSingleDC"
#pragma link "clUploader"
#pragma link "clMultiUploader"
#pragma link "clInternetConnection"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  if (clMultiUploader->IsBusy)
  {
    ShowMessage("Uploading is in progress");
    return;
  }
  memResult->Lines->Clear();
  clInternetConnection->Close();
  if (ProcessStep1())
  {
    ProcessStep2();
  }
}
//---------------------------------------------------------------------------

bool TMainForm::ProcessStep1(void)
{
  TclUploadItem *Item = clMultiUploader->UploadList->Items[0];
  rbStep1->FormFields["FirstName"]->FieldValue = edtFirstName->Text;
  rbStep1->FormFields["LastName"]->FieldValue = edtLastName->Text;
  rbStep1->FormFields["Account"]->FieldValue = edtAccount->Text;
  Item->Start(false);
  return (Item->ResourceState->LastStatus == psSuccess);
}
//---------------------------------------------------------------------------

void TMainForm::ProcessStep2(void)
{
  TclUploadItem *Item = clMultiUploader->UploadList->Items[1];
  rbStep2->FormFields["Description"]->FieldValue = edtDescription->Text;
  dynamic_cast<TclSubmitFileRequestItem*>(Item->HttpRequest->Items->Items[1])->FileName = edtFileName->Text;
  Item->Start(true);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCloseQuery(TObject *Sender, bool &CanClose)
{
  CanClose = (!clMultiUploader->IsBusy);
  if (!CanClose)
  {
    ShowMessage("Uploading is in progress");
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnViewClick(TObject *Sender)
{
  AnsiString s = edtViewPage->Text; //use AnsiString
  ShellExecute(0, "open", s.c_str(), NULL, NULL, SW_RESTORE);
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::btnStopClick(TObject *Sender)
{
  clMultiUploader->Stop(NULL);
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::clMultiUploaderProcessCompleted(TObject *Sender,
      TclInternetItem *Item)
{
  AnsiString s; //use AnsiString
  switch (Item->ResourceState->LastStatus)
  {
    case psSuccess:
      memResult->Lines->Add(Format("---------- Step %d ------------", ARRAYOFCONST((Item->Index + 1))));
      memResult->Lines->AddStrings(dynamic_cast<TclUploadItem*>(Item)->HttpResponse);
      if (Item->Index > 0)
      {
        ShowMessage("Process completed successfully.");
      }
      break;
    case psErrors:
    case psFailed:
      s = Item->Errors->Text;
      MessageBox(0, s.c_str(), "Error", 0);
      break;
    case psTerminated: MessageBox(0, "Process stopped", "Message", 0); break;
  }
}
//---------------------------------------------------------------------------

