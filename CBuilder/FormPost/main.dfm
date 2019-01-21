inherited MainForm: TMainForm
  Left = 286
  Top = 55
  Caption = 'Simulate Web Form POST request - Sample'
  Font.Name = 'MS Sans Serif'
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label4: TLabel
      Left = 16
      Top = 48
      Width = 28
      Height = 13
      Caption = 'Name'
    end
    object Label5: TLabel
      Left = 16
      Top = 126
      Width = 22
      Height = 13
      Caption = 'Host'
    end
    object Label1: TLabel
      Left = 16
      Top = 208
      Width = 48
      Height = 13
      Caption = 'Response'
    end
    object Label2: TLabel
      Left = 16
      Top = 4
      Width = 131
      Height = 13
      Caption = 'Try the original web page at'
    end
    object Label3: TLabel
      Left = 16
      Top = 74
      Width = 42
      Height = 13
      Caption = 'Birthdate'
    end
    object Label6: TLabel
      Left = 16
      Top = 101
      Width = 40
      Height = 13
      Caption = 'Account'
    end
    object edtName: TEdit
      Left = 91
      Top = 46
      Width = 430
      Height = 21
      TabOrder = 2
      Text = 'John Doe'
    end
    object btnSubmit: TButton
      Left = 16
      Top = 170
      Width = 75
      Height = 25
      Caption = '&Submit'
      TabOrder = 6
      OnClick = btnSubmitClick
    end
    object edtHost: TEdit
      Left = 16
      Top = 143
      Width = 505
      Height = 21
      TabOrder = 5
      Text = 
        'https://www.clevercomponents.com/products/inetsuite/demos/serverf' +
        'ormpost.asp'
    end
    object Memo1: TMemo
      Left = 16
      Top = 224
      Width = 505
      Height = 126
      ReadOnly = True
      TabOrder = 7
    end
    object edtViewPage: TEdit
      Left = 16
      Top = 21
      Width = 505
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 0
      Text = 
        'https://www.clevercomponents.com/products/inetsuite/demos/formpos' +
        't.asp'
    end
    object btnView: TButton
      Left = 535
      Top = 19
      Width = 75
      Height = 25
      Caption = '&View...'
      TabOrder = 1
      OnClick = btnViewClick
    end
    object edtBirthdate: TEdit
      Left = 91
      Top = 72
      Width = 430
      Height = 21
      TabOrder = 3
      Text = '10/10/77'
    end
    object edtAccount: TEdit
      Left = 91
      Top = 99
      Width = 430
      Height = 21
      TabOrder = 4
      Text = '123456'
    end
  end
  object clHttpRequest: TclHttpRequest
    Items.Items = (
      'TclFormFieldRequestItem'
      True
      'Name'
      ''
      'TclFormFieldRequestItem'
      True
      'Birthdate'
      ''
      'TclFormFieldRequestItem'
      True
      'Account'
      '')
    Header.ContentType = 'application/x-www-form-urlencoded'
    Header.Accept = '*/*'
    Left = 352
    Top = 256
  end
  object clHttp1: TclHttp
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    Left = 416
    Top = 256
  end
end
