//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clDnsQuery"
#pragma link "clUdpClient"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnResolveClick(TObject *)
{
  clDnsQuery1->Server = edtDnsServer->Text;
  clDnsQuery1->Port = StrToInt(edtPort->Text);
  clDnsQuery1->TimeOut = StrToInt(edtTimeOut->Text) * 1000;

  switch (cbNameType->ItemIndex) {
    case 0: clDnsQuery1->ResolveMX(edtName->Text); break;
    case 1: clDnsQuery1->ResolveIP(edtName->Text); break;
    case 2: clDnsQuery1->ResolveHost(edtName->Text); break;
    case 3: clDnsQuery1->ResolveNS(edtName->Text); break;
  }

  edtDnsServer->Text = clDnsQuery1->Server;

  memResult->Lines->Clear();

  FillMXResult();
  FillHostResult();
  FillNameServerResult();
  FillAliasResult();

  ShowMessage("Done");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillMXResult()
{
  if (clDnsQuery1->MailServers->Count == 0) return;

  memResult->Lines->Add("====== Mail Servers ======");

  TclMailServerInfo *mx; 
  for (int i = 0; i < clDnsQuery1->MailServers->Count; i++) {
    mx = clDnsQuery1->MailServers->Items[i];
    memResult->Lines->Add(Format("%s, Preference %d, %s", ARRAYOFCONST((mx->Name, mx->Preference, mx->IPAddress))));
  }

  memResult->Lines->Add("");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillHostResult()
{
  if (clDnsQuery1->Hosts->Count == 0) return;

  memResult->Lines->Add("====== Hosts ======");

  for (int i = 0; i < clDnsQuery1->Hosts->Count; i++) {
    memResult->Lines->Add(clDnsQuery1->Hosts->Items[i]->Name + ", " + clDnsQuery1->Hosts->Items[i]->IPAddress);
  }

  memResult->Lines->Add("");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillNameServerResult()
{
  if (clDnsQuery1->NameServers->Count == 0) return;

  memResult->Lines->Add("====== Name Servers ======");
  memResult->Lines->AddStrings(clDnsQuery1->NameServers);
  memResult->Lines->Add("");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FillAliasResult()
{
  if (clDnsQuery1->Aliases->Count == 0) return;

  memResult->Lines->Add("====== Aliases ======");
  memResult->Lines->AddStrings(clDnsQuery1->Aliases);
  memResult->Lines->Add("");
}
//---------------------------------------------------------------------------


void __fastcall TForm1::FormCreate(TObject *)
{
  cbNameType->ItemIndex = 1;
}
//---------------------------------------------------------------------------


