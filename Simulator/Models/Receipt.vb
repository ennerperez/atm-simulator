Imports System.Text

Namespace Models

    Public Class Receipt

        Public Property Bank As String

        Public Property ATM As String

        Public Property Code As String

        Public Property Card As String

        Public Property Operation As String

        Public Property Account As String

        Public Property [Date] As DateTime

        Public Property Detail As String

        'Public Overrides Function ToString() As String
        '    Dim _result As New StringBuilder()

        '    Dim _body As String =
        '    vbTab & vbTab & "{0}" & vbCrLf &
        '    vbTab & "{1}" & vbCrLf &
        '    "{2}" & vbCrLf


        '    _result.Append(vbTab & vbTab & Me.Bank & vbCrLf)
        '    _result.Append(vbTab & Me.ATM & vbTab & Me.Code)

        '    _result.Append(Me.Date.ToString)

        '    Return _result.ToString
        'End Function

    End Class

End Namespace