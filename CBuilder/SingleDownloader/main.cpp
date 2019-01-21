//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clDC"
#pragma link "clDownLoader"
#pragma link "clMultiDC"
#pragma link "clSingleDC"
#pragma link "clProgressBar"
#pragma link "clProgressBarDC"
#pragma link "clDownLoader"
#pragma link "clMultiDC"
#pragma link "clProgressBar"
#pragma link "clProgressBarDC"
#pragma link "clSingleDC"
#pragma link "DemoBaseFormUnit"
#pragma resource "*.dfm"

TDownLoaderTest *DownLoaderTest;
//---------------------------------------------------------------------------
__fastcall TDownLoaderTest::TDownLoaderTest(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnDownLoadClick(TObject *Sender)
{
  memInfo->Lines->Clear();
  memErrors->Lines->Clear();
  clDownLoader1->Start(true);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::FormCloseQuery(TObject *Sender,
      bool &CanClose)
{
  CanClose = (!clDownLoader1->IsBusy);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnGetInfoClick(TObject *Sender)
{
  memInfo->Lines->Clear();
  memErrors->Lines->Clear();
  clDownLoader1->GetResourceInfo(true);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnStopClick(TObject *Sender)
{
  clDownLoader1->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtFileChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->LocalFile = edtFile->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtUserChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->UserName = edtUser->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtPasswordChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->Password = edtPassword->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtURLChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->URL = edtURL->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtDirectoryChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->LocalFolder = edtDirectory->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtThreadCountChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->ThreadCount = updThreadCount->Position;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtBufferSizeChange(TObject *Sender)
{
  if (FIsLoading) return;
  clDownLoader1->BatchSize = updBufferSize->Position;
}
//---------------------------------------------------------------------------


void __fastcall TDownLoaderTest::clDownLoader1DataItemProceed(
      TObject *Sender, TclResourceInfo *ResourceInfo,
      TclResourceStateItem *AStateItem, PChar CurrentData,
      int CurrentDataSize)
{
  TclResourceStateList *State = AStateItem->ResourceState;
  edtStatistic->Text = Format("%.2n of %.2n Kb proceed, speed %.2n Kb/sec, elapsed %.2n min, remains %.2n min",
    ARRAYOFCONST(((double)State->BytesProceed / 1024, (double)State->ResourceSize / 1024, (double)State->Speed / 1024,
    (double)State->ElapsedTime / 60, (double)State->RemainingTime / 60)));
}
//---------------------------------------------------------------------------


void __fastcall TDownLoaderTest::clDownLoader1StatusChanged(
      TObject *Sender, TclProcessStatus Status)
{
  AnsiString s;//use AnsiString
  switch (Status)
  {
    case psSuccess: MessageBox(0, "Process completed successfully", "Message", 0); break;
    case psFailed:
      s = dynamic_cast<TclDownLoader*>(Sender)->Errors->Text;
      MessageBox(0, s.c_str(), "Error", 0);
      break;
    case psTerminated: MessageBox(0, "Process stopped", "Message", 0); break;
    case psErrors: MessageBox(0, "Process completed with some warnings", "Message", 0); break;
  };
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clDownLoader1Changed(TObject *Sender)
{
  if (FIsLoading) return;
  FIsLoading = true;
  __try
  {
    edtURL->Text = clDownLoader1->URL;
    edtUser->Text = clDownLoader1->UserName;
    edtPassword->Text = clDownLoader1->Password;
    edtFile->Text = clDownLoader1->LocalFile;
    edtDirectory->Text = clDownLoader1->LocalFolder;
    updThreadCount->Position = clDownLoader1->ThreadCount;
    updBufferSize->Position = clDownLoader1->BatchSize;
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clDownLoader1GetResourceInfo(
      TObject *Sender, TclResourceInfo *ResourceInfo)
{
  UnicodeString s;
  if (ResourceInfo)
  {
    s = "Resource " + ResourceInfo->Name;
    s += "; Size " + IntToStr(ResourceInfo->Size);
    s += "; Date " + DateTimeToStr(ResourceInfo->Date);
    s += "; Type " + ResourceInfo->ContentType;
    if (ResourceInfo->Compressed)
    {
      s += "; Compressed";
    }
  } else
  {
    s = "There are no any info available.";
  }
  memInfo->Lines->Add(s);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clDownLoader1DataTextProceed(
      TObject *Sender, TStrings *Text)
{
  memPreview->Lines->Assign(Text);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clDownLoader1Error(TObject *Sender,
      const UnicodeString Error, int ErrorCode)
{
  memErrors->Lines->Text = dynamic_cast<TclDownLoader*>(Sender)->Errors->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clDownLoader1UrlParsing(TObject *Sender, TclUrlParser *AURLComponents)

{
	memInfo->Lines->Add("Scheme: " + AURLComponents->Scheme);
	memInfo->Lines->Add("Host: " + AURLComponents->Host);
	memInfo->Lines->Add("User: " + AURLComponents->UserName);
	memInfo->Lines->Add("Path: " + AURLComponents->Path);
	memInfo->Lines->Add("QueryString: " + AURLComponents->QueryString);
}
//---------------------------------------------------------------------------

