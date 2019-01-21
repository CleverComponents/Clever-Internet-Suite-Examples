inherited Form1: TForm1
  Left = 247
  Top = 118
  Height = 530
  Caption = 'Web DAV client - Sample'
  Font.Name = 'MS Sans Serif'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 413
    object Label1: TLabel
      Left = 16
      Top = 18
      Width = 22
      Height = 13
      Caption = 'Host'
    end
    object Label2: TLabel
      Left = 16
      Top = 104
      Width = 51
      Height = 13
      Caption = 'Resources'
    end
    object Label3: TLabel
      Left = 16
      Top = 49
      Width = 22
      Height = 13
      Caption = 'User'
    end
    object Label4: TLabel
      Left = 216
      Top = 49
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label5: TLabel
      Left = 16
      Top = 82
      Width = 29
      Height = 13
      Caption = 'Depth'
    end
    object edtHost: TEdit
      Left = 56
      Top = 16
      Width = 450
      Height = 21
      TabOrder = 0
      Text = 'http://localhost/WebDAV/'
    end
    object btnOpen: TButton
      Left = 515
      Top = 14
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Open'
      TabOrder = 4
      OnClick = btnOpenClick
    end
    object edtUser: TEdit
      Left = 56
      Top = 48
      Width = 121
      Height = 21
      TabOrder = 1
    end
    object edtPassword: TEdit
      Left = 272
      Top = 48
      Width = 121
      Height = 21
      PasswordChar = '*'
      TabOrder = 2
    end
    object lvResources: TListView
      Left = 16
      Top = 120
      Width = 490
      Height = 281
      Columns = <
        item
          Caption = 'Path'
          Width = 350
        end>
      HideSelection = False
      ReadOnly = True
      RowSelect = True
      TabOrder = 7
      ViewStyle = vsReport
      OnDblClick = lvResourcesDblClick
    end
    object btnGetAllProps: TButton
      Left = 515
      Top = 120
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Get All Props'
      TabOrder = 8
      OnClick = btnGetAllPropsClick
    end
    object btnModifyProp: TButton
      Left = 515
      Top = 152
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Modify Prop'
      TabOrder = 9
      OnClick = btnModifyPropClick
    end
    object btnMakeDir: TButton
      Left = 515
      Top = 184
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Make Dir'
      TabOrder = 10
      OnClick = btnMakeDirClick
    end
    object btnDelete: TButton
      Left = 515
      Top = 216
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Delete'
      TabOrder = 11
      OnClick = btnDeleteClick
    end
    object btnLock: TButton
      Left = 515
      Top = 248
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Lock Resource'
      TabOrder = 12
      OnClick = btnLockClick
    end
    object btnUnlock: TButton
      Left = 515
      Top = 280
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Unlock'
      TabOrder = 13
      OnClick = btnUnlockClick
    end
    object btnCopyMove: TButton
      Left = 515
      Top = 312
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Copy / Move'
      TabOrder = 14
      OnClick = btnCopyMoveClick
    end
    object btnDownload: TButton
      Left = 515
      Top = 344
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Download'
      TabOrder = 15
      OnClick = btnDownloadClick
    end
    object btnUpload: TButton
      Left = 515
      Top = 376
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Upload'
      TabOrder = 16
      OnClick = btnUploadClick
    end
    object cbDepth: TComboBox
      Left = 56
      Top = 80
      Width = 121
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      TabOrder = 3
      Items.Strings = (
        'Default'
        'Resource Only'
        'Resource and Children'
        'Infinity')
    end
    object btnCapabilities: TButton
      Left = 515
      Top = 88
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Capabilities'
      TabOrder = 6
      OnClick = btnCapabilitiesClick
    end
    object btnGoUp: TButton
      Left = 515
      Top = 46
      Width = 100
      Height = 25
      Anchors = [akLeft, akTop, akRight]
      Caption = 'Go Up'
      TabOrder = 5
      OnClick = btnGoUpClick
    end
  end
  object clWebDav1: TclWebDav
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite 6.0)'
    LockTimeOut = 'Infinite, Second-86400'
    NameSpaces = <
      item
        Prefix = 'D'
        NameSpace = 'DAV:'
      end>
    Left = 216
    Top = 168
  end
  object OpenDialog1: TOpenDialog
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 128
    Top = 104
  end
  object SaveDialog1: TSaveDialog
    Options = [ofOverwritePrompt, ofHideReadOnly, ofEnableSizing]
    Left = 176
    Top = 104
  end
end
