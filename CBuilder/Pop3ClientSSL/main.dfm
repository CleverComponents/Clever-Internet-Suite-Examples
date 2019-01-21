inherited Form1: TForm1
  Left = 234
  Top = 210
  Caption = 'POP3 Client with SSL / TLS support - Sample'
  Font.Name = 'MS Sans Serif'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 15
      Top = 10
      Width = 31
      Height = 13
      Caption = 'Server'
    end
    object Label2: TLabel
      Left = 15
      Top = 38
      Width = 19
      Height = 13
      Caption = 'Port'
    end
    object Label4: TLabel
      Left = 15
      Top = 66
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label5: TLabel
      Left = 251
      Top = 67
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label3: TLabel
      Left = 16
      Top = 89
      Width = 48
      Height = 13
      Caption = 'Messages'
    end
    object Label6: TLabel
      Left = 16
      Top = 203
      Width = 23
      Height = 13
      Caption = 'From'
    end
    object Label7: TLabel
      Left = 16
      Top = 232
      Width = 36
      Height = 13
      Caption = 'Subject'
    end
    object edtServer: TEdit
      Left = 56
      Top = 8
      Width = 461
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 56
      Top = 35
      Width = 49
      Height = 21
      TabOrder = 1
      Text = '995'
    end
    object edtUser: TEdit
      Left = 56
      Top = 64
      Width = 169
      Height = 21
      TabOrder = 3
      Text = 'CleverTester'
    end
    object edtPassword: TEdit
      Left = 304
      Top = 64
      Width = 145
      Height = 21
      TabOrder = 4
      Text = 'clevertester'
    end
    object btnConnect: TButton
      Left = 525
      Top = 8
      Width = 89
      Height = 25
      Caption = 'Connect'
      TabOrder = 5
      OnClick = btnConnectClick
    end
    object cbUseTLS: TCheckBox
      Left = 304
      Top = 36
      Width = 145
      Height = 17
      Caption = 'Use SSL / TLS'
      Checked = True
      State = cbChecked
      TabOrder = 2
    end
    object lvMessages: TListView
      Left = 16
      Top = 107
      Width = 481
      Height = 89
      Columns = <
        item
          Caption = 'From'
          Width = 120
        end
        item
          Caption = 'Subject'
          Width = 120
        end
        item
          Caption = 'Date'
          Width = 70
        end
        item
          Caption = 'UID'
          Width = 100
        end>
      HideSelection = False
      ReadOnly = True
      RowSelect = True
      TabOrder = 7
      ViewStyle = vsReport
      OnDblClick = btnViewClick
    end
    object edtFrom: TEdit
      Left = 64
      Top = 203
      Width = 550
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 10
    end
    object edtSubject: TEdit
      Left = 64
      Top = 232
      Width = 550
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 11
    end
    object memBody: TMemo
      Left = 16
      Top = 260
      Width = 597
      Height = 93
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 12
    end
    object btnDelete: TButton
      Left = 525
      Top = 139
      Width = 89
      Height = 25
      Caption = 'Delete Message'
      TabOrder = 9
      OnClick = btnDeleteClick
    end
    object btnDisconnect: TButton
      Left = 525
      Top = 39
      Width = 89
      Height = 25
      Caption = 'Disconnect'
      TabOrder = 6
      OnClick = btnDisconnectClick
    end
    object btnView: TButton
      Left = 525
      Top = 107
      Width = 89
      Height = 25
      Caption = 'View Message'
      TabOrder = 8
      OnClick = btnViewClick
    end
  end
  object clPop: TclPop3
    OnVerifyServer = clPopVerifyServer
    Left = 232
    Top = 224
  end
  object clMailMessage: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38656.929073819400000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 280
    Top = 224
  end
end
