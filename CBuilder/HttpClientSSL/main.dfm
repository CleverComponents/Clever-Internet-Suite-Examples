inherited Form1: TForm1
  Left = 269
  Top = 167
  Caption = 'HTTPS GET with SSL - Sample'
  Font.Name = 'MS Sans Serif'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Panel1: TPanel
      Left = 0
      Top = 0
      Width = 623
      Height = 105
      Align = alTop
      BevelOuter = bvNone
      TabOrder = 0
      object Label1: TLabel
        Left = 16
        Top = 35
        Width = 22
        Height = 13
        Caption = 'URL'
      end
      object Label2: TLabel
        Left = 16
        Top = 8
        Width = 386
        Height = 13
        Caption = 
          'Type in the URL and click the '#39'GET'#39' button to retreive the page ' +
          'specified by URL.'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clNavy
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
      end
      object Label3: TLabel
        Left = 16
        Top = 60
        Width = 22
        Height = 13
        Caption = 'User'
      end
      object Label4: TLabel
        Left = 197
        Top = 61
        Width = 46
        Height = 13
        Caption = 'Password'
      end
      object edtUrl: TEdit
        Left = 48
        Top = 32
        Width = 481
        Height = 21
        TabOrder = 0
        Text = 'https://www.paypal.com'
      end
      object Button1: TButton
        Left = 536
        Top = 30
        Width = 73
        Height = 25
        Caption = 'GET'
        TabOrder = 1
        OnClick = Button1Click
      end
      object cbShowText: TCheckBox
        Left = 48
        Top = 84
        Width = 97
        Height = 17
        Caption = 'Show text only'
        TabOrder = 4
      end
      object edtUser: TEdit
        Left = 48
        Top = 59
        Width = 121
        Height = 21
        TabOrder = 2
      end
      object edtPassword: TEdit
        Left = 248
        Top = 59
        Width = 113
        Height = 21
        TabOrder = 3
      end
    end
    object memResult: TMemo
      Left = 0
      Top = 105
      Width = 623
      Height = 259
      Align = alClient
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 1
      WordWrap = False
    end
  end
  object clHttp1: TclHttp
    OnVerifyServer = clHttp1VerifyServer
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite 6.0)'
    Left = 144
    Top = 176
  end
  object clHtmlParser1: TclHtmlParser
    ParseMethod = pmTextOnly
    OnParseTag = clHtmlParser1ParseTag
    Left = 192
    Top = 176
  end
  object clCertificateStore1: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40003.000000000000000000
    ValidTo = 40368.000000000000000000
    Left = 240
    Top = 176
  end
end
