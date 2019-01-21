inherited MainForm: TMainForm
  Left = 390
  Top = 112
  Height = 550
  Caption = 'Ftp Client SSL / TLS - Sample'
  Font.Name = 'MS Sans Serif'
  OnDestroy = FormDestroy
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 433
    object Label3: TLabel
      Left = 15
      Top = 294
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label1: TLabel
      Left = 11
      Top = 14
      Width = 37
      Height = 13
      Caption = 'IP/Host'
    end
    object Label2: TLabel
      Left = 11
      Top = 41
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 230
      Top = 40
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 11
      Top = 68
      Width = 38
      Height = 13
      Caption = 'Start Dir'
    end
    object Label6: TLabel
      Left = 433
      Top = 14
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label7: TLabel
      Left = 11
      Top = 120
      Width = 62
      Height = 13
      Caption = 'Remote Host'
    end
    object memLog: TMemo
      Left = 7
      Top = 313
      Width = 522
      Height = 89
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 9
    end
    object ProgressBar: TProgressBar
      Left = 0
      Top = 416
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 10
    end
    object edtServer: TEdit
      Left = 53
      Top = 10
      Width = 364
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 460
      Top = 10
      Width = 67
      Height = 21
      TabOrder = 1
      Text = '990'
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
      Left = 281
      Top = 37
      Width = 136
      Height = 21
      TabOrder = 3
      Text = 'clevertester'
    end
    object edtStartDir: TEdit
      Left = 53
      Top = 64
      Width = 364
      Height = 21
      TabOrder = 4
    end
    object cbPassiveMode: TCheckBox
      Left = 442
      Top = 39
      Width = 90
      Height = 17
      Caption = 'Passive Mode'
      Checked = True
      Enabled = False
      State = cbChecked
      TabOrder = 5
    end
    object cbAsciiMode: TCheckBox
      Left = 442
      Top = 66
      Width = 90
      Height = 17
      Caption = 'Ascii Mode'
      TabOrder = 6
    end
    object btnLogin: TButton
      Left = 539
      Top = 8
      Width = 75
      Height = 25
      Caption = 'Login'
      TabOrder = 11
      OnClick = btnLoginClick
    end
    object btnLogout: TButton
      Left = 539
      Top = 38
      Width = 75
      Height = 25
      Caption = 'Logout'
      TabOrder = 12
      OnClick = btnLogoutClick
    end
    object btnOpenDir: TButton
      Left = 539
      Top = 90
      Width = 75
      Height = 25
      Caption = 'Open Dir'
      TabOrder = 13
      OnClick = btnOpenDirClick
    end
    object btnGoUp: TButton
      Left = 539
      Top = 120
      Width = 75
      Height = 25
      Caption = 'Go Up'
      TabOrder = 14
      OnClick = btnGoUpClick
    end
    object btnMakeDir: TButton
      Left = 539
      Top = 158
      Width = 75
      Height = 25
      Caption = 'Make Dir...'
      TabOrder = 15
      OnClick = btnMakeDirClick
    end
    object btnRemoveDir: TButton
      Left = 539
      Top = 188
      Width = 75
      Height = 25
      Caption = 'Remove Dir'
      TabOrder = 16
      OnClick = btnRemoveDirClick
    end
    object btnDownload: TButton
      Left = 539
      Top = 226
      Width = 75
      Height = 25
      Caption = 'Download...'
      TabOrder = 17
      OnClick = btnDownloadClick
    end
    object btnUpload: TButton
      Left = 539
      Top = 256
      Width = 75
      Height = 25
      Caption = 'Upload...'
      TabOrder = 18
      OnClick = btnUploadClick
    end
    object btnDeleteFile: TButton
      Left = 539
      Top = 294
      Width = 75
      Height = 25
      Caption = 'Delete File'
      TabOrder = 19
      OnClick = btnDeleteFileClick
    end
    object btnRename: TButton
      Left = 539
      Top = 323
      Width = 75
      Height = 25
      Caption = 'Rename...'
      TabOrder = 20
      OnClick = btnRenameClick
    end
    object btnAbort: TButton
      Left = 539
      Top = 376
      Width = 75
      Height = 25
      Caption = 'Abort'
      TabOrder = 21
      OnClick = btnAbortClick
    end
    object lbList: TListBox
      Left = 7
      Top = 144
      Width = 522
      Height = 145
      ItemHeight = 13
      Sorted = True
      TabOrder = 8
      OnDblClick = btnOpenDirClick
    end
    object cbUseTLS: TCheckBox
      Left = 56
      Top = 96
      Width = 97
      Height = 17
      Caption = 'Use SSL / TLS'
      Checked = True
      State = cbChecked
      TabOrder = 7
      OnClick = cbUseTLSClick
    end
  end
  object clFTP: TclFtp
    OnVerifyServer = clFTPVerifyServer
    OnSendCommand = clFTPSendCommand
    OnReceiveResponse = clFTPReceiveResponse
    OnProgress = clFTPProgress
    OnDirectoryListing = clFTPDirectoryListing
    Left = 274
    Top = 170
  end
  object OpenDialog: TOpenDialog
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 434
    Top = 172
  end
  object SaveDialog: TSaveDialog
    Left = 352
    Top = 174
  end
end
