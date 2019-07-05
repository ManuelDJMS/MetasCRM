Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmCompletarOV
    Private Sub FrmCompletarOV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        Dim R As String
        If bancorreo = 1 Then
            R = "Select [SetupCustomerAddressDtls].[CustomerId], [CustAccountNo], [FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1]
                FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] x1 INNER JOIN [SetupCustomerAddressDtls] ON x1.[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
		        where x1.[CustomerId] =" & empresa
            Label22.Visible = False
            NumOV.Visible = False
            Label13.Visible = False
            txtRefCot.Visible = False
            bancorreo = 3
        ElseIf bancorreo = 2 Then
            R = "SELECT [SetupCustomerAddressDtls].[CustomerId],[CustAccountNo],[FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1]
            FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
	        INNER JOIN [SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
		    where [CustAccountNo] = '" & var.Text & "'"

        End If
        Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
        lector.Read()

        txtNombreCompania.Text = lector(5)
        If bancorreo = 3 Then
            txtCorreo.Text = correos
        Else

            txtCorreo.Text = lector(4)
        End If

        txtDireccion.Text = lector(7)
        terminosPago.Text = lector(6)
        numCuenta.Text = var.Text


        If bancorreo = 2 Then
            numCuenta.Text = var.Text
        ElseIf bancorreo = 3 Then
            numCuenta.Text = lector(1)
        End If
        lector.Close()
        bancorreo = False
        correos = ""
        bancorreo = 0
        empresa = 0




        R = "SELECT [Id],[ShipVia] FROM [MetAs_Live-pruebas].[dbo].[SetupShippingMode]"
        Dim comando2 As New SqlCommand(R, conexionLIMS)
        Dim lector2 As SqlDataReader
        lector2 = comando2.ExecuteReader
        While lector2.Read()
            cboRecepcion.Items.Add(lector2(1))
            embarcarPor.Items.Add(lector2(1))
        End While
    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        Try
            MetodoLIMS()
            Dim R As String
            R = "UPDATE [MetAs_Live-pruebas].[dbo].[SalesOrderDetails] set [PONo] = '" & txtOrdenCompra.Text & "', [RecBy] = '" & cboRecibidoPor.Text & "', [BoxCount] = '" & txtCantCajas.Text & "', 
                [Weight] = '" & txtPeso.Text & "', [ReceivedVia] = '" & cboRecepcion.Text & "', [ShipVia] = '" & embarcarPor.Text & "', [Remarks] ='" & txtObservaciones.Text & "', [RefNo] = '" & txtRefCot.Text & "',
                [Volume] = '" & txtVolumen.Text & "'
                where [SOId] = " & Val(NumOV.Text) & ""
            MsgBox(R)
            Dim coma As New SqlCommand(R, conexionLIMS)
            coma.ExecuteNonQuery()
            MsgBox("ORDEN DE VENTA " & NumOV.Text & " ACTUALIZADA")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCompletarOV", "Error al actualizar la OV", Err.Number, cadena)
        End Try
        Me.Dispose()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub
End Class