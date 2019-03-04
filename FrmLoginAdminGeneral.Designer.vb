<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginAdminGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginAdminGeneral))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 71)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(235, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio de sesión"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(59, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdIngresar.Location = New System.Drawing.Point(260, 136)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(116, 29)
        Me.cmdIngresar.TabIndex = 22
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(123, 80)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(253, 20)
        Me.txtUsuario.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Contraseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(123, 110)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(253, 20)
        Me.txtContrasena.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Se requiere de inicio de sesión para acceder a las funciones"
        '
        'rbAdministradorSistemas
        '
        Me.rbAdministradorSistemas.AutoSize = True
        Me.rbAdministradorSistemas.Checked = True
        Me.rbAdministradorSistemas.Location = New System.Drawing.Point(279, 170)
        Me.rbAdministradorSistemas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbAdministradorSistemas.Name = "rbAdministradorSistemas"
        Me.rbAdministradorSistemas.Size = New System.Drawing.Size(130, 17)
        Me.rbAdministradorSistemas.TabIndex = 47
        Me.rbAdministradorSistemas.TabStop = True
        Me.rbAdministradorSistemas.Text = "AdministradorSistemas"
        Me.rbAdministradorSistemas.UseVisualStyleBackColor = True
        Me.rbAdministradorSistemas.Visible = False
        '
        'rbUsuariosCotizaciones
        '
        Me.rbUsuariosCotizaciones.AutoSize = True
        Me.rbUsuariosCotizaciones.Location = New System.Drawing.Point(130, 170)
        Me.rbUsuariosCotizaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.rbUsuariosCotizaciones.Name = "rbUsuariosCotizaciones"
        Me.rbUsuariosCotizaciones.Size = New System.Drawing.Size(129, 17)
        Me.rbUsuariosCotizaciones.TabIndex = 45
        Me.rbUsuariosCotizaciones.Text = "Usuarios Cotizaciones"
        Me.rbUsuariosCotizaciones.UseVisualStyleBackColor = True
        Me.rbUsuariosCotizaciones.Visible = False
        '
        'rbAdministrador
        '
        Me.rbAdministrador.AutoSize = True
        Me.rbAdministrador.Location = New System.Drawing.Point(12, 170)
        Me.rbAdministrador.Margin = New System.Windows.Forms.Padding(2)
        Me.rbAdministrador.Name = "rbAdministrador"
        Me.rbAdministrador.Size = New System.Drawing.Size(88, 17)
        Me.rbAdministrador.TabIndex = 44
        Me.rbAdministrador.Text = "Administrador"
        Me.rbAdministrador.UseVisualStyleBackColor = True
        Me.rbAdministrador.Visible = False
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(353, 192)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(49, 13)
        Me.lbVersion.TabIndex = 48
        Me.lbVersion.Text = "1.0.0.2.1"
        '
        'FrmLoginAdminGeneral
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 214)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.rbAdministradorSistemas)
        Me.Controls.Add(Me.rbUsuariosCotizaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbAdministrador)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLoginAdminGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticación de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
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
End Class
