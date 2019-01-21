//---------------------------------------------------------------------------

#ifndef DemoBaseFormUnitH
#define DemoBaseFormUnitH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
//---------------------------------------------------------------------------
class TclDemoBaseForm : public TForm
{
__published:	// IDE-managed Components
	TPanel *pnlLogo;
	TImage *imLogoLeft;
	TImage *imLogoMiggle;
	TImage *imLogoRight;
	TPanel *pnlMain;
	void __fastcall imLogoLeftClick(TObject *Sender);
protected:
	virtual AnsiString GetLink();
public:		// User declarations
	__fastcall TclDemoBaseForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TclDemoBaseForm *clDemoBaseForm;
//---------------------------------------------------------------------------
#endif
