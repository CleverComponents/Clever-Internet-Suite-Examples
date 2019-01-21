object MessageForm: TMessageForm
  Left = 0
  Top = 0
  BorderStyle = bsDialog
  Caption = 'Message Details'
  ClientHeight = 312
  ClientWidth = 480
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 16
    Width = 24
    Height = 13
    Caption = 'From'
  end
  object Label2: TLabel
    Left = 16
    Top = 40
    Width = 12
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
    Text = 'clevertester@company.mail'
  end
  object edtTo: TEdit
    Left = 64
    Top = 40
    Width = 393
    Height = 21
    TabOrder = 1
    Text = 'clevertester@company.mail'
  end
  object edtSubject: TEdit
    Left = 64
    Top = 64
    Width = 393
    Height = 21
    TabOrder = 2
    Text = 'Test Subject'
  end
  object memBody: TMemo
    Left = 18
    Top = 104
    Width = 441
    Height = 153
    ScrollBars = ssBoth
    TabOrder = 3
  end
  object btnAppend: TButton
    Left = 278
    Top = 272
    Width = 75
    Height = 25
    Caption = 'Append'
    ModalResult = 1
    TabOrder = 4
  end
  object btnCancel: TButton
    Left = 382
    Top = 272
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 5
  end
end
