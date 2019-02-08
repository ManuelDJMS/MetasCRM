Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmCotizadorLIMS
    Dim bandera As Integer
    Private Sub FrmCotizadorLIMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralProspectos()

    End Sub

    Public Sub consultaGeneralProspectos()
        Try
            MetodoMetasCotizador()
            DGConsulta.Rows.Clear()
            Dim R As String
            R = "select * from Prospectos"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGConsulta.DataSource = dt
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub cbNombre_Click(sender As Object, e As EventArgs) Handles cbNombre.Click
        cbCorreo.Checked = False
        cbClave.Checked = False
        cbNombre.Checked = True
        ''---------------------------
        txtNombreB.Visible = True
        LabelNombre.Visible = True
        txtCorreoB.Visible = False
        LabelCorreo.Visible = False
        LabelClave.Visible = False
        txtClaveB.Visible = False
    End Sub

    Private Sub cbCorreo_Click(sender As Object, e As EventArgs) Handles cbCorreo.Click
        cbCorreo.Checked = True
        cbClave.Checked = False
        cbNombre.Checked = False
        ''---------------------------
        txtNombreB.Visible = False
        LabelNombre.Visible = False
        txtCorreoB.Visible = True
        LabelCorreo.Visible = True
        LabelClave.Visible = False
        txtClaveB.Visible = False
    End Sub

    Private Sub cbClave_Click(sender As Object, e As EventArgs) Handles cbClave.Click
        cbCorreo.Checked = False
        cbClave.Checked = True
        cbNombre.Checked = False
        ''---------------------------
        txtNombreB.Visible = False
        LabelNombre.Visible = False
        txtCorreoB.Visible = False
        LabelCorreo.Visible = False
        LabelClave.Visible = True
        txtClaveB.Visible = True
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Try
            'DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select * from Prospectos where Prospectos.Nombre LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtNombreB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtCorreoB.Text = ""
                txtClaveB.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("idProspecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtCorreoB_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoB.TextChanged
        Try
            'DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select * from Prospectos where Prospectos.Correo LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtCorreoB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreB.Text = ""
                txtClaveB.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("idProspecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtClaveB_TextChanged(sender As Object, e As EventArgs) Handles txtClaveB.TextChanged
        Try
            'DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select * from Prospectos where Prospectos.idProspecto LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtClaveB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreB.Text = ""
                txtCorreoB.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("idProspecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtClaveProspecto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtClaveProspecto.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                MetodoMetasCotizador()
                Dim R As String
                R = " select * from Prospectos where Prospectos.idProspecto=" & txtClaveProspecto.Text & ""
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                Dim lector As SqlDataReader
                lector = comando.ExecuteReader
                If lector.Read() Then
                    txtNombreProspecto.Text = lector(1)
                    txtApellidosProspecto.Text = lector(2)
                    txtTelefonoProspecto.Text = lector(3)
                    txtExtensionProspecto.Text = lector(4)
                    txtCelularProspecto.Text = lector(5)
                    txtCorreoProspecto.Text = lector(6)
                    txtPuestoProspecto.Text = lector(7)
                    txtHoras.Text = lector(8)
                    txtCompaniaProspecto.Text = lector(9)
                    txtDireccionProspecto.Text = lector(10)
                    txtNumExteriorProspecto.Text = lector(11)
                    txtCPProspecto.Text = lector(12)
                    txtColoniaProspecto.Text = lector(13)
                    cboPaisProspecto.Text = lector(14)
                    txtEstadoProspecto.Text = lector(15)
                    txtCiudadProspecto.Text = lector(16)
                    txtNotasProspecto.Text = lector(17)
                    lector.Close()
                    ''--------------------
                    conexionMetasCotizador.Close()
                    cbInformacion.Checked = True
                    GBInformacion.Enabled = False
                    bandera = 1
                Else
                    MsgBox("No existe el prospecto con la clave: " & txtClaveProspecto.Text, MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("Ocurrio un error en la lectura de datos, llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
                MsgBox("Descripciòn del error: " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub cbInformacion_CheckStateChanged(sender As Object, e As EventArgs) Handles cbInformacion.CheckStateChanged
        If bandera = 1 Then
            GBInformacion.Enabled = True
            bandera = 0
        ElseIf bandera = 0 Then
            GBInformacion.Enabled = False
            bandera = 1
        End If
    End Sub
End Class