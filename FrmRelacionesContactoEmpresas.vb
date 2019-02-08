Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmRelacionesContactoEmpresas
    Dim fecha As String
    Private Sub FrmRelacionesContactoEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConexionGlobal()
        'consultaRelaciones()
        'consultaEmpresas()
        'consultaContactos()

        'DG2.Rows.Clear()
        'Dim X As String
        'X = "select idContacto, idEmpresa from RelacionContactosEmpresas"
        'Dim com As New SqlCommand(X, conexion)
        'Dim lect As SqlDataReader
        'lect = com.ExecuteReader()
        'While (lect.Read())
        '    DG2.Rows.Add(lect(0), lect(1))
        'End While
        'lect.Close()


    End Sub

    Public Sub consultaRelaciones()
        ' DG3.Rows.Clear()
        Dim R As String
        R = "select RelacionContactosEmpresas.NoFila as NoRelación, Contactos.ClaveContacto, Contactos.Nombre,
            Empresas.Clavempresa, Empresas.Compania, Empresas.RFC
            from RelacionContactosEmpresas 
            inner join Contactos on Contactos.ClaveContacto = RelacionContactosEmpresas.idContacto 
            inner join Empresas on Empresas.Clavempresa= RelacionContactosEmpresas.idEmpresa 
            where RelacionContactosEmpresas.Confirma=1 order by NoRelación"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        DG3.DataSource = dt


        For Each fila As DataGridViewRow In DG3.Rows
            fila.Cells("ClaveContacto").Style.BackColor = Color.AntiqueWhite
            fila.Cells("Nombre").Style.BackColor = Color.AntiqueWhite

            fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
            fila.Cells("Compania").Style.BackColor = Color.LightCyan
            fila.Cells("RFC").Style.BackColor = Color.LightCyan

        Next
    End Sub
    Public Sub consultaContactos()
        DGContactos.Rows.Clear()
        Dim R As String
        R = "select * from Contactos"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        DGContactos.DataSource = dt

        For Each fila As DataGridViewRow In DGContactos.Rows
            fila.Cells("ClaveContacto").Style.BackColor = Color.AntiqueWhite

            'fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub
    Public Sub consultaEmpresas()
        DG.Rows.Clear()
        Dim R As String
        R = "select Clavempresa, Compania, DomicilioConsig, RFC, Ciudad, EdoConsig, CPConsig from Empresas"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        DG.DataSource = dt
        For Each fila As DataGridViewRow In DG.Rows
            fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub
   
    Private Sub txtNombreEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtNombreEmpresa.TextChanged
        Dim R As String
        R = "select Clavempresa, Compania, DomicilioConsig, RFC, Ciudad, EdoConsig, CPConsig from Empresas where Empresas.Compania LIKE '%' + @NombreEmpresa + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreEmpresa", txtNombreEmpresa.Text)

        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable

        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            DG.DataSource = Nothing
        Else
            DG.DataSource = dt
            'txtClaveEmpresa.Enabled = True

        End If
        For Each fila As DataGridViewRow In DG.Rows
            fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btGuardarRelacion.Click
        recorridoRelacionRepetida()
    End Sub

    Public Sub recorridoRelacionRepetida()
        Dim idContacto, idEmpresa, bandera As String
        Dim R As String
        Dim b, confirma As Integer
        '
        b = 1
        confirma = 0
        bandera = 0

        For i = 0 To DG2.Rows.Count - 2
            idContacto = Val(DG2.Item(0, i).Value)
            idEmpresa = Val(DG2.Item(1, i).Value)
            If ((txtClaveContacto.Text = Val(DG2.Item(0, i).Value)) And (txtClaveEmpresa.Text = Val(DG2.Item(1, i).Value))) Then
                MsgBox("Ya existe una relación con este contacto, verifica nuevamente", MsgBoxStyle.Critical)
                bandera = 1
                Exit For
            End If
        Next
        If bandera = 0 Then
            R = "insert into RelacionContactosEmpresas (idContacto, idEmpresa, FechaAsignacion, Confirma) values (" & txtClaveContacto.Text & "," & txtClaveEmpresa.Text & ",'" & fecha & "'," & confirma & ")"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.ExecuteNonQuery()
            MsgBox("Relación guardada correctamente", MsgBoxStyle.OkOnly)
            consultaRelaciones()
            Me.Dispose()
        End If
    End Sub



    Private Sub cbCorreo_Click(sender As Object, e As EventArgs) Handles cbCorreo.Click
        cbCorreo.Checked = True
        cbNombre.Checked = False
        cbClave.Checked = False
        cbTelefono.Checked = False

        LabelNombre.Visible = False
        LabelCorreo.Visible = True
        LabelClave.Visible = False
        LabelTel.Visible = False

        txtNombreB.Visible = False
        txtCorreoB.Visible = True
        txtClaveB.Visible = False
        txtTelefonoB.Visible = False

    End Sub

    Private Sub cbTelefono_Click(sender As Object, e As EventArgs) Handles cbTelefono.Click
        cbTelefono.Checked = True
        cbNombre.Checked = False
        cbCorreo.Checked = False
        cbClave.Checked = False

        LabelNombre.Visible = False
        LabelCorreo.Visible = False
        LabelClave.Visible = False
        LabelTel.Visible = True

        txtNombreB.Visible = False
        txtCorreoB.Visible = False
        txtClaveB.Visible = False
        txtTelefonoB.Visible = True
    End Sub

    Private Sub cbClave_Click(sender As Object, e As EventArgs) Handles cbClave.Click
        cbClave.Checked = True
        cbNombre.Checked = False
        cbCorreo.Checked = False
        cbTelefono.Checked = False

        LabelNombre.Visible = False
        LabelCorreo.Visible = False
        LabelClave.Visible = True
        LabelTel.Visible = False

        txtNombreB.Visible = False
        txtCorreoB.Visible = False
        txtClaveB.Visible = True
        txtTelefonoB.Visible = False
    End Sub

    Private Sub cbNombre_Click(sender As Object, e As EventArgs) Handles cbNombre.Click
        cbNombre.Checked = True
        cbTelefono.Checked = False
        cbCorreo.Checked = False
        cbClave.Checked = False

        LabelNombre.Visible = True
        LabelCorreo.Visible = False
        LabelClave.Visible = False
        LabelTel.Visible = False

        txtNombreB.Visible = True
        txtCorreoB.Visible = False
        txtClaveB.Visible = False
        txtTelefonoB.Visible = False
    End Sub

    Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Dim R As String
        txtNombreEmpresa.Enabled = True
        R = "select * from Contactos where Contactos.Nombre LIKE '%' + @NombreInstrumento + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreInstrumento", txtNombreB.Text)
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            DGContactos.DataSource = Nothing
        Else
            DGContactos.DataSource = dt
            txtCorreoB.Text = ""
            txtClaveB.Text = ""
            txtTelefonoB.Text = ""
        End If
        For Each fila As DataGridViewRow In DGContactos.Rows
            fila.Cells("ClaveContacto").Style.BackColor = Color.AntiqueWhite

            'fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub txtCorreoB_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoB.TextChanged
        Dim R As String
        txtNombreEmpresa.Enabled = True
        R = "select * from Contactos where Contactos.Email LIKE '%' + @NombreInstrumento + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreInstrumento", txtCorreoB.Text)
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            DGContactos.DataSource = Nothing
        Else
            DGContactos.DataSource = dt
            txtNombreB.Text = ""
            txtClaveB.Text = ""
            txtTelefonoB.Text = ""
        End If
        For Each fila As DataGridViewRow In DGContactos.Rows
            fila.Cells("ClaveContacto").Style.BackColor = Color.AntiqueWhite

            'fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub txtClaveB_TextChanged(sender As Object, e As EventArgs) Handles txtClaveB.TextChanged
        Dim R As String
        txtNombreEmpresa.Enabled = True
        R = "select * from Contactos where Contactos.ClaveContacto LIKE '%' + @NombreInstrumento + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreInstrumento", txtClaveB.Text)
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            DGContactos.DataSource = Nothing
        Else
            DGContactos.DataSource = dt
            txtNombreB.Text = ""
            txtCorreoB.Text = ""
            txtTelefonoB.Text = ""
        End If
        For Each fila As DataGridViewRow In DGContactos.Rows
            fila.Cells("ClaveContacto").Style.BackColor = Color.AntiqueWhite

            'fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub txtTelefonoB_TextChanged(sender As Object, e As EventArgs) Handles txtTelefonoB.TextChanged
        Dim R As String
        txtNombreEmpresa.Enabled = True
        R = "select * from Contactos where Contactos.Tel LIKE '%' + @NombreInstrumento + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreInstrumento", txtTelefonoB.Text)
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            DGContactos.DataSource = Nothing
        Else
            DGContactos.DataSource = dt
            txtNombreB.Text = ""
            txtCorreoB.Text = ""
            txtClaveB.Text = ""
        End If
        For Each fila As DataGridViewRow In DGContactos.Rows
            fila.Cells("ClaveContacto").Style.BackColor = Color.AntiqueWhite

            'fila.Cells("Clavempresa").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub DGContactos_DoubleClick(sender As Object, e As EventArgs) Handles DGContactos.DoubleClick
        Try
            If Convert.ToInt32(DGContactos.CurrentCell.Value) = True Then
                MsgBox("Selecciona solo la CLAVE")
            Else
                txtClaveContacto.Text = DGContactos.CurrentCell.Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Selecciona solo la CLAVE del Contacto", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DG_DoubleClick(sender As Object, e As EventArgs) Handles DG.DoubleClick
        Try
            If Convert.ToInt32(DG.CurrentCell.Value) = True Then
                MsgBox("Selecciona solo la CLAVEaaaa")
            Else
                txtClaveEmpresa.Text = DG.CurrentCell.Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Selecciona solo la CLAVE del Cliente/Empresa", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub
End Class
