inherited MainForm: TMainForm
  Left = 192
  Top = 114
  Caption = 'Clever FTP Server SSL / TLS'
  Font.Name = 'Tahoma'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 8
      Top = 185
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label2: TLabel
      Left = 31
      Top = 106
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label3: TLabel
      Left = 11
      Top = 138
      Width = 39
      Height = 13
      Caption = 'Root Dir'
    end
    object Label4: TLabel
      Left = 8
      Top = 8
      Width = 572
      Height = 26
      Caption = 
        'This is a sample FTP SSL / TLS server. You can use any SSL-enabl' +
        'ed FTP client (such as TclFTP or SurgeFTP client to connect to t' +
        'his server.'
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
      Left = 8
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
      Left = 154
      Top = 106
      Width = 81
      Height = 13
      Caption = 'SSL / TLS Mode'
    end
    object btnStart: TButton
      Left = 56
      Top = 161
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 3
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 144
      Top = 161
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 4
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 201
      Width = 623
      Height = 163
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 5
    end
    object edtPort: TEdit
      Left = 56
      Top = 103
      Width = 57
      Height = 21
      TabOrder = 0
      Text = '990'
    end
    object edtRootDir: TEdit
      Left = 56
      Top = 134
      Width = 553
      Height = 21
      TabOrder = 2
      Text = 'C:\CleverFtpServer\'
    end
    object cbUseTls: TComboBox
      Left = 240
      Top = 103
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
  object clFtpServer1: TclFtpServer
    ServerName = 'Clever Internet Suite FTP service'
    OnStart = clFtpServer1Start
    OnStop = clFtpServer1Stop
    OnAcceptConnection = clFtpServer1AcceptConnection
    OnCloseConnection = clFtpServer1CloseConnection
    OnGetCertificate = clFtpServer1GetCertificate
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
    Left = 320
    Top = 336
  end
  object clFtpFileHandler1: TclFtpFileHandler
    Server = clFtpServer1
    Left = 360
    Top = 336
  end
  object clCertificateStore1: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40002.000000000000000000
    ValidTo = 40367.000000000000000000
    Left = 400
    Top = 336
  end
end
