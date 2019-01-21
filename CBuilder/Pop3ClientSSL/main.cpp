//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clPop3"
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
void __fastcall TForm1::btnConnectClick(TObject *Sender)
{
  if (clPop->Active) return;

  FCertificateVerified = false;

  clPop->Server = edtServer->Text;
  clPop->Port = StrToInt(edtPort->Text);
  clPop->UserName = edtUser->Text;
  clPop->Password = edtPassword->Text;

  if (cbUseTLS->Checked)
    clPop->UseTLS = ctAutomatic;
  else
    clPop->UseTLS = ctNone;

  clPop->Open();

  FillMessages();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDisconnectClick(TObject *Sender)
{
  lvMessages->Items->Clear();
  edtFrom->Text = "";
  edtSubject->Text = "";
  memBody->Lines->Clear();

  clPop->Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnViewClick(TObject *Sender)
{
  if (lvMessages->Selected == NULL) return;

  clPop->Retrieve((int)lvMessages->Selected->Data, clMailMessage);

  edtFrom->Text = clMailMessage->From->FullAddress;
  edtSubject->Text = clMailMessage->Subject;
  memBody->Lines = clMailMessage->MessageText;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDeleteClick(TObject *Sender)
{
  if (lvMessages->Selected == NULL) return;

  clPop->Delete((int)lvMessages->Selected->Data);
  lvMessages->Items->Delete(lvMessages->Selected->Index);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clPopVerifyServer(TObject *Sender,
      TclCertificate *ACertificate, const UnicodeString AStatusText,
      int AStatusCode, bool &AVerified)
{
  if (!AVerified)
    AVerified = FCertificateVerified;

  if (!AVerified && (MessageDlg(AStatusText + "\r\n Do you wish to proceed ?",
    mtWarning, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)) {
    AVerified = true;
    FCertificateVerified = true;
  }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillMessages(void)
{
  lvMessages->Items->BeginUpdate();
  __try {
    lvMessages->Items->Clear();

    TListItem *item;
    for (int i = 1; i <= clPop->MessageCount; i++) {
      clPop->RetrieveHeader(i, clMailMessage);

      item = lvMessages->Items->Add();
      item->Caption = clMailMessage->From->FullAddress;
      item->SubItems->Add(clMailMessage->Subject);
      item->SubItems->Add(DateTimeToStr(clMailMessage->Date));
      item->SubItems->Add(clPop->GetUID(i));
      item->Data = (void*)i;
    }
  }
  __finally {
    lvMessages->Items->EndUpdate();
  }
}
//---------------------------------------------------------------------------

