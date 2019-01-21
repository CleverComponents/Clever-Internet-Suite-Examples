//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clGZip"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnCompressClick(TObject *Sender)
{
  clGZip1->Compress(edtSource->Text, edtDestination->Text);
  ShowMessage(Format("The file %s was deflated and stored to %s", ARRAYOFCONST((edtSource->Text, edtDestination->Text))));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnUncompressClick(TObject *Sender)
{
  TStream *source = new TFileStream(edtSource->Text, fmOpenRead);
  TStream *dest = new TFileStream(edtDestination->Text, fmCreate);
  __try {
    clGZip1->Uncompress(source, dest);
  }
  __finally {
    delete dest;
    delete source;
  }
  ShowMessage(Format("The file %s was inflated and stored to %s", ARRAYOFCONST((edtSource->Text, edtDestination->Text))));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSourceClick(TObject *Sender)
{
  if (OpenDialog1->Execute())
    edtSource->Text = OpenDialog1->FileName;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDestinationClick(TObject *Sender)
{
  if (SaveDialog1->Execute())
    edtDestination->Text = SaveDialog1->FileName;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::clGZip1Progress(TObject *Sender,
      __int64 ABytesProceed, __int64 ATotalBytes)
{
  ProgressBar1->Max = ATotalBytes;
  ProgressBar1->Position = ABytesProceed;
}
//---------------------------------------------------------------------------

