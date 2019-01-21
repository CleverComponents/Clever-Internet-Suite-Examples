//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include <Math.h>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clMailMessage"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
  randomize();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnAddClick(TObject *Sender)
{
  if(OpenDialog->Execute())
  {
    lbAttachments->Items->Add(OpenDialog->FileName);
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnClearClick(TObject *Sender)
{
  lbAttachments->Items->Clear();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnNewClick(TObject *Sender)
{
  edtFrom->Text = "";
  edtToList->Text = "";
  edtSubject->Text = "";
  memText->Lines->Clear();
  memHtml->Lines->Clear();
  memHtml->Lines->Add("<html>");
  memHtml->Lines->Add("<body>");
  memHtml->Lines->Add("</body>");
  memHtml->Lines->Add("</html>");
  lbAttachments->Items->Clear();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnSendClick(TObject *Sender)
{
  clMailMessage->BuildMessage(memText->Text, memHtml->Text, NULL, lbAttachments->Items);
  clMailMessage->From->FullAddress = edtFrom->Text;
  clMailMessage->ToList->EmailAddresses = edtToList->Text;
  clMailMessage->Subject = edtSubject->Text;
  clMailMessage->MessageSource->SaveToFile(GenerateFileName(edtPickup->Text));
  ShowMessage("The message has been queued for sending by the Microsoft SMTP service.");
}
//---------------------------------------------------------------------------

UnicodeString __fastcall TMainForm::GenerateFileName(const UnicodeString APath)
{
  UnicodeString result = APath;
  if((result != "") && (result[result.Length()] != '\\'))
  {
    result += "\\";
  }
  result += IntToStr((int)floor(((double)Now()) * 100000000)) + IntToStr(random(1000)) + ".eml";
  return result;
}
//---------------------------------------------------------------------------
