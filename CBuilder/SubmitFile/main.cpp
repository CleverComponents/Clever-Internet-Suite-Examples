//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMultiDC"
#pragma link "clProgressBar"
#pragma link "clProgressBarDC"
#pragma link "clSingleDC"
#pragma link "clUploader"
#pragma link "clHttpRequest"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::btnBrowseClick(TObject *Sender)
{
  if (OpenDialog1->Execute())
  {
    edtFile->Text = OpenDialog1->FileName;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartClick(TObject *Sender)
{
  if (clUploader->IsBusy) return;
  clUploader->URL = edtHost->Text;
  (dynamic_cast<TclSubmitFileRequestItem*>(clUploader->HttpRequest->Items->Items[0]))->FileName = edtFile->Text;

  clUploader->Start(true);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clUploaderStatusChanged(TObject *Sender,
      TclProcessStatus Status)
{
  AnsiString s; //use AnsiString
  switch (Status)
  {
    case psSuccess: ShowMessage("Process completed successfully."); break;
    case psErrors:
    case psFailed:
      s = dynamic_cast<TclUploader*>(Sender)->Errors->Text;
      MessageBox(0, s.c_str(), "Error", 0);
      break;
    case psTerminated: MessageBox(0, "Process stopped", "Message", 0); break;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCloseQuery(TObject *Sender, bool &CanClose)
{
  CanClose = (!clUploader->IsBusy);
  if (!CanClose)
  {
    ShowMessage("Uploading is in progress");
  }
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::btnStopClick(TObject *Sender)
{
  clUploader->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnViewClick(TObject *Sender)
{
  AnsiString s = edtViewPage->Text;
  ShellExecute(0, "open", s.c_str(), NULL, NULL, SW_RESTORE);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clUploaderProcessCompleted(TObject *Sender)
{
  Memo1->Lines->Assign(clUploader->HttpResponse);
}
//---------------------------------------------------------------------------

