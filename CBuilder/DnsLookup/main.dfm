inherited Form1: TForm1
  Left = 247
  Top = 114
  Caption = 'DNS Query - Sample'
  Font.Name = 'Tahoma'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 16
      Top = 19
      Width = 57
      Height = 13
      Caption = 'DNS Server'
    end
    object Label2: TLabel
      Left = 16
      Top = 91
      Width = 55
      Height = 13
      Caption = 'Query Type'
    end
    object Label3: TLabel
      Left = 16
      Top = 55
      Width = 82
      Height = 13
      Caption = 'Name to Resolve'
    end
    object Label4: TLabel
      Left = 464
      Top = 19
      Width = 51
      Height = 13
      Caption = 'TimeOut, s'
    end
    object Label5: TLabel
      Left = 16
      Top = 120
      Width = 30
      Height = 13
      Caption = 'Result'
    end
    object Label6: TLabel
      Left = 302
      Top = 19
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object edtDnsServer: TEdit
      Left = 104
      Top = 16
      Width = 153
      Height = 21
      TabOrder = 0
    end
    object cbNameType: TComboBox
      Left = 104
      Top = 88
      Width = 153
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      ItemIndex = 1
      TabOrder = 4
      Text = 'A (IP addresses)'
      Items.Strings = (
        'MX (mail servers)'
        'A (IP addresses)'
        'PTR (host names)'
        'NS (name servers)')
    end
    object edtTimeOut: TEdit
      Left = 520
      Top = 16
      Width = 89
      Height = 21
      TabOrder = 2
      Text = '5'
    end
    object edtName: TEdit
      Left = 104
      Top = 52
      Width = 505
      Height = 21
      TabOrder = 3
      Text = 'microsoft.com'
    end
    object btnResolve: TButton
      Left = 504
      Top = 88
      Width = 105
      Height = 25
      Caption = 'Resolve'
      TabOrder = 5
      OnClick = btnResolveClick
    end
    object memResult: TMemo
      Left = 16
      Top = 136
      Width = 593
      Height = 217
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 6
    end
    object edtPort: TEdit
      Left = 329
      Top = 16
      Width = 96
      Height = 21
      TabOrder = 1
      Text = '53'
    end
  end
  object clDnsQuery1: TclDnsQuery
    Left = 224
    Top = 200
  end
end
