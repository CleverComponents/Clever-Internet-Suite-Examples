//---------------------------------------------------------------------------

#ifndef getcertH
#define getcertH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TGetCertDialog : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TEdit *edtEmail;
  TEdit *edtStore;
  TButton *btnOK;
  TButton *btnMessage;
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TGetCertDialog(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TGetCertDialog *GetCertDialog;

static UnicodeString DefaultEmail = "myname@mycompany.com";

//---------------------------------------------------------------------------
#endif
