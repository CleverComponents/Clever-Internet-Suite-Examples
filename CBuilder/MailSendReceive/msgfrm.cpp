//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "msgfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TMessageForm *MessageForm;
//---------------------------------------------------------------------------
__fastcall TMessageForm::TMessageForm(TComponent* Owner)
  : TForm(Owner)
{
}
//---------------------------------------------------------------------------
