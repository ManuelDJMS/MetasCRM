Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class cotLIMSAct
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim COT As Integer
        COT = Val(txtCot.Text)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        ' Dim n As Integer = 0
        Dim desde, hasta As Date
        Dim nombre, puesto, tel, ext, correo, emp, dom, lugar, moneda, cotizo, correoEla, depto,
        pago, entrega, modalidad, obser, calmetho, services, domFac, rfc As String
        Dim cve As Integer
        Dim R As String
        'Dim name, mfr, model, service, price, subt As String
        R = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, [Department],[Phone],[Email],
				[CompanyName], [ContAddress1] + ' '+  [ContCity] +', '+ [ContState]+'. ' + [ContCountry] +'. CP '+ [ContZip] AS DomCont, PartidaNo, Cantidad,[DetalleCotizaciones].[EquipId],
				[SetUpEquipment].[EquipmentName]+', '+[Mfr] +', '+[Model] AS Articulo,[ServiceDescription],[SetupEquipmentServiceMapping].[Price], [idUsuarioAdministrador], [Usuarios].[Nombre], [LugarCondicion].[Descripcon] AS lugar, [MonedaCondicion].[Descripcion] AS moneda, 
				[PagoCondicion].[Descripcion] AS pago, [TiemposEntregaCondicion].[Descripcion] AS entrega, [ModalidadCondicion].[Descripcion] AS modalidad,
				[Cotizaciones].[Observaciones],[CalibrationMethod], [ServiceDescription], [BillAddress1] +' '+ [BillCity] +', '+ [BillState]+'. '+[BillCountry]+' CP '+[BillZip] AS domFac, [TaxIDNo]
                from [MetasCotizador].[dbo].[Cotizaciones]
				INNER JOIN [Usuarios] ON [Cotizaciones].[idUsuarioCotizacion] = [Usuarios].[idUsuarioAdministrador]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				INNER JOIN [LugarCondicion] ON [Cotizaciones].[idLugarCondicion] = [LugarCondicion].[idLugarCondicion]
				INNER JOIN [MonedaCondicion] ON [Cotizaciones].[idMonedaCondicion] = [MonedaCondicion].[idMonedaCondicion]
				INNER JOIN [PagoCondicion] ON [Cotizaciones].[idPagoCondicion] = [PagoCondicion].[idPagoCondicion]
				INNER JOIN [TiemposEntregaCondicion] ON [Cotizaciones].[idTiempoEntregaCondicion] = [TiemposEntregaCondicion].[idTiempoEntregaCondicion]
				INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupEquipmentServiceMapping] ON [SetUpEquipment].[EquipId] =[SetupEquipmentServiceMapping].[EquipId]			
                WHERE [Cotizaciones].NumCot = '" & Val(txtCot.Text) & "'"
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        'While lectorMetasCotizador.Read()
        lectorMetasCotizador.Read()
        If ((lectorMetasCotizador(1) Is DBNull.Value) OrElse (lectorMetasCotizador(1) Is Nothing)) Then
            desde = " - "
        Else
            desde = lectorMetasCotizador(1)
        End If
        'MsgBox(desde)
        If ((lectorMetasCotizador(2) Is DBNull.Value) OrElse (lectorMetasCotizador(2) Is Nothing)) Then
            hasta = " - "
        Else
            hasta = lectorMetasCotizador(2)
        End If
        'MsgBox(hasta)
        If ((lectorMetasCotizador(3) Is DBNull.Value) OrElse (lectorMetasCotizador(3) Is Nothing)) Then
            nombre = " - "
        Else
            nombre = lectorMetasCotizador(3)
        End If
        'MsgBox(nombre)
        If ((lectorMetasCotizador(4) Is DBNull.Value) OrElse (lectorMetasCotizador(4) Is Nothing)) Then
            puesto = " - "
        Else
            puesto = lectorMetasCotizador(4)
        End If
        'MsgBox(puesto)
        If ((lectorMetasCotizador(5) Is DBNull.Value) OrElse (lectorMetasCotizador(5) Is Nothing)) Then
            tel = " - "
        Else
            tel = lectorMetasCotizador(5)
        End If
        ' MsgBox(tel)
        'If ((lectorMetasCotizador(6) Is DBNull.Value) OrElse (lectorMetasCotizador(6) Is Nothing)) Then
        '    ext = " - "
        'Else
        '    ext = lectorMetasCotizador(6)
        'End If
        'MsgBox(ext)
        If ((lectorMetasCotizador(6) Is DBNull.Value) OrElse (lectorMetasCotizador(6) Is Nothing)) Then
            correo = " - "
        Else
            correo = lectorMetasCotizador(6)
        End If
        'MsgBox(correo)
        If ((lectorMetasCotizador(7) Is DBNull.Value) OrElse (lectorMetasCotizador(7) Is Nothing)) Then
            emp = " - "
        Else
            emp = lectorMetasCotizador(7)
        End If
        'MsgBox(emp)
        If ((lectorMetasCotizador(8) Is DBNull.Value) OrElse (lectorMetasCotizador(8) Is Nothing)) Then
            dom = " - "
        Else
            dom = lectorMetasCotizador(8)
        End If
        If ((lectorMetasCotizador(15) Is DBNull.Value) OrElse (lectorMetasCotizador(19) Is Nothing)) Then
            cve = " - "
        Else
            cve = lectorMetasCotizador(15)
            Select Case cve
                Case 1
                    correoEla = "ventas1@metas.mx"
                    depto = "Ventas Calibración"
                Case 2
                    correoEla = "ventas2@metas.mx"
                    depto = "Ventas Calibración"
                Case 3
                    correoEla = "calidad@metas.mx"
                    depto = "Calidad"
                Case 4
                    correoEla = "logistica@metas.mx"
                    depto = "Lab. Temperatura & Presión"
                Case 5
                    correoEla = "logistica@metas.mx"
                    depto = "Ventas Calibración"
                Case 6
                    correoEla = "ventas2@metas.mx"
                    depto = "Ventas Calibración"
                Case 7
                    correoEla = "consultoria.gestion@metas.mx"
                    depto = "Cursos & Venta Inst"
                Case 8
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Masa Den Vol"
                Case 9
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Eléctrica"
                Case 10
                    correoEla = "logistica@metas.mx"
                    depto = "Lab. Temperatura & Presión"
                Case 11
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Eléctrica"
                Case 12
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Eléctrica"
                Case 13
                    correoEla = "logistica@metas.mx"
                    depto = "Ventas Calibración"
                Case 14
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Eléctrica"
                Case 15
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Eléctrica"
                Case 16
                    correoEla = "logistica@metas.mx"
                    depto = "Lab. Temperatura & Presión"
                Case 17
                    correoEla = "ventas3@metas.mx"
                    depto = "Ventas Calibración"
                Case 18
                    correoEla = "logistica@metas.mx"
                    depto = "Lab. Temperatura & Presión"
                Case 19
                    correoEla = "logistica@metas.mx"
                    depto = "Lab Eléctrica"
                Case 20
                    correoEla = "ventas3@metas.mx"
                    depto = "Ventas"
                Case 21
                    correoEla = "logistica@metas.mx"
                    depto = "Lab. Temperatura, Humedad & Presión"
                Case 22
                    correoEla = "logistica@metas.mx"
                    depto = "Lab. Temperatura, Humedad & Presión"
                Case 100
                    correoEla = "venta.instrumentos@metas.mx"
                    depto = "Gestoría"
            End Select
        End If
        'MsgBox(cve)
        'MsgBox(correoEla)
        'MsgBox(depto)
        If ((lectorMetasCotizador(16) Is DBNull.Value) OrElse (lectorMetasCotizador(16) Is Nothing)) Then
            cotizo = " - "
        Else
            cotizo = lectorMetasCotizador(16)
        End If
        'MsgBox(cotizo)
        If ((lectorMetasCotizador(17) Is DBNull.Value) OrElse (lectorMetasCotizador(17) Is Nothing)) Then
            lugar = " - "
        Else
            lugar = lectorMetasCotizador(17)
        End If
        'MsgBox(lugar)
        If ((lectorMetasCotizador(18) Is DBNull.Value) OrElse (lectorMetasCotizador(18) Is Nothing)) Then
            moneda = " - "
        Else
            moneda = lectorMetasCotizador(18)
        End If
        'MsgBox(moneda)
        If ((lectorMetasCotizador(19) Is DBNull.Value) OrElse (lectorMetasCotizador(19) Is Nothing)) Then
            pago = " - "
        Else
            pago = lectorMetasCotizador(19)
        End If
        'MsgBox(pago)
        If ((lectorMetasCotizador(20) Is DBNull.Value) OrElse (lectorMetasCotizador(20) Is Nothing)) Then
            entrega = " - "
        Else
            entrega = lectorMetasCotizador(20)
        End If
        'MsgBox(entrega)
        If ((lectorMetasCotizador(21) Is DBNull.Value) OrElse (lectorMetasCotizador(21) Is Nothing)) Then
            modalidad = " - "
        Else
            modalidad = lectorMetasCotizador(21)
        End If
        'MsgBox(modalidad)
        If ((lectorMetasCotizador(22) Is DBNull.Value) OrElse (lectorMetasCotizador(22) Is Nothing)) Then
            obser = " - "
        Else
            obser = lectorMetasCotizador(22)
        End If
        'MsgBox(obser)
        If ((lectorMetasCotizador(23) Is DBNull.Value) OrElse (lectorMetasCotizador(23) Is Nothing)) Then
            calmetho = " - "
        Else
            calmetho = lectorMetasCotizador(23)
        End If
        'MsgBox(calmetho)
        If ((lectorMetasCotizador(24) Is DBNull.Value) OrElse (lectorMetasCotizador(24) Is Nothing)) Then
            services = " - "
        Else
            services = lectorMetasCotizador(24)
        End If
        'MsgBox(services)
        'MsgBox(equipId)
        If ((lectorMetasCotizador(25) Is DBNull.Value) OrElse (lectorMetasCotizador(25) Is Nothing)) Then
            domFac = " - "
        Else
            domFac = lectorMetasCotizador(25)
        End If
        'MsgBox(domFac)
        If ((lectorMetasCotizador(26) Is DBNull.Value) OrElse (lectorMetasCotizador(26) Is Nothing)) Then
            rfc = " - "
        Else
            rfc = lectorMetasCotizador(26)
        End If
        lectorMetasCotizador.Close()
        'MsgBox(rfc)
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexionMetasCotizador
        Adaptador.SelectCommand.CommandText = "cotLIMS3"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@numCot", SqlDbType.VarChar)
        Dim param2 = New SqlParameter("@fechaDesde", SqlDbType.Date)
        Dim param3 = New SqlParameter("@fechaHasta", SqlDbType.Date)
        Dim param4 = New SqlParameter("@nombre", SqlDbType.VarChar)
        Dim param5 = New SqlParameter("@puesto", SqlDbType.VarChar)
        Dim param6 = New SqlParameter("@telefono", SqlDbType.VarChar)
        Dim param8 = New SqlParameter("@correo", SqlDbType.VarChar)
        Dim param9 = New SqlParameter("@com", SqlDbType.VarChar)
        Dim param10 = New SqlParameter("@dom", SqlDbType.VarChar)
        Dim param11 = New SqlParameter("@cveElaboro", SqlDbType.Int)
        Dim param12 = New SqlParameter("@elaborocot", SqlDbType.VarChar)
        Dim param13 = New SqlParameter("@correoElaboro", SqlDbType.VarChar)
        Dim param14 = New SqlParameter("@depto", SqlDbType.VarChar)
        Dim param15 = New SqlParameter("@lugar", SqlDbType.VarChar)
        Dim param16 = New SqlParameter("@moneda", SqlDbType.VarChar)
        Dim param17 = New SqlParameter("@pago", SqlDbType.VarChar)
        Dim param18 = New SqlParameter("@entrega", SqlDbType.VarChar)
        Dim param19 = New SqlParameter("@modalidad", SqlDbType.VarChar)
        Dim param20 = New SqlParameter("@obser", SqlDbType.VarChar)
        Dim param21 = New SqlParameter("@calMetodo", SqlDbType.VarChar)
        Dim param22 = New SqlParameter("@serDescripcion", SqlDbType.VarChar)
        Dim param23 = New SqlParameter("@domFactura", SqlDbType.VarChar)
        Dim param24 = New SqlParameter("@rfc", SqlDbType.VarChar)
        param2.Direction = ParameterDirection.Input
        param3.Direction = ParameterDirection.Input
        param4.Direction = ParameterDirection.Input
        param5.Direction = ParameterDirection.Input
        param6.Direction = ParameterDirection.Input
        'param7.Direction = ParameterDirection.Input
        param8.Direction = ParameterDirection.Input
        param9.Direction = ParameterDirection.Input
        param10.Direction = ParameterDirection.Input
        param11.Direction = ParameterDirection.Input
        param12.Direction = ParameterDirection.Input
        param13.Direction = ParameterDirection.Input
        param14.Direction = ParameterDirection.Input
        param15.Direction = ParameterDirection.Input
        param16.Direction = ParameterDirection.Input
        param17.Direction = ParameterDirection.Input
        param18.Direction = ParameterDirection.Input
        param19.Direction = ParameterDirection.Input
        param20.Direction = ParameterDirection.Input
        param21.Direction = ParameterDirection.Input
        param22.Direction = ParameterDirection.Input
        param23.Direction = ParameterDirection.Input
        param24.Direction = ParameterDirection.Input
        param1.Value = COT
        param2.Value = desde
        param3.Value = hasta
        param4.Value = nombre
        param5.Value = puesto
        param6.Value = tel
        'param7.Value = ext
        param8.Value = correo
        param9.Value = emp
        param10.Value = dom
        param11.Value = cve
        param12.Value = cotizo
        param13.Value = correoEla
        param14.Value = depto
        param15.Value = lugar
        param16.Value = moneda
        param17.Value = pago
        param18.Value = entrega
        param19.Value = modalidad
        param20.Value = obser
        param21.Value = calmetho
        param22.Value = services
        param23.Value = domFac
        param24.Value = rfc
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)
        Adaptador.SelectCommand.Parameters.Add(param3)
        Adaptador.SelectCommand.Parameters.Add(param4)
        Adaptador.SelectCommand.Parameters.Add(param5)
        Adaptador.SelectCommand.Parameters.Add(param6)
        'Adaptador.SelectCommand.Parameters.Add(param7)
        Adaptador.SelectCommand.Parameters.Add(param8)
        Adaptador.SelectCommand.Parameters.Add(param9)
        Adaptador.SelectCommand.Parameters.Add(param10)
        Adaptador.SelectCommand.Parameters.Add(param11)
        Adaptador.SelectCommand.Parameters.Add(param12)
        Adaptador.SelectCommand.Parameters.Add(param13)
        Adaptador.SelectCommand.Parameters.Add(param14)
        Adaptador.SelectCommand.Parameters.Add(param15)
        Adaptador.SelectCommand.Parameters.Add(param16)
        Adaptador.SelectCommand.Parameters.Add(param17)
        Adaptador.SelectCommand.Parameters.Add(param18)
        Adaptador.SelectCommand.Parameters.Add(param19)
        Adaptador.SelectCommand.Parameters.Add(param20)
        Adaptador.SelectCommand.Parameters.Add(param21)
        Adaptador.SelectCommand.Parameters.Add(param22)
        Adaptador.SelectCommand.Parameters.Add(param23)
        Adaptador.SelectCommand.Parameters.Add(param24)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("numCot", COT)
        Dim p2 As New ReportParameter("fechaDesde", desde)
        Dim p3 As New ReportParameter("fechaHasta", hasta)
        Dim p4 As New ReportParameter("nombre", nombre)
        Dim p5 As New ReportParameter("puesto", puesto)
        Dim p6 As New ReportParameter("telefono", tel)
        'Dim p7 As New ReportParameter("ext", ext)
        Dim p8 As New ReportParameter("correo", correo)
        Dim p9 As New ReportParameter("com", emp)
        Dim p10 As New ReportParameter("dom", dom)
        Dim p11 As New ReportParameter("cveElaboro", cve)
        Dim p12 As New ReportParameter("elaborocot", cotizo)
        Dim p13 As New ReportParameter("correoElaboro", correoEla)
        Dim p14 As New ReportParameter("depto", depto)
        Dim p15 As New ReportParameter("lugar", lugar)
        Dim p16 As New ReportParameter("moneda", moneda)
        Dim p17 As New ReportParameter("pago", pago)
        Dim p18 As New ReportParameter("entrega", entrega)
        Dim p19 As New ReportParameter("modalidad", modalidad)
        Dim p20 As New ReportParameter("obser", obser)
        Dim p21 As New ReportParameter("calMetodo", calmetho)
        Dim p22 As New ReportParameter("serDescripcion", services)
        Dim p23 As New ReportParameter("domFac", domFac)
        Dim p24 As New ReportParameter("rfc", rfc)

        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\cotActualizada.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p8, p9, p10, p11, p12,
                                                            p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24})
        FrmReportes.ReportViewer1.RefreshReport()
        FrmReportes.Show()
        conexionMetasCotizador.Close()
    End Sub
End Class