Imports System.Data.Sql
Imports System.Data.SqlClient
Module MetasCotizador
    Public conexionMetasCotizador As SqlConnection
    Public conexionMetrologos As SqlConnection
    Public comandoMetasCotizador As SqlCommand
    Public lectorMetasCotizador As SqlDataReader
    Public comandoMetrologos As SqlCommand
    Public lectorMetrologos As SqlDataReader
    Sub MetodoMetasCotizador()
        Try
            conexionMetasCotizador = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=MetasCotizador-3; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionMetasCotizador.Open()
        Catch ex As Exception
        End Try
    End Sub
    Sub MetodoMetasMetrologos()
        Try
            conexionMetrologos = New SqlConnection("Data Source=DATABASESERVER\COMPAC;Initial Catalog=adMETROLOGOS_ASOCIADOS; User Id=sa; Password=Contpaq1;Integrated Security=False")
            conexionMetrologos.Open()
        Catch ex As Exception
        End Try
    End Sub
End Module