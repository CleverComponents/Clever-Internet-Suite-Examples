unit certlistfrm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, clCertificate, clCertificateStore;

type
  TCertListForm = class(TForm)
    lbList: TListBox;
    btnInstall: TButton;
    btnClose: TButton;
    procedure btnInstallClick(Sender: TObject);
    procedure btnCloseClick(Sender: TObject);
  private
    FCertificates: TclCertificateStore;
    procedure FillList;
  public
    class procedure ShowCertificates(AList: TclCertificateStore);
  end;

var
  CertListForm: TCertListForm;

implementation

{$R *.dfm}

procedure TCertListForm.btnInstallClick(Sender: TObject);
begin
  if lbList.ItemIndex > -1 then
  begin
    FCertificates.Install(FCertificates.Items[lbList.ItemIndex]);
    ShowMessage('The message certificate has been installed.');
  end;
end;

class procedure TCertListForm.ShowCertificates(AList: TclCertificateStore);
var
  dlg: TCertListForm;
begin
  dlg := TCertListForm.Create(nil);
  try
    dlg.FCertificates := AList;
    dlg.FillList();
    dlg.ShowModal();
  finally
    dlg.Free();
  end;
end;

procedure TCertListForm.btnCloseClick(Sender: TObject);
begin
  Close();
end;

procedure TCertListForm.FillList;
var
  i: Integer;
  s: string;
begin
  lbList.Items.Clear();
  for i := 0 to FCertificates.Items.Count - 1 do
  begin
    s := FCertificates.Items[i].IssuedTo;
    if (FCertificates.Items[i].Email <> '') then
    begin
      s := s + ' (' + FCertificates.Items[i].Email + ')';
    end;
    lbList.Items.Add(s);
  end;
end;

end.
