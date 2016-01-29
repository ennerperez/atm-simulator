Public Class ClientEditor

    Public Property Client As Models.Client

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ' Grids
        Me.DataGridViewAccounts.AutoGenerateColumns = False
        Me.DataGridViewCards.AutoGenerateColumns = False

        Me.Client = New Models.Client

    End Sub

    Sub New(client As Models.Client)
        Me.New()
        Me.Client = client
    End Sub

    Private Sub ClientEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TextBoxFullName.Text = Client.Name
        Me.TextBoxIdentification.Text = Client.Identification
        Me.DataGridViewAccounts.DataSource = Client.Accounts
        Me.DataGridViewCards.DataSource = Client.Cards
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Parent.Controls.Remove(Me)
        Me.Dispose()
    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click
        'SAVE
        RaiseEvent Saved(Me.Client, EventArgs.Empty)
        Me.ButtonCancel.PerformClick()
    End Sub

    Public Event Saved As EventHandler

    Private Sub TabControlClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlClient.SelectedIndexChanged
        If Me.TabControlClient.SelectedTab Is Me.TabPageCards Then
            Me.CollumnCardAccount1.DataSource = (From item In Client.Accounts
                                                 Where item.Type = "Ahorro"
                                                 Select item).ToList
            Me.CollumnCardAccount1.DisplayMember = "Number"
            Me.CollumnCardAccount1.ValueMember = "Number"
            Me.CollumnCardAccount2.DataSource = (From item In Client.Accounts
                                                 Where item.Type = "Corriente"
                                                 Select item).ToList
            Me.CollumnCardAccount2.DisplayMember = "Number"
            Me.CollumnCardAccount2.ValueMember = "Number"
        End If
    End Sub

    Private Sub DataGridViewCards_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridViewCards.DataError

    End Sub
End Class
