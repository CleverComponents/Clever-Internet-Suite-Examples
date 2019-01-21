//---------------------------------------------------------------------------

#ifndef MessageFrmH
#define MessageFrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clMailMessage.hpp>
//---------------------------------------------------------------------------
class TMessageForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *edtFrom;
  TEdit *edtTo;
  TEdit *edtSubject;
  TMemo *memBody;
  TButton *btnAppend;
  TButton *btnCancel;
private:	// User declarations
public:		// User declarations
  __fastcall TMessageForm(TComponent* Owner);
  static void __fastcall ShowMessage(TclMailMessage *AMsg);
  static bool __fastcall ComposeMessage(TclMailMessage *AMsg);
};
//---------------------------------------------------------------------------
extern PACKAGE TMessageForm *MessageForm;
//---------------------------------------------------------------------------
#endif
