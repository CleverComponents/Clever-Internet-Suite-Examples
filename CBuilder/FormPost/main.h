//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clHttp.hpp>
#include <clHttpRequest.hpp>
#include <Dialogs.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include "clTcpClient.hpp"
#include "clTcpClientTls.hpp"
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtName;
  TButton *btnSubmit;
  TEdit *edtHost;
  TMemo *Memo1;
  TLabel *Label1;
  TLabel *Label2;
  TEdit *edtViewPage;
  TButton *btnView;
  TLabel *Label3;
  TEdit *edtBirthdate;
  TLabel *Label6;
  TEdit *edtAccount;
  TclHttpRequest *clHttpRequest;
  TclHttp *clHttp1;
  void __fastcall btnSubmitClick(TObject *Sender);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall btnViewClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
