Imports System.Data.SqlClient
Public Class FrmHOME
    Private Sub FrmHOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasCotizador()
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel1, "Consulta y asigna datos dentro de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel2, "Agrega Clientes/Empresas para datos de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel3, "Relaciona los contactos con las empresas existentes, Tu tienes el control ;)")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel3, "Registra posibles contactos para cotizaciones sin registro de cliente")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel4, "Agrega, consulta y aprueba prospectos para cotizaciónes con MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel5, "Genera cotizaciones para los prospectos de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel6, "Registra y consulta los catálogos de calibraciones existentes dentro de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel7, "Genera cotizaciones para los clientes de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel8, "Los equipos tambien tienen expediente")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel9, "Realiza y envia cotizaciones preformadas")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel4, "Busca cotizaciones 2018 y exportalas a 2019 como nueva cotización")

        Label3.Text = "Fecha:    " & DTP.Value.ToShortDateString

        consultaProspecciones()
        alternarColorColumnas(DGOportunidades)

    End Sub
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim Admin As New FrmContactos
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        Admin.Show()
        'MsgBox("Modulo en mantenimiento")

        Panel1.BackColor = Color.Gainsboro
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray

        Label7.ForeColor = Color.Black
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White

        ''-----------Poner invisibles----------

        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        'Dim Admin As New FrmEmpresas
        'Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        'Admin.Show()
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.SteelBlue
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Panel15.BackColor = Color.DimGray
        'Label19.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        'FrmRelacionesContactoEmpresas.MdiParent = Me
        'FrmRelacionesContactoEmpresas.Show()
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.Gainsboro
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label11.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Admin As New FrmProspectos
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        Admin.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.Gainsboro
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray

        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.Black
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim Admin As New FrmCotizadorLIMS
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        Admin.Show()
        Panel1.BackColor = Color.DimGray
        Panel2.BackColor = Color.DimGray
        Panel3.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        ' Panel5.BackColor = Color.SteelBlue
        Panel6.BackColor = Color.DimGray
        Panel7.BackColor = Color.Gainsboro
        Panel8.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Label15.ForeColor = Color.Black
        ' MsgBox("Modulo en mantenimiento")


        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim Admin As New FrmCotizadorLIMS
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        Admin.Show()
        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.Gainsboro

        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.Black
        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.SteelBlue
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label19.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.SteelBlue
        'Panel9.BackColor = Color.DimGray
        'Label21.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Admin As New FrmCotizacionInformal
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text ''------------------
        Admin.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.Gainsboro
        Panel7.BackColor = Color.DimGray

        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.Black
        Label17.ForeColor = Color.White

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub txtRol_Click(sender As Object, e As EventArgs) Handles txtRol.Click
        FrmNuevoContacto.Show()
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        FrmCotizacion2018.MdiParent = Me
        FrmCotizacion2018.Show()
        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel5.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.SteelBlue
        Panel15.BackColor = Color.DimGray
        Panel6.BackColor = Color.DimGray
        Panel8.BackColor = Color.DimGray

        ''-----------Poner invisibles----------
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click
        FrmFoliosDelAnioAnterior.MdiParent = Me
        FrmFoliosDelAnioAnterior.Show()
        ' Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text ''------------

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel5.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.DimGray
        Panel15.BackColor = Color.SteelBlue
        Panel6.BackColor = Color.DimGray
        Panel8.BackColor = Color.DimGray
        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        PanelRecordatorioSemana.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    ''Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
    ''    PictureBox5.Size = New Size(300, 300)
    ''End Sub

    ''Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
    ''    PictureBox5.Size = New Size(293, 293)
    ''End Sub

    ''Private Sub PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
    ''    PictureBox6.Size = New Size(300, 300)
    ''End Sub

    ''Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
    ''    PictureBox6.Size = New Size(293, 293)
    ''End Sub

    ''Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    ''End Sub

    Public Sub consultaProspecciones()

        'Try
        'conexionMetasCotizador.Open()
        Dim R As String
        R = "select Oportunidades.idOportunidad, Prospeccion.idProspeccion, Prospectos.Nombre, Prospectos.Apellidos, Prospectos.Correo, Prospectos.Compania, Prospeccion.Monto 
                from Oportunidades inner join Prospeccion on Oportunidades.idProspeccion= Prospeccion.idProspeccion inner join Prospectos on Prospectos.idProspecto= Prospeccion.idProspecto order by Prospeccion.Monto desc"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read()
            DGOportunidades.Rows.Add(lector(0), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()
        For Each fila As DataGridViewRow In DGOportunidades.Rows
            fila.Cells("Monto").Style.BackColor = Color.DarkSeaGreen
        Next
        conexionMetasCotizador.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos.", MsgBoxStyle.Critical)
        'End Try
    End Sub
    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmModalidades.Show()
    End Sub
End Class