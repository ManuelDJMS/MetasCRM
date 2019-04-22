<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOportunidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOportunidades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboStatusFiltrado = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.labelPostal = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1111, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 161
        Me.PictureBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(-3, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1145, 66)
        Me.Panel2.TabIndex = 162
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(979, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 33)
        Me.Button2.TabIndex = 166
        Me.Button2.Text = "Actualizar registros"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(167, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Listado de Oportunidades"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(869, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 33)
        Me.Button1.TabIndex = 164
        Me.Button1.Text = "Nuevo"
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
        Me.Label27.Size = New System.Drawing.Size(89, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Oportunidades"
        '
        'cboStatusFiltrado
        '
        Me.cboStatusFiltrado.BackColor = System.Drawing.SystemColors.Menu
        Me.cboStatusFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFiltrado.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusFiltrado.FormattingEnabled = True
        Me.cboStatusFiltrado.Location = New System.Drawing.Point(927, 112)
        Me.cboStatusFiltrado.Name = "cboStatusFiltrado"
        Me.cboStatusFiltrado.Size = New System.Drawing.Size(200, 22)
        Me.cboStatusFiltrado.TabIndex = 157
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(874, 114)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(47, 14)
        Me.Label64.TabIndex = 155
        Me.Label64.Text = "Status:"
        '
        'txtNombreP
        '
        Me.txtNombreP.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreP.Location = New System.Drawing.Point(94, 112)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(158, 21)
        Me.txtNombreP.TabIndex = 126
        '
        'labelPostal
        '
        Me.labelPostal.AutoSize = True
        Me.labelPostal.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPostal.Location = New System.Drawing.Point(278, 115)
        Me.labelPostal.Name = "labelPostal"
        Me.labelPostal.Size = New System.Drawing.Size(111, 14)
        Me.labelPostal.TabIndex = 132
        Me.labelPostal.Text = "Orden de compra:"
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(395, 113)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(79, 21)
        Me.txtCP.TabIndex = 129
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.Location = New System.Drawing.Point(504, 115)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(116, 14)
        Me.LabelCorreo.TabIndex = 132
        Me.LabelCorreo.Text = "Fecha de creación:"
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
        Me.DGConsulta.Location = New System.Drawing.Point(3, 172)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.ReadOnly = True
        Me.DGConsulta.Size = New System.Drawing.Size(1131, 453)
        Me.DGConsulta.TabIndex = 163
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(8, 114)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(80, 14)
        Me.LabelNombre.TabIndex = 125
        Me.LabelNombre.Text = "Prospección:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(626, 113)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 20)
        Me.DateTimePicker1.TabIndex = 164
        '
        'FrmOportunidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 634)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cboStatusFiltrado)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.DGConsulta)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.txtNombreP)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.labelPostal)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtCP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.Name = "FrmOportunidades"
        Me.Text = "FrmOportunidades"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cboStatusFiltrado As ComboBox
    Friend WithEvents Label64 As Label
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents labelPostal As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents LabelNombre As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
