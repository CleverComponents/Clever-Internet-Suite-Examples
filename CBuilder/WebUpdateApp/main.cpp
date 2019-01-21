//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clWebUpdate"
#pragma resource "*.dfm"
TMainForm *MainForm;
static const char *starter = "starter.cmd";

//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::StatusBarMouseDown(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{
  StatusBar->Panels->Items[0]->Bevel = pbLowered;
  clWebUpdate->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::StatusBarMouseUp(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{
  StatusBar->Panels->Items[0]->Bevel = pbRaised;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clWebUpdateNoUpdatesFound(TObject *Sender)
{
  SetStatusBarCaption("There are no new updates available.");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clWebUpdateTerminating(TObject *Sender,
      bool &CanTerminate)
{
  CanTerminate = (MessageDlg("To apply the update you need to close the application. Do you want to close ?",
    mtConfirmation, TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCreate(TObject *Sender)
{
  DeleteFile(starter);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormDestroy(TObject *Sender)
{
  AddStartAppStatement();
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::SetStatusBarCaption(const UnicodeString AText)
{
  StatusBar->Panels->Items[1]->Text = AText;
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::AddUpdateScript(const UnicodeString AScript)
{
  TStrings *list = new TStringList();
  __try
  {
    UnicodeString s = AddTrailingBackSlash(ExtractFilePath(ParamStr(0))) + starter;

	if(FileExists(s))
      list->LoadFromFile(s);

    list->Text = list->Text + AScript;
    list->SaveToFile(s);
  }
  __finally
  {
    delete list;
  }
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::AddStartAppStatement(void)
{
  AddUpdateScript("start " + ExtractFileName(ParamStr(0)));
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::clWebUpdateRunUpdate(TObject *Sender,
      TStrings *AUpdateScript, bool ANeedTerminate, bool &CanRun,
      TclRunUpdateResult &Result, UnicodeString &AErrors)
{
  if(ANeedTerminate)
  {
	AddUpdateScript(AUpdateScript->Text);
    CanRun = false;
  }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clWebUpdateError(TObject *Sender, int UpdateNo,
      const UnicodeString Error, int ErrorCode)
{
  SetStatusBarCaption("Cannot download data from the web! \"" + Error + "\" error occured.");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::clWebUpdateDownloadProgress(TObject *Sender,
      int UpdateNo, __int64 Downloaded, __int64 Total)
{
  SetStatusBarCaption(Format("Downloading %d update: %d %% completed...",
    ARRAYOFCONST((UpdateNo + 1, (int)Downloaded * 100 / (int)Total))));
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartUpdateClick(TObject *Sender)
{
  SetStatusBarCaption("Checking for new updates...");
  clWebUpdate->Start(true);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnAboutClick(TObject *Sender)
{
  ShowMessage("Web Update Demo\r\nClever Components\r\nwww.clevercomponents.com");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnCloseClick(TObject *Sender)
{
  Close();
}
//---------------------------------------------------------------------------

