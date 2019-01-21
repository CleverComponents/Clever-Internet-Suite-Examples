//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "clUpdateMgrForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clWebUpdate"
#pragma resource "*.dfm"
TMainForm *MainForm;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::btnEditClick(TObject *Sender)
{
  if(edtUpdateFile->Text == "")
    throw new Exception("The file name must be specified");

  clWebUpdate->UpdateInfo->LoadFromXml(edtUpdateFile->Text);
  if(TclUpdateMgrFrm::ShowEditor(clWebUpdate->UpdateInfo))
  {
    clWebUpdate->UpdateInfo->SaveToXml(edtUpdateFile->Text);
    ShowMessage(Format("The %s file has been updated", ARRAYOFCONST((edtUpdateFile->Text))));
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnCloseClick(TObject *Sender)
{
  Close();
}
//---------------------------------------------------------------------------

