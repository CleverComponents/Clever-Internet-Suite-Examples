//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clEncryptor.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnEncrypt;
  TButton *btnDecrypt;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *edtSource;
  TButton *btnSource;
  TEdit *edtDestination;
  TButton *btnDestination;
  TOpenDialog *OpenDialog1;
  TSaveDialog *SaveDialog1;
  TProgressBar *ProgressBar1;
  TclEncryptor *clEncryptor1;
  void __fastcall btnSourceClick(TObject *Sender);
  void __fastcall btnDestinationClick(TObject *Sender);
  void __fastcall btnEncryptClick(TObject *Sender);
  void __fastcall btnDecryptClick(TObject *Sender);
  void __fastcall clEncryptor1Progress(TObject *Sender,
    __int64 ABytesProceed, __int64 ATotalBytes);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
