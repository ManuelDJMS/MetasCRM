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
        If bancorreo = 2 Then
            numCuenta.Text = var.Text
        ElseIf bancorreo = 3 Then
            numCuenta.Text = lector(1)
        End If

        bancorreo = False
        correos = ""
        bancorreo = 0
    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub
End Class