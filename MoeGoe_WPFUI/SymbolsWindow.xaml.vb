Public Class SymbolsWindow
    Private ReadOnly _box As TextBox

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Sub New(lstSYMBOLS As List(Of String), box As TextBox)
        MyClass.New
        ItmKeyboard.ItemsSource = lstSYMBOLS
        _box = box
    End Sub

    Private Sub BtnSymbol_Click(sender As Object, e As RoutedEventArgs)
        _box.SelectedText = CStr(DirectCast(sender, Button).Content)
        _box.Select(_box.SelectionStart + _box.SelectionLength, 0)
    End Sub
End Class
