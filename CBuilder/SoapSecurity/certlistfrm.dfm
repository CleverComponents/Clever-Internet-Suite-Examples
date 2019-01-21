object CertListForm: TCertListForm
  Left = 191
  Top = 114
  BorderStyle = bsDialog
  Caption = 'Message Certificates'
  ClientHeight = 223
  ClientWidth = 391
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object lbList: TListBox
    Left = 0
    Top = 0
    Width = 391
    Height = 175
    Align = alTop
    ItemHeight = 13
    TabOrder = 0
  end
  object btnInstall: TButton
    Left = 16
    Top = 186
    Width = 75
    Height = 25
    Caption = 'Install'
    TabOrder = 1
    OnClick = btnInstallClick
  end
  object btnClose: TButton
    Left = 304
    Top = 186
    Width = 75
    Height = 25
    Caption = 'Close'
    Default = True
    TabOrder = 2
    OnClick = btnCloseClick
  end
end
