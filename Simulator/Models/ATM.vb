
Namespace Models

    Public Class ATM

        Public Property Active As TimeSpan

        Public Property Code As String

        Public Property Bank As String

        Public Property Boxes As List(Of Box)

        Public Property Receipts As Integer

        Public Overrides Function ToString() As String
            Return Me.Code & "; " & Me.Bank
        End Function

    End Class

End Namespace