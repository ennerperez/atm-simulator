<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlClient = New System.Windows.Forms.TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.TextBoxIdentification = New System.Windows.Forms.TextBox()
        Me.TextBoxFullName = New System.Windows.Forms.TextBox()
        Me.LabelIdentification = New System.Windows.Forms.Label()
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.TabPageAccounts = New System.Windows.Forms.TabPage()
        Me.DataGridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.ColumnAccountBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAccountType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnAccountNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAccountBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageCards = New System.Windows.Forms.TabPage()
        Me.DataGridViewCards = New System.Windows.Forms.DataGridView()
        Me.PanelAction = New System.Windows.Forms.Panel()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ColumnBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCardNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollumnCardPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollumnCardExp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollumnCardAccount1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CollumnCardAccount2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TabControlClient.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.TabPageAccounts.SuspendLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCards.SuspendLayout()
        CType(Me.DataGridViewCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlClient
        '
        Me.TabControlClient.Controls.Add(Me.TabPageGeneral)
        Me.TabControlClient.Controls.Add(Me.TabPageAccounts)
        Me.TabControlClient.Controls.Add(Me.TabPageCards)
        Me.TabControlClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlClient.Location = New System.Drawing.Point(0, 0)
        Me.TabControlClient.Name = "TabControlClient"
        Me.TabControlClient.SelectedIndex = 0
        Me.TabControlClient.Size = New System.Drawing.Size(573, 265)
        Me.TabControlClient.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.TextBoxIdentification)
        Me.TabPageGeneral.Controls.Add(Me.TextBoxFullName)
        Me.TabPageGeneral.Controls.Add(Me.LabelIdentification)
        Me.TabPageGeneral.Controls.Add(Me.LabelFullName)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageGeneral.Size = New System.Drawing.Size(511, 239)
        Me.TabPageGeneral.TabIndex = 0
        Me.TabPageGeneral.Text = "Datos"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'TextBoxIdentification
        '
        Me.TextBoxIdentification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIdentification.Location = New System.Drawing.Point(12, 64)
        Me.TextBoxIdentification.Name = "TextBoxIdentification"
        Me.TextBoxIdentification.Size = New System.Drawing.Size(487, 20)
        Me.TextBoxIdentification.TabIndex = 1
        '
        'TextBoxFullName
        '
        Me.TextBoxFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFullName.Location = New System.Drawing.Point(12, 25)
        Me.TextBoxFullName.Name = "TextBoxFullName"
        Me.TextBoxFullName.Size = New System.Drawing.Size(487, 20)
        Me.TextBoxFullName.TabIndex = 1
        '
        'LabelIdentification
        '
        Me.LabelIdentification.AutoSize = True
        Me.LabelIdentification.Location = New System.Drawing.Point(12, 48)
        Me.LabelIdentification.Name = "LabelIdentification"
        Me.LabelIdentification.Size = New System.Drawing.Size(73, 13)
        Me.LabelIdentification.TabIndex = 0
        Me.LabelIdentification.Text = "&Identificación:"
        '
        'LabelFullName
        '
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Location = New System.Drawing.Point(12, 9)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(93, 13)
        Me.LabelFullName.TabIndex = 0
        Me.LabelFullName.Text = "&Nombre completo:"
        '
        'TabPageAccounts
        '
        Me.TabPageAccounts.Controls.Add(Me.DataGridViewAccounts)
        Me.TabPageAccounts.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAccounts.Name = "TabPageAccounts"
        Me.TabPageAccounts.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageAccounts.Size = New System.Drawing.Size(565, 239)
        Me.TabPageAccounts.TabIndex = 1
        Me.TabPageAccounts.Text = "Cuentas"
        Me.TabPageAccounts.UseVisualStyleBackColor = True
        '
        'DataGridViewAccounts
        '
        Me.DataGridViewAccounts.AllowUserToOrderColumns = True
        Me.DataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnAccountBank, Me.ColumnAccountType, Me.ColumnAccountNumber, Me.ColumnAccountBalance})
        Me.DataGridViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAccounts.Location = New System.Drawing.Point(9, 9)
        Me.DataGridViewAccounts.Name = "DataGridViewAccounts"
        Me.DataGridViewAccounts.RowHeadersVisible = False
        Me.DataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAccounts.Size = New System.Drawing.Size(547, 221)
        Me.DataGridViewAccounts.TabIndex = 1
        '
        'ColumnAccountBank
        '
        Me.ColumnAccountBank.DataPropertyName = "Bank"
        Me.ColumnAccountBank.HeaderText = "Banco"
        Me.ColumnAccountBank.Name = "ColumnAccountBank"
        '
        'ColumnAccountType
        '
        Me.ColumnAccountType.DataPropertyName = "Type"
        Me.ColumnAccountType.HeaderText = "Tipo"
        Me.ColumnAccountType.Items.AddRange(New Object() {"Ahorro", "Corriente"})
        Me.ColumnAccountType.Name = "ColumnAccountType"
        Me.ColumnAccountType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ColumnAccountNumber
        '
        Me.ColumnAccountNumber.DataPropertyName = "Number"
        Me.ColumnAccountNumber.HeaderText = "Número"
        Me.ColumnAccountNumber.Name = "ColumnAccountNumber"
        '
        'ColumnAccountBalance
        '
        Me.ColumnAccountBalance.DataPropertyName = "Balance"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColumnAccountBalance.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnAccountBalance.HeaderText = "Balance"
        Me.ColumnAccountBalance.Name = "ColumnAccountBalance"
        '
        'TabPageCards
        '
        Me.TabPageCards.Controls.Add(Me.DataGridViewCards)
        Me.TabPageCards.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCards.Name = "TabPageCards"
        Me.TabPageCards.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageCards.Size = New System.Drawing.Size(565, 239)
        Me.TabPageCards.TabIndex = 2
        Me.TabPageCards.Text = "Tarjetas"
        Me.TabPageCards.UseVisualStyleBackColor = True
        '
        'DataGridViewCards
        '
        Me.DataGridViewCards.AllowUserToOrderColumns = True
        Me.DataGridViewCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCards.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCards.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnBank, Me.ColumnCardNumber, Me.CollumnCardPassword, Me.CollumnCardExp, Me.CollumnCardAccount1, Me.CollumnCardAccount2})
        Me.DataGridViewCards.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewCards.Location = New System.Drawing.Point(9, 9)
        Me.DataGridViewCards.Name = "DataGridViewCards"
        Me.DataGridViewCards.RowHeadersVisible = False
        Me.DataGridViewCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCards.Size = New System.Drawing.Size(547, 221)
        Me.DataGridViewCards.TabIndex = 2
        '
        'PanelAction
        '
        Me.PanelAction.Controls.Add(Me.ButtonCancel)
        Me.PanelAction.Controls.Add(Me.ButtonAccept)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAction.Location = New System.Drawing.Point(0, 265)
        Me.PanelAction.Name = "PanelAction"
        Me.PanelAction.Size = New System.Drawing.Size(573, 32)
        Me.PanelAction.TabIndex = 1
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(413, 6)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "&Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonAccept
        '
        Me.ButtonAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAccept.Location = New System.Drawing.Point(494, 6)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAccept.TabIndex = 0
        Me.ButtonAccept.Text = "&Aceptar"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ColumnBank
        '
        Me.ColumnBank.DataPropertyName = "Bank"
        Me.ColumnBank.HeaderText = "Banco"
        Me.ColumnBank.Name = "ColumnBank"
        '
        'ColumnCardNumber
        '
        Me.ColumnCardNumber.DataPropertyName = "Number"
        Me.ColumnCardNumber.HeaderText = "Número"
        Me.ColumnCardNumber.Name = "ColumnCardNumber"
        '
        'CollumnCardPassword
        '
        Me.CollumnCardPassword.DataPropertyName = "Password"
        Me.CollumnCardPassword.HeaderText = "Clave"
        Me.CollumnCardPassword.Name = "CollumnCardPassword"
        '
        'CollumnCardExp
        '
        Me.CollumnCardExp.DataPropertyName = "Exp"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CollumnCardExp.DefaultCellStyle = DataGridViewCellStyle4
        Me.CollumnCardExp.HeaderText = "Vence"
        Me.CollumnCardExp.Name = "CollumnCardExp"
        '
        'CollumnCardAccount1
        '
        Me.CollumnCardAccount1.DataPropertyName = "Account1"
        Me.CollumnCardAccount1.HeaderText = "C. Ahorro"
        Me.CollumnCardAccount1.Name = "CollumnCardAccount1"
        Me.CollumnCardAccount1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CollumnCardAccount1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CollumnCardAccount2
        '
        Me.CollumnCardAccount2.DataPropertyName = "Account2"
        Me.CollumnCardAccount2.HeaderText = "C. Corriente"
        Me.CollumnCardAccount2.Name = "CollumnCardAccount2"
        Me.CollumnCardAccount2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CollumnCardAccount2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ClientEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlClient)
        Me.Controls.Add(Me.PanelAction)
        Me.Name = "ClientEditor"
        Me.Size = New System.Drawing.Size(573, 297)
        Me.TabControlClient.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        Me.TabPageAccounts.ResumeLayout(False)
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCards.ResumeLayout(False)
        CType(Me.DataGridViewCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAction.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlClient As TabControl
    Friend WithEvents TabPageAccounts As TabPage
    Friend WithEvents DataGridViewAccounts As DataGridView
    Friend WithEvents ColumnAccountBank As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAccountType As DataGridViewComboBoxColumn
    Friend WithEvents ColumnAccountNumber As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAccountBalance As DataGridViewTextBoxColumn
    Friend WithEvents TabPageCards As TabPage
    Friend WithEvents DataGridViewCards As DataGridView
    Friend WithEvents PanelAction As Panel
    Friend WithEvents ButtonCancel As Windows.Forms.Button
    Friend WithEvents ButtonAccept As Windows.Forms.Button
    Friend WithEvents TabPageGeneral As TabPage
    Friend WithEvents TextBoxIdentification As TextBox
    Friend WithEvents TextBoxFullName As TextBox
    Friend WithEvents LabelIdentification As Label
    Friend WithEvents LabelFullName As Label
    Friend WithEvents ColumnBank As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCardNumber As DataGridViewTextBoxColumn
    Friend WithEvents CollumnCardPassword As DataGridViewTextBoxColumn
    Friend WithEvents CollumnCardExp As DataGridViewTextBoxColumn
    Friend WithEvents CollumnCardAccount1 As DataGridViewComboBoxColumn
    Friend WithEvents CollumnCardAccount2 As DataGridViewComboBoxColumn
End Class
