inherited UploaderTest: TUploaderTest
  Left = 314
  Top = 55
  VertScrollBar.Range = 0
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'MultiUpLoader - Sample'
  Font.Name = 'MS Sans Serif'
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object PageControl: TPageControl
      Left = 0
      Top = 0
      Width = 623
      Height = 322
      ActivePage = tabTasks
      Align = alClient
      TabOrder = 0
      OnChange = PageControlChange
      object tabTasks: TTabSheet
        Caption = 'Tasks'
        object Panel2: TPanel
          Left = 0
          Top = 260
          Width = 615
          Height = 34
          Align = alBottom
          BevelOuter = bvNone
          TabOrder = 0
          object btnAdd: TButton
            Left = 456
            Top = 7
            Width = 72
            Height = 22
            Caption = 'Add'
            TabOrder = 0
            OnClick = btnAddClick
          end
          object btnDelete: TButton
            Left = 538
            Top = 7
            Width = 72
            Height = 22
            Caption = 'Delete'
            TabOrder = 1
            OnClick = btnDeleteClick
          end
        end
        object ListView: TListView
          Left = 0
          Top = 0
          Width = 615
          Height = 260
          Align = alClient
          Columns = <
            item
              Caption = 'File Name'
              Width = 250
            end
            item
              Caption = 'Progress'
              Width = 180
            end
            item
              Caption = 'Status'
              Width = 55
            end>
          GridLines = True
          HideSelection = False
          ReadOnly = True
          RowSelect = True
          TabOrder = 1
          ViewStyle = vsReport
          OnChange = ListViewChange
          OnDblClick = ListViewDblClick
        end
      end
      object tabDetails: TTabSheet
        Caption = 'Details'
        ImageIndex = 1
        object Label1: TLabel
          Left = 5
          Top = 12
          Width = 22
          Height = 13
          Caption = 'URL'
        end
        object Label6: TLabel
          Left = 346
          Top = 11
          Width = 22
          Height = 13
          Caption = 'User'
        end
        object Label9: TLabel
          Left = 346
          Top = 40
          Width = 46
          Height = 13
          Caption = 'Password'
        end
        object Label4: TLabel
          Left = 5
          Top = 189
          Width = 27
          Height = 13
          Caption = 'Errors'
        end
        object Label2: TLabel
          Left = 5
          Top = 38
          Width = 16
          Height = 13
          Caption = 'File'
        end
        object Label3: TLabel
          Left = 5
          Top = 71
          Width = 18
          Height = 13
          Caption = 'Info'
        end
        object Label11: TLabel
          Left = 5
          Top = 271
          Width = 31
          Height = 13
          Caption = 'Priority'
        end
        object edtURL: TEdit
          Left = 56
          Top = 7
          Width = 241
          Height = 21
          TabOrder = 0
          Text = 'edtURL'
          OnChange = edtURLChange
        end
        object edtUser: TEdit
          Left = 397
          Top = 7
          Width = 211
          Height = 21
          TabOrder = 2
          OnChange = edtUserChange
        end
        object edtPassword: TEdit
          Left = 397
          Top = 36
          Width = 211
          Height = 21
          PasswordChar = '*'
          TabOrder = 3
          OnChange = edtPasswordChange
        end
        object memErrors: TMemo
          Left = 56
          Top = 183
          Width = 552
          Height = 75
          ReadOnly = True
          TabOrder = 5
        end
        object edtFile: TEdit
          Left = 56
          Top = 36
          Width = 241
          Height = 21
          TabOrder = 1
          Text = 'edtFile'
          OnChange = edtFileChange
        end
        object memInfo: TMemo
          Left = 56
          Top = 65
          Width = 552
          Height = 104
          ReadOnly = True
          TabOrder = 4
        end
        object cmbPriority: TComboBox
          Left = 56
          Top = 268
          Width = 241
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 6
          OnChange = cmbPriorityChange
          Items.Strings = (
            'Lower'
            'Normal'
            'Higher')
        end
      end
      object tabOptions: TTabSheet
        Caption = 'Options'
        ImageIndex = 2
        object Label7: TLabel
          Left = 19
          Top = 40
          Width = 51
          Height = 13
          Caption = 'TimeOut, s'
        end
        object Bevel1: TBevel
          Left = 6
          Top = 98
          Width = 603
          Height = 187
          Shape = bsFrame
        end
        object Bevel2: TBevel
          Left = 6
          Top = 12
          Width = 603
          Height = 75
          Shape = bsFrame
        end
        object edtTimeOut: TEdit
          Left = 102
          Top = 38
          Width = 130
          Height = 21
          TabOrder = 0
          Text = '0'
          OnChange = edtTimeOutChange
        end
        object updTimeOut: TUpDown
          Left = 232
          Top = 38
          Width = 15
          Height = 21
          Associate = edtTimeOut
          Max = 32767
          TabOrder = 1
        end
      end
    end
    object Panel1: TPanel
      Left = 0
      Top = 322
      Width = 623
      Height = 41
      Align = alBottom
      BevelOuter = bvNone
      TabOrder = 1
      object btnGetInfo: TButton
        Left = 377
        Top = 10
        Width = 72
        Height = 22
        Caption = 'Get Info'
        TabOrder = 0
        OnClick = btnGetInfoClick
      end
      object btnStop: TButton
        Left = 459
        Top = 10
        Width = 72
        Height = 22
        Caption = 'Stop'
        TabOrder = 1
        OnClick = btnStopClick
      end
      object btnUpload: TButton
        Left = 541
        Top = 10
        Width = 72
        Height = 22
        Caption = 'Upload'
        TabOrder = 2
        OnClick = btnUploadClick
      end
    end
  end
  object clMultiUploader: TclMultiUploader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    OnIsBusyChanged = clMultiUploaderIsBusyChanged
    OnStatusChanged = clMultiUploaderStatusChanged
    OnGetResourceInfo = clMultiUploaderGetResourceInfo
    OnDataItemProceed = clMultiUploaderDataItemProceed
    OnChanged = clMultiUploaderChanged
    UploadList = <
      item
        URL = 'ftp://testhost1/testdir1/testfile1.txt'
        LocalFile = 'c:\testfile1.txt'
        UserName = 'myuser'
        RequestMethod = 'PUT'
      end
      item
        URL = 'http://www.domain.com/uploads/MultiUploader.dpr'
        LocalFile = 'MultiUploader.dpr'
        RequestMethod = 'PUT'
      end>
    PublishFileMask = '*.*'
    Left = 184
    Top = 8
  end
end
