inherited MainForm: TMainForm
  Top = 122
  Height = 550
  Caption = 'Ftp Client - Sample'
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
      Left = 26
      Top = 39
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
      Width = 38
      Height = 13
      Caption = 'Start Dir'
    end
    object Label6: TLabel
      Left = 430
      Top = 12
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label7: TLabel
      Left = 11
      Top = 96
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
      TabOrder = 8
    end
    object ProgressBar: TProgressBar
      Left = 0
      Top = 416
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 9
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
      Left = 456
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
      Left = 437
      Top = 39
      Width = 90
      Height = 17
      Caption = 'Passive Mode'
      TabOrder = 5
    end
    object cbAsciiMode: TCheckBox
      Left = 437
      Top = 66
      Width = 90
      Height = 17
      Caption = 'ASCII Mode'
      TabOrder = 6
    end
    object btnLogin: TButton
      Left = 540
      Top = 8
      Width = 75
      Height = 25
      Caption = 'Login'
      TabOrder = 10
      OnClick = btnLoginClick
    end
    object btnLogout: TButton
      Left = 540
      Top = 38
      Width = 75
      Height = 25
      Caption = 'Logout'
      TabOrder = 11
      OnClick = btnLogoutClick
    end
    object btnOpenDir: TButton
      Left = 540
      Top = 90
      Width = 75
      Height = 25
      Caption = 'Open Dir'
      TabOrder = 12
      OnClick = btnOpenDirClick
    end
    object btnGoUp: TButton
      Left = 540
      Top = 120
      Width = 75
      Height = 25
      Caption = 'Go Up'
      TabOrder = 13
      OnClick = btnGoUpClick
    end
    object btnMakeDir: TButton
      Left = 540
      Top = 158
      Width = 75
      Height = 25
      Caption = 'Make Dir...'
      TabOrder = 14
      OnClick = btnMakeDirClick
    end
    object btnRemoveDir: TButton
      Left = 540
      Top = 188
      Width = 75
      Height = 25
      Caption = 'Remove Dir'
      TabOrder = 15
      OnClick = btnRemoveDirClick
    end
    object btnDownload: TButton
      Left = 540
      Top = 226
      Width = 75
      Height = 25
      Caption = 'Download...'
      TabOrder = 16
      OnClick = btnDownloadClick
    end
    object btnUpload: TButton
      Left = 540
      Top = 256
      Width = 75
      Height = 25
      Caption = 'Upload...'
      TabOrder = 17
      OnClick = btnUploadClick
    end
    object btnDeleteFile: TButton
      Left = 540
      Top = 294
      Width = 75
      Height = 25
      Caption = 'Delete File'
      TabOrder = 18
      OnClick = btnDeleteFileClick
    end
    object btnRename: TButton
      Left = 540
      Top = 323
      Width = 75
      Height = 25
      Caption = 'Rename...'
      TabOrder = 19
      OnClick = btnRenameClick
    end
    object btnAbort: TButton
      Left = 540
      Top = 376
      Width = 75
      Height = 25
      Caption = 'Abort'
      TabOrder = 20
      OnClick = btnAbortClick
    end
    object lbList: TListBox
      Left = 7
      Top = 112
      Width = 522
      Height = 173
      ItemHeight = 13
      Sorted = True
      TabOrder = 7
      OnDblClick = btnOpenDirClick
    end
  end
  object clFTP: TclFtp
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
