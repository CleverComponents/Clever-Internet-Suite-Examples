unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, DemoBaseFormUnit, clAsyncClient, clSocket, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtHost: TEdit;
    Label2: TLabel;
    edtPort: TEdit;
    btnConnect: TButton;
    memTerminal: TMemo;
    clAsyncClient1: TclAsyncClient;
    procedure clAsyncClient1Connect(Sender: TObject);
    procedure clAsyncClient1Disconnect(Sender: TObject);
    procedure clAsyncClient1Read(Sender: TObject);
    procedure btnConnectClick(Sender: TObject);
    procedure memTerminalKeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnConnectClick(Sender: TObject);
begin
  clAsyncClient1.Server := edtHost.Text;
  clAsyncClient1.Port := StrToInt(edtPort.Text);
  clAsyncClient1.Open();
  FocusControl(memTerminal);
end;

procedure TForm1.clAsyncClient1Connect(Sender: TObject);
begin
  memTerminal.Lines.Add('Connected to '
    + clAsyncClient1.Server + '(' + IntToStr(clAsyncClient1.Port) + ')');
end;

procedure TForm1.clAsyncClient1Disconnect(Sender: TObject);
begin
  if not (csDestroying in ComponentState) then
  begin
    memTerminal.Lines.Add('Connection closed');
  end;
end;

procedure TForm1.clAsyncClient1Read(Sender: TObject);
var
  str: TStringStream;
begin
  str := TStringStream.Create('');
  try
    clAsyncClient1.ReadData(str);
    if (str.DataString <> '') then
    begin
      memTerminal.Lines.Add(Trim(str.DataString));
    end;
  finally
    str.Free();
  end;
end;

procedure TForm1.memTerminalKeyPress(Sender: TObject; var Key: Char);
var
  str: TStringStream;
  s: string;
begin
  if not clAsyncClient1.Active then Exit;

  s := Key;
  if (Key = #13) then
  begin
    s := #13#10;
  end;


  str := TStringStream.Create(s);
  try
    clAsyncClient1.WriteData(str);
  finally
    str.Free();
  end;
end;

end.
