object SearchDialog: TSearchDialog
  Left = 0
  Top = 0
  BorderStyle = bsDialog
  Caption = 'Find Message'
  ClientHeight = 161
  ClientWidth = 300
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 32
    Top = 16
    Width = 46
    Height = 13
    Caption = 'Search In'
  end
  object Label2: TLabel
    Left = 32
    Top = 64
    Width = 52
    Height = 13
    Caption = 'Search For'
  end
  object cbSearchIn: TComboBox
    Left = 24
    Top = 35
    Width = 257
    Height = 21
    ItemHeight = 13
    TabOrder = 0
    Text = 'SUBJECT'
    Items.Strings = (
      'FROM'
      'SUBJECT'
      'TEXT')
  end
  object edtSearchFor: TEdit
    Left = 24
    Top = 83
    Width = 257
    Height = 21
    TabOrder = 1
  end
  object btnSearch: TButton
    Left = 88
    Top = 120
    Width = 75
    Height = 25
    Caption = 'Search'
    ModalResult = 1
    TabOrder = 2
  end
  object btnCancel: TButton
    Left = 184
    Top = 120
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 3
  end
end
