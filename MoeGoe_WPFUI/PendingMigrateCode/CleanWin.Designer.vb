Namespace MoeGoe_GUI
    Partial Class CleanWin
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CleanWin))
            Me.textBox = New System.Windows.Forms.TextBox
            Me.cleanedBox = New System.Windows.Forms.TextBox
            Me.cleanButton = New System.Windows.Forms.Button
            Me.confirmButton = New System.Windows.Forms.Button
            Me.SuspendLayout()
            ' 
            ' textBox
            ' 
            Me.textBox.Font = New System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(128)))
            Me.textBox.Location = New System.Drawing.Point(12, 12)
            Me.textBox.Multiline = True
            Me.textBox.Name = "textBox"
            Me.textBox.Size = New System.Drawing.Size(346, 93)
            Me.textBox.TabIndex = 0
            ' 
            ' cleanedBox
            ' 
            Me.cleanedBox.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.cleanedBox.Location = New System.Drawing.Point(12, 152)
            Me.cleanedBox.Multiline = True
            Me.cleanedBox.Name = "cleanedBox"
            Me.cleanedBox.Size = New System.Drawing.Size(346, 93)
            Me.cleanedBox.TabIndex = 2
            ' 
            ' cleanButton
            ' 
            Me.cleanButton.Location = New System.Drawing.Point(125, 111)
            Me.cleanButton.Name = "cleanButton"
            Me.cleanButton.Size = New System.Drawing.Size(120, 35)
            Me.cleanButton.TabIndex = 1
            Me.cleanButton.Text = "清理"
            Me.cleanButton.UseVisualStyleBackColor = True
            AddHandler Me.cleanButton.Click, New System.EventHandler(AddressOf Me.CleanButton_Click)
            ' 
            ' confirmButton
            ' 
            Me.confirmButton.Location = New System.Drawing.Point(125, 251)
            Me.confirmButton.Name = "confirmButton"
            Me.confirmButton.Size = New System.Drawing.Size(120, 35)
            Me.confirmButton.TabIndex = 3
            Me.confirmButton.Text = "确定"
            Me.confirmButton.UseVisualStyleBackColor = True
            AddHandler Me.confirmButton.Click, New System.EventHandler(AddressOf Me.ConfirmButton_Click)
            ' 
            ' AdvancedWin
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(370, 297)
            Me.Controls.Add(Me.confirmButton)
            Me.Controls.Add(Me.cleanButton)
            Me.Controls.Add(Me.cleanedBox)
            Me.Controls.Add(Me.textBox)
            Me.Font = New System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AdvancedWin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "文本清理"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.AdvancedWin_FormClosing)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region

        Private textBox As System.Windows.Forms.TextBox
        Private cleanedBox As System.Windows.Forms.TextBox
        Private cleanButton As System.Windows.Forms.Button
        Private confirmButton As System.Windows.Forms.Button
    End Class
End Namespace
