Imports System.IO
Imports System.Xml.Serialization
Imports Newtonsoft.Json

Public Class FormConfig

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.LabelTitle.Text = My.Application.Info.Description

        ' Bindings
        Me.CurrencyBox1.DataBindings.Add("Value", Program.Definition.Boxes(0), "Value", False, DataSourceUpdateMode.Never)
        Me.CurrencyBox1.DataBindings.Add("Amount", Program.Definition.Boxes(0), "Amount", False, DataSourceUpdateMode.Never)

        Me.CurrencyBox2.DataBindings.Add("Value", Program.Definition.Boxes(1), "Value", False, DataSourceUpdateMode.Never)
        Me.CurrencyBox2.DataBindings.Add("Amount", Program.Definition.Boxes(1), "Amount", False, DataSourceUpdateMode.Never)

        Me.CurrencyBox3.DataBindings.Add("Value", Program.Definition.Boxes(2), "Value", False, DataSourceUpdateMode.Never)
        Me.CurrencyBox3.DataBindings.Add("Amount", Program.Definition.Boxes(2), "Amount", False, DataSourceUpdateMode.Never)

        Me.CurrencyBox4.DataBindings.Add("Value", Program.Definition.Boxes(3), "Value", False, DataSourceUpdateMode.Never)
        Me.CurrencyBox4.DataBindings.Add("Amount", Program.Definition.Boxes(3), "Amount", False, DataSourceUpdateMode.Never)

        ' General
        Me.LabelOpen.Text = String.Format("{0:C}", 0)
        Me.LabelAvailable.Text = String.Format("{0:C}", 0)
        Me.LabelDisposed.Text = String.Format("{0:C}", 0)

    End Sub

    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ToolTipMain.SetToolTip(PictureBoxCC, My.Application.Info.Copyright)
    End Sub

    Private Sub FormConfig_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.TextBoxCode.Text = Program.Definition.Code
        Me.TextBoxBank.Text = Program.Definition.Bank

        ButtonRestore_Click(sender, e)

        ' General

        Dim _cards = From client In Program.Clients
                     From card In client.Cards
                     Where card.Account1 IsNot Nothing Or card.Account2 IsNot Nothing
                     Select card
        Dim _accounts = From client In Program.Clients
                        From account In client.Accounts
                        Select account

        Me.LabelClients.Text = Program.Clients.Count
        Me.LabelAccounts.Text = _accounts.Count
        Me.LabelCards.Text = _cards.Count

        Me.LabelOpen.Text = Me.LabelAvailable.Text

        'Where Not card.IsExpired

        Me.ListViewCards.Clear()

        For Each item As Models.Card In _cards
            Dim _lvcard As New ListViewItem(item.Number)
            _lvcard.ImageIndex = IIf(item.IsExpired, 0, 1)
            Me.ListViewCards.Items.Add(_lvcard)
        Next

        ' Clients & Accounts

        Me.ListViewClients.Clear()

        For Each item As Models.Client In Program.Clients
            Dim _lvcard As New ListViewItem(item.Name)
            _lvcard.SubItems.Add(item.Identification)
            _lvcard.ImageIndex = 0
            Me.ListViewClients.Items.Add(_lvcard)
        Next

    End Sub

    Private Sub CurrencyBox_ValueChanged(sender As Object, e As EventArgs) _
        Handles CurrencyBox1.ValueChanged, CurrencyBox2.ValueChanged, CurrencyBox3.ValueChanged, CurrencyBox4.ValueChanged

        Me.LabelAvailablePreview.Text = String.Format("{0:C}", Me.GroupBoxCurrencyBoxes.Controls.OfType(Of CurrencyBox).Sum(Function(c) c.Total))

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        If MessageBox.Show("¿Desea reiniciar el ATM para aplicar los cambios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FormATM.Restart()

            With Program.Definition

                .Boxes(0).Value = Me.CurrencyBox1.Value
                .Boxes(0).Amount = Me.CurrencyBox1.Amount

                .Boxes(1).Value = Me.CurrencyBox2.Value
                .Boxes(1).Amount = Me.CurrencyBox2.Amount

                .Boxes(2).Value = Me.CurrencyBox3.Value
                .Boxes(2).Amount = Me.CurrencyBox3.Amount

                .Boxes(3).Value = Me.CurrencyBox4.Value
                .Boxes(3).Amount = Me.CurrencyBox4.Amount

                .Receipts = Me.AmountControlReceipts.Value

            End With

            Program.SaveDefinition()

            ' General
            Me.LabelAvailablePreview.Text = String.Format("{0:C}", Me.GroupBoxCurrencyBoxes.Controls.OfType(Of CurrencyBox).Sum(Function(c) c.Total))
            Me.LabelAvailable.Text = Me.LabelAvailablePreview.Text
            Me.LabelReceiptsGeneral.Text = Me.AmountControlReceipts.Value

        End If
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click

        With Program.Definition

            Me.CurrencyBox1.Value = .Boxes(0).Value
            Me.CurrencyBox1.Amount = .Boxes(0).Amount

            Me.CurrencyBox2.Value = .Boxes(1).Value
            Me.CurrencyBox2.Amount = .Boxes(1).Amount

            Me.CurrencyBox3.Value = .Boxes(2).Value
            Me.CurrencyBox3.Amount = .Boxes(2).Amount

            Me.CurrencyBox4.Value = .Boxes(3).Value
            Me.CurrencyBox4.Amount = .Boxes(3).Amount

            Me.AmountControlReceipts.Value = .Receipts

        End With

        ' General
        Me.LabelAvailablePreview.Text = String.Format("{0:C}", Me.GroupBoxCurrencyBoxes.Controls.OfType(Of CurrencyBox).Sum(Function(c) c.Total))
        Me.LabelAvailable.Text = Me.LabelAvailablePreview.Text
        Me.LabelReceiptsGeneral.Text = Me.AmountControlReceipts.Value

    End Sub

    Private Sub ListViewCards_DoubleClick(sender As Object, e As EventArgs) Handles ListViewCards.DoubleClick
        If Me.ListViewCards.SelectedItems.Count = 1 Then
            Dim _item = Me.ListViewCards.SelectedItems(0)

            Dim _card = (From client In Program.Clients
                         From card In client.Cards
                         Where card.Number = _item.Text
                         Select card).FirstOrDefault

            If _card IsNot Nothing AndAlso Not _card.IsExpired Then

                Dim _client = (From client In Program.Clients
                               From card In client.Cards
                               Where card.Number = _card.Number
                               Select client).FirstOrDefault


                Dim _bank = (From client In Program.Clients
                             From account In client.Accounts
                             Where (_card.Account1 IsNot Nothing AndAlso _card.Account1.Contains(account.Number)) OrElse
                                 (_card.Account2 IsNot Nothing AndAlso _card.Account2.Contains(account.Number))
                             Select account.Bank).FirstOrDefault

                _card.Bank = _bank

                Dim _cardControlView As New Card(_card)
                _cardControlView.Dock = DockStyle.Fill

                Dim _cardView As New Form
                _cardView.Icon = Me.Icon
                _cardView.FormBorderStyle = FormBorderStyle.FixedSingle
                _cardView.StartPosition = FormStartPosition.Manual
                _cardView.Text = _client.Name ' _card.Number
                _cardView.MinimizeBox = False
                _cardView.MaximizeBox = False
                _cardView.Controls.Add(_cardControlView)
                _cardView.ClientSize = _cardControlView.Size

                Dim _info As New Panel
                _info.Padding = New Padding(9)
                _info.Dock = DockStyle.Bottom
                _info.Height = 32
                _info.BackColor = SystemColors.Info
                _info.Controls.Add(New Label() With {.TextAlign = ContentAlignment.MiddleRight, .Dock = DockStyle.Right,
                                   .Text = String.Format("{0}{1} - {2}",
                                                         IIf(String.IsNullOrEmpty(_card.Account1), "", "[A]"),
                                                         IIf(String.IsNullOrEmpty(_card.Account2), "", "[C]"),
                                                         _card.Password)})
                _info.Controls.Add(New Label() With {.TextAlign = ContentAlignment.MiddleLeft, .Dock = DockStyle.Fill, .Text = _client.Identification})


                _cardView.Controls.Add(_info)
                _cardView.Height += _info.Height

                _cardView.Show()
                _cardView.Location = New Point(FormATM.Location.X + FormATM.Width + 3, FormATM.Location.Y)

            End If

        End If
    End Sub

    Private Sub LinkLabelRef_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRef1.LinkClicked, LinkLabelRef2.LinkClicked
        Process.Start(sender.Tag)
    End Sub

    Private Sub PictureBoxCC_Click(sender As Object, e As EventArgs) Handles PictureBoxCC.Click
        Process.Start("http://creativecommons.org/licenses/by-nc-sa/4.0/")
    End Sub

    Private Sub ListViewClients_DoubleClick(sender As Object, e As EventArgs) Handles ListViewClients.DoubleClick
        If Me.ListViewClients.SelectedItems.Count = 1 Then
            Dim _identification = Me.ListViewClients.SelectedItems(0).SubItems(1).Text
            Dim _client = (From client In Program.Clients
                           Where client.Identification = _identification).FirstOrDefault

            If _client IsNot Nothing Then

                Dim _editor As New ClientEditor(_client)
                _editor.Dock = DockStyle.Fill
                ListViewClients.Parent.Controls.Add(_editor)
                _editor.BringToFront()
            End If
        End If
    End Sub

    Private Sub ButtonApplyGeneral_Click(sender As Object, e As EventArgs) Handles ButtonApplyGeneral.Click
        If MessageBox.Show("¿Desea reiniciar el ATM para aplicar los cambios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sender.Enabled = False

            FormATM.Restart()

            Program.Definition.Code = Me.TextBoxCode.Text
            Program.Definition.Bank = Me.TextBoxBank.Text

            Program.SaveDefinition()

        End If
    End Sub

    Private EditMode As Boolean = False

    Private Sub ButtonEditGeneral_Click(sender As Object, e As EventArgs) Handles ButtonEditGeneral.Click
        EditMode = Not EditMode
        Dim temp = Me.ButtonEditGeneral.Text
        Me.ButtonEditGeneral.Text = Me.ButtonEditGeneral.Tag
        Me.ButtonEditGeneral.Tag = temp

        If Not EditMode Then
            Me.TextBoxCode.Text = Program.Definition.Code
            Me.TextBoxBank.Text = Program.Definition.Bank
        End If

        Me.TextBoxCode.Enabled = EditMode
        Me.TextBoxBank.Enabled = EditMode
        Me.ButtonApplyGeneral.Enabled = EditMode
    End Sub
End Class