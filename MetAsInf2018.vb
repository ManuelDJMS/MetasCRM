Imports System.Data.SqlClient
Module MetAsInf2018

    Public conexion2018 As SqlConnection              ''Base de datos METASINF-2019
    Public comando2018 As SqlCommand
    Public lector2018 As SqlDataReader
    Public empresa As Integer
    Public clave As String
    'Public conexionprueba As String = "Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019-2; User Id=sa; Password=Met99011578a;Integrated Security=False"
    Sub MetodoMetasInf2018()
        Try
            'conexion = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            conexion2018 = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2018; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2018.Open()
            'MsgBox("Conectado correctamente 2018")
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try

    End Sub
End Module
