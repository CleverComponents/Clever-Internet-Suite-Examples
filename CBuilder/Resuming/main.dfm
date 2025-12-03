inherited Form1: TForm1
  Left = 247
  Top = 55
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Resuming of the downloading - Sample'
  ClientHeight = 260
  OldCreateOrder = True
  OnClose = FormClose
  OnCloseQuery = FormCloseQuery
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 182
    object clProgressBar1: TclProgressBarDC
      Left = 12
      Top = 152
      Width = 599
      Height = 16
      InternetControl = DownLoader
    end
    object Label1: TLabel
      Left = 12
      Top = 59
      Width = 19
      Height = 13
      Caption = 'URL'
    end
    object Label2: TLabel
      Left = 11
      Top = 84
      Width = 46
      Height = 13
      Caption = 'File Name'
    end
    object Label3: TLabel
      Left = 14
      Top = 10
      Width = 587
      Height = 33
      AutoSize = False
      Caption = 
        'This Demo demonstrates how to store and then load the downloadin' +
        'g state. Please try to start the downloading and then stop it be' +
        'fore the process has completed.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object btnStart: TButton
      Left = 454
      Top = 114
      Width = 75
      Height = 25
      Caption = 'Start'
      TabOrder = 2
      OnClick = btnStartClick
    end
    object btnStop: TButton
      Left = 536
      Top = 114
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 3
      OnClick = btnStopClick
    end
    object edtFileName: TEdit
      Left = 64
      Top = 82
      Width = 548
      Height = 21
      TabOrder = 1
      OnChange = edtFileNameChange
    end
    object edtURL: TEdit
      Left = 64
      Top = 54
      Width = 548
      Height = 21
      TabOrder = 0
      OnChange = edtURLChange
    end
  end
  object DownLoader: TclDownLoader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    URL = 'https://www.clevercomponents.com/images/testimage.jpg'
    LocalFile = 'C:\downloads\testimage.jpg'
    OnStatusChanged = DownLoaderStatusChanged
    OnChanged = DownLoaderChanged
    LocalFolder = 'C:\'
    Left = 266
    Top = 189
  end
end
