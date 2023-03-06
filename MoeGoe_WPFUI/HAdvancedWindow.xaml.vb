Public Class HAdvancedWindow
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Sub New(GetParameters As Func(Of Decimal()),
            SetParameters As Action(Of Decimal, Decimal, Decimal, Decimal), f0Enabled As Boolean)
        MyClass.New
        Dim parameters As Decimal() = GetParameters()
        lengthBox.Value = parameters(0)
        noiseBox.Value = parameters(1)
        noisewBox.Value = parameters(2)
        Me.SetParameters = SetParameters
        If f0Enabled Then
            f0Box.Value = parameters(3)
            f0Box.IsEnabled = True
        End If
    End Sub

    Private ReadOnly SetParameters As Action(Of Decimal, Decimal, Decimal, Decimal)
    Private Sub ConfirmButton_Click() Handles confirmButton.Click
        SetParameters(lengthBox.Value, noiseBox.Value, noisewBox.Value, f0Box.Value)
        Close()
    End Sub
    Private Sub BtnResetLength_Click() Handles BtnResetLength.Click
        lengthBox.Value = 1
    End Sub

    Private Sub BtnResetNoise_Click() Handles BtnResetNoise.Click
        noiseBox.Value = 2 / 3
    End Sub

    Private Sub BtnResetNoiseVar_Click() Handles BtnResetNoiseVar.Click
        noisewBox.Value = 0.8
    End Sub

    Private Sub BtnResetF0_Click() Handles BtnResetF0.Click
        If f0Box.IsEnabled Then
            f0Box.Value = 1
        End If
    End Sub
End Class
