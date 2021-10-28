//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include <typeinfo.h>
#include <registry.hpp>
#include <math.h>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clDC"
#pragma link "clMultiDC"
#pragma link "clMultiDownLoader"
#pragma link "clDownLoader"
#pragma link "clNewsChecker"
#pragma link "clSingleDC"
#pragma link "clProgressBar"
#pragma link "clProgressBarDC"
#pragma resource "*.dfm"
TDownLoaderTest *DownLoaderTest;

const char* cDownLoadingStopConfirm = "Downloading is in progress. Do you wish to stop the process?";
const char* cNoResourceInfoAvailable = "There are no any info available.";
const char *cDownLoadStatuses[6] = {"Ready", "Done", "Failed", "Warnings", "Process", "Stopped"};
const char* cUnknown = "Undefined";
const char* cRegistryPath = "\\Software\\Clever Components\\Clever Internet Suite\\MultiDownLoader";
const char* cSiteNewsKey = "News";

//---------------------------------------------------------------------------
__fastcall TDownLoaderTest::TDownLoaderTest(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::FormCloseQuery(TObject *Sender,
      bool &CanClose)
{
  CanClose = !clMultiDownLoader->IsBusy;
  if (!CanClose)
  {
    CanClose = (MessageBox(0, cDownLoadingStopConfirm, "Warning", MB_OKCANCEL) == IDOK);
    if (CanClose)
    {
      clMultiDownLoader->Stop(NULL);
      while (clMultiDownLoader->IsBusy)
      {
        Application->ProcessMessages();
      }
    }
  }
  if (CanClose)
  {
    clNewsChecker->Stop();
    while (clNewsChecker->IsBusy)
    {
      Application->ProcessMessages();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::FormCreate(TObject *Sender)
{
  LoadRegistry();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::FormDestroy(TObject *Sender)
{
  SaveRegistry();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::FormShow(TObject *Sender)
{
  FIsLoading = true;
  __try
  {
    PageControl->ActivePage = tabTasks;
    FillListView();
  }
  __finally
  {
    FIsLoading = false;
  };
  UpdateControls();
  if (chkDownLoadNews->Checked)
  {
    clNewsChecker->Start(true);
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnGetInfoClick(TObject *Sender)
{
  clMultiDownLoader->GetResourceInfo(GetSelectedItem(), true);
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnStopClick(TObject *Sender)
{
  clMultiDownLoader->Stop(GetSelectedItem());
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnDownLoadClick(TObject *Sender)
{
  clMultiDownLoader->Start(GetSelectedItem(), true);
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::PageControlChange(TObject *Sender)
{
  FillDetails(GetSelectedItem());
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtDirectoryChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->LocalFolder = edtDirectory->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtTimeOutChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->TimeOut = updTimeOut->Position * 1000;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtPreviewCharCountChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->PreviewCharCount = updPreviewCount->Position;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::chkDownLoadNewsClick(TObject *Sender)
{
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnViewSiteNewsClick(TObject *Sender)
{
  clNewsChecker->Start(false);
  if (!clNewsChecker->IsNewsExist)
  {
    DoShowNews(clNewsChecker->LocalFile);
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtURLChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->URL = edtURL->Text;
    ListView->Selected->Caption = NormalizeName(Item->URL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtFileChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->LocalFile = edtFile->Text;
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtUserChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->UserName = edtUser->Text;
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtPasswordChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->Password = edtPassword->Text;
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnAddClick(TObject *Sender)
{
  TListItem *ListItem = ListView->Items->Add();
  ListItem->Caption = NormalizeName("");
  ListItem->Data = clMultiDownLoader->DownLoadList->Add();
  ListItem->SubItems->Add("");
  ListItem->SubItems->Add("");
  ListItem->SubItems->Add("");
  ListItem->SubItems->Add("");
  ListItem->SubItems->Add("");
  ListItem->SubItems->Add(cDownLoadStatuses[psUnknown]);
  ListView->Selected = ListItem;
  ListViewDblClick(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnDeleteClick(TObject *Sender)
{
  delete GetSelectedItem();
  delete ListView->Selected;
  UpdateControls();
}
//---------------------------------------------------------------------------


void __fastcall TDownLoaderTest::ListViewChange(TObject *Sender,
      TListItem *Item, TItemChange Change)
{
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::ListViewDblClick(TObject *Sender)
{
  FIsLoading = true;
  __try
  {
    PageControl->ActivePage = tabDetails;
  }
  __finally
  {
    FIsLoading = false;
  };
  PageControlChange(NULL);
}
//---------------------------------------------------------------------------

UnicodeString TDownLoaderTest::NormalizeName(const UnicodeString &AName)
{
  UnicodeString Result = AName;
  if (Result.Trim().Length() == 0)
  {
    Result = cUnknown;
  }
  return(Result);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::cmbPriorityChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if ((Item) && (cmbPriority->ItemIndex > - 1))
  {
    Item->Priority = static_cast<TclProcessPriority>(cmbPriority->ItemIndex);
  }
}
//---------------------------------------------------------------------------

void TDownLoaderTest::UpdateControls()
{
  TclInternetItem *Item = GetSelectedItem();
  if (PageControl->ActivePage == tabTasks)
  {
    bool b = (Item != NULL);
    btnDelete->Enabled = b && (!Item->IsBusy);
    btnDownLoad->Enabled = b && (!Item->IsBusy);
    btnStop->Enabled = b && Item->IsBusy;
  } else
  if (PageControl->ActivePage == tabDetails)
  {
    bool b = (Item != NULL);
    btnGetInfo->Enabled = b && (!Item->IsBusy);
    btnStop1->Enabled = b && Item->IsBusy;
    btnDownLoad1->Enabled = b && (!Item->IsBusy);
    b = (Item != NULL) && (!Item->IsBusy);
    edtURL->Enabled = b;
    edtFile->Enabled = b;
    edtUser->Enabled = b;
    edtPassword->Enabled = b;
    memInfo->Enabled = b;
    memPreview->Enabled = b;
    memErrors->Enabled = b;
    cmbPriority->Enabled = b;
    updThreadCount->Enabled = b;
    edtThreadCount->Enabled = b;
  } else
  if (PageControl->ActivePage == tabOptions)
  {
    btnViewSiteNews->Enabled = chkDownLoadNews->Checked;
  }
}
//---------------------------------------------------------------------------

void TDownLoaderTest::FillListView()
{
  ListView->Items->BeginUpdate();
  __try
  {
    TclInternetItem *Item;
    TListItem *ListItem;
    ListView->Items->Clear();
    for (int i = 0; i < clMultiDownLoader->DownLoadList->Count; i++)
    {
      Item = clMultiDownLoader->DownLoadList->Items[i];
      ListItem = ListView->Items->Add();
      ListItem->Caption = NormalizeName(Item->URL);
      ListItem->Data = Item;
      ListItem->SubItems->Add("");
      ListItem->SubItems->Add("");
      ListItem->SubItems->Add("");
      ListItem->SubItems->Add("");
      ListItem->SubItems->Add("");
      ListItem->SubItems->Add(cDownLoadStatuses[psUnknown]);
    }
  }
  __finally
  {
    ListView->Items->EndUpdate();
  }
}
//---------------------------------------------------------------------------

void TDownLoaderTest::FillDetails(TclInternetItem *AItem)
{
  if ((PageControl->ActivePage != tabDetails) || FIsLoading) return;
  FIsLoading = true;
  __try
  {
    if (AItem)
    {
      edtURL->Text = AItem->URL;
      edtFile->Text = AItem->LocalFile;
      edtUser->Text = AItem->UserName;
      edtPassword->Text = AItem->Password;
      cmbPriority->ItemIndex = AItem->Priority;
      updThreadCount->Position = AItem->ThreadCount;
      memInfo->Lines->Clear();
      if (AItem->ResourceInfo)
      {
        UnicodeString s;
        s = "Resource ";
        memInfo->Lines->Add(s + AItem->ResourceInfo->Name);
        s = "Size ";
        memInfo->Lines->Add(s + IntToStr(AItem->ResourceInfo->Size));
        s = "Date ";
        memInfo->Lines->Add(s + DateTimeToStr(AItem->ResourceInfo->Date));
        s = "Type ";
        memInfo->Lines->Add(s + AItem->ResourceInfo->ContentType);
        if (AItem->ResourceInfo->Compressed)
        {
          memInfo->Lines->Add("Compressed");
        }

      } else
      {
        memInfo->Lines->Add(cNoResourceInfoAvailable);
      }
      memPreview->Lines->Assign(dynamic_cast<TclDownLoadItem*>(AItem)->Preview);
      memErrors->Lines->Text = AItem->Errors->Text;
    } else
    {
      edtURL->Text = "";
      edtFile->Text = "";
      edtUser->Text = "";
      edtPassword->Text = "";
      cmbPriority->ItemIndex = - 1;
      memInfo->Lines->Clear();
      memPreview->Lines->Clear();
      memErrors->Lines->Clear();
      updThreadCount->Position = 0;
    }
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

TclInternetItem *TDownLoaderTest::GetSelectedItem()
{
  if (ListView->Selected)
  {
    return(static_cast<TclInternetItem*>(ListView->Selected->Data));
  } else
  {
    return(NULL);
  }
}
//---------------------------------------------------------------------------

void TDownLoaderTest::LoadRegistry()
{
  clMultiDownLoader->ReadRegistry(cRegistryPath);
  TRegistry *reg = new TRegistry();
  __try
  {
    if ((reg->OpenKey(cRegistryPath, false)) && reg->ValueExists(cSiteNewsKey))
    {
      chkDownLoadNews->Checked = reg->ReadBool(cSiteNewsKey);
      reg->CloseKey();
    }
  }
  __finally
  {
    delete reg;
  }
}
//---------------------------------------------------------------------------

void TDownLoaderTest::SaveRegistry()
{
  clMultiDownLoader->WriteRegistry(cRegistryPath);
  TRegistry *reg = new TRegistry();
  __try
  {
    if ((reg->OpenKey(cRegistryPath, true)))
    {
      reg->WriteBool(cSiteNewsKey, chkDownLoadNews->Checked);
      reg->CloseKey();
    }
  }
  __finally
  {
    delete reg;
  }
}
//---------------------------------------------------------------------------

void TDownLoaderTest::DoShowNews(const AnsiString &AFileName)
{
  ShellExecute(0, "open", AFileName.c_str(), NULL, NULL, SW_RESTORE);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtThreadCountChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->ThreadCount = updThreadCount->Position;
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::chkPassiveFTPModeClick(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->PassiveFTPMode = chkPassiveFTPMode->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtHttpProxyChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->HttpProxySettings->Server = edtHttpProxy->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtProxyBypassChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->ProxyBypass->Text = Trim(edtProxyBypass->Text);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtBatchSizeChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->BatchSize = updBatchSize->Position;
}
//---------------------------------------------------------------------------



void __fastcall TDownLoaderTest::clNewsCheckerNewsExist(TObject *Sender)
{
  DoShowNews(dynamic_cast<TclNewsChecker*>(Sender)->LocalFile);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clNewsCheckerChanged(TObject *Sender)
{
  edtSiteNewsURL->Text = clNewsChecker->URL;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clMultiDownLoaderChanged(TObject *Sender,
      TclInternetItem *Item)
{
  FillDetails(Item);
  if (FIsLoading) return;
  FIsLoading = true;
  __try
  {
    edtDirectory->Text = clMultiDownLoader->LocalFolder;
    updTimeOut->Position = clMultiDownLoader->TimeOut / 1000;
    updPreviewCount->Position = clMultiDownLoader->PreviewCharCount;
    chkPassiveFTPMode->Checked = clMultiDownLoader->PassiveFTPMode;
    edtHttpProxy->Text = clMultiDownLoader->HttpProxySettings->Server;
    edtProxyBypass->Text = Trim(clMultiDownLoader->ProxyBypass->Text);
    edtProxyUser->Text = clMultiDownLoader->HttpProxySettings->UserName;
    edtProxyPassword->Text = clMultiDownLoader->HttpProxySettings->Password;
    edtHttpPort->Text = IntToStr(clMultiDownLoader->HttpProxySettings->Port);
    edtFtpProxy->Text = clMultiDownLoader->FtpProxySettings->Server;
    edtFtpPort->Text = IntToStr(clMultiDownLoader->FtpProxySettings->Port);
    updBatchSize->Position = clMultiDownLoader->BatchSize;
    updReconnectAfter->Position = clMultiDownLoader->ReconnectAfter / 1000;
    updTryCount->Position = clMultiDownLoader->TryCount;
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

UnicodeString TDownLoaderTest::GetFormattedTime(double ATime)
{
  WORD d, h, m, s;
  m = floor(ATime / 60);
  s = floor(ATime - m * 60);
  h = floor((double)m / 60);
  m = m - h * 60;
  d = floor((double)h / 24);
  h = h - d * 24;
  UnicodeString result = "";
  if (d > 0)
  {
    result += Format("%d d ", ARRAYOFCONST((d)));
  }
  if ((d > 0) || (h > 0))
  {
    result += Format("%d h ", ARRAYOFCONST((h)));
  }
  result += Format("%d m %d s", ARRAYOFCONST((m, s)));
  return result;
}
//---------------------------------------------------------------------------

UnicodeString TDownLoaderTest::GetFormattedBytes(double ABytes)
{
  if (ABytes < 1024)
  {
    return Format("%.2n b", ARRAYOFCONST((ABytes)));
  } else
  {
    ABytes = (ABytes / 1024);
    if (ABytes < 1024)
    {
      return Format("%.2n Kb", ARRAYOFCONST((ABytes)));
    } else
    {
      ABytes = (ABytes / 1024);
      return Format("%.2n Mb", ARRAYOFCONST((ABytes)));
    }
  }
}
//---------------------------------------------------------------------------


void __fastcall TDownLoaderTest::clMultiDownLoaderStatusChanged(
      TObject *Sender, TclInternetItem *Item, TclProcessStatus Status)
{
  bool old = FIsLoading;
  FIsLoading = true;
  __try
  {
    TListItem *ListItem = ListView->FindData(- 1, Item, false, false);
    if (ListItem)
    {
      ListItem->SubItems->Strings[4] = cDownLoadStatuses[Status];
    }
  }
  __finally
  {
    FIsLoading = old;
  }
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clMultiDownLoaderIsBusyChanged(
      TObject *Sender)
{
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clMultiDownLoaderGetResourceInfo(
      TObject *Sender, TclInternetItem *Item,
      TclResourceInfo *ResourceInfo)
{
  FillDetails(Item);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::clMultiDownLoaderError(TObject *Sender, TclInternetItem *Item,
		  const UnicodeString Error, int ErrorCode)
{
  FillDetails(Item);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::ListViewAdvancedCustomDrawSubItem(
      TCustomListView *Sender, TListItem *Item, int SubItem,
      TCustomDrawState State, TCustomDrawStage Stage, bool &DefaultDraw)
{
  TclInternetItem *InternetItem = static_cast<TclInternetItem*>(Item->Data);
  if ((!InternetItem) || (SubItem != 4)) return;
  TRect R;
  TclResourceStateList *ResourceState = InternetItem->ResourceState;
  ListView_GetSubItemRect(Item->Handle, Item->Index, SubItem, LVIR_BOUNDS, &R);

  TControlCanvas *canvas = new TControlCanvas();
  __try
  {
    canvas->Control = Sender;
    clProgressBar->Draw(ResourceState, canvas, R);
  }
  __finally
  {
    delete canvas;
  }
  DefaultDraw = false;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::btnExitClick(TObject *Sender)
{
  Close();
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtReconnectAfterChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->ReconnectAfter = updReconnectAfter->Position * 1000;
}
//---------------------------------------------------------------------------
void __fastcall TDownLoaderTest::edtTryCountChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiDownLoader->TryCount = updTryCount->Position;
}

void __fastcall TDownLoaderTest::clMultiDownLoaderDataTextProceed(
      TObject *Sender, TclDownLoadItem *Item, TStrings *Text)
{
  FillDetails(Item);
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtProxyUserChange(TObject *Sender)
{
  if(FIsLoading) return;
  clMultiDownLoader->HttpProxySettings->UserName = edtProxyUser->Text;
}
//---------------------------------------------------------------------------

void __fastcall TDownLoaderTest::edtProxyPasswordChange(TObject *Sender)
{
  if(FIsLoading) return;
  clMultiDownLoader->HttpProxySettings->Password = edtProxyPassword->Text;
}
//---------------------------------------------------------------------------
void __fastcall TDownLoaderTest::edtHttpPortChange(TObject *Sender)
{
  if(FIsLoading) return;
  clMultiDownLoader->HttpProxySettings->Port = StrToInt(edtHttpPort->Text);
}
//---------------------------------------------------------------------------
void __fastcall TDownLoaderTest::edtFtpProxyChange(TObject *Sender)
{
  if(FIsLoading) return;
  clMultiDownLoader->FtpProxySettings->Server = edtFtpProxy->Text;
}
//---------------------------------------------------------------------------
void __fastcall TDownLoaderTest::edtFtpPortChange(TObject *Sender)
{
  if(FIsLoading) return;
  clMultiDownLoader->FtpProxySettings->Port = StrToInt(edtFtpPort->Text);
}
//---------------------------------------------------------------------------


void __fastcall TDownLoaderTest::clMultiDownLoaderDataItemProceed(
      TObject *Sender, TclInternetItem *Item,
      TclResourceInfo *ResourceInfo, TclResourceStateItem *AStateItem,
      PChar CurrentData, int CurrentDataSize)
{
  bool old = FIsLoading;
  FIsLoading = true;
  __try
  {
    TListItem *ListItem = ListView->FindData(- 1, Item, false, false);
    if (ListItem)
    {
      TclResourceStateList *State = AStateItem->ResourceState;
      ListItem->SubItems->Strings[0] = GetFormattedBytes(State->BytesProceed);
      ListItem->SubItems->Strings[1] = GetFormattedBytes(State->Speed) + "/s";
      ListItem->SubItems->Strings[2] = GetFormattedTime(State->ElapsedTime);
      ListItem->SubItems->Strings[4] = GetFormattedTime(State->RemainingTime);
    }
  }
  __finally
  {
	FIsLoading = old;
  }
}
//---------------------------------------------------------------------------

