<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotPorFolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotPorFolio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.TabFolios = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbServicios = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lbPais = New System.Windows.Forms.Label()
        Me.lbDomicilio = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lbCiudad = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lbCP = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lbClave = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbRFC = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbEmpresa = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btGuardarInf = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btCerrar = New System.Windows.Forms.PictureBox()
        Me.lbContacto = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbClaveContacto = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.lbExt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCotizo2019 = New System.Windows.Forms.TextBox()
        Me.txtConta = New System.Windows.Forms.TextBox()
        Me.txtTipoCliente = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtCotizo = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.DGCotizaciones = New System.Windows.Forms.DataGridView()
        Me.ckSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.partida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.TabConsulta.SuspendLayout()
        Me.TabFolios.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Controls.Add(Me.TabFolios)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(3, 27)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1235, 661)
        Me.TabConsulta.TabIndex = 45
        '
        'TabFolios
        '
        Me.TabFolios.BackColor = System.Drawing.Color.Gainsboro
        Me.TabFolios.Controls.Add(Me.btEliminar)
        Me.TabFolios.Controls.Add(Me.DGCotizaciones)
        Me.TabFolios.Controls.Add(Me.Label2)
        Me.TabFolios.Controls.Add(Me.Label4)
        Me.TabFolios.Controls.Add(Me.Label5)
        Me.TabFolios.Controls.Add(Me.txtCotizo2019)
        Me.TabFolios.Controls.Add(Me.txtConta)
        Me.TabFolios.Controls.Add(Me.txtTipoCliente)
        Me.TabFolios.Controls.Add(Me.txtObservaciones)
        Me.TabFolios.Controls.Add(Me.Label6)
        Me.TabFolios.Controls.Add(Me.cboServicio)
        Me.TabFolios.Controls.Add(Me.Label7)
        Me.TabFolios.Controls.Add(Me.DTPDesde)
        Me.TabFolios.Controls.Add(Me.Label78)
        Me.TabFolios.Controls.Add(Me.Label79)
        Me.TabFolios.Controls.Add(Me.txtCotizo)
        Me.TabFolios.Controls.Add(Me.txtReferencia)
        Me.TabFolios.Controls.Add(Me.Label80)
        Me.TabFolios.Controls.Add(Me.lbExt)
        Me.TabFolios.Controls.Add(Me.lbTelefono)
        Me.TabFolios.Controls.Add(Me.Label53)
        Me.TabFolios.Controls.Add(Me.lbClaveContacto)
        Me.TabFolios.Controls.Add(Me.Label52)
        Me.TabFolios.Controls.Add(Me.lbContacto)
        Me.TabFolios.Controls.Add(Me.Label8)
        Me.TabFolios.Controls.Add(Me.Panel3)
        Me.TabFolios.Controls.Add(Me.lbServicios)
        Me.TabFolios.Controls.Add(Me.Panel1)
        Me.TabFolios.Controls.Add(Me.lbPais)
        Me.TabFolios.Controls.Add(Me.lbDomicilio)
        Me.TabFolios.Controls.Add(Me.Label50)
        Me.TabFolios.Controls.Add(Me.Label48)
        Me.TabFolios.Controls.Add(Me.lbCiudad)
        Me.TabFolios.Controls.Add(Me.Label44)
        Me.TabFolios.Controls.Add(Me.lbEstado)
        Me.TabFolios.Controls.Add(Me.Label39)
        Me.TabFolios.Controls.Add(Me.lbCP)
        Me.TabFolios.Controls.Add(Me.Label35)
        Me.TabFolios.Controls.Add(Me.lbClave)
        Me.TabFolios.Controls.Add(Me.Label29)
        Me.TabFolios.Controls.Add(Me.lbRFC)
        Me.TabFolios.Controls.Add(Me.Label25)
        Me.TabFolios.Controls.Add(Me.lbEmpresa)
        Me.TabFolios.Controls.Add(Me.Label20)
        Me.TabFolios.Controls.Add(Me.lbCorreo)
        Me.TabFolios.Controls.Add(Me.Label17)
        Me.TabFolios.Controls.Add(Me.Panel2)
        Me.TabFolios.Location = New System.Drawing.Point(4, 24)
        Me.TabFolios.Name = "TabFolios"
        Me.TabFolios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFolios.Size = New System.Drawing.Size(1227, 633)
        Me.TabFolios.TabIndex = 5
        Me.TabFolios.Text = "Cotización por Folio"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(658, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(533, 27)
        Me.Panel3.TabIndex = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Datos Cotización"
        '
        'lbServicios
        '
        Me.lbServicios.AutoSize = True
        Me.lbServicios.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbServicios.Location = New System.Drawing.Point(20, 328)
        Me.lbServicios.Name = "lbServicios"
        Me.lbServicios.Size = New System.Drawing.Size(58, 15)
        Me.lbServicios.TabIndex = 172
        Me.lbServicios.Text = "Servicios:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Location = New System.Drawing.Point(20, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 27)
        Me.Panel1.TabIndex = 170
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label42.Location = New System.Drawing.Point(6, 6)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(132, 15)
        Me.Label42.TabIndex = 152
        Me.Label42.Text = "Información del cliente"
        '
        'lbPais
        '
        Me.lbPais.AutoSize = True
        Me.lbPais.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPais.Location = New System.Drawing.Point(330, 137)
        Me.lbPais.Name = "lbPais"
        Me.lbPais.Size = New System.Drawing.Size(27, 14)
        Me.lbPais.TabIndex = 169
        Me.lbPais.Text = "Pais"
        '
        'lbDomicilio
        '
        Me.lbDomicilio.AutoSize = True
        Me.lbDomicilio.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDomicilio.Location = New System.Drawing.Point(105, 173)
        Me.lbDomicilio.Name = "lbDomicilio"
        Me.lbDomicilio.Size = New System.Drawing.Size(53, 14)
        Me.lbDomicilio.TabIndex = 169
        Me.lbDomicilio.Text = "Domicilio"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label50.Location = New System.Drawing.Point(296, 135)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(32, 15)
        Me.Label50.TabIndex = 168
        Me.Label50.Text = "Pais:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label48.Location = New System.Drawing.Point(20, 172)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(61, 15)
        Me.Label48.TabIndex = 168
        Me.Label48.Text = "Domicilio:"
        '
        'lbCiudad
        '
        Me.lbCiudad.AutoSize = True
        Me.lbCiudad.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCiudad.Location = New System.Drawing.Point(105, 192)
        Me.lbCiudad.Name = "lbCiudad"
        Me.lbCiudad.Size = New System.Drawing.Size(39, 14)
        Me.lbCiudad.TabIndex = 167
        Me.lbCiudad.Text = "ciudad"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label44.Location = New System.Drawing.Point(20, 191)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 15)
        Me.Label44.TabIndex = 166
        Me.Label44.Text = "Ciudad:"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.Location = New System.Drawing.Point(105, 210)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 14)
        Me.lbEstado.TabIndex = 165
        Me.lbEstado.Text = "estado"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(20, 209)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(47, 15)
        Me.Label39.TabIndex = 164
        Me.Label39.Text = "Estado:"
        '
        'lbCP
        '
        Me.lbCP.AutoSize = True
        Me.lbCP.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCP.Location = New System.Drawing.Point(105, 229)
        Me.lbCP.Name = "lbCP"
        Me.lbCP.Size = New System.Drawing.Size(73, 14)
        Me.lbCP.TabIndex = 163
        Me.lbCP.Text = "Código postal"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label35.Location = New System.Drawing.Point(20, 228)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(25, 15)
        Me.Label35.TabIndex = 162
        Me.Label35.Text = "CP:"
        '
        'lbClave
        '
        Me.lbClave.AutoSize = True
        Me.lbClave.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClave.Location = New System.Drawing.Point(105, 119)
        Me.lbClave.Name = "lbClave"
        Me.lbClave.Size = New System.Drawing.Size(33, 14)
        Me.lbClave.TabIndex = 155
        Me.lbClave.Text = "Clave"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label29.Location = New System.Drawing.Point(20, 118)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 15)
        Me.Label29.TabIndex = 154
        Me.Label29.Text = "Clave:"
        '
        'lbRFC
        '
        Me.lbRFC.AutoSize = True
        Me.lbRFC.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRFC.Location = New System.Drawing.Point(330, 120)
        Me.lbRFC.Name = "lbRFC"
        Me.lbRFC.Size = New System.Drawing.Size(25, 14)
        Me.lbRFC.TabIndex = 159
        Me.lbRFC.Text = "RFC"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(296, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 15)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "RFC:"
        '
        'lbEmpresa
        '
        Me.lbEmpresa.AutoSize = True
        Me.lbEmpresa.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpresa.Location = New System.Drawing.Point(105, 154)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(50, 14)
        Me.lbEmpresa.TabIndex = 159
        Me.lbEmpresa.Text = "Empresa"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(20, 153)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 15)
        Me.Label20.TabIndex = 158
        Me.Label20.Text = "Empresa:"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorreo.Location = New System.Drawing.Point(105, 136)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(39, 14)
        Me.lbCorreo.TabIndex = 157
        Me.lbCorreo.Text = "Correo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(20, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 156
        Me.Label17.Text = "Correo:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.btGuardarInf)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.TextFolio)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 66)
        Me.Panel2.TabIndex = 151
        '
        'btGuardarInf
        '
        Me.btGuardarInf.BackColor = System.Drawing.Color.SteelBlue
        Me.btGuardarInf.FlatAppearance.BorderSize = 0
        Me.btGuardarInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardarInf.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardarInf.ForeColor = System.Drawing.Color.White
        Me.btGuardarInf.Location = New System.Drawing.Point(1065, 15)
        Me.btGuardarInf.Name = "btGuardarInf"
        Me.btGuardarInf.Size = New System.Drawing.Size(151, 33)
        Me.btGuardarInf.TabIndex = 166
        Me.btGuardarInf.Text = "Guardar Cotización"
        Me.btGuardarInf.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Cotización"
        '
        'TextFolio
        '
        Me.TextFolio.Location = New System.Drawing.Point(221, 32)
        Me.TextFolio.Name = "TextFolio"
        Me.TextFolio.Size = New System.Drawing.Size(100, 23)
        Me.TextFolio.TabIndex = 176
        Me.TextFolio.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(178, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Folio:"
        Me.Label1.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label27.Location = New System.Drawing.Point(55, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Folios"
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
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Cursor = System.Windows.Forms.Cursors.No
        Me.Label49.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1131, 10)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 14)
        Me.Label49.TabIndex = 162
        Me.Label49.Text = "Cerrar formulario"
        '
        'btCerrar
        '
        Me.btCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCerrar.Image = CType(resources.GetObject("btCerrar.Image"), System.Drawing.Image)
        Me.btCerrar.Location = New System.Drawing.Point(1228, 0)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btCerrar.TabIndex = 161
        Me.btCerrar.TabStop = False
        '
        'lbContacto
        '
        Me.lbContacto.AutoSize = True
        Me.lbContacto.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContacto.Location = New System.Drawing.Point(105, 249)
        Me.lbContacto.Name = "lbContacto"
        Me.lbContacto.Size = New System.Drawing.Size(50, 14)
        Me.lbContacto.TabIndex = 183
        Me.lbContacto.Text = "Contacto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(20, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Contacto:"
        '
        'lbClaveContacto
        '
        Me.lbClaveContacto.AutoSize = True
        Me.lbClaveContacto.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClaveContacto.Location = New System.Drawing.Point(112, 267)
        Me.lbClaveContacto.Name = "lbClaveContacto"
        Me.lbClaveContacto.Size = New System.Drawing.Size(37, 14)
        Me.lbClaveContacto.TabIndex = 185
        Me.lbClaveContacto.Text = "clacec"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label52.Location = New System.Drawing.Point(20, 266)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(92, 15)
        Me.Label52.TabIndex = 184
        Me.Label52.Text = "Clave Contacto:"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.Location = New System.Drawing.Point(112, 291)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(20, 14)
        Me.lbTelefono.TabIndex = 187
        Me.lbTelefono.Text = "tel"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label53.Location = New System.Drawing.Point(20, 290)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(79, 15)
        Me.Label53.TabIndex = 186
        Me.Label53.Text = "Telefono EXT:"
        '
        'lbExt
        '
        Me.lbExt.AutoSize = True
        Me.lbExt.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbExt.Location = New System.Drawing.Point(199, 291)
        Me.lbExt.Name = "lbExt"
        Me.lbExt.Size = New System.Drawing.Size(54, 14)
        Me.lbExt.TabIndex = 188
        Me.lbExt.Text = "Extencion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1001, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 14)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Cotizó:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1001, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "Contabilizar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1000, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 14)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "Tipo de Cliente:"
        '
        'txtCotizo2019
        '
        Me.txtCotizo2019.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCotizo2019.Location = New System.Drawing.Point(1089, 223)
        Me.txtCotizo2019.Name = "txtCotizo2019"
        Me.txtCotizo2019.Size = New System.Drawing.Size(102, 21)
        Me.txtCotizo2019.TabIndex = 199
        '
        'txtConta
        '
        Me.txtConta.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConta.Location = New System.Drawing.Point(1089, 193)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(102, 21)
        Me.txtConta.TabIndex = 200
        '
        'txtTipoCliente
        '
        Me.txtTipoCliente.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCliente.Location = New System.Drawing.Point(1089, 163)
        Me.txtTipoCliente.Name = "txtTipoCliente"
        Me.txtTipoCliente.Size = New System.Drawing.Size(102, 21)
        Me.txtTipoCliente.TabIndex = 201
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(747, 246)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(200, 63)
        Me.txtObservaciones.TabIndex = 198
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(663, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 14)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Observaciones:"
        '
        'cboServicio
        '
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Items.AddRange(New Object() {"MetAs", "MetAs Campo", "MetAs Óptica"})
        Me.cboServicio.Location = New System.Drawing.Point(747, 191)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(121, 23)
        Me.cboServicio.TabIndex = 196
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(663, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 14)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Servicio en:"
        '
        'DTPDesde
        '
        Me.DTPDesde.Enabled = False
        Me.DTPDesde.Location = New System.Drawing.Point(747, 133)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(200, 23)
        Me.DTPDesde.TabIndex = 194
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(663, 220)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(67, 14)
        Me.Label78.TabIndex = 193
        Me.Label78.Text = "Cotizo 2018:"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(663, 165)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(62, 14)
        Me.Label79.TabIndex = 192
        Me.Label79.Text = "Referencia:"
        '
        'txtCotizo
        '
        Me.txtCotizo.Enabled = False
        Me.txtCotizo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCotizo.Location = New System.Drawing.Point(747, 218)
        Me.txtCotizo.Name = "txtCotizo"
        Me.txtCotizo.Size = New System.Drawing.Size(200, 21)
        Me.txtCotizo.TabIndex = 191
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(747, 163)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(200, 21)
        Me.txtReferencia.TabIndex = 190
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(663, 133)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(80, 14)
        Me.Label80.TabIndex = 189
        Me.Label80.Text = "Vigente desde:"
        '
        'DGCotizaciones
        '
        Me.DGCotizaciones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCotizaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCotizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ckSeleccionar, Me.partida, Me.codigoServicio, Me.cantidad, Me.equipoDescripcion, Me.marca, Me.modelo, Me.id, Me.intervalo, Me.precioUnitario, Me.precioTotal})
        Me.DGCotizaciones.Location = New System.Drawing.Point(14, 361)
        Me.DGCotizaciones.Name = "DGCotizaciones"
        Me.DGCotizaciones.Size = New System.Drawing.Size(1202, 266)
        Me.DGCotizaciones.TabIndex = 205
        '
        'ckSeleccionar
        '
        Me.ckSeleccionar.HeaderText = "Seleccionar"
        Me.ckSeleccionar.Name = "ckSeleccionar"
        '
        'partida
        '
        Me.partida.HeaderText = "Partida"
        Me.partida.Name = "partida"
        Me.partida.Width = 50
        '
        'codigoServicio
        '
        Me.codigoServicio.HeaderText = "Código Servicio"
        Me.codigoServicio.Name = "codigoServicio"
        Me.codigoServicio.Width = 80
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 55
        '
        'equipoDescripcion
        '
        Me.equipoDescripcion.HeaderText = "Equipo/Descripción"
        Me.equipoDescripcion.Name = "equipoDescripcion"
        Me.equipoDescripcion.Width = 270
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 80
        '
        'intervalo
        '
        Me.intervalo.HeaderText = "Intervalo"
        Me.intervalo.Name = "intervalo"
        Me.intervalo.Width = 270
        '
        'precioUnitario
        '
        Me.precioUnitario.HeaderText = "Precio 2018"
        Me.precioUnitario.Name = "precioUnitario"
        Me.precioUnitario.Width = 70
        '
        'precioTotal
        '
        Me.precioTotal.HeaderText = "Precio 2019"
        Me.precioTotal.Name = "precioTotal"
        Me.precioTotal.Width = 70
        '
        'btEliminar
        '
        Me.btEliminar.BackColor = System.Drawing.Color.Honeydew
        Me.btEliminar.FlatAppearance.BorderSize = 0
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEliminar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.ForeColor = System.Drawing.Color.Black
        Me.btEliminar.Location = New System.Drawing.Point(1106, 318)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(110, 34)
        Me.btEliminar.TabIndex = 206
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = False
        '
        'FrmCotPorFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1255, 703)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCotPorFolio"
        Me.Text = "FrmCotPorFolio"
        Me.TabConsulta.ResumeLayout(False)
        Me.TabFolios.ResumeLayout(False)
        Me.TabFolios.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents TabFolios As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lbServicios As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents lbPais As Label
    Friend WithEvents lbDomicilio As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents lbCiudad As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents lbEstado As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lbCP As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lbClave As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lbRFC As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbEmpresa As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btGuardarInf As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents TextFolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents btCerrar As PictureBox
    Friend WithEvents lbContacto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbClaveContacto As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents lbExt As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCotizo2019 As TextBox
    Friend WithEvents txtConta As TextBox
    Friend WithEvents txtTipoCliente As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents txtCotizo As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents DGCotizaciones As DataGridView
    Friend WithEvents ckSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents partida As DataGridViewTextBoxColumn
    Friend WithEvents codigoServicio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents equipoDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents intervalo As DataGridViewTextBoxColumn
    Friend WithEvents precioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents precioTotal As DataGridViewTextBoxColumn
    Friend WithEvents btEliminar As Button
End Class
