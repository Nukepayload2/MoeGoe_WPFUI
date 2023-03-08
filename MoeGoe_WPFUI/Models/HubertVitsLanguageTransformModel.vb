Imports System.ComponentModel

Public Class HubertVitsLanguageTransformModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property Output As New SpeechOutputModel

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

    Public ReadOnly Property ShowAdvancedSettings As ICommand

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
