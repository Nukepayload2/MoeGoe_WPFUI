Imports System.ComponentModel
Imports System.Text.Json.Serialization

Public Class VitsModel
    Implements INotifyPropertyChanged

    Private ReadOnly _parent As MainViewModel

    Public Sub New(mainViewModel As MainViewModel)
        _parent = mainViewModel
    End Sub

    Public ReadOnly Property OpenModel As New OpenFileCommand(
        Function() ModelPath,
        Sub(it) ModelPath = it,
        "模型文件|*.pth|所有文件|*.*", "打开 VITS 模型")

    Dim _ModelPath As String
    <JsonInclude>
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

    Public ReadOnly Property OpenConfig As New OpenFileCommand(
        Function() ConfigPath,
        Sub(it) ConfigPath = it,
        "配置文件|*.json", "打开 VITS 配置文件")

    Dim _ConfigPath As String
    <JsonInclude>
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
                _parent.UpdateActiveOutput()
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(UsageSelectedIndex)))
            End If
        End Set
    End Property

    Public ReadOnly Property TextToSpeech As New VitsTextToSpeechModel
    Public ReadOnly Property SpeechToSpeech As New VitsSpeechTransformModel

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
