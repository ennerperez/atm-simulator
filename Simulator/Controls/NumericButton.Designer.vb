<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NumericButton
    Inherits Button

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
        Me.SuspendLayout()
        '
        'NumericButton
        '
        Me.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.FlatAppearance.BorderSize = 0
        Me.ResumeLayout(False)

    End Sub

End Class
