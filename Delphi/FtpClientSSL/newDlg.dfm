object NewDialog: TNewDialog
  Left = 247
  Top = 62
  Width = 279
  Height = 139
  BorderStyle = bsDialog
  Caption = 'NewDialog'
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
  object lblName: TLabel
    Left = 16
    Top = 10
    Width = 38
    Height = 13
    Caption = 'lblName'
  end
  object edtName: TEdit
    Left = 14
    Top = 30
    Width = 245
    Height = 21
    TabOrder = 0
    Text = 'NewName'
  end
  object btnOK: TButton
    Left = 96
    Top = 66
    Width = 75
    Height = 25
    Caption = 'OK'
    Default = True
    ModalResult = 1
    TabOrder = 1
  end
  object btnCancel: TButton
    Left = 186
    Top = 66
    Width = 75
    Height = 25
    Cancel = True
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 2
  end
end
