﻿Imports System.Data.SqlClient
Public Class FrmHOME
    Private Sub FrmHOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        consultaTareas()
        alternarColorColumnas(DGTareas)

        consultaLlamadas()
        alternarColorColumnas(DGLlamadas)
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
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Label7.ForeColor = Color.Black
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
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
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.Black
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim Admin As New FrmCotizadorLIMS
        Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        Admin.Show()
        Panel1.BackColor = Color.DimGray
        Panel2.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Panel3.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        ' Panel5.BackColor = Color.SteelBlue
        Panel6.BackColor = Color.DimGray
        Panel7.BackColor = Color.Gainsboro
        Panel8.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Label15.ForeColor = Color.Black
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White
        ' MsgBox("Modulo en mantenimiento")


        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim Admin As New FrmCotizadorLIMS
        Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        Admin.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.Gainsboro
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.Black
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
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
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.Black
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub txtRol_Click(sender As Object, e As EventArgs) Handles txtRol.Click
        FrmNuevoContacto.Show()
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        FrmCotizadorLIMS.MdiParent = Me
        FrmCotizadorLIMS.Show()


        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.Gainsboro
        Panel16.BackColor = Color.DimGray
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.Black
        Label36.ForeColor = Color.White



        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click, Label39.Click
        FrmFoliosDelAnioAnterior.MdiParent = Me
        FrmFoliosDelAnioAnterior.Show()
        ' Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text ''------------

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel5.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.DimGray
        Panel15.BackColor = Color.Gainsboro
        Panel6.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Panel8.BackColor = Color.DimGray
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White
        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
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
        Try
            DGOportunidades.Rows.Clear()
            MetodoMetasCotizador()
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
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub consultaTareas()

        Try
            DGTareas.Rows.Clear()
            conexionMetasCotizador.Open()
            DGTareas.Columns(0).Visible = False
            Dim R As String
            R = " select ActividadTareaProspectos.idActividadTareaProspectos, ActividadTareaProspectos.Asunto, Prospectos.Nombre, Prospectos.Apellidos, Prospectos.Compania, Prospectos.Telefono from ActividadTareaProspectos 
                inner join Prospectos on ActividadTareaProspectos.idProspecto = Prospectos.idProspecto order by ActividadTareaProspectos.idActividadTareaProspectos"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader

            'ProgressBar1.Visible = True


            While lector.Read()
                ' ProgressBar1.Value = ProgressBar1.Value + 1
                DGTareas.Rows.Add(lector(0), lector(1), (lector(2) & " " & lector(3)), lector(4), lector(5))
            End While
            lector.Close()
            For Each fila As DataGridViewRow In DGOportunidades.Rows
                fila.Cells("Monto").Style.BackColor = Color.DarkSeaGreen
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub consultaLlamadas()
        Try
            DGLlamadas.Rows.Clear()
            conexionMetasCotizador.Open()
            DGTareas.Columns(0).Visible = False
            Dim R As String
            R = "select ActividadLlamadaProspectos.idActividadLlamadaProspectos, ActividadLlamadaProspectos.Asunto, concat(Prospectos.Nombre, ' ', Prospectos.Apellidos) as Titular, Prospectos.Compania, Prospectos.Telefono,
            ActividadLlamadaProspectos.Comentarios, ActividadLlamadaProspectos.FechaEstimadaDeLlamada from ActividadLlamadaProspectos inner join Prospectos on ActividadLlamadaProspectos.idProspecto = Prospectos.idProspecto"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGLlamadas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
            lector.Close()
            For Each fila As DataGridViewRow In DGOportunidades.Rows
                fila.Cells("Monto").Style.BackColor = Color.DarkSeaGreen
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos.", MsgBoxStyle.Critical)
        End Try
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexionMetasCotizador.Open()
        Dim R, a, b As String
        Dim id As Integer = 4234
        a = "Tareas rapidas"
        b = "Asignado a tarea" And
        R = "insert into ActividadTareaProspectos (Asunto, FechaDeVencimiento, AsignadoA, idProspecto, RelacionadoCon) values ('" & TextBox1.Text & "','" & DTPFechaTarea.Value.ToShortDateString & "','" & b & "'," & id & ",'" & a & "')"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.ExecuteNonQuery()
        MsgBox("Guardado correctamente", MsgBoxStyle.Information)
        conexionMetasCotizador.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        consultaTareas()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        consultaLlamadas()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        consultaProspecciones()
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        FrmAutorizarSolicitudes.MdiParent = Me
        FrmAutorizarSolicitudes.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.Gainsboro
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.White

        Label36.ForeColor = Color.Black

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        FrmTiemposCondicion.MdiParent = Me
        FrmTiemposCondicion.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Panel17.BackColor = Color.Gainsboro
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White
        Label37.ForeColor = Color.Black

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        FrmSeguimientoCot.MdiParent = Me
        FrmSeguimientoCot.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.DimGray
        Panel16.BackColor = Color.DimGray
        Panel17.BackColor = Color.Gainsboro
        Label7.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label17.ForeColor = Color.White
        Label30.ForeColor = Color.White
        Label36.ForeColor = Color.White
        Label37.ForeColor = Color.Black

        ''-----------Poner invisibles----------
        GroupBox5.Visible = False
        Panel12.Visible = False
        DGTareas.Visible = False
        GroupBox6.Visible = False
        PanelRecordatorioSemana.Visible = False
        GroupBox4.Visible = False
        ''--------------------------------------
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        ConfirmacionDeDatos.Show()
    End Sub
End Class