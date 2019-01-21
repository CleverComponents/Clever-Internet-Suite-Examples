unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMailMessage, DemoBaseFormUnit, ExtCtrls;

type
  TMainForm = class(TclDemoBaseForm)
    Label1: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    memText: TMemo;
    memHtml: TMemo;
    Label5: TLabel;
    lbAttachments: TListBox;
    btnAdd: TButton;
    Label6: TLabel;
    edtPickup: TEdit;
    btnClear: TButton;
    btnSend: TButton;
    btnNew: TButton;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    edtFrom: TEdit;
    edtToList: TEdit;
    edtSubject: TEdit;
    OpenDialog: TOpenDialog;
    clMailMessage: TclMailMessage;
    procedure btnAddClick(Sender: TObject);
    procedure btnClearClick(Sender: TObject);
    procedure btnNewClick(Sender: TObject);
    procedure btnSendClick(Sender: TObject);
  private
    function GenerateFileName(const APath: string): string;
    { Private declarations }
  public
    { Public declarations }
  end;

var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnAddClick(Sender: TObject);
begin
  if OpenDialog.Execute() then
  begin
    lbAttachments.Items.Add(OpenDialog.FileName);
  end;
end;

procedure TMainForm.btnClearClick(Sender: TObject);
begin
  lbAttachments.Items.Clear();
end;

procedure TMainForm.btnNewClick(Sender: TObject);
begin
  edtFrom.Text := '';
  edtToList.Text := '';
  edtSubject.Text := '';
  memText.Lines.Clear();
  memHtml.Lines.Clear();
  memHtml.Lines.Add('<html>');
  memHtml.Lines.Add('<body>');
  memHtml.Lines.Add('</body>');
  memHtml.Lines.Add('</html>');
  lbAttachments.Items.Clear();
end;

function TMainForm.GenerateFileName(const APath: string): string;
begin
  Result := APath;
  if (Result <> '') and (Result[Length(Result)] <> '\') then
  begin
    Result := Result + '\';
  end;
  Result := Result + IntToStr(Round(Now() * 10000000000)) + IntToStr(Random(1000)) + '.eml';
end;

procedure TMainForm.btnSendClick(Sender: TObject);
begin
  clMailMessage.BuildMessage(memText.Text, memHtml.Text, nil, lbAttachments.Items);
  clMailMessage.From.FullAddress := edtFrom.Text;
  clMailMessage.ToList.EmailAddresses := edtToList.Text;
  clMailMessage.Subject := edtSubject.Text;
  clMailMessage.MessageSource.SaveToFile(GenerateFileName(edtPickup.Text));
  ShowMessage('The message has been queued for sending by the Microsoft SMTP service.');
end;

end.
