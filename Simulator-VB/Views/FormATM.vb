Public Class FormATM

    Private IsShuttingDown As Boolean = False
    Public Sub Shutdown()
        CardReader.EjectCard()
        Me.IsShuttingDown = True
        Me.TimerCounterOn.Stop()
        Console.WriteLine("Apagando ATM")
        Dim action As New ScreenAction(ScreenType.Response)
        action.Color = SystemColors.ControlDarkDark
        action.Name = "Shutdown"
        action.Text = "Este cajero esta fuera de servicio."
        Me.ScreenMain.SetScreenAction(action)

        'Me.MultiPanelScreen.SelectedPage = PageShutdown
        Me.Enabled = False
        Me.TimerShutdown.Start()
    End Sub

    Public Sub Restart()
        CardReader.EjectCard()
        Me.TimerCounterOn.Stop()
        Console.WriteLine("Reiniciando ATM")
        Dim action As New ScreenAction(ScreenType.Response)
        action.Color = SystemColors.ControlDarkDark
        action.Name = "Shutdown"
        action.Text = "Este cajero esta fuera de servicio."
        Me.ScreenMain.SetScreenAction(action)
        'Me.MultiPanelScreen.SelectedPage = PageRestart
        Me.Enabled = False
        Me.TimerRestart.Start()
    End Sub

#Region "Timers"

    Private Sub TimerReinicio_Tick(sender As Object, e As EventArgs) Handles TimerRestart.Tick
        Me.TimerRestart.Stop()
        Console.WriteLine("Iniciando ATM")
        Dim action As New ScreenAction(ScreenType.Response)
        action.Color = Color.FromArgb(56, 142, 60)
        action.Name = "Welcome"
        action.Text = "Bienvenido, para comenzar introduzca su tarjeta."
        Me.ScreenMain.SetScreenAction(action)
        'Me.MultiPanelScreen.SelectedPage = PageWelcome
        Me.Enabled = True
        Me.TimerCounterOn.Start()
    End Sub

    Private Sub TimerShutdown_Tick(sender As Object, e As EventArgs) Handles TimerShutdown.Tick
        Program.SaveDefinition()
        Me.Close()
    End Sub

    Private Sub TimerCounterOn_Tick(sender As Object, e As EventArgs) Handles TimerCounterOn.Tick
        Program.Definition.Active = Program.Definition.Active.Add(New TimeSpan(0, 0, 1))
        FormConfig.LabelTimeOn.Text = Program.Definition.Active.ToString()
    End Sub

    Private Sub TimerPassword_Tick(sender As Object, e As EventArgs) Handles TimerPassword.Tick
        Me.CardReader.EjectCard()
    End Sub

#End Region

    Private Sub FormATM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Program.Load()
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

        Dim action As New ScreenAction(ScreenType.Request)
        action.Color = Color.FromArgb(245, 124, 0)
        action.Name = "Password"
        action.Text = "Ingrese su clave secreta."
        Me.ScreenMain.SetScreenAction(action)
        'Me.MultiPanelScreen.SelectedPage = PagePassword
        'Me.LabelSecretPassword.Text = Me.LabelSecretPassword.Tag & vbCrLf
        Me.TimerPassword.Start()

    End Sub
    Private Sub CardReader_CardEjected(sender As Object, e As EventArgs) Handles CardReader.CardEjected
        Me.TimerPassword.Stop()
        Me.KeyPad.Value = Nothing
        Dim action As New ScreenAction(ScreenType.Response)
        action.Color = Color.FromArgb(56, 142, 60)
        action.Name = "Welcome"
        action.Text = "Bienvenido, para comenzar introduzca su tarjeta."
        Me.ScreenMain.SetScreenAction(action)
        'Me.MultiPanelScreen.SelectedPage = PageWelcome
    End Sub

    Private Sub KeyPad_Pressed(sender As Object, e As EventArgs) Handles KeyPad.Pressed, KeyPad.Fix
        Select Case Me.ScreenMain.Action.Name
            Case "Password"
                Me.ScreenMain.AppendScreenText(StrDup(KeyPad.Value.Length, "*"))
                'Me.LabelSecretPassword.Text = Me.LabelSecretPassword.Tag & vbCrLf & StrDup(KeyPad.Valor.Length, "*")
        End Select
    End Sub
    Private Sub KeyPad_Cancel(sender As Object, e As EventArgs) Handles KeyPad.Cancel
        CardReader.EjectCard()
    End Sub
    Private Sub KeyPad_Confirm(sender As Object, e As EventArgs) Handles KeyPad.Confirm
        Select Case Me.ScreenMain.Action.Name
            Case "Password"

                Dim action As New ScreenAction(ScreenType.None)

                'Validation de contraseñas
                If Program.ValidateCard(Me.CardReader.Number, KeyPad.Value.GetHashCode) Then
                    Me.TimerPassword.Stop()
                    action = New ScreenAction(ScreenType.Menu)
                    With DirectCast(action.Actions, List(Of String))
                        .Item(0) = "Cambio de clave"
                        .Item(4) = "Consulta de saldo"
                        .Item(6) = "Retiro"
                        .Item(7) = "Retiro rápido"
                    End With
                    action.Name = "Menu"
                    action.Color = SystemColors.MenuHighlight
                Else
                    action = New ScreenAction(ScreenType.Response)
                    action.Name = "Error:Password"
                    action.Text = "Clave invalida."
                    action.Color = Color.FromArgb(230, 74, 25)
                End If

                Me.ScreenMain.SetScreenAction(action)

                'Me.MultiPanelScreen.SelectedPage = PageMainMenu
        End Select
    End Sub

    Private Sub ScreenMain_Pressed(sender As Object, e As EventArgs) Handles ScreenMain.Pressed
        Select Case Me.ScreenMain.Action.Name
            Case "Menu"
                Select Case ScreenMain.ActionPressed
                    Case 5 'Consulta de saldo
                        Dim action As New ScreenAction(ScreenType.Request)
                        action.Name = "Balance:Account"
                        action.Text = "Seleccione una cuenta"
                        With DirectCast(action.Actions, List(Of String))
                            Dim card = Program.GetCard(Me.CardReader.Number, KeyPad.Value.GetHashCode)
                            .Item(7) = card.Account1
                            .Item(6) = card.Account2
                        End With
                        Me.ScreenMain.SetScreenAction(action)
                End Select
            Case "Balance:Account"
                If Program.Definition.Receipts > 0 Then

                    Dim card = Program.GetCard(Me.CardReader.Number, KeyPad.Value.GetHashCode)
                    Dim account As Models.Account = Nothing

                    Select Case ScreenMain.ActionPressed
                        Case 8 'Primaria
                            account = Program.GetAccount(card, 0)
                        Case 7 'Secundaria
                            account = Program.GetAccount(card, 1)
                    End Select

                    If account IsNot Nothing Then
                        Me.Printer.Receipt = New Models.Receipt()
                        With Me.Printer.Receipt
                            .Bank = account.Bank
                            .Date = Now
                            .ATM = Program.Definition.Code
                            .Code = Now.Ticks.ToString
                            .Card = Me.CardReader.Number
                            .Operation = "CONSULTA DE SALDO"
                            .Account = account.Number
                            .Detail = String.Format("SU SALDO ES: {0:c}", account.Balance)
                        End With
                        Me.Printer.Print()
                        Program.Definition.Receipts -= 1
                        SaveDefinition()

                        Dim action As New ScreenAction(ScreenType.Response)
                        action.Name = "Success:Receipts"
                        action.Text = "Retire su comprobante."
                        action.Color = SystemColors.MenuHighlight
                        Me.ScreenMain.SetScreenAction(action)

                    Else
                        Dim action As New ScreenAction(ScreenType.Response)
                        action.Name = "Error:Account"
                        action.Text = "No se puede consultar la cuenta."
                        action.Color = Color.FromArgb(230, 74, 25)
                        Me.ScreenMain.SetScreenAction(action)
                    End If
                Else
                    Dim action As New ScreenAction(ScreenType.Response)
                    action.Name = "Error:Receipts"
                    action.Text = "No se puede imprimir el recibo."
                    action.Color = Color.FromArgb(230, 74, 25)
                    Me.ScreenMain.SetScreenAction(action)
                End If
                Me.CardReader.EjectCard()
        End Select
    End Sub

    'Private Sub ScreenPadRight_Pressed(sender As Object, e As EventArgs)
    '    Select Case Me.MultiPanelScreen.SelectedPage.Name
    '        Case Me.PageMainMenu.Name
    '            Select Case Me.ScreenPadRight.ActionPressed
    '                Case 1 ' Saldo
    '                    Me.MultiPanelScreen.SelectedPage = PageAccountType

    '                    'If Program.Definition.Receipts > 0 Then
    '                    '    Me.Printer.Receipt = New Models.Receipt()
    '                    '    With Me.Printer.Receipt
    '                    '        .Bank = Program.Definition.Bank
    '                    '        .Date = Now
    '                    '        .ATM = Program.Definition.Code
    '                    '        .Code = Now.Ticks.ToString
    '                    '        .Card = Me.CardReader.Number
    '                    '        .Operation = "CONSULTA DE SALDO"
    '                    '        .Account = Me.CardReader.Number
    '                    '        .Detail = "SU SALDO ES: 0.00"
    '                    '    End With
    '                    '    Me.Printer.Print()
    '                    '    Program.Definition.Receipts -= 1
    '                    '    SaveDefinition()
    '                    'End If
    '                Case 3 ' Retiro
    '                Case 4 ' Retiro rapido
    '            End Select
    '    End Select
    'End Sub

End Class
