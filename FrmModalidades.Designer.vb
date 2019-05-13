<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModalidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModalidades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.TabProspectos = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidProspeccion = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidProspecto = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.txtEdo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEdicion = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefoo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompania = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCreacion = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cboStatusFiltrado = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.txtCorreoP = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.TabActividad = New System.Windows.Forms.TabPage()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControlTareas = New System.Windows.Forms.TabControl()
        Me.TabLlamada = New System.Windows.Forms.TabPage()
        Me.DTPFechaEstimadaDeLlamada = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btAgregarLlamada = New System.Windows.Forms.Button()
        Me.EtiquetaNombreDeProspecto = New System.Windows.Forms.Label()
        Me.cboRelacionadoConLlamada = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtComentariosLlamada = New System.Windows.Forms.TextBox()
        Me.txtAsuntoLlamada = New System.Windows.Forms.TextBox()
        Me.TabTarea = New System.Windows.Forms.TabPage()
        Me.DTPFechaDeVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.btAgregarTarea = New System.Windows.Forms.Button()
        Me.EtiquetaNombreDeProspecto2 = New System.Windows.Forms.Label()
        Me.cboRelacionadoConTareas = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtAsignadoTarea = New System.Windows.Forms.TextBox()
        Me.txtAsuntoTarea = New System.Windows.Forms.TextBox()
        Me.IndicadorNuevo2 = New System.Windows.Forms.PictureBox()
        Me.IndicadorContactado2 = New System.Windows.Forms.PictureBox()
        Me.IndicadorWorking2 = New System.Windows.Forms.PictureBox()
        Me.IndicadorNo2 = New System.Windows.Forms.PictureBox()
        Me.IndicadorConvertido2 = New System.Windows.Forms.PictureBox()
        Me.TabConsulta.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabActividad.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlTareas.SuspendLayout()
        Me.TabLlamada.SuspendLayout()
        Me.TabTarea.SuspendLayout()
        CType(Me.IndicadorNuevo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicadorContactado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicadorWorking2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicadorNo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicadorConvertido2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Controls.Add(Me.TabProspectos)
        Me.TabConsulta.Controls.Add(Me.TabActividad)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(1, 3)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(884, 726)
        Me.TabConsulta.TabIndex = 43
        '
        'TabProspectos
        '
        Me.TabProspectos.BackColor = System.Drawing.Color.Gainsboro
        Me.TabProspectos.Controls.Add(Me.Panel1)
        Me.TabProspectos.Controls.Add(Me.Panel5)
        Me.TabProspectos.Controls.Add(Me.Label21)
        Me.TabProspectos.Controls.Add(Me.Label2)
        Me.TabProspectos.Controls.Add(Me.txtMonto)
        Me.TabProspectos.Controls.Add(Me.txtOrigen)
        Me.TabProspectos.Controls.Add(Me.txtDescripcion)
        Me.TabProspectos.Controls.Add(Me.Label18)
        Me.TabProspectos.Controls.Add(Me.Label15)
        Me.TabProspectos.Controls.Add(Me.Label3)
        Me.TabProspectos.Controls.Add(Me.txtDireccion)
        Me.TabProspectos.Controls.Add(Me.Label14)
        Me.TabProspectos.Controls.Add(Me.txtNombre)
        Me.TabProspectos.Controls.Add(Me.txtEdo)
        Me.TabProspectos.Controls.Add(Me.Label20)
        Me.TabProspectos.Controls.Add(Me.txtEdicion)
        Me.TabProspectos.Controls.Add(Me.txtCiudad)
        Me.TabProspectos.Controls.Add(Me.Label10)
        Me.TabProspectos.Controls.Add(Me.Label4)
        Me.TabProspectos.Controls.Add(Me.Label1)
        Me.TabProspectos.Controls.Add(Me.Label8)
        Me.TabProspectos.Controls.Add(Me.txtTelefoo)
        Me.TabProspectos.Controls.Add(Me.Label7)
        Me.TabProspectos.Controls.Add(Me.txtCompania)
        Me.TabProspectos.Controls.Add(Me.Label12)
        Me.TabProspectos.Controls.Add(Me.txtCreacion)
        Me.TabProspectos.Controls.Add(Me.Label33)
        Me.TabProspectos.Controls.Add(Me.Panel7)
        Me.TabProspectos.Controls.Add(Me.Panel2)
        Me.TabProspectos.Controls.Add(Me.DGConsulta)
        Me.TabProspectos.Location = New System.Drawing.Point(4, 24)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProspectos.Size = New System.Drawing.Size(876, 698)
        Me.TabProspectos.TabIndex = 5
        Me.TabProspectos.Text = "Prospecciones"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtidProspeccion)
        Me.Panel1.Location = New System.Drawing.Point(419, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 27)
        Me.Panel1.TabIndex = 171
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(8, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Prospección"
        '
        'txtidProspeccion
        '
        Me.txtidProspeccion.AutoSize = True
        Me.txtidProspeccion.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidProspeccion.Location = New System.Drawing.Point(220, 7)
        Me.txtidProspeccion.Name = "txtidProspeccion"
        Me.txtidProspeccion.Size = New System.Drawing.Size(74, 14)
        Me.txtidProspeccion.TabIndex = 160
        Me.txtidProspeccion.Text = "idProspeccion"
        Me.txtidProspeccion.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txtidProspecto)
        Me.Panel5.Location = New System.Drawing.Point(10, 492)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(388, 27)
        Me.Panel5.TabIndex = 170
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(8, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 15)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Información relacionada al prospecto"
        '
        'txtidProspecto
        '
        Me.txtidProspecto.AutoSize = True
        Me.txtidProspecto.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidProspecto.Location = New System.Drawing.Point(267, 7)
        Me.txtidProspecto.Name = "txtidProspecto"
        Me.txtidProspecto.Size = New System.Drawing.Size(64, 14)
        Me.txtidProspecto.TabIndex = 160
        Me.txtidProspecto.Text = "idProspecto"
        Me.txtidProspecto.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(804, 672)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 14)
        Me.Label21.TabIndex = 164
        Me.Label21.Text = "click aquí"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(504, 628)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 26)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "$"
        '
        'txtMonto
        '
        Me.txtMonto.AutoSize = True
        Me.txtMonto.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.OliveDrab
        Me.txtMonto.Location = New System.Drawing.Point(523, 630)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(71, 26)
        Me.txtMonto.TabIndex = 164
        Me.txtMonto.Text = "Puesto"
        '
        'txtOrigen
        '
        Me.txtOrigen.AutoSize = True
        Me.txtOrigen.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.Location = New System.Drawing.Point(506, 555)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(40, 14)
        Me.txtOrigen.TabIndex = 164
        Me.txtOrigen.Text = "Puesto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = True
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(506, 530)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(40, 14)
        Me.txtDescripcion.TabIndex = 164
        Me.txtDescripcion.Text = "Puesto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(427, 638)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 15)
        Me.Label18.TabIndex = 165
        Me.Label18.Text = "Monto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(427, 555)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 15)
        Me.Label15.TabIndex = 165
        Me.Label15.Text = "Origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(427, 529)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Descripción:"
        '
        'txtDireccion
        '
        Me.txtDireccion.AutoSize = True
        Me.txtDireccion.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(93, 580)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(98, 14)
        Me.txtDireccion.TabIndex = 168
        Me.txtDireccion.Text = "Numero de celular"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 579)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(93, 530)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(112, 14)
        Me.txtNombre.TabIndex = 160
        Me.txtNombre.Text = "Numero de extencion"
        '
        'txtEdo
        '
        Me.txtEdo.AutoSize = True
        Me.txtEdo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdo.Location = New System.Drawing.Point(93, 653)
        Me.txtEdo.Name = "txtEdo"
        Me.txtEdo.Size = New System.Drawing.Size(112, 14)
        Me.txtEdo.TabIndex = 160
        Me.txtEdo.Text = "Numero de extencion"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(555, 672)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(252, 14)
        Me.Label20.TabIndex = 160
        Me.Label20.Text = "Para realizar una cotización a esta oportunidad da"
        '
        'txtEdicion
        '
        Me.txtEdicion.AutoSize = True
        Me.txtEdicion.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdicion.Location = New System.Drawing.Point(506, 606)
        Me.txtEdicion.Name = "txtEdicion"
        Me.txtEdicion.Size = New System.Drawing.Size(112, 14)
        Me.txtEdicion.TabIndex = 160
        Me.txtEdicion.Text = "Numero de extencion"
        '
        'txtCiudad
        '
        Me.txtCiudad.AutoSize = True
        Me.txtCiudad.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(93, 628)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(112, 14)
        Me.txtCiudad.TabIndex = 160
        Me.txtCiudad.Text = "Numero de extencion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 652)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 604)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Edición:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 627)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Ciudad:"
        '
        'txtTelefoo
        '
        Me.txtTelefoo.AutoSize = True
        Me.txtTelefoo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefoo.Location = New System.Drawing.Point(93, 604)
        Me.txtTelefoo.Name = "txtTelefoo"
        Me.txtTelefoo.Size = New System.Drawing.Size(106, 14)
        Me.txtTelefoo.TabIndex = 158
        Me.txtTelefoo.Text = "Numero de telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 603)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "Teléfono:"
        '
        'txtCompania
        '
        Me.txtCompania.AutoSize = True
        Me.txtCompania.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompania.Location = New System.Drawing.Point(93, 555)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.Size = New System.Drawing.Size(125, 14)
        Me.txtCompania.TabIndex = 156
        Me.txtCompania.Text = "Nombre de la compañia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 554)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 15)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Compañia:"
        '
        'txtCreacion
        '
        Me.txtCreacion.AutoSize = True
        Me.txtCreacion.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreacion.ForeColor = System.Drawing.Color.Black
        Me.txtCreacion.Location = New System.Drawing.Point(506, 581)
        Me.txtCreacion.Name = "txtCreacion"
        Me.txtCreacion.Size = New System.Drawing.Size(109, 14)
        Me.txtCreacion.TabIndex = 166
        Me.txtCreacion.Text = "Estado del prospecto"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(427, 580)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 15)
        Me.Label33.TabIndex = 167
        Me.Label33.Text = "Creación:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.cboStatusFiltrado)
        Me.Panel7.Controls.Add(Me.Label64)
        Me.Panel7.Controls.Add(Me.LabelNombre)
        Me.Panel7.Controls.Add(Me.txtNombreP)
        Me.Panel7.Controls.Add(Me.txtCorreoP)
        Me.Panel7.Controls.Add(Me.LabelCorreo)
        Me.Panel7.Location = New System.Drawing.Point(-1, 65)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(878, 45)
        Me.Panel7.TabIndex = 154
        '
        'cboStatusFiltrado
        '
        Me.cboStatusFiltrado.BackColor = System.Drawing.SystemColors.Menu
        Me.cboStatusFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFiltrado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusFiltrado.FormattingEnabled = True
        Me.cboStatusFiltrado.Location = New System.Drawing.Point(550, 9)
        Me.cboStatusFiltrado.Name = "cboStatusFiltrado"
        Me.cboStatusFiltrado.Size = New System.Drawing.Size(158, 22)
        Me.cboStatusFiltrado.TabIndex = 157
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(497, 12)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(47, 14)
        Me.Label64.TabIndex = 155
        Me.Label64.Text = "Status:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(8, 13)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(57, 14)
        Me.LabelNombre.TabIndex = 125
        Me.LabelNombre.Text = "Nombre:"
        '
        'txtNombreP
        '
        Me.txtNombreP.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreP.Location = New System.Drawing.Point(71, 10)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(158, 21)
        Me.txtNombreP.TabIndex = 126
        '
        'txtCorreoP
        '
        Me.txtCorreoP.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoP.Location = New System.Drawing.Point(308, 10)
        Me.txtCorreoP.Name = "txtCorreoP"
        Me.txtCorreoP.Size = New System.Drawing.Size(158, 21)
        Me.txtCorreoP.TabIndex = 129
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.Location = New System.Drawing.Point(253, 13)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(49, 14)
        Me.LabelCorreo.TabIndex = 132
        Me.LabelCorreo.Text = "Correo:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 66)
        Me.Panel2.TabIndex = 151
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.IndianRed
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(738, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 33)
        Me.Button6.TabIndex = 167
        Me.Button6.Text = "Eliminar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(198, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Seguimiento de prospecciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(577, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 33)
        Me.Button1.TabIndex = 164
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Label27.Location = New System.Drawing.Point(55, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Prospeciones"
        '
        'DGConsulta
        '
        Me.DGConsulta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Location = New System.Drawing.Point(6, 116)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.ReadOnly = True
        Me.DGConsulta.Size = New System.Drawing.Size(864, 355)
        Me.DGConsulta.TabIndex = 124
        '
        'TabActividad
        '
        Me.TabActividad.BackColor = System.Drawing.Color.Gainsboro
        Me.TabActividad.Controls.Add(Me.Label48)
        Me.TabActividad.Controls.Add(Me.Label50)
        Me.TabActividad.Controls.Add(Me.Label51)
        Me.TabActividad.Controls.Add(Me.Label52)
        Me.TabActividad.Controls.Add(Me.Label53)
        Me.TabActividad.Controls.Add(Me.Label54)
        Me.TabActividad.Controls.Add(Me.Label55)
        Me.TabActividad.Controls.Add(Me.Label56)
        Me.TabActividad.Controls.Add(Me.Label57)
        Me.TabActividad.Controls.Add(Me.Panel6)
        Me.TabActividad.Controls.Add(Me.TabControlTareas)
        Me.TabActividad.Controls.Add(Me.IndicadorNuevo2)
        Me.TabActividad.Controls.Add(Me.IndicadorContactado2)
        Me.TabActividad.Controls.Add(Me.IndicadorWorking2)
        Me.TabActividad.Controls.Add(Me.IndicadorNo2)
        Me.TabActividad.Controls.Add(Me.IndicadorConvertido2)
        Me.TabActividad.Location = New System.Drawing.Point(4, 24)
        Me.TabActividad.Name = "TabActividad"
        Me.TabActividad.Size = New System.Drawing.Size(876, 698)
        Me.TabActividad.TabIndex = 7
        Me.TabActividad.Text = "Actividades | Tareas"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(532, 114)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 15)
        Me.Label48.TabIndex = 169
        Me.Label48.Text = "Convertido"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(407, 114)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(81, 15)
        Me.Label50.TabIndex = 170
        Me.Label50.Text = "Promoviendo"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(295, 114)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(52, 15)
        Me.Label51.TabIndex = 171
        Me.Label51.Text = "Working"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(175, 114)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(43, 15)
        Me.Label52.TabIndex = 172
        Me.Label52.Text = "Nuevo"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(35, 114)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(75, 15)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "No calificado"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(458, 85)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(91, 15)
        Me.Label54.TabIndex = 166
        Me.Label54.Text = "______________"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(335, 85)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(91, 15)
        Me.Label55.TabIndex = 167
        Me.Label55.Text = "______________"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(212, 85)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(91, 15)
        Me.Label56.TabIndex = 168
        Me.Label56.Text = "______________"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(87, 85)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(91, 15)
        Me.Label57.TabIndex = 165
        Me.Label57.Text = "______________"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(880, 66)
        Me.Panel6.TabIndex = 151
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(55, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 18)
        Me.Label13.TabIndex = 135
        Me.Label13.Text = "Registrar Actividades"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label16.Location = New System.Drawing.Point(55, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 15)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "Actividades"
        '
        'TabControlTareas
        '
        Me.TabControlTareas.Controls.Add(Me.TabLlamada)
        Me.TabControlTareas.Controls.Add(Me.TabTarea)
        Me.TabControlTareas.Location = New System.Drawing.Point(48, 162)
        Me.TabControlTareas.Name = "TabControlTareas"
        Me.TabControlTareas.SelectedIndex = 0
        Me.TabControlTareas.Size = New System.Drawing.Size(692, 262)
        Me.TabControlTareas.TabIndex = 0
        '
        'TabLlamada
        '
        Me.TabLlamada.BackColor = System.Drawing.Color.Gainsboro
        Me.TabLlamada.Controls.Add(Me.DTPFechaEstimadaDeLlamada)
        Me.TabLlamada.Controls.Add(Me.Label46)
        Me.TabLlamada.Controls.Add(Me.btAgregarLlamada)
        Me.TabLlamada.Controls.Add(Me.EtiquetaNombreDeProspecto)
        Me.TabLlamada.Controls.Add(Me.cboRelacionadoConLlamada)
        Me.TabLlamada.Controls.Add(Me.Label45)
        Me.TabLlamada.Controls.Add(Me.Label44)
        Me.TabLlamada.Controls.Add(Me.Label32)
        Me.TabLlamada.Controls.Add(Me.Label43)
        Me.TabLlamada.Controls.Add(Me.txtComentariosLlamada)
        Me.TabLlamada.Controls.Add(Me.txtAsuntoLlamada)
        Me.TabLlamada.Location = New System.Drawing.Point(4, 24)
        Me.TabLlamada.Name = "TabLlamada"
        Me.TabLlamada.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLlamada.Size = New System.Drawing.Size(684, 234)
        Me.TabLlamada.TabIndex = 0
        Me.TabLlamada.Text = "Registrar una llamada"
        '
        'DTPFechaEstimadaDeLlamada
        '
        Me.DTPFechaEstimadaDeLlamada.Enabled = False
        Me.DTPFechaEstimadaDeLlamada.Location = New System.Drawing.Point(110, 145)
        Me.DTPFechaEstimadaDeLlamada.Name = "DTPFechaEstimadaDeLlamada"
        Me.DTPFechaEstimadaDeLlamada.Size = New System.Drawing.Size(258, 23)
        Me.DTPFechaEstimadaDeLlamada.TabIndex = 175
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label46.Location = New System.Drawing.Point(9, 149)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(95, 15)
        Me.Label46.TabIndex = 174
        Me.Label46.Text = "Fecha estimada:"
        '
        'btAgregarLlamada
        '
        Me.btAgregarLlamada.BackColor = System.Drawing.Color.SteelBlue
        Me.btAgregarLlamada.Enabled = False
        Me.btAgregarLlamada.FlatAppearance.BorderSize = 0
        Me.btAgregarLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregarLlamada.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregarLlamada.ForeColor = System.Drawing.Color.White
        Me.btAgregarLlamada.Location = New System.Drawing.Point(497, 178)
        Me.btAgregarLlamada.Name = "btAgregarLlamada"
        Me.btAgregarLlamada.Size = New System.Drawing.Size(167, 33)
        Me.btAgregarLlamada.TabIndex = 163
        Me.btAgregarLlamada.Text = "Agregar Llamada"
        Me.btAgregarLlamada.UseVisualStyleBackColor = False
        '
        'EtiquetaNombreDeProspecto
        '
        Me.EtiquetaNombreDeProspecto.AutoSize = True
        Me.EtiquetaNombreDeProspecto.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaNombreDeProspecto.Location = New System.Drawing.Point(128, 20)
        Me.EtiquetaNombreDeProspecto.Name = "EtiquetaNombreDeProspecto"
        Me.EtiquetaNombreDeProspecto.Size = New System.Drawing.Size(98, 14)
        Me.EtiquetaNombreDeProspecto.TabIndex = 130
        Me.EtiquetaNombreDeProspecto.Text = "Nombre prospecto"
        '
        'cboRelacionadoConLlamada
        '
        Me.cboRelacionadoConLlamada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRelacionadoConLlamada.Enabled = False
        Me.cboRelacionadoConLlamada.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboRelacionadoConLlamada.FormattingEnabled = True
        Me.cboRelacionadoConLlamada.Location = New System.Drawing.Point(110, 184)
        Me.cboRelacionadoConLlamada.Name = "cboRelacionadoConLlamada"
        Me.cboRelacionadoConLlamada.Size = New System.Drawing.Size(258, 23)
        Me.cboRelacionadoConLlamada.TabIndex = 129
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label45.Location = New System.Drawing.Point(6, 187)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(98, 15)
        Me.Label45.TabIndex = 127
        Me.Label45.Text = "Relacionado con:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label44.Location = New System.Drawing.Point(54, 19)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(66, 15)
        Me.Label44.TabIndex = 127
        Me.Label44.Text = "Prospecto:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label32.Location = New System.Drawing.Point(23, 86)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 15)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "Comentarios:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label43.Location = New System.Drawing.Point(54, 53)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(50, 15)
        Me.Label43.TabIndex = 127
        Me.Label43.Text = "Asunto:"
        '
        'txtComentariosLlamada
        '
        Me.txtComentariosLlamada.Enabled = False
        Me.txtComentariosLlamada.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentariosLlamada.Location = New System.Drawing.Point(110, 85)
        Me.txtComentariosLlamada.Multiline = True
        Me.txtComentariosLlamada.Name = "txtComentariosLlamada"
        Me.txtComentariosLlamada.Size = New System.Drawing.Size(554, 54)
        Me.txtComentariosLlamada.TabIndex = 128
        '
        'txtAsuntoLlamada
        '
        Me.txtAsuntoLlamada.Enabled = False
        Me.txtAsuntoLlamada.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsuntoLlamada.Location = New System.Drawing.Point(110, 52)
        Me.txtAsuntoLlamada.Name = "txtAsuntoLlamada"
        Me.txtAsuntoLlamada.Size = New System.Drawing.Size(554, 21)
        Me.txtAsuntoLlamada.TabIndex = 128
        '
        'TabTarea
        '
        Me.TabTarea.BackColor = System.Drawing.Color.Gainsboro
        Me.TabTarea.Controls.Add(Me.DTPFechaDeVencimiento)
        Me.TabTarea.Controls.Add(Me.btAgregarTarea)
        Me.TabTarea.Controls.Add(Me.EtiquetaNombreDeProspecto2)
        Me.TabTarea.Controls.Add(Me.cboRelacionadoConTareas)
        Me.TabTarea.Controls.Add(Me.Label59)
        Me.TabTarea.Controls.Add(Me.Label60)
        Me.TabTarea.Controls.Add(Me.Label63)
        Me.TabTarea.Controls.Add(Me.Label61)
        Me.TabTarea.Controls.Add(Me.Label62)
        Me.TabTarea.Controls.Add(Me.txtAsignadoTarea)
        Me.TabTarea.Controls.Add(Me.txtAsuntoTarea)
        Me.TabTarea.Location = New System.Drawing.Point(4, 24)
        Me.TabTarea.Name = "TabTarea"
        Me.TabTarea.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTarea.Size = New System.Drawing.Size(684, 234)
        Me.TabTarea.TabIndex = 1
        Me.TabTarea.Text = "Nueva Tarea"
        '
        'DTPFechaDeVencimiento
        '
        Me.DTPFechaDeVencimiento.Enabled = False
        Me.DTPFechaDeVencimiento.Location = New System.Drawing.Point(110, 128)
        Me.DTPFechaDeVencimiento.Name = "DTPFechaDeVencimiento"
        Me.DTPFechaDeVencimiento.Size = New System.Drawing.Size(234, 23)
        Me.DTPFechaDeVencimiento.TabIndex = 173
        '
        'btAgregarTarea
        '
        Me.btAgregarTarea.BackColor = System.Drawing.Color.SteelBlue
        Me.btAgregarTarea.Enabled = False
        Me.btAgregarTarea.FlatAppearance.BorderSize = 0
        Me.btAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregarTarea.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregarTarea.ForeColor = System.Drawing.Color.White
        Me.btAgregarTarea.Location = New System.Drawing.Point(497, 178)
        Me.btAgregarTarea.Name = "btAgregarTarea"
        Me.btAgregarTarea.Size = New System.Drawing.Size(167, 33)
        Me.btAgregarTarea.TabIndex = 172
        Me.btAgregarTarea.Text = "Agregar Tarea"
        Me.btAgregarTarea.UseVisualStyleBackColor = False
        '
        'EtiquetaNombreDeProspecto2
        '
        Me.EtiquetaNombreDeProspecto2.AutoSize = True
        Me.EtiquetaNombreDeProspecto2.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaNombreDeProspecto2.Location = New System.Drawing.Point(128, 20)
        Me.EtiquetaNombreDeProspecto2.Name = "EtiquetaNombreDeProspecto2"
        Me.EtiquetaNombreDeProspecto2.Size = New System.Drawing.Size(98, 14)
        Me.EtiquetaNombreDeProspecto2.TabIndex = 171
        Me.EtiquetaNombreDeProspecto2.Text = "Nombre prospecto"
        '
        'cboRelacionadoConTareas
        '
        Me.cboRelacionadoConTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRelacionadoConTareas.Enabled = False
        Me.cboRelacionadoConTareas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboRelacionadoConTareas.FormattingEnabled = True
        Me.cboRelacionadoConTareas.Location = New System.Drawing.Point(110, 184)
        Me.cboRelacionadoConTareas.Name = "cboRelacionadoConTareas"
        Me.cboRelacionadoConTareas.Size = New System.Drawing.Size(258, 23)
        Me.cboRelacionadoConTareas.TabIndex = 170
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label59.Location = New System.Drawing.Point(6, 187)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(98, 15)
        Me.Label59.TabIndex = 164
        Me.Label59.Text = "Relacionado con:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label60.Location = New System.Drawing.Point(54, 19)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(66, 15)
        Me.Label60.TabIndex = 165
        Me.Label60.Text = "Prospecto:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label63.Location = New System.Drawing.Point(35, 86)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(69, 15)
        Me.Label63.TabIndex = 166
        Me.Label63.Text = "Asignado a:"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label61.Location = New System.Drawing.Point(60, 131)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(44, 15)
        Me.Label61.TabIndex = 166
        Me.Label61.Text = "Vence:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label62.Location = New System.Drawing.Point(54, 53)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(50, 15)
        Me.Label62.TabIndex = 167
        Me.Label62.Text = "Asunto:"
        '
        'txtAsignadoTarea
        '
        Me.txtAsignadoTarea.Enabled = False
        Me.txtAsignadoTarea.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignadoTarea.Location = New System.Drawing.Point(110, 85)
        Me.txtAsignadoTarea.Name = "txtAsignadoTarea"
        Me.txtAsignadoTarea.Size = New System.Drawing.Size(554, 21)
        Me.txtAsignadoTarea.TabIndex = 169
        '
        'txtAsuntoTarea
        '
        Me.txtAsuntoTarea.Enabled = False
        Me.txtAsuntoTarea.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsuntoTarea.Location = New System.Drawing.Point(110, 52)
        Me.txtAsuntoTarea.Name = "txtAsuntoTarea"
        Me.txtAsuntoTarea.Size = New System.Drawing.Size(554, 21)
        Me.txtAsuntoTarea.TabIndex = 169
        '
        'IndicadorNuevo2
        '
        Me.IndicadorNuevo2.BackColor = System.Drawing.Color.Transparent
        Me.IndicadorNuevo2.Image = CType(resources.GetObject("IndicadorNuevo2.Image"), System.Drawing.Image)
        Me.IndicadorNuevo2.Location = New System.Drawing.Point(62, 85)
        Me.IndicadorNuevo2.Name = "IndicadorNuevo2"
        Me.IndicadorNuevo2.Size = New System.Drawing.Size(25, 25)
        Me.IndicadorNuevo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IndicadorNuevo2.TabIndex = 160
        Me.IndicadorNuevo2.TabStop = False
        '
        'IndicadorContactado2
        '
        Me.IndicadorContactado2.BackColor = System.Drawing.Color.Transparent
        Me.IndicadorContactado2.Image = CType(resources.GetObject("IndicadorContactado2.Image"), System.Drawing.Image)
        Me.IndicadorContactado2.Location = New System.Drawing.Point(183, 86)
        Me.IndicadorContactado2.Name = "IndicadorContactado2"
        Me.IndicadorContactado2.Size = New System.Drawing.Size(25, 25)
        Me.IndicadorContactado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IndicadorContactado2.TabIndex = 161
        Me.IndicadorContactado2.TabStop = False
        '
        'IndicadorWorking2
        '
        Me.IndicadorWorking2.BackColor = System.Drawing.Color.Transparent
        Me.IndicadorWorking2.Image = CType(resources.GetObject("IndicadorWorking2.Image"), System.Drawing.Image)
        Me.IndicadorWorking2.Location = New System.Drawing.Point(308, 86)
        Me.IndicadorWorking2.Name = "IndicadorWorking2"
        Me.IndicadorWorking2.Size = New System.Drawing.Size(25, 25)
        Me.IndicadorWorking2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IndicadorWorking2.TabIndex = 162
        Me.IndicadorWorking2.TabStop = False
        '
        'IndicadorNo2
        '
        Me.IndicadorNo2.BackColor = System.Drawing.Color.Transparent
        Me.IndicadorNo2.Image = CType(resources.GetObject("IndicadorNo2.Image"), System.Drawing.Image)
        Me.IndicadorNo2.Location = New System.Drawing.Point(431, 85)
        Me.IndicadorNo2.Name = "IndicadorNo2"
        Me.IndicadorNo2.Size = New System.Drawing.Size(25, 25)
        Me.IndicadorNo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IndicadorNo2.TabIndex = 163
        Me.IndicadorNo2.TabStop = False
        '
        'IndicadorConvertido2
        '
        Me.IndicadorConvertido2.BackColor = System.Drawing.Color.Transparent
        Me.IndicadorConvertido2.Image = CType(resources.GetObject("IndicadorConvertido2.Image"), System.Drawing.Image)
        Me.IndicadorConvertido2.Location = New System.Drawing.Point(550, 85)
        Me.IndicadorConvertido2.Name = "IndicadorConvertido2"
        Me.IndicadorConvertido2.Size = New System.Drawing.Size(25, 25)
        Me.IndicadorConvertido2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IndicadorConvertido2.TabIndex = 164
        Me.IndicadorConvertido2.TabStop = False
        '
        'FrmModalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 732)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmModalidades"
        Me.Text = "Modalidades"
        Me.TabConsulta.ResumeLayout(False)
        Me.TabProspectos.ResumeLayout(False)
        Me.TabProspectos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabActividad.ResumeLayout(False)
        Me.TabActividad.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlTareas.ResumeLayout(False)
        Me.TabLlamada.ResumeLayout(False)
        Me.TabLlamada.PerformLayout()
        Me.TabTarea.ResumeLayout(False)
        Me.TabTarea.PerformLayout()
        CType(Me.IndicadorNuevo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicadorContactado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicadorWorking2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicadorNo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicadorConvertido2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents TabProspectos As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cboStatusFiltrado As ComboBox
    Friend WithEvents Label64 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents txtCorreoP As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents TabActividad As TabPage
    Friend WithEvents Label48 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TabControlTareas As TabControl
    Friend WithEvents TabLlamada As TabPage
    Friend WithEvents DTPFechaEstimadaDeLlamada As DateTimePicker
    Friend WithEvents Label46 As Label
    Friend WithEvents btAgregarLlamada As Button
    Friend WithEvents EtiquetaNombreDeProspecto As Label
    Friend WithEvents cboRelacionadoConLlamada As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents txtComentariosLlamada As TextBox
    Friend WithEvents txtAsuntoLlamada As TextBox
    Friend WithEvents TabTarea As TabPage
    Friend WithEvents DTPFechaDeVencimiento As DateTimePicker
    Friend WithEvents btAgregarTarea As Button
    Friend WithEvents EtiquetaNombreDeProspecto2 As Label
    Friend WithEvents cboRelacionadoConTareas As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents txtAsignadoTarea As TextBox
    Friend WithEvents txtAsuntoTarea As TextBox
    Friend WithEvents IndicadorNuevo2 As PictureBox
    Friend WithEvents IndicadorContactado2 As PictureBox
    Friend WithEvents IndicadorWorking2 As PictureBox
    Friend WithEvents IndicadorNo2 As PictureBox
    Friend WithEvents IndicadorConvertido2 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNombre As Label
    Friend WithEvents txtEdo As Label
    Friend WithEvents txtEdicion As Label
    Friend WithEvents txtCiudad As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefoo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCompania As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCreacion As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMonto As Label
    Friend WithEvents txtOrigen As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtidProspeccion As Label
    Friend WithEvents txtidProspecto As Label
    Friend WithEvents Label2 As Label
End Class
