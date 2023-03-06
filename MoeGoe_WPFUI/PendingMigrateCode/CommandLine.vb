Public Class CommandLine
    Private ReadOnly process1 As Process

    Public Delegate Sub onOutputHandler(sender As CommandLine, e As String)
    Public Event OutputHandler As onOutputHandler

    Public Sub New()
        Try
            process1 = New Process With
            {
                .StartInfo = New ProcessStartInfo("cmd.exe") With
                {
                    .Arguments = "/k",
                    .RedirectStandardInput = True,
                    .RedirectStandardOutput = True,
                    .RedirectStandardError = True,
                    .UseShellExecute = False,
                    .CreateNoWindow = True
                }
            }
            AddHandler process1.OutputDataReceived, AddressOf Command_OutputDataReceived
            AddHandler process1.ErrorDataReceived, AddressOf Command_ErrorDataReceived
            process1.Start()
            process1.BeginOutputReadLine()
            process1.BeginErrorReadLine()
        Catch e As Exception
            Trace.WriteLine(e.Message)
        End Try
    End Sub
    Private Sub Command_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs)
        OnOutput(e.Data)
    End Sub
    Private Sub Command_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        OnOutput(e.Data)
    End Sub
    Private Sub OnOutput(data1 As String)
        RaiseEvent OutputHandler(Me, data1)
    End Sub
    Public Sub Write(data1 As String)
        Try
            process1.StandardInput.WriteLine(data1)
        Catch e As Exception
            Trace.WriteLine(e.Message)
        End Try
    End Sub
End Class