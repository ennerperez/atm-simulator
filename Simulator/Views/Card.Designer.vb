<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Card))
        Me.PictureBoxChip = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMaestro = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCirrus = New System.Windows.Forms.PictureBox()
        Me.LabelBank = New System.Windows.Forms.Label()
        Me.LabelNumber = New System.Windows.Forms.Label()
        Me.LabelExp = New System.Windows.Forms.Label()
        CType(Me.PictureBoxChip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMaestro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCirrus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxChip
        '
        Me.PictureBoxChip.Image = CType(resources.GetObject("PictureBoxChip.Image"), System.Drawing.Image)
        Me.PictureBoxChip.Location = New System.Drawing.Point(12, 37)
        Me.PictureBoxChip.Name = "PictureBoxChip"
        Me.PictureBoxChip.Size = New System.Drawing.Size(32, 26)
        Me.PictureBoxChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxChip.TabIndex = 0
        Me.PictureBoxChip.TabStop = False
        '
        'PictureBoxMaestro
        '
        Me.PictureBoxMaestro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxMaestro.Image = CType(resources.GetObject("PictureBoxMaestro.Image"), System.Drawing.Image)
        Me.PictureBoxMaestro.Location = New System.Drawing.Point(194, 12)
        Me.PictureBoxMaestro.Name = "PictureBoxMaestro"
        Me.PictureBoxMaestro.Size = New System.Drawing.Size(30, 21)
        Me.PictureBoxMaestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMaestro.TabIndex = 3
        Me.PictureBoxMaestro.TabStop = False
        '
        'PictureBoxCirrus
        '
        Me.PictureBoxCirrus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxCirrus.Image = CType(resources.GetObject("PictureBoxCirrus.Image"), System.Drawing.Image)
        Me.PictureBoxCirrus.Location = New System.Drawing.Point(194, 37)
        Me.PictureBoxCirrus.Name = "PictureBoxCirrus"
        Me.PictureBoxCirrus.Size = New System.Drawing.Size(30, 21)
        Me.PictureBoxCirrus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCirrus.TabIndex = 3
        Me.PictureBoxCirrus.TabStop = False
        '
        'LabelBank
        '
        Me.LabelBank.AutoSize = True
        Me.LabelBank.Location = New System.Drawing.Point(9, 21)
        Me.LabelBank.Name = "LabelBank"
        Me.LabelBank.Size = New System.Drawing.Size(95, 13)
        Me.LabelBank.TabIndex = 4
        Me.LabelBank.Text = "Entidad Financiera"
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumber.Location = New System.Drawing.Point(12, 66)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(185, 17)
        Me.LabelNumber.TabIndex = 4
        Me.LabelNumber.Text = "000000 0000 0000 0000"
        '
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Location = New System.Drawing.Point(191, 91)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.Size = New System.Drawing.Size(36, 13)
        Me.LabelExp.TabIndex = 4
        Me.LabelExp.Text = "00/00"
        '
        'Card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.LabelNumber)
        Me.Controls.Add(Me.LabelExp)
        Me.Controls.Add(Me.LabelBank)
        Me.Controls.Add(Me.PictureBoxCirrus)
        Me.Controls.Add(Me.PictureBoxMaestro)
        Me.Controls.Add(Me.PictureBoxChip)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(238, 113)
        Me.MinimumSize = New System.Drawing.Size(238, 113)
        Me.Name = "Card"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.Size = New System.Drawing.Size(236, 111)
        CType(Me.PictureBoxChip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMaestro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCirrus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxChip As PictureBox
    Friend WithEvents PictureBoxMaestro As PictureBox
    Friend WithEvents PictureBoxCirrus As PictureBox
    Friend WithEvents LabelBank As Label
    Friend WithEvents LabelNumber As Label
    Friend WithEvents LabelExp As Label
End Class
