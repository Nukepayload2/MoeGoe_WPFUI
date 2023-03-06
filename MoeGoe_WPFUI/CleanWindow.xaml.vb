Imports System.Text.RegularExpressions

Public Class CleanWindow
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private ReadOnly returnBox As TextBox
    Private ReadOnly cmd As CommandLine
    Public Sub New(box As TextBox, cmd As CommandLine)
        MyClass.New
        returnBox = box
        Me.cmd = cmd
        If box.Text.Contains("[CLEANED]", StringComparison.Ordinal) Then
            TxtClean.Text = String.Empty
        Else
            TxtClean.Text = box.Text
        End If
        AddHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
    End Sub

    Private Sub Cmd_OutputHandler(sender As CommandLine, e As String)
        Dispatcher.BeginInvoke(
            Sub()
                Try
                    cleanedBox.Text = Regex.Unescape(e)
                Catch
                    cleanedBox.Text = e
                End Try
            End Sub)
    End Sub

    Private Sub ConfirmButton_Click() Handles confirmButton.Click
        returnBox.Text = "[CLEANED]" & cleanedBox.Text
        Close()
    End Sub

    Private Sub CleanButton_Click() Handles cleanButton.Click
        cmd.Write("t")
        cmd.Write("[ADVANCED]")
        cmd.Write(TxtClean.Text)
    End Sub

    Private Sub AdvancedWin_FormClosing() Handles Me.Closed
        RemoveHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
    End Sub
End Class
