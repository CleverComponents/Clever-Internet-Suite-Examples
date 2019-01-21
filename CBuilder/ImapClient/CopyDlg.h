//---------------------------------------------------------------------------

#ifndef CopyDlgH
#define CopyDlgH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TCopyDialog : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TComboBox *cbFolder;
  TButton *Button1;
  TButton *Button2;
private:	// User declarations
public:		// User declarations
  __fastcall TCopyDialog(TComponent* Owner);
  static UnicodeString __fastcall ShowCopyDialog(TStrings *AFolders);
};
//---------------------------------------------------------------------------
extern PACKAGE TCopyDialog *CopyDialog;
//---------------------------------------------------------------------------
#endif
