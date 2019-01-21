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
#pragma link "clOAuth"
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

  clOAuth1->AuthUrl = "https://accounts.google.com/o/oauth2/auth";
  clOAuth1->TokenUrl = "https://accounts.google.com/o/oauth2/token";
  clOAuth1->RedirectUrl = "http://localhost";
  clOAuth1->ClientID = "421475025220-6khpgoldbdsi60fegvjdqk2bk4v19ss2.apps.googleusercontent.com";
  clOAuth1->ClientSecret = "_4HJyAVUmH_iVrPB8pOJXjR1";
  clOAuth1->Scope = "https://mail.google.com/";

  clSmtp1->Server = "smtp.gmail.com";
  clSmtp1->Port = 587;
  clSmtp1->UseTLS = ctExplicit;

  clSmtp1->UserName = edtFrom->Text;

  clSmtp1->Authorization = clOAuth1->GetAuthorization();

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
