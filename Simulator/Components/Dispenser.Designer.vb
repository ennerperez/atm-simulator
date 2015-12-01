<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispenser
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
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.PanelReader = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelStatus
        '
        Me.PanelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelStatus.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelStatus.Location = New System.Drawing.Point(322, 19)
        Me.PanelStatus.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(64, 8)
        Me.PanelStatus.TabIndex = 4
        '
        'PanelReader
        '
        Me.PanelReader.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PanelReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelReader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReader.Location = New System.Drawing.Point(0, 0)
        Me.PanelReader.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelReader.Name = "PanelReader"
        Me.PanelReader.Size = New System.Drawing.Size(386, 16)
        Me.PanelReader.TabIndex = 5
        '
        'MoneyDispenser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelStatus)
        Me.Controls.Add(Me.PanelReader)
        Me.Name = "MoneyDispenser"
        Me.Size = New System.Drawing.Size(386, 29)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelStatus As Panel
    Friend WithEvents PanelReader As Panel
End Class
