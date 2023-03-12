Imports Microsoft.Win32

Public Class OpenFileCommand
    Inherits AsyncCommandBase

    Private ReadOnly _getPathCallback As Func(Of String)
    Private ReadOnly _setPathCallback As Action(Of String)
    Private ReadOnly _openDlg As OpenFileDialog

    Public Sub New(getPathCallback As Func(Of String),
                   setPathCallback As Action(Of String),
                   filter As String, title As String)
        _setPathCallback = setPathCallback
        _getPathCallback = getPathCallback
        _openDlg = New OpenFileDialog With {.Filter = filter, .Title = title}
    End Sub

    Protected Overrides Function ExecuteAsync(parameter As Object) As Task
        Dim startPath = _getPathCallback()
        If startPath <> Nothing Then
            _openDlg.InitialDirectory = IO.Path.GetDirectoryName(startPath)
            _openDlg.FileName = startPath
        End If
        If _openDlg.ShowDialog Then
            _setPathCallback(_openDlg.FileName)
        End If
        Return Task.CompletedTask
    End Function
End Class
