Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmUsuariosCotizadores
    Private Sub FrmUsuariosCotizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasCotizador()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Sub logearUsuariosCotizaciones(ByVal Username As String, ByRef Contrasena As String)
        Try
            conexionMetasCotizador.Open()
            Dim Comando1 As New SqlCommand("select Username, TipoUsuario, Nombre from UsuariosCotizaciones where Username= @Username and Contrasena = @Pass", conexionMetasCotizador)
            Comando1.Parameters.AddWithValue("Username", Username)
            Comando1.Parameters.AddWithValue("Pass", Contrasena)
            MsgBox("Usuario: " & Username)
            MsgBox("Contrasena: " & Contrasena)
            Dim adapter1 As New SqlDataAdapter(Comando1)
            Dim datatable1 As New DataTable
            adapter1.Fill(datatable1)
            If (datatable1.Rows.Count = 1) Then
                Me.Hide()
                If (datatable1.Rows(0)(1).ToString = "UsuarioCotizaciones") Then
                    Dim Admin As New Cotizaciones
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
End Class