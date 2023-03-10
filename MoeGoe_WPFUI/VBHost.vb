Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Public Class WpfVBHost
    Implements IVbHost

    Public Shared ReadOnly Property Instance As New WpfVBHost

    Private _CurrentWindow As Window
    Private _CurrentWin32Window As IWin32Window

    Public Property CurrentWindow As Window
        Get
            Return _CurrentWindow
        End Get
        Set(value As Window)
            If _CurrentWindow IsNot value Then
                _CurrentWindow = value
                If value Is Nothing Then
                    _CurrentWin32Window = Nothing
                Else
                    _CurrentWin32Window = New WinUIWin32Window(value)
                End If
            End If
        End Set
    End Property

    Public Function GetParentWindow() As IWin32Window Implements IVbHost.GetParentWindow
        Return _CurrentWin32Window
    End Function

    Public Function GetWindowTitle() As String Implements IVbHost.GetWindowTitle
        Return CurrentWindow?.Title
    End Function

    Private Class WinUIWin32Window
        Implements IWin32Window

        Private ReadOnly _window As Window
        Private ReadOnly _windowInterop As Interop.WindowInteropHelper

        Public Sub New(value As Window)
            _window = value
            _windowInterop = New Interop.WindowInteropHelper(_window)
        End Sub

        Public ReadOnly Property Handle As IntPtr Implements IWin32Window.Handle
            Get
                Return _windowInterop.Handle
            End Get
        End Property
    End Class
End Class
