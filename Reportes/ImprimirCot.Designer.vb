<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirCot
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.txtCot = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCot
        '
        Me.txtCot.Location = New System.Drawing.Point(30, 12)
        Me.txtCot.Name = "txtCot"
        Me.txtCot.Size = New System.Drawing.Size(100, 20)
        Me.txtCot.TabIndex = 0
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(147, 10)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 1
        Me.cmdBuscar.Text = "Button1"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'ImprimirCot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 54)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtCot)
        Me.Name = "ImprimirCot"
        Me.Text = "ImprimirCot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCot As TextBox
    Friend WithEvents cmdBuscar As Button
End Class
