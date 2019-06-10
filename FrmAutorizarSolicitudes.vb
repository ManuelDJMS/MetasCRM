Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Dim CustimerId As Integer
    Dim cotizacion As Integer
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralDeCotizaciones()
        consultaContactos()
        alternarColorColumnas(DGRes)
        agregar_a_Res()
    End Sub

    Public Sub agregar_a_Res()
        Try
            For i = 0 To DGOportunidades.Rows.Count - 2
                MetodoLIMS()
                'Dim R As String = "select concat([FirstName], '',  [MiddleName], '', [LastName]), [CompanyName], CustomerId from [SetupCustomerDetails] where CustomerId=" & Val(DGOportunidades.Item(1, i).Value) & ""
                Dim R As String = "  select concat([SetupCustomerDetails].[FirstName], '', [SetupCustomerDetails].[MiddleName], '', [SetupCustomerDetails].[LastName]), 
            [SetupCustomerDetails].[CompanyName],[SetupCustomerDetails].[CustAccountNo], [SetupCustomerDetails].CustomerId, [SetupCustomerAddressDtls].[ShipAddress1],
            [SetupCustomerAddressDtls].[ShipAddress2],[SetupCustomerAddressDtls].[ShipAddress3], [SetupCustomerAddressDtls].[ShipCity], [SetupCustomerAddressDtls].[ShipState],
            [SetupCustomerAddressDtls].[ShipZip],[SetupCustomerAddressDtls].[ShipCountry] from [SetupCustomerDetails] 
            inner join [SetupCustomerAddressDtls] on [SetupCustomerDetails].CustomerId = [SetupCustomerAddressDtls].CustomerId where [SetupCustomerDetails].CustomerId=" & Val(DGOportunidades.Item(1, i).Value) & ""
                Dim comando As New SqlCommand(R, conexionLIMS)
                Dim lector As SqlDataReader
                lector = comando.ExecuteReader
                lector.Read()
                DGRes.Rows.Add(Val(DGOportunidades.Item(0, i).Value), lector(0), lector(1), DGOportunidades.Item(2, i).Value, DGOportunidades.Item(3, i).Value, DGOportunidades.Item(4, i).Value, Val(DGOportunidades.Item(5, i).Value), lector(2), False, lector(2), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), 3, "Client A", lector(10), Val(DGOportunidades.Item(1, i).Value))
                conexionLIMS.Close()
            Next i
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos de cotizaciones.", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub consultaGeneralDeCotizaciones()
        Try                      ''''Consulta de algunos campos solamente
            MetodoMetasCotizador()
            'DGOportunidades.Rows.Clear()
            Dim R As String
            R = "select Cotizaciones.NumCot, Cotizaciones.idContacto, Cotizaciones.Referencia, Cotizaciones.FechaDesde, Cotizaciones.FechaHasta, Cotizaciones.Total from Cotizaciones where Cotizaciones.Origen='LIMS'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGOportunidades.DataSource = dt
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error")
        End Try
    End Sub

    Public Sub consultaContactos()
        Try
            MetodoLIMS()
            'DGContactos.Rows.Clear()
            Dim R As String
            R = "select [SetupCustomerDetails].[CustomerId], concat([SetupCustomerDetails].[FirstName], ' ',  [SetupCustomerDetails].[MiddleName], ' ', [SetupCustomerDetails].[LastName]) as Contacto, 
                  [SetupCustomerDetails].[CompanyName], [SetupCustomerDetails].[CustAccountNo],
                  [SetupCustomerAddressDtls].[ShipAddress1], [SetupCustomerAddressDtls].[ShipAddress2], [SetupCustomerAddressDtls].[ShipAddress3], [SetupCustomerAddressDtls].[ShipCity], 
                  [SetupCustomerAddressDtls].[ShipState], [SetupCustomerAddressDtls].[ShipZip], [SetupCustomerAddressDtls].[ShipCountry] 
                  from [SetupCustomerDetails] inner join [SetupCustomerAddressDtls] on [SetupCustomerDetails].CustomerId = [SetupCustomerAddressDtls].CustomerId"
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

    Private Sub DGRes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGRes.RowHeaderMouseClick
        Dim numCot As String
        numCot = DGRes.Rows(e.RowIndex).Cells(0).Value.ToString()
        CustimerId = DGRes.Rows(e.RowIndex).Cells(19).Value.ToString()
        txtClaveRecopilada.Text = numCot
        consultaContactos(CustimerId)
        consultaCot(numCot)
        TabConsulta.SelectTab(1)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Sub consultaContactos(ByVal CustomerId As Integer)
        Try
            MetodoLIMS()
            Dim R As String = "select isnull(CustAccountNo,'-'), isnull(FirstName,'-'), isnull(MiddleName,'-'), isnull(LastName,'-'),
                                isnull(Phone,'-'), isnull(Mobile,'-'), isnull(Email,'-'), isnull(CompanyName,'-'), isnull(KeyFiscal,'-') 
                                from [SetupCustomerDetails] where [SetupCustomerDetails].[CustomerId]=" & CustomerId & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            txtNumeroDeCuenta.Text = lector(0)
            txtNombreDeContacto.Text = lector(1) & " " & lector(2) & " " & lector(3)
            txtTelefono.Text = lector(4)
            txtCelular.Text = lector(5)
            txtCorreo1.Text = lector(6)
            txtNombreCompania.Text = lector(7)
            txtKeyFiscal.Text = lector(8)
            lector.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Error de lectura de datos.", MsgBoxStyle.Information)
        End Try
    End Sub

    Sub consultaCot(ByVal numCot As Integer)
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select isnull(Referencia,'-'), isnull(Observaciones,'-'), isnull(FechaDesde,'-'), isnull(FechaHasta,'-'),
                isnull(Subtotal,'-'), isnull(IVA,'-'), isnull(Total,'-') from Cotizaciones where Cotizaciones.NumCot=" & numCot & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            txtReferencia.Text = lector(0)
            txtObservaciones.Text = lector(1)
            txtFechaDesde.Text = lector(2)
            txtFechaHasta.Text = lector(3)
            txtSubtotal.Text = lector(4)
            txtIVA.Text = lector(5)
            txtTotal.Text = lector(6)
            lector.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub

    'Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
    '    Try
    '        MetodoLIMS()
    '        Dim R As String
    '        R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RecDate, RecBy, ) values ("
    '        Dim comando As New SqlCommand(R, conexionLIMS)
    '        comando.ExecuteNonQuery()
    '        MsgBox("Orden de Venta generada correctamente", MsgBoxStyle.Information)
    '    Catch ex As Exception
    '        MsgBox("Error al cargar la Orden de venta.", MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Generar
        Try
            Dim seleccionado As Boolean
            Dim R As String
            Dim b, RecDate, OnSite As Boolean
            RecDate = True
            OnSite = False
            If DGRes.Rows.Count < 2 Then
                MsgBox("No hay ordenes de venta seleccionadas.", MsgBoxStyle.Critical, "Error del sistema.")
            Else
                '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(8).Value
                    If seleccionado = True Then
                        b = True
                        Exit For
                    Else
                        b = False
                    End If
                Next
                '----------------------------------------------------------------------------------------------------
                If b = True Then
                    For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                        seleccionado = DGRes.Rows(i).Cells(8).Value
                        If seleccionado = True Then
                            MetodoLIMS()
                            R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RecDate, DataRequested, OnSite, ShipAddress1, ShipAddress2, ShipAddress3, ShipCity, ShipState, ShipZip, ShipTo, CategoryCustomer, ShipCountry,[PONo],[RefNo],[RecBy],[Priority],[ReceivedVia],[ShipVia],[Remarks],[CreatedBy],[CreatedOn],[ModifiedBy],[ModifiedOn],[SalesAmount],[SalesDiscount],[SalesTax],[Scheduled],[BillTo],[TrackingNo],[BoxCount],[Weight],[Volume],[PaymentTerms]) values(" & Val(DGRes.Rows(i).Cells(7).Value) & ",'" & DGRes.Rows(i).Cells(9).Value & "', (CONVERT(varchar(10), getdate(), 103)), '" & True & "','" & False & "','" & DGRes.Rows(i).Cells(10).Value & "','" & DGRes.Rows(i).Cells(11).Value & "','" & DGRes.Rows(i).Cells(12).Value & "','" & DGRes.Rows(i).Cells(13).Value & "','" & DGRes.Rows(i).Cells(14).Value & "','" & DGRes.Rows(i).Cells(15).Value & "','" & DGRes.Rows(i).Cells(16).Value & "','" & DGRes.Rows(i).Cells(17).Value & "','" & DGRes.Rows(i).Cells(18).Value & "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '')"
                            Dim comando As New SqlCommand(R, conexionLIMS)
                            comando.ExecuteNonQuery()
                            conexionLIMS.Close()
                        End If
                    Next
                    MsgBox("Ordenes de venta generadas correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al enviar correos.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''Actualizar
        consultaGeneralDeCotizaciones()
        consultaContactos()
        DGRes.Rows.Clear()
        agregar_a_Res()
    End Sub
End Class