inherited Form1: TForm1
  Left = 286
  Top = 95
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'TclProgressBar - Sample'
  ClientHeight = 558
  OldCreateOrder = True
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  inherited pnlMain: TPanel
    Height = 480
    object clProgressBar1: TclProgressBar
      Left = 30
      Top = 134
      Width = 25
      Height = 181
      Orientation = doVertical
      DrawScheme = dsWindowsThemeVert_1
    end
    object clProgressBar2: TclProgressBar
      Left = 93
      Top = 138
      Width = 518
      Height = 25
    end
    object clProgressBar3: TclProgressBar
      Left = 94
      Top = 238
      Width = 518
      Height = 25
      UseWindowsThemes = False
      DrawScheme = dsWindowsXP_3
    end
    object clProgressBar4: TclProgressBar
      Left = 94
      Top = 187
      Width = 518
      Height = 25
      DrawScheme = dsWindowsThemeXP
    end
    object clProgressBar5: TclProgressBar
      Left = 94
      Top = 289
      Width = 518
      Height = 25
      UseWindowsThemes = False
      DrawScheme = dsCustom
      Style = dsFlat
      Colors.BackGround = clWhite
      Colors.Frame = clBlue
      Colors.ItemColors.StatusUnknown = clBlue
      Colors.ItemColors.StatusSuccess = clBlue
      Colors.ItemColors.StatusFailed = clRed
      Colors.ItemColors.StatusErrors = clYellow
      Colors.ItemColors.StatusProcess = clBlue
      Colors.ItemColors.StatusTerminated = clBlue
      Colors.TotalColors.StatusUnknown = clGreen
      Colors.TotalColors.StatusSuccess = clGreen
      Colors.TotalColors.StatusFailed = clRed
      Colors.TotalColors.StatusErrors = clYellow
      Colors.TotalColors.StatusProcess = clGreen
      Colors.TotalColors.StatusTerminated = clGreen
    end
    object clListViewProgressBar1: TclProgressBar
      Left = 295
      Top = 332
      Width = 76
      Height = 16
      DrawScheme = dsCustom
      BorderStyle = bsNone
      ProgressSplit = 80
      Colors.BackGround = clWindow
      ThemedStyles.Bar = 11
      ThemedStyles.BarState = 2
      ThemedStyles.Item = 5
      ThemedStyles.ItemStates.StatusUnknown = 4
      ThemedStyles.ItemStates.StatusSuccess = 1
      ThemedStyles.ItemStates.StatusFailed = 2
      ThemedStyles.ItemStates.StatusErrors = 3
      ThemedStyles.ItemStates.StatusProcess = 4
      ThemedStyles.ItemStates.StatusTerminated = 4
      ThemedStyles.Total = 5
      ThemedStyles.TotalStates.StatusUnknown = 1
      ThemedStyles.TotalStates.StatusSuccess = 1
      ThemedStyles.TotalStates.StatusFailed = 2
      ThemedStyles.TotalStates.StatusErrors = 3
      ThemedStyles.TotalStates.StatusProcess = 1
      ThemedStyles.TotalStates.StatusTerminated = 1
      ThemedStyles.PulseOverlay = 7
      Visible = False
      OnChanged = clListViewProgressBar1Changed
    end
    object clListViewProgressBar2: TclProgressBar
      Left = 377
      Top = 332
      Width = 76
      Height = 16
      Options = [dpDrawTotal]
      DrawScheme = dsCustom
      BorderStyle = bsNone
      ProgressSplit = 80
      Colors.BackGround = clWindow
      ThemedStyles.Bar = 11
      ThemedStyles.BarState = 2
      ThemedStyles.Item = 5
      ThemedStyles.ItemStates.StatusUnknown = 4
      ThemedStyles.ItemStates.StatusSuccess = 1
      ThemedStyles.ItemStates.StatusFailed = 2
      ThemedStyles.ItemStates.StatusErrors = 3
      ThemedStyles.ItemStates.StatusProcess = 4
      ThemedStyles.ItemStates.StatusTerminated = 4
      ThemedStyles.Total = 5
      ThemedStyles.TotalStates.StatusUnknown = 1
      ThemedStyles.TotalStates.StatusSuccess = 1
      ThemedStyles.TotalStates.StatusFailed = 2
      ThemedStyles.TotalStates.StatusErrors = 3
      ThemedStyles.TotalStates.StatusProcess = 1
      ThemedStyles.TotalStates.StatusTerminated = 1
      ThemedStyles.PulseOverlay = 7
      Visible = False
      OnChanged = clListViewProgressBar1Changed
    end
    object clListViewProgressBar3: TclProgressBar
      Left = 461
      Top = 331
      Width = 76
      Height = 16
      Options = [dpDrawItems]
      DrawScheme = dsCustom
      BorderStyle = bsNone
      ProgressSplit = 80
      Colors.BackGround = clWindow
      ThemedStyles.Bar = 11
      ThemedStyles.BarState = 2
      ThemedStyles.Item = 5
      ThemedStyles.ItemStates.StatusUnknown = 4
      ThemedStyles.ItemStates.StatusSuccess = 1
      ThemedStyles.ItemStates.StatusFailed = 2
      ThemedStyles.ItemStates.StatusErrors = 3
      ThemedStyles.ItemStates.StatusProcess = 4
      ThemedStyles.ItemStates.StatusTerminated = 4
      ThemedStyles.Total = 5
      ThemedStyles.TotalStates.StatusUnknown = 1
      ThemedStyles.TotalStates.StatusSuccess = 1
      ThemedStyles.TotalStates.StatusFailed = 2
      ThemedStyles.TotalStates.StatusErrors = 3
      ThemedStyles.TotalStates.StatusProcess = 1
      ThemedStyles.TotalStates.StatusTerminated = 1
      ThemedStyles.PulseOverlay = 7
      Visible = False
      OnChanged = clListViewProgressBar1Changed
    end
    object Label1: TLabel
      Left = 16
      Top = 6
      Width = 569
      Height = 31
      AutoSize = False
      Caption = 
        'This demos demonstrates different variants of painting a progres' +
        's of internent operations with using of the TclProgressBar compo' +
        'nent. Try the buttons below to simulate different progress bar p' +
        'ositions.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clNavy
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label2: TLabel
      Left = 16
      Top = 90
      Width = 62
      Height = 13
      Caption = 'Vertical Style'
    end
    object Label3: TLabel
      Left = 96
      Top = 91
      Width = 75
      Height = 13
      Caption = 'Horizontal Style'
    end
    object Label4: TLabel
      Left = 30
      Top = 110
      Width = 87
      Height = 13
      Caption = 'Windows Theme 1'
    end
    object Label5: TLabel
      Left = 94
      Top = 169
      Width = 87
      Height = 13
      Caption = 'Windows Theme 2'
    end
    object Label6: TLabel
      Left = 94
      Top = 218
      Width = 210
      Height = 13
      Caption = '3D look style with Windows XP color scheme'
    end
    object Label7: TLabel
      Left = 94
      Top = 271
      Width = 215
      Height = 13
      Caption = 'Flat look style with Windows XP color scheme'
    end
    object Label8: TLabel
      Left = 16
      Top = 336
      Width = 276
      Height = 13
      Caption = 'The sample of painting a progress on an arbitrary surface'
    end
    object Bevel1: TBevel
      Left = 9
      Top = 324
      Width = 605
      Height = 3
    end
    object Bevel2: TBevel
      Left = 9
      Top = 76
      Width = 605
      Height = 3
    end
    object btnOne: TButton
      Left = 172
      Top = 42
      Width = 100
      Height = 25
      Caption = '25 % of progress'
      TabOrder = 1
      OnClick = btnOneClick
    end
    object btnTwo: TButton
      Left = 345
      Top = 42
      Width = 100
      Height = 25
      Caption = '50 % of progress'
      TabOrder = 2
      OnClick = btnTwoClick
    end
    object btnThree: TButton
      Left = 512
      Top = 41
      Width = 100
      Height = 25
      Caption = '100 % of progress'
      TabOrder = 3
      OnClick = btnThreeClick
    end
    object btnInit: TButton
      Left = 13
      Top = 42
      Width = 100
      Height = 25
      Caption = '0 % of progress'
      TabOrder = 0
      OnClick = btnInitClick
    end
    object ListView: TListView
      Left = 11
      Top = 354
      Width = 602
      Height = 113
      Columns = <
        item
          Caption = 'Item'
          Width = 200
        end
        item
          Caption = 'Progress'
          Width = 350
        end>
      GridLines = True
      Items.Data = {
        E30000000500000000000000FFFFFFFFFFFFFFFF02000000000000000D57696E
        646F7773205468656D650870726F6772657373046461746100000000FFFFFFFF
        FFFFFFFF00000000000000000000000000FFFFFFFFFFFFFFFF02000000000000
        001853686F7720746F74616C2070726F6772657373206F6E6C790870726F6772
        657373046461746100000000FFFFFFFFFFFFFFFF000000000000000000000000
        00FFFFFFFFFFFFFFFF02000000000000001753686F77206974656D2070726F67
        72657373206F6E6C790870726F67726573730464617461FFFFFFFFFFFFFFFFFF
        FFFFFF}
      ReadOnly = True
      RowSelect = True
      TabOrder = 4
      ViewStyle = vsReport
      OnCustomDrawSubItem = ListViewCustomDrawSubItem
    end
  end
end
