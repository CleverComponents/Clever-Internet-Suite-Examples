inherited Form1: TForm1
  Left = 269
  Top = 167
  Caption = 'HTTP GET with Proxy - Sample'
  Font.Name = 'Tahoma'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Panel1: TPanel
      Left = 0
      Top = 0
      Width = 623
      Height = 185
      Align = alTop
      BevelOuter = bvNone
      TabOrder = 0
      object Label1: TLabel
        Left = 16
        Top = 34
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
      end
      object Label3: TLabel
        Left = 16
        Top = 60
        Width = 22
        Height = 13
        Caption = 'User'
      end
      object Label4: TLabel
        Left = 220
        Top = 62
        Width = 46
        Height = 13
        Caption = 'Password'
      end
      object Bevel1: TBevel
        Left = 8
        Top = 88
        Width = 605
        Height = 2
      end
      object Label5: TLabel
        Left = 232
        Top = 101
        Width = 31
        Height = 13
        Caption = 'Server'
      end
      object Label6: TLabel
        Left = 538
        Top = 101
        Width = 19
        Height = 13
        Caption = 'Port'
      end
      object Label7: TLabel
        Left = 16
        Top = 134
        Width = 22
        Height = 13
        Caption = 'User'
      end
      object Label8: TLabel
        Left = 220
        Top = 133
        Width = 46
        Height = 13
        Caption = 'Password'
      end
      object Label9: TLabel
        Left = 16
        Top = 101
        Width = 24
        Height = 13
        Caption = 'Type'
      end
      object edtUrl: TEdit
        Left = 56
        Top = 32
        Width = 473
        Height = 21
        TabOrder = 0
        Text = 'http://www.microsoft.com'
      end
      object Button1: TButton
        Left = 538
        Top = 29
        Width = 73
        Height = 25
        Caption = 'GET'
        TabOrder = 1
        OnClick = Button1Click
      end
      object cbShowText: TCheckBox
        Left = 56
        Top = 163
        Width = 97
        Height = 17
        Caption = 'Show text only'
        TabOrder = 9
      end
      object edtUser: TEdit
        Left = 56
        Top = 59
        Width = 145
        Height = 21
        TabOrder = 2
      end
      object edtPassword: TEdit
        Left = 272
        Top = 59
        Width = 201
        Height = 21
        PasswordChar = '*'
        TabOrder = 3
      end
      object edtProxyServer: TEdit
        Left = 272
        Top = 98
        Width = 201
        Height = 21
        TabOrder = 5
        Text = 'proxyserver'
      end
      object edtProxyPort: TEdit
        Left = 564
        Top = 98
        Width = 49
        Height = 21
        TabOrder = 6
        Text = '8080'
      end
      object edtProxyUser: TEdit
        Left = 56
        Top = 131
        Width = 145
        Height = 21
        TabOrder = 7
      end
      object edtProxyPassword: TEdit
        Left = 272
        Top = 131
        Width = 201
        Height = 21
        PasswordChar = '*'
        TabOrder = 8
      end
      object cbProxyType: TComboBox
        Left = 56
        Top = 98
        Width = 145
        Height = 21
        Style = csDropDownList
        ItemIndex = 0
        TabOrder = 4
        Text = 'HTTP Proxy'
        OnChange = cbProxyTypeChange
        Items.Strings = (
          'HTTP Proxy'
          'SOCKS4 Firewall'
          'SOCKS5 Firewall')
      end
    end
    object memResult: TMemo
      Left = 0
      Top = 185
      Width = 623
      Height = 178
      Align = alClient
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 1
      WordWrap = False
    end
  end
  object clHttp1: TclHttp
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    KeepConnection = False
    Left = 144
    Top = 248
  end
  object clHtmlParser1: TclHtmlParser
    ParseMethod = pmTextOnly
    OnParseTag = clHtmlParser1ParseTag
    Left = 184
    Top = 248
  end
end
