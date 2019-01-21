//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "MessageFrm.h"
#include "NewFolderDlg.h"
#include "SearchDlg.h"
#include "CopyDlg.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clImap4"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma link "clTcpCommandClient"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnLoginClick(TObject *Sender)
{
  if (clImap->Active) {
    ShowMessage("You are already connected. Please click Logout to disconnect.");
    return;
  }

  clImap->Server = edtServer->Text;
  clImap->Port = StrToInt(edtPort->Text);
  clImap->UserName = edtUser->Text;
  clImap->Password = edtPassword->Text;
  clImap->UseSasl = cbUseSPA->Checked;
  clImap->TimeOut = StrToInt(edtTimeOut->Text) * 1000;
  clImap->Open();

  GetFolderList();

  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnLogoutClick(TObject *Sender)
{
  clImap->Close();

  FSubscribeStatus->Clear();
  tvFolders->Items->Clear();
  lvMessages->Items->Clear();

  edtSubscribed->Text = "";
  edtAll->Text = "";
  edtRecent->Text = "";
  edtFirstUnseen->Text = "";

  UpdateStatuses();
}
//---------------------------------------------------------------------------


void __fastcall TForm1::tvFoldersChange(TObject *Sender, TTreeNode *Node)
{
  if (clImap->Active && (tvFolders->Selected != NULL)) {
    clImap->SelectMailBox(GetFolderName(tvFolders->Selected));

    edtSubscribed->Text = GetSubscribeStatus(GetFolderName(tvFolders->Selected)) ? "yes" : "no";
    edtAll->Text = IntToStr(clImap->CurrentMailBox->ExistsMessages);
    edtRecent->Text = IntToStr(clImap->CurrentMailBox->RecentMessages);
    edtFirstUnseen->Text = IntToStr(clImap->CurrentMailBox->FirstUnseen);

    GetMessageList();
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::lvMessagesDblClick(TObject *Sender)
{
  if (clImap->Active && (lvMessages->Selected != NULL)) {
    clImap->RetrieveMessage(StrToInt(lvMessages->Selected->Caption), clMailMessage);
    clImap->SetMessageFlags(StrToInt(lvMessages->Selected->Caption), fmAdd, TclMailMessageFlags() << mfSeen);

    TMessageForm::ShowMessage(clMailMessage);
    tvFoldersChange(NULL, NULL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnNewFolderClick(TObject *Sender)
{
  if (!clImap->Active) return;

  TNewFolderDialog *dlg = new TNewFolderDialog(NULL);
  __try {
    if (dlg->ShowModal() == mrOk) {
      if (dlg->cbIsSubfolder->Checked && (tvFolders->Selected != NULL)) {
        clImap->CreateMailBox(GetFolderName(tvFolders->Selected) + clImap->MailBoxSeparator + dlg->edtName->Text);
      }
      else {
        clImap->CreateMailBox(dlg->edtName->Text);
      }

      GetFolderList();
    }
  }
  __finally {
	delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDeleteFolderClick(TObject *Sender)
{
  if (!clImap->Active) return;

  if (tvFolders->Selected != NULL) {
    if (MessageDlg("Do you wish to delete the " + GetFolderName(tvFolders->Selected) + " folder ?",
      mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes) {
      clImap->DeleteMailBox(GetFolderName(tvFolders->Selected));
      GetFolderList();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnFindClick(TObject *Sender)
{
  if ((!clImap->Active) || (tvFolders->Selected == NULL)) return;

  TSearchDialog *dlg = NULL;
  TStrings *list = NULL;
  __try {
    dlg = new TSearchDialog(NULL);
    if (dlg->ShowModal() == mrOk) {
      list = new TStringList();
      clImap->SearchMessages(dlg->GetSearchCriteria(), list);

      if (list->Count == 0) {
        ShowMessage("No messages found.");
      }
      else {
        ShowMessage(Format("Found %d message(s).\r\n Message numbers: \r\n%s",
          ARRAYOFCONST((list->Count, list->CommaText))));
      }
    }
  }
  __finally {
    delete list;
    delete dlg;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSubscribeClick(TObject *Sender)
{
  if (!clImap->Active) return;

  UnicodeString s = GetFolderName(tvFolders->Selected);
  if ((tvFolders->Selected != NULL) && (!GetSubscribeStatus(s))) {
    clImap->SubscribeMailBox(s);
    SetSubscribeStatus(s, true);
    tvFoldersChange(NULL, NULL);
    ShowMessage(Format("The folder %s has been subscribed.", ARRAYOFCONST((s))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnUnsubscribeClick(TObject *Sender)
{
  if (!clImap->Active) return;

  UnicodeString s = GetFolderName(tvFolders->Selected);
  if ((tvFolders->Selected != NULL) && GetSubscribeStatus(s)) {
    clImap->UnsubscribeMailBox(s);
    SetSubscribeStatus(s, false);
    tvFoldersChange(NULL, NULL);
    ShowMessage(Format("The folder %s has been unsubscribed.", ARRAYOFCONST((s))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnAppendClick(TObject *Sender)
{
  if ((!clImap->Active) || (tvFolders->Selected == NULL)) return;

  if (TMessageForm::ComposeMessage(clMailMessage)) {
    clImap->AppendMessage(GetFolderName(tvFolders->Selected), clMailMessage, TclMailMessageFlags());
    tvFoldersChange(NULL, NULL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCopyClick(TObject *Sender)
{
  if ((!clImap->Active) || (lvMessages->SelCount != 1)) return;

  TStrings *list = new TStringList();
  __try {
    clImap->GetMailBoxes(list);
    UnicodeString dest = TCopyDialog::ShowCopyDialog(list);
    if (dest != "") {
      clImap->CopyMessage(StrToInt(lvMessages->Selected->Caption), dest);
      GetFolderList();
    }
  }
  __finally {
	delete list;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDeleteClick(TObject *Sender)
{
  if (!clImap->Active) return;

  if ((tvFolders->Selected != NULL) && (lvMessages->SelCount == 1)) {
    clImap->DeleteMessage(StrToInt(lvMessages->Selected->Caption));
    tvFoldersChange(NULL, NULL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPurgeClick(TObject *Sender)
{
  if ((!clImap->Active) || (tvFolders->Selected == NULL)) return;

  if (MessageDlg("Purge all marked as deleted messages in selected folder ?",
    mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes) {
    clImap->PurgeMessages();
    tvFoldersChange(NULL, NULL);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clImapReceiveResponse(TObject *Sender,
      TStrings *AList)
{
  if (AList->Count > 0) {
    memLog->Lines->Add(AList->Strings[0]);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clImapSendCommand(TObject *Sender,
      const UnicodeString AText)
{
  memLog->Lines->Add(Trim(AText));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
  FSubscribeStatus = new TStringList();
  UpdateStatuses();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormDestroy(TObject *Sender)
{
  clImap->Close();
  delete FSubscribeStatus;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::GetFolderList(void)
{
  TStrings *mailboxes = NULL;
  TStrings *subscribed = NULL;
  tvFolders->Items->BeginUpdate();
  __try {
    mailboxes = new TStringList();
    subscribed = new TStringList();

    FSubscribeStatus->Clear();
    tvFolders->Items->Clear();
    lvMessages->Items->Clear();

    edtSubscribed->Text = "";
    edtAll->Text = "";
    edtRecent->Text = "";
    edtFirstUnseen->Text = "";

    clImap->GetMailBoxes(mailboxes);

    clImap->GetSubscribedMailBoxes(subscribed);

    for (int i = 0; i < mailboxes->Count; i++) {
      UnicodeString item = mailboxes->Strings[i];
      AddFolderToList(item);
      SetSubscribeStatus(item, subscribed->IndexOf(item) > -1);
	}
  }
  __finally {
    tvFolders->Items->EndUpdate();
    delete subscribed;
    delete mailboxes;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::UpdateStatuses(void)
{
  bool enabled = clImap->Active;
  if (enabled) {
	Caption = "IMAP Client - Connected";
  }
  else {
	Caption = "IMAP Client";
  }
  btnAppend->Enabled = enabled;
  btnCopy->Enabled = enabled;
  btnDelete->Enabled = enabled;
  btnDeleteFolder->Enabled = enabled;
  btnFind->Enabled = enabled;
  btnNewFolder->Enabled = enabled;
  btnPurge->Enabled = enabled;
  btnSubscribe->Enabled = enabled;
  btnUnsubscribe->Enabled = enabled;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::AddFolderToList(UnicodeString AName)
{
  UnicodeString S;

  TTreeNode *Papa = NULL;
  TTreeNode *N = tvFolders->Items->GetFirstNode();
  if (AName[1] == clImap->MailBoxSeparator)
    AName.Delete(1, 1);

  int i;
  while (true) {
    i = AName.Pos(clImap->MailBoxSeparator);
    if (i == 0) {
      Papa = tvFolders->Items->AddChild(Papa, AName);
      Papa->ImageIndex = 0;
      Papa->SelectedIndex = 0;
      break;
    }
    else {
      S = AName.SubString(1, i - 1);
      AName.Delete(1, i);
      while ((N != NULL) && (N->Text != S))
        N = N->getNextSibling();
      if (N == NULL)
        Papa = tvFolders->Items->AddChild(Papa, S);
      else
        Papa = N;
      N = Papa->getFirstChild();
    }
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::GetMessageList(void)
{
  lvMessages->Items->Clear();

  if (!clImap->Active) return;

  for (int i = 1; i <= clImap->CurrentMailBox->ExistsMessages; i++) {
    clImap->RetrieveHeader(i, clMailMessage);

    TListItem *Item = lvMessages->Items->Add();
    Item->Caption = IntToStr(i);

    Item->SubItems->Add(clMailMessage->Subject);
    Item->SubItems->Add(clMailMessage->From->FullAddress);

    TclMailMessageFlags flags = clImap->GetMessageFlags(i);
    UnicodeString s = "";

    if (flags.Contains(mfAnswered))
      s += "Answered,";
    if (flags.Contains(mfFlagged))
      s += "Flagged,";
    if (flags.Contains(mfDeleted))
      s += "Deleted,";
    if (flags.Contains(mfSeen))
      s += "Seen,";
    if (flags.Contains(mfDraft))
      s += "Draft,";
    if (flags.Contains(mfRecent))
      s += "Recent,";

    Item->SubItems->Add(s);
  }
}
//---------------------------------------------------------------------------

UnicodeString __fastcall TForm1::GetFolderName(TTreeNode *Node)
{
  if (Node != NULL) {
    UnicodeString res = Node->Text;
    while (Node->Parent != NULL) {
      Node = Node->Parent;
      res = Node->Text + clImap->MailBoxSeparator + res;
    }
    return res;
  }
  return "";
}
//---------------------------------------------------------------------------

bool __fastcall TForm1::GetSubscribeStatus(UnicodeString AFolder)
{
  int ind = FSubscribeStatus->IndexOf(AFolder);
  if (ind > -1) {
    return (bool)((int)FSubscribeStatus->Objects[ind]);
  }
  return false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SetSubscribeStatus(UnicodeString AFolder, bool AStatus)
{
  int ind = FSubscribeStatus->IndexOf(AFolder);
  if (ind > -1) {
    FSubscribeStatus->Objects[ind] = (TObject*)((int)AStatus);
  }
  else {
    FSubscribeStatus->AddObject(AFolder, (TObject*)((int)AStatus));
  }
}
//---------------------------------------------------------------------------

