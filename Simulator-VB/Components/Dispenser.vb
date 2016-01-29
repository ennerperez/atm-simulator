Public Class Dispenser

    Private Sub _EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        Me.PanelStatus.BackColor = IIf(Me.Enabled, Color.LimeGreen, Color.Red)
    End Sub

End Class
