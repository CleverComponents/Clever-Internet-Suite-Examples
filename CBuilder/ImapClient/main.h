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
#include <clImap4.hpp>
#include <clMailMessage.hpp>
#include <clMC.hpp>
#include <clTcpClient.hpp>
#include <ComCtrls.hpp>
#include <ImgList.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtServer;
  TEdit *edtPort;
  TEdit *edtUser;
  TEdit *edtPassword;
  TButton *btnLogin;
  TButton *btnLogout;
  TTreeView *tvFolders;
  TListView *lvMessages;
  TclImap4 *clImap;
  TImageList *Images;
  TclMailMessage *clMailMessage;
  TCheckBox *cbUseSPA;
  TLabel *Label3;
  TEdit *edtTimeOut;
  TGroupBox *GroupBox1;
  TLabel *Label7;
  TEdit *edtSubscribed;
  TEdit *edtAll;
  TLabel *Label8;
  TEdit *edtRecent;
  TLabel *Label9;
  TEdit *edtFirstUnseen;
  TLabel *Label10;
  TLabel *Label11;
  TMemo *memLog;
  TButton *btnNewFolder;
  TButton *btnDeleteFolder;
  TButton *btnFind;
  TButton *btnSubscribe;
  TButton *btnUnsubscribe;
  TButton *btnAppend;
  TButton *btnCopy;
  TButton *btnDelete;
  TButton *btnPurge;
  void __fastcall btnLoginClick(TObject *Sender);
  void __fastcall btnLogoutClick(TObject *Sender);
  void __fastcall tvFoldersChange(TObject *Sender, TTreeNode *Node);
  void __fastcall lvMessagesDblClick(TObject *Sender);
        void __fastcall btnNewFolderClick(TObject *Sender);
        void __fastcall btnDeleteFolderClick(TObject *Sender);
        void __fastcall btnFindClick(TObject *Sender);
        void __fastcall btnSubscribeClick(TObject *Sender);
        void __fastcall btnUnsubscribeClick(TObject *Sender);
        void __fastcall btnAppendClick(TObject *Sender);
        void __fastcall btnCopyClick(TObject *Sender);
        void __fastcall btnDeleteClick(TObject *Sender);
        void __fastcall btnPurgeClick(TObject *Sender);
        void __fastcall clImapReceiveResponse(TObject *Sender,
          TStrings *AList);
        void __fastcall clImapSendCommand(TObject *Sender,
          const UnicodeString AText);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall FormDestroy(TObject *Sender);
private:	// User declarations
        TStrings *FSubscribeStatus;
        
        void __fastcall GetFolderList(void);
        void __fastcall UpdateStatuses(void);
        void __fastcall AddFolderToList(UnicodeString AName);
        void __fastcall GetMessageList(void);
        UnicodeString __fastcall GetFolderName(TTreeNode *Node);
        bool __fastcall GetSubscribeStatus(UnicodeString AFolder);
        void __fastcall SetSubscribeStatus(UnicodeString AFolder, bool AStatus);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
