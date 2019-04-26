<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmergenteConvertir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmergenteConvertir))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btVerListado = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidprospecto = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(348, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "OrdenCompra:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(348, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "Monto: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 15)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Descripción: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.btGuardar)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.btVerListado)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 66)
        Me.Panel2.TabIndex = 169
        '
        'btGuardar
        '
        Me.btGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btGuardar.FlatAppearance.BorderSize = 0
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.ForeColor = System.Drawing.Color.White
        Me.btGuardar.Location = New System.Drawing.Point(443, 12)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(116, 33)
        Me.btGuardar.TabIndex = 166
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(56, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(162, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Crear nueva oportunidad"
        '
        'btVerListado
        '
        Me.btVerListado.BackColor = System.Drawing.Color.White
        Me.btVerListado.Cursor = System.Windows.Forms.Cursors.Default
        Me.btVerListado.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btVerListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVerListado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerListado.ForeColor = System.Drawing.Color.Black
        Me.btVerListado.Location = New System.Drawing.Point(315, 12)
        Me.btVerListado.Name = "btVerListado"
        Me.btVerListado.Size = New System.Drawing.Size(130, 33)
        Me.btVerListado.TabIndex = 164
        Me.btVerListado.Text = "Ver listado"
        Me.btVerListado.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label27.Location = New System.Drawing.Point(56, 12)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Oportunidad"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(94, 85)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(231, 86)
        Me.txtDescripcion.TabIndex = 170
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(443, 85)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(116, 20)
        Me.txtOrdenCompra.TabIndex = 171
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(443, 117)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(116, 20)
        Me.txtMonto.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "$"
        '
        'txtidprospecto
        '
        Me.txtidprospecto.Location = New System.Drawing.Point(474, 151)
        Me.txtidprospecto.Name = "txtidprospecto"
        Me.txtidprospecto.Size = New System.Drawing.Size(85, 20)
        Me.txtidprospecto.TabIndex = 171
        '
        'FrmEmergenteConvertir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 183)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtidprospecto)
        Me.Controls.Add(Me.txtOrdenCompra)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEmergenteConvertir"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btGuardar As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents btVerListado As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidprospecto As TextBox
End Class
