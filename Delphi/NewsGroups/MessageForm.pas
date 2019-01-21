unit MessageForm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, clMailMessage, StdCtrls;

type
  TclMessageForm = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edtFrom: TEdit;
    edtSubject: TEdit;
    memText: TMemo;
    btnPost: TButton;
    btnCancel: TButton;
  private
    { Private declarations }
  public
    class function PostNew(Article: TclMailMessage): Boolean;
    class function ReplyTo(Article: TclMailMessage): Boolean;
  end;

implementation

{$R *.dfm}

{ TclMessageForm }

class function TclMessageForm.PostNew(Article: TclMailMessage): Boolean;
var
  dlg: TclMessageForm;
begin
  dlg := TclMessageForm.Create(nil);
  try
    Result := dlg.ShowModal() = mrOK;
    if Result then
    begin
      Article.BuildMessage(dlg.memText.Lines.Text, '');
      Article.Subject := dlg.edtSubject.Text;
      Article.From.FullAddress := dlg.edtFrom.Text;
    end;
  finally
    dlg.Free();
  end;
end;

class function TclMessageForm.ReplyTo(Article: TclMailMessage): Boolean;
var
  i: Integer;
  src: TStrings;
  refs: TStrings;
  dlg: TclMessageForm;
begin
  dlg := TclMessageForm.Create(nil);
  src := TStringList.Create();
  refs := TStringList.Create();
  try
    src.Assign(Article.MessageText);
    for i := 0 to src.Count - 1 do
    begin
      src[i] := '> ' + src[i];
    end;
    src.Insert(0, '');
    src.Insert(0, '');
    dlg.memText.Lines.Assign(src);

    if (Pos('Re:', Article.Subject) <> 1) then
    begin
      dlg.edtSubject.Text := 'Re: ' + Article.Subject;
    end;

    refs.Assign(Article.References);

    dlg.btnPost.Caption := 'Reply';

    Result := dlg.ShowModal() = mrOK;
    if Result then
    begin
      Article.BuildMessage(dlg.memText.Lines.Text, '');
      Article.Subject := dlg.edtSubject.Text;
      Article.From.FullAddress := dlg.edtFrom.Text;
      Article.References.Assign(refs);
    end;
  finally
    refs.Free();
    src.Free();
    dlg.Free();
  end;
end;

end.
