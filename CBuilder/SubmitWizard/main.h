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
#include <clMultiDC.hpp>
#include <clProgressBar.hpp>
#include <clSingleDC.hpp>
#include <clUploader.hpp>
#include <Dialogs.hpp>
#include <clInternetConnection.hpp>
#include <clMultiUploader.hpp>
#include <clHttpRequest.hpp>
#include "clInternetConnection.hpp"
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label4;
  TEdit *edtFirstName;
  TButton *btnStart;
  TMemo *memResult;
  TLabel *Label1;
  TLabel *Label2;
  TEdit *edtViewPage;
  TButton *btnView;
  TLabel *Label3;
  TEdit *edtLastName;
  TclMultiUploader *clMultiUploader;
  TLabel *Label6;
  TEdit *edtAccount;
  TLabel *Label7;
  TEdit *edtDescription;
  TLabel *Label8;
  TEdit *edtFileName;
  TclInternetConnection *clInternetConnection;
  TButton *btnStop;
  TclHttpRequest *rbStep1;
  TclHttpRequest *rbStep2;
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall btnViewClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
        void __fastcall clMultiUploaderProcessCompleted(TObject *Sender,
          TclInternetItem *Item);
private:	// User declarations
  bool ProcessStep1(void);
  void ProcessStep2(void);
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
