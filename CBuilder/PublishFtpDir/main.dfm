inherited Form1: TForm1
  Left = 247
  Top = 114
  Caption = 'Publish FTP directory - Sample'
  Font.Name = 'MS Sans Serif'
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 24
      Top = 8
      Width = 537
      Height = 13
      Caption = 
        'This demo shows how to publish the local folder structure includ' +
        'ing sub-dirs and files into the remote FTP directory.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label2: TLabel
      Left = 24
      Top = 41
      Width = 315
      Height = 13
      Caption = 
        'Please specify the source folder and the  destination FTP direct' +
        'ory.'
    end
    object Label3: TLabel
      Left = 24
      Top = 67
      Width = 95
      Height = 13
      Caption = 'Source Local Folder'
    end
    object Label4: TLabel
      Left = 24
      Top = 92
      Width = 65
      Height = 13
      Caption = 'FTP Directory'
    end
    object Label5: TLabel
      Left = 24
      Top = 119
      Width = 45
      Height = 13
      Caption = 'FTP User'
    end
    object Label6: TLabel
      Left = 24
      Top = 144
      Width = 69
      Height = 13
      Caption = 'FTP Password'
    end
    object Label7: TLabel
      Left = 24
      Top = 203
      Width = 18
      Height = 13
      Caption = 'Log'
    end
    object Label8: TLabel
      Left = 272
      Top = 120
      Width = 82
      Height = 13
      Caption = 'Publish File Mask'
    end
    object edtLocalFolder: TEdit
      Left = 128
      Top = 65
      Width = 481
      Height = 21
      TabOrder = 0
      Text = 'c:\forpublish'
    end
    object edtFtpDir: TEdit
      Left = 128
      Top = 89
      Width = 481
      Height = 21
      TabOrder = 1
      Text = 'ftp://myserver/forpublish'
    end
    object edtUser: TEdit
      Left = 128
      Top = 115
      Width = 121
      Height = 21
      TabOrder = 2
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 128
      Top = 140
      Width = 121
      Height = 21
      PasswordChar = '*'
      TabOrder = 3
      Text = 'clevertester'
    end
    object cbPassiveMode: TCheckBox
      Left = 272
      Top = 143
      Width = 145
      Height = 17
      Caption = 'Use FTP Passive Mode'
      TabOrder = 4
    end
    object btnPublish: TButton
      Left = 23
      Top = 169
      Width = 75
      Height = 25
      Caption = 'Publish'
      TabOrder = 5
      OnClick = btnPublishClick
    end
    object btnStop: TButton
      Left = 127
      Top = 169
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 6
      OnClick = btnStopClick
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
    object memLog: TMemo
      Left = 0
      Top = 220
      Width = 623
      Height = 125
      Align = alBottom
      TabOrder = 7
    end
    object edtFileMask: TEdit
      Left = 360
      Top = 117
      Width = 105
      Height = 21
      TabOrder = 9
      Text = '*.*'
    end
  end
  object clMultiUploader: TclMultiUploader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    OnIsBusyChanged = clMultiUploaderIsBusyChanged
    OnProcessCompleted = clMultiUploaderProcessCompleted
    UploadList = <>
    ForceRemoteDir = True
    PublishFileMask = '*.*'
    OnPrepareItemToPublish = clMultiUploaderPrepareItemToPublish
    Left = 248
    Top = 256
  end
end
