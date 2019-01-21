//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clAsyncClient.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
	TLabel *Label1;
	TLabel *Label2;
	TEdit *edtPort;
	TEdit *edtHost;
	TButton *btnConnect;
	TMemo *memTerminal;
	TclAsyncClient *clAsyncClient1;
	void __fastcall clAsyncClient1Connect(TObject *Sender);
	void __fastcall clAsyncClient1Disconnect(TObject *Sender);
	void __fastcall clAsyncClient1Read(TObject *Sender);
	void __fastcall memTerminalKeyPress(TObject *Sender, char &Key);
	void __fastcall btnConnectClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
