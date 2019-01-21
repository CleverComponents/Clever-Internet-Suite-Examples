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
#include <clDC.hpp>
#include <clUploader.hpp>
#include <clMultiDC.hpp>
#include <clSingleDC.hpp>
#include "clProgressBar.hpp"
#include "clProgressBarDC.hpp"
//---------------------------------------------------------------------------
class TUploaderTest : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnUpload;
  TEdit *edtURL;
  TEdit *edtFile;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *Edit1;
  TButton *btnGetInfo;
  TLabel *Label4;
  TMemo *memErrors;
  TLabel *Label6;
  TEdit *edtUser;
  TEdit *edtPassword;
  TButton *btnStop;
  TMemo *memInfo;
  TLabel *Label7;
  TLabel *Label9;
  TclUploader *clUploader1;
  TclProgressBarDC *clProgressBar1;
  TLabel *Label5;
  TLabel *Label13;
  TLabel *Label8;
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall edtURLChange(TObject *Sender);
  void __fastcall edtUserChange(TObject *Sender);
  void __fastcall edtFileChange(TObject *Sender);
  void __fastcall edtPasswordChange(TObject *Sender);
  void __fastcall btnGetInfoClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall btnUploadClick(TObject *Sender);
  void __fastcall clUploader1StatusChanged(TObject *Sender,
		  TclProcessStatus Status);
  void __fastcall clUploader1GetResourceInfo(TObject *Sender,
		  TclResourceInfo *ResourceInfo);
  void __fastcall clUploader1Error(TObject *Sender,
		  const UnicodeString Error, int ErrorCode);
  void __fastcall clUploader1DataItemProceed(TObject *Sender,
		  TclResourceInfo *ResourceInfo, TclResourceStateItem *AStateItem,
		  PChar CurrentData, int CurrentDataSize);
  void __fastcall clUploader1Changed(TObject *Sender);
	void __fastcall clUploader1UrlParsing(TObject *Sender, TclUrlParser *AURLComponents);

private:	// User declarations
  bool FIsLoading;
public:		// User declarations
  __fastcall TUploaderTest(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TUploaderTest *UploaderTest;
//---------------------------------------------------------------------------
#endif
