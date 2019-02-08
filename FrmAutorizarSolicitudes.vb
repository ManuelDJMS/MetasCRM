Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        'consultaGeneral()
        'DG.Rows.Clear()
        'Dim X As String
        ''X = "select RelacionContactosEmpresas.NoFila, Contactos.Nombre, Empresas.Compania, RelacionContactosEmpresas.FechaAsignacion from RelacionContactosEmpresas inner join Contactos on Contactos.ClaveContacto = RelacionContactosEmpresas.idContacto inner join Empresas on Empresas.Clavempresa= RelacionContactosEmpresas.idEmpresa where RelacionContactosEmpresas.Confirma=0"
        'X = "select RelacionContactosEmpresas.NoFila, Contactos.Nombre, Contactos.Apellidos, Contactos.Email, 
        '    Empresas.Compania, Empresas.RazonSocial, Empresas.DomicilioConsig, Empresas.RFC, Empresas.Ciudad,
        '    RelacionContactosEmpresas.FechaAsignacion from RelacionContactosEmpresas 
        '    inner join Contactos on Contactos.ClaveContacto = RelacionContactosEmpresas.idContacto 
        '    inner join Empresas on Empresas.Clavempresa= RelacionContactosEmpresas.idEmpresa 
        '    where RelacionContactosEmpresas.Confirma=0"

        'Dim com As New SqlCommand(X, conexion)
        'Dim lect As SqlDataReader
        'lect = com.ExecuteReader()
        'While (lect.Read())
        '    DG.Rows.Add(lect(0), lect(1), lect(2), lect(3), lect(4), lect(5), lect(6), lect(7), lect(8), lect(9))
        'End While
        'lect.Close()
    End Sub

    Private Sub btAutorizar_Click(sender As Object, e As EventArgs) Handles btAutorizar.Click
        ActualizarAutorizacion()
        'consultaGeneral()
    End Sub
    Public Sub ActualizarAutorizacion()
        Dim R As String
        R = "update RelacionContactosEmpresas set Confirma = 1 where NoFila= " & txtClave.Text
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.ExecuteNonQuery()
        MsgBox("Autorizado correctamente", MsgBoxStyle.Information)
    End Sub
    Public Sub consultaGeneral()
        DG.Rows.Clear()
        Dim X As String
        X = "select RelacionContactosEmpresas.NoFila, Contactos.Nombre, Contactos.Apellidos, Contactos.Email, 
            Empresas.Compania, Empresas.RazonSocial, Empresas.DomicilioConsig, Empresas.RFC, Empresas.Ciudad,
            RelacionContactosEmpresas.FechaAsignacion from RelacionContactosEmpresas 
            inner join Contactos on Contactos.ClaveContacto = RelacionContactosEmpresas.idContacto 
            inner join Empresas on Empresas.Clavempresa= RelacionContactosEmpresas.idEmpresa 
            where RelacionContactosEmpresas.Confirma=0"
        Dim com As New SqlCommand(X, conexionMetasCotizador)
        Dim lect As SqlDataReader
        lect = com.ExecuteReader()
        While (lect.Read())
            DG.Rows.Add(lect(0), lect(1), lect(2), lect(3), lect(4), lect(5), lect(6), lect(7), lect(8), lect(9))
        End While
        lect.Close()

        For Each fila As DataGridViewRow In DG.Rows
            fila.Cells("Contacto").Style.BackColor = Color.AntiqueWhite
            fila.Cells("Apellidos").Style.BackColor = Color.AntiqueWhite
            fila.Cells("Email").Style.BackColor = Color.AntiqueWhite

            fila.Cells("Empresa").Style.BackColor = Color.LightCyan
            fila.Cells("Razon").Style.BackColor = Color.LightCyan
            fila.Cells("Dom").Style.BackColor = Color.LightCyan
            fila.Cells("RFC").Style.BackColor = Color.LightCyan
            fila.Cells("Ciudad").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        txtClave.Text = DG.CurrentCell.Value.ToString()
    End Sub
End Class