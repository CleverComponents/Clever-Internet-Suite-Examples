//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMultiDC"
#pragma link "clMultiDownLoader"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::clMultiDownLoaderIsBusyChanged(TObject *Sender)
{
  if(clMultiDownLoader->IsBusy)
    StatusBar1->Panels->Items[0]->Text = "Grabbing...";
  else
    StatusBar1->Panels->Items[0]->Text = "Ready";
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnGrabClick(TObject *Sender)
{
  if(clMultiDownLoader->IsBusy)
    return;
  memLog->Lines->Clear();

  clMultiDownLoader->GrabOptions = TclGrabOptions();
  if(cbGrabAll->Checked)
    clMultiDownLoader->GrabOptions << gaGrabAll;
  if(cbGrabImages->Checked)
    clMultiDownLoader->GrabOptions << gaGrabImages;
  if(cbGrabData->Checked)
    clMultiDownLoader->GrabOptions << gaGrabData;

  clMultiDownLoader->LocalFolder = edtTargetDir->Text;
  clMultiDownLoader->GrabWebsite(edtRootUrl->Text, updMaxNestLevel->Position);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClick(TObject *Sender)
{
  clMultiDownLoader->Stop(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clMultiDownLoaderProcessCompleted(TObject *Sender,
      TclInternetItem *Item)
{
  memLog->Lines->Add(Item->URL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCloseQuery(TObject *Sender, bool &CanClose)
{
  CanClose = !clMultiDownLoader->IsBusy;
  if(!CanClose)
    ShowMessage("Can not close the application. Please press the Stop button to cancel the grabbing process.");
}
//---------------------------------------------------------------------------


