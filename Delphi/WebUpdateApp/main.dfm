inherited MainForm: TMainForm
  Left = 457
  Top = 181
  Caption = 'Clever Web Update Application - Sample'
  Constraints.MinHeight = 480
  Constraints.MinWidth = 639
  ParentFont = True
  OldCreateOrder = True
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    object StatusBar: TStatusBar
      Left = 0
      Top = 345
      Width = 623
      Height = 19
      Panels = <
        item
          Alignment = taCenter
          Bevel = pbRaised
          Text = 'Cancel'
          Width = 80
        end
        item
          Text = 'Update Progress'
          Width = 50
        end>
      OnMouseDown = StatusBarMouseDown
      OnMouseUp = StatusBarMouseUp
    end
    object Memo1: TMemo
      Left = 0
      Top = 0
      Width = 623
      Height = 304
      Align = alClient
      Lines.Strings = (
        ''
        ''
        
          'This demo retrieves the version information from the website and' +
          ' if there is a newer version of the application available '
        'it will download the update files and run the update.'
        ''
        ''
        
          'You should always run your application using the starter.cmd fil' +
          'e and not using the TestApplication.exe or '
        'Delphi/C++Builder IDE.'
        ''
        ''
        'Also you must have the pkzipc.exe utility installed on your PC.'
        'You can get the latest version of pkzipc.exe from www.pkware.com'
        ''
        ''
        
          'You can learn more about the Web Updater functionality from the ' +
          'article available at '
        
          'https://www.clevercomponents.com/articles/article023/webupdater2' +
          '.asp'
        ''
        ''
        ''
        
          'Press the "Start Update" button to begin the Web updating proces' +
          's.')
      ReadOnly = True
      TabOrder = 1
    end
    object pnlBottom: TPanel
      Left = 0
      Top = 304
      Width = 623
      Height = 41
      Align = alBottom
      BevelOuter = bvNone
      TabOrder = 2
      DesignSize = (
        623
        41)
      object btnStartUpdate: TBitBtn
        Left = 8
        Top = 5
        Width = 100
        Height = 30
        Caption = 'Start Update'
        Default = True
        TabOrder = 0
        OnClick = btnStartUpdateClick
        Glyph.Data = {
          DE010000424DDE01000000000000760000002800000024000000120000000100
          0400000000006801000000000000000000001000000000000000000000000000
          80000080000000808000800000008000800080800000C0C0C000808080000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
          3333333333333333333333330000333333333333333333333333F33333333333
          00003333344333333333333333388F3333333333000033334224333333333333
          338338F3333333330000333422224333333333333833338F3333333300003342
          222224333333333383333338F3333333000034222A22224333333338F338F333
          8F33333300003222A3A2224333333338F3838F338F33333300003A2A333A2224
          33333338F83338F338F33333000033A33333A222433333338333338F338F3333
          0000333333333A222433333333333338F338F33300003333333333A222433333
          333333338F338F33000033333333333A222433333333333338F338F300003333
          33333333A222433333333333338F338F00003333333333333A22433333333333
          3338F38F000033333333333333A223333333333333338F830000333333333333
          333A333333333333333338330000333333333333333333333333333333333333
          0000}
        NumGlyphs = 2
      end
      object btnAbout: TBitBtn
        Left = 424
        Top = 5
        Width = 100
        Height = 30
        Anchors = [akTop, akRight]
        Caption = 'About'
        TabOrder = 1
        OnClick = btnAboutClick
        Glyph.Data = {
          DE010000424DDE01000000000000760000002800000024000000120000000100
          0400000000006801000000000000000000001000000000000000000000000000
          80000080000000808000800000008000800080800000C0C0C000808080000000
          FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333336633
          3333333333333FF3333333330000333333364463333333333333388F33333333
          00003333333E66433333333333338F38F3333333000033333333E66333333333
          33338FF8F3333333000033333333333333333333333338833333333300003333
          3333446333333333333333FF3333333300003333333666433333333333333888
          F333333300003333333E66433333333333338F38F333333300003333333E6664
          3333333333338F38F3333333000033333333E6664333333333338F338F333333
          0000333333333E6664333333333338F338F3333300003333344333E666433333
          333F338F338F3333000033336664333E664333333388F338F338F33300003333
          E66644466643333338F38FFF8338F333000033333E6666666663333338F33888
          3338F3330000333333EE666666333333338FF33333383333000033333333EEEE
          E333333333388FFFFF8333330000333333333333333333333333388888333333
          0000}
        NumGlyphs = 2
      end
      object btnClose: TBitBtn
        Left = 531
        Top = 5
        Width = 86
        Height = 30
        Anchors = [akTop, akRight]
        Caption = 'Exit'
        TabOrder = 2
        OnClick = btnCloseClick
      end
    end
  end
  object clWebUpdate: TclWebUpdate
    ProductName = 'Updater Sample'
    Author = 'Clever Components'
    UpdateURL = 
      'https://www.clevercomponents.com/demo/inetsuite/samples/webupdat' +
      'e6/webupdate.xml'
    UpdateDir = '.\webupdate'
    ActualUpdateInfoFile = '.\webupdate\lastupdate.xml'
    VersionFormat = vfNumber
    ErrorWords.Strings = (
      'fatal'
      'failed'
      'error')
    InternetAgent = 'Mozilla/4.0 (compatible; Clever Internet Suite 7.0)'
    OnRunUpdate = clWebUpdateRunUpdate
    OnTerminating = clWebUpdateTerminating
    OnDownloadProgress = clWebUpdateDownloadProgress
    OnError = clWebUpdateError
    OnNoUpdatesFound = clWebUpdateNoUpdatesFound
    Left = 346
    Top = 10
  end
end
