inherited Form1: TForm1
  Left = 269
  Top = 167
  Caption = 'HTTP GET - Sample'
  Font.Name = 'MS Sans Serif'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Panel1: TPanel
      Left = 0
      Top = 0
      Width = 623
      Height = 89
      Align = alTop
      BevelOuter = bvNone
      TabOrder = 0
      object Label1: TLabel
        Left = 11
        Top = 39
        Width = 22
        Height = 13
        Caption = 'URL'
      end
      object Label2: TLabel
        Left = 11
        Top = 8
        Width = 383
        Height = 13
        Caption = 
          'Type in the URL and click the '#39'GET'#39' button to retreive the page ' +
          'specified by URL'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clNavy
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object edtUrl: TEdit
        Left = 40
        Top = 36
        Width = 497
        Height = 21
        TabOrder = 0
        Text = 'http://www.microsoft.com'
      end
      object Button1: TButton
        Left = 543
        Top = 33
        Width = 71
        Height = 25
        Caption = 'GET'
        TabOrder = 1
        OnClick = Button1Click
      end
      object cbShowText: TCheckBox
        Left = 40
        Top = 64
        Width = 97
        Height = 17
        Caption = 'Show text only'
        TabOrder = 2
      end
    end
    object memResult: TMemo
      Left = 0
      Top = 89
      Width = 623
      Height = 275
      Align = alClient
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 1
      WordWrap = False
    end
  end
  object clHttp1: TclHttp
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite 6.0)'
    Left = 152
    Top = 120
  end
  object clHtmlParser1: TclHtmlParser
    ParseMethod = pmTextOnly
    OnParseTag = clHtmlParser1ParseTag
    Left = 192
    Top = 120
  end
end
