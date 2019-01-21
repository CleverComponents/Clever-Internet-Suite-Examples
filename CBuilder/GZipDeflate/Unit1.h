//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clGZip.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnCompress;
  TButton *btnUncompress;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TLabel *Label4;
  TEdit *edtSource;
  TButton *btnSource;
  TEdit *edtDestination;
  TButton *btnDestination;
  TOpenDialog *OpenDialog1;
  TSaveDialog *SaveDialog1;
  TclGZip *clGZip1;
  TProgressBar *ProgressBar1;
  void __fastcall btnCompressClick(TObject *Sender);
  void __fastcall btnUncompressClick(TObject *Sender);
  void __fastcall btnSourceClick(TObject *Sender);
  void __fastcall btnDestinationClick(TObject *Sender);
        void __fastcall clGZip1Progress(TObject *Sender,
          __int64 ABytesProceed, __int64 ATotalBytes);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
