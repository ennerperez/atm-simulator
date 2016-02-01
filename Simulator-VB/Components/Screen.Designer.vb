<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen))
        Me.PictureBoxLoading = New System.Windows.Forms.PictureBox()
        Me.MultiPanelScreen = New MultiPanel()
        Me.PageLoading = New MultiPanelPage()
        Me.PageMenu = New MultiPanelPage()
        Me.LabelMenuAction1 = New System.Windows.Forms.Label()
        Me.LabelMenuAction2 = New System.Windows.Forms.Label()
        Me.LabelMenuAction5 = New System.Windows.Forms.Label()
        Me.LabelMenuAction6 = New System.Windows.Forms.Label()
        Me.LabelMenuAction7 = New System.Windows.Forms.Label()
        Me.LabelMenuAction8 = New System.Windows.Forms.Label()
        Me.LabelMenuAction3 = New System.Windows.Forms.Label()
        Me.LabelMenuAction4 = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.PageWelcome = New MultiPanelPage()
        Me.PageRequest = New MultiPanelPage()
        Me.LabelRequestText = New System.Windows.Forms.Label()
        Me.PageResponse = New MultiPanelPage()
        Me.LabelResponseText = New System.Windows.Forms.Label()
        Me.TableLayoutPanelActions = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAction1 = New ATM.Button()
        Me.ButtonAction2 = New ATM.Button()
        Me.ButtonAction3 = New ATM.Button()
        Me.ButtonAction4 = New ATM.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAction5 = New ATM.Button()
        Me.ButtonAction6 = New ATM.Button()
        Me.ButtonAction7 = New ATM.Button()
        Me.ButtonAction8 = New ATM.Button()
        CType(Me.PictureBoxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MultiPanelScreen.SuspendLayout()
        Me.PageLoading.SuspendLayout()
        Me.PageMenu.SuspendLayout()
        Me.PageRequest.SuspendLayout()
        Me.PageResponse.SuspendLayout()
        Me.TableLayoutPanelActions.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxLoading
        '
        Me.PictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxLoading.Image = CType(resources.GetObject("PictureBoxLoading.Image"), System.Drawing.Image)
        Me.PictureBoxLoading.Location = New System.Drawing.Point(304, 224)
        Me.PictureBoxLoading.Name = "PictureBoxLoading"
        Me.PictureBoxLoading.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxLoading.TabIndex = 0
        Me.PictureBoxLoading.TabStop = False
        '
        'MultiPanelScreen
        '
        Me.MultiPanelScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MultiPanelScreen.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MultiPanelScreen.Controls.Add(Me.PageLoading)
        Me.MultiPanelScreen.Controls.Add(Me.PageMenu)
        Me.MultiPanelScreen.Controls.Add(Me.PageWelcome)
        Me.MultiPanelScreen.Controls.Add(Me.PageRequest)
        Me.MultiPanelScreen.Controls.Add(Me.PageResponse)
        Me.MultiPanelScreen.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelScreen.Location = New System.Drawing.Point(61, 0)
        Me.MultiPanelScreen.Name = "MultiPanelScreen"
        Me.MultiPanelScreen.Padding = New System.Windows.Forms.Padding(9)
        Me.MultiPanelScreen.SelectedPage = Me.PageMenu
        Me.MultiPanelScreen.Size = New System.Drawing.Size(640, 480)
        Me.MultiPanelScreen.TabIndex = 1
        '
        'PageLoading
        '
        Me.PageLoading.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PageLoading.Controls.Add(Me.PictureBoxLoading)
        Me.PageLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageLoading.Location = New System.Drawing.Point(0, 0)
        Me.PageLoading.Name = "PageLoading"
        Me.PageLoading.Size = New System.Drawing.Size(640, 480)
        Me.PageLoading.TabIndex = 0
        Me.PageLoading.Text = "Loading"
        '
        'PageMenu
        '
        Me.PageMenu.BackColor = System.Drawing.SystemColors.Highlight
        Me.PageMenu.Controls.Add(Me.LabelMenuAction1)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction2)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction5)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction6)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction7)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction8)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction3)
        Me.PageMenu.Controls.Add(Me.LabelMenuAction4)
        Me.PageMenu.Controls.Add(Me.LabelInfo)
        Me.PageMenu.Controls.Add(Me.LabelWelcome)
        Me.PageMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageMenu.Location = New System.Drawing.Point(9, 9)
        Me.PageMenu.Name = "PageMenu"
        Me.PageMenu.Size = New System.Drawing.Size(622, 462)
        Me.PageMenu.TabIndex = 0
        Me.PageMenu.Text = "Menu"
        '
        'LabelMenuAction1
        '
        Me.LabelMenuAction1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction1.Location = New System.Drawing.Point(3, 388)
        Me.LabelMenuAction1.Name = "LabelMenuAction1"
        Me.LabelMenuAction1.Size = New System.Drawing.Size(200, 71)
        Me.LabelMenuAction1.TabIndex = 2
        Me.LabelMenuAction1.Text = "{ACTION1}"
        Me.LabelMenuAction1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMenuAction2
        '
        Me.LabelMenuAction2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction2.Location = New System.Drawing.Point(3, 312)
        Me.LabelMenuAction2.Name = "LabelMenuAction2"
        Me.LabelMenuAction2.Size = New System.Drawing.Size(200, 70)
        Me.LabelMenuAction2.TabIndex = 3
        Me.LabelMenuAction2.Text = "{ACTION2}"
        Me.LabelMenuAction2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMenuAction5
        '
        Me.LabelMenuAction5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction5.Location = New System.Drawing.Point(419, 388)
        Me.LabelMenuAction5.Name = "LabelMenuAction5"
        Me.LabelMenuAction5.Size = New System.Drawing.Size(200, 71)
        Me.LabelMenuAction5.TabIndex = 6
        Me.LabelMenuAction5.Text = "{ACTION5}"
        Me.LabelMenuAction5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMenuAction6
        '
        Me.LabelMenuAction6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction6.Location = New System.Drawing.Point(419, 312)
        Me.LabelMenuAction6.Name = "LabelMenuAction6"
        Me.LabelMenuAction6.Size = New System.Drawing.Size(200, 70)
        Me.LabelMenuAction6.TabIndex = 7
        Me.LabelMenuAction6.Text = "{ACTION6}"
        Me.LabelMenuAction6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMenuAction7
        '
        Me.LabelMenuAction7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction7.Location = New System.Drawing.Point(419, 236)
        Me.LabelMenuAction7.Name = "LabelMenuAction7"
        Me.LabelMenuAction7.Size = New System.Drawing.Size(200, 70)
        Me.LabelMenuAction7.TabIndex = 8
        Me.LabelMenuAction7.Text = "{ACTION7}"
        Me.LabelMenuAction7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMenuAction8
        '
        Me.LabelMenuAction8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction8.Location = New System.Drawing.Point(419, 160)
        Me.LabelMenuAction8.Name = "LabelMenuAction8"
        Me.LabelMenuAction8.Size = New System.Drawing.Size(200, 70)
        Me.LabelMenuAction8.TabIndex = 9
        Me.LabelMenuAction8.Text = "{ACTION1}"
        Me.LabelMenuAction8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMenuAction3
        '
        Me.LabelMenuAction3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction3.Location = New System.Drawing.Point(3, 236)
        Me.LabelMenuAction3.Name = "LabelMenuAction3"
        Me.LabelMenuAction3.Size = New System.Drawing.Size(200, 70)
        Me.LabelMenuAction3.TabIndex = 4
        Me.LabelMenuAction3.Text = "{ACTION3}"
        Me.LabelMenuAction3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMenuAction4
        '
        Me.LabelMenuAction4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMenuAction4.Location = New System.Drawing.Point(3, 160)
        Me.LabelMenuAction4.Name = "LabelMenuAction4"
        Me.LabelMenuAction4.Size = New System.Drawing.Size(200, 70)
        Me.LabelMenuAction4.TabIndex = 5
        Me.LabelMenuAction4.Text = "{ACTION4}"
        Me.LabelMenuAction4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelInfo
        '
        Me.LabelInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelInfo.Location = New System.Drawing.Point(34, 61)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(544, 114)
        Me.LabelInfo.TabIndex = 1
        Me.LabelInfo.Text = "Seleccione la operación que desea realizar"
        '
        'LabelWelcome
        '
        Me.LabelWelcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelWelcome.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.Location = New System.Drawing.Point(34, 39)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(544, 22)
        Me.LabelWelcome.TabIndex = 0
        Me.LabelWelcome.Text = "Bienvenido"
        '
        'PageWelcome
        '
        Me.PageWelcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PageWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageWelcome.Location = New System.Drawing.Point(0, 0)
        Me.PageWelcome.Name = "PageWelcome"
        Me.PageWelcome.Size = New System.Drawing.Size(640, 480)
        Me.PageWelcome.TabIndex = 2
        Me.PageWelcome.Text = "Welcome"
        '
        'PageRequest
        '
        Me.PageRequest.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PageRequest.Controls.Add(Me.LabelRequestText)
        Me.PageRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageRequest.Location = New System.Drawing.Point(0, 0)
        Me.PageRequest.Name = "PageRequest"
        Me.PageRequest.Size = New System.Drawing.Size(640, 480)
        Me.PageRequest.TabIndex = 3
        Me.PageRequest.Text = "Request"
        '
        'LabelRequestText
        '
        Me.LabelRequestText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRequestText.Location = New System.Drawing.Point(3, 183)
        Me.LabelRequestText.Name = "LabelRequestText"
        Me.LabelRequestText.Size = New System.Drawing.Size(634, 114)
        Me.LabelRequestText.TabIndex = 0
        Me.LabelRequestText.Text = "{DEBE REALIZAR UNA ACCION}"
        Me.LabelRequestText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PageResponse
        '
        Me.PageResponse.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PageResponse.Controls.Add(Me.LabelResponseText)
        Me.PageResponse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageResponse.Location = New System.Drawing.Point(0, 0)
        Me.PageResponse.Name = "PageResponse"
        Me.PageResponse.Size = New System.Drawing.Size(640, 480)
        Me.PageResponse.TabIndex = 4
        Me.PageResponse.Text = "Response"
        '
        'LabelResponseText
        '
        Me.LabelResponseText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelResponseText.Location = New System.Drawing.Point(3, 183)
        Me.LabelResponseText.Name = "LabelResponseText"
        Me.LabelResponseText.Size = New System.Drawing.Size(634, 114)
        Me.LabelResponseText.TabIndex = 1
        Me.LabelResponseText.Text = "{ACCION COMPLETADA}"
        Me.LabelResponseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanelActions
        '
        Me.TableLayoutPanelActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelActions.ColumnCount = 1
        Me.TableLayoutPanelActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction1, 0, 3)
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction2, 0, 2)
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction3, 0, 1)
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction4, 0, 0)
        Me.TableLayoutPanelActions.Location = New System.Drawing.Point(3, 166)
        Me.TableLayoutPanelActions.Name = "TableLayoutPanelActions"
        Me.TableLayoutPanelActions.RowCount = 4
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.Size = New System.Drawing.Size(52, 305)
        Me.TableLayoutPanelActions.TabIndex = 6
        '
        'ButtonAction1
        '
        Me.ButtonAction1.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction1.FlatAppearance.BorderSize = 0
        Me.ButtonAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction1.Location = New System.Drawing.Point(3, 231)
        Me.ButtonAction1.Name = "ButtonAction1"
        Me.ButtonAction1.Size = New System.Drawing.Size(46, 71)
        Me.ButtonAction1.TabIndex = 1
        Me.ButtonAction1.TabStop = False
        Me.ButtonAction1.Tag = "1"
        Me.ButtonAction1.UseVisualStyleBackColor = False
        '
        'ButtonAction2
        '
        Me.ButtonAction2.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction2.FlatAppearance.BorderSize = 0
        Me.ButtonAction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction2.Location = New System.Drawing.Point(3, 155)
        Me.ButtonAction2.Name = "ButtonAction2"
        Me.ButtonAction2.Size = New System.Drawing.Size(46, 70)
        Me.ButtonAction2.TabIndex = 2
        Me.ButtonAction2.TabStop = False
        Me.ButtonAction2.Tag = "2"
        Me.ButtonAction2.UseVisualStyleBackColor = False
        '
        'ButtonAction3
        '
        Me.ButtonAction3.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction3.FlatAppearance.BorderSize = 0
        Me.ButtonAction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction3.Location = New System.Drawing.Point(3, 79)
        Me.ButtonAction3.Name = "ButtonAction3"
        Me.ButtonAction3.Size = New System.Drawing.Size(46, 70)
        Me.ButtonAction3.TabIndex = 3
        Me.ButtonAction3.TabStop = False
        Me.ButtonAction3.Tag = "3"
        Me.ButtonAction3.UseVisualStyleBackColor = False
        '
        'ButtonAction4
        '
        Me.ButtonAction4.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction4.FlatAppearance.BorderSize = 0
        Me.ButtonAction4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction4.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAction4.Name = "ButtonAction4"
        Me.ButtonAction4.Size = New System.Drawing.Size(46, 70)
        Me.ButtonAction4.TabIndex = 0
        Me.ButtonAction4.TabStop = False
        Me.ButtonAction4.Tag = "4"
        Me.ButtonAction4.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAction5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAction6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAction7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAction8, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(707, 166)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(52, 305)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonAction5
        '
        Me.ButtonAction5.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction5.FlatAppearance.BorderSize = 0
        Me.ButtonAction5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction5.Location = New System.Drawing.Point(3, 231)
        Me.ButtonAction5.Name = "ButtonAction5"
        Me.ButtonAction5.Size = New System.Drawing.Size(46, 71)
        Me.ButtonAction5.TabIndex = 0
        Me.ButtonAction5.TabStop = False
        Me.ButtonAction5.Tag = "5"
        Me.ButtonAction5.UseVisualStyleBackColor = False
        '
        'ButtonAction6
        '
        Me.ButtonAction6.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction6.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction6.FlatAppearance.BorderSize = 0
        Me.ButtonAction6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction6.Location = New System.Drawing.Point(3, 155)
        Me.ButtonAction6.Name = "ButtonAction6"
        Me.ButtonAction6.Size = New System.Drawing.Size(46, 70)
        Me.ButtonAction6.TabIndex = 1
        Me.ButtonAction6.TabStop = False
        Me.ButtonAction6.Tag = "6"
        Me.ButtonAction6.UseVisualStyleBackColor = False
        '
        'ButtonAction7
        '
        Me.ButtonAction7.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction7.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction7.FlatAppearance.BorderSize = 0
        Me.ButtonAction7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction7.Location = New System.Drawing.Point(3, 79)
        Me.ButtonAction7.Name = "ButtonAction7"
        Me.ButtonAction7.Size = New System.Drawing.Size(46, 70)
        Me.ButtonAction7.TabIndex = 2
        Me.ButtonAction7.TabStop = False
        Me.ButtonAction7.Tag = "7"
        Me.ButtonAction7.UseVisualStyleBackColor = False
        '
        'ButtonAction8
        '
        Me.ButtonAction8.BackColor = System.Drawing.Color.Silver
        Me.ButtonAction8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAction8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAction8.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAction8.FlatAppearance.BorderSize = 0
        Me.ButtonAction8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAction8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAction8.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAction8.Name = "ButtonAction8"
        Me.ButtonAction8.Size = New System.Drawing.Size(46, 70)
        Me.ButtonAction8.TabIndex = 3
        Me.ButtonAction8.TabStop = False
        Me.ButtonAction8.Tag = "8"
        Me.ButtonAction8.UseVisualStyleBackColor = False
        '
        'Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanelActions)
        Me.Controls.Add(Me.MultiPanelScreen)
        Me.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(381, 240)
        Me.Name = "Screen"
        Me.Size = New System.Drawing.Size(762, 480)
        CType(Me.PictureBoxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MultiPanelScreen.ResumeLayout(False)
        Me.PageLoading.ResumeLayout(False)
        Me.PageLoading.PerformLayout()
        Me.PageMenu.ResumeLayout(False)
        Me.PageRequest.ResumeLayout(False)
        Me.PageResponse.ResumeLayout(False)
        Me.TableLayoutPanelActions.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxLoading As PictureBox
    Friend WithEvents MultiPanelScreen As MultiPanel
    Friend WithEvents PageLoading As MultiPanelPage
    Friend WithEvents PageMenu As MultiPanelPage
    Friend WithEvents PageWelcome As MultiPanelPage
    Friend WithEvents PageRequest As MultiPanelPage
    Friend WithEvents LabelRequestText As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents PageResponse As MultiPanelPage
    Friend WithEvents LabelResponseText As Label
    Friend WithEvents LabelMenuAction4 As Label
    Friend WithEvents TableLayoutPanelActions As TableLayoutPanel
    Friend WithEvents ButtonAction1 As Button
    Friend WithEvents ButtonAction2 As Button
    Friend WithEvents ButtonAction3 As Button
    Friend WithEvents ButtonAction4 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonAction5 As Button
    Friend WithEvents ButtonAction6 As Button
    Friend WithEvents ButtonAction7 As Button
    Friend WithEvents ButtonAction8 As Button
    Friend WithEvents LabelMenuAction3 As Label
    Friend WithEvents LabelMenuAction8 As Label
    Friend WithEvents LabelMenuAction7 As Label
    Friend WithEvents LabelMenuAction6 As Label
    Friend WithEvents LabelMenuAction5 As Label
    Friend WithEvents LabelMenuAction2 As Label
    Friend WithEvents LabelMenuAction1 As Label
End Class
