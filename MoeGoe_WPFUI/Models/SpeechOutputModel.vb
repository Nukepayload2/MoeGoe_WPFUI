Imports System.ComponentModel

Public Class SpeechOutputModel
    Implements INotifyPropertyChanged

    Dim _LastGeneratedOutput As Byte()
    Public Property LastGeneratedOutput As Byte()
        Get
            Return _LastGeneratedOutput
        End Get
        Set(value As Byte())
            If _LastGeneratedOutput IsNot value Then
                _LastGeneratedOutput = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(LastGeneratedOutput)))
            End If
        End Set
    End Property

    Public ReadOnly Property SaveAs As ICommand

    Dim _SaveFilePath As String
    Public Property SaveFilePath As String
        Get
            Return _SaveFilePath
        End Get
        Set(value As String)
            If _SaveFilePath <> value Then
                _SaveFilePath = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SaveFilePath)))
            End If
        End Set
    End Property

    Public ReadOnly Property Save As ICommand
    Public ReadOnly Property Delete As ICommand
    Public ReadOnly Property Play As ICommand
    Public ReadOnly Property StopPlaying As ICommand

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
