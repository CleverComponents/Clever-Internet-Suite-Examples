//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Forms.hpp>
#include <clHttp.hpp>
#include <clTcpClient.hpp>
#include <clWebDav.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include "clTcpClientTls.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TLabel *Label1;
    TEdit *edtHost;
    TLabel *Label2;
    TButton *btnOpen;
    TclWebDav *clWebDav1;
    TLabel *Label3;
    TLabel *Label4;
    TEdit *edtUser;
    TEdit *edtPassword;
    TListView *lvResources;
    TButton *btnGetAllProps;
    TButton *btnModifyProp;
    TButton *btnMakeDir;
    TButton *btnDelete;
    TButton *btnLock;
    TButton *btnUnlock;
    TButton *btnCopyMove;
    TButton *btnDownload;
    TButton *btnUpload;
    TOpenDialog *OpenDialog1;
    TSaveDialog *SaveDialog1;
    TLabel *Label5;
    TComboBox *cbDepth;
    TButton *btnCapabilities;
    TButton *btnGoUp;
  void __fastcall btnOpenClick(TObject *Sender);
  void __fastcall btnGetAllPropsClick(TObject *Sender);
  void __fastcall btnModifyPropClick(TObject *Sender);
  void __fastcall btnMakeDirClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall btnLockClick(TObject *Sender);
  void __fastcall btnUnlockClick(TObject *Sender);
  void __fastcall btnCopyMoveClick(TObject *Sender);
  void __fastcall btnDownloadClick(TObject *Sender);
  void __fastcall btnUploadClick(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall btnCapabilitiesClick(TObject *Sender);
  void __fastcall btnGoUpClick(TObject *Sender);
  void __fastcall lvResourcesDblClick(TObject *Sender);
        void __fastcall FormDestroy(TObject *Sender);
private:	// User declarations
    UnicodeString FCurrentDir;
    TStrings *FResources;
    TStrings *FLocks;
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
