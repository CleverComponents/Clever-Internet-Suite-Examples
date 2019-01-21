//---------------------------------------------------------------------------

#ifndef ModifyPropsH
#define ModifyPropsH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TModifyPropForm : public TForm
{
__published:	// IDE-managed Components
    TLabel *Label1;
    TEdit *edtName;
    TLabel *Label2;
    TEdit *edtValue;
    TButton *Button1;
    TButton *Button2;
    TButton *Button3;
    TLabel *lblResource;
private:	// User declarations
public:		// User declarations
  __fastcall TModifyPropForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TModifyPropForm *ModifyPropForm;
//---------------------------------------------------------------------------
#endif
