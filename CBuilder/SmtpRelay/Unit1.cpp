//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "relayfrm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clSmtp"
#pragma link "clSmtpRelay"
#pragma link "clTcpClient"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clSmtp"
#pragma link "clSmtpRelay"
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

void __fastcall TForm1::ShowResults(void)
{
  TRelayStatusForm *relayStatus = new TRelayStatusForm(NULL);
  __try {
    for (int i = 0; i < clSmtpRelay1->StatusList->Count; i++) {
      relayStatus->Memo1->Lines->Add("======  " + clSmtpRelay1->StatusList->Items[i]->Domain + "  ======");
      relayStatus->Memo1->Lines->Add("Mail server: " + clSmtpRelay1->StatusList->Items[i]->MailServer);
      relayStatus->Memo1->Lines->Add("Status: " + (UnicodeString)(clSmtpRelay1->StatusList->Items[i]->IsSent ? "Sent" : "Not Sent"));
      relayStatus->Memo1->Lines->Add("Server response: " + clSmtpRelay1->StatusList->Items[i]->ResponseText);
      relayStatus->Memo1->Lines->Add("Error: " + clSmtpRelay1->StatusList->Items[i]->ErrorText);
      relayStatus->Memo1->Lines->Add("");
    }
    relayStatus->ShowModal();
  }
  __finally {
    delete relayStatus;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSendClick(TObject *Sender)
{
  btnSend->Enabled = false;
  __try {
    clMailMessage1->BuildMessage(memText->Lines->Text, "");
    clMailMessage1->From->FullAddress = edtSender->Text;
    clMailMessage1->ToList->EmailAddresses = edtRecipient->Text;
    clMailMessage1->Subject = edtSubject->Text;

    clSmtpRelay1->DnsServer = edtDNS->Text;
    clSmtpRelay1->TimeOut = StrToInt(edtDNSTimeOut->Text) * 1000;
    clSmtpRelay1->Send(clMailMessage1);

    ShowResults();
  }
  __finally {
    btnSend->Enabled = true;
  }
}
//---------------------------------------------------------------------------

