inherited Form1: TForm1
  Left = 275
  Top = 145
  Caption = 'SMTP Relay - Sample'
  Font.Name = 'MS Sans Serif'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 16
      Top = 6
      Width = 328
      Height = 13
      Caption = 
        'This demo creates e-mail and sends it directly to the recipient'#39 +
        's server.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
    end
    object Label2: TLabel
      Left = 16
      Top = 26
      Width = 585
      Height = 20
      AutoSize = False
      Caption = 
        'Please specify the DNS server IP which will be used for resolvin' +
        'g the SMTP server address of the recipient'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label3: TLabel
      Left = 16
      Top = 48
      Width = 585
      Height = 31
      AutoSize = False
      Caption = 
        'Please note ! Most SMTP servers require that the sender PC must ' +
        'be registered in DNS. Otherwise, relaying will be denied to such' +
        ' SMTP servers.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label4: TLabel
      Left = 16
      Top = 84
      Width = 68
      Height = 13
      Caption = 'DNS server IP'
    end
    object Label5: TLabel
      Left = 16
      Top = 116
      Width = 61
      Height = 13
      Caption = 'Sender email'
    end
    object Label6: TLabel
      Left = 16
      Top = 140
      Width = 50
      Height = 13
      Caption = 'Recipinets'
    end
    object Label7: TLabel
      Left = 16
      Top = 172
      Width = 93
      Height = 13
      Caption = 'Subject of message'
    end
    object Label8: TLabel
      Left = 16
      Top = 194
      Width = 63
      Height = 13
      Caption = 'Message text'
    end
    object Label9: TLabel
      Left = 248
      Top = 84
      Width = 77
      Height = 13
      Caption = 'DNS TimeOut, s'
    end
    object edtDNS: TEdit
      Left = 120
      Top = 82
      Width = 105
      Height = 21
      TabOrder = 0
      Text = '192.168.0.1'
    end
    object edtSender: TEdit
      Left = 120
      Top = 114
      Width = 490
      Height = 21
      TabOrder = 2
      Text = 'CleverTester@company.mail'
    end
    object edtRecipient: TEdit
      Left = 120
      Top = 138
      Width = 490
      Height = 21
      TabOrder = 3
      Text = 'john@domain.com,alex@company.mail'
    end
    object edtSubject: TEdit
      Left = 120
      Top = 170
      Width = 490
      Height = 21
      TabOrder = 4
      Text = 'smtp relaying test'
    end
    object memText: TMemo
      Left = 16
      Top = 214
      Width = 593
      Height = 108
      Lines.Strings = (
        'This is a test message')
      TabOrder = 5
    end
    object btnSend: TButton
      Left = 240
      Top = 330
      Width = 129
      Height = 25
      Caption = 'Send Mail'
      TabOrder = 6
      OnClick = btnSendClick
    end
    object edtDNSTimeOut: TEdit
      Left = 336
      Top = 82
      Width = 73
      Height = 21
      TabOrder = 1
      Text = '5'
    end
  end
  object clSmtpRelay1: TclSmtpRelay
    MailAgent = 'Clever Internet Suite v 7.0'
    Left = 216
    Top = 280
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38658.889933078700000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 256
    Top = 280
  end
end
