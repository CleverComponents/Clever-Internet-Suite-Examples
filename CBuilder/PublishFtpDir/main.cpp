//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMultiDC"
#pragma link "clMultiUploader"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::clMultiUploaderIsBusyChanged(TObject *Sender)
{
  if(clMultiUploader->IsBusy)
    StatusBar1->Panels->Items[0]->Text = "Publishing...";
  else
    StatusBar1->Panels->Items[0]->Text = "Ready";
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clMultiUploaderProcessCompleted(TObject *Sender,
      TclInternetItem *Item)
{
  memLog->Lines->Add(Item->URL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClick(TObject *Sender)
{
  clMultiUploader->Stop(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCloseQuery(TObject *Sender, bool &CanClose)
{
  CanClose = !clMultiUploader->IsBusy;
  if(!CanClose)
    ShowMessage("Can not close the application. Please press the Stop button to cancel the publishing process.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPublishClick(TObject *Sender)
{
  if(clMultiUploader->IsBusy) return;
  memLog->Lines->Clear();

  clMultiUploader->PublishFileMask = edtFileMask->Text;
  clMultiUploader->PassiveFTPMode = cbPassiveMode->Checked;

  clMultiUploader->Publish(edtLocalFolder->Text, edtFtpDir->Text, true);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clMultiUploaderPrepareItemToPublish(
      TObject *Sender, TclUploadItem *Item, bool &CanProceed,
      bool &Handled)
{
  Item->UserName = edtUser->Text;
  Item->Password = edtPassword->Text;
  Handled = true;
}
//---------------------------------------------------------------------------

