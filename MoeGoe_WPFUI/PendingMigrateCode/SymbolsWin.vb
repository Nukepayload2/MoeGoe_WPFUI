Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace MoeGoe_GUI
    Public Partial Class SymbolsWin
        Inherits Form
        Public Sub New(symbols As List(Of String), box As TextBox)
            InitializeComponent()
            For Each symbol As String In symbols
                Dim button1 As New Button With
    { _
                .Width = 50,
                .Height = 50,
                .Text = symbol
    }
                AddHandler button1.Click, Sub(sender, e) box.Paste(CType(sender, Button).Text)
                symbolPanel.Controls.Add(button1)
            Next
        End Sub
    End Class
End Namespace
