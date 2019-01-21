//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Dialogs.hpp>
#include <clMailMessage.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label3;
  TLabel *Label4;
  TMemo *memText;
  TMemo *memHtml;
  TLabel *Label5;
  TListBox *lbAttachments;
  TButton *btnAdd;
  TLabel *Label6;
  TEdit *edtPickup;
  TButton *btnClear;
  TButton *btnSend;
  TButton *btnNew;
  TLabel *Label7;
  TLabel *Label8;
  TLabel *Label9;
  TEdit *edtFrom;
  TEdit *edtToList;
  TEdit *edtSubject;
  TOpenDialog *OpenDialog;
  TclMailMessage *clMailMessage;
  void __fastcall btnAddClick(TObject *Sender);
  void __fastcall btnClearClick(TObject *Sender);
  void __fastcall btnNewClick(TObject *Sender);
  void __fastcall btnSendClick(TObject *Sender);
private:	// User declarations
  UnicodeString __fastcall GenerateFileName(const UnicodeString APath);
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
