Imports System.ComponentModel

Public Class HubertVitsModel
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

    Public ReadOnly Property OpenHubert As New OpenFileCommand(
        Function() HubertPath,
        Sub(it) HubertPath = it,
        "模型文件|*.pt|所有文件|*.*", "打开 HuBERT 模型")

    Dim _HubertPath As String
    Public Property HubertPath As String
        Get
            Return _HubertPath
        End Get
        Set(value As String)
            If _HubertPath <> value Then
                _HubertPath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(HubertPath)))
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

    Public ReadOnly Property OpenOriginalSpeech As New OpenFileCommand(
        Function() OriginalSpeechPath,
        Sub(it) OriginalSpeechPath = it,
        "音频文件|*.wav;*.mp3;*.ogg;*.opus", "打开原音频")

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

    Public ReadOnly Property LanguageTransform As New HubertVitsLanguageTransformModel
    Public ReadOnly Property SpeechTransform As New HubertVitsSpeechTransformModel

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

End Class
