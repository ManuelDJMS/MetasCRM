<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFiltrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFiltrar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgEmpresas = New System.Windows.Forms.DataGridView()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.TextEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btGuardarInf = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCotizacion19 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.dgEmpresas)
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 365)
        Me.Panel1.TabIndex = 162
        '
        'dgEmpresas
        '
        Me.dgEmpresas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgEmpresas.Location = New System.Drawing.Point(3, 86)
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.Size = New System.Drawing.Size(573, 271)
        Me.dgEmpresas.TabIndex = 156
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(501, 43)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(70, 21)
        Me.txtClave.TabIndex = 173
        '
        'TextEmpresa
        '
        Me.TextEmpresa.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmpresa.Location = New System.Drawing.Point(229, 43)
        Me.TextEmpresa.Name = "TextEmpresa"
        Me.TextEmpresa.Size = New System.Drawing.Size(179, 21)
        Me.TextEmpresa.TabIndex = 170
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(512, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Salir"
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.Transparent
        Me.btSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalir.Image = CType(resources.GetObject("btSalir.Image"), System.Drawing.Image)
        Me.btSalir.Location = New System.Drawing.Point(551, 3)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(24, 24)
        Me.btSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btSalir.TabIndex = 163
        Me.btSalir.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.txtClave)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.TextEmpresa)
        Me.Panel7.Controls.Add(Me.btGuardarInf)
        Me.Panel7.Controls.Add(Me.Label36)
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.txtCotizacion19)
        Me.Panel7.Controls.Add(Me.Label38)
        Me.Panel7.Location = New System.Drawing.Point(2, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(574, 75)
        Me.Panel7.TabIndex = 172
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(47, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 14)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Buscar por:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 14)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Clave Empresa:"
        '
        'btGuardarInf
        '
        Me.btGuardarInf.BackColor = System.Drawing.Color.SteelBlue
        Me.btGuardarInf.FlatAppearance.BorderSize = 0
        Me.btGuardarInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardarInf.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardarInf.ForeColor = System.Drawing.Color.White
        Me.btGuardarInf.Location = New System.Drawing.Point(1041, 10)
        Me.btGuardarInf.Name = "btGuardarInf"
        Me.btGuardarInf.Size = New System.Drawing.Size(151, 33)
        Me.btGuardarInf.TabIndex = 166
        Me.btGuardarInf.Text = "Guardar Cotización"
        Me.btGuardarInf.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Enabled = False
        Me.Label36.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(47, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(126, 18)
        Me.Label36.TabIndex = 165
        Me.Label36.Text = "Servicios en MetAs"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(119, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 14)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Nombre Empresa:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(672, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 15)
        Me.Label16.TabIndex = 170
        Me.Label16.Text = "Cotización 2019"
        '
        'txtCotizacion19
        '
        Me.txtCotizacion19.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCotizacion19.Location = New System.Drawing.Point(771, 18)
        Me.txtCotizacion19.Name = "txtCotizacion19"
        Me.txtCotizacion19.Size = New System.Drawing.Size(141, 21)
        Me.txtCotizacion19.TabIndex = 133
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label38.Location = New System.Drawing.Point(47, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 15)
        Me.Label38.TabIndex = 152
        Me.Label38.Text = "Folios"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Clave Consig"
        Me.Column2.Name = "Column2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Compañia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 269
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmFiltrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(587, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFiltrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Artículos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgEmpresas As DataGridView
    Friend WithEvents TextEmpresa As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btSalir As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btGuardarInf As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCotizacion19 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
