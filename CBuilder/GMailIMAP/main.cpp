//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clImap4"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma link "clTcpCommandClient"
#pragma link "clOAuth"
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
  if (clImap->Active) return;

  clOAuth1->AuthUrl = "https://accounts.google.com/o/oauth2/auth";
  clOAuth1->TokenUrl = "https://accounts.google.com/o/oauth2/token";
  clOAuth1->RedirectUrl = "http://localhost";
  clOAuth1->ClientID = "421475025220-6khpgoldbdsi60fegvjdqk2bk4v19ss2.apps.googleusercontent.com";
  clOAuth1->ClientSecret = "_4HJyAVUmH_iVrPB8pOJXjR1";
  clOAuth1->Scope = "https://mail.google.com/";

  clImap->Server = "imap.gmail.com";
  clImap->Port = 993;
  clImap->UseTLS = ctImplicit;

  clImap->UserName = edtUser->Text;

  clImap->Authorization = clOAuth1->GetAuthorization();

  clImap->Open();

  FillFolderList();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnLogoutClick(TObject *Sender)
{
  clImap->Close();
  tvFolders->Items->Clear();
  lvMessages->Clear();
  ClearMessage();
}
//---------------------------------------------------------------------------


void __fastcall TForm1::tvFoldersChange(TObject *Sender, TTreeNode *Node)
{
  if (FChanging) return;

  FChanging = true;
  __try {
    EnableControls(false);
    if (clImap->Active && (tvFolders->Selected != NULL))
      clImap->SelectMailBox(GetFolderName(tvFolders->Selected));
    FillMessages();
  }
  __finally {
    FChanging = false;
    EnableControls(true);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::lvMessagesClick(TObject *Sender)
{
  if (FChanging) return;

  FChanging = true;
  __try {
    EnableControls(false);

    if (clImap->Active && (lvMessages->Selected != NULL)) {
      clImap->RetrieveMessage((int)lvMessages->Selected->Data, clMailMessage);

      edtFrom->Text = clMailMessage->From->FullAddress;
      edtSubject->Text = clMailMessage->Subject;
      memBody->Lines = clMailMessage->MessageText;
    }
    else {
      ClearMessage();
    }
  }
  __finally {
    FChanging = false;
    EnableControls(true);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillFolderList(void)
{
  TStrings *list = new TStringList();
  __try {
    tvFolders->Items->BeginUpdate();
    tvFolders->Items->Clear();

    clImap->GetMailBoxes(list);

    for (int i = 0; i < list->Count; i++)
      AddFolderToList(list->Strings[i]);
  }
  __finally {
    tvFolders->Items->EndUpdate();
    delete list;
  }
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

UnicodeString __fastcall TForm1::GetFolderName(TTreeNode *Node)
{
  UnicodeString result = "";
  if(Node != NULL)
  {
    result = Node->Text;
    while(Node->Parent != NULL)
    {
      Node = Node->Parent;
      result = Node->Text + clImap->MailBoxSeparator + result;
    }
  }
  return result;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillMessages(void)
{
  lvMessages->Items->Clear();
  ClearMessage();

  if (!clImap->Active) return;

  TListItem *Item;
  for (int i = 1; i <= clImap->CurrentMailBox->ExistsMessages; i++) {
    Item = lvMessages->Items->Add();
    Item->Data = (void*)i;
    FillMessage(Item);
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillMessage(TListItem *AItem)
{
  int Index = (int)AItem->Data;

  clImap->RetrieveHeader(Index, clMailMessage);

  AItem->Caption = clMailMessage->Subject;
  AItem->SubItems->Clear();

  AItem->SubItems->Add(clMailMessage->From->FullAddress);
  AItem->SubItems->Add(DateTimeToStr(clMailMessage->Date));
  AItem->SubItems->Add(IntToStr(clImap->GetMessageSize(Index)));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ClearMessage(void)
{
  edtFrom->Text = "";
  edtSubject->Text = "";
  memBody->Lines->Clear();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::EnableControls(bool AEnabled)
{
  btnLogin->Enabled = AEnabled;
  btnLogout->Enabled = AEnabled;
  tvFolders->Enabled = AEnabled;
  lvMessages->Enabled = AEnabled;
  edtFrom->Enabled = AEnabled;
  edtSubject->Enabled = AEnabled;
  memBody->Enabled = AEnabled;

  if (AEnabled)
    Cursor = crArrow;
  else
    Cursor = crHourGlass;
}
//---------------------------------------------------------------------------

