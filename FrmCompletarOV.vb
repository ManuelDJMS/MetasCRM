Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmCompletarOV
    Private Sub FrmCompletarOV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        Dim R As String
        R = "SELECT [CustomerId],[CustAccountNo],[FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms]
      FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] = " & var.Text & ""
        Dim comando As New SqlCommand(R, conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        txtNombreCompania.Text = lector(5)

    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click

    End Sub
End Class