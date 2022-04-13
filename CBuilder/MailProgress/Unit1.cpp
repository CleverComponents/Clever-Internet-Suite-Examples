//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clPop3"
#pragma link "clSmtp"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma link "clTcpCommandClient"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnSendClick(TObject *Sender)
{
  if (clSMTP1->Active || clPOP31->Active)
    throw new Exception("Message sending / retrieving is in progress");

  TStrings *attachments = new TStringList();
  __try {
    attachments->Add(edtAttachment->Text);
    clMailMessage1->BuildMessage(memBody->Lines->Text, //text body
      "<html><body><p>" + memBody->Lines->Text + "</p></body></html>", //html body
      NULL, //images
      attachments); //attachments
  }
  __finally {
    delete attachments;
  }

  clMailMessage1->Subject = "Message Subject";
  clMailMessage1->From->FullAddress = edtFrom->Text;
  clMailMessage1->ToList->EmailAddresses = edtTo->Text;

  ProgressBar1->Position = 0;
  lblProgress->Caption = "%";

  clSMTP1->Server = edtServer->Text;
  clSMTP1->UserName = edtUser->Text;
  clSMTP1->Password = edtPassword->Text;
  clSMTP1->Open();
  __try {
    clSMTP1->Send(clMailMessage1);
  }
  __finally {
    clSMTP1->Close();
  }

  lblProgress->Caption = "100 %";

  ShowMessage("Done");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnReceiveClick(TObject *Sender)
{
  if (clSMTP1->Active || clPOP31->Active)
    throw new Exception("Message sending / retrieving is in progress");

  ProgressBar1->Position = 0;
  lblProgress->Caption = "%";

  clPOP31->Server = edtServer->Text;
  clPOP31->UserName = edtUser->Text;
  clPOP31->Password = edtPassword->Text;
  clPOP31->Open();
  __try {
    if (clPOP31->MessageCount == 0)
      throw new Exception("There are no messages in the mailbox");

    clPOP31->Retrieve(1, clMailMessage1); //retrieve first mail message

    edtFrom->Text = clMailMessage1->From->FullAddress;
    edtTo->Text = Trim(clMailMessage1->ToList->EmailAddresses);
    memBody->Lines = clMailMessage1->MessageText;
  }
  __finally {
    clPOP31->Close();
  }

  lblProgress->Caption = "100 %";

  ShowMessage("Done");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClick(TObject *Sender)
{
  clPOP31->Close();
  clSMTP1->Close();
}
//---------------------------------------------------------------------------


void __fastcall TForm1::btnBrowseClick(TObject *Sender)
{
  if (OpenDialog1->Execute())
    edtAttachment->Text = OpenDialog1->FileName;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clMailProgress(TObject *Sender,
      __int64 ABytesProceed, __int64 ATotalBytes)
{
  ProgressBar1->Max = ATotalBytes;
  ProgressBar1->Position = ABytesProceed;
  lblProgress->Caption = IntToStr((int)floor((double)ProgressBar1->Position / ProgressBar1->Max * 100)) + " %";
}
//---------------------------------------------------------------------------


void __fastcall TForm1::clMailMessage1SaveAttachment(TObject *Sender,
	  TclAttachmentBody *ABody, UnicodeString &AFileName, TStream *&AData,
	  bool &Handled)
{
  edtAttachment->Text = ABody->FileName;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clMailMessage1EncodingProgress(TObject *Sender,
	  TclMessageBody *ABody, __int64 ABytesProceed, __int64 ATotalBytes)
{
  Application->ProcessMessages();
}
//---------------------------------------------------------------------------

