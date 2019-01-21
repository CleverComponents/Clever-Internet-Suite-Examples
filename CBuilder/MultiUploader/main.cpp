//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include <typeinfo.h>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clDC"
#pragma link "clMultiDC"
#pragma link "clMultiUploader"
#pragma resource "*.dfm"
TUploaderTest *UploaderTest;

const char* cUploadingStopConfirm = "Uploading is in progress. Do you wish to stop the process?";
const char* cNoResourceInfoAvailable = "There are no any info available.";
const char* cUploadStatuses[6] = {"Ready", "Done", "Failed", "Errors", "Process", "Stopped"};
const char* cUnknown = "Undefined";
const char* cRegistryPath = "\\Software\\Clever Components\\Clever Internet Suite\\MultiUploader";
//---------------------------------------------------------------------------

__fastcall TUploaderTest::TUploaderTest(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::FormCloseQuery(TObject *Sender,
      bool &CanClose)
{
  CanClose = !clMultiUploader->IsBusy;
  if (!CanClose)
  {
    CanClose = (MessageBox(0, cUploadingStopConfirm, "Warning", MB_OKCANCEL) == IDOK);
    if (CanClose)
    {
      clMultiUploader->Stop(NULL);
      while (clMultiUploader->IsBusy)
      {
		Application->ProcessMessages();
	  }
	}
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::FormCreate(TObject *Sender)
{
  LoadRegistry();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::FormDestroy(TObject *Sender)
{
  SaveRegistry();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::FormShow(TObject *Sender)
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
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnGetInfoClick(TObject *Sender)
{
  clMultiUploader->GetResourceInfo(GetSelectedItem(), true);
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnStopClick(TObject *Sender)
{
  clMultiUploader->Stop(GetSelectedItem());
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnUploadClick(TObject *Sender)
{
  clMultiUploader->Start(GetSelectedItem(), true);
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::PageControlChange(TObject *Sender)
{
  FillDetails(GetSelectedItem());
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtTimeOutChange(TObject *Sender)
{
  if (FIsLoading) return;
  clMultiUploader->TimeOut = updTimeOut->Position * 1000;
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtURLChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->URL = edtURL->Text;
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtFileChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->LocalFile = edtFile->Text;
    ListView->Selected->Caption = NormalizeName(Item->LocalFile);
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtUserChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->UserName = edtUser->Text;
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::edtPasswordChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if (Item)
  {
    Item->Password = edtPassword->Text;
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnAddClick(TObject *Sender)
{
  TListItem *ListItem = ListView->Items->Add();
  ListItem->Caption = NormalizeName("");
  ListItem->Data = clMultiUploader->UploadList->Add();
  ListItem->SubItems->Add("");
  ListItem->SubItems->Add(cUploadStatuses[psUnknown]);
  ListView->Selected = ListItem;
  ListViewDblClick(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::btnDeleteClick(TObject *Sender)
{
  delete GetSelectedItem();
  delete ListView->Selected;
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::ListViewChange(TObject *Sender,
      TListItem *Item, TItemChange Change)
{
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::ListViewDblClick(TObject *Sender)
{
  FIsLoading = true;
  __try
  {
    PageControl->ActivePage = tabDetails;
  }
  __finally
  {
    FIsLoading = false;
  }
  PageControlChange(NULL);
}
//---------------------------------------------------------------------------

UnicodeString TUploaderTest::NormalizeName(const UnicodeString &AName)
{
  UnicodeString Result = AName;
  if (Result.Trim().Length() == 0)
  {
    Result = cUnknown;
  }
  return(Result);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::cmbPriorityChange(TObject *Sender)
{
  if (FIsLoading) return;
  TclInternetItem *Item = GetSelectedItem();
  if ((Item) && (cmbPriority->ItemIndex > - 1))
  {
    Item->Priority = static_cast<TclProcessPriority>(cmbPriority->ItemIndex);
  }
}
//---------------------------------------------------------------------------

void TUploaderTest::UpdateControls()
{
  TclInternetItem *Item = GetSelectedItem();
  bool b = (Item != NULL);
  btnGetInfo->Enabled = b && (!Item->IsBusy);
  btnStop->Enabled = b && Item->IsBusy;
  btnUpload->Enabled = b && (!Item->IsBusy);
  if (PageControl->ActivePage == tabTasks)
  {
    btnDelete->Enabled = b && (!Item->IsBusy);
  } else
  if (PageControl->ActivePage == tabDetails)
  {
    edtURL->Enabled = b;
    edtFile->Enabled = b;
    edtUser->Enabled = b;
    edtPassword->Enabled = b;
    memInfo->Enabled = b;
    memErrors->Enabled = b;
    cmbPriority->Enabled = b;
  } else
  if (PageControl->ActivePage == tabOptions)
  {
    btnGetInfo->Enabled = false;
    btnStop->Enabled = false;
    btnUpload->Enabled = false;
  }
}
//---------------------------------------------------------------------------

void TUploaderTest::FillListView()
{
  ListView->Items->BeginUpdate();
  __try
  {
    TclInternetItem *Item;
    TListItem *ListItem;
    ListView->Items->Clear();
    for (int i = 0; i < clMultiUploader->UploadList->Count; i++)
    {
      Item = clMultiUploader->UploadList->Items[i];
      ListItem = ListView->Items->Add();
      ListItem->Caption = NormalizeName(Item->URL);
      ListItem->Data = Item;
      ListItem->SubItems->Add("");
      ListItem->SubItems->Add(cUploadStatuses[psUnknown]);
    }
  }
  __finally
  {
    ListView->Items->EndUpdate();
  }
}
//---------------------------------------------------------------------------

void TUploaderTest::FillDetails(TclInternetItem *AItem)
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
      } else
      {
        memInfo->Lines->Add(cNoResourceInfoAvailable);
      }
      memErrors->Lines->Text = AItem->Errors->Text;
    } else
    {
      edtURL->Text = "";
      edtFile->Text = "";
      edtUser->Text = "";
      edtPassword->Text = "";
      cmbPriority->ItemIndex = - 1;
      memInfo->Lines->Clear();
      memErrors->Lines->Clear();
    }
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

TclInternetItem *TUploaderTest::GetSelectedItem()
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

void TUploaderTest::LoadRegistry()
{
  clMultiUploader->ReadRegistry(cRegistryPath);
}
//---------------------------------------------------------------------------

void TUploaderTest::SaveRegistry()
{
  clMultiUploader->WriteRegistry(cRegistryPath);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clMultiUploaderStatusChanged(
      TObject *Sender, TclInternetItem *Item, TclProcessStatus Status)
{
  bool old = FIsLoading;
  FIsLoading = true;
  __try
  {
    TListItem *ListItem = ListView->FindData(- 1, Item, false, false);
    if (ListItem)
    {
      ListItem->SubItems->Strings[1] = cUploadStatuses[Status];
    }
  }
  __finally
  {
    FIsLoading = old;
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clMultiUploaderIsBusyChanged(
      TObject *Sender)
{
  UpdateControls();
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clMultiUploaderGetResourceInfo(
      TObject *Sender, TclInternetItem *Item,
      TclResourceInfo *ResourceInfo)
{
  FillDetails(Item);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clMultiUploaderError(TObject *Sender, TclInternetItem *Item,
		  const UnicodeString Error, int ErrorCode)
{
  FillDetails(Item);
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clMultiUploaderDataItemProceed(
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
      UnicodeString s = IntToStr(AStateItem->ResourceState->BytesProceed);
      if (ResourceInfo)
      {
        s += " of " + IntToStr(ResourceInfo->Size);
      }
      ListItem->SubItems->Strings[0] = s;
    }
  }
  __finally
  {
    FIsLoading = old;
  }
}
//---------------------------------------------------------------------------

void __fastcall TUploaderTest::clMultiUploaderChanged(TObject *Sender,
      TclInternetItem *Item)
{
  FillDetails(Item);
  if (FIsLoading) return;
  FIsLoading = true;
  __try
  {
    updTimeOut->Position = clMultiUploader->TimeOut / 1000;
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

