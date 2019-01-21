inherited Form1: TForm1
  Left = 192
  Top = 114
  Caption = 'GZip / Deflate - Sample'
  ClientHeight = 255
  Font.Name = 'MS Sans Serif'
  ExplicitHeight = 293
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 177
    ExplicitHeight = 177
    object Label1: TLabel
      Left = 8
      Top = 8
      Width = 577
      Height = 33
      AutoSize = False
      Caption = 
        'This sample demonstrates using the TclGZip component for deflati' +
        'ng / inflating data stream.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label2: TLabel
      Left = 13
      Top = 63
      Width = 53
      Height = 13
      Caption = 'Source File'
    end
    object Label3: TLabel
      Left = 13
      Top = 96
      Width = 72
      Height = 13
      Caption = 'Destination File'
    end
    object Label4: TLabel
      Left = 7
      Top = 32
      Width = 578
      Height = 33
      AutoSize = False
      Caption = 
        'The deflated file is not compatible with WinZip file format sinc' +
        'e it does not contain the description header.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object btnCompress: TButton
      Left = 93
      Top = 123
      Width = 121
      Height = 25
      Caption = 'Compress File'
      TabOrder = 4
      OnClick = btnCompressClick
    end
    object btnUncompress: TButton
      Left = 221
      Top = 123
      Width = 121
      Height = 25
      Caption = 'Uncompress File'
      TabOrder = 5
      OnClick = btnUncompressClick
    end
    object edtSource: TEdit
      Left = 93
      Top = 60
      Width = 488
      Height = 21
      TabOrder = 0
    end
    object btnSource: TButton
      Left = 586
      Top = 58
      Width = 25
      Height = 25
      Caption = '...'
      TabOrder = 1
      OnClick = btnSourceClick
    end
    object edtDestination: TEdit
      Left = 93
      Top = 93
      Width = 488
      Height = 21
      TabOrder = 2
    end
    object btnDestination: TButton
      Left = 586
      Top = 91
      Width = 25
      Height = 25
      Caption = '...'
      TabOrder = 3
      OnClick = btnDestinationClick
    end
    object ProgressBar1: TProgressBar
      Left = 0
      Top = 160
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 6
    end
  end
  object OpenDialog1: TOpenDialog
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 272
    Top = 112
  end
  object SaveDialog1: TSaveDialog
    Left = 272
    Top = 144
  end
  object clGZip1: TclGZip
    OnProgress = clGZip1Progress
    Left = 208
    Top = 80
  end
end
