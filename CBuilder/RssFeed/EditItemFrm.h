//---------------------------------------------------------------------------

#ifndef EditItemFrmH
#define EditItemFrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
//---------------------------------------------------------------------------
class TEditItemForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtTitle;
  TLabel *Label2;
  TEdit *edtLink;
  TLabel *Label3;
  TEdit *edtDescription;
  TDateTimePicker *dtPubDate;
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtGuid;
  TButton *Button1;
  TButton *Button2;
private:	// User declarations
public:		// User declarations
  __fastcall TEditItemForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
#endif
