Imports System.IO
Imports System.Media
Imports System.Runtime.InteropServices
Imports System.Text.Json.Nodes
Imports System.Text.RegularExpressions
Imports System.Threading

Class MainWindow
    Public Sub New()
        InitializeComponent()

        _DEFAULTS = New ExDictionary(Of String, ExList(Of String))(Function() New ExList(Of String)(5))

        If File.Exists("MoeGoe_GUI.config") Then
            For Each line As String In File.ReadLines("MoeGoe_GUI.config")
                Dim split1 As String() = line.Split(">"c)
                _DEFAULTS.Add(split1(0), New ExList(Of String)(split1(1).Split("|"c), 5))
            Next
        End If

        If Not _DEFAULTS.ContainsKey("D1") Then
            _DEFAULTS("D1").Add("[ZH][ZH]")
        End If
        If Not _DEFAULTS.ContainsKey("D2") Then
            _DEFAULTS("D2").Add("[JA][JA]")
        End If
        If Not _DEFAULTS.ContainsKey("D3") Then
            _DEFAULTS("D3").Add("[KO][KO]")
        End If
        If Not _DEFAULTS.ContainsKey("D4") Then
            _DEFAULTS("D4").Add("[SA][SA]")
        End If
        If Not _DEFAULTS.ContainsKey("D5") Then
            _DEFAULTS("D5").Add("[EN][EN]")
        End If
        If Not _DEFAULTS.ContainsKey("D6") Then
            _DEFAULTS("D6").Add("[SH][SH]")
        End If
        If Not _DEFAULTS.ContainsKey("D7") Then
            _DEFAULTS("D7").Add("[GD][GD]")
        End If
        If Not _DEFAULTS.ContainsKey("D8") Then
            _DEFAULTS("D8").Add("[WZ][WZ]")
        End If
        If Not _DEFAULTS.ContainsKey("D9") Then
            _DEFAULTS("D9").Add("[SZ][SZ]")
        End If
        If Not _DEFAULTS.ContainsKey("D0") Then
            _DEFAULTS("D0").Add("[TH][TH]")
        End If

        _decLENGTHSCALE = 1
        _decNOISESCALE = 0.667D
        _decNOISESCALEW = 0.8D
        _decF0SCALE = 1

        _lstSPEAKERS = New List(Of String)
        _lstSYMBOLS = New List(Of String)
        _dicSPEAKERIDDICT = New Dictionary(Of ComboBox, Dictionary(Of Integer, Integer))
        _isSeeking = False

        If _DEFAULTS.ContainsKey("EXEPATHS") Then
            _strEXEPATH1 = __InlineAssignHelper(EXEPath.Text, _DEFAULTS("EXEPATHS").[Next]())
            modelControl.IsEnabled = True
        End If
    End Sub
    Private _cmd As CommandLine
    Private ReadOnly _DEFAULTS As ExDictionary(Of String, ExList(Of String))
    Private _strEXEPATH1 As String
    Private _strMODELPATH As String
    Private _strCONFIGPATH As String
    Private _strHUBERTPATH As String
    Private _strW2V2PATH As String
    Private _strSAVEPATH As String
    Private _strORIGINPATH As String
    Private _strEMOTIONPATH As String
    Private _decLENGTHSCALE As Decimal
    Private _decNOISESCALE As Decimal
    Private _decNOISESCALEW As Decimal
    Private _decF0SCALE As Decimal
    Private ReadOnly _lstSPEAKERS As List(Of String)
    Private ReadOnly _lstSYMBOLS As List(Of String)
    Private ReadOnly _dicSPEAKERIDDICT As Dictionary(Of ComboBox, Dictionary(Of Integer, Integer))
    Private _bUSEF0 As Boolean
    Private _isSeeking As Boolean
    Private _player As SoundPlayer
    Private Sub ClearAll()
        ClearVITS()
        ClearHubertVITS()
        ClearW2V2VITS()
    End Sub
    Private Sub ClearVITS()
        modelPath.Clear()
        _strMODELPATH = Nothing
        configPath.Clear()
        _strCONFIGPATH = Nothing
        ClearMode()
    End Sub
    Private Sub ClearMode()
        consoleBox.Clear()
        TxtInputText.Clear()
        speakerBox.Items.Clear()
        speakerBox.Text = ""
        _decLENGTHSCALE = 1
        _decNOISESCALE = 0.667D
        _decNOISESCALEW = 0.8D
        originPath.Clear()
        _strORIGINPATH = Nothing
        originBox.Items.Clear()
        originBox.Text = ""
        targetBox.Items.Clear()
        targetBox.Text = ""
        modeControl.IsEnabled = False
        ClearSavePanel()
    End Sub
    Private Sub ClearHubertVITS()
        HModelPath.Clear()
        _strMODELPATH = Nothing
        HConfigPath.Clear()
        _strCONFIGPATH = Nothing
        hubertPath.Clear()
        _strHUBERTPATH = Nothing
        ClearHubertMode()
    End Sub
    Private Sub ClearHubertMode()
        consoleBox.Clear()
        HOriginPath.Clear()
        _strORIGINPATH = Nothing
        HOpenOrigin.IsEnabled = False
        HOriginPath.IsEnabled = False
        HTargetBox.Items.Clear()
        HTargetBox.Text = ""
        _decLENGTHSCALE = 1
        _decNOISESCALE = 0.1D
        _decNOISESCALEW = 0.1D
        _decF0SCALE = 1
        HOriginBox.Items.Clear()
        HOriginBox.Text = ""
        HTargetBox2.Items.Clear()
        HTargetBox2.Text = ""
        HVCControl.IsEnabled = False
        ClearSavePanel()
    End Sub
    Private Sub ClearW2V2VITS()
        WModelPath.Clear()
        _strMODELPATH = Nothing
        WConfigPath.Clear()
        _strCONFIGPATH = Nothing
        W2V2Path.Clear()
        _strW2V2PATH = Nothing
        ClearW2V2Mode()
    End Sub
    Private Sub ClearW2V2Mode()
        consoleBox.Clear()
        emotionPath.Clear()
        _strEMOTIONPATH = Nothing
        WTextBox.Clear()
        WSpeakerBox.Items.Clear()
        WSpeakerBox.Text = ""
        _decLENGTHSCALE = 1
        _decNOISESCALE = 0.667D
        _decNOISESCALEW = 0.8D
        WOriginPath.Clear()
        _strORIGINPATH = Nothing
        WOriginBox.Items.Clear()
        WOriginBox.Text = ""
        WTargetBox.Items.Clear()
        WTargetBox.Text = ""
        WModeControl.IsEnabled = False
        ClearSavePanel()
    End Sub
    Private Sub ClearSavePanel()
        savePath.Clear()
        _strSAVEPATH = Nothing
        savePanel.IsEnabled = False
        resaveButton.IsEnabled = False
        _isSeeking = False
        _player = Nothing
        deleteButton.IsEnabled = False
        playButton.IsEnabled = False
        stopButton.IsEnabled = False
    End Sub
    Private Sub OpenEXE_Click() Handles openEXE.Click
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "|MoeGoe.exe"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            ClearAll()
            _DEFAULTS("EXEPATHS").Add(__InlineAssignHelper(_strEXEPATH1, __InlineAssignHelper(EXEPath.Text, ofd.FileName)))
            modelControl.IsEnabled = True
        End If
        ofd.Dispose()
    End Sub
    Private Sub EXEPath_KeyPress(sender As Object, e As KeyEventArgs) Handles EXEPath.KeyDown
        If e.Key = Key.Enter Then
            If Not File.Exists(EXEPath.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else
                ClearAll()
                _DEFAULTS("EXEPATHS").Add(__InlineAssignHelper(_strEXEPATH1, EXEPath.Text))
                modelControl.IsEnabled = True
            End If
        End If
    End Sub
    Private Sub GetModelBox(<Out> ByRef box As TextBox, <Out> ByRef key As String, <Out> ByRef check As Action)
        Select Case modelControl.SelectedIndex
            Case 0
                key = "_MODELPATHS"
                box = modelPath
                check = AddressOf CheckModel
            Case 1
                key = "H_MODELPATHS"
                box = HModelPath
                check = AddressOf CheckModelHubert
            Case 2
                key = "W_MODELPATHS"
                box = WModelPath
                check = AddressOf CheckModelW2V2
            Case Else
                key = Nothing
                box = Nothing
                check = Nothing
        End Select
    End Sub
    Private Sub OpenModel_Click() Handles openModel.Click
        Dim box As TextBox = Nothing
        Dim key As String = Nothing
        Dim check As Action = Nothing
        GetModelBox(box, key, check)
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "模型文件|*.pth|所有文件|*.*"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS(key).Add(__InlineAssignHelper(_strMODELPATH, __InlineAssignHelper(box.Text, ofd.FileName)))
            check()
        End If
        ofd.Dispose()
    End Sub
    Private Sub ModelPath_KeyPress(sender As Object, e As KeyEventArgs) Handles modelPath.KeyDown
        Dim box As TextBox = Nothing
        Dim key As String = Nothing
        Dim check As Action = Nothing
        GetModelBox(box, key, check)
        If e.Key = Input.Key.Enter Then
            If Not File.Exists(box.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else
                _DEFAULTS(key).Add(__InlineAssignHelper(_strMODELPATH, box.Text))
                check()
            End If
        End If
    End Sub
    Private Sub GetConfigBox(<Out> ByRef box As TextBox, <Out> ByRef key As String, <Out> ByRef check As Action)
        Select Case modelControl.SelectedIndex
            Case 0
                key = "_CONFIGPATHS"
                box = configPath
                check = AddressOf CheckModel
            Case 1
                key = "H_CONFIGPATHS"
                box = HConfigPath
                check = AddressOf CheckModelHubert
            Case 2
                key = "W_CONFIGPATHS"
                box = WConfigPath
                check = AddressOf CheckModelW2V2
            Case Else
                key = Nothing
                box = Nothing
                check = Nothing
        End Select
    End Sub
    Private Sub OpenConfig_Click() Handles openConfig.Click
        Dim box As TextBox = Nothing
        Dim key As String = Nothing
        Dim check As Action = Nothing
        GetConfigBox(box, key, check)
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "配置文件|*.json"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS(key).Add(__InlineAssignHelper(_strCONFIGPATH, __InlineAssignHelper(box.Text, ofd.FileName)))
            check()
        End If
        ofd.Dispose()
    End Sub
    Private Sub ConfigPath_KeyPress(sender As Object, e As KeyEventArgs) Handles configPath.KeyDown
        Dim box As TextBox = Nothing
        Dim key As String = Nothing
        Dim check As Action = Nothing
        GetConfigBox(box, key, check)
        If e.Key = Input.Key.Enter Then
            If Not File.Exists(box.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else
                _DEFAULTS(key).Add(__InlineAssignHelper(_strCONFIGPATH, box.Text))
                check()
            End If
        End If
    End Sub
    Private Sub CheckModel()
        ClearMode()
        If _strMODELPATH IsNot Nothing AndAlso _strCONFIGPATH IsNot Nothing Then
            InitializeSpeakers()
        End If
    End Sub

    Private Sub InitializeSpeakers()
        Using jsonStrm = File.OpenRead(_strCONFIGPATH)
            Dim jObj = JsonNode.Parse(jsonStrm).AsObject
            LoadJsonList(jObj, "speakers", _lstSPEAKERS)
            If _lstSPEAKERS.Count = 0 Then
                Dim nSpeakers As JsonNode = Nothing
                If jObj.TryGetPropertyValue("n_speakers", nSpeakers) Then
                    Dim speakerCount = nSpeakers.AsValue.GetValue(Of Integer)
                    If nSpeakers.AsValue.GetValue(Of Integer) Then
                        For i = 0 To speakerCount - 1
                            _lstSPEAKERS.Add(i.ToString())
                        Next
                    Else
                        _lstSPEAKERS.Add("0")
                    End If
                End If
            End If
            AddSpeakers()
            _lstSYMBOLS.Clear()
            LoadJsonList(jObj, "symbols", _lstSYMBOLS)
            GetStart()
        End Using
    End Sub

    Private Sub LoadJsonList(jObj As JsonObject, key As String, list As List(Of String))
        Dim speakerArray As JsonNode = Nothing
        list.Clear()
        If jObj.TryGetPropertyValue(key, speakerArray) Then
            For Each element In speakerArray.AsArray
                Dim speakerValue = element.AsValue?.GetValue(Of String)
                list.Add(speakerValue)
            Next
        End If
    End Sub

    Private Sub AddSpeakers()
        Select Case modelControl.SelectedIndex
            Case 0
                SelectSpeakers(speakerBox)
                SelectSpeakers(originBox)
                SelectSpeakers(targetBox)
            Case 1
                SelectSpeakers(HTargetBox)
                SelectSpeakers(HTargetBox2)
                SelectSpeakers(HOriginBox)
            Case 2
                SelectSpeakers(WSpeakerBox)
                SelectSpeakers(WOriginBox)
                SelectSpeakers(WTargetBox)
        End Select
    End Sub
    Private Sub GetStart()
        _cmd = New CommandLine
        AddHandler _cmd.OutputHandler, AddressOf Cmd_OutputHandler
        _cmd.Write($"""{_strEXEPATH1}"" --escape")
        _cmd.Write(_strMODELPATH)
        _cmd.Write(_strCONFIGPATH)
        Select Case modelControl.SelectedIndex
            Case 0
                modeControl.IsEnabled = True
            Case 1
                _cmd.Write(_strHUBERTPATH)
                HOpenOrigin.IsEnabled = True
                HOriginPath.IsEnabled = True
                HVCControl.IsEnabled = True
            Case 2
                _cmd.Write(_strW2V2PATH)
                WModeControl.IsEnabled = True
        End Select
        savePanel.IsEnabled = True
    End Sub
    Private Sub Cmd_OutputHandler(sender As CommandLine, e As String)
        Dispatcher.BeginInvoke(
            Sub()
                Try
                    consoleBox.AppendText(Regex.Unescape(e))
                Catch
                    consoleBox.AppendText(e)
                End Try
            End Sub)
    End Sub
    Private Function GetOriginBox() As TextBox
        Select Case modelControl.SelectedIndex
            Case 0
                Return originPath
            Case 1
                Return HOriginPath
            Case 2
                Return WOriginPath
            Case Else
                Return Nothing
        End Select
    End Function
    Private Sub OpenOrigin_Click() Handles openOrigin.Click
        Dim box As TextBox = GetOriginBox()
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "音频文件|*.wav;*.mp3;*.ogg;*.opus"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS("AUDIOPATHS").Add(__InlineAssignHelper(_strORIGINPATH, __InlineAssignHelper(box.Text, ofd.FileName)))
        End If
        ofd.Dispose()
    End Sub
    Private Sub OriginPath_KeyPress(sender As Object, e As KeyEventArgs) Handles originPath.KeyDown
        Dim textBox As TextBox = TryCast(sender, TextBox)
        If e.Key = Input.Key.Enter Then
            If Not File.Exists(textBox.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else _DEFAULTS("AUDIOPATHS").Add(__InlineAssignHelper(_strORIGINPATH, textBox.Text))
            End If
        End If
    End Sub
    Private Function IsFilled() As Boolean
        Select Case modelControl.SelectedIndex
            Case 0
                Select Case modeControl.SelectedIndex
                    Case 0
                        If TxtInputText.Text.Length = 0 Then
                            MessageBox.Show("请输入文本！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If speakerBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        Return True
                    Case 1
                        If _strORIGINPATH Is Nothing Then
                            MessageBox.Show("请指定原音频！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If originBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择原说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If targetBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择目标说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        Return True
                End Select
                Return False
            Case 1
                If _strORIGINPATH Is Nothing Then
                    MessageBox.Show("请指定原音频！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                    Return False
                End If
                Select Case HVCControl.SelectedIndex
                    Case 0
                        If HTargetBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择目标说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        Return True
                    Case 1
                        If HOriginBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择原说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If HTargetBox2.SelectedIndex = -1 Then
                            MessageBox.Show("请选择目标说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        Return True
                End Select
                Return False
            Case 2
                Select Case WModeControl.SelectedIndex
                    Case 0
                        If _strEMOTIONPATH Is Nothing Then
                            MessageBox.Show("请指定情感参考！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                        End If
                        If WTextBox.Text.Length = 0 Then
                            MessageBox.Show("请输入文本！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If WSpeakerBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        Return True
                    Case 1
                        If _strORIGINPATH Is Nothing Then
                            MessageBox.Show("请指定原音频！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If WOriginBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择原说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        If WTargetBox.SelectedIndex = -1 Then
                            MessageBox.Show("请选择目标说话人！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Warning)
                            Return False
                        End If
                        Return True
                End Select
                Return False
            Case Else
                Return False
        End Select
    End Function
    Private Sub SaveButton_Click() Handles saveButton.Click
        Dim sfd As New Forms.SaveFileDialog With
            {
            .Filter = "音频文件|*.wav"
            }
        If sfd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS("_SAVEPATHS").Add(__InlineAssignHelper(_strSAVEPATH, __InlineAssignHelper(savePath.Text, sfd.FileName)))
            SaveAudio()
        End If
        sfd.Dispose()
    End Sub
    Private Sub SaveAudio()
        If Not IsFilled() Then
            Return
        End If
        Dim directory As String = Path.GetDirectoryName(_strSAVEPATH)
        If Not IO.Directory.Exists(directory) Then
            IO.Directory.CreateDirectory(directory)
        End If
        deleteButton.IsEnabled = False
        playButton.IsEnabled = False
        stopButton.IsEnabled = False
        Select Case modelControl.SelectedIndex
            Case 0
                Select Case modeControl.SelectedIndex
                    Case 0
                        TTS(TxtInputText.Text, GetSelectedID(speakerBox))
                    Case 1
                        VC(GetSelectedID(originBox), GetSelectedID(targetBox))
                End Select
                _cmd.Write(_strSAVEPATH)
            Case 1
                Select Case HVCControl.SelectedIndex
                    Case 0
                        _cmd.Write(_strORIGINPATH)
                        _cmd.Write(GetSelectedID(HTargetBox).ToString())
                        If _bUSEF0 Then
                            _cmd.Write($"[LENGTH={_decLENGTHSCALE}][NOISE={_decNOISESCALE}][NOISEW={_decNOISESCALEW}][F0={_decF0SCALE}]{_strSAVEPATH}")
                        Else _cmd.Write($"[LENGTH={_decLENGTHSCALE}][NOISE={_decNOISESCALE}][NOISEW={_decNOISESCALEW}]{_strSAVEPATH}")
                        End If
                    Case 1
                        _cmd.Write($"[VC]")
                        _cmd.Write(_strORIGINPATH)
                        _cmd.Write(GetSelectedID(HOriginBox).ToString())
                        _cmd.Write(GetSelectedID(HTargetBox2).ToString())
                        _cmd.Write(_strSAVEPATH)
                End Select
            Case 2
                Select Case WModeControl.SelectedIndex
                    Case 0
                        TTS(WTextBox.Text, GetSelectedID(WSpeakerBox))
                        _cmd.Write(_strEMOTIONPATH)
                    Case 1
                        VC(GetSelectedID(WOriginBox), GetSelectedID(WTargetBox))
                End Select
                _cmd.Write(_strSAVEPATH)
        End Select
        _cmd.Write("y")
        resaveButton.IsEnabled = True
        _isSeeking = True
        Task.Run(
            Async Function()
                While True
                    If Not Volatile.Read(_isSeeking) Then
                        Return
                    End If
                    If File.Exists(_strSAVEPATH) Then
                        Await Dispatcher.BeginInvoke(
                             Sub()
                                 deleteButton.IsEnabled = True
                                 playButton.IsEnabled = True
                                 stopButton.IsEnabled = True
                                 Volatile.Write(_isSeeking, False)
                             End Sub)
                        Return
                    End If
                    Await Task.Delay(500)
                End While
            End Function)
    End Sub
    Private Function GetSelectedID(box As ComboBox) As Integer
        Return _dicSPEAKERIDDICT(box)(box.SelectedIndex)
    End Function
    Private Sub TTS(text1 As String, speaker As Integer)
        _cmd.Write("t")
        _cmd.Write($"[LENGTH={_decLENGTHSCALE}][NOISE={_decNOISESCALE}][NOISEW={_decNOISESCALEW}]{Regex.Replace(text1, "\r?\n", " ")}")
        _cmd.Write(speaker.ToString())
    End Sub
    Private Sub VC(origin As Integer, target As Integer)
        _cmd.Write("v")
        _cmd.Write(_strORIGINPATH)
        _cmd.Write(origin.ToString())
        _cmd.Write(target.ToString())
    End Sub
    Private Function GetTextBox() As TextBox
        Select Case modelControl.SelectedIndex
            Case 0
                Return TxtInputText
            Case 2
                Return WTextBox
            Case Else
                Return Nothing
        End Select
    End Function
    Private Sub CleanButton_Click() Handles cleanButton2.Click
        Dim box As TextBox = GetTextBox()
        Dim win As New CleanWindow(box, _cmd)
        RemoveHandler _cmd.OutputHandler, AddressOf Cmd_OutputHandler
        win.ShowDialog()
        AddHandler _cmd.OutputHandler, AddressOf Cmd_OutputHandler
    End Sub
    Private Function GetParameters() As Decimal()
        Return New Decimal() {_decLENGTHSCALE, _decNOISESCALE, _decNOISESCALEW, _decF0SCALE}
    End Function
    Private Sub SetParameters(lengthScale1 As Decimal, noiseScale1 As Decimal, noiseScaleW1 As Decimal)
        _decLENGTHSCALE = lengthScale1
        _decNOISESCALE = noiseScale1
        _decNOISESCALEW = noiseScaleW1
    End Sub
    Private Sub SetParameters(lengthScale1 As Decimal, noiseScale1 As Decimal, noiseScaleW1 As Decimal, f0Scale1 As Decimal)
        _decLENGTHSCALE = lengthScale1
        _decNOISESCALE = noiseScale1
        _decNOISESCALEW = noiseScaleW1
        _decF0SCALE = f0Scale1
    End Sub
    Private Sub AdvancedButton_Click() Handles paramsButton2.Click
        Dim win As New AdvancedWindow(AddressOf GetParameters, AddressOf SetParameters)
        win.ShowDialog()
    End Sub
    Private Sub ModelControl_SelectedIndexChanged() Handles modelControl.SelectionChanged
        '切换tab为什么要清除这些数据呢？
        'Select Case modelControl.SelectedIndex
        '    Case 0
        '        ClearVITS()
        '    Case 1
        '        ClearHubertVITS()
        '    Case 2
        '        ClearW2V2VITS()
        'End Select
    End Sub
    Private Sub CheckModelHubert()
        ClearHubertMode()
        If _strMODELPATH IsNot Nothing AndAlso _strCONFIGPATH IsNot Nothing AndAlso _strHUBERTPATH IsNot Nothing Then
            InitializeSpeakers()
        End If
    End Sub
    Private Sub HOpenHubert_Click() Handles HOpenHubert.Click
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "模型文件|*.pt|所有文件|*.*"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS("_HUBERTPATHS").Add(__InlineAssignHelper(_strHUBERTPATH, __InlineAssignHelper(hubertPath.Text, ofd.FileName)))
            CheckModelHubert()
        End If
        ofd.Dispose()
    End Sub
    Private Sub HubertPath_KeyPress(sender As Object, e As KeyEventArgs) Handles hubertPath.KeyDown
        If e.Key = Input.Key.Enter Then
            If Not File.Exists(HConfigPath.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else
                _DEFAULTS("_HUBERTPATHS").Add(__InlineAssignHelper(_strHUBERTPATH, hubertPath.Text))
                CheckModelHubert()
            End If
        End If
    End Sub
    Private Sub HAdvancedControl_Click() Handles HAdvancedControl.KeyDown
        Dim win As New HAdvancedWindow(AddressOf GetParameters, AddressOf SetParameters, _bUSEF0)
        win.ShowDialog()
    End Sub
    Private Sub MainWin_FormClosed() Handles Me.Closed
        Using sw As New StreamWriter("MoeGoe_GUI.config")
            For Each pair As KeyValuePair(Of String, ExList(Of String)) In _DEFAULTS
                sw.WriteLine(pair.Key & ">" & pair.Value.ToString)
            Next
        End Using
    End Sub
    Private Sub GetHistory(box As TextBox, key As String, e As KeyEventArgs)
        Dim list1 As ExList(Of String) = Nothing
        If Not _DEFAULTS.TryGetValue(key, list1) Then
            Return
        End If
        If e.Key = Input.Key.Up Then
            box.Text = list1.[Next]()
        ElseIf e.Key = Input.Key.Down Then
            box.Text = list1.Previous()
        End If
    End Sub
    Private Sub EXEPath_KeyDown(sender As Object, e As KeyEventArgs) Handles EXEPath.KeyDown
        GetHistory(EXEPath, "EXEPATHS", e)
    End Sub
    Private Sub ModelPath_KeyDown(sender As Object, e As KeyEventArgs) Handles modelPath.KeyDown
        GetHistory(modelPath, "_MODELPATHS", e)
    End Sub
    Private Sub ConfigPath_KeyDown(sender As Object, e As KeyEventArgs) Handles configPath.KeyDown
        GetHistory(configPath, "_CONFIGPATHS", e)
    End Sub
    Private Sub HModelPath_KeyDown(sender As Object, e As KeyEventArgs) Handles HModelPath.KeyDown
        GetHistory(HModelPath, "H_MODELPATHS", e)
    End Sub
    Private Sub HConfigPath_KeyDown(sender As Object, e As KeyEventArgs) Handles HConfigPath.KeyDown
        GetHistory(HConfigPath, "H_CONFIGPATHS", e)
    End Sub
    Private Sub HubertPath_KeyDown(sender As Object, e As KeyEventArgs) Handles hubertPath.KeyDown
        GetHistory(hubertPath, "_HUBERTPATHS", e)
    End Sub
    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtInputText.KeyDown
        Dim box As TextBox = TryCast(sender, TextBox)
        If Keyboard.Modifiers <> Input.Key.LeftCtrl Then
            Return
        End If
        Select Case e.Key
            Case Key.D1
                box.SelectedText = (_DEFAULTS("D1").[Next]())
                box.SelectionStart -= 4
            Case Key.D2
                box.SelectedText = (_DEFAULTS("D2").[Next]())
                box.SelectionStart -= 4
            Case Key.D3
                box.SelectedText = (_DEFAULTS("D3").[Next]())
                box.SelectionStart -= 4
            Case Key.D4
                box.SelectedText = (_DEFAULTS("D4").[Next]())
                box.SelectionStart -= 4
            Case Key.D5
                box.SelectedText = (_DEFAULTS("D5").[Next]())
                box.SelectionStart -= 4
            Case Key.D6
                box.SelectedText = (_DEFAULTS("D6").[Next]())
                box.SelectionStart -= 4
            Case Key.D7
                box.SelectedText = (_DEFAULTS("D7").[Next]())
                box.SelectionStart -= 4
            Case Key.D8
                box.SelectedText = (_DEFAULTS("D8").[Next]())
                box.SelectionStart -= 4
            Case Key.D9
                box.SelectedText = (_DEFAULTS("D9").[Next]())
                box.SelectionStart -= 4
            Case Key.D0
                box.SelectedText = (_DEFAULTS("D0").[Next]())
                box.SelectionStart -= 4
        End Select
    End Sub
    Private Sub SymbolsButton_Click() Handles symbolsButton2.Click
        Dim box As TextBox = GetTextBox()
        Dim win As New SymbolsWindow(_lstSYMBOLS, box)
        win.Show()
    End Sub
    Private Sub PlayButton_Click() Handles playButton.Click
        Try
            _player = New SoundPlayer(_strSAVEPATH)
            _player.Play()
        Catch
            MessageBox.Show("文件不存在！", "",
        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Return
        End Try
    End Sub
    Private Sub ResaveButton_Click() Handles resaveButton.Click
        SaveAudio()
    End Sub
    Private Sub SavePath_KeyPress(sender As Object, e As KeyEventArgs) Handles savePath.KeyDown
        If e.Key = Input.Key.Enter Then
            _DEFAULTS("_SAVEPATHS").Add(__InlineAssignHelper(_strSAVEPATH, savePath.Text))
            SaveAudio()
        End If
    End Sub
    Private Sub SavePath_KeyDown(sender As Object, e As KeyEventArgs) Handles savePath.KeyDown
        GetHistory(savePath, "_SAVEPATHS", e)
    End Sub
    Private Sub OriginPath_KeyDown(sender As Object, e As KeyEventArgs) Handles originPath.KeyDown
        GetHistory(originPath, "AUDIOPATHS", e)
    End Sub
    Private Sub HOriginPath_KeyDown(sender As Object, e As KeyEventArgs) Handles HOriginPath.KeyDown
        GetHistory(HOriginPath, "AUDIOPATHS", e)
    End Sub
    Private Sub StopButton_Click() Handles stopButton.Click
        _player.[Stop]()
    End Sub
    Private Sub DeleteButton_Click() Handles deleteButton.Click
        playButton.IsEnabled = False
        stopButton.IsEnabled = False
        File.Delete(_strSAVEPATH)
    End Sub
    Private Sub CheckModelW2V2()
        ClearW2V2Mode()
        If _strMODELPATH IsNot Nothing AndAlso _strCONFIGPATH IsNot Nothing AndAlso _strW2V2PATH IsNot Nothing Then
            InitializeSpeakers()
        End If
    End Sub
    Private Sub W2V2Model_Click() Handles W2V2Model.Click
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "模型文件|model.onnx"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS("_W2V2PATHS").Add(__InlineAssignHelper(_strW2V2PATH, __InlineAssignHelper(W2V2Path.Text, ofd.FileName)))
            CheckModelW2V2()
        End If
        ofd.Dispose()
    End Sub
    Private Sub W2V2Path_KeyPress(sender As Object, e As KeyEventArgs) Handles W2V2Path.KeyDown
        If e.Key = Input.Key.Enter Then
            If Not File.Exists(W2V2Path.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else
                _DEFAULTS("_W2V2PATHS").Add(__InlineAssignHelper(_strW2V2PATH, W2V2Path.Text))
                CheckModelW2V2()
            End If
        End If
    End Sub
    Private Sub WModelPath_KeyDown(sender As Object, e As KeyEventArgs) Handles WModelPath.KeyDown
        GetHistory(WModelPath, "W_MODELPATHS", e)
    End Sub
    Private Sub WConfigPath_KeyDown(sender As Object, e As KeyEventArgs) Handles WConfigPath.KeyDown
        GetHistory(WConfigPath, "W_CONFIGPATHS", e)
    End Sub
    Private Sub W2V2Path_KeyDown(sender As Object, e As KeyEventArgs) Handles W2V2Path.KeyDown
        GetHistory(W2V2Path, "_W2V2PATHS", e)
    End Sub
    Private Sub EmotionButton_Click() Handles emotionButton.Click
        Dim ofd As New Forms.OpenFileDialog With
            {
            .Filter = "数据文件|*.npy|音频文件|*.wav;*.mp3;*.ogg;*.opus"
            }
        If ofd.ShowDialog() = Forms.DialogResult.OK Then
            _DEFAULTS("_EMOTIONPATHS").Add(__InlineAssignHelper(_strEMOTIONPATH, __InlineAssignHelper(emotionPath.Text, ofd.FileName)))
        End If
        ofd.Dispose()
    End Sub
    Private Sub EmotionPath_KeyPress(sender As Object, e As KeyEventArgs) Handles emotionPath.KeyDown
        If e.Key = Input.Key.Enter Then
            If Not File.Exists(emotionPath.Text) Then
                MessageBox.Show("文件不存在！", "",
                        Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.[Error])
            Else _DEFAULTS("_EMOTIONPATHS").Add(__InlineAssignHelper(_strEMOTIONPATH, emotionPath.Text))
            End If
        End If
    End Sub
    Private Sub EmotionPath_KeyDown(sender As Object, e As KeyEventArgs) Handles emotionPath.KeyDown
        GetHistory(emotionPath, "_EMOTIONPATHS", e)
    End Sub
    Private Sub SearchSpeakers(sender As Object, e As KeyEventArgs) Handles speakerBox.KeyDown, originBox.KeyDown, targetBox.KeyDown,
        HTargetBox.KeyDown, HOriginBox.KeyDown, HTargetBox2.KeyDown, WSpeakerBox.KeyDown, WOriginBox.KeyDown, WTargetBox.KeyDown

        If e.Key = Input.Key.Enter Then
            SelectSpeakers(TryCast(sender, ComboBox))
        End If
    End Sub
    Private Sub SelectSpeakers(box As ComboBox)
        box.Items.Clear()
        If Not _dicSPEAKERIDDICT.ContainsKey(box) Then
            _dicSPEAKERIDDICT.Add(box, New Dictionary(Of Integer, Integer))
        Else _dicSPEAKERIDDICT(box).Clear()
        End If
        For i As Integer = 0 To _lstSPEAKERS.Count - 1
            If _lstSPEAKERS(i).Contains(box.Text) Then
                box.Items.Add(_lstSPEAKERS(i))
                _dicSPEAKERIDDICT(box).Add(box.Items.Count - 1, i)
            End If
        Next
    End Sub
    <Obsolete("Please refactor code that uses this function, it is a simple work-around to simulate inline assignment in VB!")>
    Private Shared Function __InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class

Public Class ExList(Of T)
    Private _index As Integer
    Private ReadOnly range As Integer
    Private ReadOnly list1 As List(Of T)
    Public Property Index As Integer
        Get
            Return _index
        End Get

        Set(value As Integer)
            Dim limit As Integer = If(range < list1.Count, range, list1.Count)
            If value < 0 Then
                _index = limit - 1
            ElseIf value >= limit Then
                _index = 0
            Else
                _index = value
            End If
        End Set
    End Property

    Public Sub New(range As Integer)
        list1 = New List(Of T)
        Index = -1
        Me.range = range
    End Sub

    Public Sub New(collection As IEnumerable(Of T), range As Integer)
        list1 = New List(Of T)(collection)
        Index = -1
        Me.range = range
    End Sub
    Public Sub Add(item As T)
        list1.Remove(item)
        list1.Insert(0, item)
    End Sub
    Public Function [Next]() As T
        Index += 1
        Return list1(Index)
    End Function
    Public Function Previous() As T
        Index -= 1
        Return list1(Index)
    End Function
    Public Overrides Function ToString() As String
        Dim limit As Integer = If(range < list1.Count, range, list1.Count)
        Return String.Join("|", list1.GetRange(0, limit))
    End Function
End Class

Public Class ExDictionary(Of TKey, TValue)
    Inherits Dictionary(Of TKey, TValue)
    Private ReadOnly generator As Func(Of TValue)

    Public Sub New(generator As Func(Of TValue))
        Me.generator = generator
    End Sub
    Default Public Shadows ReadOnly Property item(key As TKey) As TValue
        Get
            If Not ContainsKey(key) Then
                Add(key, generator())
            End If
            Return MyBase.Item(key)
        End Get
    End Property
End Class