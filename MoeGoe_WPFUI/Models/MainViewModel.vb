Imports System.ComponentModel

Public Class MainViewModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property OpenMoeGoe As ICommand

    Dim _MoeGoeExePath As String
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
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(UsageSelectedIndex)))
            End If
        End Set
    End Property

    Public ReadOnly Property Vits As New VitsModel
    Public ReadOnly Property HubertVits As New HubertVitsModel
    Public ReadOnly Property W2V2Vits As New W2V2VitsModel

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
