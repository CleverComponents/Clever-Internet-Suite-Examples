//---------------------------------------------------------------------------

#ifndef newDlgH
#define newDlgH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TNewDialog : public TForm
{
__published:	// IDE-managed Components
  TLabel *lblName;
  TEdit *edtName;
  TButton *btnOK;
  TButton *btnCancel;
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
private:	// User declarations
public:		// User declarations
  static UnicodeString __fastcall ShowNewDialog(const UnicodeString ACaption, const UnicodeString AValue);
  __fastcall TNewDialog(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TNewDialog *NewDialog;
//---------------------------------------------------------------------------
#endif
