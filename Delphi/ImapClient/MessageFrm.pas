unit MessageFrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clMailMessage;

type
  TMessageForm = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtFrom: TEdit;
    edtTo: TEdit;
    edtSubject: TEdit;
    memBody: TMemo;
    btnAppend: TButton;
    btnCancel: TButton;
  private
    { Private declarations }
  public
    class procedure ShowMessage(AMsg: TclMailMessage);
    class function ComposeMessage(AMsg: TclMailMessage): Boolean;
    { Public declarations }
  end;

var
  MessageForm: TMessageForm;

implementation

{$R *.dfm}

{ TMessageForm }

class function TMessageForm.ComposeMessage(AMsg: TclMailMessage): Boolean;
var
  dlg: TMessageForm;
begin
  dlg := TMessageForm.Create(nil);
  try
    dlg.btnAppend.Visible := True;
    dlg.btnCancel.Caption := 'Cancel';

    dlg.edtFrom.ReadOnly := False;
    dlg.edtTo.ReadOnly := False;
    dlg.edtSubject.ReadOnly := False;
    dlg.memBody.ReadOnly := False;

    dlg.edtFrom.Text := 'clevertester@company.mail';
    dlg.edtTo.Text := 'clevertester@company.mail';
    dlg.edtSubject.Text := 'Test Subject';
    dlg.memBody.Text := 'Test Body';

    Result := (dlg.ShowModal() = mrOk);

    if Result then
    begin
      AMsg.BuildMessage(dlg.memBody.Lines.Text, '');
      AMsg.From.FullAddress := dlg.edtFrom.Text;
      AMsg.ToList.EmailAddresses := dlg.edtTo.Text;
      AMsg.Subject := dlg.edtSubject.Text;
    end;
  finally
    dlg.Free();
  end;
end;

class procedure TMessageForm.ShowMessage(AMsg: TclMailMessage);
var
  dlg: TMessageForm;
begin
  dlg := TMessageForm.Create(nil);
  try
    dlg.btnAppend.Visible := False;
    dlg.btnCancel.Caption := 'Close';

    dlg.edtFrom.ReadOnly := True;
    dlg.edtTo.ReadOnly := True;
    dlg.edtSubject.ReadOnly := True;
    dlg.memBody.ReadOnly := True;

    dlg.edtFrom.Color := clWindow;
    dlg.edtTo.Color := clWindow;
    dlg.edtSubject.Color := clWindow;
    dlg.memBody.Color := clWindow;

    dlg.edtFrom.Text := AMsg.From.FullAddress;
    dlg.edtTo.Text := AMsg.ToList.EmailAddresses;
    dlg.edtSubject.Text := AMsg.Subject;
    dlg.memBody.Lines := AMsg.MessageText;

    dlg.ShowModal();
  finally
    dlg.Free();
  end;
end;

end.
