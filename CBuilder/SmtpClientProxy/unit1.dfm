inherited Form1: TForm1
  Left = 569
  Top = 200
  ClientHeight = 510
  Caption = 'SMTP Client over HTTP Connect Proxy'
  Constraints.MinHeight = 548
  Constraints.MinWidth = 639
  OldCreateOrder = True
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 432
    object Label1: TLabel
      Left = 16
      Top = 16
      Width = 51
      Height = 13
      Caption = 'SMTP Host'
    end
    object Label2: TLabel
      Left = 16
      Top = 43
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 16
      Top = 70
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 16
      Top = 97
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 16
      Top = 140
      Width = 24
      Height = 13
      Caption = 'From'
    end
    object Label6: TLabel
      Left = 16
      Top = 167
      Width = 12
      Height = 13
      Caption = 'To'
    end
    object Label7: TLabel
      Left = 16
      Top = 194
      Width = 36
      Height = 13
      Caption = 'Subject'
    end
    object Label8: TLabel
      Left = 337
      Top = 16
      Width = 53
      Height = 13
      Caption = 'Proxy Host'
    end
    object Label9: TLabel
      Left = 337
      Top = 43
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object edtServer: TEdit
      Left = 86
      Top = 13
      Width = 210
      Height = 21
      TabOrder = 0
      Text = 'smpt.example.com'
    end
    object edtPort: TEdit
      Left = 86
      Top = 40
      Width = 59
      Height = 21
      TabOrder = 1
      Text = '25'
    end
    object edtUser: TEdit
      Left = 86
      Top = 67
      Width = 169
      Height = 21
      TabOrder = 2
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 86
      Top = 94
      Width = 169
      Height = 21
      PasswordChar = '*'
      TabOrder = 3
      Text = 'clevertester'
    end
    object edtFrom: TEdit
      Left = 86
      Top = 137
      Width = 528
      Height = 21
      TabOrder = 6
      Text = 'CleverTester@company.mail'
    end
    object edtTo: TEdit
      Left = 86
      Top = 164
      Width = 528
      Height = 21
      TabOrder = 7
      Text = 'johndoe@domain.com'
    end
    object edtSubject: TEdit
      Left = 86
      Top = 191
      Width = 528
      Height = 21
      TabOrder = 8
      Text = 'ABC Company: New Catalog'
    end
    object memBody: TMemo
      Left = 16
      Top = 218
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
      TabOrder = 9
    end
    object btnSend: TButton
      Left = 492
      Top = 393
      Width = 122
      Height = 25
      Anchors = [akRight, akBottom]
      Caption = 'Send'
      TabOrder = 10
      OnClick = btnSendClick
    end
    object edtProxyServer: TEdit
      Left = 404
      Top = 13
      Width = 210
      Height = 21
      TabOrder = 4
      Text = 'proxy'
    end
    object edtProxyPort: TEdit
      Left = 404
      Top = 40
      Width = 59
      Height = 21
      TabOrder = 5
      Text = '8080'
    end
  end
  object clSmtp1: TclSmtp
    Proxy = clHttpProxy1
    MailAgent = 'Clever Internet Suite'
    Left = 408
    Top = 392
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 40009.488706053240000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 480
    Top = 392
  end
  object clHttpProxy1: TclHttpProxy
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    Left = 336
    Top = 392
  end
end
