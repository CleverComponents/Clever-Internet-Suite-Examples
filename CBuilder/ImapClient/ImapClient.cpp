//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
//---------------------------------------------------------------------------
USEFORM("..\Common\DemoBaseFormUnit.cpp", clDemoBaseForm);
USEFORM("main.cpp", Form1);
USEFORM("CopyDlg.cpp", CopyDialog);
USEFORM("MessageFrm.cpp", MessageForm);
USEFORM("NewFolderDlg.cpp", NewFolderDialog);
USEFORM("SearchDlg.cpp", SearchDialog);
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	try
	{
		Application->Initialize();
		Application->MainFormOnTaskBar = true;
		Application->CreateForm(__classid(TForm1), &Form1);
		Application->CreateForm(__classid(TCopyDialog), &CopyDialog);
		Application->CreateForm(__classid(TMessageForm), &MessageForm);
		Application->CreateForm(__classid(TNewFolderDialog), &NewFolderDialog);
		Application->CreateForm(__classid(TSearchDialog), &SearchDialog);
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
