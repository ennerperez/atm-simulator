<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfig
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"0000 0000 0000 0000", "Enner Pérez"}, 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfig))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cliente 1", "Enner Pérez"}, 0)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.TabControlConfig = New System.Windows.Forms.TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBoxAbout = New System.Windows.Forms.GroupBox()
        Me.LinkLabelRef2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelRef1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.LabelClientsTitle = New System.Windows.Forms.Label()
        Me.LabelCards = New System.Windows.Forms.Label()
        Me.LabelAccounts = New System.Windows.Forms.Label()
        Me.LabelCardsTitle = New System.Windows.Forms.Label()
        Me.LabelAccountsTitle = New System.Windows.Forms.Label()
        Me.LabelClients = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelTimeOnTitle = New System.Windows.Forms.Label()
        Me.LabelTimeOn = New System.Windows.Forms.Label()
        Me.LabelReceiptsGeneralTitle = New System.Windows.Forms.Label()
        Me.LabelReceiptsGeneral = New System.Windows.Forms.Label()
        Me.LabelStateTitle = New System.Windows.Forms.Label()
        Me.LabelState = New System.Windows.Forms.Label()
        Me.GroupBoxCurrency = New System.Windows.Forms.GroupBox()
        Me.LabelOpenTitle = New System.Windows.Forms.Label()
        Me.LabelDisposed = New System.Windows.Forms.Label()
        Me.LabelDisposedTitle = New System.Windows.Forms.Label()
        Me.LabelAvailable = New System.Windows.Forms.Label()
        Me.LabelAvailableTitle = New System.Windows.Forms.Label()
        Me.LabelOpen = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonEditGeneral = New System.Windows.Forms.Button()
        Me.ButtonApplyGeneral = New System.Windows.Forms.Button()
        Me.TextBoxBank = New System.Windows.Forms.TextBox()
        Me.LabelCode = New System.Windows.Forms.Label()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.LabelBank = New System.Windows.Forms.Label()
        Me.TabPageResources = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelReceipts = New System.Windows.Forms.Label()
        Me.GroupBoxCurrencyBoxes = New System.Windows.Forms.GroupBox()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.LabelAvailablePreview = New System.Windows.Forms.Label()
        Me.LabelAvailablePreviewTitle = New System.Windows.Forms.Label()
        Me.TabPageCards = New System.Windows.Forms.TabPage()
        Me.ListViewCards = New System.Windows.Forms.ListView()
        Me.ImageListCards = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageClientes = New System.Windows.Forms.TabPage()
        Me.ListViewClients = New System.Windows.Forms.ListView()
        Me.ImageListClients = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureBoxCC = New System.Windows.Forms.PictureBox()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.AmountControlReceipts = New ATM.AmountControl()
        Me.CurrencyBox1 = New ATM.CurrencyBox()
        Me.CurrencyBox2 = New ATM.CurrencyBox()
        Me.CurrencyBox3 = New ATM.CurrencyBox()
        Me.CurrencyBox4 = New ATM.CurrencyBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSameBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnOthersBanks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControlConfig.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.GroupBoxAbout.SuspendLayout()
        Me.GroupBoxClientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxCurrency.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageResources.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxCurrencyBoxes.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        Me.TabPageCards.SuspendLayout()
        Me.TabPageClientes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBoxCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonApply
        '
        Me.ButtonApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonApply.Location = New System.Drawing.Point(505, 410)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApply.TabIndex = 3
        Me.ButtonApply.Text = "&Aplicar"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonRestore.Location = New System.Drawing.Point(424, 410)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRestore.TabIndex = 2
        Me.ButtonRestore.Text = "&Restablecer"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'TabControlConfig
        '
        Me.TabControlConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlConfig.Controls.Add(Me.TabPageGeneral)
        Me.TabControlConfig.Controls.Add(Me.TabPageResources)
        Me.TabControlConfig.Controls.Add(Me.TabPageCards)
        Me.TabControlConfig.Controls.Add(Me.TabPageClientes)
        Me.TabControlConfig.Controls.Add(Me.TabPage1)
        Me.TabControlConfig.Location = New System.Drawing.Point(12, 41)
        Me.TabControlConfig.Name = "TabControlConfig"
        Me.TabControlConfig.SelectedIndex = 0
        Me.TabControlConfig.Size = New System.Drawing.Size(600, 471)
        Me.TabControlConfig.TabIndex = 2
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.AutoScroll = True
        Me.TabPageGeneral.AutoScrollMargin = New System.Drawing.Size(6, 6)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxAbout)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxClientes)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox1)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxCurrency)
        Me.TabPageGeneral.Controls.Add(Me.GroupBox3)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageGeneral.Size = New System.Drawing.Size(592, 445)
        Me.TabPageGeneral.TabIndex = 2
        Me.TabPageGeneral.Text = "Generales"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'GroupBoxAbout
        '
        Me.GroupBoxAbout.Controls.Add(Me.LinkLabelRef2)
        Me.GroupBoxAbout.Controls.Add(Me.LinkLabelRef1)
        Me.GroupBoxAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxAbout.Location = New System.Drawing.Point(9, 365)
        Me.GroupBoxAbout.Name = "GroupBoxAbout"
        Me.GroupBoxAbout.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBoxAbout.Size = New System.Drawing.Size(574, 55)
        Me.GroupBoxAbout.TabIndex = 4
        Me.GroupBoxAbout.TabStop = False
        Me.GroupBoxAbout.Text = "Documentación"
        '
        'LinkLabelRef2
        '
        Me.LinkLabelRef2.AutoSize = True
        Me.LinkLabelRef2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelRef2.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelRef2.Location = New System.Drawing.Point(9, 29)
        Me.LinkLabelRef2.Name = "LinkLabelRef2"
        Me.LinkLabelRef2.Size = New System.Drawing.Size(127, 13)
        Me.LinkLabelRef2.TabIndex = 1
        Me.LinkLabelRef2.TabStop = True
        Me.LinkLabelRef2.Tag = "http://www.yourdictionary.com/atm-machine"
        Me.LinkLabelRef2.Text = "Automatic Teller Machine"
        '
        'LinkLabelRef1
        '
        Me.LinkLabelRef1.AutoSize = True
        Me.LinkLabelRef1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelRef1.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelRef1.Location = New System.Drawing.Point(9, 16)
        Me.LinkLabelRef1.Name = "LinkLabelRef1"
        Me.LinkLabelRef1.Size = New System.Drawing.Size(230, 13)
        Me.LinkLabelRef1.TabIndex = 0
        Me.LinkLabelRef1.TabStop = True
        Me.LinkLabelRef1.Tag = "https://docs.google.com/viewer?url=patentimages.storage.googleapis.com/pdfs/US620" &
    "6284.pdf"
        Me.LinkLabelRef1.Text = "Flexible Configuration Automatic Teller Machine"
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.LabelClientsTitle)
        Me.GroupBoxClientes.Controls.Add(Me.LabelCards)
        Me.GroupBoxClientes.Controls.Add(Me.LabelAccounts)
        Me.GroupBoxClientes.Controls.Add(Me.LabelCardsTitle)
        Me.GroupBoxClientes.Controls.Add(Me.LabelAccountsTitle)
        Me.GroupBoxClientes.Controls.Add(Me.LabelClients)
        Me.GroupBoxClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxClientes.Location = New System.Drawing.Point(9, 269)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBoxClientes.Size = New System.Drawing.Size(574, 96)
        Me.GroupBoxClientes.TabIndex = 3
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Resumen clientes"
        '
        'LabelClientsTitle
        '
        Me.LabelClientsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientsTitle.Location = New System.Drawing.Point(9, 16)
        Me.LabelClientsTitle.Name = "LabelClientsTitle"
        Me.LabelClientsTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelClientsTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelClientsTitle.TabIndex = 0
        Me.LabelClientsTitle.Text = "Clientes:"
        Me.LabelClientsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCards
        '
        Me.LabelCards.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCards.Location = New System.Drawing.Point(131, 62)
        Me.LabelCards.Name = "LabelCards"
        Me.LabelCards.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelCards.Size = New System.Drawing.Size(434, 23)
        Me.LabelCards.TabIndex = 5
        Me.LabelCards.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAccounts
        '
        Me.LabelAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccounts.Location = New System.Drawing.Point(131, 39)
        Me.LabelAccounts.Name = "LabelAccounts"
        Me.LabelAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelAccounts.Size = New System.Drawing.Size(434, 23)
        Me.LabelAccounts.TabIndex = 3
        Me.LabelAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCardsTitle
        '
        Me.LabelCardsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCardsTitle.Location = New System.Drawing.Point(9, 62)
        Me.LabelCardsTitle.Name = "LabelCardsTitle"
        Me.LabelCardsTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelCardsTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelCardsTitle.TabIndex = 4
        Me.LabelCardsTitle.Text = "Tarjetas:"
        Me.LabelCardsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAccountsTitle
        '
        Me.LabelAccountsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccountsTitle.Location = New System.Drawing.Point(9, 39)
        Me.LabelAccountsTitle.Name = "LabelAccountsTitle"
        Me.LabelAccountsTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelAccountsTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelAccountsTitle.TabIndex = 2
        Me.LabelAccountsTitle.Text = "Cuentas:"
        Me.LabelAccountsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelClients
        '
        Me.LabelClients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClients.Location = New System.Drawing.Point(131, 16)
        Me.LabelClients.Name = "LabelClients"
        Me.LabelClients.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelClients.Size = New System.Drawing.Size(434, 23)
        Me.LabelClients.TabIndex = 1
        Me.LabelClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTimeOnTitle)
        Me.GroupBox1.Controls.Add(Me.LabelTimeOn)
        Me.GroupBox1.Controls.Add(Me.LabelReceiptsGeneralTitle)
        Me.GroupBox1.Controls.Add(Me.LabelReceiptsGeneral)
        Me.GroupBox1.Controls.Add(Me.LabelStateTitle)
        Me.GroupBox1.Controls.Add(Me.LabelState)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(9, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(574, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estatus"
        '
        'LabelTimeOnTitle
        '
        Me.LabelTimeOnTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimeOnTitle.Location = New System.Drawing.Point(9, 39)
        Me.LabelTimeOnTitle.Name = "LabelTimeOnTitle"
        Me.LabelTimeOnTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelTimeOnTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelTimeOnTitle.TabIndex = 2
        Me.LabelTimeOnTitle.Text = "Tiempo:"
        Me.LabelTimeOnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTimeOn
        '
        Me.LabelTimeOn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTimeOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimeOn.Location = New System.Drawing.Point(134, 39)
        Me.LabelTimeOn.Name = "LabelTimeOn"
        Me.LabelTimeOn.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelTimeOn.Size = New System.Drawing.Size(431, 23)
        Me.LabelTimeOn.TabIndex = 3
        Me.LabelTimeOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelReceiptsGeneralTitle
        '
        Me.LabelReceiptsGeneralTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReceiptsGeneralTitle.Location = New System.Drawing.Point(9, 62)
        Me.LabelReceiptsGeneralTitle.Name = "LabelReceiptsGeneralTitle"
        Me.LabelReceiptsGeneralTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelReceiptsGeneralTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelReceiptsGeneralTitle.TabIndex = 4
        Me.LabelReceiptsGeneralTitle.Text = "Recibos:"
        Me.LabelReceiptsGeneralTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelReceiptsGeneral
        '
        Me.LabelReceiptsGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelReceiptsGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReceiptsGeneral.Location = New System.Drawing.Point(134, 62)
        Me.LabelReceiptsGeneral.Name = "LabelReceiptsGeneral"
        Me.LabelReceiptsGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelReceiptsGeneral.Size = New System.Drawing.Size(431, 23)
        Me.LabelReceiptsGeneral.TabIndex = 5
        Me.LabelReceiptsGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelStateTitle
        '
        Me.LabelStateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStateTitle.Location = New System.Drawing.Point(9, 16)
        Me.LabelStateTitle.Name = "LabelStateTitle"
        Me.LabelStateTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelStateTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelStateTitle.TabIndex = 0
        Me.LabelStateTitle.Text = "Estado:"
        Me.LabelStateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelState
        '
        Me.LabelState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelState.Location = New System.Drawing.Point(134, 16)
        Me.LabelState.Name = "LabelState"
        Me.LabelState.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelState.Size = New System.Drawing.Size(431, 23)
        Me.LabelState.TabIndex = 1
        Me.LabelState.Text = "En linea"
        Me.LabelState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBoxCurrency
        '
        Me.GroupBoxCurrency.Controls.Add(Me.LabelOpenTitle)
        Me.GroupBoxCurrency.Controls.Add(Me.LabelDisposed)
        Me.GroupBoxCurrency.Controls.Add(Me.LabelDisposedTitle)
        Me.GroupBoxCurrency.Controls.Add(Me.LabelAvailable)
        Me.GroupBoxCurrency.Controls.Add(Me.LabelAvailableTitle)
        Me.GroupBoxCurrency.Controls.Add(Me.LabelOpen)
        Me.GroupBoxCurrency.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxCurrency.Location = New System.Drawing.Point(9, 73)
        Me.GroupBoxCurrency.Name = "GroupBoxCurrency"
        Me.GroupBoxCurrency.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBoxCurrency.Size = New System.Drawing.Size(574, 96)
        Me.GroupBoxCurrency.TabIndex = 1
        Me.GroupBoxCurrency.TabStop = False
        Me.GroupBoxCurrency.Text = "Resumen financiero"
        '
        'LabelOpenTitle
        '
        Me.LabelOpenTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOpenTitle.Location = New System.Drawing.Point(9, 16)
        Me.LabelOpenTitle.Name = "LabelOpenTitle"
        Me.LabelOpenTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelOpenTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelOpenTitle.TabIndex = 0
        Me.LabelOpenTitle.Text = "Apertura:"
        Me.LabelOpenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDisposed
        '
        Me.LabelDisposed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDisposed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisposed.Location = New System.Drawing.Point(134, 62)
        Me.LabelDisposed.Name = "LabelDisposed"
        Me.LabelDisposed.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelDisposed.Size = New System.Drawing.Size(431, 23)
        Me.LabelDisposed.TabIndex = 5
        Me.LabelDisposed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDisposedTitle
        '
        Me.LabelDisposedTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisposedTitle.Location = New System.Drawing.Point(9, 62)
        Me.LabelDisposedTitle.Name = "LabelDisposedTitle"
        Me.LabelDisposedTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelDisposedTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelDisposedTitle.TabIndex = 2
        Me.LabelDisposedTitle.Text = "Dispensado:"
        Me.LabelDisposedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAvailable
        '
        Me.LabelAvailable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvailable.Location = New System.Drawing.Point(134, 39)
        Me.LabelAvailable.Name = "LabelAvailable"
        Me.LabelAvailable.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelAvailable.Size = New System.Drawing.Size(431, 23)
        Me.LabelAvailable.TabIndex = 4
        Me.LabelAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAvailableTitle
        '
        Me.LabelAvailableTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvailableTitle.Location = New System.Drawing.Point(9, 39)
        Me.LabelAvailableTitle.Name = "LabelAvailableTitle"
        Me.LabelAvailableTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelAvailableTitle.Size = New System.Drawing.Size(116, 23)
        Me.LabelAvailableTitle.TabIndex = 1
        Me.LabelAvailableTitle.Text = "Disponible:"
        Me.LabelAvailableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelOpen
        '
        Me.LabelOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOpen.Location = New System.Drawing.Point(134, 16)
        Me.LabelOpen.Name = "LabelOpen"
        Me.LabelOpen.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelOpen.Size = New System.Drawing.Size(431, 23)
        Me.LabelOpen.TabIndex = 3
        Me.LabelOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonEditGeneral)
        Me.GroupBox3.Controls.Add(Me.ButtonApplyGeneral)
        Me.GroupBox3.Controls.Add(Me.TextBoxBank)
        Me.GroupBox3.Controls.Add(Me.LabelCode)
        Me.GroupBox3.Controls.Add(Me.TextBoxCode)
        Me.GroupBox3.Controls.Add(Me.LabelBank)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(574, 64)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ajustes"
        '
        'ButtonEditGeneral
        '
        Me.ButtonEditGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEditGeneral.Location = New System.Drawing.Point(490, 30)
        Me.ButtonEditGeneral.Name = "ButtonEditGeneral"
        Me.ButtonEditGeneral.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditGeneral.TabIndex = 5
        Me.ButtonEditGeneral.Tag = "&Cancelar"
        Me.ButtonEditGeneral.Text = "&Editar"
        Me.ButtonEditGeneral.UseVisualStyleBackColor = True
        '
        'ButtonApplyGeneral
        '
        Me.ButtonApplyGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonApplyGeneral.Enabled = False
        Me.ButtonApplyGeneral.Location = New System.Drawing.Point(409, 30)
        Me.ButtonApplyGeneral.Name = "ButtonApplyGeneral"
        Me.ButtonApplyGeneral.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApplyGeneral.TabIndex = 4
        Me.ButtonApplyGeneral.Text = "&Aplicar"
        Me.ButtonApplyGeneral.UseVisualStyleBackColor = True
        '
        'TextBoxBank
        '
        Me.TextBoxBank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBank.Enabled = False
        Me.TextBoxBank.Location = New System.Drawing.Point(115, 32)
        Me.TextBoxBank.MaxLength = 256
        Me.TextBoxBank.Name = "TextBoxBank"
        Me.TextBoxBank.Size = New System.Drawing.Size(288, 20)
        Me.TextBoxBank.TabIndex = 3
        '
        'LabelCode
        '
        Me.LabelCode.AutoSize = True
        Me.LabelCode.Location = New System.Drawing.Point(9, 16)
        Me.LabelCode.Name = "LabelCode"
        Me.LabelCode.Size = New System.Drawing.Size(43, 13)
        Me.LabelCode.TabIndex = 0
        Me.LabelCode.Text = "&Codigo:"
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Enabled = False
        Me.TextBoxCode.Location = New System.Drawing.Point(9, 32)
        Me.TextBoxCode.MaxLength = 8
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCode.TabIndex = 1
        '
        'LabelBank
        '
        Me.LabelBank.AutoSize = True
        Me.LabelBank.Location = New System.Drawing.Point(115, 16)
        Me.LabelBank.Name = "LabelBank"
        Me.LabelBank.Size = New System.Drawing.Size(41, 13)
        Me.LabelBank.TabIndex = 2
        Me.LabelBank.Text = "&Banco:"
        '
        'TabPageResources
        '
        Me.TabPageResources.AutoScroll = True
        Me.TabPageResources.AutoScrollMargin = New System.Drawing.Size(6, 32)
        Me.TabPageResources.Controls.Add(Me.GroupBox2)
        Me.TabPageResources.Controls.Add(Me.GroupBoxCurrencyBoxes)
        Me.TabPageResources.Controls.Add(Me.ButtonRestore)
        Me.TabPageResources.Controls.Add(Me.ButtonApply)
        Me.TabPageResources.Location = New System.Drawing.Point(4, 22)
        Me.TabPageResources.Name = "TabPageResources"
        Me.TabPageResources.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageResources.Size = New System.Drawing.Size(592, 445)
        Me.TabPageResources.TabIndex = 0
        Me.TabPageResources.Text = "Recursos"
        Me.TabPageResources.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelReceipts)
        Me.GroupBox2.Controls.Add(Me.AmountControlReceipts)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(9, 309)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(574, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Otros"
        '
        'LabelReceipts
        '
        Me.LabelReceipts.AutoSize = True
        Me.LabelReceipts.Location = New System.Drawing.Point(9, 38)
        Me.LabelReceipts.Name = "LabelReceipts"
        Me.LabelReceipts.Size = New System.Drawing.Size(86, 13)
        Me.LabelReceipts.TabIndex = 0
        Me.LabelReceipts.Text = "Papel de recibos"
        '
        'GroupBoxCurrencyBoxes
        '
        Me.GroupBoxCurrencyBoxes.Controls.Add(Me.CurrencyBox1)
        Me.GroupBoxCurrencyBoxes.Controls.Add(Me.PanelTotal)
        Me.GroupBoxCurrencyBoxes.Controls.Add(Me.CurrencyBox2)
        Me.GroupBoxCurrencyBoxes.Controls.Add(Me.CurrencyBox3)
        Me.GroupBoxCurrencyBoxes.Controls.Add(Me.CurrencyBox4)
        Me.GroupBoxCurrencyBoxes.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxCurrencyBoxes.Location = New System.Drawing.Point(9, 9)
        Me.GroupBoxCurrencyBoxes.Name = "GroupBoxCurrencyBoxes"
        Me.GroupBoxCurrencyBoxes.Padding = New System.Windows.Forms.Padding(6, 3, 6, 6)
        Me.GroupBoxCurrencyBoxes.Size = New System.Drawing.Size(574, 300)
        Me.GroupBoxCurrencyBoxes.TabIndex = 0
        Me.GroupBoxCurrencyBoxes.TabStop = False
        Me.GroupBoxCurrencyBoxes.Text = "Billetes"
        '
        'PanelTotal
        '
        Me.PanelTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotal.BackColor = System.Drawing.SystemColors.Info
        Me.PanelTotal.Controls.Add(Me.LabelAvailablePreview)
        Me.PanelTotal.Controls.Add(Me.LabelAvailablePreviewTitle)
        Me.PanelTotal.Location = New System.Drawing.Point(9, 259)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelTotal.Size = New System.Drawing.Size(556, 32)
        Me.PanelTotal.TabIndex = 4
        '
        'LabelAvailablePreview
        '
        Me.LabelAvailablePreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAvailablePreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvailablePreview.Location = New System.Drawing.Point(122, 3)
        Me.LabelAvailablePreview.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.LabelAvailablePreview.Name = "LabelAvailablePreview"
        Me.LabelAvailablePreview.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelAvailablePreview.Size = New System.Drawing.Size(431, 26)
        Me.LabelAvailablePreview.TabIndex = 1
        Me.LabelAvailablePreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAvailablePreviewTitle
        '
        Me.LabelAvailablePreviewTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelAvailablePreviewTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvailablePreviewTitle.Location = New System.Drawing.Point(3, 3)
        Me.LabelAvailablePreviewTitle.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.LabelAvailablePreviewTitle.Name = "LabelAvailablePreviewTitle"
        Me.LabelAvailablePreviewTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelAvailablePreviewTitle.Size = New System.Drawing.Size(119, 26)
        Me.LabelAvailablePreviewTitle.TabIndex = 0
        Me.LabelAvailablePreviewTitle.Text = "Disponible:"
        Me.LabelAvailablePreviewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageCards
        '
        Me.TabPageCards.Controls.Add(Me.ListViewCards)
        Me.TabPageCards.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCards.Name = "TabPageCards"
        Me.TabPageCards.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageCards.Size = New System.Drawing.Size(592, 445)
        Me.TabPageCards.TabIndex = 1
        Me.TabPageCards.Text = "Tarjetas"
        Me.TabPageCards.UseVisualStyleBackColor = True
        '
        'ListViewCards
        '
        Me.ListViewCards.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewCards.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewCards.FullRowSelect = True
        Me.ListViewCards.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListViewCards.LargeImageList = Me.ImageListCards
        Me.ListViewCards.Location = New System.Drawing.Point(9, 9)
        Me.ListViewCards.Name = "ListViewCards"
        Me.ListViewCards.Size = New System.Drawing.Size(574, 427)
        Me.ListViewCards.SmallImageList = Me.ImageListCards
        Me.ListViewCards.TabIndex = 0
        Me.ListViewCards.UseCompatibleStateImageBehavior = False
        Me.ListViewCards.View = System.Windows.Forms.View.List
        '
        'ImageListCards
        '
        Me.ImageListCards.ImageStream = CType(resources.GetObject("ImageListCards.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCards.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCards.Images.SetKeyName(0, "microchip_expired.png")
        Me.ImageListCards.Images.SetKeyName(1, "microchip_notexpired.png")
        Me.ImageListCards.Images.SetKeyName(2, "microchip_expired_password.png")
        Me.ImageListCards.Images.SetKeyName(3, "microchip.png")
        '
        'TabPageClientes
        '
        Me.TabPageClientes.Controls.Add(Me.ListViewClients)
        Me.TabPageClientes.Location = New System.Drawing.Point(4, 22)
        Me.TabPageClientes.Name = "TabPageClientes"
        Me.TabPageClientes.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPageClientes.Size = New System.Drawing.Size(592, 445)
        Me.TabPageClientes.TabIndex = 3
        Me.TabPageClientes.Text = "Clientes"
        Me.TabPageClientes.UseVisualStyleBackColor = True
        '
        'ListViewClients
        '
        Me.ListViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewClients.FullRowSelect = True
        Me.ListViewClients.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.ListViewClients.LargeImageList = Me.ImageListClients
        Me.ListViewClients.Location = New System.Drawing.Point(9, 9)
        Me.ListViewClients.Name = "ListViewClients"
        Me.ListViewClients.Size = New System.Drawing.Size(574, 427)
        Me.ListViewClients.SmallImageList = Me.ImageListClients
        Me.ListViewClients.TabIndex = 2
        Me.ListViewClients.UseCompatibleStateImageBehavior = False
        Me.ListViewClients.View = System.Windows.Forms.View.List
        '
        'ImageListClients
        '
        Me.ImageListClients.ImageStream = CType(resources.GetObject("ImageListClients.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListClients.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListClients.Images.SetKeyName(0, "btn_clients_bg.gif")
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPage1.Size = New System.Drawing.Size(592, 445)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Tarifas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(192, 26)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Simulador de ATM"
        '
        'PictureBoxCC
        '
        Me.PictureBoxCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxCC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCC.Image = CType(resources.GetObject("PictureBoxCC.Image"), System.Drawing.Image)
        Me.PictureBoxCC.Location = New System.Drawing.Point(520, 12)
        Me.PictureBoxCC.Name = "PictureBoxCC"
        Me.PictureBoxCC.Size = New System.Drawing.Size(88, 31)
        Me.PictureBoxCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxCC.TabIndex = 10
        Me.PictureBoxCC.TabStop = False
        '
        'AmountControlReceipts
        '
        Me.AmountControlReceipts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmountControlReceipts.BackColor = System.Drawing.SystemColors.Window
        Me.AmountControlReceipts.Location = New System.Drawing.Point(101, 19)
        Me.AmountControlReceipts.Maximum = 100
        Me.AmountControlReceipts.Minimum = 0
        Me.AmountControlReceipts.Name = "AmountControlReceipts"
        Me.AmountControlReceipts.Size = New System.Drawing.Size(464, 37)
        Me.AmountControlReceipts.TabIndex = 1
        Me.AmountControlReceipts.Value = 10
        '
        'CurrencyBox1
        '
        Me.CurrencyBox1.Amount = 100
        Me.CurrencyBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrencyBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CurrencyBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrencyBox1.Location = New System.Drawing.Point(9, 19)
        Me.CurrencyBox1.Maximum = 100
        Me.CurrencyBox1.Minimum = 0
        Me.CurrencyBox1.Name = "CurrencyBox1"
        Me.CurrencyBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.CurrencyBox1.Size = New System.Drawing.Size(556, 54)
        Me.CurrencyBox1.TabIndex = 0
        Me.CurrencyBox1.Value = 0R
        '
        'CurrencyBox2
        '
        Me.CurrencyBox2.Amount = 100
        Me.CurrencyBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrencyBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CurrencyBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrencyBox2.Location = New System.Drawing.Point(9, 79)
        Me.CurrencyBox2.Maximum = 100
        Me.CurrencyBox2.Minimum = 0
        Me.CurrencyBox2.Name = "CurrencyBox2"
        Me.CurrencyBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.CurrencyBox2.Size = New System.Drawing.Size(556, 54)
        Me.CurrencyBox2.TabIndex = 1
        Me.CurrencyBox2.Value = 0R
        '
        'CurrencyBox3
        '
        Me.CurrencyBox3.Amount = 100
        Me.CurrencyBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrencyBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CurrencyBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrencyBox3.Location = New System.Drawing.Point(9, 139)
        Me.CurrencyBox3.Maximum = 100
        Me.CurrencyBox3.Minimum = 0
        Me.CurrencyBox3.Name = "CurrencyBox3"
        Me.CurrencyBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.CurrencyBox3.Size = New System.Drawing.Size(556, 54)
        Me.CurrencyBox3.TabIndex = 2
        Me.CurrencyBox3.Value = 0R
        '
        'CurrencyBox4
        '
        Me.CurrencyBox4.Amount = 100
        Me.CurrencyBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrencyBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CurrencyBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrencyBox4.Location = New System.Drawing.Point(9, 199)
        Me.CurrencyBox4.Maximum = 100
        Me.CurrencyBox4.Minimum = 0
        Me.CurrencyBox4.Name = "CurrencyBox4"
        Me.CurrencyBox4.Padding = New System.Windows.Forms.Padding(6)
        Me.CurrencyBox4.Size = New System.Drawing.Size(556, 54)
        Me.CurrencyBox4.TabIndex = 3
        Me.CurrencyBox4.Value = 0R
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnDescription, Me.ColumnSameBank, Me.ColumnOthersBanks})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(9, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(574, 427)
        Me.DataGridView1.TabIndex = 0
        '
        'ColumnDescription
        '
        Me.ColumnDescription.HeaderText = "Descripción"
        Me.ColumnDescription.Name = "ColumnDescription"
        Me.ColumnDescription.ReadOnly = True
        '
        'ColumnSameBank
        '
        DataGridViewCellStyle1.Format = "C2"
        Me.ColumnSameBank.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColumnSameBank.HeaderText = "Mismo Banco"
        Me.ColumnSameBank.Name = "ColumnSameBank"
        '
        'ColumnOthersBanks
        '
        DataGridViewCellStyle2.Format = "C2"
        Me.ColumnOthersBanks.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnOthersBanks.HeaderText = "Otros Bancos"
        Me.ColumnOthersBanks.Name = "ColumnOthersBanks"
        '
        'FormConfig
        '
        Me.AcceptButton = Me.ButtonApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonRestore
        Me.ClientSize = New System.Drawing.Size(624, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBoxCC)
        Me.Controls.Add(Me.TabControlConfig)
        Me.Controls.Add(Me.LabelTitle)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(320, 540)
        Me.Name = "FormConfig"
        Me.Text = "Configuración"
        Me.TabControlConfig.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.GroupBoxAbout.ResumeLayout(False)
        Me.GroupBoxAbout.PerformLayout()
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBoxCurrency.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPageResources.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxCurrencyBoxes.ResumeLayout(False)
        Me.PanelTotal.ResumeLayout(False)
        Me.TabPageCards.ResumeLayout(False)
        Me.TabPageClientes.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBoxCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonApply As Windows.Forms.Button
    Friend WithEvents ButtonRestore As Windows.Forms.Button
    Friend WithEvents TabControlConfig As TabControl
    Friend WithEvents TabPageResources As TabPage
    Friend WithEvents TabPageCards As TabPage
    Friend WithEvents TabPageGeneral As TabPage
    Friend WithEvents ListViewCards As ListView
    Friend WithEvents ImageListCards As ImageList
    Friend WithEvents GroupBoxAbout As GroupBox
    Friend WithEvents LinkLabelRef1 As LinkLabel
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents LabelClientsTitle As Label
    Friend WithEvents LabelCards As Label
    Friend WithEvents LabelAccounts As Label
    Friend WithEvents LabelCardsTitle As Label
    Friend WithEvents LabelAccountsTitle As Label
    Friend WithEvents LabelClients As Label
    Friend WithEvents GroupBoxCurrency As GroupBox
    Friend WithEvents LabelOpenTitle As Label
    Friend WithEvents LabelAvailable As Label
    Friend WithEvents LabelAvailableTitle As Label
    Friend WithEvents LabelOpen As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LinkLabelRef2 As LinkLabel
    Friend WithEvents PictureBoxCC As PictureBox
    Friend WithEvents CurrencyBox4 As CurrencyBox
    Friend WithEvents CurrencyBox3 As CurrencyBox
    Friend WithEvents CurrencyBox2 As CurrencyBox
    Friend WithEvents CurrencyBox1 As CurrencyBox
    Friend WithEvents LabelAvailablePreview As Label
    Friend WithEvents LabelAvailablePreviewTitle As Label
    Friend WithEvents LabelState As Label
    Friend WithEvents LabelStateTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelReceiptsGeneralTitle As Label
    Friend WithEvents LabelReceiptsGeneral As Label
    Friend WithEvents LabelDisposed As Label
    Friend WithEvents LabelDisposedTitle As Label
    Friend WithEvents LabelTimeOnTitle As Label
    Friend WithEvents LabelTimeOn As Label
    Friend WithEvents PanelTotal As Panel
    Friend WithEvents GroupBoxCurrencyBoxes As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelReceipts As Label
    Friend WithEvents AmountControlReceipts As AmountControl
    Friend WithEvents TabPageClientes As TabPage
    Friend WithEvents ListViewClients As ListView
    Friend WithEvents ImageListClients As ImageList
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonApplyGeneral As Windows.Forms.Button
    Friend WithEvents TextBoxBank As TextBox
    Friend WithEvents LabelCode As Label
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents LabelBank As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ToolTipMain As ToolTip
    Friend WithEvents ButtonEditGeneral As Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnDescription As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSameBank As DataGridViewTextBoxColumn
    Friend WithEvents ColumnOthersBanks As DataGridViewTextBoxColumn
End Class
