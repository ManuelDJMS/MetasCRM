Imports System.Data.SqlClient
Module Comercial
    Sub Metodocomercial()
        Try
            'conexion = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            ' conexion2019 = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2019 = New SqlConnection("Data Source=10.10.10.9\COMPAC;Initial Catalog=MetAs_Live; User Id=sa; Password=Contpaq1;Integrated Security=False")
            conexion2019.Open()
            MsgBox("Conectado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
End Module
