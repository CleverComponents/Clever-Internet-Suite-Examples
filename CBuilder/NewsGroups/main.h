//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clMailMessage.hpp>
#include <ComCtrls.hpp>
#include <clNntp.hpp>
#include <clTcpClient.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtNewsServer;
  TButton *btnConnect;
  TclNntp *clNNTP;
  TTreeView *tvArticles;
  TMemo *memBody;
  TComboBox *cbNewsGroup;
  TLabel *Label2;
  TButton *btnPostNew;
  TButton *btnReply;
  TButton *btnGetArticles;
  TclMailMessage *clMailMessage;
  void __fastcall btnConnectClick(TObject *Sender);
  void __fastcall btnGetArticlesClick(TObject *Sender);
  void __fastcall tvArticlesDeletion(TObject *Sender, TTreeNode *Node);
  void __fastcall tvArticlesChange(TObject *Sender, TTreeNode *Node);
  void __fastcall btnPostNewClick(TObject *Sender);
  void __fastcall btnReplyClick(TObject *Sender);
  void __fastcall clNNTPGroupOverview(TObject *Sender,
          TclArticleInfo *ArticleInfo);
private:	// User declarations
    bool FIsLoading;
    TTreeNode * __fastcall FindNodeByMessageID(const String AMessageID);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
