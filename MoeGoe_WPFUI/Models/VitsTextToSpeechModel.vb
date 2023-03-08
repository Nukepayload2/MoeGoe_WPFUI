Imports System.ComponentModel

Public Class VitsTextToSpeechModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property Output As New SpeechOutputModel

    Dim _VoiceText As String
    Public Property VoiceText As String
        Get
            Return _VoiceText
        End Get
        Set(value As String)
            If _VoiceText <> value Then
                _VoiceText = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(VoiceText)))
            End If
        End Set
    End Property
    Public ReadOnly Property CleanText As ICommand
    Public ReadOnly Property ParamConfig As ICommand
    Public ReadOnly Property SymbolInput As ICommand

    Dim _Speaker As IReadOnlyList(Of String)
    Public Property Speaker As IReadOnlyList(Of String)
        Get
            Return _Speaker
        End Get
        Set(value As IReadOnlyList(Of String))
            If _Speaker IsNot value Then
                _Speaker = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Speaker)))
            End If
        End Set
    End Property

    Dim _SelectedSpeakerIndex As Integer
    Public Property SelectedSpeakerIndex As Integer
        Get
            Return _SelectedSpeakerIndex
        End Get
        Set(value As Integer)
            If _SelectedSpeakerIndex <> value Then
                _SelectedSpeakerIndex = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SelectedSpeakerIndex)))
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
