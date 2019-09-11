inherited UploaderTest: TUploaderTest
  Left = 258
  Top = 189
  Caption = 'Single Uploader - Sample'
  Font.Name = 'Tahoma'
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 92
      Width = 22
      Height = 13
      Caption = 'URL'
    end
    object Label2: TLabel
      Left = 329
      Top = 90
      Width = 16
      Height = 13
      Caption = 'File'
    end
    object Label3: TLabel
      Left = 8
      Top = 278
      Width = 34
      Height = 13
      Caption = 'Current'
    end
    object Label4: TLabel
      Left = 8
      Top = 212
      Width = 27
      Height = 13
      Caption = 'Errors'
    end
    object Label6: TLabel
      Left = 8
      Top = 119
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label7: TLabel
      Left = 8
      Top = 143
      Width = 43
      Height = 13
      Caption = 'URL Info'
    end
    object Label9: TLabel
      Left = 328
      Top = 118
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object clProgressBar1: TclProgressBarDC
      Left = 59
      Top = 302
      Width = 554
      Height = 19
      Options = [dpDrawTotal]
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
      InternetControl = clUploader1
    end
    object Label5: TLabel
      Left = 16
      Top = 8
      Width = 477
      Height = 13
      Caption = 
        'This demo uploads the file to the server via the following Netwo' +
        'rk protocols: HTTP, HTTPS and FTP.'
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
    object Label8: TLabel
      Left = 16
      Top = 48
      Width = 559
      Height = 26
      Caption = 
        'Please note ! For uploading files via HTTP / HTTPS protocol, the' +
        ' "PUT" HTTP request method is used. So the HTTP server directory' +
        ' must have the appropriate security permissions. For IIS 6 serve' +
        'r, WebDAV must be enabled.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object btnUpload: TButton
      Left = 538
      Top = 328
      Width = 75
      Height = 25
      Caption = 'Upload'
      TabOrder = 9
      OnClick = btnUploadClick
    end
    object edtURL: TEdit
      Left = 58
      Top = 88
      Width = 234
      Height = 21
      TabOrder = 0
      Text = 'edtURL'
      OnChange = edtURLChange
    end
    object edtFile: TEdit
      Left = 379
      Top = 88
      Width = 234
      Height = 21
      TabOrder = 1
      Text = 'edtFile'
      OnChange = edtFileChange
    end
    object Edit1: TEdit
      Left = 58
      Top = 276
      Width = 555
      Height = 21
      ReadOnly = True
      TabOrder = 6
    end
    object btnGetInfo: TButton
      Left = 374
      Top = 328
      Width = 75
      Height = 25
      Caption = 'Get Info'
      TabOrder = 7
      OnClick = btnGetInfoClick
    end
    object memErrors: TMemo
      Left = 58
      Top = 208
      Width = 555
      Height = 61
      ReadOnly = True
      TabOrder = 5
    end
    object edtUser: TEdit
      Left = 58
      Top = 115
      Width = 235
      Height = 21
      TabOrder = 2
      OnChange = edtUserChange
    end
    object edtPassword: TEdit
      Left = 379
      Top = 114
      Width = 234
      Height = 21
      PasswordChar = '*'
      TabOrder = 3
      OnChange = edtPasswordChange
    end
    object btnStop: TButton
      Left = 456
      Top = 328
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 8
      OnClick = btnStopClick
    end
    object memInfo: TMemo
      Left = 58
      Top = 143
      Width = 555
      Height = 58
      ReadOnly = True
      TabOrder = 4
    end
  end
  object clUploader1: TclUploader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    URL = 'http://www.domain.com/uploads/Uploader.dpr'
    LocalFile = 'Uploader.dpr'
    OnStatusChanged = clUploader1StatusChanged
    OnGetResourceInfo = clUploader1GetResourceInfo
    OnDataItemProceed = clUploader1DataItemProceed
    OnError = clUploader1Error
    OnUrlParsing = clUploader1UrlParsing
    OnChanged = clUploader1Changed
    RequestMethod = 'PUT'
    Left = 184
    Top = 102
  end
end
