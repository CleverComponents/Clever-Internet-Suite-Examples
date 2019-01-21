inherited MainForm: TMainForm
  Left = 192
  Top = 114
  Caption = 'Clever POP3 Server - Sample'
  Font.Name = 'MS Sans Serif'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 149
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label2: TLabel
      Left = 8
      Top = 67
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 8
      Top = 95
      Width = 39
      Height = 13
      Caption = 'Root Dir'
    end
    object Label4: TLabel
      Left = 8
      Top = 8
      Width = 484
      Height = 13
      Caption = 
        'This is a sample POP3 server. You can use any mail client with P' +
        'OP3 support to connect to this server.'
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
      Top = 36
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
    object btnStart: TButton
      Left = 56
      Top = 120
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 2
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 144
      Top = 120
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 3
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 165
      Width = 623
      Height = 198
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 4
    end
    object edtPort: TEdit
      Left = 56
      Top = 64
      Width = 65
      Height = 21
      TabOrder = 0
      Text = '110'
    end
    object edtRootDir: TEdit
      Left = 56
      Top = 92
      Width = 553
      Height = 21
      TabOrder = 1
      Text = 'C:\CleverMailBox\'
    end
  end
  object clPop3FileHandler1: TclPop3FileHandler
    Server = clPop3Server1
    Left = 296
    Top = 128
  end
  object clPop3Server1: TclPop3Server
    ServerName = 'Clever Internet Suite POP3 service'
    OnStart = clPop3Server1Start
    OnStop = clPop3Server1Stop
    OnAcceptConnection = clPop3Server1AcceptConnection
    OnCloseConnection = clPop3Server1CloseConnection
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
    Left = 256
    Top = 128
  end
end
