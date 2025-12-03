inherited MainForm: TMainForm
  Left = 305
  Top = 153
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Clever FTP Server - Sample'
  OldCreateOrder = True
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label2: TLabel
      Left = 10
      Top = 58
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 104
      Top = 58
      Width = 39
      Height = 13
      Caption = 'Root Dir'
    end
    object Label4: TLabel
      Left = 8
      Top = 8
      Width = 389
      Height = 13
      Caption = 
        'This is a sample FTP server. You can use any FTP client to conne' +
        'ct to this server.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label5: TLabel
      Left = 8
      Top = 32
      Width = 452
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
    object Label1: TLabel
      Left = 9
      Top = 240
      Width = 17
      Height = 13
      Caption = 'Log'
    end
    object memLog: TMemo
      Left = 0
      Top = 256
      Width = 623
      Height = 108
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 3
    end
    object edtPort: TEdit
      Left = 36
      Top = 56
      Width = 53
      Height = 21
      TabOrder = 0
      Text = '21'
    end
    object edtRootDir: TEdit
      Left = 148
      Top = 56
      Width = 365
      Height = 21
      TabOrder = 1
      Text = 'C:\CleverFtpServer\'
    end
    object GroupBox1: TGroupBox
      Left = 8
      Top = 82
      Width = 505
      Height = 151
      Caption = 'Server Guard settings'
      TabOrder = 2
      object Label6: TLabel
        Left = 11
        Top = 16
        Width = 249
        Height = 13
        Caption = 'Allowed Connections from the same host per minute'
      end
      object Label7: TLabel
        Left = 11
        Top = 35
        Width = 56
        Height = 13
        Caption = 'Black IP List'
      end
      object Label8: TLabel
        Left = 336
        Top = 35
        Width = 60
        Height = 13
        Caption = 'White IP List'
      end
      object edtAllowedConnections: TEdit
        Left = 266
        Top = 13
        Width = 55
        Height = 21
        TabOrder = 0
        Text = '6'
      end
      object memBlackList: TMemo
        Left = 11
        Top = 54
        Width = 222
        Height = 67
        Lines.Strings = (
          '192.168.0.*'
          '212.121.0.1')
        ScrollBars = ssVertical
        TabOrder = 1
      end
      object memWhiteList: TMemo
        Left = 267
        Top = 54
        Width = 222
        Height = 67
        ScrollBars = ssVertical
        TabOrder = 2
      end
      object cbWhiteListOnly: TCheckBox
        Left = 266
        Top = 124
        Width = 159
        Height = 17
        Caption = 'Allow Whitelist only'
        TabOrder = 3
      end
    end
    object btnStop: TButton
      Left = 533
      Top = 87
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 4
      OnClick = btnStopClick
    end
    object btnStart: TButton
      Left = 533
      Top = 53
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 5
      OnClick = btnStartClick
    end
  end
  object clFtpServer1: TclFtpServer
    ServerName = 'Clever Internet Suite FTP service'
    Guard = clServerGuard1
    OnStart = clFtpServer1Start
    OnStop = clFtpServer1Stop
    OnAcceptConnection = clFtpServer1AcceptConnection
    OnCloseConnection = clFtpServer1CloseConnection
    MaxDataSize = -1
    OnReceiveCommand = clFtpServer1ReceiveCommand
    OnSendResponse = clFtpServer1SendResponse
    AllowAnonymousAccess = True
    UserAccounts = <
      item
        UserName = 'CleverTester'
        Password = 'clevertester'
        DisplayName = 'Clever Tester'
      end>
    CaseInsensitive = True
    ServerOS = 'Windows 9x/NT.'
    Extensions.Strings = (
      'SIZE'
      'REST STREAM'
      'MDTM')
    OnAuthenticate = clFtpServer1Authenticate
    Left = 361
    Top = 228
  end
  object clFtpFileHandler1: TclFtpFileHandler
    Server = clFtpServer1
    Left = 393
    Top = 228
  end
  object clServerGuard1: TclServerGuard
    Left = 425
    Top = 228
  end
end
