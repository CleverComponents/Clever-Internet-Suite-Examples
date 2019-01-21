//---------------------------------------------------------------------------

#ifndef exportfrmH
#define exportfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TExportForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtFileName;
  TLabel *Label2;
  TEdit *edtPassword;
  TCheckBox *cbIncludeAll;
  TButton *btnOK;
  TButton *btnCancel;
  TEdit *edtName;
  TLabel *Label3;
private:	// User declarations
public:		// User declarations
  __fastcall TExportForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TExportForm *ExportForm;
//---------------------------------------------------------------------------
#endif
