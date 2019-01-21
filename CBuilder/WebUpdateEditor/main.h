//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Forms.hpp>
#include "clWebUpdate.hpp"
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TEdit *edtUpdateFile;
  TLabel *Label1;
  TButton *btnEdit;
  TclWebUpdate *clWebUpdate;
  TButton *btnClose;
  void __fastcall btnEditClick(TObject *Sender);
  void __fastcall btnCloseClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
