Namespace MoeGoe_GUI
    Partial Class HAdvancedWin
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HAdvancedWin))
            Me.lengthBox = New System.Windows.Forms.NumericUpDown
            Me.confirmButton = New System.Windows.Forms.Button
            Me.lengthLabel = New System.Windows.Forms.Label
            Me.noiseLabel = New System.Windows.Forms.Label
            Me.noiseBox = New System.Windows.Forms.NumericUpDown
            Me.noisewLabel = New System.Windows.Forms.Label
            Me.noisewBox = New System.Windows.Forms.NumericUpDown
            Me.f0Label = New System.Windows.Forms.Label
            Me.f0Box = New System.Windows.Forms.NumericUpDown
            CType((Me.lengthBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.noiseBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.noisewBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.f0Box), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lengthBox
            ' 
            Me.lengthBox.DecimalPlaces = 2
            Me.lengthBox.Increment = New Decimal(New Integer() { _
            1,
            0,
            0,
            131072})
            Me.lengthBox.Location = New System.Drawing.Point(136, 25)
            Me.lengthBox.Maximum = New Decimal(New Integer() { _
            10,
            0,
            0,
            0})
            Me.lengthBox.Minimum = New Decimal(New Integer() { _
            1,
            0,
            0,
            65536})
            Me.lengthBox.Name = "lengthBox"
            Me.lengthBox.Size = New System.Drawing.Size(86, 31)
            Me.lengthBox.TabIndex = 1
            Me.lengthBox.Value = New Decimal(New Integer() { _
            1,
            0,
            0,
            0})
            ' 
            ' confirmButton
            ' 
            Me.confirmButton.Location = New System.Drawing.Point(73, 190)
            Me.confirmButton.Name = "confirmButton"
            Me.confirmButton.Size = New System.Drawing.Size(120, 35)
            Me.confirmButton.TabIndex = 6
            Me.confirmButton.Text = "确定"
            Me.confirmButton.UseVisualStyleBackColor = True
            AddHandler Me.confirmButton.Click, New System.EventHandler(AddressOf Me.ConfirmButton_Click)
            ' 
            ' lengthLabel
            ' 
            Me.lengthLabel.AutoSize = True
            Me.lengthLabel.Location = New System.Drawing.Point(38, 28)
            Me.lengthLabel.Name = "lengthLabel"
            Me.lengthLabel.Size = New System.Drawing.Size(82, 24)
            Me.lengthLabel.TabIndex = 0
            Me.lengthLabel.Text = "时长比例"
            ' 
            ' noiseLabel
            ' 
            Me.noiseLabel.AutoSize = True
            Me.noiseLabel.Location = New System.Drawing.Point(38, 65)
            Me.noiseLabel.Name = "noiseLabel"
            Me.noiseLabel.Size = New System.Drawing.Size(82, 24)
            Me.noiseLabel.TabIndex = 2
            Me.noiseLabel.Text = "噪声比例"
            ' 
            ' noiseBox
            ' 
            Me.noiseBox.DecimalPlaces = 3
            Me.noiseBox.Increment = New Decimal(New Integer() { _
            1,
            0,
            0,
            196608})
            Me.noiseBox.Location = New System.Drawing.Point(136, 62)
            Me.noiseBox.Maximum = New Decimal(New Integer() { _
            10,
            0,
            0,
            0})
            Me.noiseBox.Minimum = New Decimal(New Integer() { _
            1,
            0,
            0,
            131072})
            Me.noiseBox.Name = "noiseBox"
            Me.noiseBox.Size = New System.Drawing.Size(86, 31)
            Me.noiseBox.TabIndex = 3
            Me.noiseBox.Value = New Decimal(New Integer() { _
            667,
            0,
            0,
            196608})
            ' 
            ' noisewLabel
            ' 
            Me.noisewLabel.AutoSize = True
            Me.noisewLabel.Location = New System.Drawing.Point(38, 102)
            Me.noisewLabel.Name = "noisewLabel"
            Me.noisewLabel.Size = New System.Drawing.Size(82, 24)
            Me.noisewLabel.TabIndex = 4
            Me.noisewLabel.Text = "噪声偏差"
            ' 
            ' noisewBox
            ' 
            Me.noisewBox.DecimalPlaces = 2
            Me.noisewBox.Increment = New Decimal(New Integer() { _
            1,
            0,
            0,
            131072})
            Me.noisewBox.Location = New System.Drawing.Point(136, 99)
            Me.noisewBox.Maximum = New Decimal(New Integer() { _
            10,
            0,
            0,
            0})
            Me.noisewBox.Minimum = New Decimal(New Integer() { _
            1,
            0,
            0,
            131072})
            Me.noisewBox.Name = "noisewBox"
            Me.noisewBox.Size = New System.Drawing.Size(86, 31)
            Me.noisewBox.TabIndex = 5
            Me.noisewBox.Value = New Decimal(New Integer() { _
            8,
            0,
            0,
            65536})
            ' 
            ' f0Label
            ' 
            Me.f0Label.AutoSize = True
            Me.f0Label.Enabled = False
            Me.f0Label.Location = New System.Drawing.Point(38, 139)
            Me.f0Label.Name = "f0Label"
            Me.f0Label.Size = New System.Drawing.Size(82, 24)
            Me.f0Label.TabIndex = 7
            Me.f0Label.Text = "基频比例"
            ' 
            ' f0Box
            ' 
            Me.f0Box.DecimalPlaces = 2
            Me.f0Box.Enabled = False
            Me.f0Box.Increment = New Decimal(New Integer() { _
            1,
            0,
            0,
            131072})
            Me.f0Box.Location = New System.Drawing.Point(136, 136)
            Me.f0Box.Maximum = New Decimal(New Integer() { _
            10,
            0,
            0,
            0})
            Me.f0Box.Minimum = New Decimal(New Integer() { _
            1,
            0,
            0,
            65536})
            Me.f0Box.Name = "f0Box"
            Me.f0Box.Size = New System.Drawing.Size(86, 31)
            Me.f0Box.TabIndex = 8
            Me.f0Box.Value = New Decimal(New Integer() { _
            1,
            0,
            0,
            0})
            ' 
            ' HAdvancedWin
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(267, 248)
            Me.Controls.Add(Me.f0Label)
            Me.Controls.Add(Me.f0Box)
            Me.Controls.Add(Me.noisewLabel)
            Me.Controls.Add(Me.noisewBox)
            Me.Controls.Add(Me.noiseLabel)
            Me.Controls.Add(Me.noiseBox)
            Me.Controls.Add(Me.lengthLabel)
            Me.Controls.Add(Me.confirmButton)
            Me.Controls.Add(Me.lengthBox)
            Me.Font = New System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "HAdvancedWin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "参数设置"
            CType((Me.lengthBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.noiseBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.noisewBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.f0Box), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region

        Private lengthBox As System.Windows.Forms.NumericUpDown
        Private confirmButton As System.Windows.Forms.Button
        Private lengthLabel As System.Windows.Forms.Label
        Private noiseLabel As System.Windows.Forms.Label
        Private noiseBox As System.Windows.Forms.NumericUpDown
        Private noisewLabel As System.Windows.Forms.Label
        Private noisewBox As System.Windows.Forms.NumericUpDown
        Private f0Label As System.Windows.Forms.Label
        Private f0Box As System.Windows.Forms.NumericUpDown
    End Class
End Namespace
