//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
//---------------------------------------------------------------------------
USEFORM("..\Common\DemoBaseFormUnit.cpp", clDemoBaseForm);
USEFORM("main.cpp", Form1);
USEFORM("createfrm.cpp", CreateCertForm);
USEFORM("exportfrm.cpp", ExportForm);
USEFORM("importfrm.cpp", ImportForm);
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	try
	{
		Application->Initialize();
		Application->MainFormOnTaskBar = true;
		Application->CreateForm(__classid(TForm1), &Form1);
		Application->CreateForm(__classid(TCreateCertForm), &CreateCertForm);
		Application->CreateForm(__classid(TExportForm), &ExportForm);
		Application->CreateForm(__classid(TImportForm), &ImportForm);
		Application->Run();
	}
	catch (Exception &exception)
	{
		Application->ShowException(&exception);
	}
	catch (...)
	{
		try
		{
			throw Exception("");
		}
		catch (Exception &exception)
		{
			Application->ShowException(&exception);
		}
	}
	return 0;
}
//---------------------------------------------------------------------------
