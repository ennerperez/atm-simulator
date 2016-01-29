<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormATM
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormATM))
        Me.MultiPanelScreen = New MultiPanel()
        Me.PageWelcome = New MultiPanelPage()
        Me.LabelBienvenida = New System.Windows.Forms.Label()
        Me.PageRestart = New MultiPanelPage()
        Me.LabelFueraDeServicio = New System.Windows.Forms.Label()
        Me.PagePassword = New MultiPanelPage()
        Me.LabelSecretPassword = New System.Windows.Forms.Label()
        Me.PageShutdown = New MultiPanelPage()
        Me.PageMainMenu = New MultiPanelPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMainMenu = New System.Windows.Forms.Label()
        Me.TimerRestart = New System.Windows.Forms.Timer(Me.components)
        Me.TimerShutdown = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCounterOn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPassword = New System.Windows.Forms.Timer(Me.components)
        Me.Dispenser = New ATM.Dispenser()
        Me.Printer = New ATM.Printer()
        Me.CardReader = New ATM.CardReader()
        Me.ScreenPadRight = New ATM.ScreenPad()
        Me.ScreenPadLeft = New ATM.ScreenPad()
        Me.KeyPad = New ATM.KeyPad()
        Me.MultiPanelScreen.SuspendLayout()
        Me.PageWelcome.SuspendLayout()
        Me.PageRestart.SuspendLayout()
        Me.PagePassword.SuspendLayout()
        Me.PageMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MultiPanelScreen
        '
        Me.MultiPanelScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MultiPanelScreen.Controls.Add(Me.PageWelcome)
        Me.MultiPanelScreen.Controls.Add(Me.PageRestart)
        Me.MultiPanelScreen.Controls.Add(Me.PagePassword)
        Me.MultiPanelScreen.Controls.Add(Me.PageShutdown)
        Me.MultiPanelScreen.Controls.Add(Me.PageMainMenu)
        Me.MultiPanelScreen.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelScreen.ForeColor = System.Drawing.Color.White
        Me.MultiPanelScreen.Location = New System.Drawing.Point(47, 12)
        Me.MultiPanelScreen.Name = "MultiPanelScreen"
        Me.MultiPanelScreen.SelectedPage = Me.PageMainMenu
        Me.MultiPanelScreen.Size = New System.Drawing.Size(490, 326)
        Me.MultiPanelScreen.TabIndex = 5
        '
        'PageWelcome
        '
        Me.PageWelcome.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PageWelcome.Controls.Add(Me.LabelBienvenida)
        Me.PageWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageWelcome.Location = New System.Drawing.Point(0, 0)
        Me.PageWelcome.Name = "PageWelcome"
        Me.PageWelcome.Size = New System.Drawing.Size(470, 361)
        Me.PageWelcome.TabIndex = 0
        Me.PageWelcome.Text = "Bienvenida"
        '
        'LabelBienvenida
        '
        Me.LabelBienvenida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelBienvenida.Location = New System.Drawing.Point(0, 0)
        Me.LabelBienvenida.Name = "LabelBienvenida"
        Me.LabelBienvenida.Size = New System.Drawing.Size(470, 361)
        Me.LabelBienvenida.TabIndex = 0
        Me.LabelBienvenida.Text = "Bienvenido, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para comenzar introduzca su tarjeta."
        Me.LabelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PageRestart
        '
        Me.PageRestart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PageRestart.Controls.Add(Me.LabelFueraDeServicio)
        Me.PageRestart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageRestart.Location = New System.Drawing.Point(0, 0)
        Me.PageRestart.Name = "PageRestart"
        Me.PageRestart.Padding = New System.Windows.Forms.Padding(9)
        Me.PageRestart.Size = New System.Drawing.Size(470, 361)
        Me.PageRestart.TabIndex = 1
        Me.PageRestart.Text = "Reinicio"
        '
        'LabelFueraDeServicio
        '
        Me.LabelFueraDeServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelFueraDeServicio.ForeColor = System.Drawing.Color.White
        Me.LabelFueraDeServicio.Location = New System.Drawing.Point(9, 9)
        Me.LabelFueraDeServicio.Name = "LabelFueraDeServicio"
        Me.LabelFueraDeServicio.Size = New System.Drawing.Size(452, 343)
        Me.LabelFueraDeServicio.TabIndex = 0
        Me.LabelFueraDeServicio.Text = "Este cajero esta fuera de servicio"
        Me.LabelFueraDeServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PagePassword
        '
        Me.PagePassword.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PagePassword.Controls.Add(Me.LabelSecretPassword)
        Me.PagePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagePassword.Location = New System.Drawing.Point(0, 0)
        Me.PagePassword.Name = "PagePassword"
        Me.PagePassword.Padding = New System.Windows.Forms.Padding(9)
        Me.PagePassword.Size = New System.Drawing.Size(470, 361)
        Me.PagePassword.TabIndex = 3
        Me.PagePassword.Text = "Contraseña"
        '
        'LabelSecretPassword
        '
        Me.LabelSecretPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSecretPassword.ForeColor = System.Drawing.Color.White
        Me.LabelSecretPassword.Location = New System.Drawing.Point(9, 9)
        Me.LabelSecretPassword.Name = "LabelSecretPassword"
        Me.LabelSecretPassword.Size = New System.Drawing.Size(452, 343)
        Me.LabelSecretPassword.TabIndex = 1
        Me.LabelSecretPassword.Tag = "Ingrese su clave secreta"
        Me.LabelSecretPassword.Text = "Ingrese su clave secreta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelSecretPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PageShutdown
        '
        Me.PageShutdown.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PageShutdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageShutdown.Location = New System.Drawing.Point(0, 0)
        Me.PageShutdown.Name = "PageShutdown"
        Me.PageShutdown.Size = New System.Drawing.Size(470, 361)
        Me.PageShutdown.TabIndex = 2
        Me.PageShutdown.Text = "Apagando"
        '
        'PageMainMenu
        '
        Me.PageMainMenu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PageMainMenu.Controls.Add(Me.Label2)
        Me.PageMainMenu.Controls.Add(Me.Label9)
        Me.PageMainMenu.Controls.Add(Me.Label8)
        Me.PageMainMenu.Controls.Add(Me.Label7)
        Me.PageMainMenu.Controls.Add(Me.Label1)
        Me.PageMainMenu.Controls.Add(Me.LabelMainMenu)
        Me.PageMainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.PageMainMenu.Name = "PageMainMenu"
        Me.PageMainMenu.Padding = New System.Windows.Forms.Padding(9)
        Me.PageMainMenu.Size = New System.Drawing.Size(490, 326)
        Me.PageMainMenu.TabIndex = 4
        Me.PageMainMenu.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Seleccione la operación que desea realizar"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 158)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Retiro rapido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 203)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Retiro"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 295)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Consulta de saldo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cambio de clave"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMainMenu
        '
        Me.LabelMainMenu.AutoSize = True
        Me.LabelMainMenu.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMainMenu.Location = New System.Drawing.Point(12, 12)
        Me.LabelMainMenu.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelMainMenu.Name = "LabelMainMenu"
        Me.LabelMainMenu.Size = New System.Drawing.Size(214, 24)
        Me.LabelMainMenu.TabIndex = 0
        Me.LabelMainMenu.Text = "Bienvenido al ATM"
        '
        'TimerRestart
        '
        Me.TimerRestart.Interval = 5000
        '
        'TimerShutdown
        '
        Me.TimerShutdown.Interval = 3000
        '
        'TimerCounterOn
        '
        Me.TimerCounterOn.Interval = 1000
        '
        'TimerPassword
        '
        Me.TimerPassword.Interval = 5000
        '
        'Dispenser
        '
        Me.Dispenser.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Dispenser.Location = New System.Drawing.Point(12, 344)
        Me.Dispenser.Name = "Dispenser"
        Me.Dispenser.Size = New System.Drawing.Size(560, 29)
        Me.Dispenser.TabIndex = 8
        '
        'Printer
        '
        Me.Printer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Printer.Location = New System.Drawing.Point(380, 415)
        Me.Printer.MinimumSize = New System.Drawing.Size(192, 32)
        Me.Printer.Name = "Printer"
        Me.Printer.Receipt = Nothing
        Me.Printer.Size = New System.Drawing.Size(192, 32)
        Me.Printer.TabIndex = 7
        '
        'CardReader
        '
        Me.CardReader.AllowDrop = True
        Me.CardReader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CardReader.Location = New System.Drawing.Point(380, 491)
        Me.CardReader.MinimumSize = New System.Drawing.Size(192, 32)
        Me.CardReader.Name = "CardReader"
        Me.CardReader.Size = New System.Drawing.Size(192, 40)
        Me.CardReader.TabIndex = 6
        '
        'ScreenPadRight
        '
        Me.ScreenPadRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScreenPadRight.Location = New System.Drawing.Point(543, 158)
        Me.ScreenPadRight.Name = "ScreenPadRight"
        Me.ScreenPadRight.Size = New System.Drawing.Size(29, 180)
        Me.ScreenPadRight.TabIndex = 3
        '
        'ScreenPadLeft
        '
        Me.ScreenPadLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ScreenPadLeft.Location = New System.Drawing.Point(12, 158)
        Me.ScreenPadLeft.Name = "ScreenPadLeft"
        Me.ScreenPadLeft.Size = New System.Drawing.Size(29, 180)
        Me.ScreenPadLeft.TabIndex = 3
        '
        'KeyPad
        '
        Me.KeyPad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.KeyPad.Location = New System.Drawing.Point(12, 379)
        Me.KeyPad.MaxLenght = 4
        Me.KeyPad.MinimumSize = New System.Drawing.Size(322, 210)
        Me.KeyPad.MinLenght = 4
        Me.KeyPad.Name = "KeyPad"
        Me.KeyPad.Size = New System.Drawing.Size(322, 210)
        Me.KeyPad.TabIndex = 0
        Me.KeyPad.Valor = Nothing
        '
        'FormATM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 601)
        Me.Controls.Add(Me.Dispenser)
        Me.Controls.Add(Me.Printer)
        Me.Controls.Add(Me.CardReader)
        Me.Controls.Add(Me.MultiPanelScreen)
        Me.Controls.Add(Me.ScreenPadRight)
        Me.Controls.Add(Me.ScreenPadLeft)
        Me.Controls.Add(Me.KeyPad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 640)
        Me.Name = "FormATM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATM"
        Me.MultiPanelScreen.ResumeLayout(False)
        Me.PageWelcome.ResumeLayout(False)
        Me.PageRestart.ResumeLayout(False)
        Me.PagePassword.ResumeLayout(False)
        Me.PageMainMenu.ResumeLayout(False)
        Me.PageMainMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KeyPad As KeyPad
    Friend WithEvents ScreenPadLeft As ScreenPad
    Friend WithEvents ScreenPadRight As ScreenPad
    Friend WithEvents MultiPanelScreen As MultiPanel
    Friend WithEvents PageWelcome As MultiPanelPage
    Friend WithEvents PageRestart As MultiPanelPage
    Friend WithEvents LabelFueraDeServicio As Label
    Friend WithEvents LabelBienvenida As Label
    Friend WithEvents CardReader As CardReader
    Friend WithEvents TimerRestart As Timer
    Friend WithEvents TimerShutdown As Timer
    Friend WithEvents PageShutdown As MultiPanelPage
    Friend WithEvents TimerCounterOn As Timer
    Friend WithEvents PagePassword As MultiPanelPage
    Friend WithEvents LabelSecretPassword As Label
    Friend WithEvents TimerPassword As Timer
    Friend WithEvents PageMainMenu As MultiPanelPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMainMenu As Label
    Friend WithEvents Printer As Printer
    Friend WithEvents Dispenser As Dispenser
End Class
