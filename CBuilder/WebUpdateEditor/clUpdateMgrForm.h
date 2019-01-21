//---------------------------------------------------------------------------

#ifndef clUpdateMgrFormH
#define clUpdateMgrFormH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Buttons.hpp>
#include <ExtCtrls.hpp>
#include <clWebUpdate.hpp>
//---------------------------------------------------------------------------
class TclUpdateMgrFrm : public TForm
{
__published:	// IDE-managed Components
  TMemo *memScript;
  TLabel *Label1;
  TListBox *lbUpdates;
  TLabel *Label2;
  TEdit *edtUpdateVersion;
  TLabel *Label3;
  TEdit *edtURL;
  TLabel *Label4;
  TEdit *edtSize;
  TCheckBox *cbNeedTerminate;
  TLabel *Label5;
  TButton *btnAdd;
  TButton *btnDelete;
  TButton *btnOk;
  TButton *btnCancel;
  TBevel *Bevel1;
  TBitBtn *btnUp;
  TBitBtn *btnDown;
  void __fastcall lbUpdatesClick(TObject *Sender);
  void __fastcall btnAddClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall edtUpdateVersionChange(TObject *Sender);
  void __fastcall edtURLChange(TObject *Sender);
  void __fastcall edtSizeChange(TObject *Sender);
  void __fastcall cbNeedTerminateClick(TObject *Sender);
  void __fastcall memScriptChange(TObject *Sender);
  void __fastcall btnUpClick(TObject *Sender);
  void __fastcall btnDownClick(TObject *Sender);
private:	// User declarations
  bool FUpdating;
  TclUpdateInfoList *FUpdateInfo;
  void __fastcall LoadUpdateInfo(TclUpdateInfoList *AUpdateInfo);
  void __fastcall FillListbox(int ASelectedIndex);
  void __fastcall StoreUpdateInfo(TclUpdateInfoList *AUpdateInfo);
  TclUpdateInfoItem * __fastcall GetCurrentItem(void);
  UnicodeString __fastcall GetListboxItemName(TclUpdateInfoItem *AUpdateInfoItem);
  void __fastcall UpdateControls(void);
public:		// User declarations
  __fastcall TclUpdateMgrFrm(TComponent* Owner);
  virtual __fastcall ~TclUpdateMgrFrm(void);
  static bool __fastcall ShowEditor(TclUpdateInfoList *AUpdateInfo);
};
//---------------------------------------------------------------------------
#endif
