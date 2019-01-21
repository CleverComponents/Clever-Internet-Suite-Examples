inherited Form1: TForm1
  Left = 192
  Top = 114
  Height = 278
  Caption = 'File encrypt/decrypt - Sample'
  Font.Name = 'MS Sans Serif'
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 161
    object Label1: TLabel
      Left = 24
      Top = 8
      Width = 585
      Height = 25
      AutoSize = False
      Caption = 
        'This sample demonstrates using the TclEncryptor component for en' +
        'crypting / decrypting data stream with digital certificate.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label2: TLabel
      Left = 16
      Top = 49
      Width = 53
      Height = 13
      Caption = 'Source File'
    end
    object Label3: TLabel
      Left = 16
      Top = 80
      Width = 72
      Height = 13
      Caption = 'Destination File'
    end
    object btnEncrypt: TButton
      Left = 48
      Top = 106
      Width = 121
      Height = 25
      Caption = 'Encrypt File'
      TabOrder = 4
      OnClick = btnEncryptClick
    end
    object btnDecrypt: TButton
      Left = 216
      Top = 106
      Width = 121
      Height = 25
      Caption = 'Decrypt File'
      TabOrder = 5
      OnClick = btnDecryptClick
    end
    object edtSource: TEdit
      Left = 96
      Top = 46
      Width = 489
      Height = 21
      TabOrder = 0
    end
    object btnSource: TButton
      Left = 589
      Top = 45
      Width = 22
      Height = 22
      Caption = '...'
      TabOrder = 1
      OnClick = btnSourceClick
    end
    object edtDestination: TEdit
      Left = 96
      Top = 78
      Width = 489
      Height = 21
      TabOrder = 2
    end
    object btnDestination: TButton
      Left = 589
      Top = 77
      Width = 22
      Height = 22
      Caption = '...'
      TabOrder = 3
      OnClick = btnDestinationClick
    end
    object ProgressBar1: TProgressBar
      Left = 0
      Top = 144
      Width = 623
      Height = 17
      Align = alBottom
      TabOrder = 6
    end
  end
  object OpenDialog1: TOpenDialog
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 272
    Top = 56
  end
  object SaveDialog1: TSaveDialog
    Left = 272
    Top = 88
  end
  object clEncryptor1: TclEncryptor
    SignAlgorithm = '1.2.840.113549.1.1.5'
    EncryptAlgorithm = '1.2.840.113549.3.2'
    OnProgress = clEncryptor1Progress
    Left = 216
    Top = 40
  end
end
