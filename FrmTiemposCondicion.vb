Imports System.Data.SqlClient
Public Class FrmTiemposCondicion
    Private Sub FrmTiemposCondicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaOrdenesDeVenta()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Public Sub consultaOrdenesDeVenta()
        Try
            MetodoLIMS()
            DGReal.Rows.Clear()
            Dim R As String
            R = "select SalesOrderDetails.SOId as [#OrdenVenta], SetupCustomerDetails.CompanyName as [Compañia], 
                 concat(SetupCustomerDetails.[FirstName],' ', SetupCustomerDetails.[MiddleName], ' ',SetupCustomerDetails.[LastName]) as [Contacto],
                 SetupCustomerDetails.CustAccountNo as [No.Cuenta], SalesOrderDetails.RecDate as [Fecha], SalesOrderDetails.SalesAmount as [Total] from SalesOrderDetails 
                 inner join SetupCustomerDetails on SalesOrderDetails.CustomerId = SetupCustomerDetails.CustomerId"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGReal.DataSource = dt
            DGReal.Columns(0).Width = 80
            DGReal.Columns(1).Width = 290
            DGReal.Columns(2).Width = 290
            DGReal.Columns(3).Width = 150
            DGReal.Columns(4).Width = 130
            DGReal.Columns(5).Width = 120
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub
End Class