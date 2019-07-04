Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmCompletarOV
    Private Sub FrmCompletarOV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        Dim R As String
        R = "SELECT [SetupCustomerAddressDtls].[CustomerId],[CustAccountNo],[FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1]
            FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
	        INNER JOIN [SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
		    where [CustAccountNo] = '" & var.Text & "'"
        Dim comando As New SqlCommand(R, conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        txtNombreCompania.Text = lector(5)
        txtCorreo.Text = lector(4)
        txtDireccion.Text = lector(7)
        terminosPago.Text = lector(6)
        numCuenta.Text = var.Text

    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub
End Class