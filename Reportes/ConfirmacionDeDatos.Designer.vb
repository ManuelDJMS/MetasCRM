<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmacionDeDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmacionDeDatos))
        Me.txtOV = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumGuia = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOV
        '
        Me.txtOV.Location = New System.Drawing.Point(127, 72)
        Me.txtOV.Name = "txtOV"
        Me.txtOV.Size = New System.Drawing.Size(100, 20)
        Me.txtOV.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 18)
        Me.Label26.TabIndex = 166
        Me.Label26.Text = "Número de OV:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Número de guía:"
        '
        'txtNumGuia
        '
        Me.txtNumGuia.Location = New System.Drawing.Point(127, 98)
        Me.txtNumGuia.Name = "txtNumGuia"
        Me.txtNumGuia.Size = New System.Drawing.Size(100, 20)
        Me.txtNumGuia.TabIndex = 167
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.ForeColor = System.Drawing.Color.White
        Me.cmdBuscar.Location = New System.Drawing.Point(233, 81)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(100, 25)
        Me.cmdBuscar.TabIndex = 169
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(12, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 59)
        Me.Panel2.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 17)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Confirmación de datos y Hoja de transito"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label27.Location = New System.Drawing.Point(55, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 14)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Orden de Venta"
        '
        'ConfirmacionDeDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 141)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumGuia)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtOV)
        Me.Name = "ConfirmacionDeDatos"
        Me.Text = "Confirmacion De Datos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOV As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumGuia As TextBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
End Class
