inherited Form1: TForm1
  Left = 295
  Top = 172
  Caption = 'Reveive E-mail and verify DKIM signature - Sample'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 16
      Top = 20
      Width = 32
      Height = 13
      Caption = 'Server'
    end
    object Label2: TLabel
      Left = 16
      Top = 52
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label4: TLabel
      Left = 184
      Top = 52
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label5: TLabel
      Left = 419
      Top = 52
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label3: TLabel
      Left = 16
      Top = 130
      Width = 47
      Height = 13
      Caption = 'Messages'
    end
    object edtServer: TEdit
      Left = 64
      Top = 18
      Width = 545
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 64
      Top = 50
      Width = 57
      Height = 21
      TabOrder = 1
      Text = '110'
    end
    object edtUser: TEdit
      Left = 216
      Top = 50
      Width = 169
      Height = 21
      TabOrder = 2
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 472
      Top = 50
      Width = 137
      Height = 21
      TabOrder = 3
      Text = 'clevertester'
    end
    object btnCheckMail: TButton
      Left = 64
      Top = 90
      Width = 105
      Height = 25
      Caption = 'Check Mail'
      TabOrder = 4
      OnClick = btnCheckMailClick
    end
    object lbMessages: TListBox
      Left = 16
      Top = 149
      Width = 593
      Height = 196
      ItemHeight = 13
      TabOrder = 5
    end
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38524.526523229200000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Dkim = clDkim1
    Left = 184
    Top = 256
  end
  object clDkim1: TclDkim
    DnsSettings.ServiceType = []
    DnsSettings.Flags = []
    SignatureAlgorithm = 'rsa-sha256'
    SignedHeaderFields.Strings = (
      'Date'
      'From'
      'To'
      'Subject'
      'MIME-Version'
      'Content-Type')
    PublicKeyLocation = 'dns/txt'
    Left = 248
    Top = 256
  end
  object clPop31: TclPop3
    CharSet = 'us-ascii'
    MailMessage = clMailMessage1
    Left = 112
    Top = 256
  end
end
