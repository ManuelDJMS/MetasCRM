Imports System.Data.SqlClient
Module InformacionGeneral
    Public conexionInformacionGeneral As SqlConnection
    Public comandoInformacionGeneral As SqlCommand
    Public lectorInformacionGeneral As SqlDataReader
    'Public conexionprueba As String = "Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019-2; User Id=sa; Password=Met99011578a;Integrated Security=False"
    Sub MetodoInformacionGeneral()
        Try
            'conexion = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            conexionInformacionGeneral = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=InformacionGeneral; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionInformacionGeneral.Open()
            'MsgBox("Conectado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try

    End Sub
End Module
