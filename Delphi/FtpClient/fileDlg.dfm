object FileExistsDialog: TFileExistsDialog
  Left = 247
  Top = 62
  BorderStyle = bsDialog
  Caption = 'File Exists Dialog'
  ClientHeight = 101
  ClientWidth = 358
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  PixelsPerInch = 96
  TextHeight = 13
  object lblCaption: TLabel
    Left = 16
    Top = 16
    Width = 331
    Height = 43
    AutoSize = False
    Caption = 'lblCaption'
    WordWrap = True
  end
  object btnReplace: TButton
    Left = 24
    Top = 64
    Width = 75
    Height = 25
    Caption = 'Replace'
    ModalResult = 6
    TabOrder = 0
  end
  object btnResume: TButton
    Left = 108
    Top = 64
    Width = 75
    Height = 25
    Caption = 'Resume'
    ModalResult = 7
    TabOrder = 1
  end
  object btnCancel: TButton
    Left = 256
    Top = 64
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 2
  end
end
