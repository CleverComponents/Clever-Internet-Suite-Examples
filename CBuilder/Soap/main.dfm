inherited Form1: TForm1
  Left = 468
  Top = 255
  BorderStyle = bsDialog
  Caption = 'SOAP Temperature Converter Service'
  ClientHeight = 265
  ClientWidth = 619
  OldCreateOrder = True
  ExplicitWidth = 625
  ExplicitHeight = 293
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlLogo: TPanel
    Width = 619
    ExplicitWidth = 619
    inherited imLogoMiggle: TImage
      Width = 4
      ExplicitWidth = 4
    end
    inherited imLogoRight: TImage
      Left = 410
      ExplicitLeft = 410
    end
  end
  inherited pnlMain: TPanel
    Width = 619
    Height = 187
    ExplicitWidth = 619
    ExplicitHeight = 187
    object Label1: TLabel
      Left = 20
      Top = 80
      Width = 76
      Height = 13
      Caption = 'Temperature, C'
    end
    object Label2: TLabel
      Left = 21
      Top = 115
      Width = 75
      Height = 13
      Caption = 'Temperature, F'
    end
    object Label3: TLabel
      Left = 16
      Top = 20
      Width = 550
      Height = 26
      Caption = 
        'The example shows how to use the TclSoapMessage component togeth' +
        'er with TclHttp, with a freely available web service, to do temp' +
        'erature conversion.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object btnC2F: TButton
      Left = 259
      Top = 75
      Width = 147
      Height = 25
      Caption = 'Celsius -> Fahrenheit'
      TabOrder = 2
      OnClick = btnC2FClick
    end
    object edtCelsius: TEdit
      Left = 125
      Top = 77
      Width = 111
      Height = 21
      TabOrder = 0
    end
    object edtFahrenheit: TEdit
      Left = 125
      Top = 112
      Width = 111
      Height = 21
      TabOrder = 1
    end
    object btnF2C: TButton
      Left = 259
      Top = 110
      Width = 147
      Height = 25
      Caption = 'Fahrenheit -> Celsius'
      TabOrder = 3
      OnClick = btnF2CClick
    end
    object rbUseSoapWsdl: TRadioButton
      Left = 456
      Top = 79
      Width = 145
      Height = 17
      Caption = 'Use SOAP WSDL Builder'
      Checked = True
      TabOrder = 4
      TabStop = True
    end
    object rbUseSoapXml: TRadioButton
      Left = 456
      Top = 102
      Width = 145
      Height = 17
      Caption = 'Use SOAP XML String'
      TabOrder = 5
    end
  end
  object clHttp1: TclHttp
    UserAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite)'
    KeepConnection = False
    Left = 544
    Top = 216
  end
  object clSoapMessage1: TclSoapMessage
    Header.CharSet = 'utf-8'
    Header.Accept = '*/*'
    Addressing = <>
    Signatures = <>
    EncryptedKey.KeyClassName = 'TclXmlSKIKeyInfo'
    EncryptedKey.EncryptionMethod = 'http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p'
    EncryptedKey.References = <>
    Namespaces = <>
    EncodingStyle = 'http://schemas.xmlsoap.org/soap/encoding/'
    SecurityConfig.IdName = 'Id'
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
    Left = 472
    Top = 216
  end
end
