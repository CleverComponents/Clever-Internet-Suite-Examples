object ExportForm: TExportForm
  Left = 247
  Top = 114
  BorderStyle = bsDialog
  Caption = 'Certificate Export Dialog'
  ClientHeight = 191
  ClientWidth = 378
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 48
    Width = 47
    Height = 13
    Caption = 'File Name'
  end
  object Label2: TLabel
    Left = 16
    Top = 80
    Width = 46
    Height = 13
    Caption = 'Password'
  end
  object Label3: TLabel
    Left = 16
    Top = 8
    Width = 47
    Height = 13
    Caption = 'Certificate'
  end
  object edtFileName: TEdit
    Left = 80
    Top = 48
    Width = 281
    Height = 21
    TabOrder = 1
    Text = 'cert.pfx'
  end
  object edtPassword: TEdit
    Left = 80
    Top = 80
    Width = 129
    Height = 21
    PasswordChar = '*'
    TabOrder = 2
    Text = '123'
  end
  object cbIncludeAll: TCheckBox
    Left = 80
    Top = 112
    Width = 161
    Height = 17
    Caption = 'Include All certificates in chain'
    TabOrder = 3
  end
  object btnOK: TButton
    Left = 80
    Top = 144
    Width = 75
    Height = 25
    Caption = 'OK'
    ModalResult = 1
    TabOrder = 4
  end
  object btnCancel: TButton
    Left = 208
    Top = 144
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 5
  end
  object edtName: TEdit
    Left = 80
    Top = 8
    Width = 281
    Height = 21
    Color = clBtnFace
    ReadOnly = True
    TabOrder = 0
  end
end
