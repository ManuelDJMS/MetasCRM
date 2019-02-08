Imports System.Data.Sql
Imports System.Data.SqlClient
Module LIMS              ''--------------------------BASE DE DATOS LIMS--------------
    Public conexionLIMS As SqlConnection
    Public comandoLIMS As SqlCommand
    Public lectorLIMS As SqlDataReader
    Sub MetodoLIMS()
        Try
            conexionLIMS = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            conexionLIMS.Open()
            'MsgBox("Conectado correctamente")
            'MsgBox("Cambios en GitHub")
        Catch ex As Exception
            'MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub

    Sub verifiarnulos(ByVal valor As String, ByVal txt As TextBox)

        If (valor Is DBNull.Value) Or (valor Is Nothing) Or valor.Equals("") Or valor.Length < 0 Then
            txt.Text = "-"
        Else
            txt.Text = valor
        End If
    End Sub
End Module