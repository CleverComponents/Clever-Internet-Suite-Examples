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
#pragma link "clPop3"
#pragma link "clTcpClient"
#pragma link "clTcpClientTls"
#pragma link "clTcpCommandClient"
#pragma link "clCryptUtils"
#pragma link "clDkimUtils"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnCheckMailClick(TObject *Sender)
{
	if (clPop31->Active) return;

	clPop31->Server = edtServer->Text;
	clPop31->Port = StrToInt(edtPort->Text);
	clPop31->UserName = edtUser->Text;
	clPop31->Password = edtPassword->Text;

	lbMessages->Items->Clear();

	clPop31->Open();
	__try
	{
		for (int i = 1; i <= clPop31->MessageCount; i++)
		{
			String result = "";
			try
			{
				clPop31->Retrieve(i);

				result = (clMailMessage1->Dkim->Signatures->Count > 0) ? "( DKIM OK ) " : "( NO DKIM ) ";
			}
			catch (EclCryptError &)
			{
				result = "( DKIM FAIL ) ";
			}
			catch (EclDkimError &)
			{
				result = "( DKIM FAIL ) ";
			}

			lbMessages->Items->Add(result + clMailMessage1->Subject);
		}
	}
	__finally
	{
		clPop31->Close();
	}

	ShowMessage("Done");
}
//---------------------------------------------------------------------------


