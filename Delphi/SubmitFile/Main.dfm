inherited MainForm: TMainForm
  Left = 286
  Top = 55
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Upload a file using POST request - Sample'
  OldCreateOrder = True
  OnCloseQuery = FormCloseQuery
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object Label4: TLabel
      Left = 16
      Top = 50
      Width = 16
      Height = 13
      Caption = 'File'
    end
    object Label5: TLabel
      Left = 16
      Top = 98
      Width = 22
      Height = 13
      Caption = 'Host'
    end
    object clProgressBar1: TclProgressBarDC
      Left = 16
      Top = 179
      Width = 515
      Height = 8
      Options = [dpDrawTotal]
      InternetControl = clUploader
    end
    object Label1: TLabel
      Left = 16
      Top = 200
      Width = 47
      Height = 13
      Caption = 'Response'
    end
    object Label2: TLabel
      Left = 16
      Top = 5
      Width = 135
      Height = 13
      Caption = 'Try the original web page at'
    end
    object edtFile: TEdit
      Left = 16
      Top = 66
      Width = 515
      Height = 21
      TabOrder = 2
      Text = 'SubmitFileHTTP.dpr'
    end
    object btnBrowse: TButton
      Left = 540
      Top = 65
      Width = 75
      Height = 25
      Caption = '&Browse...'
      TabOrder = 3
      OnClick = btnBrowseClick
    end
    object btnStart: TButton
      Left = 16
      Top = 145
      Width = 75
      Height = 25
      Caption = '&Send File'
      TabOrder = 5
      OnClick = btnStartClick
    end
    object edtHost: TEdit
      Left = 16
      Top = 115
      Width = 515
      Height = 21
      TabOrder = 4
      Text = 
        'https://www.clevercomponents.com/products/inetsuite/demos/server' +
        'submitfile.asp'
    end
    object Memo1: TMemo
      Left = 16
      Top = 217
      Width = 515
      Height = 135
      ReadOnly = True
      TabOrder = 7
    end
    object btnStop: TButton
      Left = 98
      Top = 145
      Width = 75
      Height = 25
      Caption = 'Stop'
      TabOrder = 6
      OnClick = btnStopClick
    end
    object edtViewPage: TEdit
      Left = 16
      Top = 21
      Width = 515
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 0
      Text = 
        'https://www.clevercomponents.com/products/inetsuite/demos/submit' +
        'file.asp'
    end
    object btnView: TButton
      Left = 540
      Top = 19
      Width = 75
      Height = 25
      Caption = '&View...'
      TabOrder = 1
      OnClick = btnViewClick
    end
  end
  object OpenDialog1: TOpenDialog
    Left = 354
    Top = 61
  end
  object clUploader: TclUploader
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    UseHttpRequest = True
    HttpRequest = clHttpRequest
    OnStatusChanged = clUploaderStatusChanged
    OnProcessCompleted = clUploaderProcessCompleted
    RequestMethod = 'POST'
    Left = 148
    Top = 227
  end
  object clHttpRequest: TclHttpRequest
    Items.Items = (
      'TclSubmitFileRequestItem'
      True
      'FileName'
      ''
      'application/octet-stream')
    Header.Connection = 'Keep-Alive'
    Header.ContentType = 'multipart/form-data'
    Header.Accept = 'text/html, */*'
    Header.AcceptLanguage = 'en-us'
    Left = 242
    Top = 228
  end
end
