<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoProspecto
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
        Me.cbinfoAdd = New System.Windows.Forms.CheckBox()
        Me.GBinfoAdd = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboTipoIndustria = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cboOrigen = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtHorarioProspecto = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GBInfo = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DTPFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.txtClaveRecopilada = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtNombreEmplado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtExtProspecto = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtPuestoProspecto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtCelularProspecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefonoProspecto = New System.Windows.Forms.TextBox()
        Me.cboSaludo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNombreProspecto = New System.Windows.Forms.TextBox()
        Me.txtCorreoProspecto = New System.Windows.Forms.TextBox()
        Me.txtApellidosProspecto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompaniaProspecto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GBGeneral = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cbPaisProspecto = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCPProspecto = New System.Windows.Forms.TextBox()
        Me.txtNumExtProspecto = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtEstadoProspecto = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCiudadProspecto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNotasProspecto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtColoniaProspecto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDireccionProspecto = New System.Windows.Forms.TextBox()
        Me.cbGeneral = New System.Windows.Forms.CheckBox()
        Me.cbAdicional = New System.Windows.Forms.CheckBox()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btGuardarYnuevo = New System.Windows.Forms.Button()
        Me.txtModificado = New System.Windows.Forms.Label()
        Me.txtCreado = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUsuarioActual = New System.Windows.Forms.Label()
        Me.GBinfoAdd.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GBInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GBGeneral.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbinfoAdd
        '
        Me.cbinfoAdd.AutoSize = True
        Me.cbinfoAdd.Location = New System.Drawing.Point(637, 380)
        Me.cbinfoAdd.Name = "cbinfoAdd"
        Me.cbinfoAdd.Size = New System.Drawing.Size(82, 17)
        Me.cbinfoAdd.TabIndex = 157
        Me.cbinfoAdd.Text = "Completado"
        Me.cbinfoAdd.UseVisualStyleBackColor = True
        '
        'GBinfoAdd
        '
        Me.GBinfoAdd.Controls.Add(Me.Panel3)
        Me.GBinfoAdd.Controls.Add(Me.cboTipoIndustria)
        Me.GBinfoAdd.Controls.Add(Me.Label31)
        Me.GBinfoAdd.Controls.Add(Me.cboOrigen)
        Me.GBinfoAdd.Controls.Add(Me.Label45)
        Me.GBinfoAdd.Controls.Add(Me.Label48)
        Me.GBinfoAdd.Controls.Add(Me.txtHorarioProspecto)
        Me.GBinfoAdd.Controls.Add(Me.Label35)
        Me.GBinfoAdd.Controls.Add(Me.Label4)
        Me.GBinfoAdd.Controls.Add(Me.Label34)
        Me.GBinfoAdd.Location = New System.Drawing.Point(519, 254)
        Me.GBinfoAdd.Name = "GBinfoAdd"
        Me.GBinfoAdd.Size = New System.Drawing.Size(379, 125)
        Me.GBinfoAdd.TabIndex = 156
        Me.GBinfoAdd.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(379, 27)
        Me.Panel3.TabIndex = 151
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(3, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 15)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "Información adicional"
        '
        'cboTipoIndustria
        '
        Me.cboTipoIndustria.BackColor = System.Drawing.SystemColors.Menu
        Me.cboTipoIndustria.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoIndustria.FormattingEnabled = True
        Me.cboTipoIndustria.Location = New System.Drawing.Point(118, 68)
        Me.cboTipoIndustria.Name = "cboTipoIndustria"
        Me.cboTipoIndustria.Size = New System.Drawing.Size(254, 22)
        Me.cboTipoIndustria.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(412, -15)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(17, 19)
        Me.Label31.TabIndex = 149
        Me.Label31.Text = "*"
        '
        'cboOrigen
        '
        Me.cboOrigen.BackColor = System.Drawing.SystemColors.Menu
        Me.cboOrigen.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.Location = New System.Drawing.Point(118, 40)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(254, 22)
        Me.cboOrigen.TabIndex = 0
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Red
        Me.Label45.Location = New System.Drawing.Point(438, -27)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(17, 19)
        Me.Label45.TabIndex = 135
        Me.Label45.Text = "*"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(444, -55)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(17, 19)
        Me.Label48.TabIndex = 135
        Me.Label48.Text = "*"
        '
        'txtHorarioProspecto
        '
        Me.txtHorarioProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorarioProspecto.Location = New System.Drawing.Point(118, 95)
        Me.txtHorarioProspecto.Name = "txtHorarioProspecto"
        Me.txtHorarioProspecto.Size = New System.Drawing.Size(254, 21)
        Me.txtHorarioProspecto.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Enabled = False
        Me.Label35.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(3, 71)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(92, 14)
        Me.Label35.TabIndex = 145
        Me.Label35.Text = "Tipo de Industria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 14)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Horario de trabajo:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Enabled = False
        Me.Label34.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(2, 43)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(112, 14)
        Me.Label34.TabIndex = 145
        Me.Label34.Text = "Origen del prospecto:"
        '
        'GBInfo
        '
        Me.GBInfo.Controls.Add(Me.Panel1)
        Me.GBInfo.Controls.Add(Me.txtNombreEmplado)
        Me.GBInfo.Controls.Add(Me.Label1)
        Me.GBInfo.Controls.Add(Me.Label5)
        Me.GBInfo.Controls.Add(Me.Label41)
        Me.GBInfo.Controls.Add(Me.Label29)
        Me.GBInfo.Controls.Add(Me.txtExtProspecto)
        Me.GBInfo.Controls.Add(Me.Label40)
        Me.GBInfo.Controls.Add(Me.Label38)
        Me.GBInfo.Controls.Add(Me.txtPuestoProspecto)
        Me.GBInfo.Controls.Add(Me.Label13)
        Me.GBInfo.Controls.Add(Me.cboStatus)
        Me.GBInfo.Controls.Add(Me.txtCelularProspecto)
        Me.GBInfo.Controls.Add(Me.Label3)
        Me.GBInfo.Controls.Add(Me.txtTelefonoProspecto)
        Me.GBInfo.Controls.Add(Me.cboSaludo)
        Me.GBInfo.Controls.Add(Me.Label17)
        Me.GBInfo.Controls.Add(Me.txtNombreProspecto)
        Me.GBInfo.Controls.Add(Me.txtCorreoProspecto)
        Me.GBInfo.Controls.Add(Me.txtApellidosProspecto)
        Me.GBInfo.Controls.Add(Me.Label14)
        Me.GBInfo.Controls.Add(Me.Label32)
        Me.GBInfo.Controls.Add(Me.Label9)
        Me.GBInfo.Controls.Add(Me.Label8)
        Me.GBInfo.Controls.Add(Me.Label6)
        Me.GBInfo.Controls.Add(Me.Label7)
        Me.GBInfo.Controls.Add(Me.txtCompaniaProspecto)
        Me.GBInfo.Controls.Add(Me.Label12)
        Me.GBInfo.Controls.Add(Me.Label33)
        Me.GBInfo.Location = New System.Drawing.Point(84, 21)
        Me.GBInfo.Name = "GBInfo"
        Me.GBInfo.Size = New System.Drawing.Size(814, 181)
        Me.GBInfo.TabIndex = 153
        Me.GBInfo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.DTPFechaActual)
        Me.Panel1.Controls.Add(Me.txtClaveRecopilada)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 27)
        Me.Panel1.TabIndex = 150
        '
        'DTPFechaActual
        '
        Me.DTPFechaActual.Location = New System.Drawing.Point(581, 4)
        Me.DTPFechaActual.Name = "DTPFechaActual"
        Me.DTPFechaActual.Size = New System.Drawing.Size(226, 20)
        Me.DTPFechaActual.TabIndex = 153
        Me.DTPFechaActual.Visible = False
        '
        'txtClaveRecopilada
        '
        Me.txtClaveRecopilada.AutoSize = True
        Me.txtClaveRecopilada.Enabled = False
        Me.txtClaveRecopilada.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveRecopilada.Location = New System.Drawing.Point(163, 6)
        Me.txtClaveRecopilada.Name = "txtClaveRecopilada"
        Me.txtClaveRecopilada.Size = New System.Drawing.Size(47, 14)
        Me.txtClaveRecopilada.TabIndex = 153
        Me.txtClaveRecopilada.Text = "Nombre"
        Me.txtClaveRecopilada.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtClaveRecopilada.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DimGray
        Me.Label47.Location = New System.Drawing.Point(3, 5)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(118, 15)
        Me.Label47.TabIndex = 152
        Me.Label47.Text = "Información General"
        '
        'txtNombreEmplado
        '
        Me.txtNombreEmplado.AutoSize = True
        Me.txtNombreEmplado.Enabled = False
        Me.txtNombreEmplado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmplado.Location = New System.Drawing.Point(152, 46)
        Me.txtNombreEmplado.Name = "txtNombreEmplado"
        Me.txtNombreEmplado.Size = New System.Drawing.Size(47, 14)
        Me.txtNombreEmplado.TabIndex = 153
        Me.txtNombreEmplado.Text = "Nombre"
        Me.txtNombreEmplado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 14)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Propietario del prospecto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(423, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "*"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(423, 157)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(17, 19)
        Me.Label41.TabIndex = 149
        Me.Label41.Text = "*"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(423, 101)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(17, 19)
        Me.Label29.TabIndex = 149
        Me.Label29.Text = "*"
        '
        'txtExtProspecto
        '
        Me.txtExtProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtProspecto.Location = New System.Drawing.Point(310, 157)
        Me.txtExtProspecto.MaxLength = 6
        Me.txtExtProspecto.Name = "txtExtProspecto"
        Me.txtExtProspecto.Size = New System.Drawing.Size(84, 21)
        Me.txtExtProspecto.TabIndex = 4
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(-4, 125)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(17, 19)
        Me.Label40.TabIndex = 149
        Me.Label40.Text = "*"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Red
        Me.Label38.Location = New System.Drawing.Point(-4, 97)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(17, 19)
        Me.Label38.TabIndex = 149
        Me.Label38.Text = "*"
        '
        'txtPuestoProspecto
        '
        Me.txtPuestoProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuestoProspecto.Location = New System.Drawing.Point(498, 129)
        Me.txtPuestoProspecto.Name = "txtPuestoProspecto"
        Me.txtPuestoProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtPuestoProspecto.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(-4, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 19)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "*"
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.Menu
        Me.cboStatus.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(553, 157)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(254, 22)
        Me.cboStatus.TabIndex = 10
        '
        'txtCelularProspecto
        '
        Me.txtCelularProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularProspecto.Location = New System.Drawing.Point(498, 44)
        Me.txtCelularProspecto.MaxLength = 12
        Me.txtCelularProspecto.Name = "txtCelularProspecto"
        Me.txtCelularProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtCelularProspecto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(438, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Puesto:"
        '
        'txtTelefonoProspecto
        '
        Me.txtTelefonoProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoProspecto.Location = New System.Drawing.Point(85, 155)
        Me.txtTelefonoProspecto.MaxLength = 12
        Me.txtTelefonoProspecto.Name = "txtTelefonoProspecto"
        Me.txtTelefonoProspecto.Size = New System.Drawing.Size(148, 21)
        Me.txtTelefonoProspecto.TabIndex = 3
        '
        'cboSaludo
        '
        Me.cboSaludo.BackColor = System.Drawing.SystemColors.Menu
        Me.cboSaludo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSaludo.FormattingEnabled = True
        Me.cboSaludo.Location = New System.Drawing.Point(85, 69)
        Me.cboSaludo.Name = "cboSaludo"
        Me.cboSaludo.Size = New System.Drawing.Size(309, 22)
        Me.cboSaludo.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 14)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "Tratamiento:"
        '
        'txtNombreProspecto
        '
        Me.txtNombreProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProspecto.Location = New System.Drawing.Point(85, 98)
        Me.txtNombreProspecto.Name = "txtNombreProspecto"
        Me.txtNombreProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtNombreProspecto.TabIndex = 1
        '
        'txtCorreoProspecto
        '
        Me.txtCorreoProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoProspecto.Location = New System.Drawing.Point(499, 74)
        Me.txtCorreoProspecto.Name = "txtCorreoProspecto"
        Me.txtCorreoProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtCorreoProspecto.TabIndex = 6
        '
        'txtApellidosProspecto
        '
        Me.txtApellidosProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidosProspecto.Location = New System.Drawing.Point(85, 127)
        Me.txtApellidosProspecto.Name = "txtApellidosProspecto"
        Me.txtApellidosProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtApellidosProspecto.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(438, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 14)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "Celular:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Enabled = False
        Me.Label32.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(13, 129)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 14)
        Me.Label32.TabIndex = 141
        Me.Label32.Text = "Apellidos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 14)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Correo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(247, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 14)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "Extensión:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 14)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Teléfono:"
        '
        'txtCompaniaProspecto
        '
        Me.txtCompaniaProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompaniaProspecto.Location = New System.Drawing.Point(498, 101)
        Me.txtCompaniaProspecto.Name = "txtCompaniaProspecto"
        Me.txtCompaniaProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtCompaniaProspecto.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(437, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Compañia:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Enabled = False
        Me.Label33.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(437, 161)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 14)
        Me.Label33.TabIndex = 145
        Me.Label33.Text = "Estado del prospecto:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(-4, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(17, 19)
        Me.Label30.TabIndex = 149
        Me.Label30.Text = "*"
        '
        'GBGeneral
        '
        Me.GBGeneral.Controls.Add(Me.Panel2)
        Me.GBGeneral.Controls.Add(Me.Label28)
        Me.GBGeneral.Controls.Add(Me.cbPaisProspecto)
        Me.GBGeneral.Controls.Add(Me.Label24)
        Me.GBGeneral.Controls.Add(Me.Label23)
        Me.GBGeneral.Controls.Add(Me.txtCPProspecto)
        Me.GBGeneral.Controls.Add(Me.txtNumExtProspecto)
        Me.GBGeneral.Controls.Add(Me.Label27)
        Me.GBGeneral.Controls.Add(Me.txtEstadoProspecto)
        Me.GBGeneral.Controls.Add(Me.Label26)
        Me.GBGeneral.Controls.Add(Me.Label30)
        Me.GBGeneral.Controls.Add(Me.Label22)
        Me.GBGeneral.Controls.Add(Me.txtCiudadProspecto)
        Me.GBGeneral.Controls.Add(Me.Label2)
        Me.GBGeneral.Controls.Add(Me.txtNotasProspecto)
        Me.GBGeneral.Controls.Add(Me.Label19)
        Me.GBGeneral.Controls.Add(Me.txtColoniaProspecto)
        Me.GBGeneral.Controls.Add(Me.Label11)
        Me.GBGeneral.Controls.Add(Me.Label10)
        Me.GBGeneral.Controls.Add(Me.Label15)
        Me.GBGeneral.Controls.Add(Me.txtDireccionProspecto)
        Me.GBGeneral.Location = New System.Drawing.Point(84, 253)
        Me.GBGeneral.Name = "GBGeneral"
        Me.GBGeneral.Size = New System.Drawing.Size(407, 276)
        Me.GBGeneral.TabIndex = 152
        Me.GBGeneral.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 27)
        Me.Panel2.TabIndex = 151
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.DimGray
        Me.Label42.Location = New System.Drawing.Point(3, 5)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(141, 15)
        Me.Label42.TabIndex = 152
        Me.Label42.Text = "Información de dirección"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(412, -15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(17, 19)
        Me.Label28.TabIndex = 149
        Me.Label28.Text = "*"
        '
        'cbPaisProspecto
        '
        Me.cbPaisProspecto.BackColor = System.Drawing.SystemColors.Menu
        Me.cbPaisProspecto.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPaisProspecto.FormattingEnabled = True
        Me.cbPaisProspecto.Location = New System.Drawing.Point(85, 123)
        Me.cbPaisProspecto.Name = "cbPaisProspecto"
        Me.cbPaisProspecto.Size = New System.Drawing.Size(309, 22)
        Me.cbPaisProspecto.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 14)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = "Pais:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 153)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 14)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "Estado:"
        '
        'txtCPProspecto
        '
        Me.txtCPProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPProspecto.Location = New System.Drawing.Point(285, 68)
        Me.txtCPProspecto.MaxLength = 5
        Me.txtCPProspecto.Name = "txtCPProspecto"
        Me.txtCPProspecto.Size = New System.Drawing.Size(109, 21)
        Me.txtCPProspecto.TabIndex = 2
        '
        'txtNumExtProspecto
        '
        Me.txtNumExtProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExtProspecto.Location = New System.Drawing.Point(85, 68)
        Me.txtNumExtProspecto.MaxLength = 6
        Me.txtNumExtProspecto.Name = "txtNumExtProspecto"
        Me.txtNumExtProspecto.Size = New System.Drawing.Size(169, 21)
        Me.txtNumExtProspecto.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(438, -27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 19)
        Me.Label27.TabIndex = 135
        Me.Label27.Text = "*"
        '
        'txtEstadoProspecto
        '
        Me.txtEstadoProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoProspecto.Location = New System.Drawing.Point(85, 151)
        Me.txtEstadoProspecto.Name = "txtEstadoProspecto"
        Me.txtEstadoProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtEstadoProspecto.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(444, -55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(17, 19)
        Me.Label26.TabIndex = 135
        Me.Label26.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(13, 180)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 14)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Ciudad:"
        '
        'txtCiudadProspecto
        '
        Me.txtCiudadProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudadProspecto.Location = New System.Drawing.Point(85, 178)
        Me.txtCiudadProspecto.Name = "txtCiudadProspecto"
        Me.txtCiudadProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtCiudadProspecto.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 14)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "CP:"
        '
        'txtNotasProspecto
        '
        Me.txtNotasProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotasProspecto.Location = New System.Drawing.Point(85, 209)
        Me.txtNotasProspecto.Multiline = True
        Me.txtNotasProspecto.Name = "txtNotasProspecto"
        Me.txtNotasProspecto.Size = New System.Drawing.Size(309, 64)
        Me.txtNotasProspecto.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 14)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "Notas:"
        '
        'txtColoniaProspecto
        '
        Me.txtColoniaProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColoniaProspecto.Location = New System.Drawing.Point(85, 95)
        Me.txtColoniaProspecto.Name = "txtColoniaProspecto"
        Me.txtColoniaProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtColoniaProspecto.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 14)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Colonia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "N° Exterior:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 14)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Dirección:"
        '
        'txtDireccionProspecto
        '
        Me.txtDireccionProspecto.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionProspecto.Location = New System.Drawing.Point(85, 40)
        Me.txtDireccionProspecto.Name = "txtDireccionProspecto"
        Me.txtDireccionProspecto.Size = New System.Drawing.Size(309, 21)
        Me.txtDireccionProspecto.TabIndex = 0
        '
        'cbGeneral
        '
        Me.cbGeneral.AutoSize = True
        Me.cbGeneral.Location = New System.Drawing.Point(169, 208)
        Me.cbGeneral.Name = "cbGeneral"
        Me.cbGeneral.Size = New System.Drawing.Size(82, 17)
        Me.cbGeneral.TabIndex = 155
        Me.cbGeneral.Text = "Completado"
        Me.cbGeneral.UseVisualStyleBackColor = True
        '
        'cbAdicional
        '
        Me.cbAdicional.AutoSize = True
        Me.cbAdicional.Location = New System.Drawing.Point(163, 535)
        Me.cbAdicional.Name = "cbAdicional"
        Me.cbAdicional.Size = New System.Drawing.Size(82, 17)
        Me.cbAdicional.TabIndex = 154
        Me.cbAdicional.Text = "Completado"
        Me.cbAdicional.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btGuardar.FlatAppearance.BorderSize = 0
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.ForeColor = System.Drawing.Color.White
        Me.btGuardar.Location = New System.Drawing.Point(862, 515)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(110, 34)
        Me.btGuardar.TabIndex = 0
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.White
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Location = New System.Drawing.Point(612, 515)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(110, 34)
        Me.btCancelar.TabIndex = 160
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btGuardarYnuevo
        '
        Me.btGuardarYnuevo.BackColor = System.Drawing.Color.White
        Me.btGuardarYnuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btGuardarYnuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btGuardarYnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardarYnuevo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardarYnuevo.ForeColor = System.Drawing.Color.Black
        Me.btGuardarYnuevo.Location = New System.Drawing.Point(721, 515)
        Me.btGuardarYnuevo.Name = "btGuardarYnuevo"
        Me.btGuardarYnuevo.Size = New System.Drawing.Size(141, 34)
        Me.btGuardarYnuevo.TabIndex = 161
        Me.btGuardarYnuevo.Text = "Guardar y nuevo"
        Me.btGuardarYnuevo.UseVisualStyleBackColor = False
        '
        'txtModificado
        '
        Me.txtModificado.AutoSize = True
        Me.txtModificado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificado.Location = New System.Drawing.Point(634, 440)
        Me.txtModificado.Name = "txtModificado"
        Me.txtModificado.Size = New System.Drawing.Size(96, 14)
        Me.txtModificado.TabIndex = 162
        Me.txtModificado.Text = "Horario de trabajo"
        '
        'txtCreado
        '
        Me.txtCreado.AutoSize = True
        Me.txtCreado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreado.Location = New System.Drawing.Point(634, 411)
        Me.txtCreado.Name = "txtCreado"
        Me.txtCreado.Size = New System.Drawing.Size(96, 14)
        Me.txtCreado.TabIndex = 163
        Me.txtCreado.Text = "Horario de trabajo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(523, 439)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 15)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Modificado:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(523, 410)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 15)
        Me.Label18.TabIndex = 165
        Me.Label18.Text = "Creado:"
        '
        'txtUsuarioActual
        '
        Me.txtUsuarioActual.AutoSize = True
        Me.txtUsuarioActual.Enabled = False
        Me.txtUsuarioActual.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioActual.Location = New System.Drawing.Point(567, 4)
        Me.txtUsuarioActual.Name = "txtUsuarioActual"
        Me.txtUsuarioActual.Size = New System.Drawing.Size(47, 14)
        Me.txtUsuarioActual.TabIndex = 153
        Me.txtUsuarioActual.Text = "Nombre"
        Me.txtUsuarioActual.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtUsuarioActual.Visible = False
        '
        'FrmNuevoProspecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.txtModificado)
        Me.Controls.Add(Me.txtUsuarioActual)
        Me.Controls.Add(Me.txtCreado)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btGuardarYnuevo)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.cbinfoAdd)
        Me.Controls.Add(Me.GBinfoAdd)
        Me.Controls.Add(Me.GBInfo)
        Me.Controls.Add(Me.GBGeneral)
        Me.Controls.Add(Me.cbGeneral)
        Me.Controls.Add(Me.cbAdicional)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmNuevoProspecto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Prospecto"
        Me.GBinfoAdd.ResumeLayout(False)
        Me.GBinfoAdd.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GBInfo.ResumeLayout(False)
        Me.GBInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBGeneral.ResumeLayout(False)
        Me.GBGeneral.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbinfoAdd As CheckBox
    Friend WithEvents GBinfoAdd As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents cboTipoIndustria As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cboOrigen As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtHorarioProspecto As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents GBInfo As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtExtProspecto As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtPuestoProspecto As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtCelularProspecto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefonoProspecto As TextBox
    Friend WithEvents cboSaludo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNombreProspecto As TextBox
    Friend WithEvents txtCorreoProspecto As TextBox
    Friend WithEvents txtApellidosProspecto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCompaniaProspecto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents GBGeneral As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cbPaisProspecto As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCPProspecto As TextBox
    Friend WithEvents txtNumExtProspecto As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtEstadoProspecto As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCiudadProspecto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNotasProspecto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtColoniaProspecto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDireccionProspecto As TextBox
    Friend WithEvents cbGeneral As CheckBox
    Friend WithEvents cbAdicional As CheckBox
    Friend WithEvents btGuardar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents txtNombreEmplado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFechaActual As DateTimePicker
    Friend WithEvents btGuardarYnuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtClaveRecopilada As Label
    Friend WithEvents txtModificado As Label
    Friend WithEvents txtCreado As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtUsuarioActual As Label
End Class
