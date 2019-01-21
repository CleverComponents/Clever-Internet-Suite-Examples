unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics,
  Controls, Forms, Dialogs, StdCtrls, clMailMessage,
  clTcpClient, clTcpClientTls, clTcpCommandClient, clMC, clPop3, clDkim, clDkimUtils, clCryptUtils, 
  DemoBaseFormUnit, ExtCtrls;

type
  TForm1 = class(TclDemoBaseForm)
    Label1: TLabel;
    edtServer: TEdit;
    Label2: TLabel;
    edtPort: TEdit;
    Label4: TLabel;
    edtUser: TEdit;
    Label5: TLabel;
    edtPassword: TEdit;
    btnCheckMail: TButton;
    lbMessages: TListBox;
    Label3: TLabel;
    clMailMessage1: TclMailMessage;
    clDkim1: TclDkim;
    clPop31: TclPop3;
    procedure btnCheckMailClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnCheckMailClick(Sender: TObject);
var
  i: Integer;
  result: string;
begin
  if (clPop31.Active) then Exit;

  clPop31.Server := edtServer.Text;
  clPop31.Port := StrToInt(edtPort.Text);
  clPop31.UserName := edtUser.Text;
  clPop31.Password := edtPassword.Text;

  lbMessages.Items.Clear();

  clPop31.Open();
  try
    for i := 1 to clPop31.MessageCount do
    begin
      try
        clPop31.Retrieve(i);

        if (clMailMessage1.Dkim.Signatures.Count > 0) then
        begin
          result := '( DKIM OK ) ';
        end else
        begin
          result := '( NO DKIM ) ';
        end;
      except
        on EclCryptError do result := '( DKIM FAIL ) ';
        on EclDkimError do result := '( DKIM FAIL ) ';
      end;

      lbMessages.Items.Add(result + clMailMessage1.Subject);
    end;
  finally
    clPop31.Close();
  end;

  ShowMessage('Done');
end;

end.
