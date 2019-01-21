//---------------------------------------------------------------------------

#ifndef CopyMoveH
#define CopyMoveH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TCopyMoveForm : public TForm
{
__published:	// IDE-managed Components
    TEdit *edtDestination;
    TCheckBox *cbIsMove;
    TButton *Button1;
    TButton *Button2;
    TLabel *Label1;
    TLabel *Label2;
    TEdit *edtSource;
private:	// User declarations
public:		// User declarations
  __fastcall TCopyMoveForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TCopyMoveForm *CopyMoveForm;
//---------------------------------------------------------------------------
#endif
