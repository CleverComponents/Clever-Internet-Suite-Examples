//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "ViewProps.h"
#include "ModifyProps.h"
#include "CopyMove.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clHttp"
#pragma link "clTcpClient"
#pragma link "clWebDav"
#pragma link "clTcpClientTls"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnOpenClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;

  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;
  clWebDav1->ListDir(edtHost->Text);
  FCurrentDir = edtHost->Text;

  lvResources->Items->Clear();

  TListItem *item;
  for(int i = 0; i < clWebDav1->ResourceProperties->Count; i++) {
    item = lvResources->Items->Add();
    item->Caption = clWebDav1->ResourceProperties->Items[i]->Uri;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnGetAllPropsClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;

  if (cbDepth->ItemIndex == 0)
    clWebDav1->Depth = wdResourceOnly;
  else
    clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }
  clWebDav1->GetAllProperties(url);

  clWebDav1->GetActiveLocks(url);

  TViewPropsForm *dlg = new TViewPropsForm(NULL);
  __try {
    dlg->Memo1->Clear();
    dlg->Memo1->Lines->Add(url);
    dlg->Memo1->Lines->Add("");
    dlg->Memo1->Lines->Add("Properties:");

    for(int i = 0; i < clWebDav1->ResourceProperties->Count; i++) {
      dlg->Memo1->Lines->Add(clWebDav1->ResourceProperties->Items[i]->Name + " = " + clWebDav1->ResourceProperties->Items[i]->Value);
    }

    dlg->Memo1->Lines->Add("");
    dlg->Memo1->Lines->Add("Active Locks:");

    for(int i = 0; i < clWebDav1->ActiveLocks->Count; i++) {
      dlg->Memo1->Lines->Add("Owner: " + clWebDav1->ActiveLocks->Items[i]->Owner);
      dlg->Memo1->Lines->Add("Lock Token: " + clWebDav1->ActiveLocks->Items[i]->LockToken);
      dlg->Memo1->Lines->Add("Lock Type: " + clWebDav1->ActiveLocks->Items[i]->LockType);
      dlg->Memo1->Lines->Add("Lock Timeout: " + clWebDav1->ActiveLocks->Items[i]->TimeOut);
    }

    dlg->ShowModal();
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnModifyPropClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }

  TModifyPropForm *dlg = new TModifyPropForm(NULL);
  __try {
    dlg->lblResource->Caption = url;
    switch (dlg->ShowModal()) {
      case mrYes:
        clWebDav1->SetProperties(url, OPENARRAY(UnicodeString, (dlg->edtName->Text)), OPENARRAY(UnicodeString, (dlg->edtValue->Text)));
        ShowMessage("Property '" + dlg->edtName->Text + "' added / modified.");
        break;
      case mrNo:
        clWebDav1->RemoveProperties(url, OPENARRAY(UnicodeString, (dlg->edtName->Text)));
        ShowMessage("Property '" + dlg->edtName->Text + "' removed.");
        break;
    }
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnMakeDirClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  UnicodeString newDir;
  if (lvResources->Selected != NULL) {
    newDir = lvResources->Selected->Caption;
  }
  else {
    newDir = edtHost->Text;
  }

  if (InputQuery("Make new directory", "Enter a name for new directory", newDir)) {
    clWebDav1->MakeDir(newDir);
    btnOpenClick(NULL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDeleteClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  if (lvResources->Selected == NULL) {
    throw new Exception("Please select a resource");
  }

  if (MessageDlg("Do you want to delete " + lvResources->Selected->Caption + " ?",
    mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes) {
    clWebDav1->Delete(lvResources->Selected->Caption);
    btnOpenClick(NULL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnLockClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;

  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  clWebDav1->LockOwner = "WebDAV tester";
  clWebDav1->LockScope = wsExclusive;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }
  UnicodeString lockToken = clWebDav1->Lock(url);
  FResources->Add(url);
  FLocks->Add(lockToken);

  ShowMessage("The " + url + " resource has been locked successfully.\r\n\r\nLock Token = " + lockToken);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnUnlockClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  clWebDav1->LockOwner = "WebDAV tester";
  clWebDav1->LockScope = wsExclusive;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }

  for (int i = 0; i < FResources->Count; i++) {
    if (SameText(FResources->Strings[i], url)) {
      clWebDav1->Unlock(url, FLocks->Strings[i]);
    }
  }

  ShowMessage("The " + url + " resource has been unlocked.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCopyMoveClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }

  TCopyMoveForm *dlg = new TCopyMoveForm(NULL);
  __try {
    dlg->edtSource->Text = url;
    if (dlg->ShowModal() == mrOk) {
      if (dlg->cbIsMove->Checked) {
        clWebDav1->Move(dlg->edtSource->Text, dlg->edtDestination->Text, true);
      }
      else {
        clWebDav1->Copy(dlg->edtSource->Text, dlg->edtDestination->Text, true);
      }

      btnOpenClick(NULL);
    }
  }
  __finally {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDownloadClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }

  if (SaveDialog1->Execute()) {
    TFileStream *dst = new TFileStream(SaveDialog1->FileName, fmCreate);
    __try {
      clWebDav1->Get(url, dst);
    }
    __finally {
      delete dst;
    }
    ShowMessage("The resource has been downloaded and stored in to " + SaveDialog1->FileName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnUploadClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;
  clWebDav1->Depth = (TclWebDavDepth)cbDepth->ItemIndex;

  UnicodeString url;
  if (lvResources->Selected != NULL) {
    url = lvResources->Selected->Caption;
  }
  else {
    url = edtHost->Text;
  }

  if (OpenDialog1->Execute()) {
    TFileStream *src = new TFileStream(OpenDialog1->FileName, fmOpenRead);
    __try {
      clWebDav1->Put(url + "/" + ExtractFileName(OpenDialog1->FileName), src);
    }
    __finally {
      delete src;
    }
    btnOpenClick(NULL);
    ShowMessage("The file has been uploaded in to " + url);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
  FResources = new TStringList();
  FLocks = new TStringList();
  cbDepth->ItemIndex = 0;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCapabilitiesClick(TObject *Sender)
{
  clWebDav1->UserName = edtUser->Text;
  clWebDav1->Password = edtPassword->Text;

  UnicodeString url;
  if (lvResources->Selected != NULL)
    url = lvResources->Selected->Caption;
  else
    url = edtHost->Text;

  clWebDav1->GetCapabilities(url);

  TViewPropsForm *dlg = new TViewPropsForm(NULL);
  __try
  {
    dlg->Caption = "WebDAV Capabilities";
    dlg->Memo1->Lines->Add("WebDav Class: " + clWebDav1->Capabilities->WebDavClass);

    dlg->Memo1->Lines->Add("");
    dlg->Memo1->Lines->Add("Allowed Methods:");
    dlg->Memo1->Lines->AddStrings(clWebDav1->Capabilities->AllowedMethods);

    dlg->Memo1->Lines->Add("");
    dlg->Memo1->Lines->Add("Public Methods:");
    dlg->Memo1->Lines->AddStrings(clWebDav1->Capabilities->PublicMethods);

    dlg->ShowModal();
  }
  __finally
  {
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnGoUpClick(TObject *Sender)
{
  UnicodeString s = edtHost->Text;
  if (s == "") return;

  if ('/' == s[s.Length()])
    s = s.SubString(1, s.Length() - 1);

  int ind = LastDelimiter("/", s);
  s = s.SubString(1, ind);
  edtHost->Text = s;
  FCurrentDir = edtHost->Text;
  btnOpenClick(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::lvResourcesDblClick(TObject *Sender)
{
  if (lvResources->Selected != NULL)
    edtHost->Text = lvResources->Selected->Caption;
  btnOpenClick(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormDestroy(TObject *Sender)
{
  delete FLocks;
  delete FResources;
  //
}
//---------------------------------------------------------------------------

