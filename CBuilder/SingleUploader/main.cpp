//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clDC"
#pragma link "clUploader"
#pragma link "clMultiDC"
#pragma link "clSingleDC"
#pragma link "clProgressBar"
#pragma link "clProgressBarDC"
#pragma resource "*.dfm"
TUploaderTest *UploaderTest;
//---------------------------------------------------------------------------
__fastcall TUploaderTest::TUploaderTest(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TUploaderTest::FormCloseQuery(TObject *Sender,
      bool &CanClose)
{
  CanClose = !clUploader1->IsBusy;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtURLChange(TObject *Sender)
{
  if (FIsLoading) return;
  clUploader1->URL = edtURL->Text;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtUserChange(TObject *Sender)
{
  if (FIsLoading) return;
  clUploader1->UserName = edtUser->Text;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtFileChange(TObject *Sender)
{
  if (FIsLoading) return;
  clUploader1->LocalFile = edtFile->Text;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtPasswordChange(TObject *Sender)
{
  if (FIsLoading) return;
  clUploader1->Password = edtPassword->Text;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnGetInfoClick(TObject *Sender)
{
  memInfo->Lines->Clear();
  memErrors->Lines->Clear();
  clUploader1->GetResourceInfo(true);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnStopClick(TObject *Sender)
{
  clUploader1->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnUploadClick(TObject *Sender)
{
  memInfo->Lines->Clear();
  memErrors->Lines->Clear();
  clUploader1->Start(true);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clUploader1StatusChanged(TObject *Sender,
      TclProcessStatus Status)
{
  AnsiString s; //use AnsiString
  switch (Status)
  {
    case psSuccess: MessageBox(0, "Process completed successfully", "Message", 0); break;
    case psFailed:
      s = dynamic_cast<TclUploader*>(Sender)->Errors->Text;
      MessageBox(0, s.c_str(), "Error", 0);
      break;
    case psTerminated: MessageBox(0, "Process stopped", "Message", 0); break;
    case psErrors: MessageBox(0, "Process completed with some errors", "Message", 0); break;
  };
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clUploader1GetResourceInfo(TObject *Sender,
      TclResourceInfo *ResourceInfo)
{
  UnicodeString s;
  if (ResourceInfo)
  {
    s = "Resource " + ResourceInfo->Name;
    s += "; Size " + IntToStr(ResourceInfo->Size);
    s += "; Date " + DateTimeToStr(ResourceInfo->Date);
    s += "; Type " + ResourceInfo->ContentType;
  } else
  {
    s = "There are no any info available.";
  }
  memInfo->Lines->Add(s);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clUploader1Error(TObject *Sender,
      const UnicodeString Error, int ErrorCode)
{
  memErrors->Lines->Text = dynamic_cast<TclUploader*>(Sender)->Errors->Text;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clUploader1DataItemProceed(TObject *Sender,
      TclResourceInfo *ResourceInfo, TclResourceStateItem *AStateItem,
      PChar CurrentData, int CurrentDataSize)
{
  TclResourceStateList *State = AStateItem->ResourceState;
  Edit1->Text = Format("%n of %n Kb proceed, speed %n Kb/sec, elapsed %n min, remains %n min",
    ARRAYOFCONST(((double)State->BytesProceed / 1024, (double)State->ResourceSize / 1024, (double)State->Speed / 1024,
    (double)State->ElapsedTime / 60, (double)State->RemainingTime / 60)));
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clUploader1Changed(TObject *Sender)
{
  if (FIsLoading) return;
  FIsLoading = true;
  __try
  {
    edtURL->Text = clUploader1->URL;
    edtUser->Text = clUploader1->UserName;
    edtPassword->Text = clUploader1->Password;
    edtFile->Text = clUploader1->LocalFile;
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clUploader1UrlParsing(TObject *Sender, TclUrlParser *AURLComponents)

{
	memInfo->Lines->Add("Scheme: " + AURLComponents->Scheme);
	memInfo->Lines->Add("Host: " + AURLComponents->Host);
	memInfo->Lines->Add("User: " + AURLComponents->UserName);
	memInfo->Lines->Add("Path: " + AURLComponents->Path);
	memInfo->Lines->Add("QueryString: " + AURLComponents->QueryString);
}
//---------------------------------------------------------------------------

