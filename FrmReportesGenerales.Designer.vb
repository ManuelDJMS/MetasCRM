<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesGenerales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreAdmin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logeo de Usuario Administrador Sandra"
        '
        'txtNombreAdmin
        '
        Me.txtNombreAdmin.AutoSize = True
        Me.txtNombreAdmin.Location = New System.Drawing.Point(326, 145)
        Me.txtNombreAdmin.Name = "txtNombreAdmin"
        Me.txtNombreAdmin.Size = New System.Drawing.Size(194, 13)
        Me.txtNombreAdmin.TabIndex = 1
        Me.txtNombreAdmin.Text = "Logeo de Usuario Administrador Sandra"
        '
        'FrmReportesGenerales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 195)
        Me.Controls.Add(Me.txtNombreAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmReportesGenerales"
        Me.Text = "FrmReportesGenerales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreAdmin As Label
End Class
