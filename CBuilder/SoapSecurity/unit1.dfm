inherited Form1: TForm1
  Left = 305
  Top = 71
  Caption = 'SOAP Security - Encrypt / Decrypt, Sign / Verify  - Sample'
  ClientHeight = 570
  Font.Name = 'Tahoma'
  ExplicitHeight = 608
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 492
    ExplicitHeight = 492
    object Label4: TLabel
      Left = 16
      Top = 214
      Width = 53
      Height = 13
      Caption = 'Parameters'
    end
    object Label5: TLabel
      Left = 291
      Top = 214
      Width = 32
      Height = 13
      Caption = 'Values'
    end
    object Label6: TLabel
      Left = 24
      Top = 24
      Width = 3
      Height = 13
    end
    object Label15: TLabel
      Left = 16
      Top = 305
      Width = 102
      Height = 13
      Caption = 'Decrypted SOAP xml:'
    end
    object memWSDLParams: TMemo
      Left = 16
      Top = 233
      Width = 265
      Height = 62
      Lines.Strings = (
        'param1'
        'param2')
      ScrollBars = ssVertical
      TabOrder = 5
    end
    object memWSDLParamValues: TMemo
      Left = 291
      Top = 233
      Width = 230
      Height = 62
      Lines.Strings = (
        '1234567890'
        'sample_text')
      ScrollBars = ssVertical
      TabOrder = 6
    end
    object memSOAPMessage: TMemo
      Left = 16
      Top = 323
      Width = 505
      Height = 158
      ReadOnly = True
      ScrollBars = ssBoth
      TabOrder = 7
    end
    object btnSignEncrypt: TButton
      Left = 526
      Top = 20
      Width = 89
      Height = 25
      Caption = 'Sign/Encrypt'
      TabOrder = 2
      OnClick = btnSignEncryptClick
    end
    object btnDecryptVerify: TButton
      Left = 526
      Top = 53
      Width = 89
      Height = 25
      Caption = 'Decrypt/Verify'
      TabOrder = 3
      OnClick = btnDecryptVerifyClick
    end
    object btnCertificates: TButton
      Left = 526
      Top = 323
      Width = 89
      Height = 25
      Caption = 'Certificates'
      TabOrder = 8
      OnClick = btnCertificatesClick
    end
    object GroupBox1: TGroupBox
      Left = 16
      Top = 16
      Width = 281
      Height = 106
      Caption = ' SOAP Timestamp '
      TabOrder = 0
      object Label8: TLabel
        Left = 8
        Top = 24
        Width = 37
        Height = 13
        Caption = 'Created'
      end
      object Label9: TLabel
        Left = 8
        Top = 48
        Width = 34
        Height = 13
        Caption = 'Expires'
      end
      object Label10: TLabel
        Left = 8
        Top = 72
        Width = 11
        Height = 13
        Caption = 'ID'
      end
      object edtTimeStampID: TEdit
        Left = 72
        Top = 72
        Width = 201
        Height = 21
        TabOrder = 0
        Text = 'TimeStamp-123'
      end
      object edtTimeStampExpires: TEdit
        Left = 72
        Top = 48
        Width = 201
        Height = 21
        TabOrder = 1
        Text = '2020-02-01T11:51:03.314Z'
      end
      object edtTimestampCreated: TEdit
        Left = 72
        Top = 24
        Width = 201
        Height = 21
        TabOrder = 2
        Text = '2015-02-01T11:51:03.314Z'
      end
    end
    object GroupBox2: TGroupBox
      Left = 305
      Top = 16
      Width = 216
      Height = 106
      Caption = ' SOAP Addressing '
      TabOrder = 1
      object Label12: TLabel
        Left = 8
        Top = 24
        Width = 28
        Height = 13
        Caption = 'Name'
      end
      object Label13: TLabel
        Left = 8
        Top = 48
        Width = 27
        Height = 13
        Caption = 'Value'
      end
      object Label14: TLabel
        Left = 8
        Top = 72
        Width = 11
        Height = 13
        Caption = 'ID'
      end
      object edtAddressID: TEdit
        Left = 56
        Top = 72
        Width = 152
        Height = 21
        TabOrder = 0
        Text = 'Address-124'
      end
      object edtAddressValue: TEdit
        Left = 56
        Top = 48
        Width = 152
        Height = 21
        TabOrder = 1
        Text = '456'
      end
      object edtAddressName: TEdit
        Left = 56
        Top = 24
        Width = 152
        Height = 21
        TabOrder = 2
        Text = 'To'
      end
    end
    object GroupBox3: TGroupBox
      Left = 16
      Top = 128
      Width = 505
      Height = 78
      Caption = ' SOAP-WSDL parameters '
      TabOrder = 4
      object Label2: TLabel
        Left = 8
        Top = 24
        Width = 58
        Height = 13
        Caption = 'Method URI'
      end
      object Label3: TLabel
        Left = 8
        Top = 50
        Width = 36
        Height = 13
        Caption = 'Method'
      end
      object Label7: TLabel
        Left = 283
        Top = 51
        Width = 38
        Height = 13
        Caption = 'Body ID'
      end
      object edtMethod: TEdit
        Left = 72
        Top = 48
        Width = 193
        Height = 21
        TabOrder = 0
        Text = 'sampleMethod'
      end
      object edtMethodURI: TEdit
        Left = 72
        Top = 21
        Width = 425
        Height = 21
        TabOrder = 1
        Text = 'http://www.domain.com/sampleServices'
      end
      object edtBodyID: TEdit
        Left = 327
        Top = 48
        Width = 169
        Height = 21
        TabOrder = 2
        Text = 'Body-125'
      end
    end
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
    OnGetSigningCertificate = clSoapMessage1GetSigningCertificate
    OnGetEncryptionCertificate = clSoapMessage1GetEncryptionCertificate
    Left = 184
    Top = 376
  end
  object clCertificateStore1: TclCertificateStore
    StoreName = 'MY'
    CSP = 'Microsoft Base Cryptographic Provider v1.0'
    ValidFrom = 42039.000000000000000000
    ValidTo = 42404.000000000000000000
    Left = 144
    Top = 376
  end
  object OpenDialog1: TOpenDialog
    DefaultExt = '.xml'
    Filter = 'XML (*.xml)|*.xml|All (*.*)|*.*'
    FilterIndex = 0
    Options = [ofHideReadOnly, ofFileMustExist, ofEnableSizing]
    Left = 224
    Top = 376
  end
  object SaveDialog1: TSaveDialog
    DefaultExt = '.xml'
    Filter = 'XML (*.xml)|*.xml|All (*.*)|*.*'
    FilterIndex = 0
    Left = 264
    Top = 376
  end
end
