//---------------------------------------------------------------------------

#ifndef SearchDlgH
#define SearchDlgH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TSearchDialog : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TComboBox *cbSearchIn;
  TLabel *Label2;
  TEdit *edtSearchFor;
  TButton *btnSearch;
  TButton *btnCancel;
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
private:	// User declarations
public:		// User declarations
  __fastcall TSearchDialog(TComponent* Owner);
  UnicodeString __fastcall GetSearchCriteria(void);
};
//---------------------------------------------------------------------------
extern PACKAGE TSearchDialog *SearchDialog;
//---------------------------------------------------------------------------
#endif
