//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
//---------------------------------------------------------------------------
USEFORM("..\Common\DemoBaseFormUnit.cpp", clDemoBaseForm);
USEFORM("main.cpp", Form1);
USEFORM("CopyMove.cpp", CopyMoveForm);
USEFORM("ModifyProps.cpp", ModifyPropForm);
USEFORM("ViewProps.cpp", ViewPropsForm);
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	try
	{
		Application->Initialize();
		Application->MainFormOnTaskBar = true;
		Application->CreateForm(__classid(TForm1), &Form1);
		Application->CreateForm(__classid(TCopyMoveForm), &CopyMoveForm);
		Application->CreateForm(__classid(TModifyPropForm), &ModifyPropForm);
		Application->CreateForm(__classid(TViewPropsForm), &ViewPropsForm);
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
