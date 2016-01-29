Namespace Models

    <Serializable()>
    Public Class Box

        Sub New()
        End Sub

        Sub New(value As Double, amount As Integer)
            Me.New()
            Me.Value = value
            Me.Amount = amount
        End Sub

        Public Property Value As Double
        Public Property Amount As Integer

        Public ReadOnly Property SubTotal As Double
            Get
                Return Value * Amount
            End Get
        End Property

    End Class

End Namespace