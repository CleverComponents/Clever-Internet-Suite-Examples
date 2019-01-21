object CreateCertForm: TCreateCertForm
  Left = 247
  Top = 114
  BorderStyle = bsDialog
  Caption = 'Create Certificate Dialog'
  ClientHeight = 420
  ClientWidth = 453
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label3: TLabel
    Left = 16
    Top = 329
    Width = 411
    Height = 13
    Caption = 
      'The new certificate will be created and installed in to the curr' +
      'ently loaded System Store:'
    WordWrap = True
  end
  object Label1: TLabel
    Left = 16
    Top = 32
    Width = 72
    Height = 13
    Caption = 'Common Name'
  end
  object Label2: TLabel
    Left = 16
    Top = 160
    Width = 66
    Height = 13
    Caption = 'Serial Number'
  end
  object Label4: TLabel
    Left = 16
    Top = 184
    Width = 49
    Height = 13
    Caption = 'Valid From'
  end
  object Label5: TLabel
    Left = 264
    Top = 184
    Width = 39
    Height = 13
    Caption = 'Valid To'
  end
  object Label6: TLabel
    Left = 16
    Top = 56
    Width = 59
    Height = 13
    Caption = 'Organization'
  end
  object Label7: TLabel
    Left = 16
    Top = 80
    Width = 89
    Height = 13
    Caption = 'Organizational Unit'
  end
  object Label8: TLabel
    Left = 16
    Top = 104
    Width = 36
    Height = 13
    Caption = 'Locality'
  end
  object Label9: TLabel
    Left = 264
    Top = 104
    Width = 36
    Height = 13
    Caption = 'Country'
  end
  object Label10: TLabel
    Left = 16
    Top = 136
    Width = 25
    Height = 13
    Caption = 'Email'
  end
  object Label11: TLabel
    Left = 16
    Top = 211
    Width = 49
    Height = 13
    Caption = 'Key Name'
  end
  object Label12: TLabel
    Left = 16
    Top = 238
    Width = 54
    Height = 13
    Caption = 'Key Length'
  end
  object Label13: TLabel
    Left = 16
    Top = 270
    Width = 52
    Height = 13
    Caption = 'Key Usage'
  end
  object Label14: TLabel
    Left = 16
    Top = 8
    Width = 67
    Height = 13
    Caption = 'Friendly Name'
  end
  object btnOK: TButton
    Left = 112
    Top = 380
    Width = 75
    Height = 25
    Caption = 'OK'
    ModalResult = 1
    TabOrder = 17
  end
  object btnCancel: TButton
    Left = 240
    Top = 380
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 18
  end
  object edtStoreName: TEdit
    Left = 16
    Top = 348
    Width = 417
    Height = 21
    Color = clBtnFace
    ReadOnly = True
    TabOrder = 16
  end
  object edtCN: TEdit
    Left = 112
    Top = 32
    Width = 321
    Height = 21
    TabOrder = 1
    Text = 'CleverTester'
  end
  object edtSerial: TEdit
    Left = 112
    Top = 160
    Width = 89
    Height = 21
    TabOrder = 7
    Text = '1'
  end
  object edtValidFrom: TEdit
    Left = 112
    Top = 184
    Width = 121
    Height = 21
    TabOrder = 8
  end
  object edtValidTo: TEdit
    Left = 312
    Top = 184
    Width = 121
    Height = 21
    TabOrder = 9
  end
  object edtO: TEdit
    Left = 112
    Top = 56
    Width = 321
    Height = 21
    TabOrder = 2
    Text = 'YourCompany'
  end
  object edtOU: TEdit
    Left = 112
    Top = 80
    Width = 321
    Height = 21
    TabOrder = 3
    Text = 'Demos'
  end
  object edtL: TEdit
    Left = 112
    Top = 104
    Width = 121
    Height = 21
    TabOrder = 4
    Text = 'CA'
  end
  object edtC: TEdit
    Left = 312
    Top = 104
    Width = 121
    Height = 21
    TabOrder = 5
    Text = 'US'
  end
  object edtE: TEdit
    Left = 112
    Top = 136
    Width = 321
    Height = 21
    TabOrder = 6
    Text = 'CleverTester@company.mail'
  end
  object edtKeyName: TEdit
    Left = 112
    Top = 211
    Width = 321
    Height = 21
    TabOrder = 10
    Text = 'testkeyname-99046937-7D4A-441A-8621-5CDADA8AF9DC'
  end
  object edtKeyLength: TEdit
    Left = 112
    Top = 238
    Width = 89
    Height = 21
    TabOrder = 11
    Text = '1024'
  end
  object cbServerAuth: TCheckBox
    Left = 112
    Top = 269
    Width = 89
    Height = 17
    Caption = 'Server Auth'
    Checked = True
    State = cbChecked
    TabOrder = 12
    OnClick = cbServerAuthClick
  end
  object cbClientAuth: TCheckBox
    Left = 112
    Top = 292
    Width = 89
    Height = 17
    Caption = 'Client Auth'
    Checked = True
    State = cbChecked
    TabOrder = 13
    OnClick = cbServerAuthClick
  end
  object cbCodeSigning: TCheckBox
    Left = 226
    Top = 269
    Width = 89
    Height = 17
    Caption = 'Code Signing'
    Checked = True
    State = cbChecked
    TabOrder = 14
    OnClick = cbServerAuthClick
  end
  object cbEmailProtection: TCheckBox
    Left = 226
    Top = 292
    Width = 103
    Height = 17
    Caption = 'Email Protection'
    Checked = True
    State = cbChecked
    TabOrder = 15
    OnClick = cbServerAuthClick
  end
  object edtFriendlyName: TEdit
    Left = 112
    Top = 8
    Width = 321
    Height = 21
    TabOrder = 0
    Text = 'Clever Tester'
  end
  object cbAll: TCheckBox
    Left = 335
    Top = 269
    Width = 97
    Height = 17
    Caption = 'All Purposes'
    TabOrder = 19
    OnClick = cbAllClick
  end
end
