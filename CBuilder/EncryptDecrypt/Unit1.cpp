//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "getcert.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clEncryptor"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnEncryptClick(TObject *Sender)
{
  TGetCertDialog *dlg = new TGetCertDialog(NULL);
  __try {
    dlg->Caption = "Get encryption certificate";
    if(dlg->ShowModal() == mrOk) {
      clEncryptor1->EncryptStore = dlg->edtStore->Text;
      clEncryptor1->EncryptCertificate = dlg->edtEmail->Text;
    }
  }
  __finally {
      delete dlg;
  }

  clEncryptor1->Encrypt(edtSource->Text, edtDestination->Text);

  ShowMessage(Format("The file %s was encrypted and stored to %s", ARRAYOFCONST((edtSource->Text, edtDestination->Text))));
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDecryptClick(TObject *Sender)
{
  TGetCertDialog * dlg = new TGetCertDialog(NULL);
  __try {
    dlg->Caption = "Get encryption certificate";
    if(dlg->ShowModal() == mrOk) {
      clEncryptor1->EncryptStore = dlg->edtStore->Text;
      clEncryptor1->EncryptCertificate = dlg->edtEmail->Text;
    }
  }
  __finally {
      delete dlg;
  }

  clEncryptor1->Decrypt(edtSource->Text, edtDestination->Text);

  ShowMessage(Format("The file %s was decrypted and stored to %s", ARRAYOFCONST((edtSource->Text, edtDestination->Text))));
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


void __fastcall TForm1::clEncryptor1Progress(TObject *Sender,
      __int64 ABytesProceed, __int64 ATotalBytes)
{
  ProgressBar1->Max = ATotalBytes;
  ProgressBar1->Position = ABytesProceed;
}
//---------------------------------------------------------------------------

