<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenPad
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
        Me.TableLayoutPanelActions = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAction1 = New ATM.Button()
        Me.ButtonAction2 = New ATM.Button()
        Me.ButtonAction3 = New ATM.Button()
        Me.ButtonAction4 = New ATM.Button()
        Me.TableLayoutPanelActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelActions
        '
        Me.TableLayoutPanelActions.ColumnCount = 1
        Me.TableLayoutPanelActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction1, 0, 3)
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction2, 0, 2)
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction3, 0, 1)
        Me.TableLayoutPanelActions.Controls.Add(Me.ButtonAction4, 0, 0)
        Me.TableLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelActions.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelActions.Name = "TableLayoutPanelActions"
        Me.TableLayoutPanelActions.RowCount = 4
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelActions.Size = New System.Drawing.Size(64, 260)
        Me.TableLayoutPanelActions.TabIndex = 0
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
        Me.ButtonAction1.Location = New System.Drawing.Point(3, 198)
        Me.ButtonAction1.Name = "ButtonAction1"
        Me.ButtonAction1.Size = New System.Drawing.Size(58, 59)
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
        Me.ButtonAction2.Location = New System.Drawing.Point(3, 133)
        Me.ButtonAction2.Name = "ButtonAction2"
        Me.ButtonAction2.Size = New System.Drawing.Size(58, 59)
        Me.ButtonAction2.TabIndex = 1
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
        Me.ButtonAction3.Location = New System.Drawing.Point(3, 68)
        Me.ButtonAction3.Name = "ButtonAction3"
        Me.ButtonAction3.Size = New System.Drawing.Size(58, 59)
        Me.ButtonAction3.TabIndex = 1
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
        Me.ButtonAction4.Size = New System.Drawing.Size(58, 59)
        Me.ButtonAction4.TabIndex = 1
        Me.ButtonAction4.TabStop = False
        Me.ButtonAction4.Tag = "4"
        Me.ButtonAction4.UseVisualStyleBackColor = False
        '
        'ScreenPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelActions)
        Me.Name = "ScreenPad"
        Me.Size = New System.Drawing.Size(64, 260)
        Me.TableLayoutPanelActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelActions As TableLayoutPanel
    Friend WithEvents ButtonAction1 As Button
    Friend WithEvents ButtonAction2 As Button
    Friend WithEvents ButtonAction3 As Button
    Friend WithEvents ButtonAction4 As Button
End Class
