Imports System.Data.SqlClient
Public Class FrmTiemposCondicion
    Dim OrdenVenta As Integer
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
            cadena = "select SalesOrderDetails.SOId as [#OrdenVenta], SetupCustomerDetails.CompanyName as [Compañia], 
                 concat(SetupCustomerDetails.[FirstName],' ', SetupCustomerDetails.[MiddleName], ' ',SetupCustomerDetails.[LastName]) as [Contacto],
                 SetupCustomerDetails.CustAccountNo as [No.Cuenta], SalesOrderDetails.RecDate as [Fecha], SalesOrderDetails.SalesAmount as [Total] from SalesOrderDetails 
                 inner join SetupCustomerDetails on SalesOrderDetails.CustomerId = SetupCustomerDetails.CustomerId"
            Dim comando As New SqlCommand(cadena, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), False)
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
        Try
            Dim seleccionado As Boolean
            Dim b As Boolean
            If DGRes.Rows.Count < 2 Then
                MsgBox("No hay ordenes de venta seleccionadas.", MsgBoxStyle.Critical, "Error del sistema.")
            Else
                '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(6).Value
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
                        seleccionado = DGRes.Rows(i).Cells(6).Value
                        If seleccionado = True Then
                            OrdenVenta = DGRes.Rows(i).Cells(0).Value.ToString()
                            ''Acciones para los seleccionados
                            asignarDatos(OrdenVenta)
                        End If
                    Next
                    'accion post
                Else
                    MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al enviar correos.")
        End Try
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

    Public Sub asignarDatos(ByVal ordenVenta As Integer)
        Try
            MetodoLIMS()
            Dim linea As DataGridViewRow
            Dim cadena As String
            cadena = "select SalesOrderDetails.SOId, SalesOrderDetails.SalesAmount,
		              WorkOrderDetails.CustEquipMapId, SetUpEquipment.EquipmentName, WorkOrderDetails.WorkAmount
		              from SalesOrderDetails inner join WorkOrderDetails on SalesOrderDetails.SOId=WorkOrderDetails.SOId
		              inner join SetUpEquipment on WorkOrderDetails.CustEquipMapId = SetUpEquipment.EquipId where SalesOrderDetails.SOId=" & ordenVenta & ""
            Dim comando As New SqlCommand(cadena, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGAgregados.Rows.Add("4", "A", lector(0), "CONTADO", "01", "G01", "PPD", "CodigoCliente", "Cliente",
                    lector(1), "16", "0", lector(1) * 1.16, lector(2), lector(3), 1, "SERVICIO", lector(4), "16", "0", lector(4) * 1.16)
            End While
            For Each linea In DGAgregados.Rows
                linea.Cells(21).Value = linea.Cells(15).Value * linea.Cells(20).Value
            Next
            lector.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Error en lectura de datos.", MsgBoxStyle.Information)
        End Try
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