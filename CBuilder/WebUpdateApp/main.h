//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clWebUpdate.hpp>
#include <ComCtrls.hpp>
#include <Menus.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Buttons.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TStatusBar *StatusBar;
    TclWebUpdate *clWebUpdate;
	TMemo *Memo1;
	TBitBtn *btnStartUpdate;
	TBitBtn *btnAbout;
	TBitBtn *btnClose;
  void __fastcall StatusBarMouseDown(TObject *Sender, TMouseButton Button,
          TShiftState Shift, int X, int Y);
  void __fastcall StatusBarMouseUp(TObject *Sender, TMouseButton Button,
          TShiftState Shift, int X, int Y);
  void __fastcall clWebUpdateNoUpdatesFound(TObject *Sender);
  void __fastcall clWebUpdateTerminating(TObject *Sender,
          bool &CanTerminate);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall clWebUpdateRunUpdate(TObject *Sender,
          TStrings *AUpdateScript, bool ANeedTerminate, bool &CanRun,
          TclRunUpdateResult &Result, UnicodeString &AErrors);
        void __fastcall clWebUpdateError(TObject *Sender, int UpdateNo,
          const UnicodeString Error, int ErrorCode);
        void __fastcall clWebUpdateDownloadProgress(TObject *Sender,
          int UpdateNo, __int64 Downloaded, __int64 Total);
	void __fastcall btnStartUpdateClick(TObject *Sender);
	void __fastcall btnAboutClick(TObject *Sender);
	void __fastcall btnCloseClick(TObject *Sender);
private:	// User declarations
  void __fastcall SetStatusBarCaption(const UnicodeString AText);
  void __fastcall AddUpdateScript(const UnicodeString AScript);
  void __fastcall AddStartAppStatement(void);
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
