Imports System.ComponentModel

Public Class VitsSpeechTransformModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property Output As New SpeechOutputModel

    Public ReadOnly Property OpenOriginalSpeech As New OpenFileCommand(
        Function() SpeechPath,
        Sub(it) SpeechPath = it,
        "音频文件|*.wav;*.mp3;*.ogg;*.opus", "打开原音频")

    Dim _SpeechPath As String
    Public Property SpeechPath As String
        Get
            Return _SpeechPath
        End Get
        Set(value As String)
            If _SpeechPath <> value Then
                _SpeechPath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SpeechPath)))
            End If
        End Set
    End Property

    Dim _OriginalSpeakerList As IReadOnlyList(Of String)
    Public Property OriginalSpeakerList As IReadOnlyList(Of String)
        Get
            Return _OriginalSpeakerList
        End Get
        Set(value As IReadOnlyList(Of String))
            If _OriginalSpeakerList IsNot value Then
                _OriginalSpeakerList = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(OriginalSpeakerList)))
            End If
        End Set
    End Property

    Dim _SelectedOriginalSpeakerIndex As Integer
    Public Property SelectedOriginalSpeakerIndex As Integer
        Get
            Return _SelectedOriginalSpeakerIndex
        End Get
        Set(value As Integer)
            If _SelectedOriginalSpeakerIndex <> value Then
                _SelectedOriginalSpeakerIndex = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SelectedOriginalSpeakerIndex)))
            End If
        End Set
    End Property

    Dim _TargetSpeakerList As IReadOnlyList(Of String)
    Public Property TargetSpeakerList As IReadOnlyList(Of String)
        Get
            Return _TargetSpeakerList
        End Get
        Set(value As IReadOnlyList(Of String))
            If _TargetSpeakerList IsNot value Then
                _TargetSpeakerList = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(TargetSpeakerList)))
            End If
        End Set
    End Property

    Dim _SelectedTargetSpeakerIndex As Integer
    Public Property SelectedTargetSpeakerIndex As Integer
        Get
            Return _SelectedTargetSpeakerIndex
        End Get
        Set(value As Integer)
            If _SelectedTargetSpeakerIndex <> value Then
                _SelectedTargetSpeakerIndex = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SelectedTargetSpeakerIndex)))
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
