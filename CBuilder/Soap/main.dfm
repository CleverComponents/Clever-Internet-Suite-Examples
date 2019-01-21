inherited Form1: TForm1
  Left = 248
  Top = 114
  Caption = 'SOAP Message - Sample'
  ClientHeight = 259
  Font.Name = 'MS Sans Serif'
  ExplicitHeight = 297
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 181
    ExplicitHeight = 181
    object Label1: TLabel
      Left = 40
      Top = 16
      Width = 540
      Height = 26
      Caption = 
        'This demo demonstrates how to  use the  SOAPMessage component wi' +
        'th a freely available web service to get the latitude/longitude ' +
        'coordinates of an address. '
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label3: TLabel
      Left = 16
      Top = 85
      Width = 38
      Height = 13
      Caption = 'Address'
    end
    object Label4: TLabel
      Left = 16
      Top = 150
      Width = 38
      Height = 13
      Caption = 'Latitude'
    end
    object Label5: TLabel
      Left = 16
      Top = 54
      Width = 332
      Height = 13
      Caption = 'This demo uses a free service available from geocoder.us.'
      Font.Charset = ANSI_CHARSET
      Font.Color = clBlack
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object Label2: TLabel
      Left = 235
      Top = 150
      Width = 47
      Height = 13
      Caption = 'Longitude'
    end
    object btnStart: TButton
      Left = 72
      Top = 110
      Width = 105
      Height = 25
      Caption = 'Get coordinates'
      TabOrder = 1
      OnClick = btnStartClick
    end
    object edtLatitude: TEdit
      Left = 72
      Top = 147
      Width = 137
      Height = 21
      ReadOnly = True
      TabOrder = 2
    end
    object edtAddress: TEdit
      Left = 72
      Top = 83
      Width = 540
      Height = 21
      TabOrder = 0
      Text = '1600 Pennsylvania Ave, Washington DC'
    end
    object edtLongitude: TEdit
      Left = 288
      Top = 147
      Width = 137
      Height = 21
      ReadOnly = True
      TabOrder = 3
    end
  end
  object clSoapMessage: TclSoapMessage
    Header.CharSet = 'utf-8'
    Header.Connection = 'Keep-Alive'
    Header.Accept = 'text/html, */*'
    Header.AcceptLanguage = 'en-us'
    Addressing = <>
    Signatures = <>
    EncryptedKey.KeyClassName = 'TclXmlSKIKeyInfo'
    EncryptedKey.EncryptionMethod = 'http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p'
    EncryptedKey.References = <>
    Namespaces = <>
    EncodingStyle = 'http://schemas.xmlsoap.org/soap/encoding/'
    SecurityConfig.IdName = 'id'
    SecurityConfig.HashAlgorithms = <
      item
        Name = 'md2'
        Identifier = 32769
      end
      item
        Name = 'md5'
        Identifier = 32771
      end
      item
        Name = 'sha1'
        Identifier = 32772
      end>
    SecurityConfig.CryptAlgorithms = <
      item
        Name = 'aes256'
        Identifier = 26128
        KeySize = 32
      end
      item
        Name = 'aes192'
        Identifier = 26127
        KeySize = 24
      end
      item
        Name = 'aes128'
        Identifier = 26126
        KeySize = 16
      end>
    SecurityConfig.Namespaces = <
      item
        Prefix = 'env'
        NameSpace = 'http://www.w3.org/2003/05/soap-envelope'
      end
      item
        Prefix = 'soapenv'
        NameSpace = 'http://schemas.xmlsoap.org/soap/envelope/'
      end
      item
        Prefix = 'ds'
        NameSpace = 'http://www.w3.org/2000/09/xmldsig#'
      end
      item
        Prefix = 'wsse'
        NameSpace = 
          'http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecuri' +
          'ty-secext-1.0.xsd'
      end
      item
        Prefix = 'wsu'
        NameSpace = 
          'http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecuri' +
          'ty-utility-1.0.xsd'
      end
      item
        Prefix = 'wsa'
        NameSpace = 'http://www.w3.org/2005/08/addressing'
      end
      item
        Prefix = 'xenc'
        NameSpace = 'http://www.w3.org/2001/04/xmlenc#'
      end
      item
        Prefix = 'wsse11'
        NameSpace = 
          'http://docs.oasis-open.org/wss/oasis-wss-wssecurity-secext-1.1.x' +
          'sd'
      end>
    Left = 328
    Top = 184
  end
  object clHttp1: TclHttp
    Request = clSoapMessage
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite 8.0)'
    KeepConnection = False
    Left = 368
    Top = 184
  end
end
