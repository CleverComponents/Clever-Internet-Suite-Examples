inherited MainForm: TMainForm
  Left = 192
  Top = 114
  Caption = 'Clever POP3 Server SSL / TLS - Sample'
  Font.Name = 'Tahoma'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 193
      Width = 18
      Height = 14
      Caption = 'Log'
    end
    object Label2: TLabel
      Left = 8
      Top = 115
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 8
      Top = 143
      Width = 39
      Height = 13
      Caption = 'Root Dir'
    end
    object Label4: TLabel
      Left = 24
      Top = 8
      Width = 585
      Height = 33
      AutoSize = False
      Caption = 
        'This is a sample POP3 SSL / TLS server. You can use any SSL-enab' +
        'led POP3 client (such as TclPop3 or MS Outlook client to connect' +
        ' to this server.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label5: TLabel
      Left = 24
      Top = 80
      Width = 454
      Height = 13
      Caption = 
        'Please use the "CleverTester" user name and "clevertester" passw' +
        'ord to log-in.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object Label6: TLabel
      Left = 24
      Top = 40
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
    object Label7: TLabel
      Left = 152
      Top = 115
      Width = 81
      Height = 13
      Caption = 'SSL / TLS Mode'
    end
    object btnStart: TButton
      Left = 56
      Top = 168
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 3
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 144
      Top = 168
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 4
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 209
      Width = 623
      Height = 154
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 5
    end
    object edtPort: TEdit
      Left = 56
      Top = 112
      Width = 57
      Height = 21
      TabOrder = 0
      Text = '995'
    end
    object edtRootDir: TEdit
      Left = 56
      Top = 140
      Width = 553
      Height = 21
      TabOrder = 2
      Text = 'C:\CleverMailBox\'
    end
    object cbUseTls: TComboBox
      Left = 240
      Top = 112
      Width = 161
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      ItemIndex = 1
      TabOrder = 1
      Text = 'Implicit'
      Items.Strings = (
        'None'
        'Implicit'
        'Allow Explicit'
        'Require Explicit')
    end
  end
  object clPop3FileHandler1: TclPop3FileHandler
    Server = clPop3Server1
    Left = 336
    Top = 256
  end
  object clPop3Server1: TclPop3Server
    ServerName = 'Clever Internet Suite POP3 service'
    OnStart = clPop3Server1Start
    OnStop = clPop3Server1Stop
    OnAcceptConnection = clPop3Server1AcceptConnection
    OnCloseConnection = clPop3Server1CloseConnection
    OnGetCertificate = clPop3Server1GetCertificate
    MaxDataSize = -1
    OnReceiveCommand = clPop3Server1ReceiveCommand
    OnSendResponse = clPop3Server1SendResponse
    UserAccounts = <
      item
        UserName = 'CleverTester'
        Password = 'clevertester'
        DisplayName = 'CleverTester'
      end>
    HelpText.Strings = (
      'Valid commands:'
      'USER,'
      'PASS,'
      'APOP,'
      'AUTH,'
      'QUIT,'
      'NOOP,'
      'HELP,'
      'STAT,'
      'RETR,'
      'TOP,'
      'DELE,'
      'RSET,'
      'LIST,'
      'UIDL,'
      'STLS')
    OnAuthenticate = clPop3Server1Authenticate
    Left = 296
    Top = 256
  end
  object clCertificateStore1: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40004.000000000000000000
    ValidTo = 40369.000000000000000000
    Left = 376
    Top = 256
  end
end
