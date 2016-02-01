Public Class CardReader

    Private _Number As String
    Public ReadOnly Property Number As String
        Get
            Return _Number
        End Get
    End Property

    Public ReadOnly Property IsCardInserted As Boolean
        Get
            Return Not String.IsNullOrEmpty(_Number)
        End Get
    End Property

    Public Event CardInserted As EventHandler
    Protected Sub OnCardInserted(sender As Object, e As EventArgs)
        Me.PanelCard.Visible = True
        Me.PanelReader.BackColor = SystemColors.ControlDarkDark
        RaiseEvent CardInserted(Me, e)
    End Sub

    Public Sub EjectCard()
        Console.WriteLine("Expulsando tarjeta")
        OnCardEjected(Me, EventArgs.Empty)
    End Sub

    Public Event CardEjected As EventHandler
    Protected Sub OnCardEjected(sender As Object, e As EventArgs)
        _Number = Nothing
        Me.PanelCard.Visible = False
        Me.PanelReader.BackColor = SystemColors.ControlDark
        RaiseEvent CardEjected(Me, e)
    End Sub

    Private Sub CardReader_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If Not IsCardInserted Then
            _Number = e.Data.GetData(DataFormats.Text).ToString()
            Console.WriteLine("Leyendo tarjeta: " & _Number)
            OnCardInserted(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub CardReader_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) And Not IsCardInserted Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PanelCard_Click(sender As Object, e As EventArgs) Handles PanelCard.Click
        OnCardEjected(Me, EventArgs.Empty)
    End Sub

End Class
