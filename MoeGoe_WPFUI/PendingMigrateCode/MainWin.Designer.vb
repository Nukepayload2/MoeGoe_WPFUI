Namespace MoeGoe_GUI
    Partial Class MainWin
        ''' <summary>
        ''' 必需的设计器变量。
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing
        ''' <summary>
        ''' 清理所有正在使用的资源。
        ''' </summary>
        ''' <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
#Region "Windows 窗体设计器生成的代码"

        ''' <summary>
        ''' 设计器支持所需的方法 - 不要修改
        ''' 使用代码编辑器修改此方法的内容。
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainWin))
            Me.EXEPanel = New System.Windows.Forms.GroupBox
            Me.EXEPath = New System.Windows.Forms.TextBox
            Me.openEXE = New System.Windows.Forms.Button
            Me.modelPanel = New System.Windows.Forms.GroupBox
            Me.configPath = New System.Windows.Forms.TextBox
            Me.openConfig = New System.Windows.Forms.Button
            Me.modelPath = New System.Windows.Forms.TextBox
            Me.openModel = New System.Windows.Forms.Button
            Me.modeControl = New System.Windows.Forms.TabControl
            Me.TTSPage = New System.Windows.Forms.TabPage
            Me.cleanButton2 = New System.Windows.Forms.Button
            Me.symbolsButton2 = New System.Windows.Forms.Button
            Me.paramsButton2 = New System.Windows.Forms.Button
            Me.speakerBox = New System.Windows.Forms.ComboBox
            Me.speakerLabel = New System.Windows.Forms.Label
            Me.textLabel = New System.Windows.Forms.Label
            Me.textBox = New System.Windows.Forms.TextBox
            Me.menuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.cleanButton = New System.Windows.Forms.ToolStripMenuItem
            Me.paramsButton = New System.Windows.Forms.ToolStripMenuItem
            Me.symbolsButton = New System.Windows.Forms.ToolStripMenuItem
            Me.VCPage = New System.Windows.Forms.TabPage
            Me.openOrigin = New System.Windows.Forms.Button
            Me.originPath = New System.Windows.Forms.TextBox
            Me.originBox = New System.Windows.Forms.ComboBox
            Me.originLabel = New System.Windows.Forms.Label
            Me.targetBox = New System.Windows.Forms.ComboBox
            Me.targetLabel = New System.Windows.Forms.Label
            Me.savePanel = New System.Windows.Forms.GroupBox
            Me.deleteButton = New System.Windows.Forms.Button
            Me.stopButton = New System.Windows.Forms.Button
            Me.resaveButton = New System.Windows.Forms.Button
            Me.playButton = New System.Windows.Forms.Button
            Me.savePath = New System.Windows.Forms.TextBox
            Me.saveButton = New System.Windows.Forms.Button
            Me.consoleBox = New System.Windows.Forms.TextBox
            Me.modelControl = New System.Windows.Forms.TabControl
            Me.vitsPage = New System.Windows.Forms.TabPage
            Me.hubertPage = New System.Windows.Forms.TabPage
            Me.HOpenOrigin = New System.Windows.Forms.Button
            Me.HVCControl = New System.Windows.Forms.TabControl
            Me.HVCPage1 = New System.Windows.Forms.TabPage
            Me.HAdvancedControl = New System.Windows.Forms.Button
            Me.HTargetLabel = New System.Windows.Forms.Label
            Me.HTargetBox = New System.Windows.Forms.ComboBox
            Me.HVCPage2 = New System.Windows.Forms.TabPage
            Me.HOriginLabel = New System.Windows.Forms.Label
            Me.HOriginBox = New System.Windows.Forms.ComboBox
            Me.HOriginLabel2 = New System.Windows.Forms.Label
            Me.HTargetBox2 = New System.Windows.Forms.ComboBox
            Me.HModelPanel = New System.Windows.Forms.GroupBox
            Me.hubertPath = New System.Windows.Forms.TextBox
            Me.HOpenHubert = New System.Windows.Forms.Button
            Me.HConfigPath = New System.Windows.Forms.TextBox
            Me.HOpenConfig = New System.Windows.Forms.Button
            Me.HModelPath = New System.Windows.Forms.TextBox
            Me.HOpenModel = New System.Windows.Forms.Button
            Me.HOriginPath = New System.Windows.Forms.TextBox
            Me.w2v2Page = New System.Windows.Forms.TabPage
            Me.WModeControl = New System.Windows.Forms.TabControl
            Me.tabPage1 = New System.Windows.Forms.TabPage
            Me.emotionButton = New System.Windows.Forms.Button
            Me.emotionPath = New System.Windows.Forms.TextBox
            Me.WSpeakerBox = New System.Windows.Forms.ComboBox
            Me.WSpeakerLabel = New System.Windows.Forms.Label
            Me.WTextLabel = New System.Windows.Forms.Label
            Me.WTextBox = New System.Windows.Forms.TextBox
            Me.tabPage2 = New System.Windows.Forms.TabPage
            Me.WOpenOrigin = New System.Windows.Forms.Button
            Me.WOriginPath = New System.Windows.Forms.TextBox
            Me.WOriginBox = New System.Windows.Forms.ComboBox
            Me.WOriginLabel = New System.Windows.Forms.Label
            Me.WTargetBox = New System.Windows.Forms.ComboBox
            Me.WTargetLabel = New System.Windows.Forms.Label
            Me.WModelPanel = New System.Windows.Forms.GroupBox
            Me.W2V2Path = New System.Windows.Forms.TextBox
            Me.W2V2Model = New System.Windows.Forms.Button
            Me.WConfigPath = New System.Windows.Forms.TextBox
            Me.WOpenConfig = New System.Windows.Forms.Button
            Me.WModelPath = New System.Windows.Forms.TextBox
            Me.WOpenModel = New System.Windows.Forms.Button
            Me.EXEPanel.SuspendLayout()
            Me.modelPanel.SuspendLayout()
            Me.modeControl.SuspendLayout()
            Me.TTSPage.SuspendLayout()
            Me.menuStrip.SuspendLayout()
            Me.VCPage.SuspendLayout()
            Me.savePanel.SuspendLayout()
            Me.modelControl.SuspendLayout()
            Me.vitsPage.SuspendLayout()
            Me.hubertPage.SuspendLayout()
            Me.HVCControl.SuspendLayout()
            Me.HVCPage1.SuspendLayout()
            Me.HVCPage2.SuspendLayout()
            Me.HModelPanel.SuspendLayout()
            Me.w2v2Page.SuspendLayout()
            Me.WModeControl.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.WModelPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' EXEPanel
            ' 
            Me.EXEPanel.Controls.Add(Me.EXEPath)
            Me.EXEPanel.Controls.Add(Me.openEXE)
            Me.EXEPanel.Location = New System.Drawing.Point(12, 12)
            Me.EXEPanel.Name = "EXEPanel"
            Me.EXEPanel.Size = New System.Drawing.Size(501, 85)
            Me.EXEPanel.TabIndex = 0
            Me.EXEPanel.TabStop = False
            Me.EXEPanel.Text = "MoeGoe.exe"
            ' 
            ' EXEPath
            ' 
            Me.EXEPath.Location = New System.Drawing.Point(132, 32)
            Me.EXEPath.Name = "EXEPath"
            Me.EXEPath.Size = New System.Drawing.Size(363, 31)
            Me.EXEPath.TabIndex = 1
            AddHandler Me.EXEPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.EXEPath_KeyDown)
            AddHandler Me.EXEPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.EXEPath_KeyPress)
            ' 
            ' openEXE
            ' 
            Me.openEXE.Location = New System.Drawing.Point(6, 30)
            Me.openEXE.Name = "openEXE"
            Me.openEXE.Size = New System.Drawing.Size(120, 35)
            Me.openEXE.TabIndex = 0
            Me.openEXE.Text = "打开文件"
            Me.openEXE.UseVisualStyleBackColor = True
            AddHandler Me.openEXE.Click, New System.EventHandler(AddressOf Me.OpenEXE_Click)
            ' 
            ' modelPanel
            ' 
            Me.modelPanel.Controls.Add(Me.configPath)
            Me.modelPanel.Controls.Add(Me.openConfig)
            Me.modelPanel.Controls.Add(Me.modelPath)
            Me.modelPanel.Controls.Add(Me.openModel)
            Me.modelPanel.Location = New System.Drawing.Point(6, 6)
            Me.modelPanel.Name = "modelPanel"
            Me.modelPanel.Size = New System.Drawing.Size(485, 125)
            Me.modelPanel.TabIndex = 1
            Me.modelPanel.TabStop = False
            Me.modelPanel.Text = "模型文件"
            ' 
            ' configPath
            ' 
            Me.configPath.Location = New System.Drawing.Point(132, 73)
            Me.configPath.Name = "configPath"
            Me.configPath.Size = New System.Drawing.Size(347, 31)
            Me.configPath.TabIndex = 3
            AddHandler Me.configPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.ConfigPath_KeyDown)
            AddHandler Me.configPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.ConfigPath_KeyPress)
            ' 
            ' openConfig
            ' 
            Me.openConfig.Location = New System.Drawing.Point(6, 71)
            Me.openConfig.Name = "openConfig"
            Me.openConfig.Size = New System.Drawing.Size(120, 35)
            Me.openConfig.TabIndex = 2
            Me.openConfig.Text = "打开配置"
            Me.openConfig.UseVisualStyleBackColor = True
            AddHandler Me.openConfig.Click, New System.EventHandler(AddressOf Me.OpenConfig_Click)
            ' 
            ' modelPath
            ' 
            Me.modelPath.Location = New System.Drawing.Point(132, 32)
            Me.modelPath.Name = "modelPath"
            Me.modelPath.Size = New System.Drawing.Size(347, 31)
            Me.modelPath.TabIndex = 1
            AddHandler Me.modelPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.ModelPath_KeyDown)
            AddHandler Me.modelPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.ModelPath_KeyPress)
            ' 
            ' openModel
            ' 
            Me.openModel.Location = New System.Drawing.Point(6, 30)
            Me.openModel.Name = "openModel"
            Me.openModel.Size = New System.Drawing.Size(120, 35)
            Me.openModel.TabIndex = 0
            Me.openModel.Text = "打开模型"
            Me.openModel.UseVisualStyleBackColor = True
            AddHandler Me.openModel.Click, New System.EventHandler(AddressOf Me.OpenModel_Click)
            ' 
            ' modeControl
            ' 
            Me.modeControl.Controls.Add(Me.TTSPage)
            Me.modeControl.Controls.Add(Me.VCPage)
            Me.modeControl.Enabled = False
            Me.modeControl.Location = New System.Drawing.Point(6, 137)
            Me.modeControl.Name = "modeControl"
            Me.modeControl.SelectedIndex = 0
            Me.modeControl.Size = New System.Drawing.Size(487, 267)
            Me.modeControl.TabIndex = 2
            ' 
            ' TTSPage
            ' 
            Me.TTSPage.Controls.Add(Me.cleanButton2)
            Me.TTSPage.Controls.Add(Me.symbolsButton2)
            Me.TTSPage.Controls.Add(Me.paramsButton2)
            Me.TTSPage.Controls.Add(Me.speakerBox)
            Me.TTSPage.Controls.Add(Me.speakerLabel)
            Me.TTSPage.Controls.Add(Me.textLabel)
            Me.TTSPage.Controls.Add(Me.textBox)
            Me.TTSPage.Location = New System.Drawing.Point(4, 33)
            Me.TTSPage.Name = "TTSPage"
            Me.TTSPage.Padding = New System.Windows.Forms.Padding(3)
            Me.TTSPage.Size = New System.Drawing.Size(479, 230)
            Me.TTSPage.TabIndex = 0
            Me.TTSPage.Text = "语音合成"
            Me.TTSPage.UseVisualStyleBackColor = True
            ' 
            ' cleanButton2
            ' 
            Me.cleanButton2.Location = New System.Drawing.Point(118, 138)
            Me.cleanButton2.Name = "cleanButton2"
            Me.cleanButton2.Size = New System.Drawing.Size(111, 35)
            Me.cleanButton2.TabIndex = 10
            Me.cleanButton2.Text = "清理文本"
            Me.cleanButton2.UseVisualStyleBackColor = True
            AddHandler Me.cleanButton2.Click, New System.EventHandler(AddressOf Me.CleanButton_Click)
            ' 
            ' symbolsButton2
            ' 
            Me.symbolsButton2.Location = New System.Drawing.Point(351, 138)
            Me.symbolsButton2.Name = "symbolsButton2"
            Me.symbolsButton2.Size = New System.Drawing.Size(111, 35)
            Me.symbolsButton2.TabIndex = 9
            Me.symbolsButton2.Text = "符号输入"
            Me.symbolsButton2.UseVisualStyleBackColor = True
            AddHandler Me.symbolsButton2.Click, New System.EventHandler(AddressOf Me.SymbolsButton_Click)
            ' 
            ' paramsButton2
            ' 
            Me.paramsButton2.Location = New System.Drawing.Point(234, 138)
            Me.paramsButton2.Name = "paramsButton2"
            Me.paramsButton2.Size = New System.Drawing.Size(111, 35)
            Me.paramsButton2.TabIndex = 8
            Me.paramsButton2.Text = "参数设置"
            Me.paramsButton2.UseVisualStyleBackColor = True
            AddHandler Me.paramsButton2.Click, New System.EventHandler(AddressOf Me.AdvancedButton_Click)
            ' 
            ' speakerBox
            ' 
            Me.speakerBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.speakerBox.FormattingEnabled = True
            Me.speakerBox.Location = New System.Drawing.Point(118, 179)
            Me.speakerBox.Name = "speakerBox"
            Me.speakerBox.Size = New System.Drawing.Size(344, 33)
            Me.speakerBox.TabIndex = 3
            AddHandler Me.speakerBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' speakerLabel
            ' 
            Me.speakerLabel.AutoSize = True
            Me.speakerLabel.Location = New System.Drawing.Point(28, 183)
            Me.speakerLabel.Name = "speakerLabel"
            Me.speakerLabel.Size = New System.Drawing.Size(64, 24)
            Me.speakerLabel.TabIndex = 2
            Me.speakerLabel.Text = "说话人"
            ' 
            ' textLabel
            ' 
            Me.textLabel.AutoSize = True
            Me.textLabel.Location = New System.Drawing.Point(37, 63)
            Me.textLabel.Name = "textLabel"
            Me.textLabel.Size = New System.Drawing.Size(46, 24)
            Me.textLabel.TabIndex = 0
            Me.textLabel.Text = "文本"
            ' 
            ' textBox
            ' 
            Me.textBox.ContextMenuStrip = Me.menuStrip
            Me.textBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.textBox.Location = New System.Drawing.Point(118, 18)
            Me.textBox.Multiline = True
            Me.textBox.Name = "textBox"
            Me.textBox.Size = New System.Drawing.Size(344, 114)
            Me.textBox.TabIndex = 1
            AddHandler Me.textBox.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextBox_KeyDown)
            ' 
            ' menuStrip
            ' 
            Me.menuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { _
            Me.cleanButton,
            Me.paramsButton,
            Me.symbolsButton})
            Me.menuStrip.Name = "menuStrip"
            Me.menuStrip.Size = New System.Drawing.Size(153, 94)
            ' 
            ' cleanButton
            ' 
            Me.cleanButton.Name = "cleanButton"
            Me.cleanButton.Size = New System.Drawing.Size(152, 30)
            Me.cleanButton.Text = "清理文本"
            AddHandler Me.cleanButton.Click, New System.EventHandler(AddressOf Me.CleanButton_Click)
            ' 
            ' paramsButton
            ' 
            Me.paramsButton.Name = "paramsButton"
            Me.paramsButton.Size = New System.Drawing.Size(152, 30)
            Me.paramsButton.Text = "参数设置"
            AddHandler Me.paramsButton.Click, New System.EventHandler(AddressOf Me.AdvancedButton_Click)
            ' 
            ' symbolsButton
            ' 
            Me.symbolsButton.Name = "symbolsButton"
            Me.symbolsButton.Size = New System.Drawing.Size(152, 30)
            Me.symbolsButton.Text = "符号输入"
            AddHandler Me.symbolsButton.Click, New System.EventHandler(AddressOf Me.SymbolsButton_Click)
            ' 
            ' VCPage
            ' 
            Me.VCPage.Controls.Add(Me.openOrigin)
            Me.VCPage.Controls.Add(Me.originPath)
            Me.VCPage.Controls.Add(Me.originBox)
            Me.VCPage.Controls.Add(Me.originLabel)
            Me.VCPage.Controls.Add(Me.targetBox)
            Me.VCPage.Controls.Add(Me.targetLabel)
            Me.VCPage.Location = New System.Drawing.Point(4, 33)
            Me.VCPage.Name = "VCPage"
            Me.VCPage.Padding = New System.Windows.Forms.Padding(3)
            Me.VCPage.Size = New System.Drawing.Size(479, 230)
            Me.VCPage.TabIndex = 1
            Me.VCPage.Text = "语音转换"
            Me.VCPage.UseVisualStyleBackColor = True
            ' 
            ' openOrigin
            ' 
            Me.openOrigin.Location = New System.Drawing.Point(12, 39)
            Me.openOrigin.Name = "openOrigin"
            Me.openOrigin.Size = New System.Drawing.Size(108, 35)
            Me.openOrigin.TabIndex = 4
            Me.openOrigin.Text = "打开原音频"
            Me.openOrigin.UseVisualStyleBackColor = True
            AddHandler Me.openOrigin.Click, New System.EventHandler(AddressOf Me.OpenOrigin_Click)
            ' 
            ' originPath
            ' 
            Me.originPath.Location = New System.Drawing.Point(128, 41)
            Me.originPath.Name = "originPath"
            Me.originPath.Size = New System.Drawing.Size(344, 31)
            Me.originPath.TabIndex = 12
            AddHandler Me.originPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.OriginPath_KeyDown)
            AddHandler Me.originPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.OriginPath_KeyPress)
            ' 
            ' originBox
            ' 
            Me.originBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.originBox.FormattingEnabled = True
            Me.originBox.Location = New System.Drawing.Point(128, 106)
            Me.originBox.Name = "originBox"
            Me.originBox.Size = New System.Drawing.Size(344, 33)
            Me.originBox.TabIndex = 10
            AddHandler Me.originBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' originLabel
            ' 
            Me.originLabel.AutoSize = True
            Me.originLabel.Location = New System.Drawing.Point(25, 110)
            Me.originLabel.Name = "originLabel"
            Me.originLabel.Size = New System.Drawing.Size(82, 24)
            Me.originLabel.TabIndex = 9
            Me.originLabel.Text = "原说话人"
            ' 
            ' targetBox
            ' 
            Me.targetBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.targetBox.FormattingEnabled = True
            Me.targetBox.Location = New System.Drawing.Point(128, 156)
            Me.targetBox.Name = "targetBox"
            Me.targetBox.Size = New System.Drawing.Size(344, 33)
            Me.targetBox.TabIndex = 8
            AddHandler Me.targetBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' targetLabel
            ' 
            Me.targetLabel.AutoSize = True
            Me.targetLabel.Location = New System.Drawing.Point(16, 160)
            Me.targetLabel.Name = "targetLabel"
            Me.targetLabel.Size = New System.Drawing.Size(100, 24)
            Me.targetLabel.TabIndex = 7
            Me.targetLabel.Text = "目标说话人"
            ' 
            ' savePanel
            ' 
            Me.savePanel.Controls.Add(Me.deleteButton)
            Me.savePanel.Controls.Add(Me.stopButton)
            Me.savePanel.Controls.Add(Me.resaveButton)
            Me.savePanel.Controls.Add(Me.playButton)
            Me.savePanel.Controls.Add(Me.savePath)
            Me.savePanel.Controls.Add(Me.saveButton)
            Me.savePanel.Enabled = False
            Me.savePanel.Location = New System.Drawing.Point(12, 556)
            Me.savePanel.Name = "savePanel"
            Me.savePanel.Size = New System.Drawing.Size(501, 125)
            Me.savePanel.TabIndex = 3
            Me.savePanel.TabStop = False
            Me.savePanel.Text = "保存文件"
            ' 
            ' deleteButton
            ' 
            Me.deleteButton.Enabled = False
            Me.deleteButton.Location = New System.Drawing.Point(132, 71)
            Me.deleteButton.Name = "deleteButton"
            Me.deleteButton.Size = New System.Drawing.Size(115, 35)
            Me.deleteButton.TabIndex = 7
            Me.deleteButton.Text = "删除"
            Me.deleteButton.UseVisualStyleBackColor = True
            AddHandler Me.deleteButton.Click, New System.EventHandler(AddressOf Me.DeleteButton_Click)
            ' 
            ' stopButton
            ' 
            Me.stopButton.Enabled = False
            Me.stopButton.Location = New System.Drawing.Point(380, 71)
            Me.stopButton.Name = "stopButton"
            Me.stopButton.Size = New System.Drawing.Size(115, 35)
            Me.stopButton.TabIndex = 6
            Me.stopButton.Text = "停止"
            Me.stopButton.UseVisualStyleBackColor = True
            AddHandler Me.stopButton.Click, New System.EventHandler(AddressOf Me.StopButton_Click)
            ' 
            ' resaveButton
            ' 
            Me.resaveButton.Enabled = False
            Me.resaveButton.Location = New System.Drawing.Point(6, 71)
            Me.resaveButton.Name = "resaveButton"
            Me.resaveButton.Size = New System.Drawing.Size(120, 35)
            Me.resaveButton.TabIndex = 2
            Me.resaveButton.Text = "重新合成"
            Me.resaveButton.UseVisualStyleBackColor = True
            AddHandler Me.resaveButton.Click, New System.EventHandler(AddressOf Me.ResaveButton_Click)
            ' 
            ' playButton
            ' 
            Me.playButton.Enabled = False
            Me.playButton.Location = New System.Drawing.Point(256, 71)
            Me.playButton.Name = "playButton"
            Me.playButton.Size = New System.Drawing.Size(115, 35)
            Me.playButton.TabIndex = 4
            Me.playButton.Text = "播放"
            Me.playButton.UseVisualStyleBackColor = True
            AddHandler Me.playButton.Click, New System.EventHandler(AddressOf Me.PlayButton_Click)
            ' 
            ' savePath
            ' 
            Me.savePath.Location = New System.Drawing.Point(132, 32)
            Me.savePath.Name = "savePath"
            Me.savePath.Size = New System.Drawing.Size(363, 31)
            Me.savePath.TabIndex = 1
            AddHandler Me.savePath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.SavePath_KeyDown)
            AddHandler Me.savePath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SavePath_KeyPress)
            ' 
            ' saveButton
            ' 
            Me.saveButton.Location = New System.Drawing.Point(6, 30)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(120, 35)
            Me.saveButton.TabIndex = 0
            Me.saveButton.Text = "保存"
            Me.saveButton.UseVisualStyleBackColor = True
            AddHandler Me.saveButton.Click, New System.EventHandler(AddressOf Me.SaveButton_Click)
            ' 
            ' consoleBox
            ' 
            Me.consoleBox.Font = New System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.consoleBox.Location = New System.Drawing.Point(528, 24)
            Me.consoleBox.Multiline = True
            Me.consoleBox.Name = "consoleBox"
            Me.consoleBox.[ReadOnly] = True
            Me.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.consoleBox.Size = New System.Drawing.Size(436, 657)
            Me.consoleBox.TabIndex = 4
            ' 
            ' modelControl
            ' 
            Me.modelControl.Controls.Add(Me.vitsPage)
            Me.modelControl.Controls.Add(Me.hubertPage)
            Me.modelControl.Controls.Add(Me.w2v2Page)
            Me.modelControl.Enabled = False
            Me.modelControl.Location = New System.Drawing.Point(12, 103)
            Me.modelControl.Name = "modelControl"
            Me.modelControl.SelectedIndex = 0
            Me.modelControl.Size = New System.Drawing.Size(505, 447)
            Me.modelControl.TabIndex = 5
            AddHandler Me.modelControl.SelectedIndexChanged, New System.EventHandler(AddressOf Me.ModelControl_SelectedIndexChanged)
            ' 
            ' vitsPage
            ' 
            Me.vitsPage.Controls.Add(Me.modelPanel)
            Me.vitsPage.Controls.Add(Me.modeControl)
            Me.vitsPage.Location = New System.Drawing.Point(4, 33)
            Me.vitsPage.Name = "vitsPage"
            Me.vitsPage.Padding = New System.Windows.Forms.Padding(3)
            Me.vitsPage.Size = New System.Drawing.Size(497, 410)
            Me.vitsPage.TabIndex = 0
            Me.vitsPage.Text = "VITS"
            Me.vitsPage.UseVisualStyleBackColor = True
            ' 
            ' hubertPage
            ' 
            Me.hubertPage.Controls.Add(Me.HOpenOrigin)
            Me.hubertPage.Controls.Add(Me.HVCControl)
            Me.hubertPage.Controls.Add(Me.HModelPanel)
            Me.hubertPage.Controls.Add(Me.HOriginPath)
            Me.hubertPage.Location = New System.Drawing.Point(4, 33)
            Me.hubertPage.Name = "hubertPage"
            Me.hubertPage.Padding = New System.Windows.Forms.Padding(3)
            Me.hubertPage.Size = New System.Drawing.Size(497, 410)
            Me.hubertPage.TabIndex = 1
            Me.hubertPage.Text = "HuBERT-VITS"
            Me.hubertPage.UseVisualStyleBackColor = True
            ' 
            ' HOpenOrigin
            ' 
            Me.HOpenOrigin.Enabled = False
            Me.HOpenOrigin.Location = New System.Drawing.Point(10, 189)
            Me.HOpenOrigin.Name = "HOpenOrigin"
            Me.HOpenOrigin.Size = New System.Drawing.Size(122, 35)
            Me.HOpenOrigin.TabIndex = 13
            Me.HOpenOrigin.Text = "打开原音频"
            Me.HOpenOrigin.UseVisualStyleBackColor = True
            AddHandler Me.HOpenOrigin.Click, New System.EventHandler(AddressOf Me.OpenOrigin_Click)
            ' 
            ' HVCControl
            ' 
            Me.HVCControl.Controls.Add(Me.HVCPage1)
            Me.HVCControl.Controls.Add(Me.HVCPage2)
            Me.HVCControl.Location = New System.Drawing.Point(6, 241)
            Me.HVCControl.Name = "HVCControl"
            Me.HVCControl.SelectedIndex = 0
            Me.HVCControl.Size = New System.Drawing.Size(485, 163)
            Me.HVCControl.TabIndex = 18
            ' 
            ' HVCPage1
            ' 
            Me.HVCPage1.Controls.Add(Me.HAdvancedControl)
            Me.HVCPage1.Controls.Add(Me.HTargetLabel)
            Me.HVCPage1.Controls.Add(Me.HTargetBox)
            Me.HVCPage1.Location = New System.Drawing.Point(4, 33)
            Me.HVCPage1.Name = "HVCPage1"
            Me.HVCPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.HVCPage1.Size = New System.Drawing.Size(477, 126)
            Me.HVCPage1.TabIndex = 0
            Me.HVCPage1.Text = "语言转换（模式一）"
            Me.HVCPage1.UseVisualStyleBackColor = True
            ' 
            ' HAdvancedControl
            ' 
            Me.HAdvancedControl.Location = New System.Drawing.Point(362, 47)
            Me.HAdvancedControl.Name = "HAdvancedControl"
            Me.HAdvancedControl.Size = New System.Drawing.Size(109, 35)
            Me.HAdvancedControl.TabIndex = 17
            Me.HAdvancedControl.Text = "高级设置"
            Me.HAdvancedControl.UseVisualStyleBackColor = True
            AddHandler Me.HAdvancedControl.Click, New System.EventHandler(AddressOf Me.HAdvancedControl_Click)
            ' 
            ' HTargetLabel
            ' 
            Me.HTargetLabel.AutoSize = True
            Me.HTargetLabel.Location = New System.Drawing.Point(14, 52)
            Me.HTargetLabel.Name = "HTargetLabel"
            Me.HTargetLabel.Size = New System.Drawing.Size(100, 24)
            Me.HTargetLabel.TabIndex = 14
            Me.HTargetLabel.Text = "目标说话人"
            ' 
            ' HTargetBox
            ' 
            Me.HTargetBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.HTargetBox.FormattingEnabled = True
            Me.HTargetBox.Location = New System.Drawing.Point(128, 48)
            Me.HTargetBox.Name = "HTargetBox"
            Me.HTargetBox.Size = New System.Drawing.Size(228, 33)
            Me.HTargetBox.TabIndex = 15
            AddHandler Me.HTargetBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' HVCPage2
            ' 
            Me.HVCPage2.Controls.Add(Me.HOriginLabel)
            Me.HVCPage2.Controls.Add(Me.HOriginBox)
            Me.HVCPage2.Controls.Add(Me.HOriginLabel2)
            Me.HVCPage2.Controls.Add(Me.HTargetBox2)
            Me.HVCPage2.Location = New System.Drawing.Point(4, 33)
            Me.HVCPage2.Name = "HVCPage2"
            Me.HVCPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.HVCPage2.Size = New System.Drawing.Size(477, 126)
            Me.HVCPage2.TabIndex = 1
            Me.HVCPage2.Text = "语音转换（模式二）"
            Me.HVCPage2.UseVisualStyleBackColor = True
            ' 
            ' HOriginLabel
            ' 
            Me.HOriginLabel.AutoSize = True
            Me.HOriginLabel.Location = New System.Drawing.Point(23, 32)
            Me.HOriginLabel.Name = "HOriginLabel"
            Me.HOriginLabel.Size = New System.Drawing.Size(82, 24)
            Me.HOriginLabel.TabIndex = 21
            Me.HOriginLabel.Text = "原说话人"
            ' 
            ' HOriginBox
            ' 
            Me.HOriginBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.HOriginBox.FormattingEnabled = True
            Me.HOriginBox.Location = New System.Drawing.Point(128, 28)
            Me.HOriginBox.Name = "HOriginBox"
            Me.HOriginBox.Size = New System.Drawing.Size(343, 33)
            Me.HOriginBox.TabIndex = 22
            AddHandler Me.HOriginBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' HOriginLabel2
            ' 
            Me.HOriginLabel2.AutoSize = True
            Me.HOriginLabel2.Location = New System.Drawing.Point(14, 71)
            Me.HOriginLabel2.Name = "HOriginLabel2"
            Me.HOriginLabel2.Size = New System.Drawing.Size(100, 24)
            Me.HOriginLabel2.TabIndex = 18
            Me.HOriginLabel2.Text = "目标说话人"
            ' 
            ' HTargetBox2
            ' 
            Me.HTargetBox2.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.HTargetBox2.FormattingEnabled = True
            Me.HTargetBox2.Location = New System.Drawing.Point(128, 67)
            Me.HTargetBox2.Name = "HTargetBox2"
            Me.HTargetBox2.Size = New System.Drawing.Size(343, 33)
            Me.HTargetBox2.TabIndex = 19
            AddHandler Me.HTargetBox2.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' HModelPanel
            ' 
            Me.HModelPanel.Controls.Add(Me.hubertPath)
            Me.HModelPanel.Controls.Add(Me.HOpenHubert)
            Me.HModelPanel.Controls.Add(Me.HConfigPath)
            Me.HModelPanel.Controls.Add(Me.HOpenConfig)
            Me.HModelPanel.Controls.Add(Me.HModelPath)
            Me.HModelPanel.Controls.Add(Me.HOpenModel)
            Me.HModelPanel.Location = New System.Drawing.Point(6, 6)
            Me.HModelPanel.Name = "HModelPanel"
            Me.HModelPanel.Size = New System.Drawing.Size(485, 167)
            Me.HModelPanel.TabIndex = 2
            Me.HModelPanel.TabStop = False
            Me.HModelPanel.Text = "模型文件"
            ' 
            ' hubertPath
            ' 
            Me.hubertPath.Location = New System.Drawing.Point(132, 114)
            Me.hubertPath.Name = "hubertPath"
            Me.hubertPath.Size = New System.Drawing.Size(347, 31)
            Me.hubertPath.TabIndex = 5
            AddHandler Me.hubertPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.HubertPath_KeyDown)
            AddHandler Me.hubertPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.HubertPath_KeyPress)
            ' 
            ' HOpenHubert
            ' 
            Me.HOpenHubert.Font = New System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.HOpenHubert.Location = New System.Drawing.Point(6, 112)
            Me.HOpenHubert.Name = "HOpenHubert"
            Me.HOpenHubert.Size = New System.Drawing.Size(120, 35)
            Me.HOpenHubert.TabIndex = 4
            Me.HOpenHubert.Text = "HuBERT模型"
            Me.HOpenHubert.UseVisualStyleBackColor = True
            AddHandler Me.HOpenHubert.Click, New System.EventHandler(AddressOf Me.HOpenHubert_Click)
            ' 
            ' HConfigPath
            ' 
            Me.HConfigPath.Location = New System.Drawing.Point(132, 73)
            Me.HConfigPath.Name = "HConfigPath"
            Me.HConfigPath.Size = New System.Drawing.Size(347, 31)
            Me.HConfigPath.TabIndex = 3
            AddHandler Me.HConfigPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.HConfigPath_KeyDown)
            AddHandler Me.HConfigPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.ConfigPath_KeyPress)
            ' 
            ' HOpenConfig
            ' 
            Me.HOpenConfig.Location = New System.Drawing.Point(6, 71)
            Me.HOpenConfig.Name = "HOpenConfig"
            Me.HOpenConfig.Size = New System.Drawing.Size(120, 35)
            Me.HOpenConfig.TabIndex = 2
            Me.HOpenConfig.Text = "VITS配置"
            Me.HOpenConfig.UseVisualStyleBackColor = True
            AddHandler Me.HOpenConfig.Click, New System.EventHandler(AddressOf Me.OpenConfig_Click)
            ' 
            ' HModelPath
            ' 
            Me.HModelPath.Location = New System.Drawing.Point(132, 32)
            Me.HModelPath.Name = "HModelPath"
            Me.HModelPath.Size = New System.Drawing.Size(347, 31)
            Me.HModelPath.TabIndex = 1
            AddHandler Me.HModelPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.HModelPath_KeyDown)
            AddHandler Me.HModelPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.ModelPath_KeyPress)
            ' 
            ' HOpenModel
            ' 
            Me.HOpenModel.Location = New System.Drawing.Point(6, 30)
            Me.HOpenModel.Name = "HOpenModel"
            Me.HOpenModel.Size = New System.Drawing.Size(120, 35)
            Me.HOpenModel.TabIndex = 0
            Me.HOpenModel.Text = "VITS模型"
            Me.HOpenModel.UseVisualStyleBackColor = True
            AddHandler Me.HOpenModel.Click, New System.EventHandler(AddressOf Me.OpenModel_Click)
            ' 
            ' HOriginPath
            ' 
            Me.HOriginPath.Enabled = False
            Me.HOriginPath.Location = New System.Drawing.Point(138, 191)
            Me.HOriginPath.Name = "HOriginPath"
            Me.HOriginPath.Size = New System.Drawing.Size(349, 31)
            Me.HOriginPath.TabIndex = 16
            AddHandler Me.HOriginPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.HOriginPath_KeyDown)
            AddHandler Me.HOriginPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.OriginPath_KeyPress)
            ' 
            ' w2v2Page
            ' 
            Me.w2v2Page.Controls.Add(Me.WModeControl)
            Me.w2v2Page.Controls.Add(Me.WModelPanel)
            Me.w2v2Page.Location = New System.Drawing.Point(4, 33)
            Me.w2v2Page.Name = "w2v2Page"
            Me.w2v2Page.Size = New System.Drawing.Size(497, 410)
            Me.w2v2Page.TabIndex = 2
            Me.w2v2Page.Text = "W2V2-VITS"
            Me.w2v2Page.UseVisualStyleBackColor = True
            ' 
            ' WModeControl
            ' 
            Me.WModeControl.Controls.Add(Me.tabPage1)
            Me.WModeControl.Controls.Add(Me.tabPage2)
            Me.WModeControl.Enabled = False
            Me.WModeControl.Location = New System.Drawing.Point(6, 179)
            Me.WModeControl.Name = "WModeControl"
            Me.WModeControl.SelectedIndex = 0
            Me.WModeControl.Size = New System.Drawing.Size(487, 225)
            Me.WModeControl.TabIndex = 4
            ' 
            ' tabPage1
            ' 
            Me.tabPage1.Controls.Add(Me.emotionButton)
            Me.tabPage1.Controls.Add(Me.emotionPath)
            Me.tabPage1.Controls.Add(Me.WSpeakerBox)
            Me.tabPage1.Controls.Add(Me.WSpeakerLabel)
            Me.tabPage1.Controls.Add(Me.WTextLabel)
            Me.tabPage1.Controls.Add(Me.WTextBox)
            Me.tabPage1.Location = New System.Drawing.Point(4, 33)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(479, 188)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "语音合成"
            Me.tabPage1.UseVisualStyleBackColor = True
            ' 
            ' emotionButton
            ' 
            Me.emotionButton.Location = New System.Drawing.Point(6, 6)
            Me.emotionButton.Name = "emotionButton"
            Me.emotionButton.Size = New System.Drawing.Size(117, 35)
            Me.emotionButton.TabIndex = 13
            Me.emotionButton.Text = "情感参考"
            Me.emotionButton.UseVisualStyleBackColor = True
            AddHandler Me.emotionButton.Click, New System.EventHandler(AddressOf Me.EmotionButton_Click)
            ' 
            ' emotionPath
            ' 
            Me.emotionPath.Location = New System.Drawing.Point(128, 8)
            Me.emotionPath.Name = "emotionPath"
            Me.emotionPath.Size = New System.Drawing.Size(344, 31)
            Me.emotionPath.TabIndex = 14
            AddHandler Me.emotionPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.EmotionPath_KeyDown)
            AddHandler Me.emotionPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.EmotionPath_KeyPress)
            ' 
            ' WSpeakerBox
            ' 
            Me.WSpeakerBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.WSpeakerBox.FormattingEnabled = True
            Me.WSpeakerBox.Location = New System.Drawing.Point(128, 146)
            Me.WSpeakerBox.Name = "WSpeakerBox"
            Me.WSpeakerBox.Size = New System.Drawing.Size(344, 33)
            Me.WSpeakerBox.TabIndex = 3
            AddHandler Me.WSpeakerBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' WSpeakerLabel
            ' 
            Me.WSpeakerLabel.AutoSize = True
            Me.WSpeakerLabel.Location = New System.Drawing.Point(32, 150)
            Me.WSpeakerLabel.Name = "WSpeakerLabel"
            Me.WSpeakerLabel.Size = New System.Drawing.Size(64, 24)
            Me.WSpeakerLabel.TabIndex = 2
            Me.WSpeakerLabel.Text = "说话人"
            ' 
            ' WTextLabel
            ' 
            Me.WTextLabel.AutoSize = True
            Me.WTextLabel.Location = New System.Drawing.Point(41, 81)
            Me.WTextLabel.Name = "WTextLabel"
            Me.WTextLabel.Size = New System.Drawing.Size(46, 24)
            Me.WTextLabel.TabIndex = 0
            Me.WTextLabel.Text = "文本"
            ' 
            ' WTextBox
            ' 
            Me.WTextBox.ContextMenuStrip = Me.menuStrip
            Me.WTextBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.WTextBox.Location = New System.Drawing.Point(128, 47)
            Me.WTextBox.Multiline = True
            Me.WTextBox.Name = "WTextBox"
            Me.WTextBox.Size = New System.Drawing.Size(344, 93)
            Me.WTextBox.TabIndex = 1
            AddHandler Me.WTextBox.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextBox_KeyDown)
            ' 
            ' tabPage2
            ' 
            Me.tabPage2.Controls.Add(Me.WOpenOrigin)
            Me.tabPage2.Controls.Add(Me.WOriginPath)
            Me.tabPage2.Controls.Add(Me.WOriginBox)
            Me.tabPage2.Controls.Add(Me.WOriginLabel)
            Me.tabPage2.Controls.Add(Me.WTargetBox)
            Me.tabPage2.Controls.Add(Me.WTargetLabel)
            Me.tabPage2.Location = New System.Drawing.Point(4, 33)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(479, 188)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "语音转换"
            Me.tabPage2.UseVisualStyleBackColor = True
            ' 
            ' WOpenOrigin
            ' 
            Me.WOpenOrigin.Location = New System.Drawing.Point(6, 28)
            Me.WOpenOrigin.Name = "WOpenOrigin"
            Me.WOpenOrigin.Size = New System.Drawing.Size(116, 35)
            Me.WOpenOrigin.TabIndex = 4
            Me.WOpenOrigin.Text = "打开原音频"
            Me.WOpenOrigin.UseVisualStyleBackColor = True
            AddHandler Me.WOpenOrigin.Click, New System.EventHandler(AddressOf Me.OpenOrigin_Click)
            ' 
            ' WOriginPath
            ' 
            Me.WOriginPath.Location = New System.Drawing.Point(128, 30)
            Me.WOriginPath.Name = "WOriginPath"
            Me.WOriginPath.Size = New System.Drawing.Size(344, 31)
            Me.WOriginPath.TabIndex = 12
            AddHandler Me.WOriginPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.OriginPath_KeyDown)
            AddHandler Me.WOriginPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.OriginPath_KeyPress)
            ' 
            ' WOriginBox
            ' 
            Me.WOriginBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.WOriginBox.FormattingEnabled = True
            Me.WOriginBox.Location = New System.Drawing.Point(128, 89)
            Me.WOriginBox.Name = "WOriginBox"
            Me.WOriginBox.Size = New System.Drawing.Size(344, 33)
            Me.WOriginBox.TabIndex = 10
            AddHandler Me.WOriginBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' WOriginLabel
            ' 
            Me.WOriginLabel.AutoSize = True
            Me.WOriginLabel.Location = New System.Drawing.Point(23, 93)
            Me.WOriginLabel.Name = "WOriginLabel"
            Me.WOriginLabel.Size = New System.Drawing.Size(82, 24)
            Me.WOriginLabel.TabIndex = 9
            Me.WOriginLabel.Text = "原说话人"
            ' 
            ' WTargetBox
            ' 
            Me.WTargetBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.WTargetBox.FormattingEnabled = True
            Me.WTargetBox.Location = New System.Drawing.Point(128, 128)
            Me.WTargetBox.Name = "WTargetBox"
            Me.WTargetBox.Size = New System.Drawing.Size(344, 33)
            Me.WTargetBox.TabIndex = 8
            AddHandler Me.WTargetBox.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.SearchSpeakers)
            ' 
            ' WTargetLabel
            ' 
            Me.WTargetLabel.AutoSize = True
            Me.WTargetLabel.Location = New System.Drawing.Point(14, 132)
            Me.WTargetLabel.Name = "WTargetLabel"
            Me.WTargetLabel.Size = New System.Drawing.Size(100, 24)
            Me.WTargetLabel.TabIndex = 7
            Me.WTargetLabel.Text = "目标说话人"
            ' 
            ' WModelPanel
            ' 
            Me.WModelPanel.Controls.Add(Me.W2V2Path)
            Me.WModelPanel.Controls.Add(Me.W2V2Model)
            Me.WModelPanel.Controls.Add(Me.WConfigPath)
            Me.WModelPanel.Controls.Add(Me.WOpenConfig)
            Me.WModelPanel.Controls.Add(Me.WModelPath)
            Me.WModelPanel.Controls.Add(Me.WOpenModel)
            Me.WModelPanel.Location = New System.Drawing.Point(6, 6)
            Me.WModelPanel.Name = "WModelPanel"
            Me.WModelPanel.Size = New System.Drawing.Size(485, 167)
            Me.WModelPanel.TabIndex = 3
            Me.WModelPanel.TabStop = False
            Me.WModelPanel.Text = "模型文件"
            ' 
            ' W2V2Path
            ' 
            Me.W2V2Path.Location = New System.Drawing.Point(132, 114)
            Me.W2V2Path.Name = "W2V2Path"
            Me.W2V2Path.Size = New System.Drawing.Size(347, 31)
            Me.W2V2Path.TabIndex = 5
            AddHandler Me.W2V2Path.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.W2V2Path_KeyDown)
            AddHandler Me.W2V2Path.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.W2V2Path_KeyPress)
            ' 
            ' W2V2Model
            ' 
            Me.W2V2Model.Font = New System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.W2V2Model.Location = New System.Drawing.Point(6, 112)
            Me.W2V2Model.Name = "W2V2Model"
            Me.W2V2Model.Size = New System.Drawing.Size(120, 35)
            Me.W2V2Model.TabIndex = 4
            Me.W2V2Model.Text = "情感识别模型"
            Me.W2V2Model.UseVisualStyleBackColor = True
            AddHandler Me.W2V2Model.Click, New System.EventHandler(AddressOf Me.W2V2Model_Click)
            ' 
            ' WConfigPath
            ' 
            Me.WConfigPath.Location = New System.Drawing.Point(132, 73)
            Me.WConfigPath.Name = "WConfigPath"
            Me.WConfigPath.Size = New System.Drawing.Size(347, 31)
            Me.WConfigPath.TabIndex = 3
            AddHandler Me.WConfigPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.WConfigPath_KeyDown)
            AddHandler Me.WConfigPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.ConfigPath_KeyPress)
            ' 
            ' WOpenConfig
            ' 
            Me.WOpenConfig.Location = New System.Drawing.Point(6, 71)
            Me.WOpenConfig.Name = "WOpenConfig"
            Me.WOpenConfig.Size = New System.Drawing.Size(120, 35)
            Me.WOpenConfig.TabIndex = 2
            Me.WOpenConfig.Text = "VITS配置"
            Me.WOpenConfig.UseVisualStyleBackColor = True
            AddHandler Me.WOpenConfig.Click, New System.EventHandler(AddressOf Me.OpenConfig_Click)
            ' 
            ' WModelPath
            ' 
            Me.WModelPath.Location = New System.Drawing.Point(132, 32)
            Me.WModelPath.Name = "WModelPath"
            Me.WModelPath.Size = New System.Drawing.Size(347, 31)
            Me.WModelPath.TabIndex = 1
            AddHandler Me.WModelPath.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.WModelPath_KeyDown)
            AddHandler Me.WModelPath.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.ModelPath_KeyPress)
            ' 
            ' WOpenModel
            ' 
            Me.WOpenModel.Location = New System.Drawing.Point(6, 30)
            Me.WOpenModel.Name = "WOpenModel"
            Me.WOpenModel.Size = New System.Drawing.Size(120, 35)
            Me.WOpenModel.TabIndex = 0
            Me.WOpenModel.Text = "VITS模型"
            Me.WOpenModel.UseVisualStyleBackColor = True
            AddHandler Me.WOpenModel.Click, New System.EventHandler(AddressOf Me.OpenModel_Click)
            ' 
            ' MainWin
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(977, 701)
            Me.Controls.Add(Me.modelControl)
            Me.Controls.Add(Me.consoleBox)
            Me.Controls.Add(Me.savePanel)
            Me.Controls.Add(Me.EXEPanel)
            Me.Font = New System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.Name = "MainWin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MoeGoe"
            AddHandler Me.FormClosed, New System.Windows.Forms.FormClosedEventHandler(AddressOf Me.MainWin_FormClosed)
            Me.EXEPanel.ResumeLayout(False)
            Me.EXEPanel.PerformLayout()
            Me.modelPanel.ResumeLayout(False)
            Me.modelPanel.PerformLayout()
            Me.modeControl.ResumeLayout(False)
            Me.TTSPage.ResumeLayout(False)
            Me.TTSPage.PerformLayout()
            Me.menuStrip.ResumeLayout(False)
            Me.VCPage.ResumeLayout(False)
            Me.VCPage.PerformLayout()
            Me.savePanel.ResumeLayout(False)
            Me.savePanel.PerformLayout()
            Me.modelControl.ResumeLayout(False)
            Me.vitsPage.ResumeLayout(False)
            Me.hubertPage.ResumeLayout(False)
            Me.hubertPage.PerformLayout()
            Me.HVCControl.ResumeLayout(False)
            Me.HVCPage1.ResumeLayout(False)
            Me.HVCPage1.PerformLayout()
            Me.HVCPage2.ResumeLayout(False)
            Me.HVCPage2.PerformLayout()
            Me.HModelPanel.ResumeLayout(False)
            Me.HModelPanel.PerformLayout()
            Me.w2v2Page.ResumeLayout(False)
            Me.WModeControl.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.WModelPanel.ResumeLayout(False)
            Me.WModelPanel.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region

        Private EXEPanel As System.Windows.Forms.GroupBox
        Private EXEPath As System.Windows.Forms.TextBox
        Private openEXE As System.Windows.Forms.Button
        Private modelPanel As System.Windows.Forms.GroupBox
        Private configPath As System.Windows.Forms.TextBox
        Private openConfig As System.Windows.Forms.Button
        Private modelPath As System.Windows.Forms.TextBox
        Private openModel As System.Windows.Forms.Button
        Private modeControl As System.Windows.Forms.TabControl
        Private TTSPage As System.Windows.Forms.TabPage
        Private VCPage As System.Windows.Forms.TabPage
        Private textLabel As System.Windows.Forms.Label
        Private textBox As System.Windows.Forms.TextBox
        Private speakerBox As System.Windows.Forms.ComboBox
        Private speakerLabel As System.Windows.Forms.Label
        Private originPath As System.Windows.Forms.TextBox
        Private originBox As System.Windows.Forms.ComboBox
        Private originLabel As System.Windows.Forms.Label
        Private targetBox As System.Windows.Forms.ComboBox
        Private targetLabel As System.Windows.Forms.Label
        Private savePanel As System.Windows.Forms.GroupBox
        Private savePath As System.Windows.Forms.TextBox
        Private saveButton As System.Windows.Forms.Button
        Private consoleBox As System.Windows.Forms.TextBox
        Private openOrigin As System.Windows.Forms.Button
        Private menuStrip As System.Windows.Forms.ContextMenuStrip
        Private cleanButton As System.Windows.Forms.ToolStripMenuItem
        Private paramsButton As System.Windows.Forms.ToolStripMenuItem
        Private modelControl As System.Windows.Forms.TabControl
        Private vitsPage As System.Windows.Forms.TabPage
        Private hubertPage As System.Windows.Forms.TabPage
        Private HModelPanel As System.Windows.Forms.GroupBox
        Private hubertPath As System.Windows.Forms.TextBox
        Private HOpenHubert As System.Windows.Forms.Button
        Private HConfigPath As System.Windows.Forms.TextBox
        Private HOpenConfig As System.Windows.Forms.Button
        Private HModelPath As System.Windows.Forms.TextBox
        Private HOpenModel As System.Windows.Forms.Button
        Private symbolsButton As System.Windows.Forms.ToolStripMenuItem
        Private playButton As System.Windows.Forms.Button
        Private resaveButton As System.Windows.Forms.Button
        Private stopButton As System.Windows.Forms.Button
        Private HVCControl As System.Windows.Forms.TabControl
        Private HVCPage1 As System.Windows.Forms.TabPage
        Private HOpenOrigin As System.Windows.Forms.Button
        Private HOriginPath As System.Windows.Forms.TextBox
        Private HVCPage2 As System.Windows.Forms.TabPage
        Private w2v2Page As System.Windows.Forms.TabPage
        Private HTargetLabel As System.Windows.Forms.Label
        Private HTargetBox As System.Windows.Forms.ComboBox
        Private HAdvancedControl As System.Windows.Forms.Button
        Private HOriginLabel As System.Windows.Forms.Label
        Private HOriginBox As System.Windows.Forms.ComboBox
        Private HOriginLabel2 As System.Windows.Forms.Label
        Private HTargetBox2 As System.Windows.Forms.ComboBox
        Private WModelPanel As System.Windows.Forms.GroupBox
        Private W2V2Path As System.Windows.Forms.TextBox
        Private W2V2Model As System.Windows.Forms.Button
        Private WConfigPath As System.Windows.Forms.TextBox
        Private WOpenConfig As System.Windows.Forms.Button
        Private WModelPath As System.Windows.Forms.TextBox
        Private WOpenModel As System.Windows.Forms.Button
        Private deleteButton As System.Windows.Forms.Button
        Private WModeControl As System.Windows.Forms.TabControl
        Private tabPage1 As System.Windows.Forms.TabPage
        Private emotionButton As System.Windows.Forms.Button
        Private emotionPath As System.Windows.Forms.TextBox
        Private WSpeakerBox As System.Windows.Forms.ComboBox
        Private WSpeakerLabel As System.Windows.Forms.Label
        Private WTextLabel As System.Windows.Forms.Label
        Private WTextBox As System.Windows.Forms.TextBox
        Private tabPage2 As System.Windows.Forms.TabPage
        Private WOpenOrigin As System.Windows.Forms.Button
        Private WOriginPath As System.Windows.Forms.TextBox
        Private WOriginBox As System.Windows.Forms.ComboBox
        Private WOriginLabel As System.Windows.Forms.Label
        Private WTargetBox As System.Windows.Forms.ComboBox
        Private WTargetLabel As System.Windows.Forms.Label
        Private cleanButton2 As System.Windows.Forms.Button
        Private symbolsButton2 As System.Windows.Forms.Button
        Private paramsButton2 As System.Windows.Forms.Button
    End Class
End Namespace
