//---------------------------------------------------------------------------

#ifndef loginH
#define loginH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TLoginConfirmation : public TForm
{
__published:	// IDE-managed Components
	TLabel *Label1;
	TEdit *edtClientID;
	TLabel *Label2;
	TEdit *edtScope;
	TButton *btnOK;
	TButton *btnCancel;
	TLabel *Label3;
private:	// User declarations
public:		// User declarations
	__fastcall TLoginConfirmation(TComponent* Owner);
	static bool __fastcall ShowConfirmation(const UnicodeString  AClientID, const UnicodeString AScope);
};
//---------------------------------------------------------------------------
extern PACKAGE TLoginConfirmation *LoginConfirmation;
//---------------------------------------------------------------------------
#endif
