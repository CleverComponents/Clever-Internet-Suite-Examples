inherited Form1: TForm1
  Left = 319
  Top = 74
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Send E-mail with DKIM signature'
  ClientHeight = 619
  OldCreateOrder = True
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 541
    object Label1: TLabel
      Left = 17
      Top = 16
      Width = 32
      Height = 13
      Caption = 'Server'
    end
    object Label2: TLabel
      Left = 17
      Top = 43
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 376
      Top = 16
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 376
      Top = 43
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 17
      Top = 332
      Width = 24
      Height = 13
      Caption = 'From'
    end
    object Label6: TLabel
      Left = 17
      Top = 359
      Width = 12
      Height = 13
      Caption = 'To'
    end
    object Label7: TLabel
      Left = 17
      Top = 386
      Width = 36
      Height = 13
      Caption = 'Subject'
    end
    object Label8: TLabel
      Left = 17
      Top = 96
      Width = 62
      Height = 13
      Caption = 'DKIM domain'
    end
    object Label9: TLabel
      Left = 356
      Top = 96
      Width = 66
      Height = 13
      Caption = 'DKIM selector'
    end
    object Label10: TLabel
      Left = 17
      Top = 160
      Width = 55
      Height = 13
      Caption = 'Private Key'
    end
    object Label12: TLabel
      Left = 17
      Top = 288
      Width = 66
      Height = 13
      Caption = 'DNS txt value'
    end
    object Label11: TLabel
      Left = 17
      Top = 128
      Width = 62
      Height = 13
      Caption = 'Fields to sign'
    end
    object Label13: TLabel
      Left = 17
      Top = 261
      Width = 66
      Height = 13
      Caption = 'DNS txt name'
    end
    object edtServer: TEdit
      Left = 88
      Top = 13
      Width = 201
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 88
      Top = 40
      Width = 65
      Height = 21
      TabOrder = 1
      Text = '25'
    end
    object edtUser: TEdit
      Left = 432
      Top = 13
      Width = 180
      Height = 21
      TabOrder = 2
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 432
      Top = 40
      Width = 180
      Height = 21
      PasswordChar = '*'
      TabOrder = 3
      Text = 'clevertester'
    end
    object edtFrom: TEdit
      Left = 96
      Top = 329
      Width = 516
      Height = 21
      TabOrder = 12
      Text = 'steve@example.com'
    end
    object edtTo: TEdit
      Left = 96
      Top = 356
      Width = 516
      Height = 21
      TabOrder = 13
      Text = 'johndoe@domain.com'
    end
    object edtSubject: TEdit
      Left = 96
      Top = 383
      Width = 516
      Height = 21
      TabOrder = 14
      Text = 'Sample message with DKIM signature'
    end
    object memBody: TMemo
      Left = 17
      Top = 410
      Width = 595
      Height = 91
      Lines.Strings = (
        'This is a sample email with DKIM signature.')
      TabOrder = 15
    end
    object btnSend: TButton
      Left = 491
      Top = 507
      Width = 121
      Height = 25
      Caption = 'Send'
      TabOrder = 16
      OnClick = btnSendClick
    end
    object edtDkimDomain: TEdit
      Left = 88
      Top = 93
      Width = 201
      Height = 21
      TabOrder = 4
      Text = 'example.com'
    end
    object edtDkimSelector: TEdit
      Left = 432
      Top = 93
      Width = 180
      Height = 21
      TabOrder = 5
      Text = 'sample'
    end
    object memPrivateKey: TMemo
      Left = 88
      Top = 160
      Width = 524
      Height = 52
      ScrollBars = ssVertical
      TabOrder = 7
      WordWrap = False
    end
    object btnLoadKey: TButton
      Left = 89
      Top = 217
      Width = 75
      Height = 25
      Caption = 'Load...'
      TabOrder = 8
      OnClick = btnLoadKeyClick
    end
    object btnGenerateKey: TButton
      Left = 198
      Top = 217
      Width = 75
      Height = 25
      Caption = 'Generate'
      TabOrder = 9
      OnClick = btnGenerateKeyClick
    end
    object edtDnsTxtValue: TEdit
      Left = 96
      Top = 285
      Width = 516
      Height = 21
      ReadOnly = True
      TabOrder = 11
    end
    object edtSignFields: TEdit
      Left = 88
      Top = 125
      Width = 524
      Height = 21
      TabOrder = 6
    end
    object edtDnsTxtName: TEdit
      Left = 96
      Top = 258
      Width = 516
      Height = 21
      ReadOnly = True
      TabOrder = 10
    end
  end
  object clSmtp1: TclSmtp
    CharSet = 'us-ascii'
    MailAgent = 'Clever Internet Suite'
    Left = 104
    Top = 516
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 40009.488706053240000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Dkim = clDkim1
    Left = 168
    Top = 516
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
    Left = 240
    Top = 516
  end
  object OpenDialog1: TOpenDialog
    DefaultExt = '.pem'
    Filter = 'Key files (*.pem)|*.pem|All (*.*)|*.*'
    FilterIndex = 0
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 48
    Top = 514
  end
end
