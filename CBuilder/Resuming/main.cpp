//---------------------------------------------------------------------------

#include <vcl.h>
#include <inifiles.hpp>

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
#pragma resource "*.dfm"
TForm1 *Form1;

const char* ResourceInfoFile = "settings.ini";

//---------------------------------------------------------------------------
void __fastcall TForm1::btnStartClick(TObject *Sender)
{
  DownLoader->Start(true);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::DownLoaderStatusChanged(TObject *Sender, TclProcessStatus Status)
{
  AnsiString s;//use AnsiString
  switch (Status)
  {
    case psSuccess: MessageBox(0,
      "The downloading is completed, there are no reasons to store the downloading info.", "Message", 0); break;
    case psFailed:
    	s = dynamic_cast<TclDownLoader*>(Sender)->Errors->Text;
    	MessageBox(0, s.c_str(), "Error", 0);
        break;
    case psTerminated: MessageBox(0, "Process stopped", "Message", 0); break;
    case psErrors: MessageBox(0, "Process completed with some warnings", "Message", 0); break;
  };
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RestoreResourceInfo()
{
  DownLoader->ResourceState->Clear();
  if (!FileExists(FResourceInfoFile)) return;
  TIniFile *IniFile = new TIniFile(FResourceInfoFile);
  __try
  {
    DownLoader->URL = IniFile->ReadString("Download", "URL", DownLoader->URL);
    DownLoader->LocalFile = IniFile->ReadString("Download", "LocalFile", DownLoader->LocalFile);
    int cnt = IniFile->ReadInteger("ResourceState", "Count", 0);
    DownLoader->ResourceState->ResourceSize = IniFile->ReadInteger("ResourceState", "ResourceSize", 0);
    TclResourceStateItem *Item;
    for (int i = 0; i < cnt; i++)
    {
      Item = DownLoader->ResourceState->Add();
      Item->ResourcePos = IniFile->ReadInteger("ResourceStateItem" + IntToStr(i),
        "ResourcePos", 0);
      Item->BytesToProceed = IniFile->ReadInteger("ResourceStateItem" + IntToStr(i),
        "BytesToProceed", 0);
      Item->BytesProceed = IniFile->ReadInteger("ResourceStateItem" + IntToStr(i),
        "BytesProceed", 0);
    }
    ShowMessage("The last downloading state has been loaded from the '" + FResourceInfoFile + "' file.");
  }
  __finally
  {
    delete IniFile;
  }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::StoreResourceInfo()
{
  TIniFile *IniFile = new TIniFile(FResourceInfoFile);
  __try
  {
    IniFile->WriteString("Download", "URL", DownLoader->URL);
    IniFile->WriteString("Download", "LocalFile", DownLoader->LocalFile);
    IniFile->WriteInteger("ResourceState", "Count", DownLoader->ResourceState->Count);
    IniFile->WriteInteger("ResourceState", "ResourceSize", DownLoader->ResourceState->ResourceSize);
    for (int i = 0; i < DownLoader->ResourceState->Count; i++)
    {
      IniFile->WriteInteger("ResourceStateItem" + IntToStr(i),
        "ResourcePos", DownLoader->ResourceState->Items[i]->ResourcePos);
      IniFile->WriteInteger("ResourceStateItem" + IntToStr(i),
        "BytesToProceed", DownLoader->ResourceState->Items[i]->BytesToProceed);
      IniFile->WriteInteger("ResourceStateItem" + IntToStr(i),
        "BytesProceed", DownLoader->ResourceState->Items[i]->BytesProceed);
    }
  }
  __finally
  {
    delete IniFile;
  }
  ShowMessage("Your downloading state has been stored to the '" + FResourceInfoFile + "' file.");
}
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnStopClick(TObject *Sender)
{
  DownLoader->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCloseQuery(TObject *Sender, bool &CanClose)
{
  CanClose = !DownLoader->IsBusy;
  if (!CanClose)
  {
    ShowMessage("Downloading is in progress");
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::edtURLChange(TObject *Sender)
{
  if (FLoading) return;
  DownLoader->URL = edtURL->Text;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::edtFileNameChange(TObject *Sender)
{
  if (FLoading) return;
  DownLoader->LocalFile = edtFileName->Text;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::DownLoaderChanged(TObject *Sender)
{
  FLoading = true;
  __try
  {
    edtURL->Text = DownLoader->URL;
    edtFileName->Text = DownLoader->LocalFile;
  }
  __finally
  {
    FLoading = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormShow(TObject *Sender)
{
  FResourceInfoFile = ExtractFilePath(ParamStr(0));
  if (!FResourceInfoFile.IsEmpty() && ('\\' != FResourceInfoFile[FResourceInfoFile.Length()]))
  {
    FResourceInfoFile += "\\";
  }
  FResourceInfoFile += ResourceInfoFile;
  RestoreResourceInfo();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormClose(TObject *Sender, TCloseAction &Action)
{
  if (DownLoader->ResourceState->LastStatus == psSuccess)
  {
    DownLoader->ResourceState->Clear();
    DeleteFile(FResourceInfoFile);
  } else
  if (DownLoader->ResourceState->LastStatus != psUnknown)
  {
    StoreResourceInfo();
  }
}
//---------------------------------------------------------------------------

