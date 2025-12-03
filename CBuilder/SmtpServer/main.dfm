inherited MainForm: TMainForm
  Left = 192
  Top = 114
  Caption = 'Clever SMTP Server - Sample'
  Constraints.MinHeight = 480
  Constraints.MinWidth = 639
  OldCreateOrder = True
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 197
      Width = 17
      Height = 13
      Caption = 'Log'
    end
    object Label2: TLabel
      Left = 8
      Top = 72
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 8
      Top = 99
      Width = 52
      Height = 13
      Caption = 'Mailbox Dir'
    end
    object Label4: TLabel
      Left = 72
      Top = 8
      Width = 454
      Height = 26
      Caption = 
        'This is a sample SMTP server. You can use any mail client with S' +
        'MTP support to connect to this server.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label5: TLabel
      Left = 72
      Top = 32
      Width = 429
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
      Top = 127
      Width = 43
      Height = 13
      Caption = 'Relay Dir'
    end
    object btnStart: TButton
      Left = 72
      Top = 175
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 3
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 160
      Top = 175
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 4
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 213
      Width = 623
      Height = 151
      Anchors = [akLeft, akTop, akRight, akBottom]
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 5
    end
    object edtPort: TEdit
      Left = 72
      Top = 69
      Width = 49
      Height = 21
      TabOrder = 0
      Text = '25'
    end
    object edtMailboxDir: TEdit
      Left = 72
      Top = 97
      Width = 537
      Height = 21
      TabOrder = 1
      Text = 'C:\CleverMailBox\'
    end
    object edtRelayDir: TEdit
      Left = 72
      Top = 125
      Width = 537
      Height = 21
      TabOrder = 2
      Text = 'C:\CleverMailBox\RelayQueue\'
    end
    object cbUseLogin: TCheckBox
      Left = 72
      Top = 152
      Width = 289
      Height = 17
      Caption = 'Use Authentication - LOGIN / CRAM-MD5 / NTLM'
      Checked = True
      State = cbChecked
      TabOrder = 6
    end
  end
  object clSmtpServer1: TclSmtpServer
    ServerName = 'Clever Internet Suite SMTP service'
    OnStart = clSmtpServer1Start
    OnStop = clSmtpServer1Stop
    OnAcceptConnection = clSmtpServer1AcceptConnection
    OnCloseConnection = clSmtpServer1CloseConnection
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
    Left = 392
    Top = 24
  end
  object clSmtpFileHandler1: TclSmtpFileHandler
    Server = clSmtpServer1
    Left = 392
    Top = 56
  end
end
