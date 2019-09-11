inherited Form1: TForm1
  Left = 241
  Top = 120
  Caption = 'SOAP Digital Signature - Sample'
  Font.Name = 'Tahoma'
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    ExplicitHeight = 364
    object Label1: TLabel
      Left = 13
      Top = 179
      Width = 66
      Height = 13
      Caption = 'Certificate File'
    end
    object Label2: TLabel
      Left = 13
      Top = 203
      Width = 46
      Height = 13
      Caption = 'Password'
    end
    object Label3: TLabel
      Left = 441
      Top = 6
      Width = 116
      Height = 13
      Caption = 'SOAP data items to Sign'
    end
    object Label4: TLabel
      Left = 12
      Top = 6
      Width = 111
      Height = 13
      Caption = 'Source SOAP message'
    end
    object Label5: TLabel
      Left = 14
      Top = 231
      Width = 110
      Height = 13
      Caption = 'Signed SOAP message'
    end
    object Bevel1: TBevel
      Left = 11
      Top = 226
      Width = 605
      Height = 2
    end
    object memSource: TMemo
      Left = 12
      Top = 24
      Width = 417
      Height = 145
      Lines.Strings = (
        '<?xml version="1.0" encoding="UTF-8"?>'
        
          '<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envel' +
          'ope/">'
        '    <soap:Header>'
        '      <Operation Id="MsgOperation">TestAction</Operation>'
        '    </soap:Header>'
        '    <soap:Body Id="MsgBody">'
        '      <TestData>data</TestData>'
        '    </soap:Body>'
        '</soap:Envelope>')
      ScrollBars = ssBoth
      TabOrder = 0
      WordWrap = False
    end
    object memResult: TMemo
      Left = 13
      Top = 248
      Width = 598
      Height = 105
      Lines.Strings = (
        'Result'
        '')
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 6
      WordWrap = False
    end
    object btnSign: TButton
      Left = 516
      Top = 194
      Width = 97
      Height = 25
      Caption = 'Sign'
      TabOrder = 5
      OnClick = btnSignClick
    end
    object edtCertFile: TEdit
      Left = 88
      Top = 176
      Width = 313
      Height = 21
      TabOrder = 2
      Text = '*.p12'
    end
    object edtCertPassword: TEdit
      Left = 88
      Top = 200
      Width = 89
      Height = 21
      PasswordChar = '*'
      TabOrder = 4
    end
    object memReferences: TMemo
      Left = 440
      Top = 24
      Width = 174
      Height = 145
      Lines.Strings = (
        'MsgOperation'
        'MsgBody')
      ScrollBars = ssVertical
      TabOrder = 1
    end
    object btnBrowse: TButton
      Left = 405
      Top = 175
      Width = 25
      Height = 22
      Caption = '...'
      TabOrder = 3
      OnClick = btnBrowseClick
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
    OnGetSigningCertificate = clSoapMessageGetSigningCertificate
    Left = 272
    Top = 270
  end
  object OpenDialog: TOpenDialog
    DefaultExt = '*.p12'
    Filter = '*.cer|*.cer|*.p12|*.p12|*.pfx|*.pfx|All (*.*)|*.*'
    FilterIndex = 2
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 352
    Top = 272
  end
  object clCertificateStore: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 40008.000000000000000000
    ValidTo = 40373.000000000000000000
    Left = 312
    Top = 272
  end
end
