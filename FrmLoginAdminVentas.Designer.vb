<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLoginAdminVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginAdminVentas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtNombreAdmin = New System.Windows.Forms.Label()
        Me.Catalogos = New System.Windows.Forms.MenuStrip()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónContactosEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónContactosEmpresasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesPorCONTACTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesPorEMPRESAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Catalogos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(741, 395)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(774, 395)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'txtNombreAdmin
        '
        Me.txtNombreAdmin.AutoSize = True
        Me.txtNombreAdmin.Location = New System.Drawing.Point(78, 411)
        Me.txtNombreAdmin.Name = "txtNombreAdmin"
        Me.txtNombreAdmin.Size = New System.Drawing.Size(44, 13)
        Me.txtNombreAdmin.TabIndex = 29
        Me.txtNombreAdmin.Text = "Nombre"
        '
        'Catalogos
        '
        Me.Catalogos.BackColor = System.Drawing.Color.Transparent
        Me.Catalogos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem, Me.ContactosToolStripMenuItem, Me.RelaciónContactosEmpresasToolStripMenuItem, Me.ReportesPDFToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.Catalogos.Location = New System.Drawing.Point(0, 0)
        Me.Catalogos.Name = "Catalogos"
        Me.Catalogos.Size = New System.Drawing.Size(863, 24)
        Me.Catalogos.TabIndex = 30
        Me.Catalogos.Text = "MenuStrip1"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevaEmpresaToolStripMenuItem})
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'AgregarNuevaEmpresaToolStripMenuItem
        '
        Me.AgregarNuevaEmpresaToolStripMenuItem.Name = "AgregarNuevaEmpresaToolStripMenuItem"
        Me.AgregarNuevaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AgregarNuevaEmpresaToolStripMenuItem.Text = "Agregar nueva empresa"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoContactoToolStripMenuItem})
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'AgregarNuevoContactoToolStripMenuItem
        '
        Me.AgregarNuevoContactoToolStripMenuItem.Name = "AgregarNuevoContactoToolStripMenuItem"
        Me.AgregarNuevoContactoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AgregarNuevoContactoToolStripMenuItem.Text = "Agregar nuevo contacto"
        '
        'RelaciónContactosEmpresasToolStripMenuItem
        '
        Me.RelaciónContactosEmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelacionesToolStripMenuItem})
        Me.RelaciónContactosEmpresasToolStripMenuItem.Name = "RelaciónContactosEmpresasToolStripMenuItem"
        Me.RelaciónContactosEmpresasToolStripMenuItem.Size = New System.Drawing.Size(176, 20)
        Me.RelaciónContactosEmpresasToolStripMenuItem.Text = "Relación Contactos-Empresas"
        '
        'RelacionesToolStripMenuItem
        '
        Me.RelacionesToolStripMenuItem.Name = "RelacionesToolStripMenuItem"
        Me.RelacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RelacionesToolStripMenuItem.Text = "Agregar relación"
        '
        'ReportesPDFToolStripMenuItem
        '
        Me.ReportesPDFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactosToolStripMenuItem1, Me.EmpresasToolStripMenuItem1, Me.RelaciónContactosEmpresasToolStripMenuItem1, Me.CotizacionesPorCONTACTOToolStripMenuItem, Me.CotizacionesPorEMPRESAToolStripMenuItem})
        Me.ReportesPDFToolStripMenuItem.Name = "ReportesPDFToolStripMenuItem"
        Me.ReportesPDFToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ReportesPDFToolStripMenuItem.Text = "Reportes PDF"
        '
        'ContactosToolStripMenuItem1
        '
        Me.ContactosToolStripMenuItem1.Name = "ContactosToolStripMenuItem1"
        Me.ContactosToolStripMenuItem1.Size = New System.Drawing.Size(237, 22)
        Me.ContactosToolStripMenuItem1.Text = "Contactos"
        '
        'EmpresasToolStripMenuItem1
        '
        Me.EmpresasToolStripMenuItem1.Name = "EmpresasToolStripMenuItem1"
        Me.EmpresasToolStripMenuItem1.Size = New System.Drawing.Size(237, 22)
        Me.EmpresasToolStripMenuItem1.Text = "Empresas"
        '
        'RelaciónContactosEmpresasToolStripMenuItem1
        '
        Me.RelaciónContactosEmpresasToolStripMenuItem1.Name = "RelaciónContactosEmpresasToolStripMenuItem1"
        Me.RelaciónContactosEmpresasToolStripMenuItem1.Size = New System.Drawing.Size(237, 22)
        Me.RelaciónContactosEmpresasToolStripMenuItem1.Text = "Relación Contactos - Empresas"
        '
        'CotizacionesPorCONTACTOToolStripMenuItem
        '
        Me.CotizacionesPorCONTACTOToolStripMenuItem.Name = "CotizacionesPorCONTACTOToolStripMenuItem"
        Me.CotizacionesPorCONTACTOToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.CotizacionesPorCONTACTOToolStripMenuItem.Text = "Cotizaciones por CONTACTO"
        '
        'CotizacionesPorEMPRESAToolStripMenuItem
        '
        Me.CotizacionesPorEMPRESAToolStripMenuItem.Name = "CotizacionesPorEMPRESAToolStripMenuItem"
        Me.CotizacionesPorEMPRESAToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.CotizacionesPorEMPRESAToolStripMenuItem.Text = "Cotizaciones por EMPRESA"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Bienvenido:"
        '
        'FrmLoginAdminVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(863, 433)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Catalogos)
        Me.Controls.Add(Me.txtNombreAdmin)
        Me.MaximizeBox = False
        Me.Name = "FrmLoginAdminVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADMINISTRADOR GENERAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Catalogos.ResumeLayout(False)
        Me.Catalogos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNombreAdmin As Label
    Friend WithEvents Catalogos As MenuStrip
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevaEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónContactosEmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RelaciónContactosEmpresasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CotizacionesPorCONTACTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesPorEMPRESAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
