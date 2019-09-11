object CertForm: TCertForm
  Left = 247
  Top = 114
  BorderStyle = bsDialog
  Caption = 'View / Install certificate'
  ClientHeight = 230
  ClientWidth = 385
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 16
    Width = 67
    Height = 13
    Caption = 'Friendly Name'
  end
  object Label2: TLabel
    Left = 24
    Top = 48
    Width = 47
    Height = 13
    Caption = 'Issued To'
  end
  object Label3: TLabel
    Left = 24
    Top = 80
    Width = 46
    Height = 13
    Caption = 'Issued By'
  end
  object Label4: TLabel
    Left = 24
    Top = 112
    Width = 49
    Height = 13
    Caption = 'Valid From'
  end
  object Label5: TLabel
    Left = 24
    Top = 144
    Width = 39
    Height = 13
    Caption = 'Valid To'
  end
  object edtName: TEdit
    Left = 104
    Top = 16
    Width = 257
    Height = 21
    ReadOnly = True
    TabOrder = 0
  end
  object edtIssuedTo: TEdit
    Left = 104
    Top = 48
    Width = 257
    Height = 21
    ReadOnly = True
    TabOrder = 1
  end
  object edtIssuedBy: TEdit
    Left = 104
    Top = 80
    Width = 257
    Height = 21
    ReadOnly = True
    TabOrder = 2
  end
  object edtValidFrom: TEdit
    Left = 104
    Top = 112
    Width = 257
    Height = 21
    ReadOnly = True
    TabOrder = 3
  end
  object edtValidTo: TEdit
    Left = 104
    Top = 144
    Width = 257
    Height = 21
    ReadOnly = True
    TabOrder = 4
  end
  object btnInstall: TButton
    Left = 16
    Top = 184
    Width = 121
    Height = 25
    Caption = 'Install && Continue'
    ModalResult = 6
    TabOrder = 5
  end
  object btnContinue: TButton
    Left = 200
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Continue'
    ModalResult = 1
    TabOrder = 6
  end
  object btnCancel: TButton
    Left = 288
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 7
  end
end
