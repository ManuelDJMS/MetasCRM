Imports System.Data.SqlClient
Public Class FrmTiemposCondicion
    Dim invoice As String
    Private Sub FrmTiemposCondicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaOrdenesDeVenta()
        alternarColorColumnas(DGRes)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Public Sub consultaOrdenesDeVenta()
        Try
            MetodoLIMS()
            DGRes.Rows.Clear()
            Dim cadena As String
            cadena = " select BillingDetails.BillingId, BillingDetails.BillingNumber, BillingDetails.SOID_FK, SetupCustomerDetails.CompanyName, 
                      concat(SetupCustomerDetails.[FirstName],' ', SetupCustomerDetails.[MiddleName], ' ',SetupCustomerDetails.[LastName]) as [Contacto],
                      BillingDetails.BillingDate, BillingDetails.BillingAmount from BillingDetails inner join SalesOrderDetails on BillingDetails.SOID_FK = SalesOrderDetails.SOId
                      inner join SetupCustomerDetails on SalesOrderDetails.CustomerId = SetupCustomerDetails.CustomerId where BillingDetails.facturado<>1"
            Dim comando As New SqlCommand(cadena, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), False)
            End While
            lector.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Error en lectura de datos.", MsgBoxStyle.Information)
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

    Private Sub DGRes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGRes.RowHeaderMouseClick, DGAgregados.RowHeaderMouseClick
        Dim fila As String
        fila = DGRes.Rows(e.RowIndex).Cells(0).Value.ToString()
        'TabConsulta.SelectTab(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        consultaOrdenesDeVenta()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Generar facuturas de ordenes de venta
        ' Try
        Dim seleccionado As Boolean
            Dim b As Boolean
            If DGRes.Rows.Count < 2 Then
                MsgBox("No hay ordenes de venta seleccionadas.", MsgBoxStyle.Critical, "Error del sistema.")
            Else
                '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                seleccionado = DGRes.Rows(i).Cells(7).Value
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
                    seleccionado = DGRes.Rows(i).Cells(7).Value
                    If seleccionado = True Then
                        invoice = DGRes.Rows(i).Cells(1).Value.ToString()
                        asignarDatos(invoice)
                    End If
                    Next
                    'accion post
                Else
                    MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
                End If
            End If
        'Catch ex As Exception
        ' MsgBox("Error al enviar correos.")
        ' End Try
    End Sub

    Public Sub exportarExcel()
        Dim fichero As New SaveFileDialog()
        fichero.Filter = "Excel (*.xls)|*.xls"
        If fichero.ShowDialog() = DialogResult.OK Then
            Dim aplicacion As Microsoft.Office.Interop.Excel.Application
            Dim libros_trabajo As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja_trabajo As Microsoft.Office.Interop.Excel.Worksheet
            aplicacion = New Microsoft.Office.Interop.Excel.Application()
            libros_trabajo = aplicacion.Workbooks.Add()
            hoja_trabajo = DirectCast(libros_trabajo.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
            'Recorremos el DataGridView rellenando la hoja de trabajo
            Dim columnsCount As Integer = DGAgregados.Columns.Count
            For i As Integer = 0 To DGAgregados.Rows.Count - 2
                For j As Integer = 0 To DGAgregados.Columns.Count - 1
                    If i = 0 Then 'pintamos cabecera
                        hoja_trabajo.Cells(i + 1, j + 1) = DGAgregados.Columns(j).HeaderText
                    Else 'pintamos datos
                        hoja_trabajo.Cells(i + 1, j + 1) = DGAgregados.Rows(i).Cells(j).Value.ToString()
                    End If
                Next
            Next
            libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
            libros_trabajo.Close(True)
            aplicacion.Quit()
        End If
    End Sub

    Public Sub asignarDatos(ByVal x As String)
        'Try
        MetodoLIMS()
        DGAgregados.Rows.Add(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        Dim linea As DataGridViewRow
            Dim cadena As String
            cadena = " select WorkOrderDetails.BillingNumber, SalesOrderDetails.RefNo, SalesOrderDetails.[PaymentTerms], SetupCustomerDetails.Organization, SetupCustomerDetails.Mobile, 
		              SetupCustomerDetails.Email, SetupCustomerDetails.KeyFiscal, WorkOrderDetails.SOId, SetupCustomerDetails.DefaultPO,  SetupCustomerDetails.Currency, 
		              WorkOrderDetails.WOId,SetupCustomerEquipmentMapping.InstrumentId,SetupServices.ServiceName, SetupServices.[FeeType], SetupServices.ShortNote, 
		              [SetUpEquipment].EquipmentName, WorkOrderDetails.WorkAmount, WorkOrderDetails.WorkTax, [ShipmentDetailsTable].[ShipingCharge]
		              from WorkOrderDetails 
		              inner join SalesOrderDetails on WorkOrderDetails.SOId=SalesOrderDetails.SOId 
		              inner join SetupCustomerDetails on WorkOrderDetails.CustomerId=SetupCustomerDetails.CustomerId
		              inner join SetupCustomerEquipmentMapping on [WorkOrderDetails].CustEquipMapId = SetupCustomerEquipmentMapping.CustEquipMapId
		              inner join [SetupServices] on [WorkOrderDetails].ServiceId = [SetupServices].ServicesId 
		              inner join [SetUpEquipment] on [WorkOrderDetails].CustEquipMapId = [SetUpEquipment].EquipId 
		              inner join [ShipmentDetailsTable] on [WorkOrderDetails].ShipmentId_Fk= [ShipmentDetailsTable].Shipmentid where WorkOrderDetails.BillingNumber='" & x & "'"
            Dim comando As New SqlCommand(cadena, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
            DGAgregados.Rows.Add(lector(0), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(1), lector(2), lector(9),
                                     lector(10), lector(12), lector(13), lector(14), lector(11), lector(15), lector(16), lector(18), "Subtotal", 16,
                                     lector(17), "Total", "4", "CFDII", "FolioComercial", lector(2), "FormaPagoComecial", "USO CFDI MANUAL", "METODO PAGO MANUAL",
                                     lector(6), "ClienteComercial", "Subtotal", 16, 0, "Total", "Codigo Servicio Comercial", "Descripcion Servicio", 1,
                                     "SERVICIO", "PRECIO", 16, 0, "TotalUnitario", "TotalFinal", "Clave Prod/Serv Comercial", "SERVICIO", "E48 - Unidad de servicio", "Clave Prodcuto SAT")
        End While



        For Each linea In DGAgregados.Rows
            linea.Cells(18).Value = linea.Cells(16).Value + linea.Cells(17).Value
            linea.Cells(21).Value = linea.Cells(18).Value * 1.16
            linea.Cells(31).Value = linea.Cells(18).Value
            linea.Cells(34).Value = linea.Cells(21).Value
            linea.Cells(36).Value = "Servicio de Calibración a " & linea.Cells(15).Value
            linea.Cells(39).Value = linea.Cells(18).Value
            linea.Cells(42).Value = linea.Cells(39).Value * 1.16
            linea.Cells(43).Value = linea.Cells(42).Value * linea.Cells(37).Value
            ' linea.Cells(21).Value = linea.Cells(15).Value * linea.Cells(20).Value
        Next




        lector.Close()
            conexionLIMS.Close()
        '  Catch ex As Exception
        '   MsgBox("Error en lectura de datos.", MsgBoxStyle.Information)
        '  End Try
    End Sub

    Private Sub DGCotizaciones_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGAgregados.CellEndEdit
        For Each fila In DGAgregados.Rows
            fila.Cells(21).Value = fila.Cells(15).Value * fila.Cells(20).Value
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exportarExcel()
    End Sub
End Class