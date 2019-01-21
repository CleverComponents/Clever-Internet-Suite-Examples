//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clDkim"
#pragma link "clMailMessage"
#pragma link "clMC"
#pragma link "clSmtp"
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
void __fastcall TForm1::FormShow(TObject *Sender)
{
	edtSignFields->Text = clDkim1->SignedHeaderFields->CommaText;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnLoadKeyClick(TObject *Sender)
{
	if (OpenDialog1->Execute())
	{
		clDkim1->ImportPrivateKey(OpenDialog1->FileName);

		memPrivateKey->Lines->LoadFromFile(OpenDialog1->FileName);

		edtDnsTxtName->Text = "";
		edtDnsTxtValue->Text = "";
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnGenerateKeyClick(TObject *Sender)
{
	clDkim1->Domain = edtDkimDomain->Text;
	clDkim1->Selector = edtDkimSelector->Text;

	clDkim1->GenerateSigningKey(512);

	clDkim1->ExportPrivateKey(memPrivateKey->Lines);

	clDkim1->GenerateDnsRecord();

	edtDnsTxtName->Text = clDkim1->DnsRecord->Name;
	edtDnsTxtValue->Text = clDkim1->DnsRecord->Value;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSendClick(TObject *Sender)
{
	if (clSmtp1->Active) return;

	clDkim1->Domain = edtDkimDomain->Text;
	clDkim1->Selector = edtDkimSelector->Text;
	clDkim1->SignedHeaderFields->CommaText = edtSignFields->Text;

	clDkim1->ImportPrivateKey(memPrivateKey->Lines);

	clMailMessage1->BuildMessage(memBody->Text, "");
	clMailMessage1->From->FullAddress = edtFrom->Text;
	clMailMessage1->ToList->EmailAddresses = edtTo->Text;
	clMailMessage1->Subject = edtSubject->Text;

	clSmtp1->Server = edtServer->Text;
	clSmtp1->Port = StrToInt(edtPort->Text);

	clSmtp1->UserName = edtUser->Text;
	clSmtp1->Password = edtPassword->Text;

	clSmtp1->Open();
	__try
	{
		clSmtp1->Send(clMailMessage1);
	}
	__finally
	{
		clSmtp1->Close();
	}

	ShowMessage("The signed message was sent successfully.");
}
//---------------------------------------------------------------------------

