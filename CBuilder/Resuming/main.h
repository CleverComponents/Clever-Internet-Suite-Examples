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
#include "clDC.hpp"
#include "clDownLoader.hpp"
#include "clMultiDC.hpp"
#include "clSingleDC.hpp"
#include "clProgressBar.hpp"
#include "clProgressBarDC.hpp"
#include <ComCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TButton *btnStart;
    TclDownLoader *DownLoader;
    TButton *btnStop;
    TclProgressBarDC *clProgressBar1;
    TLabel *Label1;
    TLabel *Label2;
    TEdit *edtFileName;
    TEdit *edtURL;
    TLabel *Label3;
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall DownLoaderStatusChanged(TObject *Sender,
          TclProcessStatus Status);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall edtURLChange(TObject *Sender);
  void __fastcall edtFileNameChange(TObject *Sender);
  void __fastcall DownLoaderChanged(TObject *Sender);
  void __fastcall FormShow(TObject *Sender);
  void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
private:	// User declarations
  bool FLoading;
  UnicodeString FResourceInfoFile;
  void __fastcall RestoreResourceInfo();
  void __fastcall StoreResourceInfo();
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
