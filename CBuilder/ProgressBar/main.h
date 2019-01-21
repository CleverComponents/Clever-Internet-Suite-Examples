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
#include <clProgressBar.hpp>
#include <Dialogs.hpp>
#include <ComCtrls.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnOne;
  TButton *btnTwo;
  TButton *btnThree;
  TButton *btnInit;
  TListView *ListView;
  TclProgressBar *clProgressBar1;
  TclProgressBar *clProgressBar2;
  TclProgressBar *clProgressBar3;
  TclProgressBar *clProgressBar4;
  TclProgressBar *clProgressBar5;
  TclProgressBar *clListViewProgressBar1;
  TclProgressBar *clListViewProgressBar2;
  TclProgressBar *clListViewProgressBar3;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TLabel *Label4;
  TLabel *Label5;
  TLabel *Label6;
  TLabel *Label7;
  TLabel *Label8;
  TBevel *Bevel1;
  TBevel *Bevel2;
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall btnInitClick(TObject *Sender);
  void __fastcall btnOneClick(TObject *Sender);
  void __fastcall btnTwoClick(TObject *Sender);
  void __fastcall btnThreeClick(TObject *Sender);
  void __fastcall ListViewCustomDrawSubItem(TCustomListView *Sender,
          TListItem *Item, int SubItem, TCustomDrawState State,
          bool &DefaultDraw);
  void __fastcall clListViewProgressBar1Changed(TObject *Sender);
private:	// User declarations
  void UpdateProgressBars(void);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
