//---------------------------------------------------------------------------

#ifndef msgfrmH
#define msgfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TMessageForm : public TForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtFrom;
  TLabel *Label2;
  TEdit *edtTo;
  TLabel *Label3;
  TEdit *edtSubject;
  TMemo *memBody;
  TButton *btnSend;
  TButton *btnClose;
private:	// User declarations
public:		// User declarations
  __fastcall TMessageForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMessageForm *MessageForm;
//---------------------------------------------------------------------------
#endif
