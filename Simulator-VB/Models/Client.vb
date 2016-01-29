Namespace Models

    Public Class Client

        Sub New()
            Accounts = New List(Of Account)
            Cards = New List(Of Card)
        End Sub

        Public Property Name As String
        Public Property Identification As String

        Public Property Accounts As List(Of Account)

        Public Property Cards As List(Of Card)

        Public Overrides Function ToString() As String
            Return Me.Name & ";" & Me.Identification
        End Function

    End Class

End Namespace