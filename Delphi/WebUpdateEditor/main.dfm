inherited MainForm: TMainForm
  Left = 270
  Top = 265
  VertScrollBar.Range = 0
  BorderStyle = bsDialog
  Caption = 'Update Manager - Sample'
  ClientHeight = 181
  Font.Name = 'Tahoma'
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 103
    object Label1: TLabel
      Left = 16
      Top = 14
      Width = 54
      Height = 13
      Caption = 'Update File'
    end
    object edtUpdateFile: TEdit
      Left = 16
      Top = 32
      Width = 593
      Height = 21
      Anchors = [akLeft, akTop, akRight]
      TabOrder = 0
      Text = 'webupdate.xml'
    end
    object btnEdit: TButton
      Left = 454
      Top = 64
      Width = 75
      Height = 25
      Anchors = [akTop, akRight]
      Caption = 'Edit'
      TabOrder = 1
      OnClick = btnEditClick
    end
    object btnClose: TButton
      Left = 534
      Top = 64
      Width = 75
      Height = 25
      Anchors = [akTop, akRight]
      Caption = 'Close'
      TabOrder = 2
      OnClick = btnCloseClick
    end
  end
  object clWebUpdate: TclWebUpdate
    UpdateDir = '.\'
    ActualUpdateInfoFile = 'lastupdate.xml'
    ErrorWords.Strings = (
      'fatal'
      'failed'
      'error')
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    Left = 304
    Top = 136
  end
end
