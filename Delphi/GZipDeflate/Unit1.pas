unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clGZip, ComCtrls, DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    btnCompress: TButton;
    btnUncompress: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    edtSource: TEdit;
    btnSource: TButton;
    edtDestination: TEdit;
    btnDestination: TButton;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    clGZip1: TclGZip;
    ProgressBar1: TProgressBar;
    procedure btnSourceClick(Sender: TObject);
    procedure btnDestinationClick(Sender: TObject);
    procedure btnCompressClick(Sender: TObject);
    procedure btnUncompressClick(Sender: TObject);
    procedure clGZip1Progress(Sender: TObject; ABytesProceed, ATotalBytes: Int64);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSourceClick(Sender: TObject);
begin
  if OpenDialog1.Execute() then
  begin
    edtSource.Text := OpenDialog1.FileName;
  end;
end;

procedure TForm1.btnDestinationClick(Sender: TObject);
begin
  if SaveDialog1.Execute() then
  begin
    edtDestination.Text := SaveDialog1.FileName;
  end;
end;

procedure TForm1.btnCompressClick(Sender: TObject);
begin
  clGZip1.Compress(edtSource.Text, edtDestination.Text);
  ShowMessage(Format('The file %s was deflated and stored to %s', [edtSource.Text, edtDestination.Text]));
end;

procedure TForm1.btnUncompressClick(Sender: TObject);
var
  source, dest: TStream;
begin
  source := TFileStream.Create(edtSource.Text, fmOpenRead);
  dest := TFileStream.Create(edtDestination.Text, fmCreate);
  try
    clGZip1.Uncompress(source, dest);
  finally
    dest.Free();
    source.Free();
  end;
  ShowMessage(Format('The file %s was inflated and stored to %s', [edtSource.Text, edtDestination.Text]));
end;

procedure TForm1.clGZip1Progress(Sender: TObject; ABytesProceed, ATotalBytes: Int64);
begin
  ProgressBar1.Max := ATotalBytes;
  ProgressBar1.Position := ABytesProceed;
end;

end.
