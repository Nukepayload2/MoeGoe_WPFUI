Imports System.Windows.Forms

Namespace MoeGoe_GUI
    Public Partial Class HAdvancedWin
        Inherits Form
        Public Sub New(GetParameters As Func(Of Decimal()),
            SetParameters As Action(Of Decimal, Decimal, Decimal, Decimal), f0Enabled As Boolean)
            InitializeComponent()
            Dim parameters As Decimal() = GetParameters()
            lengthBox.Value = parameters(0)
            noiseBox.Value = parameters(1)
            noisewBox.Value = parameters(2)
            Me.SetParameters = SetParameters
            If f0Enabled Then
                f0Box.Value = parameters(3)
                f0Label.Enabled = True
                f0Box.Enabled = True
            End If
        End Sub
        Private ReadOnly SetParameters As Action(Of Decimal, Decimal, Decimal, Decimal)
        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs)
            SetParameters(lengthBox.Value, noiseBox.Value, noisewBox.Value, f0Box.Value)
            Close()
        End Sub
    End Class
End Namespace
