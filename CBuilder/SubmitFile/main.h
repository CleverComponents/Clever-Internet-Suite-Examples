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
#include <clProgressBarDC.hpp>
#include <clSingleDC.hpp>
#include <clUploader.hpp>
#include <clHttpRequest.hpp>
#include <Dialogs.hpp>
#include <clHttpRequest.hpp>
#include <Dialogs.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtFile;
  TButton *btnBrowse;
  TButton *btnStart;
  TEdit *edtHost;
  TOpenDialog *OpenDialog1;
  TclUploader *clUploader;
  TclProgressBarDC *clProgressBar1;
  TMemo *Memo1;
  TLabel *Label1;
  TButton *btnStop;
  TLabel *Label2;
  TEdit *edtViewPage;
  TButton *btnView;
  TclHttpRequest *clHttpRequest;
  void __fastcall btnBrowseClick(TObject *Sender);
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall clUploaderStatusChanged(TObject *Sender,
          TclProcessStatus Status);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall btnViewClick(TObject *Sender);
        void __fastcall clUploaderProcessCompleted(TObject *Sender);
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
