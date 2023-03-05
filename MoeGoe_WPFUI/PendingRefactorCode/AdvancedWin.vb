Imports System.Windows.Forms

Namespace MoeGoe_GUI
    Public Partial Class AdvancedWin
        Inherits Form
        Public Sub New(GetParameters As Func(Of Decimal()),
            SetParameters As Action(Of Decimal, Decimal, Decimal))
            InitializeComponent()
            Dim parameters As Decimal() = GetParameters()
            lengthBox.Value = parameters(0)
            noiseBox.Value = parameters(1)
            noisewBox.Value = parameters(2)
            Me.SetParameters = SetParameters
        End Sub
        Private ReadOnly SetParameters As Action(Of Decimal, Decimal, Decimal)
        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs)
            SetParameters(lengthBox.Value, noiseBox.Value, noisewBox.Value)
            Close()
        End Sub
    End Class
End Namespace
