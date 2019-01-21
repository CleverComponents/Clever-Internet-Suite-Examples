//---------------------------------------------------------------------------

#ifndef relayfrmH
#define relayfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TRelayStatusForm : public TForm
{
__published:	// IDE-managed Components
  TMemo *Memo1;
private:	// User declarations
public:		// User declarations
  __fastcall TRelayStatusForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TRelayStatusForm *RelayStatusForm;
//---------------------------------------------------------------------------
#endif
