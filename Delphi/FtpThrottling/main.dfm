inherited MainForm: TMainForm
  Left = 247
  Top = 62
  Caption = 'Ftp Client Throttling - Sample'
  Font.Name = 'MS Sans Serif'
  OnDestroy = FormDestroy
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 12
      Top = 77
      Width = 37
      Height = 13
      Caption = 'IP/Host'
    end
    object Label2: TLabel
      Left = 28
      Top = 104
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 223
      Top = 104
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 11
      Top = 132
      Width = 38
      Height = 13
      Caption = 'Start Dir'
    end
    object Label6: TLabel
      Left = 431
      Top = 76
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label7: TLabel
      Left = 11
      Top = 193
      Width = 62
      Height = 13
      Caption = 'Remote Host'
    end
    object Label8: TLabel
      Left = 11
      Top = 162
      Width = 89
      Height = 13
      Caption = 'Throttling, Bits/sec'
    end
    object Label3: TLabel
      Left = 16
      Top = 8
      Width = 337
      Height = 13
      Caption = 
        'This demo provides you with the ability to control the connectio' +
        'n speed.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label9: TLabel
      Left = 16
      Top = 28
      Width = 577
      Height = 33
      AutoSize = False
      Caption = 
        'Please use the BitsPerSec property of the TclFTP component to ch' +
        'ange the upper limit for throughput on the connection intercept.' +
        ' Zero value for this property switches off .'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object ProgressBar: TProgressBar
      Left = 0
      Top = 346
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 10
    end
    object edtServer: TEdit
      Left = 53
      Top = 74
      Width = 356
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 455
      Top = 74
      Width = 67
      Height = 21
      TabOrder = 1
      Text = '21'
    end
    object edtUser: TEdit
      Left = 53
      Top = 101
      Width = 137
      Height = 21
      TabOrder = 2
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 272
      Top = 101
      Width = 137
      Height = 21
      TabOrder = 3
      Text = 'clevertester'
    end
    object edtStartDir: TEdit
      Left = 53
      Top = 128
      Width = 356
      Height = 21
      TabOrder = 4
    end
    object cbPassiveMode: TCheckBox
      Left = 437
      Top = 103
      Width = 97
      Height = 17
      Caption = 'Passive Mode'
      TabOrder = 5
    end
    object cbAsciiMode: TCheckBox
      Left = 437
      Top = 130
      Width = 97
      Height = 17
      Caption = 'ASCII Mode'
      TabOrder = 6
    end
    object btnLogin: TButton
      Left = 537
      Top = 72
      Width = 75
      Height = 25
      Caption = 'Login'
      TabOrder = 11
      OnClick = btnLoginClick
    end
    object btnLogout: TButton
      Left = 537
      Top = 102
      Width = 75
      Height = 25
      Caption = 'Logout'
      TabOrder = 12
      OnClick = btnLogoutClick
    end
    object btnOpenDir: TButton
      Left = 537
      Top = 151
      Width = 75
      Height = 25
      Caption = 'Open Dir'
      TabOrder = 13
      OnClick = btnOpenDirClick
    end
    object btnGoUp: TButton
      Left = 537
      Top = 181
      Width = 75
      Height = 25
      Caption = 'Go Up'
      TabOrder = 14
      OnClick = btnGoUpClick
    end
    object btnDownload: TButton
      Left = 537
      Top = 222
      Width = 75
      Height = 25
      Caption = 'Download...'
      TabOrder = 15
      OnClick = btnDownloadClick
    end
    object btnUpload: TButton
      Left = 537
      Top = 252
      Width = 75
      Height = 25
      Caption = 'Upload...'
      TabOrder = 16
      OnClick = btnUploadClick
    end
    object btnAbort: TButton
      Left = 537
      Top = 307
      Width = 75
      Height = 25
      Caption = 'Abort'
      TabOrder = 17
      OnClick = btnAbortClick
    end
    object lbList: TListBox
      Left = 11
      Top = 210
      Width = 518
      Height = 124
      ItemHeight = 13
      Sorted = True
      TabOrder = 9
      OnDblClick = btnOpenDirClick
    end
    object edtBitsPerSec: TEdit
      Left = 104
      Top = 160
      Width = 241
      Height = 21
      TabOrder = 7
      Text = '3000000'
    end
    object btnApply: TButton
      Left = 352
      Top = 157
      Width = 57
      Height = 25
      Caption = 'Apply'
      TabOrder = 8
      OnClick = btnApplyClick
    end
  end
  object clFTP: TclFtp
    OnProgress = clFTPProgress
    OnDirectoryListing = clFTPDirectoryListing
    Left = 274
    Top = 218
  end
  object OpenDialog: TOpenDialog
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 434
    Top = 220
  end
  object SaveDialog: TSaveDialog
    Left = 352
    Top = 222
  end
end
