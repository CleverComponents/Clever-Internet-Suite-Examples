//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "clUpdateMgrForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
//---------------------------------------------------------------------------
__fastcall TclUpdateMgrFrm::TclUpdateMgrFrm(TComponent* Owner)
  : TForm(Owner)
{
  FUpdateInfo = new TclUpdateInfoList();
}
//---------------------------------------------------------------------------
__fastcall TclUpdateMgrFrm::~TclUpdateMgrFrm(void)
{
  delete FUpdateInfo;
}
//---------------------------------------------------------------------------
void __fastcall TclUpdateMgrFrm::lbUpdatesClick(TObject *Sender)
{
  if(lbUpdates->ItemIndex < 0) return;
  FUpdating = true;
  __try
  {
    TclUpdateInfoItem *item = GetCurrentItem();
    edtUpdateVersion->Text = item->Version;
    edtURL->Text = item->URL;
    edtSize->Text = item->Size;
    cbNeedTerminate->Checked = item->NeedTerminate;
    memScript->Lines->Assign(item->UpdateScript);
  }
  __finally
  {
    FUpdating = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::btnAddClick(TObject *Sender)
{
  FUpdateInfo->Add();
  FillListbox(FUpdateInfo->Count - 1);
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::btnDeleteClick(TObject *Sender)
{
  int ind = lbUpdates->ItemIndex;
  if(ind < 0) return;
  FUpdateInfo->Delete(ind);
  if(ind > 0)
    ind--;
  FillListbox(ind);
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::edtUpdateVersionChange(TObject *Sender)
{
  if(FUpdating) return;
  GetCurrentItem()->Version = edtUpdateVersion->Text;
  lbUpdates->Items->Strings[lbUpdates->ItemIndex] = GetListboxItemName(GetCurrentItem());
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::edtURLChange(TObject *Sender)
{
  if(FUpdating) return;
  GetCurrentItem()->URL = edtURL->Text;
  lbUpdates->Items->Strings[lbUpdates->ItemIndex] = GetListboxItemName(GetCurrentItem());
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::edtSizeChange(TObject *Sender)
{
  if(FUpdating) return;
  GetCurrentItem()->Size = edtSize->Text;
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::cbNeedTerminateClick(TObject *Sender)
{
  if(FUpdating) return;
  GetCurrentItem()->NeedTerminate = cbNeedTerminate->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::memScriptChange(TObject *Sender)
{
  if(FUpdating) return;
  GetCurrentItem()->UpdateScript->Assign(memScript->Lines);
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::btnUpClick(TObject *Sender)
{
  int ind = lbUpdates->ItemIndex;
  if(ind < 1) return;
  FUpdateInfo->Items[ind]->Index = ind - 1;
  FillListbox(ind - 1);
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::btnDownClick(TObject *Sender)
{
  int ind = lbUpdates->ItemIndex;
  if((ind < 0) || (ind == FUpdateInfo->Count - 1)) return;
  FUpdateInfo->Items[ind]->Index = ind + 1;
  FillListbox(ind + 1);
}
//---------------------------------------------------------------------------

void __fastcall TclUpdateMgrFrm::LoadUpdateInfo(TclUpdateInfoList *AUpdateInfo)
{
  FUpdateInfo->Assign(AUpdateInfo);
  FillListbox(0);
}
//---------------------------------------------------------------------------
void __fastcall TclUpdateMgrFrm::FillListbox(int ASelectedIndex)
{
  lbUpdates->Items->Clear();

  for(int i = 0; i < FUpdateInfo->Count; i++)
    lbUpdates->Items->AddObject(GetListboxItemName(FUpdateInfo->Items[i]), FUpdateInfo->Items[i]);

  if(lbUpdates->Items->Count > ASelectedIndex)
    lbUpdates->ItemIndex = ASelectedIndex;
    
  UpdateControls();
  lbUpdatesClick(NULL);
}
//---------------------------------------------------------------------------
void __fastcall TclUpdateMgrFrm::StoreUpdateInfo(TclUpdateInfoList *AUpdateInfo)
{
  AUpdateInfo->Assign(FUpdateInfo);
}
//---------------------------------------------------------------------------
TclUpdateInfoItem * __fastcall TclUpdateMgrFrm::GetCurrentItem(void)
{
  if(lbUpdates->ItemIndex < 0)
    return NULL;
  return (TclUpdateInfoItem *)lbUpdates->Items->Objects[lbUpdates->ItemIndex];
}
//---------------------------------------------------------------------------
UnicodeString __fastcall TclUpdateMgrFrm::GetListboxItemName(TclUpdateInfoItem *AUpdateInfoItem)
{
  UnicodeString result = "Unspecified";
  int ind = RTextPos("/", AUpdateInfoItem->URL, -1);
  if(ind > 0)
    result = AUpdateInfoItem->URL.SubString(ind, 1000);
  else
  if(AUpdateInfoItem->URL != "")
    result = AUpdateInfoItem->URL;

  if (AUpdateInfoItem->Version != "")
    result = " - " + result;
  return AUpdateInfoItem->Version + result;
}
//---------------------------------------------------------------------------
void __fastcall TclUpdateMgrFrm::UpdateControls(void)
{
  bool disable = (lbUpdates->Items->Count < 1);
  memScript->ReadOnly = disable;
  edtUpdateVersion->ReadOnly = disable;
  edtURL->ReadOnly = disable;
  edtSize->ReadOnly = disable;
  cbNeedTerminate->Enabled = !disable;
}
//---------------------------------------------------------------------------
bool __fastcall TclUpdateMgrFrm::ShowEditor(TclUpdateInfoList *AUpdateInfo)
{
  bool res;
  TclUpdateMgrFrm *dlg = new TclUpdateMgrFrm(NULL);
  __try
  {
    dlg->LoadUpdateInfo(AUpdateInfo);
    res = (dlg->ShowModal() == mrOk);
    if(res)
      dlg->StoreUpdateInfo(AUpdateInfo);
  }
  __finally
  {
    delete dlg;
  }
  return res;
}
//---------------------------------------------------------------------------

