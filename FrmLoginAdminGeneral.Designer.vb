<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLoginAdminGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginAdminGeneral))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbAdministradorSistemas = New System.Windows.Forms.RadioButton()
        Me.rbUsuariosCotizaciones = New System.Windows.Forms.RadioButton()
        Me.rbAdministrador = New System.Windows.Forms.RadioButton()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdIngresar.Location = New System.Drawing.Point(406, 188)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(44, 16)
        Me.cmdIngresar.TabIndex = 22
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        Me.cmdIngresar.Visible = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(154, 97)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(296, 31)
        Me.txtUsuario.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Contraseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(154, 134)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(296, 31)
        Me.txtContrasena.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(312, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Se requiere de inicio de sesión para acceder a las funciones"
        '
        'rbAdministradorSistemas
        '
        Me.rbAdministradorSistemas.AutoSize = True
        Me.rbAdministradorSistemas.BackColor = System.Drawing.Color.Gainsboro
        Me.rbAdministradorSistemas.Checked = True
        Me.rbAdministradorSistemas.Location = New System.Drawing.Point(322, 209)
        Me.rbAdministradorSistemas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbAdministradorSistemas.Name = "rbAdministradorSistemas"
        Me.rbAdministradorSistemas.Size = New System.Drawing.Size(130, 17)
        Me.rbAdministradorSistemas.TabIndex = 47
        Me.rbAdministradorSistemas.TabStop = True
        Me.rbAdministradorSistemas.Text = "AdministradorSistemas"
        Me.rbAdministradorSistemas.UseVisualStyleBackColor = False
        Me.rbAdministradorSistemas.Visible = False
        '
        'rbUsuariosCotizaciones
        '
        Me.rbUsuariosCotizaciones.AutoSize = True
        Me.rbUsuariosCotizaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.rbUsuariosCotizaciones.Location = New System.Drawing.Point(173, 209)
        Me.rbUsuariosCotizaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.rbUsuariosCotizaciones.Name = "rbUsuariosCotizaciones"
        Me.rbUsuariosCotizaciones.Size = New System.Drawing.Size(129, 17)
        Me.rbUsuariosCotizaciones.TabIndex = 45
        Me.rbUsuariosCotizaciones.Text = "Usuarios Cotizaciones"
        Me.rbUsuariosCotizaciones.UseVisualStyleBackColor = False
        Me.rbUsuariosCotizaciones.Visible = False
        '
        'rbAdministrador
        '
        Me.rbAdministrador.AutoSize = True
        Me.rbAdministrador.BackColor = System.Drawing.Color.Gainsboro
        Me.rbAdministrador.Location = New System.Drawing.Point(55, 209)
        Me.rbAdministrador.Margin = New System.Windows.Forms.Padding(2)
        Me.rbAdministrador.Name = "rbAdministrador"
        Me.rbAdministrador.Size = New System.Drawing.Size(88, 17)
        Me.rbAdministrador.TabIndex = 44
        Me.rbAdministrador.Text = "Administrador"
        Me.rbAdministrador.UseVisualStyleBackColor = False
        Me.rbAdministrador.Visible = False
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.BackColor = System.Drawing.Color.Gainsboro
        Me.lbVersion.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.Location = New System.Drawing.Point(402, 239)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(48, 15)
        Me.lbVersion.TabIndex = 48
        Me.lbVersion.Text = "1.0.0.2.3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(280, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 33)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Inicio de sesión"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(86, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(154, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 33)
        Me.Button1.TabIndex = 167
        Me.Button1.Text = "INICIAR SESIÓN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmLoginAdminGeneral
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(502, 278)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbAdministradorSistemas)
        Me.Controls.Add(Me.rbUsuariosCotizaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbAdministrador)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cmdIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLoginAdminGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticación de Usuarios"
        Me.TransparencyKey = System.Drawing.Color.RosyBrown
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbAdministradorSistemas As RadioButton
    Friend WithEvents rbUsuariosCotizaciones As RadioButton
    Friend WithEvents rbAdministrador As RadioButton
    Friend WithEvents lbVersion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
