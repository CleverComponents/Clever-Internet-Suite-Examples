object NewFolderDialog: TNewFolderDialog
  Left = 0
  Top = 0
  BorderStyle = bsDialog
  Caption = 'New Folder'
  ClientHeight = 128
  ClientWidth = 326
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 16
    Width = 84
    Height = 13
    Caption = 'New Folder Name'
  end
  object edtName: TEdit
    Left = 24
    Top = 35
    Width = 281
    Height = 21
    TabOrder = 0
    Text = 'NewName'
  end
  object cbIsSubfolder: TCheckBox
    Left = 24
    Top = 62
    Width = 273
    Height = 17
    Caption = 'Create as subfolder of the current folder'
    TabOrder = 1
  end
  object Button1: TButton
    Left = 136
    Top = 85
    Width = 75
    Height = 25
    Caption = 'OK'
    ModalResult = 1
    TabOrder = 2
  end
  object Button2: TButton
    Left = 230
    Top = 85
    Width = 75
    Height = 25
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 3
  end
end
