<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFoliosDelAnioAnterior
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFoliosDelAnioAnterior))
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.TabFolios = New System.Windows.Forms.TabPage()
        Me.btAgregarFila = New System.Windows.Forms.Button()
        Me.lbServicios = New System.Windows.Forms.Label()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
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
        Me.lbRazonSocial = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btGuardarInf = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Magnitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Informe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Facturadp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveContactoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClavecontactoUsuarioa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCalib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServCatalogo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServCatalogo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosAdicionales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUCalib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PULab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUFacturado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alcance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accesorios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puntos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patron1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patron2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patron3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Funciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etiquetas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HacerEtiquetas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatosInforme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calibro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumEmisiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RealizoMedicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirEdo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiEdoEm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirPais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirCp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv8Idioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sv10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextFolio = New System.Windows.Forms.TextBox()
        Me.TabConsulta.SuspendLayout()
        Me.TabFolios.SuspendLayout()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Controls.Add(Me.TabFolios)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(5, 29)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 639)
        Me.TabConsulta.TabIndex = 43
        '
        'TabFolios
        '
        Me.TabFolios.BackColor = System.Drawing.Color.Gainsboro
        Me.TabFolios.Controls.Add(Me.TextFolio)
        Me.TabFolios.Controls.Add(Me.Label1)
        Me.TabFolios.Controls.Add(Me.btEliminar)
        Me.TabFolios.Controls.Add(Me.btAgregarFila)
        Me.TabFolios.Controls.Add(Me.lbServicios)
        Me.TabFolios.Controls.Add(Me.DGConsulta)
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
        Me.TabFolios.Controls.Add(Me.lbRazonSocial)
        Me.TabFolios.Controls.Add(Me.Label17)
        Me.TabFolios.Controls.Add(Me.Panel2)
        Me.TabFolios.Location = New System.Drawing.Point(4, 24)
        Me.TabFolios.Name = "TabFolios"
        Me.TabFolios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFolios.Size = New System.Drawing.Size(1140, 611)
        Me.TabFolios.TabIndex = 5
        Me.TabFolios.Text = "Folios del año anterior"
        '
        'btAgregarFila
        '
        Me.btAgregarFila.BackColor = System.Drawing.Color.SteelBlue
        Me.btAgregarFila.FlatAppearance.BorderSize = 0
        Me.btAgregarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregarFila.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregarFila.ForeColor = System.Drawing.Color.White
        Me.btAgregarFila.Location = New System.Drawing.Point(979, 280)
        Me.btAgregarFila.Name = "btAgregarFila"
        Me.btAgregarFila.Size = New System.Drawing.Size(151, 33)
        Me.btAgregarFila.TabIndex = 173
        Me.btAgregarFila.Text = "Agregar Fila"
        Me.btAgregarFila.UseVisualStyleBackColor = False
        '
        'lbServicios
        '
        Me.lbServicios.AutoSize = True
        Me.lbServicios.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbServicios.Location = New System.Drawing.Point(26, 321)
        Me.lbServicios.Name = "lbServicios"
        Me.lbServicios.Size = New System.Drawing.Size(58, 15)
        Me.lbServicios.TabIndex = 172
        Me.lbServicios.Text = "Servicios:"
        '
        'DGConsulta
        '
        Me.DGConsulta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Folio, Me.Magnitud, Me.Informe, Me.Facturadp, Me.ClaveContacto, Me.Empresa, Me.ClaveContactoUsuario, Me.Usuario, Me.ClavecontactoUsuarioa, Me.FechaRecepcion, Me.FechaCalib, Me.FechaEmision, Me.ServCatalogo1, Me.ServCatalogo2, Me.ServiciosAdicionales, Me.PUCalib, Me.PULab, Me.PUFacturado, Me.Tipo, Me.Alcance, Me.Marca, Me.Modelo, Me.Serie, Me.ID, Me.Accesorios, Me.Puntos, Me.Patron1, Me.Patron2, Me.Patron3, Me.Funciones, Me.Etiquetas, Me.HacerEtiquetas, Me.DatosInforme, Me.Observaciones, Me.Calibro, Me.NumEmisiones, Me.NumCot, Me.Status, Me.CveOperador, Me.RealizoMedicion, Me.EmpresaEmision, Me.DirCalle, Me.DirCol, Me.DirEdo, Me.DiEdoEm, Me.DirPais, Me.DirCp, Me.Sv1, Me.Sv3, Me.Sv5, Me.Sv6, Me.Sv7, Me.Sv8Idioma, Me.Sv9, Me.Sv10, Me.FechaRegistro})
        Me.DGConsulta.Location = New System.Drawing.Point(23, 365)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.Size = New System.Drawing.Size(1098, 226)
        Me.DGConsulta.TabIndex = 171
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Location = New System.Drawing.Point(23, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 27)
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
        Me.lbPais.Location = New System.Drawing.Point(332, 261)
        Me.lbPais.Name = "lbPais"
        Me.lbPais.Size = New System.Drawing.Size(27, 14)
        Me.lbPais.TabIndex = 169
        Me.lbPais.Text = "Pais"
        '
        'lbDomicilio
        '
        Me.lbDomicilio.AutoSize = True
        Me.lbDomicilio.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDomicilio.Location = New System.Drawing.Point(98, 208)
        Me.lbDomicilio.Name = "lbDomicilio"
        Me.lbDomicilio.Size = New System.Drawing.Size(27, 14)
        Me.lbDomicilio.TabIndex = 169
        Me.lbDomicilio.Text = "Pais"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label50.Location = New System.Drawing.Point(253, 259)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(32, 15)
        Me.Label50.TabIndex = 168
        Me.Label50.Text = "Pais:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label48.Location = New System.Drawing.Point(26, 206)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(61, 15)
        Me.Label48.TabIndex = 168
        Me.Label48.Text = "Domicilio:"
        '
        'lbCiudad
        '
        Me.lbCiudad.AutoSize = True
        Me.lbCiudad.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCiudad.Location = New System.Drawing.Point(98, 234)
        Me.lbCiudad.Name = "lbCiudad"
        Me.lbCiudad.Size = New System.Drawing.Size(40, 14)
        Me.lbCiudad.TabIndex = 167
        Me.lbCiudad.Text = "Estado"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label44.Location = New System.Drawing.Point(26, 232)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 15)
        Me.Label44.TabIndex = 166
        Me.Label44.Text = "Ciudad:"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.Location = New System.Drawing.Point(98, 261)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 14)
        Me.lbEstado.TabIndex = 165
        Me.lbEstado.Text = "Ciudad"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(26, 259)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(47, 15)
        Me.Label39.TabIndex = 164
        Me.Label39.Text = "Estado:"
        '
        'lbCP
        '
        Me.lbCP.AutoSize = True
        Me.lbCP.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCP.Location = New System.Drawing.Point(98, 286)
        Me.lbCP.Name = "lbCP"
        Me.lbCP.Size = New System.Drawing.Size(73, 14)
        Me.lbCP.TabIndex = 163
        Me.lbCP.Text = "Código postal"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label35.Location = New System.Drawing.Point(26, 285)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(25, 15)
        Me.Label35.TabIndex = 162
        Me.Label35.Text = "CP:"
        '
        'lbClave
        '
        Me.lbClave.AutoSize = True
        Me.lbClave.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClave.Location = New System.Drawing.Point(98, 160)
        Me.lbClave.Name = "lbClave"
        Me.lbClave.Size = New System.Drawing.Size(121, 14)
        Me.lbClave.TabIndex = 155
        Me.lbClave.Text = "Dirección del prospecto"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label29.Location = New System.Drawing.Point(26, 158)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 15)
        Me.Label29.TabIndex = 154
        Me.Label29.Text = "Clave:"
        '
        'lbRFC
        '
        Me.lbRFC.AutoSize = True
        Me.lbRFC.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRFC.Location = New System.Drawing.Point(332, 236)
        Me.lbRFC.Name = "lbRFC"
        Me.lbRFC.Size = New System.Drawing.Size(43, 14)
        Me.lbRFC.TabIndex = 159
        Me.lbRFC.Text = "Colonia"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(253, 234)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 15)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "RFC:"
        '
        'lbEmpresa
        '
        Me.lbEmpresa.AutoSize = True
        Me.lbEmpresa.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpresa.Location = New System.Drawing.Point(98, 183)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(43, 14)
        Me.lbEmpresa.TabIndex = 159
        Me.lbEmpresa.Text = "Colonia"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(26, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 15)
        Me.Label20.TabIndex = 158
        Me.Label20.Text = "Empresa:"
        '
        'lbRazonSocial
        '
        Me.lbRazonSocial.AutoSize = True
        Me.lbRazonSocial.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRazonSocial.Location = New System.Drawing.Point(332, 161)
        Me.lbRazonSocial.Name = "lbRazonSocial"
        Me.lbRazonSocial.Size = New System.Drawing.Size(88, 14)
        Me.lbRazonSocial.TabIndex = 157
        Me.lbRazonSocial.Text = "Numero exterior"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(253, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 15)
        Me.Label17.TabIndex = 156
        Me.Label17.Text = "Razón Social:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.btGuardarInf)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.btBuscar)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 66)
        Me.Panel2.TabIndex = 151
        '
        'btGuardarInf
        '
        Me.btGuardarInf.BackColor = System.Drawing.Color.SteelBlue
        Me.btGuardarInf.FlatAppearance.BorderSize = 0
        Me.btGuardarInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardarInf.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardarInf.ForeColor = System.Drawing.Color.White
        Me.btGuardarInf.Location = New System.Drawing.Point(979, 15)
        Me.btGuardarInf.Name = "btGuardarInf"
        Me.btGuardarInf.Size = New System.Drawing.Size(151, 33)
        Me.btGuardarInf.TabIndex = 166
        Me.btGuardarInf.Text = "Guardar Informes"
        Me.btGuardarInf.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(147, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Folios del año anterior"
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.White
        Me.btBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.ForeColor = System.Drawing.Color.Black
        Me.btBuscar.Location = New System.Drawing.Point(860, 15)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(119, 33)
        Me.btBuscar.TabIndex = 164
        Me.btBuscar.Text = "Buscar Folio"
        Me.btBuscar.UseVisualStyleBackColor = False
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
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Cursor = System.Windows.Forms.Cursors.No
        Me.Label49.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1020, 12)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 14)
        Me.Label49.TabIndex = 142
        Me.Label49.Text = "Cerrar formulario"
        '
        'btEliminar
        '
        Me.btEliminar.BackColor = System.Drawing.Color.White
        Me.btEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEliminar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.ForeColor = System.Drawing.Color.Black
        Me.btEliminar.Location = New System.Drawing.Point(860, 280)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(119, 33)
        Me.btEliminar.TabIndex = 174
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Eliminar"
        Me.Column1.Name = "Column1"
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        '
        'Magnitud
        '
        Me.Magnitud.HeaderText = "Magnitud"
        Me.Magnitud.Name = "Magnitud"
        '
        'Informe
        '
        Me.Informe.HeaderText = "Informe"
        Me.Informe.Name = "Informe"
        '
        'Facturadp
        '
        Me.Facturadp.HeaderText = "Facturado"
        Me.Facturadp.Name = "Facturadp"
        '
        'ClaveContacto
        '
        Me.ClaveContacto.HeaderText = "ClaveContactoConsig"
        Me.ClaveContacto.Name = "ClaveContacto"
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        '
        'ClaveContactoUsuario
        '
        Me.ClaveContactoUsuario.HeaderText = "ClaveContacto"
        Me.ClaveContactoUsuario.Name = "ClaveContactoUsuario"
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        '
        'ClavecontactoUsuarioa
        '
        Me.ClavecontactoUsuarioa.HeaderText = "ClaveContactoUsuario"
        Me.ClavecontactoUsuarioa.Name = "ClavecontactoUsuarioa"
        '
        'FechaRecepcion
        '
        Me.FechaRecepcion.HeaderText = "Fecha de Recepcion"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        '
        'FechaCalib
        '
        Me.FechaCalib.HeaderText = "Fecha de Calibración"
        Me.FechaCalib.Name = "FechaCalib"
        '
        'FechaEmision
        '
        Me.FechaEmision.HeaderText = "Fecha de Emisión"
        Me.FechaEmision.Name = "FechaEmision"
        '
        'ServCatalogo1
        '
        Me.ServCatalogo1.HeaderText = "ServCatalogo1"
        Me.ServCatalogo1.Name = "ServCatalogo1"
        '
        'ServCatalogo2
        '
        Me.ServCatalogo2.HeaderText = "ServCatalogo2"
        Me.ServCatalogo2.Name = "ServCatalogo2"
        '
        'ServiciosAdicionales
        '
        Me.ServiciosAdicionales.HeaderText = "ServiciosAdicionales"
        Me.ServiciosAdicionales.Name = "ServiciosAdicionales"
        '
        'PUCalib
        '
        Me.PUCalib.HeaderText = "PUCalib"
        Me.PUCalib.Name = "PUCalib"
        '
        'PULab
        '
        Me.PULab.HeaderText = "PULab"
        Me.PULab.Name = "PULab"
        '
        'PUFacturado
        '
        Me.PUFacturado.HeaderText = "PUFacturado"
        Me.PUFacturado.Name = "PUFacturado"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Alcance
        '
        Me.Alcance.HeaderText = "Alcance"
        Me.Alcance.Name = "Alcance"
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Accesorios
        '
        Me.Accesorios.HeaderText = "Accesorios"
        Me.Accesorios.Name = "Accesorios"
        '
        'Puntos
        '
        Me.Puntos.HeaderText = "Puntos"
        Me.Puntos.Name = "Puntos"
        '
        'Patron1
        '
        Me.Patron1.HeaderText = "Patron1"
        Me.Patron1.Name = "Patron1"
        '
        'Patron2
        '
        Me.Patron2.HeaderText = "Patron2"
        Me.Patron2.Name = "Patron2"
        '
        'Patron3
        '
        Me.Patron3.HeaderText = "Patron3"
        Me.Patron3.Name = "Patron3"
        '
        'Funciones
        '
        Me.Funciones.HeaderText = "Funciones Calib"
        Me.Funciones.Name = "Funciones"
        '
        'Etiquetas
        '
        Me.Etiquetas.HeaderText = "Etiquetas"
        Me.Etiquetas.Name = "Etiquetas"
        '
        'HacerEtiquetas
        '
        Me.HacerEtiquetas.HeaderText = "Hacer Etiquetas"
        Me.HacerEtiquetas.Name = "HacerEtiquetas"
        '
        'DatosInforme
        '
        Me.DatosInforme.HeaderText = "Datos Informe"
        Me.DatosInforme.Name = "DatosInforme"
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'Calibro
        '
        Me.Calibro.HeaderText = "Calibro"
        Me.Calibro.Name = "Calibro"
        '
        'NumEmisiones
        '
        Me.NumEmisiones.HeaderText = "Num. Emisiones"
        Me.NumEmisiones.Name = "NumEmisiones"
        '
        'NumCot
        '
        Me.NumCot.HeaderText = "NumCot"
        Me.NumCot.Name = "NumCot"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'CveOperador
        '
        Me.CveOperador.HeaderText = "Operador"
        Me.CveOperador.Name = "CveOperador"
        '
        'RealizoMedicion
        '
        Me.RealizoMedicion.HeaderText = "Realizo-Medicion"
        Me.RealizoMedicion.Name = "RealizoMedicion"
        '
        'EmpresaEmision
        '
        Me.EmpresaEmision.HeaderText = "Empresa Emision"
        Me.EmpresaEmision.Name = "EmpresaEmision"
        '
        'DirCalle
        '
        Me.DirCalle.HeaderText = "Dir Calle Emision"
        Me.DirCalle.Name = "DirCalle"
        '
        'DirCol
        '
        Me.DirCol.HeaderText = "Dir Col Emision"
        Me.DirCol.Name = "DirCol"
        '
        'DirEdo
        '
        Me.DirEdo.HeaderText = "Dir Ciudad Emision"
        Me.DirEdo.Name = "DirEdo"
        '
        'DiEdoEm
        '
        Me.DiEdoEm.HeaderText = "Dir Edo Emision"
        Me.DiEdoEm.Name = "DiEdoEm"
        '
        'DirPais
        '
        Me.DirPais.HeaderText = "Dir Pais Emision"
        Me.DirPais.Name = "DirPais"
        '
        'DirCp
        '
        Me.DirCp.HeaderText = "Dir CP Emision"
        Me.DirCp.Name = "DirCp"
        '
        'Sv1
        '
        Me.Sv1.HeaderText = "Sv1Ajuste"
        Me.Sv1.Name = "Sv1"
        '
        'Sv3
        '
        Me.Sv3.HeaderText = "Sv3Matto"
        Me.Sv3.Name = "Sv3"
        '
        'Sv5
        '
        Me.Sv5.HeaderText = "Sv5COM2"
        Me.Sv5.Name = "Sv5"
        '
        'Sv6
        '
        Me.Sv6.HeaderText = "Sv6IntervaloRe"
        Me.Sv6.Name = "Sv6"
        '
        'Sv7
        '
        Me.Sv7.HeaderText = "Sv7Curva"
        Me.Sv7.Name = "Sv7"
        '
        'Sv8Idioma
        '
        Me.Sv8Idioma.HeaderText = "Sv8Idioma"
        Me.Sv8Idioma.Name = "Sv8Idioma"
        '
        'Sv9
        '
        Me.Sv9.HeaderText = "Sv9Calendar"
        Me.Sv9.Name = "Sv9"
        '
        'Sv10
        '
        Me.Sv10.HeaderText = "SVAD10"
        Me.Sv10.Name = "Sv10"
        '
        'FechaRegistro
        '
        Me.FechaRegistro.HeaderText = "FechaRegistro"
        Me.FechaRegistro.Name = "FechaRegistro"
        '
        'btCerrar
        '
        Me.btCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCerrar.Image = CType(resources.GetObject("btCerrar.Image"), System.Drawing.Image)
        Me.btCerrar.Location = New System.Drawing.Point(1116, 7)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btCerrar.TabIndex = 141
        Me.btCerrar.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(26, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Folio:"
        '
        'TextFolio
        '
        Me.TextFolio.Location = New System.Drawing.Point(69, 79)
        Me.TextFolio.Name = "TextFolio"
        Me.TextFolio.Size = New System.Drawing.Size(100, 23)
        Me.TextFolio.TabIndex = 176
        '
        'FrmFoliosDelAnioAnterior
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFoliosDelAnioAnterior"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmFoliosDelAnioAnterior"
        Me.TabConsulta.ResumeLayout(False)
        Me.TabFolios.ResumeLayout(False)
        Me.TabFolios.PerformLayout()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents TabFolios As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btGuardarInf As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents btCerrar As PictureBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents lbRazonSocial As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents lbServicios As Label
    Friend WithEvents btAgregarFila As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents Magnitud As DataGridViewTextBoxColumn
    Friend WithEvents Informe As DataGridViewTextBoxColumn
    Friend WithEvents Facturadp As DataGridViewTextBoxColumn
    Friend WithEvents ClaveContacto As DataGridViewTextBoxColumn
    Friend WithEvents Empresa As DataGridViewTextBoxColumn
    Friend WithEvents ClaveContactoUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents ClavecontactoUsuarioa As DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaCalib As DataGridViewTextBoxColumn
    Friend WithEvents FechaEmision As DataGridViewTextBoxColumn
    Friend WithEvents ServCatalogo1 As DataGridViewTextBoxColumn
    Friend WithEvents ServCatalogo2 As DataGridViewTextBoxColumn
    Friend WithEvents ServiciosAdicionales As DataGridViewTextBoxColumn
    Friend WithEvents PUCalib As DataGridViewTextBoxColumn
    Friend WithEvents PULab As DataGridViewTextBoxColumn
    Friend WithEvents PUFacturado As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Alcance As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Serie As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Accesorios As DataGridViewTextBoxColumn
    Friend WithEvents Puntos As DataGridViewTextBoxColumn
    Friend WithEvents Patron1 As DataGridViewTextBoxColumn
    Friend WithEvents Patron2 As DataGridViewTextBoxColumn
    Friend WithEvents Patron3 As DataGridViewTextBoxColumn
    Friend WithEvents Funciones As DataGridViewTextBoxColumn
    Friend WithEvents Etiquetas As DataGridViewTextBoxColumn
    Friend WithEvents HacerEtiquetas As DataGridViewTextBoxColumn
    Friend WithEvents DatosInforme As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Calibro As DataGridViewTextBoxColumn
    Friend WithEvents NumEmisiones As DataGridViewTextBoxColumn
    Friend WithEvents NumCot As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents CveOperador As DataGridViewTextBoxColumn
    Friend WithEvents RealizoMedicion As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaEmision As DataGridViewTextBoxColumn
    Friend WithEvents DirCalle As DataGridViewTextBoxColumn
    Friend WithEvents DirCol As DataGridViewTextBoxColumn
    Friend WithEvents DirEdo As DataGridViewTextBoxColumn
    Friend WithEvents DiEdoEm As DataGridViewTextBoxColumn
    Friend WithEvents DirPais As DataGridViewTextBoxColumn
    Friend WithEvents DirCp As DataGridViewTextBoxColumn
    Friend WithEvents Sv1 As DataGridViewTextBoxColumn
    Friend WithEvents Sv3 As DataGridViewTextBoxColumn
    Friend WithEvents Sv5 As DataGridViewTextBoxColumn
    Friend WithEvents Sv6 As DataGridViewTextBoxColumn
    Friend WithEvents Sv7 As DataGridViewTextBoxColumn
    Friend WithEvents Sv8Idioma As DataGridViewTextBoxColumn
    Friend WithEvents Sv9 As DataGridViewTextBoxColumn
    Friend WithEvents Sv10 As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As DataGridViewTextBoxColumn
    Friend WithEvents TextFolio As TextBox
    Friend WithEvents Label1 As Label
End Class
