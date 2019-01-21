//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clAsyncClient"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::clAsyncClient1Connect(TObject *Sender)
{
  memTerminal->Lines->Add("Connected to "
	+ clAsyncClient1->Server + "(" + IntToStr(clAsyncClient1->Port) + ")");
}
//---------------------------------------------------------------------------
void __fastcall TForm1::clAsyncClient1Disconnect(TObject *Sender)
{
  if (!ComponentState.Contains(csDestroying))
  {
	memTerminal->Lines->Add("Connection closed");
  }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::clAsyncClient1Read(TObject *Sender)
{
  UnicodeString s = "";
  TStringStream *str = new TStringStream(s);
  __try
  {
	clAsyncClient1->ReadData(str);
	if (str->DataString != "")
	{
	  memTerminal->Lines->Add(Trim(str->DataString));
	}
  }
  __finally
  {
	delete str;
  }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnConnectClick(TObject *Sender)
{
  clAsyncClient1->Server = edtHost->Text;
  clAsyncClient1->Port = StrToInt(edtPort->Text);
  clAsyncClient1->Open();
  FocusControl(memTerminal);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::memTerminalKeyPress(TObject *Sender, char &Key)
{
  if (!clAsyncClient1->Active) return;

  UnicodeString s = Key;
  if (Key == '\r')
  {
    s = "\r\n";
  }

  TStringStream *str = new TStringStream(s);
  __try
  {
    clAsyncClient1->WriteData(str);
  }
  __finally
  {
    delete str;
  }
}
//---------------------------------------------------------------------------

