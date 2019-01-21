inherited Form1: TForm1
  Left = 412
  Top = 154
  Caption = 'RSS Feed - Sample'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 14
      Top = 11
      Width = 20
      Height = 13
      Caption = 'Title'
    end
    object Label2: TLabel
      Left = 13
      Top = 38
      Width = 18
      Height = 13
      Caption = 'Link'
    end
    object Label3: TLabel
      Left = 14
      Top = 65
      Width = 53
      Height = 13
      Caption = 'Description'
    end
    object Label4: TLabel
      Left = 322
      Top = 66
      Width = 47
      Height = 13
      Caption = 'Copyright'
    end
    object Label5: TLabel
      Left = 14
      Top = 94
      Width = 47
      Height = 13
      Caption = 'Language'
    end
    object Label6: TLabel
      Left = 14
      Top = 121
      Width = 58
      Height = 13
      Caption = 'Web Master'
    end
    object Label7: TLabel
      Left = 14
      Top = 148
      Width = 49
      Height = 13
      Caption = 'Generator'
    end
    object Label9: TLabel
      Left = 14
      Top = 175
      Width = 30
      Height = 13
      Caption = 'Image'
    end
    object edtTitle: TEdit
      Left = 80
      Top = 8
      Width = 533
      Height = 21
      TabOrder = 0
      Text = 'Demo Company - News'
    end
    object edtLink: TEdit
      Left = 80
      Top = 35
      Width = 533
      Height = 21
      TabOrder = 1
      Text = 'http://www.sample.com'
    end
    object edtDescription: TEdit
      Left = 80
      Top = 62
      Width = 225
      Height = 21
      TabOrder = 2
      Text = 'Demo company description'
    end
    object edtCopyright: TEdit
      Left = 376
      Top = 63
      Width = 237
      Height = 21
      TabOrder = 3
      Text = 'Copyright 2009 Company Inc.'
    end
    object edtLanguage: TEdit
      Left = 80
      Top = 91
      Width = 533
      Height = 21
      TabOrder = 4
      Text = 'en-US'
    end
    object edtWebMaster: TEdit
      Left = 80
      Top = 118
      Width = 533
      Height = 21
      TabOrder = 5
      Text = 'webmaster@sample.com'
    end
    object edtGenerator: TEdit
      Left = 80
      Top = 145
      Width = 533
      Height = 21
      TabOrder = 6
      Text = 'Clever Internet Suite 7.0 RSS Component'
    end
    object edtImageUrl: TEdit
      Left = 80
      Top = 172
      Width = 533
      Height = 21
      TabOrder = 7
      Text = 'http://www.sample.com/image.gif'
    end
    object lbNews: TListBox
      Left = 12
      Top = 202
      Width = 517
      Height = 153
      ItemHeight = 13
      TabOrder = 8
      OnDblClick = lbNewsDblClick
    end
    object btnAdd: TButton
      Left = 538
      Top = 202
      Width = 75
      Height = 25
      Caption = 'Add'
      TabOrder = 9
      OnClick = btnAddClick
    end
    object btnDelete: TButton
      Left = 538
      Top = 233
      Width = 75
      Height = 25
      Caption = 'Delete'
      TabOrder = 10
      OnClick = btnDeleteClick
    end
    object btnClear: TButton
      Left = 538
      Top = 266
      Width = 75
      Height = 25
      Caption = 'Clear'
      TabOrder = 11
      OnClick = btnClearClick
    end
    object btnLoad: TButton
      Left = 538
      Top = 297
      Width = 75
      Height = 25
      Caption = 'Load'
      TabOrder = 12
      OnClick = btnLoadClick
    end
    object btnSave: TButton
      Left = 538
      Top = 328
      Width = 75
      Height = 25
      Caption = 'Save'
      TabOrder = 13
      OnClick = btnSaveClick
    end
  end
  object clRss1: TclRss
    Items = <>
    Left = 128
    Top = 312
  end
  object OpenDialog1: TOpenDialog
    DefaultExt = 'xml'
    Filter = 'RSS Files|*.xml|All Files|*.*'
    FilterIndex = 0
    Left = 168
    Top = 312
  end
  object SaveDialog1: TSaveDialog
    DefaultExt = 'xml'
    Filter = 'RSS Files|*.xml|All Files|*.*'
    FilterIndex = 0
    Left = 208
    Top = 312
  end
end
