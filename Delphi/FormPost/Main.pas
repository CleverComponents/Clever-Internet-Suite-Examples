unit Main;
 
interface

uses
  Windows, SysUtils, Classes, Forms, Dialogs, StdCtrls, Controls, ShellAPI, clHttpRequest,
  clTcpClient, clHttp, clTcpClientTls, DemoBaseFormUnit, ExtCtrls, Graphics;

type
  TMainForm = class(TclDemoBaseForm)
    Label4: TLabel;
    Label5: TLabel;
    edtName: TEdit;
    btnSubmit: TButton;
    edtHost: TEdit;
    Memo1: TMemo;
    Label1: TLabel;
    Label2: TLabel;
    edtViewPage: TEdit;
    btnView: TButton;
    Label3: TLabel;
    edtBirthdate: TEdit;
    Label6: TLabel;
    edtAccount: TEdit;
    clHttpRequest: TclHttpRequest;
    clHttp1: TclHttp;
    procedure btnSubmitClick(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure btnViewClick(Sender: TObject);
  end;
 
var
  MainForm: TMainForm;

implementation

{$R *.dfm}

procedure TMainForm.btnSubmitClick(Sender: TObject);
var
  response: TStream;
begin
  if clHttp1.Active then Exit;

  clHttpRequest.FormFields['Name'].FieldValue := edtName.Text;
  clHttpRequest.FormFields['Birthdate'].FieldValue := edtBirthdate.Text;
  clHttpRequest.FormFields['Account'].FieldValue := edtAccount.Text;

  response := TMemoryStream.Create();
  try
    clHttp1.Post(edtHost.Text, clHttpRequest, response);

    response.Position := 0;
    Memo1.Lines.LoadFromStream(response);
  finally
    response.Free();
    clHttp1.Close();
  end;

  ShowMessage('Process completed successfully.');
end;

procedure TMainForm.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  CanClose := not clHttp1.Active;
end;

procedure TMainForm.btnViewClick(Sender: TObject);
begin
  ShellExecute(0, 'open', PChar(edtViewPage.Text), nil, nil, SW_RESTORE);
end;

end.
