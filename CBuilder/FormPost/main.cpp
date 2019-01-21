//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clHttp"
#pragma link "clHttpRequest"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnSubmitClick(TObject *Sender)
{
  if (clHttp1->Active) return;

  clHttpRequest->FormFields["Name"]->FieldValue = edtName->Text;
  clHttpRequest->FormFields["Birthdate"]->FieldValue = edtBirthdate->Text;
  clHttpRequest->FormFields["Account"]->FieldValue = edtAccount->Text;

  TStream *response = new TMemoryStream();
  __try {
	clHttp1->Post(edtHost->Text, clHttpRequest, response);

	response->Position = 0;
	Memo1->Lines->LoadFromStream(response);
  }
  __finally {
	delete response;
	clHttp1->Close();
  }

  ShowMessage("Process completed successfully.");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCloseQuery(TObject *, bool &CanClose)
{
  CanClose = !clHttp1->Active;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnViewClick(TObject *)
{
  AnsiString s = edtViewPage->Text;//use AnsiString
  ShellExecute(0, "open", s.c_str(), NULL, NULL, SW_RESTORE);
}
//---------------------------------------------------------------------------

