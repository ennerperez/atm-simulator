<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyBox
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
        Me.ComboBoxDenomination = New System.Windows.Forms.ComboBox()
        Me.LabelDenomination = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.AmountControl = New ATM.AmountControl()
        Me.SuspendLayout()
        '
        'ComboBoxDenomination
        '
        Me.ComboBoxDenomination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDenomination.FormattingEnabled = True
        Me.ComboBoxDenomination.Items.AddRange(New Object() {"5", "10", "20", "50", "100", "500", "1000"})
        Me.ComboBoxDenomination.Location = New System.Drawing.Point(9, 23)
        Me.ComboBoxDenomination.Name = "ComboBoxDenomination"
        Me.ComboBoxDenomination.Size = New System.Drawing.Size(77, 21)
        Me.ComboBoxDenomination.TabIndex = 1
        '
        'LabelDenomination
        '
        Me.LabelDenomination.AutoSize = True
        Me.LabelDenomination.Location = New System.Drawing.Point(6, 6)
        Me.LabelDenomination.Name = "LabelDenomination"
        Me.LabelDenomination.Size = New System.Drawing.Size(78, 13)
        Me.LabelDenomination.TabIndex = 0
        Me.LabelDenomination.Text = "&Denominación:"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTotal.Location = New System.Drawing.Point(230, 23)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTotal.TabIndex = 6
        Me.TextBoxTotal.Text = "0.000.000.00 BSF"
        Me.TextBoxTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(296, 6)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(34, 13)
        Me.LabelTotal.TabIndex = 5
        Me.LabelTotal.Text = "&Total:"
        '
        'AmountControl
        '
        Me.AmountControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmountControl.Location = New System.Drawing.Point(92, 6)
        Me.AmountControl.Maximum = 100
        Me.AmountControl.Minimum = 0
        Me.AmountControl.Name = "AmountControl"
        Me.AmountControl.Size = New System.Drawing.Size(132, 37)
        Me.AmountControl.TabIndex = 7
        Me.AmountControl.Value = 100
        '
        'CurrencyBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.AmountControl)
        Me.Controls.Add(Me.ComboBoxDenomination)
        Me.Controls.Add(Me.LabelDenomination)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.LabelTotal)
        Me.Name = "CurrencyBox"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Size = New System.Drawing.Size(339, 54)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxDenomination As ComboBox
    Friend WithEvents LabelDenomination As Label
    Friend WithEvents TextBoxTotal As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents AmountControl As AmountControl
End Class
