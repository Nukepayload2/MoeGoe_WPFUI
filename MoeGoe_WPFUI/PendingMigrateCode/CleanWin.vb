Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace MoeGoe_GUI
    Public Partial Class CleanWin
        Inherits Form
        Public Sub New(box As TextBox, cmd As CommandLine)
            InitializeComponent()
            returnBox = box
            Me.cmd = cmd
            Dim regexCleaned As New Regex("\[CLEANED\]")
            Dim match1 As Match = Regex.Match(box.Text, "\[CLEANED\]")
            If match1.Success Then
                textBox.Text = ""
            Else textBox.Text = box.Text
            End If
            AddHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
        End Sub
        Private ReadOnly returnBox As TextBox
        Private ReadOnly cmd As CommandLine
        Private Sub Cmd_OutputHandler(sender As CommandLine, e As String)
            Invoke(New Action(Sub()
                                  Try
                                      cleanedBox.Text = Regex.Unescape(e)
                                  Catch
                                      cleanedBox.Text = e
                                  End Try
                              End Sub))
        End Sub
        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs)
            returnBox.Text = "[CLEANED]" & cleanedBox.Text
            Close()
        End Sub
        Private Sub CleanButton_Click(sender As Object, e As EventArgs)
            cmd.Write("t")
            cmd.Write("[ADVANCED]")
            cmd.Write(textBox.Text)
        End Sub
        Private Sub AdvancedWin_FormClosing(sender As Object, e As FormClosingEventArgs)
            RemoveHandler cmd.OutputHandler, AddressOf Cmd_OutputHandler
        End Sub
    End Class
End Namespace
