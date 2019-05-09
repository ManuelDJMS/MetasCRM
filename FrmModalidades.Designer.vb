<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModalidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModalidades))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.txtModalidad = New System.Windows.Forms.TextBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.e = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.df = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalInterval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalCycle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsAc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InSiute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Modalidades de servicio"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(269, 162)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(93, 32)
        Me.btGuardar.TabIndex = 59
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(18, 78)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(93, 32)
        Me.btNuevo.TabIndex = 58
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'txtModalidad
        '
        Me.txtModalidad.Location = New System.Drawing.Point(120, 136)
        Me.txtModalidad.Name = "txtModalidad"
        Me.txtModalidad.Size = New System.Drawing.Size(242, 20)
        Me.txtModalidad.TabIndex = 57
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Nombre})
        Me.DG.Location = New System.Drawing.Point(422, 78)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(415, 157)
        Me.DG.TabIndex = 56
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.Width = 90
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Descripción"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 280
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 65)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(526, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Fecha: "
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(580, 23)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(258, 20)
        Me.DTP.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(128, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Modalidades de condición"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(49, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.e, Me.equipid, Me.d, Me.df, Me.Dep, Me.lo, Me.CalInterval, Me.CalCycle, Me.IsAc, Me.InSiute, Me.Shor, Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 345)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1370, 157)
        Me.DataGridView1.TabIndex = 61
        '
        'e
        '
        Me.e.HeaderText = "Customerid"
        Me.e.Name = "e"
        '
        'equipid
        '
        Me.equipid.HeaderText = "equipid"
        Me.equipid.Name = "equipid"
        '
        'd
        '
        Me.d.HeaderText = "Instrumentid"
        Me.d.Name = "d"
        '
        'df
        '
        Me.df.HeaderText = "SrlNo"
        Me.df.Name = "df"
        '
        'Dep
        '
        Me.Dep.HeaderText = "Dept"
        Me.Dep.Name = "Dep"
        '
        'lo
        '
        Me.lo.HeaderText = "locatioon"
        Me.lo.Name = "lo"
        '
        'CalInterval
        '
        Me.CalInterval.HeaderText = "CalInterval"
        Me.CalInterval.Name = "CalInterval"
        '
        'CalCycle
        '
        Me.CalCycle.HeaderText = "Calcycle"
        Me.CalCycle.Name = "CalCycle"
        '
        'IsAc
        '
        Me.IsAc.HeaderText = "isActive"
        Me.IsAc.Name = "IsAc"
        '
        'InSiute
        '
        Me.InSiute.HeaderText = "OnSite"
        Me.InSiute.Name = "InSiute"
        '
        'Shor
        '
        Me.Shor.HeaderText = "Notas"
        Me.Shor.Name = "Shor"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(804, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 32)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Exporta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(556, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 32)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Exporta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(-1, 541)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1370, 189)
        Me.DataGridView2.TabIndex = 61
        '
        'FrmModalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1499, 742)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.txtModalidad)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmModalidades"
        Me.Text = "Modalidades"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btGuardar As Button
    Friend WithEvents btNuevo As Button
    Friend WithEvents txtModalidad As TextBox
    Friend WithEvents DG As DataGridView
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents e As DataGridViewTextBoxColumn
    Friend WithEvents equipid As DataGridViewTextBoxColumn
    Friend WithEvents d As DataGridViewTextBoxColumn
    Friend WithEvents df As DataGridViewTextBoxColumn
    Friend WithEvents Dep As DataGridViewTextBoxColumn
    Friend WithEvents lo As DataGridViewTextBoxColumn
    Friend WithEvents CalInterval As DataGridViewTextBoxColumn
    Friend WithEvents CalCycle As DataGridViewTextBoxColumn
    Friend WithEvents IsAc As DataGridViewTextBoxColumn
    Friend WithEvents InSiute As DataGridViewTextBoxColumn
    Friend WithEvents Shor As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
