//---------------------------------------------------------------------------

#ifndef MessageFormH
#define MessageFormH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <clMailMessage.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TclMessageForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *edtFrom;
  TEdit *edtSubject;
  TMemo *memText;
  TButton *btnPost;
  TButton *btnCancel;
private:	// User declarations
public:		// User declarations
  __fastcall TclMessageForm(TComponent* Owner);
  static bool __fastcall PostNew(TclMailMessage *Article);
  static bool __fastcall ReplyTo(TclMailMessage *Article);
};
//---------------------------------------------------------------------------
#endif
