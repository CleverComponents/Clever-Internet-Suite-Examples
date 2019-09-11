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
#pragma link "clHttpProxy"
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

  clHttpProxy1->Server = edtProxyServer->Text;
  clHttpProxy1->Port = StrToInt(edtProxyPort->Text);

  clSmtp1->Proxy = clHttpProxy1;

  clSmtp1->Server = edtServer->Text;
  clSmtp1->Port = StrToInt(edtPort->Text);
  clSmtp1->UserName = edtUser->Text;
  clSmtp1->Password = edtPassword->Text;

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


