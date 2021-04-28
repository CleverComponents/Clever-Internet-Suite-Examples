inherited MainForm: TMainForm
  Left = 305
  Top = 153
  Height = 455
  ActiveControl = pgMain
  Caption = 'Clever SFTP Server'
  OldCreateOrder = True
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 339
    object pgMain: TPageControl
      Left = 0
      Top = 0
      Width = 623
      Height = 339
      ActivePage = tabServer
      Align = alClient
      TabOrder = 0
      object tabServer: TTabSheet
        Caption = 'Server'
        object Label2: TLabel
          Left = 15
          Top = 59
          Width = 57
          Height = 13
          Caption = 'Binding Port'
        end
        object Label3: TLabel
          Left = 15
          Top = 118
          Width = 39
          Height = 13
          Caption = 'Root Dir'
        end
        object Label1: TLabel
          Left = 15
          Top = 149
          Width = 56
          Height = 13
          Caption = 'Activity Log'
        end
        object Label5: TLabel
          Left = 15
          Top = 88
          Width = 22
          Height = 13
          Caption = 'Host'
        end
        object Label4: TLabel
          Left = 15
          Top = 7
          Width = 591
          Height = 32
          Caption = 
            'This is a sample SFTP server, which demonstrates the using of th' +
            'e TclSFtpServer, TclSFtpFileHandler, and TclServerGuard componen' +
            'ts.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object lblStatus: TLabel
          Left = 407
          Top = 88
          Width = 42
          Height = 16
          Caption = 'Started'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clRed
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
        end
        object edtPort: TEdit
          Left = 88
          Top = 56
          Width = 53
          Height = 21
          TabOrder = 0
          Text = '22'
        end
        object edtRootDir: TEdit
          Left = 88
          Top = 115
          Width = 361
          Height = 21
          TabOrder = 3
          Text = 'C:\CleverFtpServer\'
        end
        object btnStart: TButton
          Left = 472
          Top = 85
          Width = 115
          Height = 25
          Caption = 'Start'
          TabOrder = 4
          OnClick = btnStartClick
        end
        object btnStop: TButton
          Left = 472
          Top = 113
          Width = 115
          Height = 25
          Caption = 'Stop'
          TabOrder = 5
          OnClick = btnStopClick
        end
        object memLog: TMemo
          Left = 0
          Top = 168
          Width = 615
          Height = 143
          Align = alBottom
          ReadOnly = True
          ScrollBars = ssVertical
          TabOrder = 6
        end
        object edtBindingHost: TEdit
          Left = 88
          Top = 85
          Width = 161
          Height = 21
          TabOrder = 1
        end
        object cbUseIPv6: TCheckBox
          Left = 280
          Top = 89
          Width = 97
          Height = 17
          Caption = 'Use IPv6'
          TabOrder = 2
        end
      end
      object tabBanner: TTabSheet
        Caption = 'Banner'
        ImageIndex = 5
        object Label14: TLabel
          Left = 16
          Top = 41
          Width = 79
          Height = 13
          Caption = 'Banner Message'
        end
        object Label15: TLabel
          Left = 16
          Top = 7
          Width = 196
          Height = 16
          Caption = 'The SFTP Server Banner Settings.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object Label16: TLabel
          Left = 16
          Top = 71
          Width = 47
          Height = 13
          Caption = 'Language'
        end
        object edtBannerMessage: TEdit
          Left = 112
          Top = 38
          Width = 481
          Height = 21
          TabOrder = 0
        end
        object edtBannerLanguage: TEdit
          Left = 112
          Top = 68
          Width = 121
          Height = 21
          TabOrder = 1
          Text = 'en'
        end
        object cbEnableBanner: TCheckBox
          Left = 112
          Top = 101
          Width = 97
          Height = 17
          Caption = 'Enable Banner'
          TabOrder = 2
        end
      end
      object tabHostKey: TTabSheet
        Caption = 'Host Key'
        ImageIndex = 1
        object Label17: TLabel
          Left = 16
          Top = 125
          Width = 45
          Height = 13
          Caption = 'Key Type'
        end
        object Label18: TLabel
          Left = 16
          Top = 152
          Width = 54
          Height = 13
          Caption = 'Key Lenght'
        end
        object Label19: TLabel
          Left = 16
          Top = 62
          Width = 62
          Height = 13
          Caption = 'Host Key File'
        end
        object Label20: TLabel
          Left = 16
          Top = 187
          Width = 83
          Height = 13
          Caption = 'Fingerprint (md5)'
        end
        object Label21: TLabel
          Left = 16
          Top = 7
          Width = 497
          Height = 32
          Caption = 
            'You can load an existing private key or generate a new one. A ne' +
            'w key is saved to the Host Key File. TclSFtpServer supports only' +
            ' RSA host keys.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object Label22: TLabel
          Left = 16
          Top = 89
          Width = 58
          Height = 13
          Caption = 'Pass Phrase'
        end
        object edtKeyType: TEdit
          Left = 113
          Top = 122
          Width = 73
          Height = 21
          Enabled = False
          TabOrder = 3
          Text = 'ssh-rsa'
        end
        object edtKeyLength: TEdit
          Left = 113
          Top = 149
          Width = 112
          Height = 21
          TabOrder = 4
          Text = '2048'
        end
        object edtHostKeyFile: TEdit
          Left = 113
          Top = 59
          Width = 320
          Height = 21
          TabOrder = 0
          Text = 'host-key-rsa.key'
        end
        object edtFingerPrint: TEdit
          Left = 113
          Top = 184
          Width = 448
          Height = 21
          TabOrder = 6
        end
        object btnGenerateHostKey: TButton
          Left = 238
          Top = 147
          Width = 115
          Height = 25
          Caption = 'Generate'
          TabOrder = 5
          OnClick = btnGenerateHostKeyClick
        end
        object btnLoadHostKey: TButton
          Left = 446
          Top = 57
          Width = 115
          Height = 25
          Caption = 'Load'
          TabOrder = 2
          OnClick = btnLoadHostKeyClick
        end
        object edtHostKeyPassPhrase: TEdit
          Left = 113
          Top = 86
          Width = 121
          Height = 21
          PasswordChar = '*'
          TabOrder = 1
        end
      end
      object tabAccessControl: TTabSheet
        Caption = 'Access Control'
        ImageIndex = 2
        object Label9: TLabel
          Left = 16
          Top = 56
          Width = 52
          Height = 13
          Caption = 'User Name'
        end
        object Label10: TLabel
          Left = 16
          Top = 7
          Width = 506
          Height = 32
          Caption = 
            'This sample implements the only one user account. You can define' +
            ' all the desired users using the TclSFtpServer.UserAccounts prop' +
            'erty.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object Label11: TLabel
          Left = 278
          Top = 56
          Width = 46
          Height = 13
          Caption = 'Password'
        end
        object Label12: TLabel
          Left = 16
          Top = 88
          Width = 39
          Height = 13
          Caption = 'Root Dir'
        end
        object edtUserName: TEdit
          Left = 86
          Top = 53
          Width = 137
          Height = 21
          TabOrder = 0
          Text = 'CleverTester'
        end
        object edtPassword: TEdit
          Left = 342
          Top = 53
          Width = 137
          Height = 21
          TabOrder = 1
          Text = 'clevertester'
        end
        object edtUserRootDir: TEdit
          Left = 86
          Top = 85
          Width = 393
          Height = 21
          TabOrder = 2
        end
        object gbUserPermissions: TGroupBox
          Left = 86
          Top = 120
          Width = 393
          Height = 121
          Caption = 'User Permissions'
          TabOrder = 3
          object cbCanList: TCheckBox
            Left = 16
            Top = 24
            Width = 97
            Height = 17
            Caption = 'List'
            Checked = True
            State = cbChecked
            TabOrder = 0
          end
          object cbCanMakeDir: TCheckBox
            Left = 16
            Top = 47
            Width = 97
            Height = 17
            Caption = 'Make Dir'
            Checked = True
            State = cbChecked
            TabOrder = 1
          end
          object cbCanRemoveDir: TCheckBox
            Left = 16
            Top = 70
            Width = 97
            Height = 17
            Caption = 'Remove Dir'
            Checked = True
            State = cbChecked
            TabOrder = 2
          end
          object cbCanRead: TCheckBox
            Left = 141
            Top = 24
            Width = 97
            Height = 17
            Caption = 'Read'
            Checked = True
            State = cbChecked
            TabOrder = 3
          end
          object cbCanWrite: TCheckBox
            Left = 141
            Top = 47
            Width = 97
            Height = 17
            Caption = 'Write'
            Checked = True
            State = cbChecked
            TabOrder = 4
          end
          object cbCanRename: TCheckBox
            Left = 141
            Top = 70
            Width = 97
            Height = 17
            Caption = 'Rename'
            Checked = True
            State = cbChecked
            TabOrder = 5
          end
          object cbCanRemove: TCheckBox
            Left = 141
            Top = 93
            Width = 97
            Height = 17
            Caption = 'Remove'
            Checked = True
            State = cbChecked
            TabOrder = 6
          end
          object cbCanMakeLink: TCheckBox
            Left = 256
            Top = 24
            Width = 97
            Height = 17
            Caption = 'Make Link'
            Checked = True
            State = cbChecked
            TabOrder = 7
          end
          object cbCanReadLink: TCheckBox
            Left = 256
            Top = 47
            Width = 97
            Height = 17
            Caption = 'Read Link'
            Checked = True
            State = cbChecked
            TabOrder = 8
          end
        end
      end
      object tabIPBlocking: TTabSheet
        Caption = 'IP Blocking'
        ImageIndex = 3
        object Label6: TLabel
          Left = 17
          Top = 42
          Width = 249
          Height = 13
          Caption = 'Allowed Connections from the same host per minute'
        end
        object Label7: TLabel
          Left = 17
          Top = 69
          Width = 56
          Height = 13
          Caption = 'Black IP List'
        end
        object Label8: TLabel
          Left = 310
          Top = 69
          Width = 60
          Height = 13
          Caption = 'White IP List'
        end
        object Label13: TLabel
          Left = 17
          Top = 7
          Width = 167
          Height = 16
          Caption = 'The TclServerGuard settings.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object edtAllowedConnections: TEdit
          Left = 310
          Top = 39
          Width = 55
          Height = 21
          TabOrder = 0
          Text = '6'
        end
        object memBlackList: TMemo
          Left = 17
          Top = 88
          Width = 270
          Height = 127
          Lines.Strings = (
            '11.22.33.*'
            '44.55.66.77')
          ScrollBars = ssVertical
          TabOrder = 1
        end
        object memWhiteList: TMemo
          Left = 310
          Top = 88
          Width = 273
          Height = 128
          ScrollBars = ssVertical
          TabOrder = 2
        end
        object cbWhiteListOnly: TCheckBox
          Left = 312
          Top = 222
          Width = 159
          Height = 17
          Caption = 'Allow Whitelist only'
          TabOrder = 3
        end
      end
      object tabSSHAlgorithms: TTabSheet
        Caption = 'SSH Algorithms'
        ImageIndex = 4
        object Label23: TLabel
          Left = 16
          Top = 80
          Width = 68
          Height = 13
          Caption = 'Key Exchange'
        end
        object Label24: TLabel
          Left = 16
          Top = 112
          Width = 46
          Height = 13
          Caption = 'Signature'
        end
        object Label25: TLabel
          Left = 16
          Top = 144
          Width = 51
          Height = 13
          Caption = 'Encryption'
        end
        object Label26: TLabel
          Left = 16
          Top = 175
          Width = 68
          Height = 13
          Caption = 'Data Integrity'
        end
        object Label27: TLabel
          Left = 16
          Top = 7
          Width = 574
          Height = 48
          Caption = 
            'You can add/remove the supported SSH algorithms here. Note, if y' +
            'ou want to add a new algorithm, which is not yet implemented in ' +
            'the TclSFtpServer component, you need to register a correspondin' +
            'g class yourself within the TclSFtpServer.Config property.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object edtKexAlgs: TEdit
          Left = 104
          Top = 77
          Width = 481
          Height = 21
          TabOrder = 0
        end
        object edtSignatureAlgs: TEdit
          Left = 104
          Top = 109
          Width = 481
          Height = 21
          TabOrder = 1
        end
        object edtEncryptionAlgs: TEdit
          Left = 104
          Top = 141
          Width = 481
          Height = 21
          TabOrder = 2
        end
        object edtDataIntegrityAlgs: TEdit
          Left = 104
          Top = 172
          Width = 481
          Height = 21
          TabOrder = 3
        end
      end
      object tabAdditional: TTabSheet
        Caption = 'Additional Settings'
        ImageIndex = 6
        object Label28: TLabel
          Left = 17
          Top = 44
          Width = 67
          Height = 13
          Caption = 'Character Set'
        end
        object Label29: TLabel
          Left = 17
          Top = 76
          Width = 80
          Height = 13
          Caption = 'Max Return Files'
        end
        object Label30: TLabel
          Left = 17
          Top = 107
          Width = 75
          Height = 13
          Caption = 'Data Batch Size'
        end
        object Label31: TLabel
          Left = 17
          Top = 139
          Width = 83
          Height = 13
          Caption = 'Max Window Size'
        end
        object Label32: TLabel
          Left = 17
          Top = 7
          Width = 486
          Height = 16
          Caption = 
            'These settings are commonly used for fine tuning the data transf' +
            'erring performance.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -13
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          WordWrap = True
        end
        object edtCharSet: TEdit
          Left = 113
          Top = 41
          Width = 121
          Height = 21
          TabOrder = 0
        end
        object edtMaxReturnFiles: TEdit
          Left = 113
          Top = 73
          Width = 121
          Height = 21
          TabOrder = 1
        end
        object edtBatchSize: TEdit
          Left = 113
          Top = 104
          Width = 121
          Height = 21
          TabOrder = 2
        end
        object edtMaxWindowSize: TEdit
          Left = 113
          Top = 136
          Width = 121
          Height = 21
          TabOrder = 3
        end
      end
    end
  end
  object clServerGuard1: TclServerGuard
    Left = 433
    Top = 360
  end
  object clSFtpServer1: TclSFtpServer
    ServerName = 'Clever_Internet_Suite_Server'
    Guard = clServerGuard1
    OnStart = clSFtpServer1Start
    OnStop = clSFtpServer1Stop
    OnAcceptConnection = clSFtpServer1AcceptConnection
    OnCloseConnection = clSFtpServer1CloseConnection
    CharSet = 'utf-8'
    EnableBanner = False
    UserAccounts = <>
    OnReceiveRequest = clSFtpServer1ReceiveRequest
    OnSendResponse = clSFtpServer1SendResponse
    Left = 248
    Top = 360
  end
  object clSFtpFileHandler1: TclSFtpFileHandler
    Server = clSFtpServer1
    Left = 336
    Top = 360
  end
end
