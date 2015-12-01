Public Class FormATM

    Private IsShuttingDown As Boolean = False
    Public Sub Shutdown()
        CardReader.EjectCard()
        Me.IsShuttingDown = True
        Me.TimerCounterOn.Stop()
        Console.WriteLine("Apagando ATM")
        Me.MultiPanelScreen.SelectedPage = PageShutdown
        Me.Enabled = False
        Me.TimerShutdown.Start()
    End Sub

    Public Sub Restart()
        CardReader.EjectCard()
        Me.TimerCounterOn.Stop()
        Console.WriteLine("Reiniciando ATM")
        Me.MultiPanelScreen.SelectedPage = PageRestart
        Me.Enabled = False
        Me.TimerRestart.Start()
    End Sub

    Private Sub TimerReinicio_Tick(sender As Object, e As EventArgs) Handles TimerRestart.Tick
        Me.TimerRestart.Stop()
        Console.WriteLine("Iniciando ATM")
        Me.MultiPanelScreen.SelectedPage = PageWelcome
        Me.Enabled = True
        Me.TimerCounterOn.Start()
    End Sub

    Private Sub TimerShutdown_Tick(sender As Object, e As EventArgs) Handles TimerShutdown.Tick
        Program.SaveDefinition()
        Me.Close()
    End Sub

    Private Sub FormATM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Program.Load()
    End Sub

    Private Sub TimerCounterOn_Tick(sender As Object, e As EventArgs) Handles TimerCounterOn.Tick
        Program.Definition.Active = Program.Definition.Active.Add(New TimeSpan(0, 0, 1))
        FormConfig.LabelTimeOn.Text = Program.Definition.Active.ToString()
    End Sub

    Private Sub FormATM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.IsShuttingDown Then
            e.Cancel = True
            Me.Shutdown()
        End If
    End Sub

    Private Sub CardReader_CardInserted(sender As Object, e As EventArgs) Handles CardReader.CardInserted
        Dim card As Models.Card = (From client In Program.Clients
                                   From item In client.Cards
                                   Where item.Number = CardReader.Number
                                   Select item).FirstOrDefault

        Me.MultiPanelScreen.SelectedPage = PagePassword
        Me.LabelSecretPassword.Text = Me.LabelSecretPassword.Tag & vbCrLf

        Me.TimerPassword.Start()

    End Sub

    Private Sub TimerPassword_Tick(sender As Object, e As EventArgs) Handles TimerPassword.Tick
        Me.CardReader.EjectCard()
    End Sub

    Private Sub CardReader_CardEjected(sender As Object, e As EventArgs) Handles CardReader.CardEjected
        Me.TimerPassword.Stop()
        Me.KeyPad.Valor = Nothing
        Me.MultiPanelScreen.SelectedPage = PageWelcome
    End Sub

    Private Sub KeyPad_Pressed(sender As Object, e As EventArgs) Handles KeyPad.Pressed, KeyPad.Fix
        Select Case Me.MultiPanelScreen.SelectedPage.Name
            Case Me.PagePassword.Name
                Me.LabelSecretPassword.Text = Me.LabelSecretPassword.Tag & vbCrLf & StrDup(KeyPad.Valor.Length, "*")
        End Select
    End Sub

    Private Sub KeyPad_Cancel(sender As Object, e As EventArgs) Handles KeyPad.Cancel
        CardReader.EjectCard()
    End Sub

    Private Sub KeyPad_Confirm(sender As Object, e As EventArgs) Handles KeyPad.Confirm
        Select Case Me.MultiPanelScreen.SelectedPage.Name
            Case Me.PagePassword.Name
                Me.TimerPassword.Stop()
                Me.MultiPanelScreen.SelectedPage = PageMainMenu
        End Select
    End Sub

    Private Sub ScreenPadRight_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScreenPadRight_Pressed(sender As Object, e As EventArgs) Handles ScreenPadRight.Pressed
        Select Case Me.MultiPanelScreen.SelectedPage.Name
            Case Me.PageMainMenu.Name
                Select Case Me.ScreenPadRight.ActionPressed
                    Case 1 ' Saldo
                        If Program.Definition.Receipts > 0 Then
                            Me.Printer.Receipt = New Models.Receipt()
                            With Me.Printer.Receipt
                                .Bank = Program.Definition.Bank
                                .Date = Now
                                .ATM = Program.Definition.Code
                                .Code = Now.Ticks.ToString
                                .Card = Me.CardReader.Number
                                .Operation = "CONSULTA DE SALDO"
                                .Account = Me.CardReader.Number
                                .Detail = "SU SALDO ES: 0.00"
                            End With
                            Me.Printer.Print()
                            Program.Definition.Receipts -= 1
                            SaveDefinition()
                        End If
                    Case 3 ' Retiro
                    Case 4 ' Retiro rapido
                End Select
        End Select
    End Sub


End Class
