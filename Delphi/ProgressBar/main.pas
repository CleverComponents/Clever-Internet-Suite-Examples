unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, ComCtrls, CommCtrl, clProgressBar, Buttons, clResourceState, DemoBaseFormUnit;

type
  TForm1 = class(TclDemoBaseForm)
    btnOne: TButton;
    btnTwo: TButton;
    btnThree: TButton;
    btnInit: TButton;
    ListView: TListView;
    clProgressBar1: TclProgressBar;
    clProgressBar2: TclProgressBar;
    clProgressBar3: TclProgressBar;
    clProgressBar4: TclProgressBar;
    clProgressBar5: TclProgressBar;
    clListViewProgressBar1: TclProgressBar;
    clListViewProgressBar2: TclProgressBar;
    clListViewProgressBar3: TclProgressBar;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Bevel1: TBevel;
    Bevel2: TBevel;
    procedure FormCreate(Sender: TObject);
    procedure btnInitClick(Sender: TObject);
    procedure btnOneClick(Sender: TObject);
    procedure btnTwoClick(Sender: TObject);
    procedure btnThreeClick(Sender: TObject);
    procedure ListViewCustomDrawSubItem(Sender: TCustomListView;
      Item: TListItem; SubItem: Integer; State: TCustomDrawState;
      var DefaultDraw: Boolean);
    procedure clListViewProgressBar1Changed(Sender: TObject);
  private
    procedure UpdateProgressBars;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
begin
  btnInitClick(nil);
end;

procedure TForm1.UpdateProgressBars;
begin
  clProgressBar2.ResourceState.Assign(clProgressBar1.ResourceState);
  clProgressBar3.ResourceState.Assign(clProgressBar1.ResourceState);
  clProgressBar4.ResourceState.Assign(clProgressBar1.ResourceState);
  clProgressBar5.ResourceState.Assign(clProgressBar1.ResourceState);
  clListViewProgressBar1.ResourceState.Assign(clProgressBar1.ResourceState);
  clListViewProgressBar2.ResourceState.Assign(clProgressBar1.ResourceState);
  clListViewProgressBar3.ResourceState.Assign(clProgressBar1.ResourceState);
end;

procedure TForm1.btnInitClick(Sender: TObject);
begin
{
  We emulate resource state changing
  just like it occurs during the downloading process begins
}

  clProgressBar1.ResourceState.Clear();
  clProgressBar1.ResourceState.Init(5, 5000);

  UpdateProgressBars();
end;

procedure TForm1.btnOneClick(Sender: TObject);
begin
{
  We emulate resource state changing
  just like it occurs during the downloading process goes
}
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[0], 120);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[1], 100);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[2], 50);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[3], 200);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[4], 130);
  clProgressBar1.ResourceState.UpdateStatus(clProgressBar1.ResourceState[0], psProcess);
  clProgressBar1.ResourceState.UpdateStatus(clProgressBar1.ResourceState[1], psErrors);
  clProgressBar1.ResourceState.UpdateStatus(clProgressBar1.ResourceState[3], psFailed);

  UpdateProgressBars();
end;

procedure TForm1.btnTwoClick(Sender: TObject);
begin
{
  We emulate resource state changing
  just like it occurs during the downloading process goes
}
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[0], 600);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[1], 340);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[2], 500);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[3], 800);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[4], 250);

  UpdateProgressBars();
end;

procedure TForm1.btnThreeClick(Sender: TObject);
begin
{
  We emulate resource state changing
  just like it occurs during the downloading process done
}
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[0], 1000);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[1], 1000);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[2], 1000);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[3], 1000);
  clProgressBar1.ResourceState.UpdateProceed(clProgressBar1.ResourceState[4], 1000);

  UpdateProgressBars();
end;

procedure TForm1.ListViewCustomDrawSubItem(Sender: TCustomListView;
  Item: TListItem; SubItem: Integer; State: TCustomDrawState;
  var DefaultDraw: Boolean);
var
  R: TRect;
begin
  if not ((Item.Index in [0, 2, 4]) and (SubItem = 1)) then Exit;
  ListView_GetSubItemRect(Item.Handle, Item.Index, SubItem, LVIR_BOUNDS, @R);
  case Item.Index of
    0: clListViewProgressBar1.Draw(clListViewProgressBar1.ResourceState, Sender.Canvas, R);
    2: clListViewProgressBar2.Draw(clListViewProgressBar2.ResourceState, Sender.Canvas, R);
    4: clListViewProgressBar3.Draw(clListViewProgressBar3.ResourceState, Sender.Canvas, R);
  end;
  DefaultDraw := False;
end;

procedure TForm1.clListViewProgressBar1Changed(Sender: TObject);
var
  R: TRect;
begin
  ListView_GetSubItemRect(ListView.Handle, 0, 1, LVIR_BOUNDS, @R);
  InvalidateRect(ListView.Handle, @R, False);
  ListView_GetSubItemRect(ListView.Handle, 2, 1, LVIR_BOUNDS, @R);
  InvalidateRect(ListView.Handle, @R, False);
  ListView_GetSubItemRect(ListView.Handle, 4, 1, LVIR_BOUNDS, @R);
  InvalidateRect(ListView.Handle, @R, False);
end;

end.
