inherited MainForm: TMainForm
  Left = 408
  Top = 110
  Caption = 'Clever SMTP Server - Sample'
  Font.Name = 'Tahoma'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 238
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label2: TLabel
      Left = 8
      Top = 112
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 8
      Top = 141
      Width = 52
      Height = 13
      Caption = 'Mailbox Dir'
    end
    object Label5: TLabel
      Left = 23
      Top = 77
      Width = 456
      Height = 26
      Caption = 
        'Please use the "CleverTester" user name and "clevertester" passw' +
        'ord to log-in. The user e-mail: CleverTester@company.mail'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label6: TLabel
      Left = 8
      Top = 166
      Width = 43
      Height = 13
      Caption = 'Relay Dir'
    end
    object Label7: TLabel
      Left = 194
      Top = 113
      Width = 81
      Height = 13
      Caption = 'SSL / TLS Mode'
    end
    object Label4: TLabel
      Left = 23
      Top = 8
      Width = 586
      Height = 33
      AutoSize = False
      Caption = 
        'This is a sample SMTP SSL / TLS server. You can use any SSL-enab' +
        'led SMTP client (such as TclSmtp or MS Outlook client to connect' +
        ' to this server.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label8: TLabel
      Left = 23
      Top = 42
      Width = 579
      Height = 26
      Caption = 
        'This server uses self-signed server certificate to establish the' +
        ' SSL connection. In real application you will need to request a ' +
        'certificate from trusted issuer or use your own self-signed cert' +
        'ificate.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object btnStart: TButton
      Left = 70
      Top = 214
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 4
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 158
      Top = 214
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 5
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 254
      Width = 623
      Height = 109
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 6
    end
    object edtPort: TEdit
      Left = 72
      Top = 110
      Width = 49
      Height = 21
      TabOrder = 0
      Text = '25'
    end
    object edtMailboxDir: TEdit
      Left = 71
      Top = 138
      Width = 543
      Height = 21
      TabOrder = 2
      Text = 'C:\CleverMailBox\'
    end
    object edtRelayDir: TEdit
      Left = 71
      Top = 165
      Width = 543
      Height = 21
      TabOrder = 3
      Text = 'C:\CleverMailBox\RelayQueue\'
    end
    object cbUseTls: TComboBox
      Left = 280
      Top = 110
      Width = 137
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      ItemIndex = 3
      TabOrder = 1
      Text = 'Require Explicit'
      Items.Strings = (
        'None'
        'Implicit'
        'Allow Explicit'
        'Require Explicit')
    end
    object cbUseLogin: TCheckBox
      Left = 72
      Top = 191
      Width = 289
      Height = 17
      Caption = 'Use Authentication - LOGIN / CRAM-MD5 / NTLM'
      Checked = True
      State = cbChecked
      TabOrder = 7
    end
  end
  object clSmtpServer1: TclSmtpServer
    ServerName = 'Clever Internet Suite SMTP service'
    OnStart = clSmtpServer1Start
    OnStop = clSmtpServer1Stop
    OnAcceptConnection = clSmtpServer1AcceptConnection
    OnCloseConnection = clSmtpServer1CloseConnection
    OnGetCertificate = clSmtpServer1GetCertificate
    MaxDataSize = -1
    OnReceiveCommand = clSmtpServer1ReceiveCommand
    OnSendResponse = clSmtpServer1SendResponse
    UserAccounts = <
      item
        UserName = 'CleverTester'
        Password = 'clevertester'
        DisplayName = 'CleverTester'
        Email = 'CleverTester@company.mail'
      end>
    HelpText.Strings = (
      'Commands Supported:'
      'HELO EHLO AUTH HELP QUIT MAIL NOOP RSET RCPT DATA STARTTLS')
    OnAuthenticate = clSmtpServer1Authenticate
    Left = 288
    Top = 384
  end
  object clSmtpFileHandler1: TclSmtpFileHandler
    Server = clSmtpServer1
    Left = 336
    Top = 384
  end
  object clCertificateStore1: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40004.000000000000000000
    ValidTo = 40369.000000000000000000
    Left = 384
    Top = 384
  end
end
