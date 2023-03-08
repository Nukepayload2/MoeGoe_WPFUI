Imports System.ComponentModel

Public Class W2V2VitsModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property OpenModel As ICommand

    Dim _ModelPath As String
    Public Property ModelPath As String
        Get
            Return _ModelPath
        End Get
        Set(value As String)
            If _ModelPath <> value Then
                _ModelPath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(ModelPath)))
            End If
        End Set
    End Property

    Public ReadOnly Property OpenConfig As ICommand

    Dim _ConfigPath As String
    Public Property ConfigPath As String
        Get
            Return _ConfigPath
        End Get
        Set(value As String)
            If _ConfigPath <> value Then
                _ConfigPath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(ConfigPath)))
            End If
        End Set
    End Property

    Public ReadOnly Property OpenW2V2 As ICommand

    Dim _W2V2Path As String
    Public Property W2V2Path As String
        Get
            Return _W2V2Path
        End Get
        Set(value As String)
            If _W2V2Path <> value Then
                _W2V2Path = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(W2V2Path)))
            End If
        End Set
    End Property

    Dim _IsModelConfigReady As Boolean

    Public Property IsModelConfigReady As Boolean
        Get
            Return _IsModelConfigReady
        End Get
        Set(value As Boolean)
            If _IsModelConfigReady <> value Then
                _IsModelConfigReady = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(IsModelConfigReady)))
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

    Public ReadOnly Property TextToSpeech As New W2V2VitsTtsModel
    Public ReadOnly Property SpeechTransform As New W2V2VitsSpeechTransformationModel

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
