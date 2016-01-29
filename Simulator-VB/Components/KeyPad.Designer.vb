<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KeyPad
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
        Me.ButtonCancel = New ATM.Button()
        Me.ButtonFix = New ATM.Button()
        Me.ButtonVoid = New ATM.Button()
        Me.ButtonConfirm = New ATM.Button()
        Me.Button1 = New ATM.NumericButton()
        Me.Button2 = New ATM.NumericButton()
        Me.Button3 = New ATM.NumericButton()
        Me.Button4 = New ATM.NumericButton()
        Me.Button5 = New ATM.NumericButton()
        Me.Button6 = New ATM.NumericButton()
        Me.Button7 = New ATM.NumericButton()
        Me.Button8 = New ATM.NumericButton()
        Me.Button9 = New ATM.NumericButton()
        Me.Button00 = New ATM.NumericButton()
        Me.Button0 = New ATM.NumericButton()
        Me.ButtonDot = New ATM.NumericButton()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Silver
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Red
        Me.ButtonCancel.Location = New System.Drawing.Point(192, 0)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonCancel.Size = New System.Drawing.Size(128, 48)
        Me.ButtonCancel.TabIndex = 12
        Me.ButtonCancel.TabStop = False
        Me.ButtonCancel.Text = "CANCELAR"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonFix
        '
        Me.ButtonFix.BackColor = System.Drawing.Color.Silver
        Me.ButtonFix.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFix.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFix.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFix.ForeColor = System.Drawing.Color.Yellow
        Me.ButtonFix.Location = New System.Drawing.Point(192, 54)
        Me.ButtonFix.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.ButtonFix.Name = "ButtonFix"
        Me.ButtonFix.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonFix.Size = New System.Drawing.Size(128, 48)
        Me.ButtonFix.TabIndex = 13
        Me.ButtonFix.TabStop = False
        Me.ButtonFix.Text = "COREGIR"
        Me.ButtonFix.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonFix.UseVisualStyleBackColor = False
        '
        'ButtonVoid
        '
        Me.ButtonVoid.BackColor = System.Drawing.Color.Silver
        Me.ButtonVoid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVoid.Enabled = False
        Me.ButtonVoid.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVoid.Location = New System.Drawing.Point(192, 108)
        Me.ButtonVoid.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.ButtonVoid.Name = "ButtonVoid"
        Me.ButtonVoid.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonVoid.Size = New System.Drawing.Size(128, 48)
        Me.ButtonVoid.TabIndex = 14
        Me.ButtonVoid.TabStop = False
        Me.ButtonVoid.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButtonVoid.UseVisualStyleBackColor = False
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.BackColor = System.Drawing.Color.Silver
        Me.ButtonConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfirm.ForeColor = System.Drawing.Color.Green
        Me.ButtonConfirm.Location = New System.Drawing.Point(192, 162)
        Me.ButtonConfirm.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonConfirm.Size = New System.Drawing.Size(128, 48)
        Me.ButtonConfirm.TabIndex = 15
        Me.ButtonConfirm.TabStop = False
        Me.ButtonConfirm.Text = "CONFIRMAR"
        Me.ButtonConfirm.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonConfirm.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Letters = "QZ"
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3)
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Letters = "ABC"
        Me.Button2.Location = New System.Drawing.Point(54, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(3)
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.TabStop = False
        Me.Button2.Text = "2"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Letters = "DEF"
        Me.Button3.Location = New System.Drawing.Point(108, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(3)
        Me.Button3.Size = New System.Drawing.Size(48, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.TabStop = False
        Me.Button3.Text = "3"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Letters = "GHI"
        Me.Button4.Location = New System.Drawing.Point(0, 54)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(3)
        Me.Button4.Size = New System.Drawing.Size(48, 48)
        Me.Button4.TabIndex = 3
        Me.Button4.TabStop = False
        Me.Button4.Text = "4"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Letters = "JKL"
        Me.Button5.Location = New System.Drawing.Point(54, 54)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(3)
        Me.Button5.Size = New System.Drawing.Size(48, 48)
        Me.Button5.TabIndex = 4
        Me.Button5.TabStop = False
        Me.Button5.Text = "5"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Letters = "MNO"
        Me.Button6.Location = New System.Drawing.Point(108, 54)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(3)
        Me.Button6.Size = New System.Drawing.Size(48, 48)
        Me.Button6.TabIndex = 5
        Me.Button6.TabStop = False
        Me.Button6.Text = "6"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Silver
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Letters = "PRS"
        Me.Button7.Location = New System.Drawing.Point(0, 108)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(3)
        Me.Button7.Size = New System.Drawing.Size(48, 48)
        Me.Button7.TabIndex = 6
        Me.Button7.TabStop = False
        Me.Button7.Text = "7"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Silver
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Letters = "TUV"
        Me.Button8.Location = New System.Drawing.Point(54, 108)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(3)
        Me.Button8.Size = New System.Drawing.Size(48, 48)
        Me.Button8.TabIndex = 7
        Me.Button8.TabStop = False
        Me.Button8.Text = "8"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Silver
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Letters = "WXY"
        Me.Button9.Location = New System.Drawing.Point(108, 108)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(3)
        Me.Button9.Size = New System.Drawing.Size(48, 48)
        Me.Button9.TabIndex = 8
        Me.Button9.TabStop = False
        Me.Button9.Text = "9"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button00
        '
        Me.Button00.BackColor = System.Drawing.Color.Silver
        Me.Button00.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button00.Enabled = False
        Me.Button00.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button00.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button00.Letters = ""
        Me.Button00.Location = New System.Drawing.Point(0, 162)
        Me.Button00.Margin = New System.Windows.Forms.Padding(0, 3, 3, 0)
        Me.Button00.Name = "Button00"
        Me.Button00.Padding = New System.Windows.Forms.Padding(3)
        Me.Button00.Size = New System.Drawing.Size(48, 48)
        Me.Button00.TabIndex = 9
        Me.Button00.TabStop = False
        Me.Button00.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button00.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.Silver
        Me.Button0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button0.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Letters = ""
        Me.Button0.Location = New System.Drawing.Point(54, 162)
        Me.Button0.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Button0.Name = "Button0"
        Me.Button0.Padding = New System.Windows.Forms.Padding(3)
        Me.Button0.Size = New System.Drawing.Size(48, 48)
        Me.Button0.TabIndex = 10
        Me.Button0.TabStop = False
        Me.Button0.Text = "0"
        Me.Button0.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button0.UseVisualStyleBackColor = False
        '
        'ButtonDot
        '
        Me.ButtonDot.BackColor = System.Drawing.Color.Silver
        Me.ButtonDot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDot.Enabled = False
        Me.ButtonDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDot.Letters = ""
        Me.ButtonDot.Location = New System.Drawing.Point(108, 162)
        Me.ButtonDot.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.ButtonDot.Name = "ButtonDot"
        Me.ButtonDot.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonDot.Size = New System.Drawing.Size(48, 48)
        Me.ButtonDot.TabIndex = 11
        Me.ButtonDot.TabStop = False
        Me.ButtonDot.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButtonDot.UseVisualStyleBackColor = False
        '
        'KeyPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonFix)
        Me.Controls.Add(Me.ButtonVoid)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button00)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.ButtonDot)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(320, 210)
        Me.Name = "KeyPad"
        Me.Size = New System.Drawing.Size(320, 210)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As NumericButton
    Friend WithEvents Button2 As NumericButton
    Friend WithEvents Button3 As NumericButton
    Friend WithEvents Button4 As NumericButton
    Friend WithEvents Button5 As NumericButton
    Friend WithEvents Button6 As NumericButton
    Friend WithEvents Button7 As NumericButton
    Friend WithEvents Button8 As NumericButton
    Friend WithEvents Button9 As NumericButton
    Friend WithEvents Button00 As NumericButton
    Friend WithEvents Button0 As NumericButton
    Friend WithEvents ButtonDot As NumericButton
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonFix As Button
    Friend WithEvents ButtonVoid As Button
    Friend WithEvents ButtonConfirm As Button
End Class
