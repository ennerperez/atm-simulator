Imports System.Text

Public Class Printer

    Public Property Receipt As Models.Receipt

    Public Sub Print()
        Me.PanelStatus.BackColor = Color.Orange
        Me.TimerPrinting.Start()
    End Sub

    Public Sub Discart()
        Me.PanelStatus.BackColor = IIf(Me.Enabled, Color.LimeGreen, Color.Red)
        Me.Receipt = Nothing
        Me.PanelPaper.Visible = False
    End Sub

    Private Sub TimerDiscart_Tick(sender As Object, e As EventArgs) Handles TimerDiscart.Tick
        Me.Discart()
        Me.TimerDiscart.Stop()
    End Sub

    Private Sub TimerPrinting_Tick(sender As Object, e As EventArgs) Handles TimerPrinting.Tick
        Me.PanelPaper.Visible = True
        Me.TimerPrinting.Stop()
        Me.TimerDiscart.Start()
    End Sub

    Private Sub Paper_Click(sender As Object, e As EventArgs) Handles PanelPaper.Click, LabelPaper.Click
        Dim _ReceiptPreview As New Form
        With _ReceiptPreview

            .FormBorderStyle = FormBorderStyle.FixedSingle
            .StartPosition = FormStartPosition.CenterScreen
            .Icon = Me.FindForm.Icon
            .Padding = New Padding(3)
            .Size = New Size(240, 320)
            .MaximizeBox = False

            Dim _receipt As New Panel
            _receipt.Padding = New Padding(6)
            _receipt.BackColor = Color.White
            _receipt.Font = New Font("Consolas", 8)
            _receipt.BorderStyle = BorderStyle.FixedSingle
            _receipt.Dock = DockStyle.Fill
            _receipt.Controls.Add(New Label() With {.Dock = DockStyle.Fill, .AutoSize = False, .Text = Generate(Me.Receipt)})

            .Controls.Add(_receipt)

            .Show()

        End With
        Me.Discart()
    End Sub

    Private Function SecureIt(source As String, Optional chr As Char = "+", Optional visible As Integer = 4) As String
        If source.Length > visible Then
            Dim hiddend = source.Substring(0, source.Length - visible).Length
            Return StrDup(hiddend, chr) & source.Substring(hiddend)
        Else
            Return source
        End If
    End Function


    Public Function Generate(source As Models.Receipt) As String
        Dim _template As String = My.Resources.Receipt

        Dim _result As String = _template _
            .Replace("{BANK}", source.Bank) _
            .Replace("{ATM}", source.ATM) _
            .Replace("{CODE}", source.Code) _
            .Replace("{DATE}", source.Date.ToShortDateString) _
            .Replace("{TIME}", source.Date.ToShortTimeString) _
            .Replace("{CARD}", SecureIt(source.Card)) _
            .Replace("{OPERATION}", source.Operation) _
            .Replace("{ACCOUNT}", SecureIt(source.Account)) _
            .Replace("{DETAIL}", source.Detail)

        Return _result
    End Function

    Private Sub _EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        Me.PanelStatus.BackColor = IIf(Me.Enabled, Color.LimeGreen, Color.Red)
    End Sub

End Class
