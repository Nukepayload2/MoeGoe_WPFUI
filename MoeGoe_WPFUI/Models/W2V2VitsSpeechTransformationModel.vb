Imports System.ComponentModel

Public Class W2V2VitsSpeechTransformationModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property Output As New SpeechOutputModel

    Public ReadOnly Property OpenOriginalSpeech As ICommand

    Dim _OriginalSpeechPath As String
    Public Property OriginalSpeechPath As String
        Get
            Return _OriginalSpeechPath
        End Get
        Set(value As String)
            If _OriginalSpeechPath <> value Then
                _OriginalSpeechPath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(OriginalSpeechPath)))
            End If
        End Set
    End Property

    Dim _OriginalSpeakers As IReadOnlyList(Of String)
    Public Property OriginalSpeakers As IReadOnlyList(Of String)
        Get
            Return _OriginalSpeakers
        End Get
        Set(value As IReadOnlyList(Of String))
            If _OriginalSpeakers IsNot value Then
                _OriginalSpeakers = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(OriginalSpeakers)))
            End If
        End Set
    End Property

    Dim _SelectedOriginalSpeakerIndex As String
    Public Property SelectedOriginalSpeakerIndex As String
        Get
            Return _SelectedOriginalSpeakerIndex
        End Get
        Set(value As String)
            If _SelectedOriginalSpeakerIndex <> value Then
                _SelectedOriginalSpeakerIndex = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SelectedOriginalSpeakerIndex)))
            End If
        End Set
    End Property

    Dim _TargetSpeakers As IReadOnlyList(Of String)
    Public Property TargetSpeakers As IReadOnlyList(Of String)
        Get
            Return _TargetSpeakers
        End Get
        Set(value As IReadOnlyList(Of String))
            If _TargetSpeakers IsNot value Then
                _TargetSpeakers = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(TargetSpeakers)))
            End If
        End Set
    End Property

    Dim _SelectedTargetSpeakerIndex As String

    Public Property SelectedTargetSpeakerIndex As String
        Get
            Return _SelectedTargetSpeakerIndex
        End Get
        Set(value As String)
            If _SelectedTargetSpeakerIndex <> value Then
                _SelectedTargetSpeakerIndex = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SelectedTargetSpeakerIndex)))
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

End Class
