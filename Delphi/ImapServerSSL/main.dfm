inherited MainForm: TMainForm
  Left = 192
  Top = 114
  Caption = 'Clever IMAP4 Server SSL / TLS - Sample'
  Font.Name = 'MS Sans Serif'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 192
      Width = 18
      Height = 13
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
        'This is a sample IMAP4 SSL / TLS server. You can use any SSL-ena' +
        'bled IMAP client (such as TclIMAP4 or MS Outlook client to conne' +
        'ct to this server.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label5: TLabel
      Left = 8
      Top = 80
      Width = 454
      Height = 13
      Caption = 
        'Please use the "CleverTester" user name and "clevertester" passw' +
        'ord to log-in.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
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
      Font.Name = 'MS Sans Serif'
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
      Left = 55
      Top = 168
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 3
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 143
      Top = 168
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 4
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 208
      Width = 623
      Height = 155
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
      Text = '993'
    end
    object edtRootDir: TEdit
      Left = 56
      Top = 140
      Width = 409
      Height = 21
      TabOrder = 2
      Text = 'C:\CleverMailBox\'
    end
    object cbUseTls: TComboBox
      Left = 240
      Top = 112
      Width = 225
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
  object clImap4FileHandler1: TclImap4FileHandler
    Server = clImap4Server1
    MailBoxInfoFile = 'imap.dat'
    MessagesInfoFile = 'messages.dat'
    Left = 312
    Top = 296
  end
  object clImap4Server1: TclImap4Server
    ServerName = 'Clever Internet Suite IMAP4 service'
    OnStart = clImap4Server1Start
    OnStop = clImap4Server1Stop
    OnAcceptConnection = clImap4Server1AcceptConnection
    OnCloseConnection = clImap4Server1CloseConnection
    OnGetCertificate = clImap4Server1GetCertificate
    MaxDataSize = -1
    OnReceiveCommand = clImap4Server1ReceiveCommand
    OnSendResponse = clImap4Server1SendResponse
    UserAccounts = <
      item
        UserName = 'CleverTester'
        Password = 'clevertester'
        DisplayName = 'CleverTester'
      end>
    Capabilities.Strings = (
      'IMAP4rev1')
    OnAuthenticate = clImap4Server1Authenticate
    Left = 272
    Top = 296
  end
  object clCertificateStore1: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40003.000000000000000000
    ValidTo = 40368.000000000000000000
    Left = 352
    Top = 296
  end
end
