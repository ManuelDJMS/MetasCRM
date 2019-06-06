<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotizadorLIMS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizadorLIMS))
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.Tab2018 = New System.Windows.Forms.TabPage()
        Me.TextArticulo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PanelCot = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNombreProspecto = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombreCompania = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtclavee = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelNormal = New System.Windows.Forms.Panel()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGEmpresas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgAgregar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btCotizacion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.lblCot = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.DGCotizaciones = New System.Windows.Forms.DataGridView()
        Me.s = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TabConsulta.SuspendLayout()
        Me.Tab2018.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelCot.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelNormal.SuspendLayout()
        CType(Me.DGEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Controls.Add(Me.Tab2018)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(4, 10)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 649)
        Me.TabConsulta.TabIndex = 142
        '
        'Tab2018
        '
        Me.Tab2018.BackColor = System.Drawing.Color.Gainsboro
        Me.Tab2018.Controls.Add(Me.TextArticulo)
        Me.Tab2018.Controls.Add(Me.Label7)
        Me.Tab2018.Controls.Add(Me.Panel1)
        Me.Tab2018.Controls.Add(Me.PanelCot)
        Me.Tab2018.Controls.Add(Me.Panel5)
        Me.Tab2018.Controls.Add(Me.PanelNormal)
        Me.Tab2018.Controls.Add(Me.btCotizacion)
        Me.Tab2018.Controls.Add(Me.Label3)
        Me.Tab2018.Controls.Add(Me.txtMarca)
        Me.Tab2018.Controls.Add(Me.Label1)
        Me.Tab2018.Controls.Add(Me.lblMarca)
        Me.Tab2018.Controls.Add(Me.TextID)
        Me.Tab2018.Controls.Add(Me.lblCot)
        Me.Tab2018.Controls.Add(Me.lblModelo)
        Me.Tab2018.Controls.Add(Me.txtModelo)
        Me.Tab2018.Controls.Add(Me.DGCotizaciones)
        Me.Tab2018.Controls.Add(Me.Panel2)
        Me.Tab2018.Location = New System.Drawing.Point(4, 24)
        Me.Tab2018.Name = "Tab2018"
        Me.Tab2018.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2018.Size = New System.Drawing.Size(1140, 621)
        Me.Tab2018.TabIndex = 5
        Me.Tab2018.Text = "Nueva cotización"
        '
        'TextArticulo
        '
        Me.TextArticulo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextArticulo.Location = New System.Drawing.Point(394, 358)
        Me.TextArticulo.Name = "TextArticulo"
        Me.TextArticulo.Size = New System.Drawing.Size(139, 21)
        Me.TextArticulo.TabIndex = 182
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(337, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Artículo:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Location = New System.Drawing.Point(408, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 27)
        Me.Panel1.TabIndex = 181
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label30.Location = New System.Drawing.Point(3, 6)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 15)
        Me.Label30.TabIndex = 152
        Me.Label30.Text = "Datos Cotización"
        '
        'PanelCot
        '
        Me.PanelCot.Controls.Add(Me.Label21)
        Me.PanelCot.Controls.Add(Me.Label20)
        Me.PanelCot.Controls.Add(Me.txtNombreProspecto)
        Me.PanelCot.Controls.Add(Me.txtCorreo)
        Me.PanelCot.Controls.Add(Me.Label9)
        Me.PanelCot.Controls.Add(Me.txtTelefono)
        Me.PanelCot.Controls.Add(Me.Label10)
        Me.PanelCot.Controls.Add(Me.txtNombreCompania)
        Me.PanelCot.Controls.Add(Me.Label11)
        Me.PanelCot.Controls.Add(Me.Label12)
        Me.PanelCot.Location = New System.Drawing.Point(6, 91)
        Me.PanelCot.Name = "PanelCot"
        Me.PanelCot.Size = New System.Drawing.Size(395, 243)
        Me.PanelCot.TabIndex = 175
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(191, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 14)
        Me.Label21.TabIndex = 172
        Me.Label21.Text = "click aquí"
        Me.Label21.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(186, 14)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Si deseas cotizar a otro prospecto da"
        Me.Label20.Visible = False
        '
        'txtNombreProspecto
        '
        Me.txtNombreProspecto.AutoSize = True
        Me.txtNombreProspecto.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProspecto.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNombreProspecto.Location = New System.Drawing.Point(7, 52)
        Me.txtNombreProspecto.Name = "txtNombreProspecto"
        Me.txtNombreProspecto.Size = New System.Drawing.Size(169, 23)
        Me.txtNombreProspecto.TabIndex = 152
        Me.txtNombreProspecto.Text = "Información general"
        '
        'txtCorreo
        '
        Me.txtCorreo.AutoSize = True
        Me.txtCorreo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(83, 117)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(96, 14)
        Me.txtCorreo.TabIndex = 162
        Me.txtCorreo.Text = "Correo electronico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Correo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.AutoSize = True
        Me.txtTelefono.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(83, 141)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(106, 14)
        Me.txtTelefono.TabIndex = 158
        Me.txtTelefono.Text = "Numero de telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Teléfono:"
        '
        'txtNombreCompania
        '
        Me.txtNombreCompania.AutoSize = True
        Me.txtNombreCompania.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompania.Location = New System.Drawing.Point(83, 92)
        Me.txtNombreCompania.Name = "txtNombreCompania"
        Me.txtNombreCompania.Size = New System.Drawing.Size(125, 14)
        Me.txtNombreCompania.TabIndex = 156
        Me.txtNombreCompania.Text = "Nombre de la compañia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 15)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Esta cotización será realizada para el cliente:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 15)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Compañia:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.txtclavee)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(6, 58)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(395, 27)
        Me.Panel5.TabIndex = 170
        '
        'txtclavee
        '
        Me.txtclavee.AutoSize = True
        Me.txtclavee.Location = New System.Drawing.Point(211, 6)
        Me.txtclavee.Name = "txtclavee"
        Me.txtclavee.Size = New System.Drawing.Size(61, 15)
        Me.txtclavee.TabIndex = 166
        Me.txtclavee.Text = "Parametro"
        Me.txtclavee.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(8, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Información general"
        '
        'PanelNormal
        '
        Me.PanelNormal.Controls.Add(Me.txtClave)
        Me.PanelNormal.Controls.Add(Me.Label4)
        Me.PanelNormal.Controls.Add(Me.Label42)
        Me.PanelNormal.Controls.Add(Me.TextCorreo)
        Me.PanelNormal.Controls.Add(Me.Label5)
        Me.PanelNormal.Controls.Add(Me.DGEmpresas)
        Me.PanelNormal.Controls.Add(Me.DgAgregar)
        Me.PanelNormal.Location = New System.Drawing.Point(408, 91)
        Me.PanelNormal.Name = "PanelNormal"
        Me.PanelNormal.Size = New System.Drawing.Size(726, 243)
        Me.PanelNormal.TabIndex = 174
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(159, 9)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(76, 21)
        Me.txtClave.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "idContacto:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label42.Location = New System.Drawing.Point(19, 8)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(49, 19)
        Me.Label42.TabIndex = 152
        Me.Label42.Text = "Filtro:"
        '
        'TextCorreo
        '
        Me.TextCorreo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCorreo.Location = New System.Drawing.Point(334, 9)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(152, 21)
        Me.TextCorreo.TabIndex = 163
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Correo:"
        '
        'DGEmpresas
        '
        Me.DGEmpresas.AllowUserToDeleteRows = False
        Me.DGEmpresas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column10, Me.Column11, Me.Telefono})
        Me.DGEmpresas.Location = New System.Drawing.Point(23, 36)
        Me.DGEmpresas.Name = "DGEmpresas"
        Me.DGEmpresas.ReadOnly = True
        Me.DGEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEmpresas.Size = New System.Drawing.Size(691, 204)
        Me.DGEmpresas.TabIndex = 154
        '
        'Column1
        '
        Me.Column1.HeaderText = "idContacto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellidos"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "Compañia"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 250
        '
        'Column10
        '
        Me.Column10.HeaderText = "RFC"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 150
        '
        'Column11
        '
        Me.Column11.HeaderText = "Correo"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 300
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'DgAgregar
        '
        Me.DgAgregar.AllowUserToDeleteRows = False
        Me.DgAgregar.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgAgregar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgAgregar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAgregar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAgregar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        Me.DgAgregar.Location = New System.Drawing.Point(424, 163)
        Me.DgAgregar.Name = "DgAgregar"
        Me.DgAgregar.Size = New System.Drawing.Size(145, 141)
        Me.DgAgregar.TabIndex = 182
        Me.DgAgregar.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'btCotizacion
        '
        Me.btCotizacion.BackColor = System.Drawing.Color.SteelBlue
        Me.btCotizacion.FlatAppearance.BorderSize = 0
        Me.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCotizacion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCotizacion.ForeColor = System.Drawing.Color.White
        Me.btCotizacion.Location = New System.Drawing.Point(983, 348)
        Me.btCotizacion.Name = "btCotizacion"
        Me.btCotizacion.Size = New System.Drawing.Size(111, 33)
        Me.btCotizacion.TabIndex = 173
        Me.btCotizacion.Text = "Cotizar"
        Me.btCotizacion.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(35, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Filtrar por:"
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(583, 359)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(139, 21)
        Me.txtMarca.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "MetAs_id:"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(537, 360)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(44, 15)
        Me.lblMarca.TabIndex = 132
        Me.lblMarca.Text = "Marca:"
        '
        'TextID
        '
        Me.TextID.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(208, 359)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(112, 21)
        Me.TextID.TabIndex = 165
        '
        'lblCot
        '
        Me.lblCot.AutoSize = True
        Me.lblCot.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCot.Location = New System.Drawing.Point(11, 337)
        Me.lblCot.Name = "lblCot"
        Me.lblCot.Size = New System.Drawing.Size(67, 18)
        Me.lblCot.TabIndex = 156
        Me.lblCot.Text = "Artículos:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(744, 362)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 15)
        Me.lblModelo.TabIndex = 153
        Me.lblModelo.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(803, 359)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(140, 21)
        Me.txtModelo.TabIndex = 152
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
        Me.DGCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.s, Me.ID, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DGCotizaciones.Location = New System.Drawing.Point(14, 390)
        Me.DGCotizaciones.Name = "DGCotizaciones"
        Me.DGCotizaciones.Size = New System.Drawing.Size(1120, 225)
        Me.DGCotizaciones.TabIndex = 155
        '
        's
        '
        Me.s.HeaderText = "Seleccionar"
        Me.s.Name = "s"
        Me.s.Width = 80
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "MetAs_id"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 160
        '
        'Column6
        '
        Me.Column6.HeaderText = "Equipo"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 400
        '
        'Column7
        '
        Me.Column7.HeaderText = "Marca"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 200
        '
        'Column8
        '
        Me.Column8.HeaderText = "Modelo"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 200
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
        Me.Panel2.Size = New System.Drawing.Size(1140, 52)
        Me.Panel2.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(991, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Parametro"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(216, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Nueva Cotización para Prospectos"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 7)
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
        Me.Label27.Location = New System.Drawing.Point(55, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Cotización"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1128, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 143
        Me.PictureBox5.TabStop = False
        '
        'FrmCotizadorLIMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.Name = "FrmCotizadorLIMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCotizadorLIMS"
        Me.TabConsulta.ResumeLayout(False)
        Me.Tab2018.ResumeLayout(False)
        Me.Tab2018.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelCot.ResumeLayout(False)
        Me.PanelCot.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelNormal.ResumeLayout(False)
        Me.PanelNormal.PerformLayout()
        CType(Me.DGEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents Tab2018 As TabPage
    Friend WithEvents PanelCot As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNombreProspecto As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtclavee As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefono As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombreCompania As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PanelNormal As Panel
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGEmpresas As DataGridView
    Friend WithEvents btCotizacion As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents lblCot As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents DGCotizaciones As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents DgAgregar As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TextArticulo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents s As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
