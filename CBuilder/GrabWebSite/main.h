//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clMultiDC.hpp>
#include <clMultiDownLoader.hpp>
#include <ComCtrls.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *edtRootUrl;
  TclMultiDownLoader *clMultiDownLoader;
  TGroupBox *GroupBox1;
  TLabel *Label4;
  TEdit *edtTargetDir;
  TCheckBox *cbGrabAll;
  TCheckBox *cbGrabImages;
  TCheckBox *cbGrabData;
  TButton *btnGrab;
  TButton *btnStop;
  TLabel *Label5;
  TMemo *memLog;
  TStatusBar *StatusBar1;
  TEdit *edtMaxNestLevel;
  TLabel *Label6;
  TUpDown *updMaxNestLevel;
  void __fastcall clMultiDownLoaderIsBusyChanged(TObject *Sender);
  void __fastcall btnGrabClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall clMultiDownLoaderProcessCompleted(TObject *Sender,
          TclInternetItem *Item);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
