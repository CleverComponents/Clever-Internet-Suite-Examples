//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clDC.hpp>
#include <clMultiDC.hpp>
#include <clMultiDownLoader.hpp>
#include <clDownLoader.hpp>
#include <clNewsChecker.hpp>
#include <clSingleDC.hpp>
#include <clProgressBar.hpp>
#include <clProgressBarDC.hpp>

//---------------------------------------------------------------------------
class TDownLoaderTest : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TclMultiDownLoader *clMultiDownLoader;
    TPageControl *PageControl;
    TTabSheet *tabTasks;
    TTabSheet *tabDetails;
    TLabel *Label1;
    TLabel *Label6;
    TLabel *Label9;
    TLabel *Label4;
    TEdit *edtURL;
    TEdit *edtUser;
    TEdit *edtPassword;
    TMemo *memErrors;
    TLabel *Label5;
    TLabel *Label2;
    TEdit *edtFile;
    TMemo *memPreview;
    TPanel *Panel1;
    TPanel *Panel2;
    TListView *ListView;
    TButton *btnAdd;
    TButton *btnDelete;
    TLabel *Label3;
    TMemo *memInfo;
    TTabSheet *tabOptions;
    TLabel *Label8;
    TEdit *edtDirectory;
    TLabel *Label7;
    TEdit *edtTimeOut;
    TEdit *edtPreviewCharCount;
    TLabel *Label10;
    TCheckBox *chkDownLoadNews;
    TEdit *edtSiteNewsURL;
    TButton *btnViewSiteNews;
    TComboBox *cmbPriority;
    TLabel *Label11;
    TUpDown *updTimeOut;
    TUpDown *updPreviewCount;
    TBevel *Bevel1;
    TBevel *Bevel2;
    TclNewsChecker *clNewsChecker;
    TEdit *edtThreadCount;
    TLabel *Label12;
    TUpDown *updThreadCount;
    TCheckBox *chkPassiveFTPMode;
    TLabel *Label13;
    TLabel *Label14;
    TEdit *edtHttpProxy;
    TEdit *edtProxyBypass;
    TclProgressBarDC *clProgressBar;
    TLabel *Label15;
    TEdit *edtBatchSize;
    TUpDown *updBatchSize;
    TButton *btnDownLoad;
    TButton *btnStop;
    TButton *btnExit;
    TButton *btnGetInfo;
    TBevel *Bevel3;
    TButton *btnStop1;
    TButton *btnAdd1;
    TButton *btnDownLoad1;
    TButton *btnCancel;
    TLabel *Label16;
    TEdit *edtReconnectAfter;
    TUpDown *updReconnectAfter;
    TLabel *Label17;
    TEdit *edtTryCount;
    TUpDown *updTryCount;
    TLabel *Label18;
    TEdit *edtProxyUser;
    TLabel *Label19;
    TEdit *edtProxyPassword;
    TLabel *Label20;
    TEdit *edtHttpPort;
    TLabel *Label21;
    TEdit *edtFtpProxy;
    TLabel *Label22;
    TEdit *edtFtpPort;
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall FormShow(TObject *Sender);
  void __fastcall btnGetInfoClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall btnDownLoadClick(TObject *Sender);
  void __fastcall btnAddClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall PageControlChange(TObject *Sender);
  void __fastcall ListViewChange(TObject *Sender, TListItem *Item,
          TItemChange Change);
  void __fastcall edtURLChange(TObject *Sender);
  void __fastcall edtFileChange(TObject *Sender);
  void __fastcall edtUserChange(TObject *Sender);
  void __fastcall edtPasswordChange(TObject *Sender);
  void __fastcall edtDirectoryChange(TObject *Sender);
  void __fastcall ListViewDblClick(TObject *Sender);
  void __fastcall edtTimeOutChange(TObject *Sender);
  void __fastcall edtPreviewCharCountChange(TObject *Sender);
  void __fastcall chkDownLoadNewsClick(TObject *Sender);
  void __fastcall btnViewSiteNewsClick(TObject *Sender);
  void __fastcall edtThreadCountChange(TObject *Sender);
  void __fastcall chkPassiveFTPModeClick(TObject *Sender);
  void __fastcall edtHttpProxyChange(TObject *Sender);
  void __fastcall edtProxyBypassChange(TObject *Sender);
  void __fastcall edtBatchSizeChange(TObject *Sender);
  void __fastcall clProgressBarChanged(TObject *Sender);
  void __fastcall clMultiDownLoaderChanged(TObject *Sender,
	TclInternetItem *Item);
  void __fastcall clMultiDownLoaderIsBusyChanged(TObject *Sender);
  void __fastcall clMultiDownLoaderGetResourceInfo(TObject *Sender,
	TclInternetItem *Item, TclResourceInfo *ResourceInfo);
  void __fastcall clMultiDownLoaderStatusChanged(TObject *Sender,
	TclInternetItem *Item, TclProcessStatus Status);
  void __fastcall clNewsCheckerChanged(TObject *Sender);
  void __fastcall clNewsCheckerNewsExist(TObject *Sender);
  void __fastcall ListViewAdvancedCustomDrawSubItem(
		  TCustomListView *Sender, TListItem *Item, int SubItem,
		  TCustomDrawState State, TCustomDrawStage Stage,
		  bool &DefaultDraw);
  void __fastcall btnExitClick(TObject *Sender);
  void __fastcall btnCancelClick(TObject *Sender);
  void __fastcall edtReconnectAfterChange(TObject *Sender);
  void __fastcall edtTryCountChange(TObject *Sender);
  void __fastcall clMultiDownLoaderDataTextProceed(TObject *Sender,
          TclDownLoadItem *Item, TStrings *Text);
  void __fastcall edtProxyUserChange(TObject *Sender);
  void __fastcall edtProxyPasswordChange(TObject *Sender);
  void __fastcall cmbPriorityChange(TObject *Sender);
  void __fastcall edtHttpPortChange(TObject *Sender);
  void __fastcall edtFtpProxyChange(TObject *Sender);
  void __fastcall edtFtpPortChange(TObject *Sender);
  void __fastcall clMultiDownLoaderDataItemProceed(TObject *Sender,
          TclInternetItem *Item, TclResourceInfo *ResourceInfo,
          TclResourceStateItem *AStateItem, PChar CurrentData,
          int CurrentDataSize);
  void __fastcall clMultiDownLoaderError(TObject *Sender, TclInternetItem *Item, const UnicodeString Error,
	  int ErrorCode);
private:	// User declarations
  bool FIsLoading;
  bool FIsNewItem;
  UnicodeString NormalizeName(const UnicodeString &AName);
  void UpdateControls();
  void FillListView();
  void FillDetails(TclInternetItem *AItem);
  TclInternetItem *GetSelectedItem();
  void LoadRegistry();
  void SaveRegistry();
  void DoShowNews(const AnsiString &AFileName);
  UnicodeString GetFormattedTime(double ATime);
  UnicodeString GetFormattedBytes(double ABytes);
public:		// User declarations
  __fastcall TDownLoaderTest(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TDownLoaderTest *DownLoaderTest;
//---------------------------------------------------------------------------
#endif
