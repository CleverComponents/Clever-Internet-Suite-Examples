//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clMC"
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
  if (clSmtp1->Active) return;

  clSmtp1->Server = edtServer->Text;
  clSmtp1->Port = StrToInt(edtPort->Text);

  clSmtp1->UserName = edtUser->Text;
  clSmtp1->Password = edtPassword->Text;

  if (cbUseTLS->Checked) {
    clSmtp1->UseTLS = ctAutomatic;
  }
  else {
    clSmtp1->UseTLS = ctNone;
  }

  clSmtp1->Open();
  __try {
    clMailMessage1->BuildMessage(memBody->Text, "");
    clMailMessage1->From->FullAddress = edtFrom->Text;
    clMailMessage1->ToList->EmailAddresses = edtTo->Text;
    clMailMessage1->Subject = edtSubject->Text;

    clSmtp1->Send(clMailMessage1);

    ShowMessage("The message was sent successfully.");
  }
  __finally {
    clSmtp1->Close();
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clSmtp1VerifyServer(TObject *Sender,
      TclCertificate *ACertificate, const UnicodeString AStatusText,
      int AStatusCode, bool &AVerified)
{
  if (!AVerified && (MessageDlg(AStatusText + "\r\n Do you wish to proceed ?",
    mtWarning, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)) {
    AVerified = true;
  }
}
//---------------------------------------------------------------------------

