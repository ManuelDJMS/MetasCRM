﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCotizacion2018
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacion2018))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btCerrar = New System.Windows.Forms.PictureBox()
        Me.Tab2018 = New System.Windows.Forms.TabPage()
        Me.PanelFiltrado = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.lblCot = New System.Windows.Forms.Label()
        Me.DGCotizaciones = New System.Windows.Forms.DataGridView()
        Me.DGEmpresas = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btCotizacion = New System.Windows.Forms.Button()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab2018.SuspendLayout()
        Me.PanelFiltrado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Cursor = System.Windows.Forms.Cursors.No
        Me.Label49.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1029, 10)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 14)
        Me.Label49.TabIndex = 142
        Me.Label49.Text = "Cerrar formulario"
        '
        'btCerrar
        '
        Me.btCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCerrar.Image = CType(resources.GetObject("btCerrar.Image"), System.Drawing.Image)
        Me.btCerrar.Location = New System.Drawing.Point(1121, 0)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btCerrar.TabIndex = 141
        Me.btCerrar.TabStop = False
        '
        'Tab2018
        '
        Me.Tab2018.BackColor = System.Drawing.Color.Gainsboro
        Me.Tab2018.Controls.Add(Me.PanelFiltrado)
        Me.Tab2018.Controls.Add(Me.Panel1)
        Me.Tab2018.Controls.Add(Me.lblCot)
        Me.Tab2018.Controls.Add(Me.DGCotizaciones)
        Me.Tab2018.Controls.Add(Me.DGEmpresas)
        Me.Tab2018.Controls.Add(Me.Panel2)
        Me.Tab2018.Location = New System.Drawing.Point(4, 24)
        Me.Tab2018.Name = "Tab2018"
        Me.Tab2018.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2018.Size = New System.Drawing.Size(1140, 625)
        Me.Tab2018.TabIndex = 5
        Me.Tab2018.Text = "Búsqueda Cotizaciones 2018"
        '
        'PanelFiltrado
        '
        Me.PanelFiltrado.BackColor = System.Drawing.Color.LightGray
        Me.PanelFiltrado.Controls.Add(Me.btCotizacion)
        Me.PanelFiltrado.Controls.Add(Me.Label3)
        Me.PanelFiltrado.Controls.Add(Me.txtMarca)
        Me.PanelFiltrado.Controls.Add(Me.Label1)
        Me.PanelFiltrado.Controls.Add(Me.lblMarca)
        Me.PanelFiltrado.Controls.Add(Me.TextID)
        Me.PanelFiltrado.Controls.Add(Me.lblModelo)
        Me.PanelFiltrado.Controls.Add(Me.txtModelo)
        Me.PanelFiltrado.Location = New System.Drawing.Point(14, 340)
        Me.PanelFiltrado.Name = "PanelFiltrado"
        Me.PanelFiltrado.Size = New System.Drawing.Size(1090, 44)
        Me.PanelFiltrado.TabIndex = 172
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Filtrar por:"
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(382, 14)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(139, 21)
        Me.txtMarca.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Número de Equipo:"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(334, 13)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(44, 15)
        Me.lblMarca.TabIndex = 132
        Me.lblMarca.Text = "Marca:"
        '
        'TextID
        '
        Me.TextID.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(212, 13)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(112, 21)
        Me.TextID.TabIndex = 165
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(524, 14)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 15)
        Me.lblModelo.TabIndex = 153
        Me.lblModelo.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(583, 14)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(140, 21)
        Me.txtModelo.TabIndex = 152
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.TextCorreo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LabelNombre)
        Me.Panel1.Controls.Add(Me.txtClave)
        Me.Panel1.Controls.Add(Me.txtNombreE)
        Me.Panel1.Location = New System.Drawing.Point(14, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 35)
        Me.Panel1.TabIndex = 171
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label42.Location = New System.Drawing.Point(6, 6)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(58, 19)
        Me.Label42.TabIndex = 152
        Me.Label42.Text = "Buscar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Customer ID:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(236, 7)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(65, 18)
        Me.LabelNombre.TabIndex = 125
        Me.LabelNombre.Text = "Empresa:"
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(158, 6)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(72, 21)
        Me.txtClave.TabIndex = 161
        '
        'txtNombreE
        '
        Me.txtNombreE.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreE.Location = New System.Drawing.Point(307, 6)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(203, 21)
        Me.txtNombreE.TabIndex = 126
        '
        'lblCot
        '
        Me.lblCot.AutoSize = True
        Me.lblCot.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCot.Location = New System.Drawing.Point(13, 317)
        Me.lblCot.Name = "lblCot"
        Me.lblCot.Size = New System.Drawing.Size(159, 18)
        Me.lblCot.TabIndex = 156
        Me.lblCot.Text = "Artículos De La Empresa:"
        '
        'DGCotizaciones
        '
        Me.DGCotizaciones.AllowUserToDeleteRows = False
        Me.DGCotizaciones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCotizaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCotizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DGCotizaciones.Location = New System.Drawing.Point(14, 390)
        Me.DGCotizaciones.Name = "DGCotizaciones"
        Me.DGCotizaciones.ReadOnly = True
        Me.DGCotizaciones.Size = New System.Drawing.Size(1099, 229)
        Me.DGCotizaciones.TabIndex = 155
        '
        'DGEmpresas
        '
        Me.DGEmpresas.AllowUserToDeleteRows = False
        Me.DGEmpresas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column10, Me.Column11})
        Me.DGEmpresas.Location = New System.Drawing.Point(14, 97)
        Me.DGEmpresas.Name = "DGEmpresas"
        Me.DGEmpresas.ReadOnly = True
        Me.DGEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEmpresas.Size = New System.Drawing.Size(1099, 217)
        Me.DGEmpresas.TabIndex = 154
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 52)
        Me.Panel2.TabIndex = 151
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(213, 18)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Exportar Cotizaciones 2018 a 2019"
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
        Me.Label27.Size = New System.Drawing.Size(144, 15)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Cotizaciones MetAs 2018"
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Controls.Add(Me.Tab2018)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(4, 13)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 653)
        Me.TabConsulta.TabIndex = 43
        '
        'Column1
        '
        Me.Column1.HeaderText = "CustomerID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Contacto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellidos"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nombre Empresa"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(516, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Correo:"
        '
        'TextCorreo
        '
        Me.TextCorreo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCorreo.Location = New System.Drawing.Point(570, 5)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(203, 21)
        Me.TextCorreo.TabIndex = 163
        '
        'Column5
        '
        Me.Column5.HeaderText = "Número de Equipo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Nombre de Equipo"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 500
        '
        'Column7
        '
        Me.Column7.HeaderText = "Marca"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 200
        '
        'Column8
        '
        Me.Column8.HeaderText = "Modelo"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 200
        '
        'btCotizacion
        '
        Me.btCotizacion.BackColor = System.Drawing.Color.SteelBlue
        Me.btCotizacion.FlatAppearance.BorderSize = 0
        Me.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCotizacion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCotizacion.ForeColor = System.Drawing.Color.White
        Me.btCotizacion.Location = New System.Drawing.Point(823, 6)
        Me.btCotizacion.Name = "btCotizacion"
        Me.btCotizacion.Size = New System.Drawing.Size(151, 33)
        Me.btCotizacion.TabIndex = 173
        Me.btCotizacion.Text = "Realizar Cotización"
        Me.btCotizacion.UseVisualStyleBackColor = False
        '
        'FrmCotizacion2018
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.Name = "FrmCotizacion2018"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCotizacion2018"
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab2018.ResumeLayout(False)
        Me.Tab2018.PerformLayout()
        Me.PanelFiltrado.ResumeLayout(False)
        Me.PanelFiltrado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsulta.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label49 As Label
    Friend WithEvents btCerrar As PictureBox
    Friend WithEvents Tab2018 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCot As Label
    Friend WithEvents DGCotizaciones As DataGridView
    Friend WithEvents DGEmpresas As DataGridView
    Friend WithEvents lblModelo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents PanelFiltrado As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btCotizacion As Button
End Class
