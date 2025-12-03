object LoginConfirmation: TLoginConfirmation
  Left = 0
  Top = 0
  BorderStyle = bsDialog
  Caption = 'Login Confirmation'
  ClientHeight = 229
  ClientWidth = 483
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
    Width = 446
    Height = 26
    Caption = 
      'The "Clever Internet Suite Demos" app is about to log in to your' +
      ' GMail mailbox and display E-mails within the selected folder.'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
    WordWrap = True
  end
  object Label2: TLabel
    Left = 16
    Top = 120
    Width = 104
    Height = 13
    Caption = 'Requested Scope: '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label3: TLabel
    Left = 16
    Top = 56
    Width = 92
    Height = 13
    Caption = 'OAuth Client ID: '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object edtClientID: TEdit
    Left = 16
    Top = 80
    Width = 448
    Height = 21
    Color = clBtnFace
    Enabled = False
    TabOrder = 0
    Text = 'edtClientID'
  end
  object edtScope: TEdit
    Left = 16
    Top = 139
    Width = 448
    Height = 21
    Color = clBtnFace
    Enabled = False
    TabOrder = 1
    Text = 'edtScope'
  end
  object btnOK: TButton
    Left = 136
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Continue'
    Default = True
    ModalResult = 1
    TabOrder = 2
  end
  object btnCancel: TButton
    Left = 280
    Top = 184
    Width = 75
    Height = 25
    Cancel = True
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 3
  end
end
