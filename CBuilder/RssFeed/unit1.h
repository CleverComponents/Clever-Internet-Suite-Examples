//---------------------------------------------------------------------------

#ifndef unit1H
#define unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clRss.hpp>
#include <ComCtrls.hpp>
#include "EditItemFrm.h"
#include <Dialogs.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtTitle;
  TLabel *Label2;
  TEdit *edtLink;
  TLabel *Label3;
  TEdit *edtDescription;
  TLabel *Label4;
  TEdit *edtCopyright;
  TLabel *Label5;
  TEdit *edtLanguage;
  TLabel *Label6;
  TEdit *edtWebMaster;
  TLabel *Label7;
  TEdit *edtGenerator;
  TLabel *Label9;
  TEdit *edtImageUrl;
  TListBox *lbNews;
  TButton *btnAdd;
  TButton *btnDelete;
  TButton *btnClear;
  TButton *btnLoad;
  TButton *btnSave;
  TclRss *clRss1;
  TOpenDialog *OpenDialog1;
  TSaveDialog *SaveDialog1;
  void __fastcall lbNewsDblClick(TObject *Sender);
  void __fastcall btnAddClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall btnClearClick(TObject *Sender);
  void __fastcall btnLoadClick(TObject *Sender);
  void __fastcall btnSaveClick(TObject *Sender);
private:	// User declarations
  void __fastcall LoadControls();
  void __fastcall SaveControls();
  void __fastcall SaveItem(TEditItemForm *ADlg, TclRssItem *AItem);
  void __fastcall LoadItem(TEditItemForm *ADlg, TclRssItem *AItem);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
