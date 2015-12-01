<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmountControl
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
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.NumericUpDownAmount = New System.Windows.Forms.NumericUpDown()
        Me.TrackBarAmount = New System.Windows.Forms.TrackBar()
        CType(Me.NumericUpDownAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAmount
        '
        Me.LabelAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.Location = New System.Drawing.Point(77, 0)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Size = New System.Drawing.Size(52, 13)
        Me.LabelAmount.TabIndex = 6
        Me.LabelAmount.Text = "&Cantidad:"
        '
        'NumericUpDownAmount
        '
        Me.NumericUpDownAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownAmount.Location = New System.Drawing.Point(80, 17)
        Me.NumericUpDownAmount.Name = "NumericUpDownAmount"
        Me.NumericUpDownAmount.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDownAmount.TabIndex = 7
        Me.NumericUpDownAmount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'TrackBarAmount
        '
        Me.TrackBarAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBarAmount.AutoSize = False
        Me.TrackBarAmount.Location = New System.Drawing.Point(0, 17)
        Me.TrackBarAmount.Maximum = 100
        Me.TrackBarAmount.Name = "TrackBarAmount"
        Me.TrackBarAmount.Size = New System.Drawing.Size(74, 20)
        Me.TrackBarAmount.TabIndex = 5
        Me.TrackBarAmount.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'AmountControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelAmount)
        Me.Controls.Add(Me.NumericUpDownAmount)
        Me.Controls.Add(Me.TrackBarAmount)
        Me.Name = "AmountControl"
        Me.Size = New System.Drawing.Size(128, 37)
        CType(Me.NumericUpDownAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAmount As Label
    Friend WithEvents NumericUpDownAmount As NumericUpDown
    Friend WithEvents TrackBarAmount As TrackBar
End Class
