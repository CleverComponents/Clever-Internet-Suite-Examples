inherited Form1: TForm1
  Left = 569
  Top = 200
  Caption = 'SMTP Client with SSL / TLS support - Sample'
  Constraints.MinHeight = 480
  Constraints.MinWidth = 639
  OldCreateOrder = True
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 16
      Top = 16
      Width = 32
      Height = 13
      Caption = 'Server'
    end
    object Label2: TLabel
      Left = 16
      Top = 43
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 256
      Top = 43
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 442
      Top = 43
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 16
      Top = 78
      Width = 24
      Height = 13
      Caption = 'From'
    end
    object Label6: TLabel
      Left = 16
      Top = 105
      Width = 12
      Height = 13
      Caption = 'To'
    end
    object Label7: TLabel
      Left = 16
      Top = 132
      Width = 36
      Height = 13
      Caption = 'Subject'
    end
    object edtServer: TEdit
      Left = 56
      Top = 13
      Width = 558
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 56
      Top = 40
      Width = 59
      Height = 21
      TabOrder = 1
      Text = '25'
    end
    object edtUser: TEdit
      Left = 288
      Top = 40
      Width = 115
      Height = 21
      TabOrder = 3
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 494
      Top = 40
      Width = 120
      Height = 21
      PasswordChar = '*'
      TabOrder = 4
      Text = 'clevertester'
    end
    object edtFrom: TEdit
      Left = 56
      Top = 75
      Width = 558
      Height = 21
      TabOrder = 5
      Text = 'CleverTester@company.mail'
    end
    object edtTo: TEdit
      Left = 56
      Top = 102
      Width = 558
      Height = 21
      TabOrder = 6
      Text = 'johndoe@domain.com'
    end
    object edtSubject: TEdit
      Left = 56
      Top = 129
      Width = 558
      Height = 21
      TabOrder = 7
      Text = 'ABC Company: New Catalog'
    end
    object memBody: TMemo
      Left = 16
      Top = 160
      Width = 598
      Height = 162
      Anchors = [akLeft, akTop, akRight, akBottom]
      Lines.Strings = (
        'Dear Sir/Madam,'
        ''
        
          'Our company is glad to hear about your interest in our catalog. ' +
          'We will send updated versions of our catalogs'
        
          'each month. The first section should be especially interesting t' +
          'o you since it has parts you were looking for.'
        
          'This is our most completed and updated version, so do not hesita' +
          'te to contact us if you need new merchandise.'
        ''
        'Thank you for your interest in our catalogs.'
        ''
        'Best,'
        'Timmy Warner'
        'ABC Company, Ltd'
        '+1 2223334455')
      TabOrder = 8
    end
    object cbUseTLS: TCheckBox
      Left = 124
      Top = 43
      Width = 97
      Height = 17
      Caption = 'Use SSL / TLS'
      Checked = True
      State = cbChecked
      TabOrder = 2
    end
    object btnSend: TButton
      Left = 492
      Top = 329
      Width = 122
      Height = 25
      Anchors = [akRight, akBottom]
      Caption = 'Send'
      TabOrder = 9
      OnClick = btnSendClick
    end
  end
  object clSmtp1: TclSmtp
    OnVerifyServer = clSmtp1VerifyServer
    MailAgent = 'Clever Internet Suite'
    Left = 48
    Top = 272
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 40009.488706053240000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 80
    Top = 272
  end
end
