Namespace Models

    Public Class Card

        Public Property Number As String
        Public Property Password As String

        Public Property Hash As String

        Public Property Bank As String

        Public Property Exp As Date

        Public Property Locked As Boolean

        Public Function IsExpired() As Boolean
            Return Exp.Date.Subtract(Now.Date).Days <= 0
        End Function

        Public Property Account1 As String
        Public Property Account2 As String

    End Class

End Namespace