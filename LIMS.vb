Imports System.Data.SqlClient
Module LIMS              ''--------------------------BASE DE DATOS LIMS--------------
    Public conexionLIMS As SqlConnection
    Public comandoLIMS As SqlCommand
    Public lectorLIMS As SqlDataReader
    Public ban As Boolean = True
    Public banderaform As Boolean
    Public numcotfrm, Total As Integer
    Public empresafrm, Contacto, Referencia, corrreofrm As String
    Sub MetodoLIMS()
        Try
            'conexionLIMS = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            conexionLIMS = New SqlConnection("Data Source=DATABASESERVER\COMPAC;Initial Catalog=MetAs_Live-pruebas; User Id=sa; Password=Contpaq1;Integrated Security=False")
            'conexionLIMS = New SqlConnection("Data Source=185.166.213.202;Initial Catalog=MetAs_Live; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionLIMS.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub

    Sub verifiarnulos(ByVal valor As String, ByVal txt As TextBox)

        If (valor Is DBNull.Value) Or (valor Is Nothing) Or valor.Equals("") Or valor.Length < 0 Then
            txt.Text = "-"
        Else
            txt.Text = valor
        End If
    End Sub
    Public Sub consultaGeneralDeCotizaciones(ByVal dg As DataGridView)
        Try
            MetodoMetasCotizador()
            Dim R As String = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
                inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Public Sub busquedas(ByVal dg As DataGridView, ByVal email As TextBox, ByVal cp As TextBox, ByVal empresa As TextBox, ByVal domicilio As TextBox, ByVal telefono As TextBox)
        Try
            dg.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
                inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0 and CompanyName like '" & empresa.Text & "%' and ContAddress1 like '" & domicilio.Text & "%'
                and Email like '" & email.Text & "%' and ContZip like '" & cp.Text & "%' and Phone like '" & telefono.Text & "%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
End Module