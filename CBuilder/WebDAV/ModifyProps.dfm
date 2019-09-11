object ModifyPropForm: TModifyPropForm
  Left = 247
  Top = 118
  BorderStyle = bsDialog
  Caption = 'Change / Remove Property'
  ClientHeight = 138
  ClientWidth = 332
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 32
    Width = 70
    Height = 13
    Caption = 'Property Name'
  end
  object Label2: TLabel
    Left = 16
    Top = 64
    Width = 54
    Height = 13
    Caption = ' New value'
  end
  object lblResource: TLabel
    Left = 16
    Top = 8
    Width = 56
    Height = 13
    Caption = 'lblResource'
  end
  object edtName: TEdit
    Left = 96
    Top = 32
    Width = 209
    Height = 21
    TabOrder = 0
    Text = 'author'
  end
  object edtValue: TEdit
    Left = 96
    Top = 64
    Width = 209
    Height = 21
    TabOrder = 1
    Text = 'J.J. Johnson'
  end
  object Button1: TButton
    Left = 40
    Top = 96
    Width = 75
    Height = 25
    Caption = 'Set'
    ModalResult = 6
    TabOrder = 2
  end
  object Button2: TButton
    Left = 136
    Top = 96
    Width = 75
    Height = 25
    Caption = 'Remove'
    ModalResult = 7
    TabOrder = 3
  end
  object Button3: TButton
    Left = 232
    Top = 96
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 4
  end
end
