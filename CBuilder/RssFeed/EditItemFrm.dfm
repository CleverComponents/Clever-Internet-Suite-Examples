object EditItemForm: TEditItemForm
  Left = 0
  Top = 0
  BorderStyle = bsDialog
  Caption = 'RSS News Item'
  ClientHeight = 202
  ClientWidth = 371
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
    Left = 21
    Top = 16
    Width = 20
    Height = 13
    Caption = 'Title'
  end
  object Label2: TLabel
    Left = 21
    Top = 43
    Width = 18
    Height = 13
    Caption = 'Link'
  end
  object Label3: TLabel
    Left = 21
    Top = 70
    Width = 53
    Height = 13
    Caption = 'Description'
  end
  object Label4: TLabel
    Left = 21
    Top = 94
    Width = 44
    Height = 13
    Caption = 'Pub Date'
  end
  object Label5: TLabel
    Left = 21
    Top = 124
    Width = 25
    Height = 13
    Caption = 'GUID'
  end
  object edtTitle: TEdit
    Left = 80
    Top = 13
    Width = 265
    Height = 21
    TabOrder = 0
    Text = 'News Title'
  end
  object edtLink: TEdit
    Left = 80
    Top = 40
    Width = 265
    Height = 21
    TabOrder = 1
    Text = 'http://www.sample.com/news.html'
  end
  object edtDescription: TEdit
    Left = 80
    Top = 67
    Width = 265
    Height = 21
    TabOrder = 2
    Text = 'New version released.'
  end
  object dtPubDate: TDateTimePicker
    Left = 80
    Top = 94
    Width = 105
    Height = 21
    CalAlignment = dtaLeft
    Date = 40085.2345401042
    Time = 40085.2345401042
    DateFormat = dfShort
    DateMode = dmComboBox
    Kind = dtkDate
    ParseInput = False
    TabOrder = 3
  end
  object edtGuid: TEdit
    Left = 80
    Top = 121
    Width = 265
    Height = 21
    TabOrder = 4
    Text = 'New_version_released'
  end
  object Button1: TButton
    Left = 176
    Top = 160
    Width = 75
    Height = 25
    Caption = 'OK'
    Default = True
    ModalResult = 1
    TabOrder = 5
  end
  object Button2: TButton
    Left = 270
    Top = 160
    Width = 75
    Height = 25
    Cancel = True
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 6
  end
end
