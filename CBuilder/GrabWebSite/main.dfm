inherited Form1: TForm1
  Left = 248
  Top = 114
  Caption = 'Grab Website - Sample'
  Font.Name = 'Tahoma'
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 136
      Top = 16
      Width = 358
      Height = 13
      Caption = 
        'This demo downloads all website pages and available resources re' +
        'cursively.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label2: TLabel
      Left = 112
      Top = 40
      Width = 395
      Height = 13
      Caption = 
        'Please select the root website URL at which you want to start th' +
        'e grabbing process.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label3: TLabel
      Left = 16
      Top = 72
      Width = 48
      Height = 13
      Caption = 'Root URL'
    end
    object Label4: TLabel
      Left = 16
      Top = 104
      Width = 47
      Height = 13
      Caption = 'Target Dir'
    end
    object Label5: TLabel
      Left = 16
      Top = 232
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label6: TLabel
      Left = 352
      Top = 142
      Width = 74
      Height = 13
      Caption = 'Max Nest Level'
    end
    object edtRootUrl: TEdit
      Left = 71
      Top = 68
      Width = 540
      Height = 21
      TabOrder = 0
      Text = 'https://www.google.com'
    end
    object GroupBox1: TGroupBox
      Left = 16
      Top = 136
      Width = 321
      Height = 49
      Caption = 'Grab Options'
      TabOrder = 1
      object cbGrabAll: TCheckBox
        Left = 16
        Top = 20
        Width = 97
        Height = 17
        Caption = 'Grab All'
        TabOrder = 0
      end
      object cbGrabImages: TCheckBox
        Left = 112
        Top = 20
        Width = 89
        Height = 17
        Caption = 'Grab Images'
        Checked = True
        State = cbChecked
        TabOrder = 1
      end
      object cbGrabData: TCheckBox
        Left = 224
        Top = 20
        Width = 73
        Height = 17
        Caption = 'Grab Data'
        TabOrder = 2
      end
    end
    object edtTargetDir: TEdit
      Left = 71
      Top = 100
      Width = 540
      Height = 21
      TabOrder = 2
      Text = 'c:\downloads'
    end
    object btnGrab: TButton
      Left = 16
      Top = 196
      Width = 75
      Height = 25
      Caption = 'Grab'
      TabOrder = 3
      OnClick = btnGrabClick
    end
    object btnStop: TButton
      Left = 104
      Top = 196
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 4
      OnClick = btnStopClick
    end
    object memLog: TMemo
      Left = 0
      Top = 250
      Width = 623
      Height = 95
      Align = alBottom
      ReadOnly = True
      ScrollBars = ssVertical
      TabOrder = 5
    end
    object StatusBar1: TStatusBar
      Left = 0
      Top = 345
      Width = 623
      Height = 19
      Panels = <
        item
          Text = 'Ready'
          Width = 50
        end>
    end
    object edtMaxNestLevel: TEdit
      Left = 352
      Top = 160
      Width = 97
      Height = 21
      TabOrder = 7
      Text = '3'
    end
    object updMaxNestLevel: TUpDown
      Left = 449
      Top = 160
      Width = 16
      Height = 21
      Associate = edtMaxNestLevel
      Position = 3
      TabOrder = 8
    end
  end
  object clMultiDownLoader: TclMultiDownLoader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    OnIsBusyChanged = clMultiDownLoaderIsBusyChanged
    OnProcessCompleted = clMultiDownLoaderProcessCompleted
    DownLoadList = <>
    Left = 264
    Top = 288
  end
end
