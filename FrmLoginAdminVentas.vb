Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmLoginAdminVentas
    Private Sub FrmLoginAdminVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasCotizador()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'MsgBox("Ah ocurrido un error, ponte en contacto con el Administrador General de Sistemas")

    End Sub

    Sub logearUsuariosAdministradores(ByVal Username As String, ByRef Contrasena As String)
        Try
            conexionMetasCotizador.Open()
            Dim Comando1 As New SqlCommand("select Username, TipoUsuario, Nombre from UsuariosAdministradoresSistemas where Username= @Username and Contrasena = @Pass", conexionMetasCotizador)
            Comando1.Parameters.AddWithValue("Username", Username)
            Comando1.Parameters.AddWithValue("Pass", Contrasena)
            MsgBox("Usuario: " & Username)
            MsgBox("Contrasena: " & Contrasena)
            Dim adapter1 As New SqlDataAdapter(Comando1)
            Dim datatable1 As New DataTable
            adapter1.Fill(datatable1)
            If (datatable1.Rows.Count = 1) Then
                Me.Hide()
                If (datatable1.Rows(0)(1).ToString = "UsuarioAdministrador") Then
                    Dim Admin As New FrmReportesGenerales
                    Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
                    Admin.ShowDialog()

                Else
                    MessageBox.Show("Usuario y/o Contraseña son Incorrectos")
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            conexionMetasCotizador.Close()
        End Try
    End Sub

    Private Sub RelacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionesToolStripMenuItem.Click
        FrmRelacionesContactoEmpresas.ShowDialog()
    End Sub
End Class