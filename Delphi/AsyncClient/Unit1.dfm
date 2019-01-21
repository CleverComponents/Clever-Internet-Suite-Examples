inherited Form1: TForm1
  Left = 403
  Top = 164
  Caption = 'Asynchronous Client Sample - TELNET'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 26
      Top = 19
      Width = 22
      Height = 13
      Caption = 'Host'
    end
    object Label2: TLabel
      Left = 26
      Top = 46
      Width = 20
      Height = 13
      Caption = 'Port'
    end
    object edtHost: TEdit
      Left = 56
      Top = 16
      Width = 465
      Height = 21
      TabOrder = 0
      Text = 'localhost'
    end
    object edtPort: TEdit
      Left = 58
      Top = 43
      Width = 81
      Height = 21
      TabOrder = 1
      Text = '23'
    end
    object btnConnect: TButton
      Left = 533
      Top = 14
      Width = 75
      Height = 25
      Caption = 'Connect'
      TabOrder = 2
      OnClick = btnConnectClick
    end
    object memTerminal: TMemo
      Left = 0
      Top = 72
      Width = 623
      Height = 291
      Align = alBottom
      ScrollBars = ssBoth
      TabOrder = 3
      WordWrap = False
      OnKeyPress = memTerminalKeyPress
    end
  end
  object clAsyncClient1: TclAsyncClient
    Port = 0
    TLSFlags = []
    OnConnect = clAsyncClient1Connect
    OnDisconnect = clAsyncClient1Disconnect
    OnRead = clAsyncClient1Read
    Left = 112
    Top = 184
  end
end
