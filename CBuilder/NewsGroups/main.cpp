//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "MessageForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clNntp"
#pragma link "clNntp"
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
void __fastcall TForm1::btnConnectClick(TObject *Sender)
{
  cbNewsGroup->Enabled = false;
  btnGetArticles->Enabled = false;
  btnPostNew->Enabled = false;
  btnReply->Enabled = false;
  tvArticles->Enabled = false;
  memBody->Enabled = false;

  clNNTP->Close();
  clNNTP->Server = edtNewsServer->Text;
  clNNTP->Open();

  clNNTP->GetGroups(cbNewsGroup->Items, false);

  cbNewsGroup->Enabled = true;
  btnGetArticles->Enabled = true;
  btnPostNew->Enabled = true;
  btnReply->Enabled = true;
  tvArticles->Enabled = true;
  memBody->Enabled = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnGetArticlesClick(TObject *Sender)
{
  btnGetArticles->Enabled = false;
  btnPostNew->Enabled = false;
  btnReply->Enabled = false;
  tvArticles->Enabled = false;
  memBody->Enabled = false;

  FIsLoading = true;
  TStrings *list = new TStringList();
  __try
  {
    tvArticles->Items->Clear();
    memBody->Lines->Clear();

    clNNTP->SelectGroup(cbNewsGroup->Text);
    clNNTP->GroupOverview();
  }
  __finally
  {
    delete list;
    FIsLoading = false;

    btnGetArticles->Enabled = true;
    btnPostNew->Enabled = true;
    btnReply->Enabled = true;
    tvArticles->Enabled = true;
    memBody->Enabled = true;
  }
}
//---------------------------------------------------------------------------


void __fastcall TForm1::tvArticlesDeletion(TObject *Sender,
      TTreeNode *Node)
{
  FreeMemory(Node->Data);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::tvArticlesChange(TObject *Sender, TTreeNode *Node)
{
  if(FIsLoading || (Node == NULL)) return;
  FIsLoading = true;
  __try
  {
    UnicodeString messageID = (char *)Node->Data;

    clNNTP->GetBody(messageID, memBody->Lines);
  }
  __finally
  {
    FIsLoading = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPostNewClick(TObject *Sender)
{
  if(TclMessageForm::PostNew(clMailMessage))
    clNNTP->PostArticle(clMailMessage, "", cbNewsGroup->Text);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnReplyClick(TObject *Sender)
{
  if(tvArticles->Selected == NULL)
  {
    ShowMessage("Select article first");
    return;
  }
  UnicodeString messageID = (char *)tvArticles->Selected->Data;

  clNNTP->GetArticle(messageID, clMailMessage);

  if(TclMessageForm::ReplyTo(clMailMessage))
    clNNTP->PostArticle(clMailMessage, messageID, cbNewsGroup->Text);
}
//---------------------------------------------------------------------------

TTreeNode * __fastcall TForm1::FindNodeByMessageID(const String AMessageID)
{
  for(int i = 0; i < tvArticles->Items->Count; i++)
  {
    if(wcscmp((Char *)tvArticles->Items->Item[i]->Data, AMessageID.c_str()) == 0)
      return tvArticles->Items->Item[i];
  }
  return NULL;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clNNTPGroupOverview(TObject *Sender,
      TclArticleInfo *ArticleInfo)
{
  char * p = (char *)GetMemory(ArticleInfo->MessageID.Length() + 1);
  memcpy(p, ArticleInfo->MessageID.c_str(), ArticleInfo->MessageID.Length());
  p[ArticleInfo->MessageID.Length()] = 0;

  TTreeNode *node = NULL;

  if(ArticleInfo->References->Count > 0)
    node = FindNodeByMessageID(ArticleInfo->References->Strings[ArticleInfo->References->Count - 1]);

  if((node != NULL) && (ArticleInfo->References->Count > 0))
    tvArticles->Items->AddChildObject(node, ArticleInfo->Subject + " from " + ArticleInfo->From->FullAddress, p);
  else
    tvArticles->Items->AddObject(node, ArticleInfo->Subject + " from " + ArticleInfo->From->FullAddress, p);
}
//---------------------------------------------------------------------------

