//---------------------------------------------------------------------------

#ifndef fileDlgH
#define fileDlgH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TFileExistsDialog : public TForm
{
__published:	// IDE-managed Components
  TLabel *lblCaption;
  TButton *btnReplace;
  TButton *btnResume;
  TButton *btnCancel;
private:	// User declarations
public:		// User declarations
  static int __fastcall ShowFileDialog(const UnicodeString AFileName);
  __fastcall TFileExistsDialog(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFileExistsDialog *FileExistsDialog;
//---------------------------------------------------------------------------
#endif
