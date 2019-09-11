inherited DownLoaderTest: TDownLoaderTest
  Left = 258
  Top = 189
  Caption = 'Single DownLoader - Sample'
  Font.Name = 'Tahoma'
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 7
      Top = 52
      Width = 22
      Height = 13
      Caption = 'URL'
    end
    object Label2: TLabel
      Left = 333
      Top = 77
      Width = 16
      Height = 13
      Caption = 'File'
    end
    object Label3: TLabel
      Left = 7
      Top = 281
      Width = 37
      Height = 13
      Caption = 'Statistic'
    end
    object Label5: TLabel
      Left = 331
      Top = 131
      Width = 38
      Height = 13
      Caption = 'Preview'
    end
    object Label4: TLabel
      Left = 9
      Top = 221
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label6: TLabel
      Left = 7
      Top = 79
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label7: TLabel
      Left = 7
      Top = 132
      Width = 43
      Height = 13
      Caption = 'URL Info'
    end
    object Label8: TLabel
      Left = 332
      Top = 51
      Width = 13
      Height = 13
      Caption = 'Dir'
    end
    object Label9: TLabel
      Left = 7
      Top = 107
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object clProgressBar1: TclProgressBarDC
      Left = 59
      Top = 305
      Width = 555
      Height = 19
      DrawScheme = dsCustom
      ProgressSplit = 50
      Colors.BackGround = clWindow
      ThemedStyles.Bar = 11
      ThemedStyles.BarState = 2
      ThemedStyles.Item = 5
      ThemedStyles.ItemStates.StatusUnknown = 4
      ThemedStyles.ItemStates.StatusSuccess = 1
      ThemedStyles.ItemStates.StatusFailed = 2
      ThemedStyles.ItemStates.StatusErrors = 3
      ThemedStyles.ItemStates.StatusProcess = 4
      ThemedStyles.ItemStates.StatusTerminated = 4
      ThemedStyles.Total = 5
      ThemedStyles.TotalStates.StatusUnknown = 1
      ThemedStyles.TotalStates.StatusSuccess = 1
      ThemedStyles.TotalStates.StatusFailed = 2
      ThemedStyles.TotalStates.StatusErrors = 3
      ThemedStyles.TotalStates.StatusProcess = 1
      ThemedStyles.TotalStates.StatusTerminated = 1
      ThemedStyles.PulseOverlay = 7
      InternetControl = clDownLoader1
    end
    object Label10: TLabel
      Left = 331
      Top = 105
      Width = 39
      Height = 13
      Caption = 'Threads'
    end
    object Label11: TLabel
      Left = 477
      Top = 105
      Width = 28
      Height = 13
      Caption = 'Buffer'
    end
    object Label12: TLabel
      Left = 16
      Top = 6
      Width = 471
      Height = 13
      Caption = 
        'This demo downloads files from server via the following Network ' +
        'protocols: HTTP, HTTPS and FTP.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label13: TLabel
      Left = 16
      Top = 24
      Width = 459
      Height = 13
      Caption = 
        'Please set the "http://" URL value for HTTP protocol, "https://"' +
        ' for HTTPS and "ftp://" for FTP.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object btnDownLoad: TButton
      Left = 539
      Top = 330
      Width = 75
      Height = 25
      Caption = 'DownLoad'
      TabOrder = 15
      OnClick = btnDownLoadClick
    end
    object edtURL: TEdit
      Left = 57
      Top = 48
      Width = 240
      Height = 21
      TabOrder = 0
      Text = 'edtURL'
      OnChange = edtURLChange
    end
    object edtFile: TEdit
      Left = 373
      Top = 75
      Width = 241
      Height = 21
      TabOrder = 4
      Text = 'edtFile'
      OnChange = edtFileChange
    end
    object memPreview: TMemo
      Left = 373
      Top = 132
      Width = 241
      Height = 78
      ReadOnly = True
      TabOrder = 10
    end
    object edtStatistic: TEdit
      Left = 58
      Top = 279
      Width = 555
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 12
    end
    object btnGetInfo: TButton
      Left = 375
      Top = 330
      Width = 75
      Height = 25
      Caption = 'Get Info'
      TabOrder = 13
      OnClick = btnGetInfoClick
    end
    object memErrors: TMemo
      Left = 58
      Top = 219
      Width = 555
      Height = 51
      ReadOnly = True
      TabOrder = 11
    end
    object edtUser: TEdit
      Left = 58
      Top = 75
      Width = 240
      Height = 21
      TabOrder = 1
      OnChange = edtUserChange
    end
    object edtPassword: TEdit
      Left = 58
      Top = 103
      Width = 240
      Height = 21
      PasswordChar = '*'
      TabOrder = 2
      OnChange = edtPasswordChange
    end
    object btnStop: TButton
      Left = 457
      Top = 330
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 14
      OnClick = btnStopClick
    end
    object memInfo: TMemo
      Left = 58
      Top = 132
      Width = 240
      Height = 78
      ReadOnly = True
      TabOrder = 9
    end
    object edtDirectory: TEdit
      Left = 373
      Top = 48
      Width = 240
      Height = 21
      TabOrder = 3
      OnChange = edtDirectoryChange
    end
    object edtThreadCount: TEdit
      Left = 373
      Top = 103
      Width = 81
      Height = 21
      TabOrder = 5
      Text = '0'
      OnChange = edtThreadCountChange
    end
    object edtBufferSize: TEdit
      Left = 511
      Top = 103
      Width = 87
      Height = 21
      TabOrder = 7
      Text = '0'
      OnChange = edtBufferSizeChange
    end
    object updBufferSize: TUpDown
      Left = 598
      Top = 103
      Width = 16
      Height = 21
      Associate = edtBufferSize
      Max = 32767
      TabOrder = 8
    end
    object updThreadCount: TUpDown
      Left = 454
      Top = 103
      Width = 16
      Height = 21
      Associate = edtThreadCount
      TabOrder = 6
    end
  end
  object clDownLoader1: TclDownLoader
    BatchSize = 4096
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    ThreadCount = 2
    URL = 'https://www.clevercomponents.com/images/testimage.jpg'
    LocalFile = 'c:\testimage.jpg'
    OnStatusChanged = clDownLoader1StatusChanged
    OnGetResourceInfo = clDownLoader1GetResourceInfo
    OnDataItemProceed = clDownLoader1DataItemProceed
    OnError = clDownLoader1Error
    OnUrlParsing = clDownLoader1UrlParsing
    OnChanged = clDownLoader1Changed
    LocalFolder = 'c:\'
    OnDataTextProceed = clDownLoader1DataTextProceed
    Left = 154
    Top = 57
  end
end
