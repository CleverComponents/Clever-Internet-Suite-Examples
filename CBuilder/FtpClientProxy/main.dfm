inherited MainForm: TMainForm
  Left = 234
  Top = 115
  Caption = 'FTP Client over Proxy'
  OnDestroy = FormDestroy
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 11
      Top = 14
      Width = 36
      Height = 13
      Caption = 'IP/Host'
    end
    object Label2: TLabel
      Left = 27
      Top = 40
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 216
      Top = 40
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 11
      Top = 68
      Width = 40
      Height = 13
      Caption = 'Start Dir'
    end
    object Label6: TLabel
      Left = 439
      Top = 13
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object Label7: TLabel
      Left = 11
      Top = 192
      Width = 62
      Height = 13
      Caption = 'Remote Host'
    end
    object Bevel1: TBevel
      Left = 8
      Top = 96
      Width = 522
      Height = 2
    end
    object Label3: TLabel
      Left = 13
      Top = 110
      Width = 63
      Height = 13
      Caption = 'Proxy Server'
    end
    object Label8: TLabel
      Left = 311
      Top = 136
      Width = 77
      Height = 13
      Caption = 'Proxy Password'
    end
    object Label9: TLabel
      Left = 409
      Top = 109
      Width = 51
      Height = 13
      Caption = 'Proxy Port'
    end
    object Label10: TLabel
      Left = 23
      Top = 135
      Width = 53
      Height = 13
      Caption = 'Proxy User'
    end
    object Label11: TLabel
      Left = 22
      Top = 162
      Width = 55
      Height = 13
      Caption = 'Proxy Type'
    end
    object ProgressBar: TProgressBar
      Left = 0
      Top = 346
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 14
    end
    object edtServer: TEdit
      Left = 53
      Top = 10
      Width = 356
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 462
      Top = 10
      Width = 67
      Height = 21
      TabOrder = 1
      Text = '21'
    end
    object edtUser: TEdit
      Left = 53
      Top = 37
      Width = 137
      Height = 21
      TabOrder = 2
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 272
      Top = 37
      Width = 137
      Height = 21
      PasswordChar = '*'
      TabOrder = 3
      Text = 'clevertester'
    end
    object edtStartDir: TEdit
      Left = 53
      Top = 64
      Width = 356
      Height = 21
      TabOrder = 4
    end
    object cbPassiveMode: TCheckBox
      Left = 443
      Top = 39
      Width = 90
      Height = 17
      Caption = 'Passive Mode'
      Checked = True
      State = cbChecked
      TabOrder = 5
    end
    object cbAsciiMode: TCheckBox
      Left = 443
      Top = 66
      Width = 90
      Height = 17
      Caption = 'ASCII Mode'
      TabOrder = 6
    end
    object btnLogin: TButton
      Left = 538
      Top = 8
      Width = 75
      Height = 25
      Caption = 'Login'
      TabOrder = 11
      OnClick = btnLoginClick
    end
    object btnLogout: TButton
      Left = 538
      Top = 38
      Width = 75
      Height = 25
      Caption = 'Logout'
      TabOrder = 12
      OnClick = btnLogoutClick
    end
    object btnOpenDir: TButton
      Left = 538
      Top = 94
      Width = 75
      Height = 25
      Caption = 'Open Dir'
      TabOrder = 15
      OnClick = btnOpenDirClick
    end
    object btnGoUp: TButton
      Left = 538
      Top = 124
      Width = 75
      Height = 25
      Caption = 'Go Up'
      TabOrder = 16
      OnClick = btnGoUpClick
    end
    object btnDownload: TButton
      Left = 538
      Top = 153
      Width = 75
      Height = 25
      Caption = 'Download...'
      TabOrder = 17
      OnClick = btnDownloadClick
    end
    object btnUpload: TButton
      Left = 538
      Top = 183
      Width = 75
      Height = 25
      Caption = 'Upload...'
      TabOrder = 18
      OnClick = btnUploadClick
    end
    object btnAbort: TButton
      Left = 538
      Top = 312
      Width = 75
      Height = 25
      Caption = 'Abort'
      TabOrder = 19
      OnClick = btnAbortClick
    end
    object lbList: TListBox
      Left = 7
      Top = 209
      Width = 522
      Height = 130
      ItemHeight = 13
      Sorted = True
      TabOrder = 13
      OnDblClick = btnOpenDirClick
    end
    object edtProxyServer: TEdit
      Left = 80
      Top = 106
      Width = 281
      Height = 21
      TabOrder = 7
      Text = 'proxy'
    end
    object edtProxyUser: TEdit
      Left = 80
      Top = 133
      Width = 150
      Height = 21
      TabOrder = 9
    end
    object edtProxyPassword: TEdit
      Left = 390
      Top = 133
      Width = 139
      Height = 21
      PasswordChar = '*'
      TabOrder = 10
    end
    object edtProxyPort: TEdit
      Left = 462
      Top = 106
      Width = 67
      Height = 21
      TabOrder = 8
      Text = '8080'
    end
    object cbProxyType: TComboBox
      Left = 80
      Top = 160
      Width = 283
      Height = 21
      Style = csDropDownList
      ItemIndex = 8
      TabOrder = 20
      Text = 'HTTP Connect'
      Items.Strings = (
        'None'
        'UserSite'
        'Site'
        'Open'
        'UserPass'
        'Transparent'
        'Custom (OnCustomFtpProxy event handler required)'
        'Account'
        'HTTP Connect')
    end
  end
  object clFTP: TclFtp
    OnProgress = clFTPProgress
    OnDirectoryListing = clFTPDirectoryListing
    Left = 282
    Top = 282
  end
  object OpenDialog: TOpenDialog
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 442
    Top = 284
  end
  object SaveDialog: TSaveDialog
    Left = 360
    Top = 286
  end
end
