inherited MainForm: TMainForm
  Left = 367
  Top = 127
  Caption = 'SFTP Client'
  Font.Name = 'MS Sans Serif'
  OnDestroy = FormDestroy
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label3: TLabel
      Left = 15
      Top = 230
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label1: TLabel
      Left = 11
      Top = 13
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
      Left = 232
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
      Left = 440
      Top = 13
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label7: TLabel
      Left = 11
      Top = 91
      Width = 62
      Height = 13
      Caption = 'Remote Host'
    end
    object memLog: TMemo
      Left = 7
      Top = 249
      Width = 522
      Height = 89
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 6
    end
    object ProgressBar: TProgressBar
      Left = 0
      Top = 346
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 7
    end
    object edtServer: TEdit
      Left = 53
      Top = 10
      Width = 372
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 464
      Top = 10
      Width = 67
      Height = 21
      TabOrder = 1
      Text = '22'
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
      Left = 288
      Top = 37
      Width = 137
      Height = 21
      TabOrder = 3
      Text = 'clevertester'
    end
    object edtStartDir: TEdit
      Left = 53
      Top = 64
      Width = 372
      Height = 21
      TabOrder = 4
    end
    object btnLogin: TButton
      Left = 539
      Top = 7
      Width = 75
      Height = 25
      Caption = 'Login'
      TabOrder = 8
      OnClick = btnLoginClick
    end
    object btnLogout: TButton
      Left = 539
      Top = 37
      Width = 75
      Height = 25
      Caption = 'Logout'
      TabOrder = 9
      OnClick = btnLogoutClick
    end
    object btnOpenDir: TButton
      Left = 538
      Top = 77
      Width = 75
      Height = 25
      Caption = 'Open Dir'
      TabOrder = 10
      OnClick = btnOpenDirClick
    end
    object btnGoUp: TButton
      Left = 538
      Top = 107
      Width = 75
      Height = 25
      Caption = 'Go Up'
      TabOrder = 11
      OnClick = btnGoUpClick
    end
    object btnMakeDir: TButton
      Left = 538
      Top = 145
      Width = 75
      Height = 25
      Caption = 'Make Dir...'
      TabOrder = 12
      OnClick = btnMakeDirClick
    end
    object btnRemoveDir: TButton
      Left = 538
      Top = 175
      Width = 75
      Height = 25
      Caption = 'Remove Dir'
      TabOrder = 13
      OnClick = btnRemoveDirClick
    end
    object btnDownload: TButton
      Left = 538
      Top = 213
      Width = 75
      Height = 25
      Caption = 'Download...'
      TabOrder = 14
      OnClick = btnDownloadClick
    end
    object btnUpload: TButton
      Left = 538
      Top = 243
      Width = 75
      Height = 25
      Caption = 'Upload...'
      TabOrder = 15
      OnClick = btnUploadClick
    end
    object btnDeleteFile: TButton
      Left = 538
      Top = 282
      Width = 75
      Height = 25
      Caption = 'Delete File'
      TabOrder = 16
      OnClick = btnDeleteFileClick
    end
    object btnRename: TButton
      Left = 538
      Top = 311
      Width = 75
      Height = 25
      Caption = 'Rename...'
      TabOrder = 17
      OnClick = btnRenameClick
    end
    object lbList: TListBox
      Left = 7
      Top = 107
      Width = 522
      Height = 118
      ItemHeight = 13
      Sorted = True
      TabOrder = 5
      OnDblClick = btnOpenDirClick
    end
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
  object clSFtp1: TclSFtp
    SshAgent = 'Clever_Internet_Suite'
    OnSendCommand = clSFtp1SendCommand
    OnReceiveResponse = clSFtp1ReceiveResponse
    OnProgress = clSFtp1Progress
    OnVerifyServer = clSFtp1VerifyServer
    OnDirectoryListing = clSFtp1DirectoryListing
    OnShowBanner = clSFtp1ShowBanner
    Left = 224
    Top = 176
  end
end
