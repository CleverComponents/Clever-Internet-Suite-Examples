inherited DownLoaderTest: TDownLoaderTest
  Left = 187
  Top = 175
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'MultiDownLoader - Sample'
  ClientHeight = 509
  ClientWidth = 756
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  OnShow = FormShow
  ExplicitWidth = 762
  ExplicitHeight = 538
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlLogo: TPanel
    Width = 756
    ExplicitWidth = 756
    inherited imLogoMiggle: TImage
      Width = 141
      ExplicitWidth = 141
    end
    inherited imLogoRight: TImage
      Left = 547
      ExplicitLeft = 547
    end
  end
  inherited pnlMain: TPanel
    Width = 756
    Height = 431
    ExplicitWidth = 756
    ExplicitHeight = 431
    object PageControl: TPageControl
      Left = 0
      Top = 0
      Width = 756
      Height = 390
      ActivePage = tabTasks
      Align = alClient
      TabOrder = 0
      OnChange = PageControlChange
      object tabTasks: TTabSheet
        Caption = 'Downloading Files'
        object Panel2: TPanel
          Left = 0
          Top = 321
          Width = 748
          Height = 41
          Align = alBottom
          BevelOuter = bvNone
          TabOrder = 1
          object btnAdd: TButton
            Left = 426
            Top = 10
            Width = 72
            Height = 22
            Caption = 'Add New...'
            TabOrder = 0
            OnClick = btnAddClick
          end
          object btnDelete: TButton
            Left = 506
            Top = 10
            Width = 72
            Height = 22
            Caption = 'Delete'
            TabOrder = 1
            OnClick = btnDeleteClick
          end
          object btnDownLoad: TButton
            Left = 593
            Top = 10
            Width = 72
            Height = 22
            Caption = 'DownLoad'
            TabOrder = 2
            OnClick = btnDownLoadClick
          end
          object btnStop: TButton
            Left = 673
            Top = 10
            Width = 72
            Height = 22
            Caption = 'Stop'
            TabOrder = 3
            OnClick = btnStopClick
          end
        end
        object ListView: TListView
          Left = 0
          Top = 0
          Width = 748
          Height = 321
          Align = alClient
          Columns = <
            item
              Caption = 'URL'
              Width = 190
            end
            item
              Caption = 'Proceed'
              Width = 75
            end
            item
              Caption = 'Speed'
              Width = 75
            end
            item
              Caption = 'Elapsed'
              Width = 75
            end
            item
              Caption = 'Remained'
              Width = 75
            end
            item
              Caption = 'Status'
            end
            item
              Caption = 'Progress'
              Width = 190
            end>
          GridLines = True
          HideSelection = False
          ReadOnly = True
          RowSelect = True
          TabOrder = 0
          ViewStyle = vsReport
          OnAdvancedCustomDrawSubItem = ListViewAdvancedCustomDrawSubItem
          OnChange = ListViewChange
          OnDblClick = ListViewDblClick
        end
      end
      object tabDetails: TTabSheet
        Caption = 'File Info'
        ImageIndex = 1
        DesignSize = (
          748
          362)
        object Label1: TLabel
          Left = 5
          Top = 12
          Width = 19
          Height = 13
          Caption = 'URL'
        end
        object Label6: TLabel
          Left = 5
          Top = 61
          Width = 52
          Height = 13
          Caption = 'User Name'
        end
        object Label9: TLabel
          Left = 310
          Top = 62
          Width = 46
          Height = 13
          Caption = 'Password'
        end
        object Label4: TLabel
          Left = 5
          Top = 266
          Width = 120
          Height = 13
          Caption = 'Information Retrieve Log'
        end
        object Label5: TLabel
          Left = 389
          Top = 119
          Width = 99
          Height = 13
          Caption = 'File Content Preview'
        end
        object Label2: TLabel
          Left = 5
          Top = 34
          Width = 58
          Height = 13
          Caption = 'Save To File'
        end
        object Label3: TLabel
          Left = 5
          Top = 119
          Width = 56
          Height = 13
          Caption = 'Information'
        end
        object Label11: TLabel
          Left = 5
          Top = 87
          Width = 34
          Height = 13
          Caption = 'Priority'
        end
        object Label12: TLabel
          Left = 310
          Top = 87
          Width = 39
          Height = 13
          Caption = 'Threads'
        end
        object Bevel3: TBevel
          Left = 2
          Top = 112
          Width = 743
          Height = 4
          Anchors = [akLeft, akTop, akRight]
          Shape = bsTopLine
        end
        object edtURL: TEdit
          Left = 78
          Top = 7
          Width = 667
          Height = 21
          TabOrder = 0
          Text = 'edtURL'
          OnChange = edtURLChange
        end
        object edtUser: TEdit
          Left = 78
          Top = 58
          Width = 197
          Height = 21
          TabOrder = 2
          OnChange = edtUserChange
        end
        object edtPassword: TEdit
          Left = 366
          Top = 58
          Width = 197
          Height = 21
          PasswordChar = '*'
          TabOrder = 3
          OnChange = edtPasswordChange
        end
        object memErrors: TMemo
          Left = 5
          Top = 286
          Width = 740
          Height = 35
          ReadOnly = True
          TabOrder = 9
        end
        object edtFile: TEdit
          Left = 78
          Top = 32
          Width = 667
          Height = 21
          TabOrder = 1
          Text = 'edtFile'
          OnChange = edtFileChange
        end
        object memPreview: TMemo
          Left = 387
          Top = 141
          Width = 358
          Height = 119
          ReadOnly = True
          TabOrder = 8
        end
        object memInfo: TMemo
          Left = 5
          Top = 141
          Width = 372
          Height = 120
          ReadOnly = True
          TabOrder = 7
        end
        object cmbPriority: TComboBox
          Left = 78
          Top = 84
          Width = 197
          Height = 21
          Style = csDropDownList
          TabOrder = 4
          OnChange = cmbPriorityChange
          Items.Strings = (
            'Lower'
            'Normal'
            'Higher')
        end
        object edtThreadCount: TEdit
          Left = 366
          Top = 84
          Width = 182
          Height = 21
          TabOrder = 5
          Text = '1'
          OnChange = edtThreadCountChange
        end
        object updThreadCount: TUpDown
          Left = 548
          Top = 84
          Width = 16
          Height = 21
          Associate = edtThreadCount
          Min = 1
          Max = 10
          Position = 1
          TabOrder = 6
        end
        object btnGetInfo: TButton
          Left = 6
          Top = 332
          Width = 72
          Height = 22
          Caption = 'Get Info'
          TabOrder = 10
          OnClick = btnGetInfoClick
        end
        object btnStop1: TButton
          Left = 85
          Top = 332
          Width = 72
          Height = 22
          Caption = 'Stop'
          TabOrder = 11
          OnClick = btnStopClick
        end
        object btnAdd1: TButton
          Left = 512
          Top = 332
          Width = 72
          Height = 22
          Caption = 'Add New...'
          TabOrder = 12
          OnClick = btnAddClick
        end
        object btnDownload1: TButton
          Left = 592
          Top = 332
          Width = 72
          Height = 22
          Caption = 'DownLoad'
          TabOrder = 13
          OnClick = btnDownLoadClick
        end
        object btnCancel: TButton
          Left = 672
          Top = 332
          Width = 72
          Height = 22
          Caption = 'Cancel'
          TabOrder = 14
          OnClick = btnCancelClick
        end
      end
      object tabOptions: TTabSheet
        Caption = 'Options'
        ImageIndex = 2
        object Label8: TLabel
          Left = 19
          Top = 30
          Width = 67
          Height = 13
          Caption = 'Output Folder'
        end
        object Label7: TLabel
          Left = 19
          Top = 59
          Width = 52
          Height = 13
          Caption = 'TimeOut, s'
        end
        object Label10: TLabel
          Left = 19
          Top = 118
          Width = 70
          Height = 13
          Caption = 'Preview Count'
        end
        object Bevel1: TBevel
          Left = 6
          Top = 232
          Width = 736
          Height = 121
          Shape = bsFrame
        end
        object Bevel2: TBevel
          Left = 6
          Top = 10
          Width = 736
          Height = 207
          Shape = bsFrame
        end
        object Label13: TLabel
          Left = 411
          Top = 31
          Width = 56
          Height = 13
          Caption = 'HTTP Proxy'
        end
        object Label14: TLabel
          Left = 410
          Top = 88
          Width = 65
          Height = 13
          Caption = 'Proxy Bypass'
        end
        object Label15: TLabel
          Left = 18
          Top = 175
          Width = 52
          Height = 13
          Caption = 'Buffer Size'
        end
        object Label16: TLabel
          Left = 19
          Top = 88
          Width = 79
          Height = 13
          Caption = 'Reconnect After'
        end
        object Label17: TLabel
          Left = 19
          Top = 147
          Width = 48
          Height = 13
          Caption = 'Try Count'
        end
        object Label18: TLabel
          Left = 410
          Top = 117
          Width = 53
          Height = 13
          Caption = 'Proxy User'
        end
        object Label19: TLabel
          Left = 410
          Top = 147
          Width = 77
          Height = 13
          Caption = 'Proxy Password'
        end
        object Label20: TLabel
          Left = 656
          Top = 32
          Width = 20
          Height = 13
          Caption = 'Port'
        end
        object Label21: TLabel
          Left = 411
          Top = 60
          Width = 49
          Height = 13
          Caption = 'FTP Proxy'
        end
        object Label22: TLabel
          Left = 656
          Top = 61
          Width = 20
          Height = 13
          Caption = 'Port'
        end
        object edtDirectory: TEdit
          Left = 102
          Top = 27
          Width = 291
          Height = 21
          TabOrder = 0
          OnChange = edtDirectoryChange
        end
        object edtTimeOut: TEdit
          Left = 102
          Top = 56
          Width = 275
          Height = 21
          TabOrder = 1
          Text = '0'
          OnChange = edtTimeOutChange
        end
        object edtPreviewCharCount: TEdit
          Left = 102
          Top = 115
          Width = 275
          Height = 21
          TabOrder = 5
          Text = '0'
          OnChange = edtPreviewCharCountChange
        end
        object chkDownLoadNews: TCheckBox
          Left = 112
          Top = 285
          Width = 113
          Height = 17
          Caption = 'Check for News'
          Checked = True
          State = cbChecked
          TabOrder = 19
          OnClick = chkDownLoadNewsClick
        end
        object edtSiteNewsURL: TEdit
          Left = 231
          Top = 283
          Width = 375
          Height = 21
          Color = clBtnFace
          ReadOnly = True
          TabOrder = 20
        end
        object btnViewSiteNews: TButton
          Left = 617
          Top = 282
          Width = 72
          Height = 22
          Caption = 'View'
          TabOrder = 21
          OnClick = btnViewSiteNewsClick
        end
        object updTimeOut: TUpDown
          Left = 377
          Top = 56
          Width = 16
          Height = 21
          Associate = edtTimeOut
          Max = 32767
          TabOrder = 2
        end
        object updPreviewCount: TUpDown
          Left = 377
          Top = 115
          Width = 16
          Height = 21
          Associate = edtPreviewCharCount
          Max = 32767
          TabOrder = 6
        end
        object chkPassiveFTPMode: TCheckBox
          Left = 493
          Top = 173
          Width = 144
          Height = 17
          Caption = 'Passive FTP Mode'
          Checked = True
          State = cbChecked
          TabOrder = 18
          OnClick = chkPassiveFTPModeClick
        end
        object edtHttpProxy: TEdit
          Left = 492
          Top = 27
          Width = 157
          Height = 21
          TabOrder = 11
          OnChange = edtHttpProxyChange
        end
        object edtProxyBypass: TEdit
          Left = 492
          Top = 86
          Width = 237
          Height = 21
          TabOrder = 15
          OnChange = edtProxyBypassChange
        end
        object edtBatchSize: TEdit
          Left = 102
          Top = 173
          Width = 275
          Height = 21
          TabOrder = 9
          Text = '0'
          OnChange = edtBatchSizeChange
        end
        object updBatchSize: TUpDown
          Left = 377
          Top = 173
          Width = 15
          Height = 21
          Associate = edtBatchSize
          Max = 32767
          TabOrder = 10
        end
        object edtReconnectAfter: TEdit
          Left = 102
          Top = 85
          Width = 275
          Height = 21
          TabOrder = 3
          Text = '0'
          OnChange = edtReconnectAfterChange
        end
        object updReconnectAfter: TUpDown
          Left = 377
          Top = 85
          Width = 16
          Height = 21
          Associate = edtReconnectAfter
          Max = 32767
          TabOrder = 4
        end
        object edtTryCount: TEdit
          Left = 102
          Top = 144
          Width = 275
          Height = 21
          TabOrder = 7
          Text = '0'
          OnChange = edtTryCountChange
        end
        object updTryCount: TUpDown
          Left = 377
          Top = 144
          Width = 16
          Height = 21
          Associate = edtTryCount
          Max = 32767
          TabOrder = 8
        end
        object edtProxyUser: TEdit
          Left = 492
          Top = 115
          Width = 237
          Height = 21
          TabOrder = 16
          OnChange = edtProxyUserChange
        end
        object edtProxyPassword: TEdit
          Left = 492
          Top = 145
          Width = 237
          Height = 21
          PasswordChar = '*'
          TabOrder = 17
          OnChange = edtProxyPasswordChange
        end
        object edtHttpPort: TEdit
          Left = 682
          Top = 27
          Width = 47
          Height = 21
          TabOrder = 12
          Text = '0'
          OnChange = edtHttpPortChange
        end
        object edtFtpProxy: TEdit
          Left = 492
          Top = 56
          Width = 157
          Height = 21
          TabOrder = 13
          OnChange = edtFtpProxyChange
        end
        object edtFtpPort: TEdit
          Left = 682
          Top = 56
          Width = 47
          Height = 21
          TabOrder = 14
          Text = '0'
          OnChange = edtFtpPortChange
        end
      end
    end
    object Panel1: TPanel
      Left = 0
      Top = 390
      Width = 756
      Height = 41
      Align = alBottom
      BevelOuter = bvNone
      TabOrder = 1
      object clProgressBar: TclProgressBarDC
        Left = 16
        Top = 12
        Width = 178
        Height = 16
        Visible = False
        OnChanged = clProgressBarChanged
        InternetControl = clMultiDownLoader
      end
      object btnExit: TButton
        Left = 677
        Top = 10
        Width = 72
        Height = 22
        Caption = 'E&xit'
        TabOrder = 0
        OnClick = btnExitClick
      end
    end
  end
  object clMultiDownLoader: TclMultiDownLoader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    OnIsBusyChanged = clMultiDownLoaderIsBusyChanged
    OnStatusChanged = clMultiDownLoaderStatusChanged
    OnGetResourceInfo = clMultiDownLoaderGetResourceInfo
    OnDataItemProceed = clMultiDownLoaderDataItemProceed
    OnError = clMultiDownLoaderError
    OnChanged = clMultiDownLoaderChanged
    DownLoadList = <
      item
        URL = 'https://www.clevercomponents.com/images/testimage.jpg'
        LocalFile = 'c:\testimage.jpg'
      end>
    LocalFolder = 'c:\'
    OnDataTextProceed = clMultiDownLoaderDataTextProceed
    Left = 188
    Top = 40
  end
  object clNewsChecker: TclNewsChecker
    TryCount = 1
    TimeOut = 60000
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    ThreadCount = 1
    URL = 'https://www.clevercomponents.com/checknews/clnews.html'
    LocalFile = 'clnews.html'
    Priority = ppLower
    OnChanged = clNewsCheckerChanged
    OnNewsExist = clNewsCheckerNewsExist
    Left = 302
    Top = 38
  end
end
