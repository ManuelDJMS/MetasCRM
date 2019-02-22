<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCotizacion2018
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacion2018))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabAuxiliar = New System.Windows.Forms.TabPage()
        Me.txtNombreEmpleado = New System.Windows.Forms.Label()
        Me.cbDireccion = New System.Windows.Forms.CheckBox()
        Me.cbTelefono = New System.Windows.Forms.CheckBox()
        Me.cbCorreo = New System.Windows.Forms.CheckBox()
        Me.txtClaveProspecto = New System.Windows.Forms.TextBox()
        Me.txtClaveRecopila = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.cbNombre = New System.Windows.Forms.CheckBox()
        Me.txtNombreMod = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.Label()
        Me.cbCP = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtSaludo = New System.Windows.Forms.Label()
        Me.btabi = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCreador = New System.Windows.Forms.Label()
        Me.Tab2018 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbTodosArt = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbArticulo = New System.Windows.Forms.RadioButton()
        Me.rbCotizacion = New System.Windows.Forms.RadioButton()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCot = New System.Windows.Forms.Label()
        Me.DGCotizaciones = New System.Windows.Forms.DataGridView()
        Me.DGEmpresas = New System.Windows.Forms.DataGridView()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.rbFolios = New System.Windows.Forms.RadioButton()
        Me.TabAuxiliar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab2018.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsulta.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAuxiliar
        '
        Me.TabAuxiliar.BackColor = System.Drawing.Color.Gainsboro
        Me.TabAuxiliar.Controls.Add(Me.txtNombreEmpleado)
        Me.TabAuxiliar.Controls.Add(Me.cbDireccion)
        Me.TabAuxiliar.Controls.Add(Me.cbTelefono)
        Me.TabAuxiliar.Controls.Add(Me.cbCorreo)
        Me.TabAuxiliar.Controls.Add(Me.txtClaveProspecto)
        Me.TabAuxiliar.Controls.Add(Me.txtClaveRecopila)
        Me.TabAuxiliar.Controls.Add(Me.TextBox6)
        Me.TabAuxiliar.Controls.Add(Me.cbNombre)
        Me.TabAuxiliar.Controls.Add(Me.txtNombreMod)
        Me.TabAuxiliar.Controls.Add(Me.Label5)
        Me.TabAuxiliar.Controls.Add(Me.txtApellidos)
        Me.TabAuxiliar.Controls.Add(Me.cbCP)
        Me.TabAuxiliar.Controls.Add(Me.Panel1)
        Me.TabAuxiliar.Controls.Add(Me.btabi)
        Me.TabAuxiliar.Controls.Add(Me.Label18)
        Me.TabAuxiliar.Controls.Add(Me.txtCreador)
        Me.TabAuxiliar.Location = New System.Drawing.Point(4, 24)
        Me.TabAuxiliar.Margin = New System.Windows.Forms.Padding(0)
        Me.TabAuxiliar.Name = "TabAuxiliar"
        Me.TabAuxiliar.Size = New System.Drawing.Size(1140, 606)
        Me.TabAuxiliar.TabIndex = 2
        Me.TabAuxiliar.Text = "Auxiliar"
        Me.TabAuxiliar.ToolTipText = "Registrar un nuevo Cliente/Empresa"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.AutoSize = True
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(1001, 567)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(113, 17)
        Me.txtNombreEmpleado.TabIndex = 142
        Me.txtNombreEmpleado.Text = "Nombre Empleado"
        Me.txtNombreEmpleado.Visible = False
        '
        'cbDireccion
        '
        Me.cbDireccion.AutoSize = True
        Me.cbDireccion.Enabled = False
        Me.cbDireccion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbDireccion.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbDireccion.Location = New System.Drawing.Point(1011, 567)
        Me.cbDireccion.Name = "cbDireccion"
        Me.cbDireccion.Size = New System.Drawing.Size(85, 22)
        Me.cbDireccion.TabIndex = 135
        Me.cbDireccion.Text = "Dirección"
        Me.cbDireccion.UseVisualStyleBackColor = True
        Me.cbDireccion.Visible = False
        '
        'cbTelefono
        '
        Me.cbTelefono.AutoSize = True
        Me.cbTelefono.Enabled = False
        Me.cbTelefono.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbTelefono.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbTelefono.Location = New System.Drawing.Point(1001, 564)
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(82, 22)
        Me.cbTelefono.TabIndex = 134
        Me.cbTelefono.Text = "Teléfono"
        Me.cbTelefono.UseVisualStyleBackColor = True
        Me.cbTelefono.Visible = False
        '
        'cbCorreo
        '
        Me.cbCorreo.AutoSize = True
        Me.cbCorreo.Enabled = False
        Me.cbCorreo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbCorreo.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbCorreo.Location = New System.Drawing.Point(1031, 566)
        Me.cbCorreo.Name = "cbCorreo"
        Me.cbCorreo.Size = New System.Drawing.Size(69, 22)
        Me.cbCorreo.TabIndex = 60
        Me.cbCorreo.Text = "Correo"
        Me.cbCorreo.UseVisualStyleBackColor = True
        Me.cbCorreo.Visible = False
        '
        'txtClaveProspecto
        '
        Me.txtClaveProspecto.Enabled = False
        Me.txtClaveProspecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveProspecto.Location = New System.Drawing.Point(994, 569)
        Me.txtClaveProspecto.Name = "txtClaveProspecto"
        Me.txtClaveProspecto.Size = New System.Drawing.Size(118, 20)
        Me.txtClaveProspecto.TabIndex = 134
        Me.txtClaveProspecto.Visible = False
        '
        'txtClaveRecopila
        '
        Me.txtClaveRecopila.Enabled = False
        Me.txtClaveRecopila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveRecopila.Location = New System.Drawing.Point(996, 573)
        Me.txtClaveRecopila.Name = "txtClaveRecopila"
        Me.txtClaveRecopila.Size = New System.Drawing.Size(118, 20)
        Me.txtClaveRecopila.TabIndex = 134
        Me.txtClaveRecopila.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1006, 576)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(116, 20)
        Me.TextBox6.TabIndex = 51
        Me.TextBox6.Visible = False
        '
        'cbNombre
        '
        Me.cbNombre.AutoSize = True
        Me.cbNombre.Enabled = False
        Me.cbNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbNombre.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbNombre.Location = New System.Drawing.Point(1031, 573)
        Me.cbNombre.Name = "cbNombre"
        Me.cbNombre.Size = New System.Drawing.Size(78, 22)
        Me.cbNombre.TabIndex = 61
        Me.cbNombre.Text = "Nombre"
        Me.cbNombre.UseVisualStyleBackColor = True
        Me.cbNombre.Visible = False
        '
        'txtNombreMod
        '
        Me.txtNombreMod.AutoSize = True
        Me.txtNombreMod.Enabled = False
        Me.txtNombreMod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreMod.Location = New System.Drawing.Point(998, 571)
        Me.txtNombreMod.Name = "txtNombreMod"
        Me.txtNombreMod.Size = New System.Drawing.Size(57, 18)
        Me.txtNombreMod.TabIndex = 141
        Me.txtNombreMod.Text = "nombre"
        Me.txtNombreMod.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(992, 573)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Clave de Prospecto:"
        Me.Label5.Visible = False
        '
        'txtApellidos
        '
        Me.txtApellidos.AutoSize = True
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtApellidos.Location = New System.Drawing.Point(998, 571)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(65, 18)
        Me.txtApellidos.TabIndex = 141
        Me.txtApellidos.Text = "apellidos"
        Me.txtApellidos.Visible = False
        '
        'cbCP
        '
        Me.cbCP.AutoSize = True
        Me.cbCP.Enabled = False
        Me.cbCP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbCP.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbCP.Location = New System.Drawing.Point(1011, 576)
        Me.cbCP.Name = "cbCP"
        Me.cbCP.Size = New System.Drawing.Size(111, 22)
        Me.cbCP.TabIndex = 136
        Me.cbCP.Text = "Código postal"
        Me.cbCP.UseVisualStyleBackColor = True
        Me.cbCP.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Controls.Add(Me.txtSaludo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 66)
        Me.Panel1.TabIndex = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 18)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Confirmación de datos"
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(85, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(0, 18)
        Me.txtNombre.TabIndex = 135
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label47.Location = New System.Drawing.Point(55, 15)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(93, 15)
        Me.Label47.TabIndex = 152
        Me.Label47.Text = "Cotización 2018"
        '
        'txtSaludo
        '
        Me.txtSaludo.AutoSize = True
        Me.txtSaludo.Enabled = False
        Me.txtSaludo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSaludo.Location = New System.Drawing.Point(55, 32)
        Me.txtSaludo.Name = "txtSaludo"
        Me.txtSaludo.Size = New System.Drawing.Size(0, 18)
        Me.txtSaludo.TabIndex = 153
        '
        'btabi
        '
        Me.btabi.BackColor = System.Drawing.Color.CadetBlue
        Me.btabi.Enabled = False
        Me.btabi.FlatAppearance.BorderSize = 0
        Me.btabi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btabi.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btabi.ForeColor = System.Drawing.Color.White
        Me.btabi.Location = New System.Drawing.Point(1031, 566)
        Me.btabi.Name = "btabi"
        Me.btabi.Size = New System.Drawing.Size(79, 39)
        Me.btabi.TabIndex = 65
        Me.btabi.Text = "Habilitar textos"
        Me.btabi.UseVisualStyleBackColor = False
        Me.btabi.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1018, 578)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 18)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Cuenta:"
        Me.Label18.Visible = False
        '
        'txtCreador
        '
        Me.txtCreador.AutoSize = True
        Me.txtCreador.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreador.Location = New System.Drawing.Point(1069, 581)
        Me.txtCreador.Name = "txtCreador"
        Me.txtCreador.Size = New System.Drawing.Size(45, 14)
        Me.txtCreador.TabIndex = 145
        Me.txtCreador.Text = "Creador"
        Me.txtCreador.Visible = False
        '
        'Tab2018
        '
        Me.Tab2018.BackColor = System.Drawing.Color.Gainsboro
        Me.Tab2018.Controls.Add(Me.Label1)
        Me.Tab2018.Controls.Add(Me.TextID)
        Me.Tab2018.Controls.Add(Me.Panel3)
        Me.Tab2018.Controls.Add(Me.txtClave)
        Me.Tab2018.Controls.Add(Me.Label4)
        Me.Tab2018.Controls.Add(Me.lblCot)
        Me.Tab2018.Controls.Add(Me.DGCotizaciones)
        Me.Tab2018.Controls.Add(Me.DGEmpresas)
        Me.Tab2018.Controls.Add(Me.lblModelo)
        Me.Tab2018.Controls.Add(Me.txtModelo)
        Me.Tab2018.Controls.Add(Me.Panel2)
        Me.Tab2018.Controls.Add(Me.lblMarca)
        Me.Tab2018.Controls.Add(Me.txtMarca)
        Me.Tab2018.Controls.Add(Me.txtNombreE)
        Me.Tab2018.Controls.Add(Me.LabelNombre)
        Me.Tab2018.Location = New System.Drawing.Point(4, 24)
        Me.Tab2018.Name = "Tab2018"
        Me.Tab2018.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2018.Size = New System.Drawing.Size(1140, 606)
        Me.Tab2018.TabIndex = 5
        Me.Tab2018.Text = "Búsqueda Cotizaciones 2018"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(690, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "ID:"
        '
        'TextID
        '
        Me.TextID.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(712, 349)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(158, 21)
        Me.TextID.TabIndex = 165
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbFolios)
        Me.Panel3.Controls.Add(Me.rbTodosArt)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.rbArticulo)
        Me.Panel3.Controls.Add(Me.rbCotizacion)
        Me.Panel3.Location = New System.Drawing.Point(3, 299)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(624, 44)
        Me.Panel3.TabIndex = 162
        '
        'rbTodosArt
        '
        Me.rbTodosArt.AutoSize = True
        Me.rbTodosArt.Location = New System.Drawing.Point(373, 11)
        Me.rbTodosArt.Name = "rbTodosArt"
        Me.rbTodosArt.Size = New System.Drawing.Size(123, 19)
        Me.rbTodosArt.TabIndex = 165
        Me.rbTodosArt.Text = "Todos los Artículos"
        Me.rbTodosArt.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Buscar por:"
        '
        'rbArticulo
        '
        Me.rbArticulo.AutoSize = True
        Me.rbArticulo.Location = New System.Drawing.Point(264, 12)
        Me.rbArticulo.Name = "rbArticulo"
        Me.rbArticulo.Size = New System.Drawing.Size(66, 19)
        Me.rbArticulo.TabIndex = 1
        Me.rbArticulo.Text = "Articulo"
        Me.rbArticulo.UseVisualStyleBackColor = True
        '
        'rbCotizacion
        '
        Me.rbCotizacion.AutoSize = True
        Me.rbCotizacion.Checked = True
        Me.rbCotizacion.Location = New System.Drawing.Point(150, 11)
        Me.rbCotizacion.Name = "rbCotizacion"
        Me.rbCotizacion.Size = New System.Drawing.Size(80, 19)
        Me.rbCotizacion.TabIndex = 0
        Me.rbCotizacion.TabStop = True
        Me.rbCotizacion.Text = "Cotización"
        Me.rbCotizacion.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(127, 89)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(72, 21)
        Me.txtClave.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Clave:"
        '
        'lblCot
        '
        Me.lblCot.AutoSize = True
        Me.lblCot.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCot.Location = New System.Drawing.Point(11, 348)
        Me.lblCot.Name = "lblCot"
        Me.lblCot.Size = New System.Drawing.Size(90, 18)
        Me.lblCot.TabIndex = 156
        Me.lblCot.Text = "Cotizaciones:"
        '
        'DGCotizaciones
        '
        Me.DGCotizaciones.AllowUserToDeleteRows = False
        Me.DGCotizaciones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCotizaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCotizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCotizaciones.Location = New System.Drawing.Point(14, 390)
        Me.DGCotizaciones.Name = "DGCotizaciones"
        Me.DGCotizaciones.ReadOnly = True
        Me.DGCotizaciones.Size = New System.Drawing.Size(884, 206)
        Me.DGCotizaciones.TabIndex = 155
        '
        'DGEmpresas
        '
        Me.DGEmpresas.AllowUserToDeleteRows = False
        Me.DGEmpresas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpresas.Location = New System.Drawing.Point(14, 124)
        Me.DGEmpresas.Name = "DGEmpresas"
        Me.DGEmpresas.ReadOnly = True
        Me.DGEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEmpresas.Size = New System.Drawing.Size(955, 169)
        Me.DGEmpresas.TabIndex = 154
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(410, 351)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(47, 14)
        Me.lblModelo.TabIndex = 153
        Me.lblModelo.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(463, 349)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(194, 21)
        Me.txtModelo.TabIndex = 152
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 66)
        Me.Panel2.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(213, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Exportar Cotizaciones 2018 a 2019"
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
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label27.Location = New System.Drawing.Point(55, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(144, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Cotizaciones MetAs 2018"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(142, 351)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(41, 14)
        Me.lblMarca.TabIndex = 132
        Me.lblMarca.Text = "Marca:"
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(189, 349)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(189, 21)
        Me.txtMarca.TabIndex = 129
        '
        'txtNombreE
        '
        Me.txtNombreE.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreE.Location = New System.Drawing.Point(296, 89)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(203, 21)
        Me.txtNombreE.TabIndex = 126
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(225, 88)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(65, 18)
        Me.LabelNombre.TabIndex = 125
        Me.LabelNombre.Text = "Empresa:"
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Controls.Add(Me.Tab2018)
        Me.TabConsulta.Controls.Add(Me.TabAuxiliar)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(4, 27)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 634)
        Me.TabConsulta.TabIndex = 43
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Cursor = System.Windows.Forms.Cursors.No
        Me.Label49.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1029, 10)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 14)
        Me.Label49.TabIndex = 142
        Me.Label49.Text = "Cerrar formulario"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1125, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 141
        Me.PictureBox5.TabStop = False
        '
        'rbFolios
        '
        Me.rbFolios.AutoSize = True
        Me.rbFolios.Location = New System.Drawing.Point(531, 11)
        Me.rbFolios.Name = "rbFolios"
        Me.rbFolios.Size = New System.Drawing.Size(54, 19)
        Me.rbFolios.TabIndex = 166
        Me.rbFolios.Text = "Folio:"
        Me.rbFolios.UseVisualStyleBackColor = True
        '
        'FrmCotizacion2018
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.Name = "FrmCotizacion2018"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCotizacion2018"
        Me.TabAuxiliar.ResumeLayout(False)
        Me.TabAuxiliar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab2018.ResumeLayout(False)
        Me.Tab2018.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsulta.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabAuxiliar As TabPage
    Friend WithEvents txtNombreEmpleado As Label
    Friend WithEvents cbDireccion As CheckBox
    Friend WithEvents cbTelefono As CheckBox
    Friend WithEvents cbCorreo As CheckBox
    Friend WithEvents txtClaveProspecto As TextBox
    Friend WithEvents txtClaveRecopila As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents cbNombre As CheckBox
    Friend WithEvents txtNombreMod As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidos As Label
    Friend WithEvents cbCP As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtSaludo As Label
    Friend WithEvents btabi As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCreador As Label
    Friend WithEvents Tab2018 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCot As Label
    Friend WithEvents DGCotizaciones As DataGridView
    Friend WithEvents DGEmpresas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rbArticulo As RadioButton
    Friend WithEvents rbCotizacion As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents rbTodosArt As RadioButton
    Friend WithEvents rbFolios As RadioButton
End Class
