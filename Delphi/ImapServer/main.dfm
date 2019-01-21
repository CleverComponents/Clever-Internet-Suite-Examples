inherited MainForm: TMainForm
  Left = 192
  Top = 114
  Caption = 'Clever IMAP4 Server - Sample'
  Font.Name = 'MS Sans Serif'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 142
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
      Width = 480
      Height = 13
      Caption = 
        'This is a sample IMAP server. You can use any mail client with I' +
        'MAP support to connect to this server.'
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
      Top = 159
      Width = 623
      Height = 204
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 4
    end
    object edtPort: TEdit
      Left = 56
      Top = 64
      Width = 161
      Height = 21
      TabOrder = 0
      Text = '143'
    end
    object edtRootDir: TEdit
      Left = 56
      Top = 92
      Width = 556
      Height = 21
      TabOrder = 1
      Text = 'C:\CleverMailBox\'
    end
  end
  object clImap4FileHandler1: TclImap4FileHandler
    Server = clImap4Server1
    MailBoxInfoFile = 'imap.dat'
    MessagesInfoFile = 'messages.dat'
    Left = 296
    Top = 128
  end
  object clImap4Server1: TclImap4Server
    ServerName = 'Clever Internet Suite IMAP4 service'
    OnStart = clImap4Server1Start
    OnStop = clImap4Server1Stop
    OnAcceptConnection = clImap4Server1AcceptConnection
    OnCloseConnection = clImap4Server1CloseConnection
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
    Left = 256
    Top = 128
  end
end
