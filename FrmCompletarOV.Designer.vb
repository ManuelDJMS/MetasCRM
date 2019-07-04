<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompletarOV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompletarOV))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCotizacion = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCot = New System.Windows.Forms.Panel()
        Me.terminosPago = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numCuenta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombreCompania = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumOV = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.var = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.embarcarPor = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboRecepcion = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtVolumen = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCantCajas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboRecibidoPor = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRefCot = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFechaRecep = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelCot.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(518, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Salir"
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.Transparent
        Me.btSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalir.Image = CType(resources.GetObject("btSalir.Image"), System.Drawing.Image)
        Me.btSalir.Location = New System.Drawing.Point(557, 12)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(24, 24)
        Me.btSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btSalir.TabIndex = 165
        Me.btSalir.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btCotizacion)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PanelCot)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(5, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 558)
        Me.Panel1.TabIndex = 167
        '
        'btCotizacion
        '
        Me.btCotizacion.BackColor = System.Drawing.Color.SteelBlue
        Me.btCotizacion.FlatAppearance.BorderSize = 0
        Me.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCotizacion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCotizacion.ForeColor = System.Drawing.Color.White
        Me.btCotizacion.Location = New System.Drawing.Point(461, 516)
        Me.btCotizacion.Name = "btCotizacion"
        Me.btCotizacion.Size = New System.Drawing.Size(111, 33)
        Me.btCotizacion.TabIndex = 179
        Me.btCotizacion.Text = "ENVIAR"
        Me.btCotizacion.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(6, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(566, 27)
        Me.Panel3.TabIndex = 177
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(8, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 15)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Datos de recepción"
        '
        'PanelCot
        '
        Me.PanelCot.Controls.Add(Me.terminosPago)
        Me.PanelCot.Controls.Add(Me.Label5)
        Me.PanelCot.Controls.Add(Me.numCuenta)
        Me.PanelCot.Controls.Add(Me.Label2)
        Me.PanelCot.Controls.Add(Me.txtCorreo)
        Me.PanelCot.Controls.Add(Me.Label9)
        Me.PanelCot.Controls.Add(Me.txtDireccion)
        Me.PanelCot.Controls.Add(Me.Label10)
        Me.PanelCot.Controls.Add(Me.txtNombreCompania)
        Me.PanelCot.Controls.Add(Me.Label12)
        Me.PanelCot.Location = New System.Drawing.Point(6, 88)
        Me.PanelCot.Name = "PanelCot"
        Me.PanelCot.Size = New System.Drawing.Size(566, 86)
        Me.PanelCot.TabIndex = 177
        '
        'terminosPago
        '
        Me.terminosPago.AutoSize = True
        Me.terminosPago.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminosPago.Location = New System.Drawing.Point(460, 33)
        Me.terminosPago.Name = "terminosPago"
        Me.terminosPago.Size = New System.Drawing.Size(96, 14)
        Me.terminosPago.TabIndex = 166
        Me.terminosPago.Text = "Correo electronico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(357, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 15)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Términos de pago :"
        '
        'numCuenta
        '
        Me.numCuenta.AutoSize = True
        Me.numCuenta.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuenta.Location = New System.Drawing.Point(460, 10)
        Me.numCuenta.Name = "numCuenta"
        Me.numCuenta.Size = New System.Drawing.Size(95, 15)
        Me.numCuenta.TabIndex = 165
        Me.numCuenta.Text = "Núm. de Cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Núm. de Cuenta:"
        '
        'txtCorreo
        '
        Me.txtCorreo.AutoSize = True
        Me.txtCorreo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(83, 34)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(96, 14)
        Me.txtCorreo.TabIndex = 162
        Me.txtCorreo.Text = "Correo electronico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Correo:"
        '
        'txtDireccion
        '
        Me.txtDireccion.AutoSize = True
        Me.txtDireccion.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(83, 58)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(52, 14)
        Me.txtDireccion.TabIndex = 158
        Me.txtDireccion.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Dirección:"
        '
        'txtNombreCompania
        '
        Me.txtNombreCompania.AutoSize = True
        Me.txtNombreCompania.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompania.Location = New System.Drawing.Point(83, 10)
        Me.txtNombreCompania.Name = "txtNombreCompania"
        Me.txtNombreCompania.Size = New System.Drawing.Size(125, 14)
        Me.txtNombreCompania.TabIndex = 156
        Me.txtNombreCompania.Text = "Nombre de la compañia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 15)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Compañia:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(6, 55)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(566, 27)
        Me.Panel5.TabIndex = 176
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(8, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 15)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Información del cliente"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NumOV)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.var)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(569, 46)
        Me.Panel2.TabIndex = 0
        '
        'NumOV
        '
        Me.NumOV.AutoSize = True
        Me.NumOV.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOV.Location = New System.Drawing.Point(538, 18)
        Me.NumOV.Name = "NumOV"
        Me.NumOV.Size = New System.Drawing.Size(20, 14)
        Me.NumOV.TabIndex = 168
        Me.NumOV.Text = "ov"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(44, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(228, 18)
        Me.Label26.TabIndex = 168
        Me.Label26.Text = "Completar datos de Orden de venta"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(462, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 15)
        Me.Label22.TabIndex = 169
        Me.Label22.Text = "NÚM. OV:"
        '
        'var
        '
        Me.var.AutoSize = True
        Me.var.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var.Location = New System.Drawing.Point(539, 3)
        Me.var.Name = "var"
        Me.var.Size = New System.Drawing.Size(20, 14)
        Me.var.TabIndex = 170
        Me.var.Text = "ov"
        Me.var.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 166
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label27.Location = New System.Drawing.Point(44, 2)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 15)
        Me.Label27.TabIndex = 167
        Me.Label27.Text = "Orden de venta"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtObservaciones)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.embarcarPor)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.cboRecepcion)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtVolumen)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.txtPeso)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.txtCantCajas)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.cboRecibidoPor)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.txtRefCot)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.dtpFechaRecep)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtOrdenCompra)
        Me.Panel4.Location = New System.Drawing.Point(6, 213)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(566, 297)
        Me.Panel4.TabIndex = 178
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(133, 202)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(200, 86)
        Me.txtObservaciones.TabIndex = 195
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "Orden de compra:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 199)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 15)
        Me.Label20.TabIndex = 194
        Me.Label20.Text = "Observaciones:"
        '
        'embarcarPor
        '
        Me.embarcarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.embarcarPor.FormattingEnabled = True
        Me.embarcarPor.Location = New System.Drawing.Point(133, 174)
        Me.embarcarPor.Name = "embarcarPor"
        Me.embarcarPor.Size = New System.Drawing.Size(200, 21)
        Me.embarcarPor.TabIndex = 193
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 15)
        Me.Label19.TabIndex = 192
        Me.Label19.Text = "Embarcar por:"
        '
        'cboRecepcion
        '
        Me.cboRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecepcion.FormattingEnabled = True
        Me.cboRecepcion.Location = New System.Drawing.Point(133, 146)
        Me.cboRecepcion.Name = "cboRecepcion"
        Me.cboRecepcion.Size = New System.Drawing.Size(200, 21)
        Me.cboRecepcion.TabIndex = 191
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 15)
        Me.Label18.TabIndex = 190
        Me.Label18.Text = "Medio de recepción:"
        '
        'txtVolumen
        '
        Me.txtVolumen.Location = New System.Drawing.Point(462, 112)
        Me.txtVolumen.Name = "txtVolumen"
        Me.txtVolumen.Size = New System.Drawing.Size(93, 20)
        Me.txtVolumen.TabIndex = 189
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(391, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 188
        Me.Label17.Text = "Volumen:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(133, 119)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(200, 20)
        Me.txtPeso.TabIndex = 187
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 15)
        Me.Label16.TabIndex = 186
        Me.Label16.Text = "Peso:"
        '
        'txtCantCajas
        '
        Me.txtCantCajas.Location = New System.Drawing.Point(133, 92)
        Me.txtCantCajas.Name = "txtCantCajas"
        Me.txtCantCajas.Size = New System.Drawing.Size(200, 20)
        Me.txtCantCajas.TabIndex = 185
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 15)
        Me.Label15.TabIndex = 184
        Me.Label15.Text = "Cantidad de cajas:"
        '
        'cboRecibidoPor
        '
        Me.cboRecibidoPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecibidoPor.FormattingEnabled = True
        Me.cboRecibidoPor.Items.AddRange(New Object() {"Susana", "Osvaldo", "Karina"})
        Me.cboRecibidoPor.Location = New System.Drawing.Point(133, 64)
        Me.cboRecibidoPor.Name = "cboRecibidoPor"
        Me.cboRecibidoPor.Size = New System.Drawing.Size(200, 21)
        Me.cboRecibidoPor.TabIndex = 183
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 182
        Me.Label14.Text = "Recibido por:"
        '
        'txtRefCot
        '
        Me.txtRefCot.Location = New System.Drawing.Point(462, 10)
        Me.txtRefCot.Name = "txtRefCot"
        Me.txtRefCot.Size = New System.Drawing.Size(93, 20)
        Me.txtRefCot.TabIndex = 181
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(391, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 15)
        Me.Label13.TabIndex = 179
        Me.Label13.Text = "Cotización:"
        '
        'dtpFechaRecep
        '
        Me.dtpFechaRecep.Location = New System.Drawing.Point(133, 37)
        Me.dtpFechaRecep.Name = "dtpFechaRecep"
        Me.dtpFechaRecep.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaRecep.TabIndex = 180
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "Fecha recepción:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(133, 10)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(200, 20)
        Me.txtOrdenCompra.TabIndex = 0
        '
        'FrmCompletarOV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(599, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompletarOV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Completar OV"
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelCot.ResumeLayout(False)
        Me.PanelCot.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btSalir As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents PanelCot As Panel
    Friend WithEvents txtCorreo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccion As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombreCompania As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents numCuenta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents terminosPago As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCantCajas As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboRecibidoPor As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRefCot As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaRecep As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents embarcarPor As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboRecepcion As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtVolumen As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btCotizacion As Button
    Friend WithEvents NumOV As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents var As Label
End Class
