inherited Form1: TForm1
  Left = 249
  Top = 133
  Caption = 'News Reader (by groups) - Sample'
  Font.Name = 'Tahoma'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 15
      Top = 14
      Width = 61
      Height = 13
      Caption = 'News Server'
    end
    object Label2: TLabel
      Left = 14
      Top = 44
      Width = 59
      Height = 13
      Caption = 'News Group'
    end
    object edtNewsServer: TEdit
      Left = 85
      Top = 11
      Width = 527
      Height = 21
      TabOrder = 0
      Text = 'forums.embarcadero.com'
    end
    object btnConnect: TButton
      Left = 12
      Top = 70
      Width = 75
      Height = 25
      Caption = 'Connect'
      TabOrder = 2
      OnClick = btnConnectClick
    end
    object tvArticles: TTreeView
      Left = 12
      Top = 104
      Width = 600
      Height = 97
      Enabled = False
      Indent = 19
      ReadOnly = True
      TabOrder = 6
      OnChange = tvArticlesChange
      OnDeletion = tvArticlesDeletion
    end
    object memBody: TMemo
      Left = 12
      Top = 210
      Width = 600
      Height = 142
      Enabled = False
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 7
    end
    object cbNewsGroup: TComboBox
      Left = 85
      Top = 42
      Width = 527
      Height = 21
      Enabled = False
      ItemHeight = 13
      TabOrder = 1
    end
    object btnPostNew: TButton
      Left = 456
      Top = 70
      Width = 75
      Height = 25
      Caption = 'Post New...'
      Enabled = False
      TabOrder = 4
      OnClick = btnPostNewClick
    end
    object btnReply: TButton
      Left = 536
      Top = 70
      Width = 75
      Height = 25
      Caption = 'Reply...'
      Enabled = False
      TabOrder = 5
      OnClick = btnReplyClick
    end
    object btnGetArticles: TButton
      Left = 92
      Top = 70
      Width = 75
      Height = 25
      Caption = 'Get Articles'
      Enabled = False
      TabOrder = 3
      OnClick = btnGetArticlesClick
    end
  end
  object clNNTP: TclNntp
    NewsAgent = 'Clever Internet Suite v 6.0'
    OnGroupOverview = clNNTPGroupOverview
    Left = 56
    Top = 216
  end
  object clMailMessage: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38339.696624768500000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 104
    Top = 216
  end
end
