inherited MainForm: TMainForm
  Left = 261
  Top = 62
  Caption = 'SMIME Message - Sample'
  ClientHeight = 514
  Font.Name = 'Tahoma'
  OnCreate = FormCreate
  ExplicitHeight = 552
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 436
    ExplicitHeight = 436
    object Label3: TLabel
      Left = 9
      Top = 140
      Width = 47
      Height = 13
      Caption = 'Plain Text'
    end
    object Label4: TLabel
      Left = 308
      Top = 140
      Width = 56
      Height = 13
      Caption = 'Plain HTML'
    end
    object Label5: TLabel
      Left = 11
      Top = 273
      Width = 59
      Height = 13
      Caption = 'Attachments'
    end
    object Label7: TLabel
      Left = 11
      Top = 63
      Width = 23
      Height = 13
      Caption = 'From'
    end
    object Label8: TLabel
      Left = 10
      Top = 86
      Width = 32
      Height = 13
      Caption = 'To List'
    end
    object Label9: TLabel
      Left = 10
      Top = 110
      Width = 36
      Height = 13
      Caption = 'Subject'
    end
    object Label1: TLabel
      Left = 16
      Top = 8
      Width = 417
      Height = 13
      Caption = 
        'This demo creates and signs / encodes the mail message and store' +
        's it to file on the disk.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label2: TLabel
      Left = 16
      Top = 24
      Width = 577
      Height = 26
      AutoSize = False
      Caption = 
        'If you have a mail message, already stored on the  disk, you can' +
        ' load it and decrypt / verify  the message  digital signature.  ' +
        'Please see Readme.txt for more details.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object memText: TMemo
      Left = 8
      Top = 156
      Width = 289
      Height = 110
      Lines.Strings = (
        'This is SMIME test message built using Clever Message Parser')
      ScrollBars = ssBoth
      TabOrder = 3
      WordWrap = False
    end
    object memHtml: TMemo
      Left = 307
      Top = 156
      Width = 304
      Height = 110
      Lines.Strings = (
        '<html>'
        '<body>'
        
          '<p>This is SMIME test message built using Clever Message Parser<' +
          '/p>'
        '</body>'
        '</html>')
      ScrollBars = ssBoth
      TabOrder = 4
      WordWrap = False
    end
    object lbAttachments: TListBox
      Left = 9
      Top = 291
      Width = 520
      Height = 62
      ItemHeight = 13
      TabOrder = 5
    end
    object btnAdd: TButton
      Left = 536
      Top = 288
      Width = 75
      Height = 25
      Caption = 'Add...'
      TabOrder = 6
      OnClick = btnAddClick
    end
    object btnClear: TButton
      Left = 536
      Top = 316
      Width = 75
      Height = 25
      Caption = 'Clear'
      TabOrder = 7
      OnClick = btnClearClick
    end
    object btnEncrypt: TButton
      Left = 223
      Top = 368
      Width = 100
      Height = 25
      Caption = 'Encrypt...'
      TabOrder = 10
      OnClick = btnEncryptClick
    end
    object btnSign: TButton
      Left = 115
      Top = 368
      Width = 100
      Height = 25
      Caption = 'Sign...'
      TabOrder = 9
      OnClick = btnSignClick
    end
    object edtFrom: TEdit
      Left = 50
      Top = 60
      Width = 563
      Height = 21
      TabOrder = 0
      Text = 'myname@mycompany.com'
    end
    object edtToList: TEdit
      Left = 50
      Top = 84
      Width = 563
      Height = 21
      TabOrder = 1
      Text = 'recipient@domain.com'
    end
    object edtSubject: TEdit
      Left = 50
      Top = 108
      Width = 563
      Height = 21
      TabOrder = 2
      Text = 'Clever SMime Message Test'
    end
    object btnSignEncrypt: TButton
      Left = 332
      Top = 368
      Width = 106
      Height = 25
      Caption = 'Sign/Encrypt...'
      TabOrder = 11
      OnClick = btnSignEncryptClick
    end
    object btnVerify: TButton
      Left = 115
      Top = 400
      Width = 100
      Height = 25
      Caption = 'Verify...'
      TabOrder = 12
      OnClick = btnVerifyClick
    end
    object btnVerifyDecrypt: TButton
      Left = 333
      Top = 400
      Width = 105
      Height = 25
      Caption = 'Verify/Decrypt...'
      TabOrder = 14
      OnClick = btnVerifyDecryptClick
    end
    object btnDecrypt: TButton
      Left = 223
      Top = 400
      Width = 100
      Height = 25
      Caption = 'Decrypt...'
      TabOrder = 13
      OnClick = btnDecryptClick
    end
    object btnNewMessage: TButton
      Left = 8
      Top = 368
      Width = 100
      Height = 25
      Caption = 'New Message'
      TabOrder = 8
      OnClick = btnNewMessageClick
    end
    object cbDetachedSignature: TCheckBox
      Left = 464
      Top = 372
      Width = 125
      Height = 17
      Caption = 'Detached Signature'
      Checked = True
      State = cbChecked
      TabOrder = 15
      OnClick = cbDetachedSignatureClick
    end
    object cbIncludeCertificate: TCheckBox
      Left = 464
      Top = 404
      Width = 127
      Height = 17
      Caption = 'Include Certificate'
      Checked = True
      State = cbChecked
      TabOrder = 16
      OnClick = cbDetachedSignatureClick
    end
    object btnViewCertificates: TButton
      Left = 8
      Top = 400
      Width = 100
      Height = 25
      Caption = 'View Certificates'
      TabOrder = 17
      OnClick = btnViewCertificatesClick
    end
  end
  object OpenDialog: TOpenDialog
    DefaultExt = '.eml'
    Filter = 'Emails (*.eml)|*.eml|All (*.*)|*.*'
    FilterIndex = 0
    Options = [ofFileMustExist, ofEnableSizing]
    Left = 134
    Top = 302
  end
  object clSMimeMessage: TclSMimeMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38123.495004074100000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    OnSaveAttachment = clSMimeMessageSaveAttachment
    OnGetSigningCertificate = clSMimeMessageGetSigningCertificate
    OnGetEncryptionCertificate = clSMimeMessageGetEncryptionCertificate
    Left = 52
    Top = 264
  end
  object SaveDialog: TSaveDialog
    DefaultExt = '.eml'
    Filter = 'Emails (*.eml)|*.eml|All (*.*)|*.*'
    FilterIndex = 0
    Left = 222
    Top = 302
  end
  object OpenAttach: TOpenDialog
    Options = [ofFileMustExist, ofEnableSizing]
    Left = 486
    Top = 290
  end
  object clCertificateStore: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40004.000000000000000000
    ValidTo = 40369.000000000000000000
    Left = 88
    Top = 264
  end
end
