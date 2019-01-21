//---------------------------------------------------------------------------

#ifndef createfrmH
#define createfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TCreateCertForm : public TForm
{
__published:	// IDE-managed Components
  TButton *btnOK;
  TButton *btnCancel;
  TLabel *Label3;
  TEdit *edtStoreName;
  TLabel *Label1;
  TEdit *edtCN;
  TLabel *Label2;
  TLabel *Label4;
  TEdit *edtSerial;
  TEdit *edtValidFrom;
  TEdit *edtValidTo;
  TLabel *Label5;
  TLabel *Label6;
  TLabel *Label7;
  TLabel *Label8;
  TLabel *Label9;
  TLabel *Label10;
  TEdit *edtO;
  TEdit *edtOU;
  TEdit *edtL;
  TEdit *edtC;
  TEdit *edtE;
  TLabel *Label11;
  TEdit *edtKeyName;
  TLabel *Label12;
  TEdit *edtKeyLength;
  TLabel *Label13;
  TCheckBox *cbServerAuth;
  TCheckBox *cbClientAuth;
  TCheckBox *cbCodeSigning;
  TCheckBox *cbEmailProtection;
  TLabel *Label14;
  TEdit *edtFriendlyName;
  TCheckBox *cbAll;
  void __fastcall FormCreate(TObject *Sender);
	void __fastcall cbAllClick(TObject *Sender);
	void __fastcall cbServerAuthClick(TObject *Sender);
private:	// User declarations
  bool FInProgress;
public:		// User declarations
  __fastcall TCreateCertForm(TComponent* Owner);
  UnicodeString __fastcall BuildSubjectString();
};
//---------------------------------------------------------------------------
extern PACKAGE TCreateCertForm *CreateCertForm;
//---------------------------------------------------------------------------
#endif
