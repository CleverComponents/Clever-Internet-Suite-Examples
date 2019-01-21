//---------------------------------------------------------------------------

#ifndef importfrmH
#define importfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TImportForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtFileName;
  TLabel *Label2;
  TEdit *edtPassword;
  TButton *btnOK;
  TButton *btnCancel;
  TLabel *Label3;
  TEdit *edtStoreName;
private:	// User declarations
public:		// User declarations
  __fastcall TImportForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TImportForm *ImportForm;
//---------------------------------------------------------------------------
#endif
