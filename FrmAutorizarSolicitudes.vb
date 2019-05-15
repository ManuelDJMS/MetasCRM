Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralDeCotizaciones()
        consultaContactos()
        alternarColorColumnas(DGOportunidades)





        For i = 0 To DGOportunidades.Rows.Count - 2
            MetodoLIMS()
            Dim R As String = "select concat([FirstName], ' ',  [MiddleName], ' ', [LastName]), [CompanyName] from [SetupCustomerDetails] where CustomerId=" & Val(DGOportunidades.Item(1, i).Value) & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            DGReal.Rows.Add(Val(DGOportunidades.Item(0, i).Value), lector(0), lector(1), DGOportunidades.Item(2, i).Value, DGOportunidades.Item(3, i).Value, DGOportunidades.Item(4, i).Value, Val(DGOportunidades.Item(5, i).Value), Val(DGOportunidades.Item(6, i).Value), Val(DGOportunidades.Item(7, i).Value))
            conexionLIMS.Close()
        Next i



    End Sub
    Public Sub consultaGeneralDeCotizaciones()
        Try                      ''''Consulta de algunos campos solamente
            MetodoMetasCotizador()
            DGOportunidades.Rows.Clear()
            Dim R As String
            R = "select Cotizaciones.NumCot, Cotizaciones.idContacto, Cotizaciones.Referencia, Cotizaciones.FechaDesde, Cotizaciones.FechaHasta, Cotizaciones.Subtotal, Cotizaciones.IVA, Cotizaciones.Total from Cotizaciones"
            'R = "select Cotizaciones.NumCot, Cotizaciones.idContacto from Cotizaciones"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGOportunidades.DataSource = dt
            ' DGOportunidades.Columns(1).Visible = False
            'DGOportunidades.Columns(0).Width = 80
            ' DGOportunidades.Columns(2).Width = 380
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub

    Public Sub consultaContactos()
        Try                      ''''Consulta de algunos campos solamente
            MetodoLIMS()
            DGContactos.Rows.Clear()
            Dim R As String
            'R = "select Cotizaciones.NumCot, Cotizaciones.idContacto, Cotizaciones.Referencia, Cotizaciones.FechaDesde, Cotizaciones.FechaHasta, Cotizaciones.Subtotal, Cotizaciones.IVA, Cotizaciones.Total from Cotizaciones"
            R = "select [CustomerId], concat([FirstName], ' ',  [MiddleName], ' ', [LastName]), [CompanyName] from [SetupCustomerDetails]"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGContactos.DataSource = dt
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub



    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DGReal_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGReal.RowHeaderMouseClick
        Dim clave As String
        clave = DGReal.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtClaveRecopilada.Text = clave
        MsgBox(clave)
        TabConsulta.SelectTab(1)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub
End Class