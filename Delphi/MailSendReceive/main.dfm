inherited Form1: TForm1
  Left = 192
  Top = 114
  Caption = 'SMTP / POP3 client - Sample'
  Constraints.MinHeight = 480
  Constraints.MinWidth = 639
  OldCreateOrder = True
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 12
      Top = 18
      Width = 54
      Height = 13
      Caption = 'POP server'
    end
    object Label2: TLabel
      Left = 12
      Top = 66
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label3: TLabel
      Left = 12
      Top = 88
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label4: TLabel
      Left = 13
      Top = 152
      Width = 147
      Height = 13
      Caption = 'Messages. Double click to view'
    end
    object Label5: TLabel
      Left = 12
      Top = 42
      Width = 60
      Height = 13
      Caption = 'SMTP server'
    end
    object edtPop3Server: TEdit
      Left = 79
      Top = 16
      Width = 533
      Height = 21
      TabOrder = 0
      Text = 'pop.domain.com'
    end
    object edtUser: TEdit
      Left = 79
      Top = 64
      Width = 533
      Height = 21
      TabOrder = 2
      Text = 'user@domain.com'
    end
    object edtPassword: TEdit
      Left = 79
      Top = 88
      Width = 533
      Height = 21
      PasswordChar = '*'
      TabOrder = 3
      Text = 'password'
    end
    object btnComposeMail: TButton
      Left = 203
      Top = 118
      Width = 113
      Height = 25
      Caption = 'Compose Mail'
      TabOrder = 4
      OnClick = btnComposeMailClick
    end
    object btnCheckMail: TButton
      Left = 79
      Top = 118
      Width = 113
      Height = 25
      Caption = 'Check Mail'
      TabOrder = 5
      OnClick = btnCheckMailClick
    end
    object lbMessages: TListBox
      Left = 12
      Top = 168
      Width = 599
      Height = 183
      Anchors = [akLeft, akTop, akRight, akBottom]
      ItemHeight = 13
      TabOrder = 6
      OnDblClick = lbMessagesDblClick
    end
    object edtSmtpServer: TEdit
      Left = 79
      Top = 40
      Width = 533
      Height = 21
      TabOrder = 1
      Text = 'smtp.domain.com'
    end
  end
  object clSMTP1: TclSmtp
    MailAgent = 'Clever Internet Suite'
    Left = 80
    Top = 256
  end
  object clPOP31: TclPop3
    Left = 120
    Top = 256
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38524.526523229200000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 160
    Top = 256
  end
end
