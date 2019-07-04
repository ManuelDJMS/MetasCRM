Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Dim CustimerId As Integer
    Dim cotizacion As Integer
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralDeCotizaciones()
    End Sub
    Public Sub consultaGeneralDeCotizaciones()
        Try
            MetodoMetasCotizador()
            Dim R As String = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Referencia, FechaDesde, FechaHasta, Total, CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] where Creado= 0"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), False, lector(8))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al buscar cot", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DGRes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGRes.RowHeaderMouseClick
        Try
            Dim numCot As String
            numCot = DGRes.Rows(e.RowIndex).Cells(0).Value.ToString()
            CustimerId = DGRes.Rows(e.RowIndex).Cells(7).Value.ToString()
            txtClaveRecopilada.Text = numCot
            consultaContactos(CustimerId)
            consultaCot(numCot)
            TabConsulta.SelectTab(1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al seleccionar una cotización", Err.Number, cadena)
        End Try
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error en Consulta Contactos", Err.Number, cadena)
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
            R = "select NumCot, ItemNumber, RelationItemNo, EquipmentName, Mfr, Model, SrlNo, Accuracy, Price, CantidadReal from DetalleCotizaciones
             inner join" & servidor & "[SetupEquipment] Equipos on DetalleCotizaciones.EquipId=Equipos.EquipId
             inner join" & servidor & "[SetupEquipmentServiceMapping] Precio on Equipos.EquipId=Precio.EquipId where NumCot=" & numCot
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read
                dgCot.Rows.Add(lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9))
            End While
            lector.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar la consulta de la cotización", Err.Number, cadena)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Generar
        Dim con As FrmCompletarOV
        Dim cliente As String
        Dim cu, ca As Integer
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

                        Dim fecha As String
                        If seleccionado = True Then
                            MetodoLIMS()
                            R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RecDate, DataRequested, OnSite, ShipAddress1, ShipAddress2, ShipAddress3, ShipCity, ShipState, ShipZip, ShipTo, CategoryCustomer, ShipCountry,[PONo],[RefNo],[RecBy],[Priority],[ReceivedVia],[ShipVia],[Remarks],[CreatedBy],[CreatedOn],[ModifiedBy],[ModifiedOn],[SalesAmount],[SalesDiscount],[SalesTax],[Scheduled],[BillTo],[TrackingNo],[BoxCount],[Weight],[Volume],[PaymentTerms]) 
                            values(" & Val(DGRes.Rows(i).Cells(19).Value) & ",'" & DGRes.Rows(i).Cells(9).Value & "','" & dtp.Value.ToShortDateString & "', '" & True & "','" & False & "','" & DGRes.Rows(i).Cells(10).Value & "','" & DGRes.Rows(i).Cells(11).Value & "','" & DGRes.Rows(i).Cells(12).Value & "','" & DGRes.Rows(i).Cells(13).Value & "','" & DGRes.Rows(i).Cells(14).Value & "','" & DGRes.Rows(i).Cells(15).Value & "','" & DGRes.Rows(i).Cells(16).Value & "','" & DGRes.Rows(i).Cells(17).Value & "','" & DGRes.Rows(i).Cells(18).Value & "', '', ' " & DGRes.Rows(i).Cells(0).Value & "', '', '', '', '', '', 'USR00000008', '" & dtp.Value.ToShortDateString & "', '', '', '', '', '', '', '', '', '', '', '', '')"
                            Dim comando As New SqlCommand
                            comando = conexionLIMS.CreateCommand
                            comando.CommandText = R
                            comando.ExecuteNonQuery()
                            cu = Val(DGRes.Rows(i).Cells(19).Value)
                            ca = DGRes.Rows(i).Cells(9).Value
                            cusAcount.Text = ca
                            fecha = dtp.Value.ToShortDateString
                            conexionLIMS.Close()
                            MetodoLIMS()
                            R = "SELECT top 1 [SOId], [CustomerId],[CustAccountNo],[RecDate]
                            FROM SalesOrderDetails where [CustomerId] = '" & Val(cu) & "' and [CustAccountNo] = '" & Val(ca) & "'  and [RecDate] = '" & fecha & "' ORDER BY [SOId] DESC"
                            Dim comando2 As New SqlCommand(R, conexionLIMS)
                            Dim lector As SqlDataReader
                            lector = comando2.ExecuteReader
                            lector.Read()
                            Dim numOV As Integer = lector(0)
                            conexionLIMS.Close()
                            MetodoMetasCotizador()
                            R = "update Cotizaciones set Creado= '" & numOV & "' where NumCot=" & Val(DGRes.Rows(i).Cells(0).Value) & ""
                            Dim coma As New SqlCommand(R, conexionMetasCotizador)
                            OV.Text = numOV
                            coma.ExecuteNonQuery()
                            conexionMetasCotizador.Close()
                        End If
                    Next
                    MsgBox("Ordenes de venta generadas correctamente.", MsgBoxStyle.Information)
                    MetodoMetasCotizador()
                    FrmCompletarOV.var.Text = Me.cusAcount.Text
                    FrmCompletarOV.NumOV.Text = Me.OV.Text
                    FrmCompletarOV.ShowDialog()

                    If DGRes.Rows.Count < 2 Then

                    Else
                        DGRes.Rows.Clear()
                    End If
                    consultaGeneralDeCotizaciones()
                Else
                    MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        cadena = Err.Description
        cadena = cadena.Replace("'", "")
        Bitacora("FrmAutorizarSolicitudes", "Error al guardar la OV", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MetodoMetasCotizador()
        If DGRes.Rows.Count < 2 Then

        Else
            DGRes.Rows.Clear()
        End If
        consultaGeneralDeCotizaciones()
    End Sub

    Private Sub txtNumeroDeCuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroDeCuentaB.TextChanged
        Try
            For Each row As DataGridViewRow In DGRes.Rows
                row.Selected = False
                If CStr(row.Cells(0).Value) = txtNumeroDeCuentaB.Text Then
                    row.Selected = True
                    Exit For
                ElseIf CStr(row.Cells(0).Value).ToLower = Nothing Then
                    row.Selected = False
                Else
                    row.Selected = False
                End If
            Next
        Catch ex As Exception
            MsgBox("No se encuentra dicho número de cotización.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class