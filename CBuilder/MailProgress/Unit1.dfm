inherited Form1: TForm1
  Left = 247
  Top = 114
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Mail Progress - Sample'
  OldCreateOrder = True
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 9
      Top = 14
      Width = 32
      Height = 13
      Caption = 'Server'
    end
    object Label2: TLabel
      Left = 9
      Top = 41
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label3: TLabel
      Left = 9
      Top = 72
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label4: TLabel
      Left = 9
      Top = 98
      Width = 24
      Height = 13
      Caption = 'From'
    end
    object Label5: TLabel
      Left = 9
      Top = 124
      Width = 12
      Height = 13
      Caption = 'To'
    end
    object lblProgress: TLabel
      Left = 9
      Top = 335
      Width = 11
      Height = 13
      Caption = '%'
    end
    object Label6: TLabel
      Left = 9
      Top = 272
      Width = 56
      Height = 13
      Caption = 'Attachment'
    end
    object Message: TLabel
      Left = 9
      Top = 149
      Width = 42
      Height = 13
      Caption = 'Message'
    end
    object edtServer: TEdit
      Left = 72
      Top = 12
      Width = 540
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtUser: TEdit
      Left = 72
      Top = 40
      Width = 540
      Height = 21
      TabOrder = 1
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 72
      Top = 68
      Width = 540
      Height = 21
      PasswordChar = '*'
      TabOrder = 2
      Text = 'clevertester'
    end
    object btnSend: TButton
      Left = 72
      Top = 300
      Width = 75
      Height = 25
      Caption = 'Send'
      TabOrder = 8
      OnClick = btnSendClick
    end
    object btnReceive: TButton
      Left = 160
      Top = 300
      Width = 75
      Height = 25
      Caption = 'Receive'
      TabOrder = 9
      OnClick = btnReceiveClick
    end
    object ProgressBar1: TProgressBar
      Left = 24
      Top = 335
      Width = 589
      Height = 17
      Max = 0
      TabOrder = 11
    end
    object edtFrom: TEdit
      Left = 72
      Top = 95
      Width = 540
      Height = 21
      TabOrder = 3
      Text = 'CleverTester@company.mail'
    end
    object edtTo: TEdit
      Left = 72
      Top = 122
      Width = 540
      Height = 21
      TabOrder = 4
      Text = 'CleverTester@company.mail'
    end
    object btnStop: TButton
      Left = 248
      Top = 300
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 10
      OnClick = btnStopClick
    end
    object edtAttachment: TEdit
      Left = 72
      Top = 272
      Width = 510
      Height = 21
      TabOrder = 6
      Text = 'MailProgress.zip'
    end
    object btnBrowse: TButton
      Left = 587
      Top = 269
      Width = 25
      Height = 25
      Caption = '...'
      TabOrder = 7
      OnClick = btnBrowseClick
    end
    object memBody: TMemo
      Left = 72
      Top = 149
      Width = 540
      Height = 116
      Lines.Strings = (
        'Message text follows here')
      ScrollBars = ssVertical
      TabOrder = 5
    end
  end
  object clPOP31: TclPop3
    TimeOut = 10000
    OnProgress = clMailProgress
    Left = 176
    Top = 304
  end
  object clSMTP1: TclSmtp
    TimeOut = 10000
    OnProgress = clMailProgress
    MailAgent = 'Clever Internet Suite'
    Left = 216
    Top = 304
  end
  object clMailMessage1: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38575.524826736100000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    OnSaveAttachment = clMailMessage1SaveAttachment
    OnEncodingProgress = clMailMessage1EncodingProgress
    Left = 256
    Top = 304
  end
  object OpenDialog1: TOpenDialog
    Left = 296
    Top = 304
  end
end
