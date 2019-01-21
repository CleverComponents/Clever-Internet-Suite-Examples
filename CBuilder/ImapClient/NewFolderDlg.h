//---------------------------------------------------------------------------

#ifndef NewFolderDlgH
#define NewFolderDlgH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TNewFolderDialog : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtName;
  TCheckBox *cbIsSubfolder;
  TButton *Button1;
  TButton *Button2;
        void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
private:	// User declarations
public:		// User declarations
        __fastcall TNewFolderDialog(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TNewFolderDialog *NewFolderDialog;
//---------------------------------------------------------------------------
#endif
