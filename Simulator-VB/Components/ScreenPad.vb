Public Class ScreenPad

    Private _ActionPressed As Integer
    Public ReadOnly Property ActionPressed As Integer
        Get
            Return _ActionPressed
        End Get
    End Property

    Public Event Pressed As EventHandler

    Private Sub ButtonAction_Click(sender As Object, e As EventArgs) Handles ButtonAction4.Click, ButtonAction3.Click, ButtonAction2.Click, ButtonAction1.Click
        _ActionPressed = CInt(sender.Tag)
        RaiseEvent Pressed(Me, EventArgs.Empty)
    End Sub
End Class
