Public Class AmountControl

    Private _Value As Integer = 0
    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(value As Integer)
            If _Value <> value Then
                _Value = value
                OnValueChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Private _Minimum As Integer = 0
    Public Property Minimum As Integer
        Get
            Return _Minimum
        End Get
        Set(value As Integer)
            If _Minimum <> value Then
                _Minimum = value
                OnMinimumChanged(EventArgs.Empty)
            End If
        End Set
    End Property
    Private _Maximum As Integer = 100
    Public Property Maximum As Integer
        Get
            Return _Maximum
        End Get
        Set(value As Integer)
            If _Maximum <> value Then
                _Maximum = value
                OnMaximumChanged(EventArgs.Empty)
            End If
        End Set
    End Property

#Region "Events"

    Private Sub OnMinimumChanged(e As EventArgs)
        Me.NumericUpDownAmount.Minimum = Me.Minimum
        Me.TrackBarAmount.Minimum = Me.Minimum
    End Sub

    Private Sub OnMaximumChanged(e As EventArgs)
        Me.NumericUpDownAmount.Maximum = Me.Maximum
        Me.TrackBarAmount.Maximum = Me.Maximum
    End Sub

    Private Sub OnValueChanged(e As EventArgs)
        Me.NumericUpDownAmount.Value = Me.Value
        Me.TrackBarAmount.Value = Me.Value
        RaiseEvent ValueChanged(Me, EventArgs.Empty)
    End Sub

    Public Event ValueChanged As EventHandler

#End Region

    Public Function Percent() As Double
        Return Me.Value * 100 / Me.Maximum
    End Function

    Private Sub TrackBarAmount_Scroll(sender As Object, e As EventArgs) Handles TrackBarAmount.Scroll
        Me.Value = sender.Value
        Me.NumericUpDownAmount.Value = Me.Value
    End Sub

    Private Sub NumericUpDownAmount_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownAmount.ValueChanged
        Me.Value = sender.Value
        Me.TrackBarAmount.Value = Me.Value
    End Sub
End Class
