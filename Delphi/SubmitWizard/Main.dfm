inherited MainForm: TMainForm
  Left = 286
  Top = 55
  Caption = 'Simulate Web Form POST requests from multiple web forms - Sample'
  Font.Name = 'MS Sans Serif'
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label4: TLabel
      Left = 12
      Top = 50
      Width = 50
      Height = 13
      Caption = 'First Name'
    end
    object Label1: TLabel
      Left = 12
      Top = 217
      Width = 48
      Height = 13
      Caption = 'Response'
    end
    object Label2: TLabel
      Left = 12
      Top = 3
      Width = 131
      Height = 13
      Caption = 'Try the original web page at'
    end
    object Label3: TLabel
      Left = 12
      Top = 76
      Width = 51
      Height = 13
      Caption = 'Last Name'
    end
    object Label6: TLabel
      Left = 12
      Top = 102
      Width = 40
      Height = 13
      Caption = 'Account'
    end
    object Label7: TLabel
      Left = 12
      Top = 128
      Width = 72
      Height = 13
      Caption = 'File Description'
    end
    object Label8: TLabel
      Left = 12
      Top = 154
      Width = 47
      Height = 13
      Caption = 'File Name'
    end
    object edtFirstName: TEdit
      Left = 91
      Top = 47
      Width = 440
      Height = 21
      TabOrder = 2
      Text = 'John'
    end
    object btnStart: TButton
      Left = 12
      Top = 183
      Width = 73
      Height = 25
      Caption = '&Submit'
      TabOrder = 7
      OnClick = btnStartClick
    end
    object memResult: TMemo
      Left = 12
      Top = 234
      Width = 509
      Height = 120
      ReadOnly = True
      TabOrder = 9
      WordWrap = False
    end
    object edtViewPage: TEdit
      Left = 12
      Top = 21
      Width = 519
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 0
      Text = 
        'https://www.clevercomponents.com/products/inetsuite/demos/submitw' +
        'izard.asp'
    end
    object btnView: TButton
      Left = 539
      Top = 19
      Width = 75
      Height = 25
      Caption = '&View...'
      TabOrder = 1
      OnClick = btnViewClick
    end
    object edtLastName: TEdit
      Left = 91
      Top = 72
      Width = 440
      Height = 21
      TabOrder = 3
      Text = 'Doe'
    end
    object edtAccount: TEdit
      Left = 91
      Top = 98
      Width = 440
      Height = 21
      TabOrder = 4
      Text = '123'
    end
    object edtDescription: TEdit
      Left = 91
      Top = 124
      Width = 440
      Height = 21
      TabOrder = 5
      Text = 'Delphi project file'
    end
    object edtFileName: TEdit
      Left = 91
      Top = 150
      Width = 440
      Height = 21
      TabOrder = 6
      Text = 'SubmitWizard.dpr'
    end
    object btnStop: TButton
      Left = 91
      Top = 183
      Width = 73
      Height = 25
      Caption = 'Sto&p'
      TabOrder = 8
      OnClick = btnStopClick
    end
  end
  object clMultiUploader: TclMultiUploader
    ReconnectAfter = 1
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    Connection = clInternetConnection
    OnProcessCompleted = clMultiUploaderProcessCompleted
    UploadList = <
      item
        URL = 
          'https://www.clevercomponents.com/products/inetsuite/demos/submitw' +
          'izardtwo.asp'
        HttpRequest = rbStep1
        UseHttpRequest = True
        RequestMethod = 'POST'
      end
      item
        URL = 
          'https://www.clevercomponents.com/products/inetsuite/demos/submitw' +
          'izardthree.asp'
        HttpRequest = rbStep2
        UseHttpRequest = True
        RequestMethod = 'POST'
      end>
    PublishFileMask = '*.*'
    Left = 132
    Top = 300
  end
  object clInternetConnection: TclInternetConnection
    Left = 254
    Top = 298
  end
  object rbStep1: TclHttpRequest
    Items.Items = (
      'TclFormFieldRequestItem'
      True
      'FirstName'
      ''
      'TclFormFieldRequestItem'
      True
      'LastName'
      ''
      'TclFormFieldRequestItem'
      True
      'Account'
      '')
    Header.ContentType = 'application/x-www-form-urlencoded'
    Header.Accept = '*/*'
    Left = 132
    Top = 246
  end
  object rbStep2: TclHttpRequest
    Items.Items = (
      'TclFormFieldRequestItem'
      True
      'Description'
      ''
      'TclSubmitFileRequestItem'
      True
      'FileName'
      ''
      'application/octet-stream')
    Header.ContentType = 'multipart/form-data'
    Header.Accept = '*/*'
    Left = 254
    Top = 244
  end
end
