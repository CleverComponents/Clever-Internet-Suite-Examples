object GetCertDialog: TGetCertDialog
  Left = 247
  Top = 62
  BorderStyle = bsDialog
  Caption = 'Get Certificate Form'
  ClientHeight = 101
  ClientWidth = 292
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 10
    Top = 10
    Width = 69
    Height = 13
    Caption = 'E-mail Address'
  end
  object Label2: TLabel
    Left = 10
    Top = 32
    Width = 56
    Height = 13
    Caption = 'Store Name'
  end
  object edtEmail: TEdit
    Left = 88
    Top = 6
    Width = 189
    Height = 21
    TabOrder = 0
    Text = 'myname@mycompany.com'
  end
  object edtStore: TEdit
    Left = 88
    Top = 30
    Width = 190
    Height = 21
    TabOrder = 1
    Text = 'MY'
  end
  object btnOK: TButton
    Left = 88
    Top = 62
    Width = 75
    Height = 25
    Caption = 'OK'
    Default = True
    ModalResult = 1
    TabOrder = 2
  end
  object btnMessage: TButton
    Left = 172
    Top = 62
    Width = 105
    Height = 25
    Cancel = True
    Caption = 'Get From Message'
    ModalResult = 2
    TabOrder = 3
  end
end
