<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFiltrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFiltrar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextCP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextEmpresa = New System.Windows.Forms.TextBox()
        Me.btGuardarInf = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.dgEmpresas = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.dgEmpresas)
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 409)
        Me.Panel1.TabIndex = 162
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Controls.Add(Me.TextCP)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.TextDireccion)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.TextCorreo)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.txtidCliente)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.TextEmpresa)
        Me.Panel7.Controls.Add(Me.btGuardarInf)
        Me.Panel7.Controls.Add(Me.Label36)
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label38)
        Me.Panel7.Location = New System.Drawing.Point(2, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(979, 85)
        Me.Panel7.TabIndex = 172
        '
        'TextCP
        '
        Me.TextCP.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCP.Location = New System.Drawing.Point(856, 55)
        Me.TextCP.Name = "TextCP"
        Me.TextCP.Size = New System.Drawing.Size(99, 21)
        Me.TextCP.TabIndex = 179
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(825, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 14)
        Me.Label7.TabIndex = 180
        Me.Label7.Text = "CP:"
        '
        'TextDireccion
        '
        Me.TextDireccion.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDireccion.Location = New System.Drawing.Point(696, 55)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(123, 21)
        Me.TextDireccion.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(630, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 14)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Dirección:"
        '
        'TextCorreo
        '
        Me.TextCorreo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCorreo.Location = New System.Drawing.Point(501, 55)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(123, 21)
        Me.TextCorreo.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 14)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Buscar por:"
        '
        'txtidCliente
        '
        Me.txtidCliente.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidCliente.Location = New System.Drawing.Point(141, 55)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(56, 21)
        Me.txtidCliente.TabIndex = 173
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "idCliente:"
        '
        'TextEmpresa
        '
        Me.TextEmpresa.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmpresa.Location = New System.Drawing.Point(314, 55)
        Me.TextEmpresa.Name = "TextEmpresa"
        Me.TextEmpresa.Size = New System.Drawing.Size(129, 21)
        Me.TextEmpresa.TabIndex = 170
        '
        'btGuardarInf
        '
        Me.btGuardarInf.BackColor = System.Drawing.Color.SteelBlue
        Me.btGuardarInf.FlatAppearance.BorderSize = 0
        Me.btGuardarInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardarInf.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardarInf.ForeColor = System.Drawing.Color.White
        Me.btGuardarInf.Location = New System.Drawing.Point(1041, 10)
        Me.btGuardarInf.Name = "btGuardarInf"
        Me.btGuardarInf.Size = New System.Drawing.Size(151, 33)
        Me.btGuardarInf.TabIndex = 166
        Me.btGuardarInf.Text = "Guardar Cotización"
        Me.btGuardarInf.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Enabled = False
        Me.Label36.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(47, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(150, 18)
        Me.Label36.TabIndex = 165
        Me.Label36.Text = "Búsqueda de contactos"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(197, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 14)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Nombre Empresa:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label38.Location = New System.Drawing.Point(47, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(61, 15)
        Me.Label38.TabIndex = 152
        Me.Label38.Text = "Contactos"
        '
        'dgEmpresas
        '
        Me.dgEmpresas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgEmpresas.Location = New System.Drawing.Point(3, 96)
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.Size = New System.Drawing.Size(978, 306)
        Me.dgEmpresas.TabIndex = 156
        '
        'Column2
        '
        Me.Column2.HeaderText = "idCliente"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Compañía"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 140
        '
        'Column3
        '
        Me.Column3.HeaderText = "N° Cuenta"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Correo"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Dirección"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 220
        '
        'Column6
        '
        Me.Column6.HeaderText = "Código Postal"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(928, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Salir"
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.Transparent
        Me.btSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalir.Image = CType(resources.GetObject("btSalir.Image"), System.Drawing.Image)
        Me.btSalir.Location = New System.Drawing.Point(967, 2)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(24, 24)
        Me.btSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btSalir.TabIndex = 163
        Me.btSalir.TabStop = False
        '
        'FrmFiltrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(997, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFiltrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Artículos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgEmpresas As DataGridView
    Friend WithEvents TextEmpresa As TextBox
    Friend WithEvents txtidCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btSalir As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btGuardarInf As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents TextCP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents Label2 As Label
End Class
