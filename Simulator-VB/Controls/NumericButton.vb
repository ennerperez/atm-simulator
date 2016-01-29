Public Class NumericButton

    Public Property Letters As String

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        If Not String.IsNullOrEmpty(Me.Letters) Then
            pevent.Graphics.DrawString(Me.Letters, New Font(Me.Font.FontFamily, Me.Font.Size / 2), New SolidBrush(Me.ForeColor), New System.Drawing.Point(Me.Padding.Left, Me.Padding.Top))
        End If

    End Sub

End Class
