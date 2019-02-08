<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresas))
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.txtCorreoCompaniaConsulta = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCompaniaConsutla = New System.Windows.Forms.TextBox()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.txtClaveCompaniaConsulta = New System.Windows.Forms.TextBox()
        Me.LabelClave = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.txtCompaniaConsulta = New System.Windows.Forms.TextBox()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.cbClave = New System.Windows.Forms.CheckBox()
        Me.cbTelefono = New System.Windows.Forms.CheckBox()
        Me.cbNombre = New System.Windows.Forms.CheckBox()
        Me.cbCorreo = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DGConsulta2 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.DGConsulta1 = New System.Windows.Forms.DataGridView()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.Label()
        Me.TabConsulta.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DGConsulta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConsulta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.Controls.Add(Me.TabPage2)
        Me.TabConsulta.Controls.Add(Me.TabPage5)
        Me.TabConsulta.Location = New System.Drawing.Point(2, 30)
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 639)
        Me.TabConsulta.TabIndex = 42
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.PictureBox12)
        Me.TabPage2.Controls.Add(Me.LabelCorreo)
        Me.TabPage2.Controls.Add(Me.txtCorreoCompaniaConsulta)
        Me.TabPage2.Controls.Add(Me.txtTelefonoCompaniaConsutla)
        Me.TabPage2.Controls.Add(Me.LabelTel)
        Me.TabPage2.Controls.Add(Me.txtClaveCompaniaConsulta)
        Me.TabPage2.Controls.Add(Me.LabelClave)
        Me.TabPage2.Controls.Add(Me.LabelNombre)
        Me.TabPage2.Controls.Add(Me.txtCompaniaConsulta)
        Me.TabPage2.Controls.Add(Me.DGConsulta)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.PictureBox10)
        Me.TabPage2.Controls.Add(Me.PictureBox11)
        Me.TabPage2.Controls.Add(Me.cbClave)
        Me.TabPage2.Controls.Add(Me.cbTelefono)
        Me.TabPage2.Controls.Add(Me.cbNombre)
        Me.TabPage2.Controls.Add(Me.cbCorreo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1140, 613)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Consulta general por parametros"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(997, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 32)
        Me.Button3.TabIndex = 138
        Me.Button3.Text = "Exportar Consulta"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox12.Enabled = False
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(961, 12)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 43
        Me.PictureBox12.TabStop = False
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelCorreo.Location = New System.Drawing.Point(287, 94)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(54, 18)
        Me.LabelCorreo.TabIndex = 132
        Me.LabelCorreo.Text = "Correo:"
        Me.LabelCorreo.Visible = False
        '
        'txtCorreoCompaniaConsulta
        '
        Me.txtCorreoCompaniaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoCompaniaConsulta.Location = New System.Drawing.Point(347, 94)
        Me.txtCorreoCompaniaConsulta.Name = "txtCorreoCompaniaConsulta"
        Me.txtCorreoCompaniaConsulta.Size = New System.Drawing.Size(158, 20)
        Me.txtCorreoCompaniaConsulta.TabIndex = 129
        Me.txtCorreoCompaniaConsulta.Visible = False
        '
        'txtTelefonoCompaniaConsutla
        '
        Me.txtTelefonoCompaniaConsutla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoCompaniaConsutla.Location = New System.Drawing.Point(645, 51)
        Me.txtTelefonoCompaniaConsutla.Name = "txtTelefonoCompaniaConsutla"
        Me.txtTelefonoCompaniaConsutla.Size = New System.Drawing.Size(158, 20)
        Me.txtTelefonoCompaniaConsutla.TabIndex = 131
        Me.txtTelefonoCompaniaConsutla.Visible = False
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelTel.Location = New System.Drawing.Point(572, 53)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(67, 18)
        Me.LabelTel.TabIndex = 130
        Me.LabelTel.Text = "Teléfono:"
        Me.LabelTel.Visible = False
        '
        'txtClaveCompaniaConsulta
        '
        Me.txtClaveCompaniaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveCompaniaConsulta.Location = New System.Drawing.Point(645, 77)
        Me.txtClaveCompaniaConsulta.Name = "txtClaveCompaniaConsulta"
        Me.txtClaveCompaniaConsulta.Size = New System.Drawing.Size(158, 20)
        Me.txtClaveCompaniaConsulta.TabIndex = 128
        Me.txtClaveCompaniaConsulta.Visible = False
        '
        'LabelClave
        '
        Me.LabelClave.AutoSize = True
        Me.LabelClave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelClave.Location = New System.Drawing.Point(511, 77)
        Me.LabelClave.Name = "LabelClave"
        Me.LabelClave.Size = New System.Drawing.Size(128, 18)
        Me.LabelClave.TabIndex = 127
        Me.LabelClave.Text = "Clave de compañia:"
        Me.LabelClave.Visible = False
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.Location = New System.Drawing.Point(565, 103)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(74, 18)
        Me.LabelNombre.TabIndex = 125
        Me.LabelNombre.Text = "Compañia:"
        Me.LabelNombre.Visible = False
        '
        'txtCompaniaConsulta
        '
        Me.txtCompaniaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompaniaConsulta.Location = New System.Drawing.Point(645, 103)
        Me.txtCompaniaConsulta.Name = "txtCompaniaConsulta"
        Me.txtCompaniaConsulta.Size = New System.Drawing.Size(158, 20)
        Me.txtCompaniaConsulta.TabIndex = 126
        Me.txtCompaniaConsulta.Visible = False
        '
        'DGConsulta
        '
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Location = New System.Drawing.Point(6, 124)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.Size = New System.Drawing.Size(1111, 458)
        Me.DGConsulta.TabIndex = 124
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.Label39.Location = New System.Drawing.Point(112, 12)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(393, 17)
        Me.Label39.TabIndex = 121
        Me.Label39.Text = "Seleccióna una casilla para realizar búsqueda de Clientes / Empresas."
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 122
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(43, 12)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(63, 24)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 123
        Me.PictureBox11.TabStop = False
        '
        'cbClave
        '
        Me.cbClave.AutoSize = True
        Me.cbClave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbClave.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbClave.Location = New System.Drawing.Point(125, 66)
        Me.cbClave.Name = "cbClave"
        Me.cbClave.Size = New System.Drawing.Size(143, 22)
        Me.cbClave.TabIndex = 63
        Me.cbClave.Text = "Clave de compañia"
        Me.cbClave.UseVisualStyleBackColor = True
        '
        'cbTelefono
        '
        Me.cbTelefono.AutoSize = True
        Me.cbTelefono.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbTelefono.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbTelefono.Location = New System.Drawing.Point(293, 66)
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(50, 22)
        Me.cbTelefono.TabIndex = 62
        Me.cbTelefono.Text = "RFC"
        Me.cbTelefono.UseVisualStyleBackColor = True
        '
        'cbNombre
        '
        Me.cbNombre.AutoSize = True
        Me.cbNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbNombre.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbNombre.Location = New System.Drawing.Point(13, 66)
        Me.cbNombre.Name = "cbNombre"
        Me.cbNombre.Size = New System.Drawing.Size(89, 22)
        Me.cbNombre.TabIndex = 61
        Me.cbNombre.Text = "Compañia"
        Me.cbNombre.UseVisualStyleBackColor = True
        '
        'cbCorreo
        '
        Me.cbCorreo.AutoSize = True
        Me.cbCorreo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbCorreo.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbCorreo.Location = New System.Drawing.Point(374, 66)
        Me.cbCorreo.Name = "cbCorreo"
        Me.cbCorreo.Size = New System.Drawing.Size(69, 22)
        Me.cbCorreo.TabIndex = 60
        Me.cbCorreo.Text = "Correo"
        Me.cbCorreo.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage5.Controls.Add(Me.DGConsulta2)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.TextBox1)
        Me.TabPage5.Controls.Add(Me.TextBox2)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.TextBox3)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.TextBox5)
        Me.TabPage5.Controls.Add(Me.CheckBox4)
        Me.TabPage5.Controls.Add(Me.CheckBox5)
        Me.TabPage5.Controls.Add(Me.CheckBox6)
        Me.TabPage5.Controls.Add(Me.CheckBox7)
        Me.TabPage5.Controls.Add(Me.DGConsulta1)
        Me.TabPage5.Controls.Add(Me.Label46)
        Me.TabPage5.Controls.Add(Me.PictureBox8)
        Me.TabPage5.Controls.Add(Me.PictureBox9)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1140, 613)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Consulta de contactos por empresa"
        '
        'DGConsulta2
        '
        Me.DGConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta2.Location = New System.Drawing.Point(593, 129)
        Me.DGConsulta2.Name = "DGConsulta2"
        Me.DGConsulta2.Size = New System.Drawing.Size(533, 467)
        Me.DGConsulta2.TabIndex = 154
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(590, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Datos de contactos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Correo:"
        Me.Label2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(70, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 149
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(316, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 151
        Me.TextBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(243, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Teléfono:"
        Me.Label3.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(626, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(158, 20)
        Me.TextBox3.TabIndex = 148
        Me.TextBox3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(492, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Clave de compañia:"
        Me.Label4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(790, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "Compañia:"
        Me.Label8.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(870, 89)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(143, 20)
        Me.TextBox5.TabIndex = 146
        Me.TextBox5.Visible = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox4.ForeColor = System.Drawing.Color.SteelBlue
        Me.CheckBox4.Location = New System.Drawing.Point(125, 54)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(143, 22)
        Me.CheckBox4.TabIndex = 144
        Me.CheckBox4.Text = "Clave de compañia"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox5.ForeColor = System.Drawing.Color.SteelBlue
        Me.CheckBox5.Location = New System.Drawing.Point(293, 54)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(50, 22)
        Me.CheckBox5.TabIndex = 143
        Me.CheckBox5.Text = "RFC"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox6.ForeColor = System.Drawing.Color.SteelBlue
        Me.CheckBox6.Location = New System.Drawing.Point(13, 54)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(89, 22)
        Me.CheckBox6.TabIndex = 142
        Me.CheckBox6.Text = "Compañia"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox7.ForeColor = System.Drawing.Color.SteelBlue
        Me.CheckBox7.Location = New System.Drawing.Point(374, 54)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(69, 22)
        Me.CheckBox7.TabIndex = 141
        Me.CheckBox7.Text = "Correo"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'DGConsulta1
        '
        Me.DGConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta1.Location = New System.Drawing.Point(13, 129)
        Me.DGConsulta1.Name = "DGConsulta1"
        Me.DGConsulta1.Size = New System.Drawing.Size(538, 467)
        Me.DGConsulta1.TabIndex = 140
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.Label46.Location = New System.Drawing.Point(112, 12)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(220, 17)
        Me.Label46.TabIndex = 137
        Me.Label46.Text = "Contactos pertenecientes a empresas"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 138
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(43, 12)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(63, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 139
        Me.PictureBox9.TabStop = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Cursor = System.Windows.Forms.Cursors.No
        Me.Label49.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1026, 14)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 14)
        Me.Label49.TabIndex = 140
        Me.Label49.Text = "Cerrar formulario"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1122, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 139
        Me.PictureBox5.TabStop = False
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.AutoSize = True
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(386, 10)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(113, 17)
        Me.txtNombreEmpleado.TabIndex = 153
        Me.txtNombreEmpleado.Text = "Nombre Empleado"
        '
        'FrmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.Name = "FrmEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Empresas registradas a MetAs"
        Me.TabConsulta.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DGConsulta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConsulta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents txtCorreoCompaniaConsulta As TextBox
    Friend WithEvents txtTelefonoCompaniaConsutla As TextBox
    Friend WithEvents LabelTel As Label
    Friend WithEvents txtClaveCompaniaConsulta As TextBox
    Friend WithEvents LabelClave As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents txtCompaniaConsulta As TextBox
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents Label39 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents cbClave As CheckBox
    Friend WithEvents cbTelefono As CheckBox
    Friend WithEvents cbNombre As CheckBox
    Friend WithEvents cbCorreo As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DGConsulta1 As DataGridView
    Friend WithEvents Label46 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label49 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents DGConsulta2 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombreEmpleado As Label
End Class
