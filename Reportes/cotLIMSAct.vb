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
        Dim fir As Image
        'Dim name, mfr, model, service, price, subt As String
        R = "	Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, isnull([Department], '-') AS Departament, isnull([Phone], '-') as Phone, isnull([SetupCustomerDetails].[Email], '-') as Email,
				isnull([CompanyName],'-') as CompanyName, [ContAddress1] + ' '+  [ContCity] +', '+ [ContState]+'. ' + [ContCountry] +'. CP '+ [ContZip] AS DomCont, ROW_NUMBER() OVER(ORDER BY PartidaNo ASC) AS Partidad, Cantidad,[DetalleCotizaciones].[EquipId],
				[SetUpEquipment].[EquipmentName]+', '+[Mfr] +', '+[Model] +'. ' + (CASE WHEN  [identificadorInventarioCliente] = '-' COLLATE SQL_Latin1_General_CP1_CI_AS  THEN [identificadorInventarioCliente]  COLLATE SQL_Latin1_General_CP1_CI_AS 
				ELSE [identificadorInventarioCliente] COLLATE SQL_Latin1_General_CP1_CI_AS  END) AS Comparacion,[SetupServices].[ServiceName],[ServiceDescription] +', ' + [TurnAroundTime]+' dias para calibración' as Descrip, [SetupEquipmentServiceMapping].[Price], [SetupEquipmentServiceMapping].[Price] * Cantidad AS sub,
				[idUsuarioAdministrador], [Usuarios].[Nombre], [LugarCondicion].[Descripcon] AS lugar, [MonedaCondicion].[Descripcion] AS moneda, 
				[PagoCondicion].[Descripcion] AS pago, [ModalidadCondicion].[Descripcion] AS modalidad,
				[Cotizaciones].[Observaciones],[CalibrationMethod], [ServiceDescription], [BillAddress1] +' '+ [BillCity] +', '+ [BillState]+'. '+[BillCountry]+' CP '+[BillZip] AS domFac, [TaxIDNo],
				[Usuarios].[Email], [Usuarios].[Depto], [Usuarios].[Firma] 
                from [MetasCotizador].[dbo].[Cotizaciones]
				INNER JOIN [Usuarios] ON [Cotizaciones].[idUsuarioCotizacion] = [Usuarios].[idUsuarioAdministrador]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].[idListaCotizacion] = [ServiciosEnCotizaciones].[idListaCotizacion]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupServices] ON [ServiciosEnCotizaciones].[idServicio] = [SetupServices].[ServicesId]
				INNER JOIN [LugarCondicion] ON [Cotizaciones].[idLugarCondicion] = [LugarCondicion].[idLugarCondicion]
				INNER JOIN [MonedaCondicion] ON [Cotizaciones].[idMonedaCondicion] = [MonedaCondicion].[idMonedaCondicion]
				INNER JOIN [PagoCondicion] ON [Cotizaciones].[idPagoCondicion] = [PagoCondicion].[idPagoCondicion]
				INNER JOIN [TiemposEntregaCondicion] ON [Cotizaciones].[idTiempoEntregaCondicion] = [TiemposEntregaCondicion].[idTiempoEntregaCondicion]
				INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipmentServiceMapping] ON [SetUpEquipment].[EquipId] =[SetupEquipmentServiceMapping].[EquipId]
                    WHERE [Cotizaciones].NumCot = '" & Val(txtCot.Text) & "'"
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        'While lectorMetasCotizador.Read()
        lectorMetasCotizador.Read()
        desde = lectorMetasCotizador(1)
        MsgBox(desde)
        hasta = lectorMetasCotizador(2)
        MsgBox(hasta)
        nombre = lectorMetasCotizador(3)
        MsgBox(nombre)
        puesto = lectorMetasCotizador(4)
        MsgBox(puesto)
        tel = lectorMetasCotizador(5)
        MsgBox(tel)
        correo = lectorMetasCotizador(6)
        MsgBox(correo)
        emp = lectorMetasCotizador(7)
        MsgBox(emp)
        dom = lectorMetasCotizador(8)
        MsgBox(dom)
        cve = lectorMetasCotizador(17)
        MsgBox(cve)
        cotizo = lectorMetasCotizador(18)
        MsgBox(cotizo)
        lugar = lectorMetasCotizador(19)
        MsgBox(lugar)
        moneda = lectorMetasCotizador(20)
        MsgBox(moneda)
        pago = lectorMetasCotizador(21)
        MsgBox(pago)
        modalidad = lectorMetasCotizador(22)
        MsgBox(modalidad)
        obser = lectorMetasCotizador(23)
        MsgBox(obser)
        calmetho = lectorMetasCotizador(24)
        MsgBox(calmetho)
        services = lectorMetasCotizador(25)
        MsgBox(services)
        domFac = lectorMetasCotizador(26)

        rfc = lectorMetasCotizador(27)
        correoEla = lectorMetasCotizador(28)
        depto = lectorMetasCotizador(29)
        fir = lectorMetasCotizador(27)
        lectorMetasCotizador.Close()
        'MsgBox(rfc)
        'Dim Adaptador As New SqlDataAdapter
        'Adaptador.SelectCommand = New SqlCommand
        'Adaptador.SelectCommand.Connection = conexionMetasCotizador
        'Adaptador.SelectCommand.CommandText = "cotLIMS3"
        'Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        'Dim param1 = New SqlParameter("@numCot", SqlDbType.VarChar)
        'Dim param2 = New SqlParameter("@fechaDesde", SqlDbType.Date)
        'Dim param3 = New SqlParameter("@fechaHasta", SqlDbType.Date)
        'Dim param4 = New SqlParameter("@nombre", SqlDbType.VarChar)
        'Dim param5 = New SqlParameter("@puesto", SqlDbType.VarChar)
        'Dim param6 = New SqlParameter("@telefono", SqlDbType.VarChar)
        'Dim param8 = New SqlParameter("@correo", SqlDbType.VarChar)
        'Dim param9 = New SqlParameter("@com", SqlDbType.VarChar)
        'Dim param10 = New SqlParameter("@dom", SqlDbType.VarChar)
        'Dim param11 = New SqlParameter("@cveElaboro", SqlDbType.Int)
        'Dim param12 = New SqlParameter("@elaborocot", SqlDbType.VarChar)
        'Dim param13 = New SqlParameter("@correoElaboro", SqlDbType.VarChar)
        'Dim param14 = New SqlParameter("@depto", SqlDbType.VarChar)
        'Dim param15 = New SqlParameter("@lugar", SqlDbType.VarChar)
        'Dim param16 = New SqlParameter("@moneda", SqlDbType.VarChar)
        'Dim param17 = New SqlParameter("@pago", SqlDbType.VarChar)
        'Dim param18 = New SqlParameter("@entrega", SqlDbType.VarChar)
        'Dim param19 = New SqlParameter("@modalidad", SqlDbType.VarChar)
        'Dim param20 = New SqlParameter("@obser", SqlDbType.VarChar)
        'Dim param21 = New SqlParameter("@calMetodo", SqlDbType.VarChar)
        'Dim param22 = New SqlParameter("@serDescripcion", SqlDbType.VarChar)
        'Dim param23 = New SqlParameter("@domFactura", SqlDbType.VarChar)
        'Dim param24 = New SqlParameter("@rfc", SqlDbType.VarChar)
        'param2.Direction = ParameterDirection.Input
        'param3.Direction = ParameterDirection.Input
        'param4.Direction = ParameterDirection.Input
        'param5.Direction = ParameterDirection.Input
        'param6.Direction = ParameterDirection.Input
        ''param7.Direction = ParameterDirection.Input
        'param8.Direction = ParameterDirection.Input
        'param9.Direction = ParameterDirection.Input
        'param10.Direction = ParameterDirection.Input
        'param11.Direction = ParameterDirection.Input
        'param12.Direction = ParameterDirection.Input
        'param13.Direction = ParameterDirection.Input
        'param14.Direction = ParameterDirection.Input
        'param15.Direction = ParameterDirection.Input
        'param16.Direction = ParameterDirection.Input
        'param17.Direction = ParameterDirection.Input
        'param18.Direction = ParameterDirection.Input
        'param19.Direction = ParameterDirection.Input
        'param20.Direction = ParameterDirection.Input
        'param21.Direction = ParameterDirection.Input
        'param22.Direction = ParameterDirection.Input
        'param23.Direction = ParameterDirection.Input
        'param24.Direction = ParameterDirection.Input
        'param1.Value = COT
        'param2.Value = desde
        'param3.Value = hasta
        'param4.Value = nombre
        'param5.Value = puesto
        'param6.Value = tel
        ''param7.Value = ext
        'param8.Value = correo
        'param9.Value = emp
        'param10.Value = dom
        'param11.Value = cve
        'param12.Value = cotizo
        'param13.Value = correoEla
        'param14.Value = depto
        'param15.Value = lugar
        'param16.Value = moneda
        'param17.Value = pago
        'param18.Value = entrega
        'param19.Value = modalidad
        'param20.Value = obser
        'param21.Value = calmetho
        'param22.Value = services
        'param23.Value = domFac
        'param24.Value = rfc
        'Adaptador.SelectCommand.Parameters.Add(param1)
        'Adaptador.SelectCommand.Parameters.Add(param2)
        'Adaptador.SelectCommand.Parameters.Add(param3)
        'Adaptador.SelectCommand.Parameters.Add(param4)
        'Adaptador.SelectCommand.Parameters.Add(param5)
        'Adaptador.SelectCommand.Parameters.Add(param6)
        ''Adaptador.SelectCommand.Parameters.Add(param7)
        'Adaptador.SelectCommand.Parameters.Add(param8)
        'Adaptador.SelectCommand.Parameters.Add(param9)
        'Adaptador.SelectCommand.Parameters.Add(param10)
        'Adaptador.SelectCommand.Parameters.Add(param11)
        'Adaptador.SelectCommand.Parameters.Add(param12)
        'Adaptador.SelectCommand.Parameters.Add(param13)
        'Adaptador.SelectCommand.Parameters.Add(param14)
        'Adaptador.SelectCommand.Parameters.Add(param15)
        'Adaptador.SelectCommand.Parameters.Add(param16)
        'Adaptador.SelectCommand.Parameters.Add(param17)
        'Adaptador.SelectCommand.Parameters.Add(param18)
        'Adaptador.SelectCommand.Parameters.Add(param19)
        'Adaptador.SelectCommand.Parameters.Add(param20)
        'Adaptador.SelectCommand.Parameters.Add(param21)
        'Adaptador.SelectCommand.Parameters.Add(param22)
        'Adaptador.SelectCommand.Parameters.Add(param23)
        'Adaptador.SelectCommand.Parameters.Add(param24)
        'Dim Data As New DataSet
        'Adaptador.Fill(Data)
        'Data.DataSetName = "Data1"
        'Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        'Datasource.Name = "DataSet1"
        'Datasource.Value = Data.Tables(0)
        'Dim p1 As New ReportParameter("numCot", COT)
        'Dim p2 As New ReportParameter("fechaDesde", desde)
        'Dim p3 As New ReportParameter("fechaHasta", hasta)
        'Dim p4 As New ReportParameter("nombre", nombre)
        'Dim p5 As New ReportParameter("puesto", puesto)
        'Dim p6 As New ReportParameter("telefono", tel)
        ''Dim p7 As New ReportParameter("ext", ext)
        'Dim p8 As New ReportParameter("correo", correo)
        'Dim p9 As New ReportParameter("com", emp)
        'Dim p10 As New ReportParameter("dom", dom)
        'Dim p11 As New ReportParameter("cveElaboro", cve)
        'Dim p12 As New ReportParameter("elaborocot", cotizo)
        'Dim p13 As New ReportParameter("correoElaboro", correoEla)
        'Dim p14 As New ReportParameter("depto", depto)
        'Dim p15 As New ReportParameter("lugar", lugar)
        'Dim p16 As New ReportParameter("moneda", moneda)
        'Dim p17 As New ReportParameter("pago", pago)
        'Dim p18 As New ReportParameter("entrega", entrega)
        'Dim p19 As New ReportParameter("modalidad", modalidad)
        'Dim p20 As New ReportParameter("obser", obser)
        'Dim p21 As New ReportParameter("calMetodo", calmetho)
        'Dim p22 As New ReportParameter("serDescripcion", services)
        'Dim p23 As New ReportParameter("domFac", domFac)
        'Dim p24 As New ReportParameter("rfc", rfc)

        'Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        'FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        'FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        'FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\cotActualizada.rdlc"
        'FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p8, p9, p10, p11, p12,
        '                                                    p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24})
        'FrmReportes.ReportViewer1.RefreshReport()
        'FrmReportes.Show()
        'conexionMetasCotizador.Close()
    End Sub
End Class