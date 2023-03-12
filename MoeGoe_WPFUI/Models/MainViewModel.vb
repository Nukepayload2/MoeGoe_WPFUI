Imports System.ComponentModel
Imports System.Text.Json.Serialization

Public Class MainViewModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property OpenMoeGoe As New OpenFileCommand(
        Function() MoeGoeExePath,
        Sub(it) MoeGoeExePath = it,
        "MoeGoe 或与之兼容的 exe|*.exe", "打开 MoeGoe.exe")

    Dim _MoeGoeExePath As String
    <JsonInclude>
    Public Property MoeGoeExePath As String
        Get
            Return _MoeGoeExePath
        End Get
        Set(value As String)
            If _MoeGoeExePath <> value Then
                _MoeGoeExePath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(MoeGoeExePath)))
            End If
        End Set
    End Property

    Dim _UsageSelectedIndex As Integer
    Public Property UsageSelectedIndex As Integer
        Get
            Return _UsageSelectedIndex
        End Get
        Set(value As Integer)
            If _UsageSelectedIndex <> value Then
                _UsageSelectedIndex = value
                UpdateActiveOutput()
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(UsageSelectedIndex)))
            End If
        End Set
    End Property

    Public Sub UpdateActiveOutput()
        Select Case UsageSelectedIndex
            Case 0
                If Vits Is Nothing Then Return
                Select Case Vits.UsageSelectedIndex
                    Case 0
                        ActiveOutput = Vits.TextToSpeech?.Output
                    Case 1
                        ActiveOutput = Vits.SpeechToSpeech?.Output
                End Select
            Case 1
                If HubertVits Is Nothing Then Return
                Select Case HubertVits.UsageSelectedIndex
                    Case 0
                        ActiveOutput = HubertVits.LanguageTransform?.Output
                    Case 1
                        ActiveOutput = HubertVits.SpeechTransform?.Output
                End Select
            Case 2
                If W2V2Vits Is Nothing Then Return
                Select Case W2V2Vits.UsageSelectedIndex
                    Case 0
                        ActiveOutput = W2V2Vits.TextToSpeech?.Output
                    Case 1
                        ActiveOutput = W2V2Vits.SpeechTransform?.Output
                End Select
        End Select
    End Sub

    <JsonInclude>
    Public ReadOnly Property Vits As New VitsModel(Me)
    <JsonInclude>
    Public ReadOnly Property HubertVits As New HubertVitsModel(Me)
    <JsonInclude>
    Public ReadOnly Property W2V2Vits As New W2V2VitsModel(Me)

    Dim _ActiveOutput As SpeechOutputModel
    Public Property ActiveOutput As SpeechOutputModel
        Get
            Return _ActiveOutput
        End Get
        Set(value As SpeechOutputModel)
            If _ActiveOutput IsNot value Then
                _ActiveOutput = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(ActiveOutput)))
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
