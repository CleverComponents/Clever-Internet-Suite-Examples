inherited MainForm: TMainForm
  Left = 298
  Top = 51
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Html Parser - Sample'
  Font.Name = 'Tahoma'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object btnOpen: TButton
      Left = 12
      Top = 327
      Width = 75
      Height = 25
      Caption = 'Open File'
      TabOrder = 0
      OnClick = btnOpenClick
    end
    object PageControl: TPageControl
      Left = 10
      Top = 8
      Width = 602
      Height = 311
      ActivePage = tabLinks
      TabOrder = 1
      object tabLinks: TTabSheet
        Caption = 'Links'
        object Label1: TLabel
          Left = 10
          Top = 236
          Width = 22
          Height = 13
          Caption = 'URL'
        end
        object Label2: TLabel
          Left = 286
          Top = 236
          Width = 31
          Height = 13
          Caption = 'Target'
        end
        object Label3: TLabel
          Left = 444
          Top = 236
          Width = 28
          Height = 13
          Caption = 'Name'
        end
        object Label4: TLabel
          Left = 9
          Top = 15
          Width = 47
          Height = 13
          Caption = 'Link Tags'
        end
        object lbLinks: TListBox
          Left = 8
          Top = 32
          Width = 577
          Height = 195
          ItemHeight = 13
          TabOrder = 0
          OnClick = lbLinksClick
        end
        object edtUrlHref: TEdit
          Left = 10
          Top = 254
          Width = 261
          Height = 21
          ReadOnly = True
          TabOrder = 1
        end
        object edtUrlTarget: TEdit
          Left = 285
          Top = 254
          Width = 143
          Height = 21
          ReadOnly = True
          TabOrder = 2
        end
        object edtUrlName: TEdit
          Left = 444
          Top = 254
          Width = 141
          Height = 21
          ReadOnly = True
          TabOrder = 3
        end
      end
      object tabImages: TTabSheet
        Caption = 'Images'
        ImageIndex = 1
        object Label5: TLabel
          Left = 9
          Top = 14
          Width = 56
          Height = 13
          Caption = 'Image Tags'
        end
        object Label6: TLabel
          Left = 318
          Top = 185
          Width = 28
          Height = 13
          Caption = 'Width'
        end
        object Label7: TLabel
          Left = 318
          Top = 237
          Width = 31
          Height = 13
          Caption = 'Height'
        end
        object Label8: TLabel
          Left = 10
          Top = 185
          Width = 16
          Height = 13
          Caption = 'Src'
        end
        object Label9: TLabel
          Left = 10
          Top = 237
          Width = 12
          Height = 13
          Caption = 'Alt'
        end
        object lbImages: TListBox
          Left = 8
          Top = 32
          Width = 577
          Height = 145
          ItemHeight = 13
          TabOrder = 0
          OnClick = lbImagesClick
        end
        object edtImageSrc: TEdit
          Left = 10
          Top = 202
          Width = 297
          Height = 21
          ReadOnly = True
          TabOrder = 1
        end
        object edtImageWidth: TEdit
          Left = 319
          Top = 202
          Width = 266
          Height = 21
          ReadOnly = True
          TabOrder = 2
        end
        object edtImageAlt: TEdit
          Left = 10
          Top = 255
          Width = 297
          Height = 21
          ReadOnly = True
          TabOrder = 3
        end
        object edtImageHeight: TEdit
          Left = 319
          Top = 255
          Width = 266
          Height = 21
          ReadOnly = True
          TabOrder = 4
        end
      end
      object tabForms: TTabSheet
        Caption = 'Forms'
        ImageIndex = 2
        object Label10: TLabel
          Left = 10
          Top = 15
          Width = 50
          Height = 13
          Caption = 'Form Tags'
        end
        object Label11: TLabel
          Left = 11
          Top = 186
          Width = 30
          Height = 13
          Caption = 'Action'
        end
        object Label12: TLabel
          Left = 10
          Top = 235
          Width = 46
          Height = 13
          Caption = 'Enc Type'
        end
        object Label13: TLabel
          Left = 392
          Top = 186
          Width = 54
          Height = 13
          Caption = 'Form Name'
        end
        object Label14: TLabel
          Left = 392
          Top = 235
          Width = 36
          Height = 13
          Caption = 'Method'
        end
        object Label15: TLabel
          Left = 393
          Top = 15
          Width = 38
          Height = 13
          Caption = 'Controls'
        end
        object lbForms: TListBox
          Left = 8
          Top = 32
          Width = 369
          Height = 145
          ItemHeight = 13
          TabOrder = 0
          OnClick = lbFormsClick
        end
        object edtFormAction: TEdit
          Left = 10
          Top = 203
          Width = 367
          Height = 21
          ReadOnly = True
          TabOrder = 2
        end
        object edtFormEncType: TEdit
          Left = 10
          Top = 252
          Width = 367
          Height = 21
          ReadOnly = True
          TabOrder = 4
        end
        object edtFormName: TEdit
          Left = 391
          Top = 203
          Width = 194
          Height = 21
          ReadOnly = True
          TabOrder = 3
        end
        object edtFormMethod: TEdit
          Left = 391
          Top = 252
          Width = 194
          Height = 21
          ReadOnly = True
          TabOrder = 5
        end
        object lbFormControls: TListBox
          Left = 392
          Top = 32
          Width = 193
          Height = 145
          ItemHeight = 13
          TabOrder = 1
        end
      end
      object tabText: TTabSheet
        Caption = 'Text'
        ImageIndex = 3
        object lbText: TRichEdit
          Left = 8
          Top = 11
          Width = 577
          Height = 262
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -11
          Font.Name = 'Tahoma'
          Font.Style = []
          ParentFont = False
          PlainText = True
          ReadOnly = True
          ScrollBars = ssVertical
          TabOrder = 0
        end
      end
    end
  end
  object OpenDialog: TOpenDialog
    DefaultExt = 'htm'
    Filter = 'Html Files (*.htm)|*.htm|All Files (*.*)|*.*'
    Options = [ofHideReadOnly, ofPathMustExist, ofFileMustExist, ofEnableSizing]
    Left = 118
    Top = 280
  end
  object clHtmlParser: TclHtmlParser
    ParseMethod = pmAll
    OnParseTag = clHtmlParserParseTag
    Left = 190
    Top = 278
  end
end
