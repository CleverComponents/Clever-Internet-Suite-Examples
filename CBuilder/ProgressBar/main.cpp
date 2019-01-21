//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "DemoBaseFormUnit"
#pragma link "clProgressBar"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
  : TclDemoBaseForm(Owner)
{
}
//---------------------------------------------------------------------------


void __fastcall TForm1::FormCreate(TObject *Sender)
{
  btnInitClick(NULL);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnInitClick(TObject *Sender)
{
/*
  We emulate resource state changing
  just like it occurs during the downloading process begins
*/

  clProgressBar1->ResourceState->Clear();
  clProgressBar1->ResourceState->Init(5, 5000);

  UpdateProgressBars();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnOneClick(TObject *Sender)
{
/*
  We emulate resource state changing
  just like it occurs during the downloading process goes
*/

  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[0], 120);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[1], 100);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[2], 50);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[3], 200);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[4], 130);
  clProgressBar1->ResourceState->UpdateStatus(clProgressBar1->ResourceState->Items[0], psProcess);
  clProgressBar1->ResourceState->UpdateStatus(clProgressBar1->ResourceState->Items[1], psErrors);
  clProgressBar1->ResourceState->UpdateStatus(clProgressBar1->ResourceState->Items[3], psFailed);

  UpdateProgressBars();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnTwoClick(TObject *Sender)
{
/*
  We emulate resource state changing
  just like it occurs during the downloading process goes
*/

  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[0], 600);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[1], 340);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[2], 500);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[3], 800);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[4], 250);

  UpdateProgressBars();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnThreeClick(TObject *Sender)
{
/*
  We emulate resource state changing
  just like it occurs during the downloading process done
*/

  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[0], 1000);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[1], 1000);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[2], 1000);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[3], 1000);
  clProgressBar1->ResourceState->UpdateProceed(clProgressBar1->ResourceState->Items[4], 1000);

  UpdateProgressBars();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ListViewCustomDrawSubItem(TCustomListView *Sender,
	  TListItem *Item, int SubItem, TCustomDrawState State,
	  bool &DefaultDraw)
{
  if (!(((Item->Index == 0) || (Item->Index == 2) || (Item->Index ==  4))
	&& (SubItem == 1))) return;
  TRect R;
  ListView_GetSubItemRect(Item->Handle, Item->Index, SubItem, LVIR_BOUNDS, &R);
  switch (Item->Index)
  {
	case 0: clListViewProgressBar1->Draw(clListViewProgressBar1->ResourceState, Sender->Canvas, R); break;
	case 2: clListViewProgressBar2->Draw(clListViewProgressBar2->ResourceState, Sender->Canvas, R); break;
	case 4: clListViewProgressBar3->Draw(clListViewProgressBar3->ResourceState, Sender->Canvas, R); break;
  }
  DefaultDraw = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::clListViewProgressBar1Changed(TObject *Sender)
{
  TRect R;
  ListView_GetSubItemRect(ListView->Handle, 0, 1, LVIR_BOUNDS, &R);
  InvalidateRect(ListView->Handle, &R, false);
  ListView_GetSubItemRect(ListView->Handle, 2, 1, LVIR_BOUNDS, &R);
  InvalidateRect(ListView->Handle, &R, false);
  ListView_GetSubItemRect(ListView->Handle, 4, 1, LVIR_BOUNDS, &R);
  InvalidateRect(ListView->Handle, &R, false);
}
//---------------------------------------------------------------------------

void TForm1::UpdateProgressBars(void)
{
  clProgressBar2->ResourceState->Assign(clProgressBar1->ResourceState);
  clProgressBar3->ResourceState->Assign(clProgressBar1->ResourceState);
  clProgressBar4->ResourceState->Assign(clProgressBar1->ResourceState);
  clProgressBar5->ResourceState->Assign(clProgressBar1->ResourceState);
  clListViewProgressBar1->ResourceState->Assign(clProgressBar1->ResourceState);
  clListViewProgressBar2->ResourceState->Assign(clProgressBar1->ResourceState);
  clListViewProgressBar3->ResourceState->Assign(clProgressBar1->ResourceState);
}
//---------------------------------------------------------------------------

