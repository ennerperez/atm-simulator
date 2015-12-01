<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printer))
        Me.PanelReader = New System.Windows.Forms.Panel()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.PanelPaper = New System.Windows.Forms.Panel()
        Me.LabelPaper = New System.Windows.Forms.Label()
        Me.TimerDiscart = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPrinting = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPaper.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelReader
        '
        Me.PanelReader.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelReader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReader.Location = New System.Drawing.Point(0, 0)
        Me.PanelReader.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelReader.Name = "PanelReader"
        Me.PanelReader.Size = New System.Drawing.Size(150, 10)
        Me.PanelReader.TabIndex = 3
        '
        'PanelStatus
        '
        Me.PanelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelStatus.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelStatus.Location = New System.Drawing.Point(86, 13)
        Me.PanelStatus.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(64, 8)
        Me.PanelStatus.TabIndex = 3
        '
        'PanelPaper
        '
        Me.PanelPaper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelPaper.BackColor = System.Drawing.Color.White
        Me.PanelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPaper.Controls.Add(Me.LabelPaper)
        Me.PanelPaper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelPaper.Location = New System.Drawing.Point(2, 5)
        Me.PanelPaper.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelPaper.Name = "PanelPaper"
        Me.PanelPaper.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelPaper.Size = New System.Drawing.Size(146, 29)
        Me.PanelPaper.TabIndex = 4
        Me.PanelPaper.Visible = False
        '
        'LabelPaper
        '
        Me.LabelPaper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPaper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPaper.Font = New System.Drawing.Font("Consolas", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaper.Location = New System.Drawing.Point(3, 0)
        Me.LabelPaper.Name = "LabelPaper"
        Me.LabelPaper.Size = New System.Drawing.Size(138, 24)
        Me.LabelPaper.TabIndex = 0
        Me.LabelPaper.Text = resources.GetString("LabelPaper.Text")
        '
        'TimerDiscart
        '
        Me.TimerDiscart.Interval = 3000
        '
        'TimerPrinting
        '
        Me.TimerPrinting.Interval = 3000
        '
        'ReceiptPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelPaper)
        Me.Controls.Add(Me.PanelStatus)
        Me.Controls.Add(Me.PanelReader)
        Me.Name = "ReceiptPrinter"
        Me.Size = New System.Drawing.Size(150, 34)
        Me.PanelPaper.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelReader As Panel
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents PanelPaper As Panel
    Friend WithEvents LabelPaper As Label
    Friend WithEvents TimerDiscart As Timer
    Friend WithEvents TimerPrinting As Timer
End Class
