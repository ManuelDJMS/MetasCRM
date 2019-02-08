<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuariosCotizadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuariosCotizadores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtNombreAdmin = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeContactosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COTIZACIONESREALIZADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContactosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónContactosEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesPorContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesPorEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Bienvenido:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(736, 342)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(769, 342)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'txtNombreAdmin
        '
        Me.txtNombreAdmin.AutoSize = True
        Me.txtNombreAdmin.Location = New System.Drawing.Point(78, 358)
        Me.txtNombreAdmin.Name = "txtNombreAdmin"
        Me.txtNombreAdmin.Size = New System.Drawing.Size(44, 13)
        Me.txtNombreAdmin.TabIndex = 34
        Me.txtNombreAdmin.Text = "Nombre"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactosToolStripMenuItem, Me.EmpresasClientesToolStripMenuItem, Me.RelaciónDeContactosClientesToolStripMenuItem, Me.COTIZACIONESREALIZADASToolStripMenuItem, Me.ReportesInformesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(858, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'EmpresasClientesToolStripMenuItem
        '
        Me.EmpresasClientesToolStripMenuItem.Name = "EmpresasClientesToolStripMenuItem"
        Me.EmpresasClientesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EmpresasClientesToolStripMenuItem.Text = "Empresas"
        '
        'RelaciónDeContactosClientesToolStripMenuItem
        '
        Me.RelaciónDeContactosClientesToolStripMenuItem.Name = "RelaciónDeContactosClientesToolStripMenuItem"
        Me.RelaciónDeContactosClientesToolStripMenuItem.Size = New System.Drawing.Size(171, 20)
        Me.RelaciónDeContactosClientesToolStripMenuItem.Text = "Relación Contacto/Empresas"
        '
        'COTIZACIONESREALIZADASToolStripMenuItem
        '
        Me.COTIZACIONESREALIZADASToolStripMenuItem.Name = "COTIZACIONESREALIZADASToolStripMenuItem"
        Me.COTIZACIONESREALIZADASToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.COTIZACIONESREALIZADASToolStripMenuItem.Text = "Cotizaciones Realizadas"
        '
        'ReportesInformesToolStripMenuItem
        '
        Me.ReportesInformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactosToolStripMenuItem1, Me.EmpresasToolStripMenuItem, Me.RelaciónContactosEmpresasToolStripMenuItem, Me.CotizacionesPorContactoToolStripMenuItem, Me.CotizacionesPorEmpresaToolStripMenuItem})
        Me.ReportesInformesToolStripMenuItem.Name = "ReportesInformesToolStripMenuItem"
        Me.ReportesInformesToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ReportesInformesToolStripMenuItem.Text = "Reportes/Informes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(695, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 51)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Nueva Cotización"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContactosToolStripMenuItem1
        '
        Me.ContactosToolStripMenuItem1.Name = "ContactosToolStripMenuItem1"
        Me.ContactosToolStripMenuItem1.Size = New System.Drawing.Size(231, 22)
        Me.ContactosToolStripMenuItem1.Text = "Contactos"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'RelaciónContactosEmpresasToolStripMenuItem
        '
        Me.RelaciónContactosEmpresasToolStripMenuItem.Name = "RelaciónContactosEmpresasToolStripMenuItem"
        Me.RelaciónContactosEmpresasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.RelaciónContactosEmpresasToolStripMenuItem.Text = "Relación Contactos/Empresas"
        '
        'CotizacionesPorContactoToolStripMenuItem
        '
        Me.CotizacionesPorContactoToolStripMenuItem.Name = "CotizacionesPorContactoToolStripMenuItem"
        Me.CotizacionesPorContactoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CotizacionesPorContactoToolStripMenuItem.Text = "Cotizaciones por Contacto"
        '
        'CotizacionesPorEmpresaToolStripMenuItem
        '
        Me.CotizacionesPorEmpresaToolStripMenuItem.Name = "CotizacionesPorEmpresaToolStripMenuItem"
        Me.CotizacionesPorEmpresaToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CotizacionesPorEmpresaToolStripMenuItem.Text = "Cotizaciones por Empresa"
        '
        'FrmUsuariosCotizadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 380)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtNombreAdmin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmUsuariosCotizadores"
        Me.Text = "COTIZADORES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNombreAdmin As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContactosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDeContactosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COTIZACIONESREALIZADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesInformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ContactosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónContactosEmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesPorContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesPorEmpresaToolStripMenuItem As ToolStripMenuItem
End Class
