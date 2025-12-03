inherited MainForm: TMainForm
  Left = 261
  Top = 62
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'MS SMTP Mail Sender - Sample'
  OldCreateOrder = True
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label1: TLabel
      Left = 8
      Top = 8
      Width = 513
      Height = 13
      Caption = 
        'This demo demonstrates how to send MIME mail message using Micro' +
        'soft Exchange server'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label3: TLabel
      Left = 9
      Top = 104
      Width = 47
      Height = 13
      Caption = 'Plain Text'
    end
    object Label4: TLabel
      Left = 316
      Top = 104
      Width = 51
      Height = 13
      Caption = 'Plain HTML'
    end
    object Label5: TLabel
      Left = 10
      Top = 218
      Width = 61
      Height = 13
      Caption = 'Attachments'
    end
    object Label6: TLabel
      Left = 8
      Top = 305
      Width = 137
      Height = 13
      Caption = 'Exchange drop/pickup folder'
    end
    object Label7: TLabel
      Left = 11
      Top = 32
      Width = 24
      Height = 13
      Caption = 'From'
    end
    object Label8: TLabel
      Left = 10
      Top = 58
      Width = 31
      Height = 13
      Caption = 'To List'
    end
    object Label9: TLabel
      Left = 10
      Top = 81
      Width = 36
      Height = 13
      Caption = 'Subject'
    end
    object memText: TMemo
      Left = 8
      Top = 120
      Width = 297
      Height = 94
      Lines.Strings = (
        
          'This is MIME test message built using Clever MailMessage compone' +
          'nt')
      ScrollBars = ssBoth
      TabOrder = 3
      WordWrap = False
    end
    object memHtml: TMemo
      Left = 316
      Top = 120
      Width = 296
      Height = 94
      Lines.Strings = (
        '<html>'
        '<body>'
        
          '<p>This is MIME test message built using Clever MailMessage comp' +
          'onent</p>'
        '</body>'
        '</html>')
      ScrollBars = ssBoth
      TabOrder = 4
      WordWrap = False
    end
    object lbAttachments: TListBox
      Left = 8
      Top = 236
      Width = 521
      Height = 55
      ItemHeight = 13
      TabOrder = 5
    end
    object btnAdd: TButton
      Left = 537
      Top = 235
      Width = 75
      Height = 25
      Caption = 'Add...'
      TabOrder = 6
      OnClick = btnAddClick
    end
    object edtPickup: TEdit
      Left = 156
      Top = 301
      Width = 457
      Height = 21
      TabOrder = 8
      Text = 'C:\Inetpub\mailroot\Pickup'
    end
    object btnClear: TButton
      Left = 537
      Top = 266
      Width = 75
      Height = 25
      Caption = 'Clear'
      TabOrder = 7
      OnClick = btnClearClick
    end
    object btnSend: TButton
      Left = 506
      Top = 328
      Width = 107
      Height = 25
      Caption = 'Send Message'
      TabOrder = 10
      OnClick = btnSendClick
    end
    object btnNew: TButton
      Left = 390
      Top = 328
      Width = 107
      Height = 25
      Caption = 'New Message'
      TabOrder = 9
      OnClick = btnNewClick
    end
    object edtFrom: TEdit
      Left = 50
      Top = 30
      Width = 563
      Height = 21
      TabOrder = 0
      Text = 'test@myhost.com'
    end
    object edtToList: TEdit
      Left = 50
      Top = 54
      Width = 563
      Height = 21
      TabOrder = 1
      Text = 'john@nexthost.com,doe@thirdhost.com'
    end
    object edtSubject: TEdit
      Left = 50
      Top = 78
      Width = 563
      Height = 21
      TabOrder = 2
      Text = 'Clever MailMessage Test'
    end
  end
  object OpenDialog: TOpenDialog
    Options = [ofEnableSizing]
    Left = 488
    Top = 262
  end
  object clMailMessage: TclMailMessage
    ToList = <>
    CCList = <>
    BCCList = <>
    Date = 38031.676125254600000000
    CharSet = 'iso-8859-1'
    ContentType = 'text/plain'
    Left = 236
    Top = 356
  end
end
