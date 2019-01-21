object clMessageForm: TclMessageForm
  Left = 248
  Top = 114
  BorderStyle = bsDialog
  Caption = 'Post Article Form'
  ClientHeight = 388
  ClientWidth = 516
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
    Left = 24
    Top = 16
    Width = 23
    Height = 13
    Caption = 'From'
  end
  object Label2: TLabel
    Left = 24
    Top = 48
    Width = 36
    Height = 13
    Caption = 'Subject'
  end
  object Label3: TLabel
    Left = 24
    Top = 80
    Width = 21
    Height = 13
    Caption = 'Text'
  end
  object edtFrom: TEdit
    Left = 72
    Top = 16
    Width = 425
    Height = 21
    TabOrder = 0
    Text = 'newsuser@company.mail'
  end
  object edtSubject: TEdit
    Left = 72
    Top = 48
    Width = 425
    Height = 21
    TabOrder = 1
    Text = 'Test Subject'
  end
  object memText: TMemo
    Left = 16
    Top = 96
    Width = 481
    Height = 241
    Lines.Strings = (
      'My test newsgroup post')
    TabOrder = 2
  end
  object btnPost: TButton
    Left = 320
    Top = 352
    Width = 75
    Height = 25
    Caption = 'Post'
    Default = True
    ModalResult = 1
    TabOrder = 3
  end
  object btnCancel: TButton
    Left = 416
    Top = 352
    Width = 75
    Height = 25
    Cancel = True
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 4
  end
end
