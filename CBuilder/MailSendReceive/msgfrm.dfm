object MessageForm: TMessageForm
  Left = 192
  Top = 114
  BorderStyle = bsDialog
  Caption = 'Message Form'
  ClientHeight = 391
  ClientWidth = 473
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
    Top = 16
    Width = 23
    Height = 13
    Caption = 'From'
  end
  object Label2: TLabel
    Left = 16
    Top = 40
    Width = 13
    Height = 13
    Caption = 'To'
  end
  object Label3: TLabel
    Left = 16
    Top = 64
    Width = 36
    Height = 13
    Caption = 'Subject'
  end
  object edtFrom: TEdit
    Left = 64
    Top = 16
    Width = 393
    Height = 21
    TabOrder = 0
    Text = 'john@domain.com'
  end
  object edtTo: TEdit
    Left = 64
    Top = 40
    Width = 393
    Height = 21
    TabOrder = 1
    Text = 'alex@someserver.com'
  end
  object edtSubject: TEdit
    Left = 64
    Top = 64
    Width = 393
    Height = 21
    TabOrder = 2
    Text = 'Sample'
  end
  object memBody: TMemo
    Left = 16
    Top = 96
    Width = 441
    Height = 241
    Lines.Strings = (
      'Hello, Alex')
    ScrollBars = ssBoth
    TabOrder = 3
  end
  object btnSend: TButton
    Left = 280
    Top = 352
    Width = 75
    Height = 25
    Caption = 'Send'
    ModalResult = 1
    TabOrder = 4
  end
  object btnClose: TButton
    Left = 384
    Top = 352
    Width = 75
    Height = 25
    Caption = 'Close'
    ModalResult = 2
    TabOrder = 5
  end
end
