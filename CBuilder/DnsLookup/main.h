//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clDnsQuery.hpp>
#include <clUdpClient.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TEdit *edtDnsServer;
  TLabel *Label2;
  TComboBox *cbNameType;
  TLabel *Label3;
  TLabel *Label4;
  TEdit *edtTimeOut;
  TEdit *edtName;
  TButton *btnResolve;
  TclDnsQuery *clDnsQuery1;
  TLabel *Label5;
  TMemo *memResult;
  TLabel *Label6;
  TEdit *edtPort;
  void __fastcall btnResolveClick(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
private:	// User declarations
  void __fastcall FillMXResult();
  void __fastcall FillHostResult();
  void __fastcall FillNameServerResult();
  void __fastcall FillAliasResult();
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
