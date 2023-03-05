Public Class HAdvancedWindow
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Sub New(value1 As Func(Of Decimal()), value2 As Action(Of Decimal, Decimal, Decimal), bUSEF0 As Boolean)
        MyClass.New

    End Sub

End Class
