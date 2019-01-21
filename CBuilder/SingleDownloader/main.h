//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
#include "clDownLoader.hpp"
#include "clMultiDC.hpp"
#include "clProgressBar.hpp"
#include "clProgressBarDC.hpp"
#include "clSingleDC.hpp"
#include "DemoBaseFormUnit.h"
#include <Classes.hpp>
#include <ComCtrls.hpp>
#include <Controls.hpp>
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <StdCtrls.hpp>
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clDC.hpp>
#include <clDownLoader.hpp>
#include <clMultiDC.hpp>
#include <clSingleDC.hpp>
#include <clProgressBar.hpp>
#include <clProgressBarDC.hpp>
#include <ComCtrls.hpp>

//---------------------------------------------------------------------------
class TDownLoaderTest : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnDownLoad;
  TEdit *edtURL;
  TEdit *edtFile;
  TLabel *Label1;
  TLabel *Label2;
  TclDownLoader *clDownLoader1;
  TMemo *memPreview;
  TLabel *Label3;
  TEdit *edtStatistic;
  TButton *btnGetInfo;
  TLabel *Label5;
  TLabel *Label4;
  TMemo *memErrors;
  TLabel *Label6;
  TEdit *edtUser;
  TEdit *edtPassword;
  TButton *btnStop;
  TMemo *memInfo;
  TLabel *Label7;
  TEdit *edtDirectory;
  TLabel *Label8;
  TLabel *Label9;
  TclProgressBarDC *clProgressBar1;
  TLabel *Label10;
  TEdit *edtThreadCount;
  TLabel *Label11;
  TEdit *edtBufferSize;
  TUpDown *updBufferSize;
  TUpDown *updThreadCount;
  TLabel *Label12;
  TLabel *Label13;
  void __fastcall edtURLChange(TObject *Sender);
  void __fastcall edtUserChange(TObject *Sender);
  void __fastcall edtPasswordChange(TObject *Sender);
  void __fastcall edtDirectoryChange(TObject *Sender);
  void __fastcall edtFileChange(TObject *Sender);
  void __fastcall btnGetInfoClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall btnDownLoadClick(TObject *Sender);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall edtThreadCountChange(TObject *Sender);
  void __fastcall edtBufferSizeChange(TObject *Sender);
  void __fastcall clDownLoader1DataItemProceed(TObject *Sender,
          TclResourceInfo *ResourceInfo, TclResourceStateItem *AStateItem,
          PChar CurrentData, int CurrentDataSize);
  void __fastcall clDownLoader1StatusChanged(TObject *Sender,
          TclProcessStatus Status);
  void __fastcall clDownLoader1Changed(TObject *Sender);
  void __fastcall clDownLoader1GetResourceInfo(TObject *Sender,
		  TclResourceInfo *ResourceInfo);
  void __fastcall clDownLoader1DataTextProceed(TObject *Sender,
          TStrings *Text);
  void __fastcall clDownLoader1Error(TObject *Sender,
          const UnicodeString Error, int ErrorCode);
	void __fastcall clDownLoader1UrlParsing(TObject *Sender, TclUrlParser *AURLComponents);


private:	// User declarations
  bool FIsLoading;
public:		// User declarations
  __fastcall TDownLoaderTest(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TDownLoaderTest *DownLoaderTest;
//---------------------------------------------------------------------------
#endif
