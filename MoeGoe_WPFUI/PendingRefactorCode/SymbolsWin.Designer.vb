Namespace MoeGoe_GUI
    Partial Class SymbolsWin
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SymbolsWin))
            Me.symbolPanel = New System.Windows.Forms.FlowLayoutPanel
            Me.SuspendLayout()
            ' 
            ' symbolPanel
            ' 
            Me.symbolPanel.AutoScroll = True
            Me.symbolPanel.Location = New System.Drawing.Point(12, 12)
            Me.symbolPanel.Name = "symbolPanel"
            Me.symbolPanel.Size = New System.Drawing.Size(436, 305)
            Me.symbolPanel.TabIndex = 0
            ' 
            ' SymbolsWin
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(460, 329)
            Me.Controls.Add(Me.symbolPanel)
            Me.Font = New System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(134)))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "SymbolsWin"
            Me.Text = "符号输入"
            Me.ResumeLayout(False)
        End Sub
#End Region

        Private symbolPanel As System.Windows.Forms.FlowLayoutPanel
    End Class
End Namespace
