//---------------------------------------------------------------------------

#ifndef certfrmH
#define certfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TCertForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtName;
  TLabel *Label2;
  TEdit *edtIssuedTo;
  TLabel *Label3;
  TEdit *edtIssuedBy;
  TLabel *Label4;
  TEdit *edtValidFrom;
  TLabel *Label5;
  TEdit *edtValidTo;
  TButton *btnInstall;
  TButton *btnContinue;
  TButton *btnCancel;
private:	// User declarations
public:		// User declarations
  __fastcall TCertForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TCertForm *CertForm;
//---------------------------------------------------------------------------
#endif
