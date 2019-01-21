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
#include "clDC.hpp"
#include "clMultiDC.hpp"
#include "clMultiDownLoader.hpp"
#include "clDownLoader.hpp"
#include "clNewsChecker.hpp"
#include "clMultiUploader.hpp"
//---------------------------------------------------------------------------
class TUploaderTest : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TclMultiUploader *clMultiUploader;
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
  TLabel *Label2;
  TEdit *edtFile;
  TPanel *Panel1;
  TButton *btnGetInfo;
  TButton *btnStop;
  TButton *btnUpload;
  TPanel *Panel2;
  TListView *ListView;
  TButton *btnAdd;
  TButton *btnDelete;
  TLabel *Label3;
  TMemo *memInfo;
  TTabSheet *tabOptions;
  TLabel *Label7;
  TEdit *edtTimeOut;
  TComboBox *cmbPriority;
  TLabel *Label11;
  TUpDown *updTimeOut;
  TBevel *Bevel1;
  TBevel *Bevel2;
  void __fastcall btnAddClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall btnGetInfoClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall FormShow(TObject *Sender);
  void __fastcall PageControlChange(TObject *Sender);
  void __fastcall ListViewChange(TObject *Sender, TListItem *Item,
          TItemChange Change);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall edtURLChange(TObject *Sender);
  void __fastcall edtFileChange(TObject *Sender);
  void __fastcall edtUserChange(TObject *Sender);
  void __fastcall edtPasswordChange(TObject *Sender);
  void __fastcall cmbPriorityChange(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall ListViewDblClick(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall edtTimeOutChange(TObject *Sender);
  void __fastcall btnUploadClick(TObject *Sender);
  void __fastcall clMultiUploaderStatusChanged(TObject *Sender,
          TclInternetItem *Item, TclProcessStatus Status);
  void __fastcall clMultiUploaderIsBusyChanged(TObject *Sender);
  void __fastcall clMultiUploaderGetResourceInfo(TObject *Sender,
          TclInternetItem *Item, TclResourceInfo *ResourceInfo);
  void __fastcall clMultiUploaderDataItemProceed(TObject *Sender,
          TclInternetItem *Item, TclResourceInfo *ResourceInfo,
          TclResourceStateItem *AStateItem, PChar CurrentData,
          int CurrentDataSize);
  void __fastcall clMultiUploaderChanged(TObject *Sender,
          TclInternetItem *Item);
  void __fastcall clMultiUploaderError(TObject *Sender, TclInternetItem *Item, const UnicodeString Error,
		  int ErrorCode);
private:	// User declarations
  bool FIsLoading;
  UnicodeString NormalizeName(const UnicodeString &AName);
  void UpdateControls();
  void FillListView();
  void FillDetails(TclInternetItem *AItem);
  TclInternetItem *GetSelectedItem();
  void LoadRegistry();
  void SaveRegistry();
  void DoShowNews(const UnicodeString &AFileName);
public:		// User declarations
  __fastcall TUploaderTest(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TUploaderTest *UploaderTest;
//---------------------------------------------------------------------------
#endif
