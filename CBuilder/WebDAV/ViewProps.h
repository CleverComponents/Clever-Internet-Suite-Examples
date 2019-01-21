//---------------------------------------------------------------------------

#ifndef ViewPropsH
#define ViewPropsH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TViewPropsForm : public TForm
{
__published:	// IDE-managed Components
    TMemo *Memo1;
private:	// User declarations
public:		// User declarations
  __fastcall TViewPropsForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TViewPropsForm *ViewPropsForm;
//---------------------------------------------------------------------------
#endif
