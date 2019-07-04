Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Collections
Module MetAsInf2019
    Public servidor As String = "[DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo]." 'Esta variable sirve para alojar el servidor para las consultas
    Public bancorreo As Integer 'Esta variable es una bandera para abrir cierto formukario
    Public correos As String
    Public conexion2019 As SqlConnection              ''Base de datos METASINF-2019
    Public comando2019 As SqlCommand
    Public lector2019 As SqlDataReader
    Public conexioncot As SqlConnection
    Public fechaActual As DateTime
    Public respuestafolio As Integer
    Public fecharecepcion As String
    'Public conexionprueba As String = "Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019-2; User Id=sa; Password=Met99011578a;Integrated Security=False"
    Sub MetodoMetasInf2019()
        Try
            'conexion = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            ' conexion2019 = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2019 = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019-3; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2019.Open()
            'MsgBox("Conectado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
    Sub MetodoCotizador2019()
        '------METODO PARA USAR SOLO LAS TABLAS DEL COTIZADOR-------------
        Try
            conexioncot = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=MetasCotizador-3; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexioncot.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
End Module
