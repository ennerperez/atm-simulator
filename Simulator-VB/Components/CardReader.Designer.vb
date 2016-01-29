<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CardReader
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PanelReader = New System.Windows.Forms.Panel()
        Me.TimerCard = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.PictureBoxCirrus = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMaestro = New System.Windows.Forms.PictureBox()
        Me.PanelCard.SuspendLayout()
        CType(Me.PictureBoxCirrus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMaestro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelReader
        '
        Me.PanelReader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelReader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReader.Location = New System.Drawing.Point(0, 0)
        Me.PanelReader.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelReader.Name = "PanelReader"
        Me.PanelReader.Size = New System.Drawing.Size(192, 16)
        Me.PanelReader.TabIndex = 0
        '
        'TimerCard
        '
        Me.TimerCard.Interval = 1000
        '
        'PanelCard
        '
        Me.PanelCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCard.Controls.Add(Me.PictureBoxCirrus)
        Me.PanelCard.Controls.Add(Me.PictureBoxMaestro)
        Me.PanelCard.Location = New System.Drawing.Point(5, 5)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Size = New System.Drawing.Size(182, 24)
        Me.PanelCard.TabIndex = 0
        Me.PanelCard.Visible = False
        '
        'PictureBoxCirrus
        '
        Me.PictureBoxCirrus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxCirrus.Image = Global.ATM.My.Resources.Resources.Cirrus
        Me.PictureBoxCirrus.Location = New System.Drawing.Point(120, -14)
        Me.PictureBoxCirrus.Name = "PictureBoxCirrus"
        Me.PictureBoxCirrus.Size = New System.Drawing.Size(21, 30)
        Me.PictureBoxCirrus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCirrus.TabIndex = 4
        Me.PictureBoxCirrus.TabStop = False
        '
        'PictureBoxMaestro
        '
        Me.PictureBoxMaestro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxMaestro.Image = Global.ATM.My.Resources.Resources.Maestro
        Me.PictureBoxMaestro.Location = New System.Drawing.Point(147, -14)
        Me.PictureBoxMaestro.Name = "PictureBoxMaestro"
        Me.PictureBoxMaestro.Size = New System.Drawing.Size(21, 30)
        Me.PictureBoxMaestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMaestro.TabIndex = 5
        Me.PictureBoxMaestro.TabStop = False
        '
        'CardReader
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelCard)
        Me.Controls.Add(Me.PanelReader)
        Me.MinimumSize = New System.Drawing.Size(192, 32)
        Me.Name = "CardReader"
        Me.Size = New System.Drawing.Size(192, 32)
        Me.PanelCard.ResumeLayout(False)
        CType(Me.PictureBoxCirrus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMaestro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelReader As Panel
    Friend WithEvents TimerCard As Timer
    Friend WithEvents PanelCard As Panel
    Friend WithEvents PictureBoxCirrus As PictureBox
    Friend WithEvents PictureBoxMaestro As PictureBox
End Class
