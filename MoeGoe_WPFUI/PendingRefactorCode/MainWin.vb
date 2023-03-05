Imports System.Collections.Generic
Imports System.IO
Imports System.Media
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Namespace MoeGoe_GUI
    Public Partial Class MainWin
        Inherits Form
        Public Sub New()
            InitializeComponent()

            DEFAULTS = New ExDictionary(Of String, ExList(Of String))(Function() As MoeGoe_GUI.ExList(Of String)
                                                                          Return New ExList(Of String)(5)
                                                                      End Function)

            If File.Exists("MoeGoe_GUI.config") Then
                For Each line As String In File.ReadLines("MoeGoe_GUI.config")
                    Dim split1 As String() = line.Split(">"c)
                    DEFAULTS.Add(split1(0), New ExList(Of String)(split1(1).Split("|"c), 5))
                Next
            End If

            If Not DEFAULTS.ContainsKey("D1") Then
                DEFAULTS("D1").Add("[ZH][ZH]")
            End If
            If Not DEFAULTS.ContainsKey("D2") Then
                DEFAULTS("D2").Add("[JA][JA]")
            End If
            If Not DEFAULTS.ContainsKey("D3") Then
                DEFAULTS("D3").Add("[KO][KO]")
            End If
            If Not DEFAULTS.ContainsKey("D4") Then
                DEFAULTS("D4").Add("[SA][SA]")
            End If
            If Not DEFAULTS.ContainsKey("D5") Then
                DEFAULTS("D5").Add("[EN][EN]")
            End If
            If Not DEFAULTS.ContainsKey("D6") Then
                DEFAULTS("D6").Add("[SH][SH]")
            End If
            If Not DEFAULTS.ContainsKey("D7") Then
                DEFAULTS("D7").Add("[GD][GD]")
            End If
            If Not DEFAULTS.ContainsKey("D8") Then
                DEFAULTS("D8").Add("[WZ][WZ]")
            End If
            If Not DEFAULTS.ContainsKey("D9") Then
                DEFAULTS("D9").Add("[SZ][SZ]")
            End If
            If Not DEFAULTS.ContainsKey("D0") Then
                DEFAULTS("D0").Add("[TH][TH]")
            End If

            _LENGTHSCALE = 1
            _NOISESCALE = 0.667D
            _NOISESCALEW = 0.8D
            _F0SCALE = 1

            _SPEAKERS = New List(Of String)
            _SYMBOLS = New List(Of String)
            _SPEAKERIDDICT = New Dictionary(Of ComboBox, Dictionary(Of Integer, Integer))
            _isSeeking = False

            If DEFAULTS.ContainsKey("EXEPATHS") Then
                EXEPATH1 = __InlineAssignHelper(EXEPath.Text, DEFAULTS("EXEPATHS").[Next]())
                modelControl.Enabled = True
            End If
        End Sub
        Private cmd As CommandLine
        Private ReadOnly DEFAULTS As ExDictionary(Of String, ExList(Of String))
        Private EXEPATH1 As String
        Private _MODELPATH As String
        Private _CONFIGPATH As String
        Private _HUBERTPATH As String
        Private _W2V2PATH As String
        Private _SAVEPATH As String
        Private _ORIGINPATH As String
        Private _EMOTIONPATH As String
        Private _LENGTHSCALE As Decimal
        Private _NOISESCALE As Decimal
        Private _NOISESCALEW As Decimal
        Private _F0SCALE As Decimal
        Private ReadOnly _SPEAKERS As List(Of String)
        Private ReadOnly _SYMBOLS As List(Of String)
        Private ReadOnly _SPEAKERIDDICT As Dictionary(Of ComboBox, Dictionary(Of Integer, Integer))
        Private _USEF0 As Boolean
        Private _isSeeking As Boolean
        Private _player As SoundPlayer
        Private Sub ClearAll()
            ClearVITS()
            ClearHubertVITS()
            ClearW2V2VITS()
        End Sub
        Private Sub ClearVITS()
            modelPath.Clear()
            _MODELPATH = Nothing
            configPath.Clear()
            _CONFIGPATH = Nothing
            ClearMode()
        End Sub
        Private Sub ClearMode()
            consoleBox.Clear()
            textBox.Clear()
            speakerBox.Items.Clear()
            speakerBox.Text = ""
            _LENGTHSCALE = 1
            _NOISESCALE = 0.667D
            _NOISESCALEW = 0.8D
            originPath.Clear()
            _ORIGINPATH = Nothing
            originBox.Items.Clear()
            originBox.Text = ""
            targetBox.Items.Clear()
            targetBox.Text = ""
            modeControl.Enabled = False
            ClearSavePanel()
        End Sub
        Private Sub ClearHubertVITS()
            HModelPath.Clear()
            _MODELPATH = Nothing
            HConfigPath.Clear()
            _CONFIGPATH = Nothing
            hubertPath.Clear()
            _HUBERTPATH = Nothing
            ClearHubertMode()
        End Sub
        Private Sub ClearHubertMode()
            consoleBox.Clear()
            HOriginPath.Clear()
            _ORIGINPATH = Nothing
            HOpenOrigin.Enabled = False
            HOriginPath.Enabled = False
            HTargetBox.Items.Clear()
            HTargetBox.Text = ""
            _LENGTHSCALE = 1
            _NOISESCALE = 0.1D
            _NOISESCALEW = 0.1D
            _F0SCALE = 1
            HOriginBox.Items.Clear()
            HOriginBox.Text = ""
            HTargetBox2.Items.Clear()
            HTargetBox2.Text = ""
            HVCControl.Enabled = False
            ClearSavePanel()
        End Sub
        Private Sub ClearW2V2VITS()
            WModelPath.Clear()
            _MODELPATH = Nothing
            WConfigPath.Clear()
            _CONFIGPATH = Nothing
            W2V2Path.Clear()
            _W2V2PATH = Nothing
            ClearW2V2Mode()
        End Sub
        Private Sub ClearW2V2Mode()
            consoleBox.Clear()
            emotionPath.Clear()
            _EMOTIONPATH = Nothing
            WTextBox.Clear()
            WSpeakerBox.Items.Clear()
            WSpeakerBox.Text = ""
            _LENGTHSCALE = 1
            _NOISESCALE = 0.667D
            _NOISESCALEW = 0.8D
            WOriginPath.Clear()
            _ORIGINPATH = Nothing
            WOriginBox.Items.Clear()
            WOriginBox.Text = ""
            WTargetBox.Items.Clear()
            WTargetBox.Text = ""
            WModeControl.Enabled = False
            ClearSavePanel()
        End Sub
        Private Sub ClearSavePanel()
            savePath.Clear()
            _SAVEPATH = Nothing
            savePanel.Enabled = False
            resaveButton.Enabled = False
            _isSeeking = False
            _player = Nothing
            deleteButton.Enabled = False
            playButton.Enabled = False
            stopButton.Enabled = False
        End Sub
        Private Sub OpenEXE_Click(sender As Object, e As EventArgs)
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "|MoeGoe.exe"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                ClearAll()
                DEFAULTS("EXEPATHS").Add(__InlineAssignHelper(EXEPATH1, __InlineAssignHelper(EXEPath.Text, ofd.FileName)))
                modelControl.Enabled = True
            End If
            ofd.Dispose()
        End Sub
        Private Sub EXEPath_KeyPress(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = vbCr Then
                If Not File.Exists(EXEPath.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    ClearAll()
                    DEFAULTS("EXEPATHS").Add(__InlineAssignHelper(EXEPATH1, EXEPath.Text))
                    modelControl.Enabled = True
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
        Private Sub OpenModel_Click(sender As Object, e As EventArgs)
            Dim box As TextBox = Nothing
            Dim key As String = Nothing
            Dim check As Action = Nothing
            GetModelBox(box, key, check)
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "模型文件|*.pth|所有文件|*.*"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                DEFAULTS(key).Add(__InlineAssignHelper(_MODELPATH, __InlineAssignHelper(box.Text, ofd.FileName)))
                check()
            End If
            ofd.Dispose()
        End Sub
        Private Sub ModelPath_KeyPress(sender As Object, e As KeyPressEventArgs)
            Dim box As TextBox = Nothing
            Dim key As String = Nothing
            Dim check As Action = Nothing
            GetModelBox(box, key, check)
            If e.KeyChar = vbCr Then
                If Not File.Exists(box.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    DEFAULTS(key).Add(__InlineAssignHelper(_MODELPATH, box.Text))
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
        Private Sub OpenConfig_Click(sender As Object, e As EventArgs)
            Dim box As TextBox = Nothing
            Dim key As String = Nothing
            Dim check As Action = Nothing
            GetConfigBox(box, key, check)
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "配置文件|*.json"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                DEFAULTS(key).Add(__InlineAssignHelper(_CONFIGPATH, __InlineAssignHelper(box.Text, ofd.FileName)))
                check()
            End If
            ofd.Dispose()
        End Sub
        Private Sub ConfigPath_KeyPress(sender As Object, e As KeyPressEventArgs)
            Dim box As TextBox = Nothing
            Dim key As String = Nothing
            Dim check As Action = Nothing
            GetConfigBox(box, key, check)
            If e.KeyChar = vbCr Then
                If Not File.Exists(box.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    DEFAULTS(key).Add(__InlineAssignHelper(_CONFIGPATH, box.Text))
                    check()
                End If
            End If
        End Sub
        Private Sub CheckModel()
            ClearMode()
            If _MODELPATH IsNot Nothing AndAlso _CONFIGPATH IsNot Nothing Then
                InitializeSpeakers()
            End If
        End Sub
        Private Function LoadJsonList(json As String, key As String, action1 As Action(Of String)) As Boolean
            Dim match1 As Match = Regex.Match(json,
                $"""{key}""\s*:\s*\[((?:\s*""(?:(?:\.)|[^\""])*""\s*,?\s*)*)\]")
            If match1.Success Then
                Dim matches1 As MatchCollection = Regex.Matches(match1.Groups(1).Value,
        """""((?:(?:\.)|[^\""""])*)""""")
                If matches1.Count > 0 Then
                    For i As Integer = 0 To matches1.Count - 1
                        Dim speaker As String = Regex.Unescape(matches1(i).Groups(1).Value)
                        action1(speaker)
                    Next
                End If
                Return True
            End If
            Return False
        End Function
        Private Sub InitializeSpeakers()
            Dim json As String = File.ReadAllText(_CONFIGPATH)
            Dim useF01 As Match = Regex.Match(json, """""use_f0""""\s*:\s*([A-Za-z]+)")
            If useF01.Success Then
                _USEF0 = Boolean.Parse(useF01.Groups(1).Value)
            Else _USEF0 = False
            End If
            Dim match1 As Match = Regex.Match(json,
                """""speakers""""\s*:\s*\[((?:\s*""""(?:(?:\.)|[^\""""])*""""\s*,?\s*)*)\]")
            _SPEAKERS.Clear()
            If Not LoadJsonList(json, "speakers", AddressOf _SPEAKERS.Add) Then
                match1 = Regex.Match(json,
    """""n_speakers""""\s*:\s*(\d+)")
                Dim nspeakers As Integer = 0
                If match1.Success Then
                    nspeakers = Integer.Parse(match1.Groups(1).Value)
                End If
                If nspeakers = 0 Then
                    _SPEAKERS.Add("0")
                Else For i As Integer = 0 To nspeakers - 1
                        _SPEAKERS.Add(i.ToString())
                    Next
                End If
            End If
            AddSpeakers()
            _SYMBOLS.Clear()
            LoadJsonList(json, "symbols", AddressOf _SYMBOLS.Add)
            GetStart()
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
            cmd = New CommandLine
            AddHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
            cmd.Write($"""{EXEPATH1}"" --escape")
            cmd.Write(_MODELPATH)
            cmd.Write(_CONFIGPATH)
            Select Case modelControl.SelectedIndex
                Case 0
                    modeControl.Enabled = True
                Case 1
                    cmd.Write(_HUBERTPATH)
                    HOpenOrigin.Enabled = True
                    HOriginPath.Enabled = True
                    HVCControl.Enabled = True
                Case 2
                    cmd.Write(_W2V2PATH)
                    WModeControl.Enabled = True
            End Select
            savePanel.Enabled = True
        End Sub
        Private Sub Cmd_OutputHandler(sender As CommandLine, e As String)
            Invoke(New Action(Sub()
                                  Try
                                      consoleBox.Text += Regex.Unescape(e)
                                  Catch
                                      consoleBox.Text += e
                                  End Try
                              End Sub))
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
        Private Sub OpenOrigin_Click(sender As Object, e As EventArgs)
            Dim box As TextBox = GetOriginBox()
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "音频文件|*.wav;*.mp3;*.ogg;*.opus"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                DEFAULTS("AUDIOPATHS").Add(__InlineAssignHelper(_ORIGINPATH, __InlineAssignHelper(box.Text, ofd.FileName)))
            End If
            ofd.Dispose()
        End Sub
        Private Sub OriginPath_KeyPress(sender As Object, e As KeyPressEventArgs)
            Dim textBox As TextBox = TryCast(sender, TextBox)
            If e.KeyChar = vbCr Then
                If Not File.Exists(textBox.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else DEFAULTS("AUDIOPATHS").Add(__InlineAssignHelper(_ORIGINPATH, textBox.Text))
                End If
            End If
        End Sub
        Private Function IsFilled() As Boolean
            Select Case modelControl.SelectedIndex
                Case 0
                    Select Case modeControl.SelectedIndex
                        Case 0
                            If textBox.Text.Length = 0 Then
                                MessageBox.Show("请输入文本！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If speakerBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            Return True
                        Case 1
                            If _ORIGINPATH Is Nothing Then
                                MessageBox.Show("请指定原音频！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If originBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择原说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If targetBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择目标说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            Return True
                    End Select
                    Return False
                Case 1
                    If _ORIGINPATH Is Nothing Then
                        MessageBox.Show("请指定原音频！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                    Select Case HVCControl.SelectedIndex
                        Case 0
                            If HTargetBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择目标说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            Return True
                        Case 1
                            If HOriginBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择原说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If HTargetBox2.SelectedIndex = -1 Then
                                MessageBox.Show("请选择目标说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            Return True
                    End Select
                    Return False
                Case 2
                    Select Case WModeControl.SelectedIndex
                        Case 0
                            If _EMOTIONPATH Is Nothing Then
                                MessageBox.Show("请指定情感参考！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                            If WTextBox.Text.Length = 0 Then
                                MessageBox.Show("请输入文本！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If WSpeakerBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            Return True
                        Case 1
                            If _ORIGINPATH Is Nothing Then
                                MessageBox.Show("请指定原音频！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If WOriginBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择原说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            If WTargetBox.SelectedIndex = -1 Then
                                MessageBox.Show("请选择目标说话人！", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return False
                            End If
                            Return True
                    End Select
                    Return False
                Case Else
                    Return False
            End Select
        End Function
        Private Sub SaveButton_Click(sender As Object, e As EventArgs)
            Dim sfd As New SaveFileDialog With
            {
            .Filter = "音频文件|*.wav"
            }
            If sfd.ShowDialog() = DialogResult.OK Then
                DEFAULTS("_SAVEPATHS").Add(__InlineAssignHelper(_SAVEPATH, __InlineAssignHelper(savePath.Text, sfd.FileName)))
                SaveAudio()
            End If
            sfd.Dispose()
        End Sub
        Private Sub SaveAudio()
            If Not IsFilled() Then
                Return
            End If
            Dim directory As String = Path.GetDirectoryName(_SAVEPATH)
            If Not IO.Directory.Exists(directory) Then
                IO.Directory.CreateDirectory(directory)
            End If
            deleteButton.Enabled = False
            playButton.Enabled = False
            stopButton.Enabled = False
            Select Case modelControl.SelectedIndex
                Case 0
                    Select Case modeControl.SelectedIndex
                        Case 0
                            TTS(textBox.Text, GetSelectedID(speakerBox))
                        Case 1
                            VC(GetSelectedID(originBox), GetSelectedID(targetBox))
                    End Select
                    cmd.Write(_SAVEPATH)
                Case 1
                    Select Case HVCControl.SelectedIndex
                        Case 0
                            cmd.Write(_ORIGINPATH)
                            cmd.Write(GetSelectedID(HTargetBox).ToString())
                            If _USEF0 Then
                                cmd.Write($"[LENGTH={_LENGTHSCALE}][NOISE={_NOISESCALE}][NOISEW={_NOISESCALEW}][F0={_F0SCALE}]{_SAVEPATH}")
                            Else cmd.Write($"[LENGTH={_LENGTHSCALE}][NOISE={_NOISESCALE}][NOISEW={_NOISESCALEW}]{_SAVEPATH}")
                            End If
                        Case 1
                            cmd.Write($"[VC]")
                            cmd.Write(_ORIGINPATH)
                            cmd.Write(GetSelectedID(HOriginBox).ToString())
                            cmd.Write(GetSelectedID(HTargetBox2).ToString())
                            cmd.Write(_SAVEPATH)
                    End Select
                Case 2
                    Select Case WModeControl.SelectedIndex
                        Case 0
                            TTS(WTextBox.Text, GetSelectedID(WSpeakerBox))
                            cmd.Write(_EMOTIONPATH)
                        Case 1
                            VC(GetSelectedID(WOriginBox), GetSelectedID(WTargetBox))
                    End Select
                    cmd.Write(_SAVEPATH)
            End Select
            cmd.Write("y")
            resaveButton.Enabled = True
            _isSeeking = True
            Task.Run(Sub()
                         While True
                             If Not _isSeeking Then
                                 Return
                             End If
                             If File.Exists(_SAVEPATH) Then
                                 Invoke(New Action(Sub()
                                                       deleteButton.Enabled = True
                                                       playButton.Enabled = True
                                                       stopButton.Enabled = True
                                                       _isSeeking = False
                                                   End Sub))
                                 Return
                             End If
                             Thread.Sleep(500)
                         End While
                     End Sub)
        End Sub
        Private Function GetSelectedID(box As ComboBox) As Integer
            Return _SPEAKERIDDICT(box)(box.SelectedIndex)
        End Function
        Private Sub TTS(text1 As String, speaker As Integer)
            cmd.Write("t")
            cmd.Write($"[LENGTH={_LENGTHSCALE}][NOISE={_NOISESCALE}][NOISEW={_NOISESCALEW}]{Regex.Replace(text1, "\r?\n", " ")}")
            cmd.Write(speaker.ToString())
        End Sub
        Private Sub VC(origin As Integer, target As Integer)
            cmd.Write("v")
            cmd.Write(_ORIGINPATH)
            cmd.Write(origin.ToString())
            cmd.Write(target.ToString())
        End Sub
        Private Function GetTextBox() As TextBox
            Select Case modelControl.SelectedIndex
                Case 0
                    Return textBox
                Case 2
                    Return WTextBox
                Case Else
                    Return Nothing
            End Select
        End Function
        Private Sub CleanButton_Click(sender As Object, e As EventArgs)
            Dim box As TextBox = GetTextBox()
            Dim win As New CleanWin(box, cmd)
            RemoveHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
            win.ShowDialog()
            AddHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
            win.Dispose()
        End Sub
        Private Function GetParameters() As Decimal()
            Return New Decimal() {_LENGTHSCALE, _NOISESCALE, _NOISESCALEW, _F0SCALE}
        End Function
        Private Sub SetParameters(lengthScale1 As Decimal, noiseScale1 As Decimal, noiseScaleW1 As Decimal)
            _LENGTHSCALE = lengthScale1
            _NOISESCALE = noiseScale1
            _NOISESCALEW = noiseScaleW1
        End Sub
        Private Sub SetParameters(lengthScale1 As Decimal, noiseScale1 As Decimal, noiseScaleW1 As Decimal, f0Scale1 As Decimal)
            _LENGTHSCALE = lengthScale1
            _NOISESCALE = noiseScale1
            _NOISESCALEW = noiseScaleW1
            _F0SCALE = f0Scale1
        End Sub
        Private Sub AdvancedButton_Click(sender As Object, e As EventArgs)
            Dim win As New AdvancedWin(AddressOf GetParameters, AddressOf SetParameters)
            win.ShowDialog()
            win.Dispose()
        End Sub
        Private Sub ModelControl_SelectedIndexChanged(sender As Object, e As EventArgs)
            Select Case modelControl.SelectedIndex
                Case 0
                    ClearVITS()
                Case 1
                    ClearHubertVITS()
                Case 2
                    ClearW2V2VITS()
            End Select
        End Sub
        Private Sub CheckModelHubert()
            ClearHubertMode()
            If _MODELPATH IsNot Nothing AndAlso _CONFIGPATH IsNot Nothing AndAlso _HUBERTPATH IsNot Nothing Then
                InitializeSpeakers()
            End If
        End Sub
        Private Sub HOpenHubert_Click(sender As Object, e As EventArgs)
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "模型文件|*.pt|所有文件|*.*"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                DEFAULTS("_HUBERTPATHS").Add(__InlineAssignHelper(_HUBERTPATH, __InlineAssignHelper(hubertPath.Text, ofd.FileName)))
                CheckModelHubert()
            End If
            ofd.Dispose()
        End Sub
        Private Sub HubertPath_KeyPress(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = vbCr Then
                If Not File.Exists(HConfigPath.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    DEFAULTS("_HUBERTPATHS").Add(__InlineAssignHelper(_HUBERTPATH, hubertPath.Text))
                    CheckModelHubert()
                End If
            End If
        End Sub
        Private Sub HAdvancedControl_Click(sender As Object, e As EventArgs)
            Dim win As New HAdvancedWin(AddressOf GetParameters, AddressOf SetParameters, _USEF0)
            win.ShowDialog()
            win.Dispose()
        End Sub
        Private Sub MainWin_FormClosed(sender As Object, e As FormClosedEventArgs)
            Using sw As New StreamWriter("MoeGoe_GUI.config")
                For Each pair As KeyValuePair(Of String, ExList(Of String)) In DEFAULTS
                    sw.WriteLine(pair.Key & ">" & pair.Value.ToString)
                Next
            End Using
        End Sub
        Private Sub GetHistory(box As TextBox, key As String, e As KeyEventArgs)
            Dim list1 As ExList(Of String) = Nothing
            If Not DEFAULTS.TryGetValue(key, list1) Then
                Return
            End If
            If e.KeyCode = Keys.Up Then
                box.Text = list1.[Next]()
            ElseIf e.KeyCode = Keys.Down Then
                box.Text = list1.Previous()
            End If
        End Sub
        Private Sub EXEPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(EXEPath, "EXEPATHS", e)
        End Sub
        Private Sub ModelPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(modelPath, "_MODELPATHS", e)
        End Sub
        Private Sub ConfigPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(configPath, "_CONFIGPATHS", e)
        End Sub
        Private Sub HModelPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(HModelPath, "H_MODELPATHS", e)
        End Sub
        Private Sub HConfigPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(HConfigPath, "H_CONFIGPATHS", e)
        End Sub
        Private Sub HubertPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(hubertPath, "_HUBERTPATHS", e)
        End Sub
        Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
            Dim box As TextBox = TryCast(sender, TextBox)
            If Not e.Control Then
                Return
            End If
            Select Case e.KeyCode
                Case Keys.D1
                    box.Paste(DEFAULTS("D1").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D2
                    box.Paste(DEFAULTS("D2").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D3
                    box.Paste(DEFAULTS("D3").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D4
                    box.Paste(DEFAULTS("D4").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D5
                    box.Paste(DEFAULTS("D5").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D6
                    box.Paste(DEFAULTS("D6").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D7
                    box.Paste(DEFAULTS("D7").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D8
                    box.Paste(DEFAULTS("D8").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D9
                    box.Paste(DEFAULTS("D9").[Next]())
                    box.SelectionStart -= 4
                Case Keys.D0
                    box.Paste(DEFAULTS("D0").[Next]())
                    box.SelectionStart -= 4
            End Select
        End Sub
        Private Sub SymbolsButton_Click(sender As Object, e As EventArgs)
            Dim box As TextBox = GetTextBox()
            Dim win As New SymbolsWin(_SYMBOLS, box)
            win.Show()
        End Sub
        Private Sub PlayButton_Click(sender As Object, e As EventArgs)
            Try
                _player = New SoundPlayer(_SAVEPATH)
                _player.Play()
            Catch
                MessageBox.Show("文件不存在！", "",
        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End Try
        End Sub
        Private Sub ResaveButton_Click(sender As Object, e As EventArgs)
            SaveAudio()
        End Sub
        Private Sub SavePath_KeyPress(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = vbCr Then
                DEFAULTS("_SAVEPATHS").Add(__InlineAssignHelper(_SAVEPATH, savePath.Text))
                SaveAudio()
            End If
        End Sub
        Private Sub SavePath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(savePath, "_SAVEPATHS", e)
        End Sub
        Private Sub OriginPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(originPath, "AUDIOPATHS", e)
        End Sub
        Private Sub HOriginPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(HOriginPath, "AUDIOPATHS", e)
        End Sub
        Private Sub StopButton_Click(sender As Object, e As EventArgs)
            _player.[Stop]()
        End Sub
        Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
            playButton.Enabled = False
            stopButton.Enabled = False
            File.Delete(_SAVEPATH)
        End Sub
        Private Sub CheckModelW2V2()
            ClearW2V2Mode()
            If _MODELPATH IsNot Nothing AndAlso _CONFIGPATH IsNot Nothing AndAlso _W2V2PATH IsNot Nothing Then
                InitializeSpeakers()
            End If
        End Sub
        Private Sub W2V2Model_Click(sender As Object, e As EventArgs)
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "模型文件|model.onnx"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                DEFAULTS("_W2V2PATHS").Add(__InlineAssignHelper(_W2V2PATH, __InlineAssignHelper(W2V2Path.Text, ofd.FileName)))
                CheckModelW2V2()
            End If
            ofd.Dispose()
        End Sub
        Private Sub W2V2Path_KeyPress(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = vbCr Then
                If Not File.Exists(W2V2Path.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    DEFAULTS("_W2V2PATHS").Add(__InlineAssignHelper(_W2V2PATH, W2V2Path.Text))
                    CheckModelW2V2()
                End If
            End If
        End Sub
        Private Sub WModelPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(WModelPath, "W_MODELPATHS", e)
        End Sub
        Private Sub WConfigPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(WConfigPath, "W_CONFIGPATHS", e)
        End Sub
        Private Sub W2V2Path_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(W2V2Path, "_W2V2PATHS", e)
        End Sub
        Private Sub EmotionButton_Click(sender As Object, e As EventArgs)
            Dim ofd As New OpenFileDialog With
            {
            .Filter = "数据文件|*.npy|音频文件|*.wav;*.mp3;*.ogg;*.opus"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                DEFAULTS("_EMOTIONPATHS").Add(__InlineAssignHelper(_EMOTIONPATH, __InlineAssignHelper(emotionPath.Text, ofd.FileName)))
            End If
            ofd.Dispose()
        End Sub
        Private Sub EmotionPath_KeyPress(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = vbCr Then
                If Not File.Exists(emotionPath.Text) Then
                    MessageBox.Show("文件不存在！", "",
                        MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else DEFAULTS("_EMOTIONPATHS").Add(__InlineAssignHelper(_EMOTIONPATH, emotionPath.Text))
                End If
            End If
        End Sub
        Private Sub EmotionPath_KeyDown(sender As Object, e As KeyEventArgs)
            GetHistory(emotionPath, "_EMOTIONPATHS", e)
        End Sub
        Private Sub SearchSpeakers(sender As Object, e As KeyPressEventArgs)
            If e.KeyChar = vbCr Then
                SelectSpeakers(TryCast(sender, ComboBox))
            End If
        End Sub
        Private Sub SelectSpeakers(box As ComboBox)
            box.Items.Clear()
            If Not _SPEAKERIDDICT.ContainsKey(box) Then
                _SPEAKERIDDICT.Add(box, New Dictionary(Of Integer, Integer))
            Else _SPEAKERIDDICT(box).Clear()
            End If
            For i As Integer = 0 To _SPEAKERS.Count - 1
                If _SPEAKERS(i).Contains(box.Text) Then
                    box.Items.Add(_SPEAKERS(i))
                    _SPEAKERIDDICT(box).Add(box.Items.Count - 1, i)
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
            index = -1
            Me.range = range
            list1 = New List(Of T)
        End Sub

        Public Sub New(collection As IEnumerable(Of T), range As Integer)
            index = -1
            Me.range = range
            list1 = New List(Of T)(collection)
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
                Return MyBase.item(key)
            End Get
        End Property
    End Class
End Namespace
