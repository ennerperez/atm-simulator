Public Class KeyPad


    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        For Each item As NumericButton In Me.Controls.OfType(Of NumericButton)
            If item.Enabled Then
                AddHandler item.Click, AddressOf _Pressed
            End If
        Next

    End Sub

    Public Event Pressed As EventHandler

    Private Sub _Pressed(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(Value) OrElse Value.Length < MaxLenght Then
            Value &= DirectCast(sender, NumericButton).Text
            RaiseEvent Pressed(Me, EventArgs.Empty)
        End If
    End Sub


    Public Property MinLenght As Integer = 4
    Public Property MaxLenght As Integer = 4

    Public Property Value As String = String.Empty

    Private Sub _Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        For Each item As NumericButton In Me.Controls.OfType(Of NumericButton)
            If item.Enabled Then
                RemoveHandler item.Click, AddressOf _Pressed
            End If
        Next
    End Sub

#Region "Events"

    Public Event Cancel As EventHandler
    Public Event Fix As EventHandler
    Public Event Confirm As EventHandler
    Public Event [Error] As EventHandler

#End Region

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        RaiseEvent Cancel(Me, EventArgs.Empty)
    End Sub

    Private Sub ButtonFix_Click(sender As Object, e As EventArgs) Handles ButtonFix.Click
        If Not String.IsNullOrEmpty(Value) AndAlso Value.Length > 0 Then
            Value = Value.Substring(0, Value.Length - 1)
        End If
        RaiseEvent Fix(Me, EventArgs.Empty)
    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        If Not String.IsNullOrEmpty(Value) AndAlso Value.Length <= MaxLenght AndAlso Value.Length = MinLenght Then
            RaiseEvent Confirm(Me, EventArgs.Empty)
        Else
            RaiseEvent Error(Me, EventArgs.Empty)
        End If
    End Sub

End Class
