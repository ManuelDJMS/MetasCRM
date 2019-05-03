Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class ImprimirCot
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim COT As Integer
        COT = Val(txtCot.Text)
        MetodoMetasInf2019()
        comando2019 = conexion2019.CreateCommand
        Dim R As String
        R = " SELECT [Contactos-Clientes-Usuarios].Nombre+ ' ' + [Contactos-Clientes-Usuarios].Apellidos as nombre, Cargo, [Contactos-Clientes-Usuarios].Compania, 
                [MetAsInf].DomicilioConsig+' '+ [MetAsInf].CiudadConsig+', '+[MetAsInf].EdoConsig+'. '+ 
                [MetAsInf].PaisConsig +' CP '+ [MetAsInf].CPConsig AS Dom, Tel, Ext, [Contactos-Clientes-Usuarios].Email, EntradaRegistroCot.Numcot, EntradaRegistroCot.ClaveContacto, Fecha,
                [Claves-Elaboro-Cot].[Nombre], [PartidaNo],[Cant],[1Cotizar].[Tipo],[Marca],[Modelo],[1Cotizar].[Alcance],[Punitariocot],[Punitariocot] * [Cant] as subtotal, donde, Precios, [condiciones_pago],
                tentrega, [Condiciones_p_cotizar].modalidad,EntradaRegistroCot.observaciones,[1Cotizar].ServCatalogo,Instrumento,PuntosdeCalibracion,Trazabilidad+ ' - ' +Acreditamiento as Tra,
                MetododeCalibracion,ResultadosInforme,Ajuste,ObservacionTemporal, Depto, [Claves-Elaboro-Cot].Email, [MetAsInf].RFC, [MetAsInf].RazonSocial
                from [MetAsInf] 
                INNER JOIN [Contactos-Clientes-Usuarios] on [Contactos-Clientes-Usuarios].Clavempresa = [MetAsInf].Clavempresa 
                INNER JOIN EntradaRegistroCot on EntradaRegistroCot.ClaveContacto = [Contactos-Clientes-Usuarios].ClaveContacto
                INNER JOIN [1Cotizar] ON EntradaRegistroCot.[Numcot] = [1Cotizar].[Numcot]
                INNER JOIN [Claves-Elaboro-Cot] ON EntradaRegistroCot.[Elaboró Cot] = [Claves-Elaboro-Cot].[Clave-elaboro-cot]
                INNER JOIN [Condiciones_p_cotizar] ON EntradaRegistroCot.[Numcond] = [Condiciones_p_cotizar].[Numcond]
                INNER JOIN [Catalogo-Calibracion-Laboratorios] ON [1Cotizar].ServCatalogo = [Catalogo-Calibracion-Laboratorios].NoCatalogo
            where EntradaRegistroCot.Numcot = '" & Val(txtCot.Text) & "'"
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        lector2019.Read()
        Dim nombre, cargo, Compania, Domicilio, Email, Tel, Ext, elaboroCot, donde, precio, condiciones, entrega, modalidad,
            observaciones, serv, instr, puntos, tra, met, result, ajuste, obser, correo, depto, rfc, razon As String
        Dim clave As Integer
        Dim fecha, vencimiento As Date
        If ((lector2019(0) Is DBNull.Value) OrElse (lector2019(0) Is Nothing)) Then
            nombre = "-"
        Else
            nombre = lector2019(0)
        End If
        If ((lector2019(1) Is DBNull.Value) OrElse (lector2019(1) Is Nothing)) Then
            cargo = "-"
        Else
            cargo = lector2019(1)
        End If
        If ((lector2019(2) Is DBNull.Value) OrElse (lector2019(2) Is Nothing)) Then
            Compania = "-"
        Else
            Compania = lector2019(2)
        End If
        If ((lector2019(3) Is DBNull.Value) OrElse (lector2019(3) Is Nothing)) Then
            Domicilio = "-"
        Else
            Domicilio = lector2019(3)
        End If
        If ((lector2019(4) Is DBNull.Value) OrElse (lector2019(4) Is Nothing)) Then
            Tel = "-"
        Else
            Tel = lector2019(4)
        End If
        If ((lector2019(5) Is DBNull.Value) OrElse (lector2019(5) Is Nothing)) Then
            Ext = "-"
        Else
            Ext = lector2019(5)
        End If
        If ((lector2019(6) Is DBNull.Value) OrElse (lector2019(6) Is Nothing)) Then
            Email = "-"
        Else
            Email = lector2019(6)
        End If
        If ((lector2019(8) Is DBNull.Value) OrElse (lector2019(8) Is Nothing)) Then
            clave = "-"
        Else
            clave = Val(lector2019(8).ToString)
        End If
        If ((lector2019(9) Is DBNull.Value) OrElse (lector2019(9) Is Nothing)) Then
            fecha = "-"
        Else
            fecha = lector2019(9)
        End If
        If ((lector2019(10) Is DBNull.Value) OrElse (lector2019(10) Is Nothing)) Then
            elaboroCot = "-"
        Else
            elaboroCot = lector2019(10)
        End If
        If ((lector2019(19) Is DBNull.Value) OrElse (lector2019(19) Is Nothing)) Then
            donde = "-"
        Else
            donde = lector2019(19)
        End If
        If ((lector2019(20) Is DBNull.Value) OrElse (lector2019(20) Is Nothing)) Then
            precio = "-"
        Else
            precio = lector2019(20)
        End If
        If ((lector2019(21) Is DBNull.Value) OrElse (lector2019(21) Is Nothing)) Then
            condiciones = "-"
        Else
            condiciones = lector2019(21)
        End If
        If ((lector2019(22) Is DBNull.Value) OrElse (lector2019(22) Is Nothing)) Then
            entrega = "-"
        Else
            entrega = lector2019(22)
        End If
        If ((lector2019(23) Is DBNull.Value) OrElse (lector2019(23) Is Nothing)) Then
            modalidad = "-"
        Else
            modalidad = lector2019(23)
        End If
        If ((lector2019(24) Is DBNull.Value) OrElse (lector2019(24) Is Nothing)) Then
            observaciones = "-"
        Else
            observaciones = lector2019(24)
        End If
        If ((lector2019(25) Is DBNull.Value) OrElse (lector2019(25) Is Nothing)) Then
            serv = "-"
        Else
            serv = lector2019(25)
        End If
        If ((lector2019(26) Is DBNull.Value) OrElse (lector2019(26) Is Nothing)) Then
            instr = "-"
        Else
            instr = lector2019(26)
        End If
        If ((lector2019(27) Is DBNull.Value) OrElse (lector2019(27) Is Nothing)) Then
            puntos = "-"
        Else
            puntos = lector2019(27)
        End If
        If ((lector2019(28) Is DBNull.Value) OrElse (lector2019(28) Is Nothing)) Then
            tra = "-"
        Else
            tra = lector2019(28)
        End If
        If ((lector2019(29) Is DBNull.Value) OrElse (lector2019(29) Is Nothing)) Then
            met = "-"
        Else
            met = lector2019(29)
        End If
        If ((lector2019(30) Is DBNull.Value) OrElse (lector2019(30) Is Nothing)) Then
            result = "-"
        Else
            result = lector2019(30)
        End If
        If ((lector2019(31) Is DBNull.Value) OrElse (lector2019(31) Is Nothing)) Then
            ajuste = "-"
        Else
            ajuste = lector2019(31)
        End If
        If ((lector2019(32) Is DBNull.Value) OrElse (lector2019(32) Is Nothing)) Then
            obser = "-"
        Else
            obser = lector2019(32)
        End If
        If ((lector2019(33) Is DBNull.Value) OrElse (lector2019(33) Is Nothing)) Then
            depto = "-"
        Else
            depto = lector2019(33)
        End If
        If ((lector2019(34) Is DBNull.Value) OrElse (lector2019(34) Is Nothing)) Then
            correo = "-"
        Else
            correo = lector2019(34)
        End If
        If ((lector2019(35) Is DBNull.Value) OrElse (lector2019(35) Is Nothing)) Then
            rfc = "-"
        Else
            rfc = lector2019(35)
        End If
        If ((lector2019(36) Is DBNull.Value) OrElse (lector2019(36) Is Nothing)) Then
            razon = "-"
        Else
            razon = lector2019(36)
        End If
        lector2019.Close()
        vencimiento = fecha.AddDays(30)
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion2019
        Adaptador.SelectCommand.CommandText = "ECliente"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@cot", SqlDbType.VarChar)
        Dim param2 = New SqlParameter("@nombre", SqlDbType.VarChar)
        Dim param3 = New SqlParameter("@cargo", SqlDbType.VarChar)
        Dim param4 = New SqlParameter("@empresa", SqlDbType.VarChar)
        Dim param5 = New SqlParameter("@dom", SqlDbType.VarChar)
        Dim param10 = New SqlParameter("@tel", SqlDbType.VarChar)
        Dim param11 = New SqlParameter("@ext", SqlDbType.VarChar)
        Dim param12 = New SqlParameter("@correo", SqlDbType.VarChar)
        Dim param13 = New SqlParameter("@clave", SqlDbType.VarChar)
        Dim param14 = New SqlParameter("@fecha", SqlDbType.Date)
        Dim param15 = New SqlParameter("@vencimiento", SqlDbType.Date)
        Dim param16 = New SqlParameter("@elaboroCot", SqlDbType.VarChar)
        Dim param17 = New SqlParameter("@donde", SqlDbType.VarChar)
        Dim param18 = New SqlParameter("@precio", SqlDbType.VarChar)
        Dim param19 = New SqlParameter("@condiciones", SqlDbType.VarChar)
        Dim param20 = New SqlParameter("@entrega", SqlDbType.VarChar)
        Dim param21 = New SqlParameter("@modalidad", SqlDbType.VarChar)
        Dim param22 = New SqlParameter("@observaciones", SqlDbType.VarChar)
        Dim param23 = New SqlParameter("@servCat", SqlDbType.VarChar)
        Dim param24 = New SqlParameter("@instru", SqlDbType.VarChar)
        Dim param25 = New SqlParameter("@puntos", SqlDbType.VarChar)
        Dim param26 = New SqlParameter("@trazabilidad", SqlDbType.VarChar)
        Dim param27 = New SqlParameter("@metodo", SqlDbType.VarChar)
        Dim param28 = New SqlParameter("@result", SqlDbType.VarChar)
        Dim param29 = New SqlParameter("@ajuste", SqlDbType.VarChar)
        Dim param30 = New SqlParameter("@oTemp", SqlDbType.VarChar)
        Dim param31 = New SqlParameter("@depto", SqlDbType.VarChar)
        Dim param32 = New SqlParameter("@emailG", SqlDbType.VarChar)
        Dim param33 = New SqlParameter("@rfc", SqlDbType.VarChar)
        Dim param34 = New SqlParameter("@razon", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param3.Direction = ParameterDirection.Input
        param4.Direction = ParameterDirection.Input
        param5.Direction = ParameterDirection.Input
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
        param25.Direction = ParameterDirection.Input
        param26.Direction = ParameterDirection.Input
        param27.Direction = ParameterDirection.Input
        param28.Direction = ParameterDirection.Input
        param29.Direction = ParameterDirection.Input
        param30.Direction = ParameterDirection.Input
        param31.Direction = ParameterDirection.Input
        param32.Direction = ParameterDirection.Input
        param33.Direction = ParameterDirection.Input
        param34.Direction = ParameterDirection.Input
        param1.Value = COT
        param2.Value = nombre
        param3.Value = cargo
        param4.Value = Compania
        param5.Value = Domicilio
        param10.Value = Tel
        param11.Value = Ext
        param12.Value = Email
        param13.Value = clave
        param14.Value = fecha
        param15.Value = vencimiento
        param16.Value = elaboroCot
        param17.Value = donde
        param18.Value = precio
        param19.Value = condiciones
        param20.Value = entrega
        param21.Value = modalidad
        param22.Value = observaciones
        param23.Value = serv
        param24.Value = instr
        param25.Value = puntos
        param26.Value = tra
        param27.Value = met
        param28.Value = result
        param29.Value = ajuste
        param30.Value = obser
        param31.Value = depto
        param32.Value = correo
        param33.Value = rfc
        param34.Value = razon
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)
        Adaptador.SelectCommand.Parameters.Add(param3)
        Adaptador.SelectCommand.Parameters.Add(param4)
        Adaptador.SelectCommand.Parameters.Add(param5)
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
        Adaptador.SelectCommand.Parameters.Add(param25)
        Adaptador.SelectCommand.Parameters.Add(param26)
        Adaptador.SelectCommand.Parameters.Add(param27)
        Adaptador.SelectCommand.Parameters.Add(param28)
        Adaptador.SelectCommand.Parameters.Add(param29)
        Adaptador.SelectCommand.Parameters.Add(param30)
        Adaptador.SelectCommand.Parameters.Add(param31)
        Adaptador.SelectCommand.Parameters.Add(param32)
        Adaptador.SelectCommand.Parameters.Add(param33)
        Adaptador.SelectCommand.Parameters.Add(param34)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("numcot", COT)
        Dim p2 As New ReportParameter("nombre", nombre)
        Dim p3 As New ReportParameter("cargo", cargo)
        Dim p4 As New ReportParameter("empresa", Compania)
        Dim p5 As New ReportParameter("dom", Domicilio)
        Dim p10 As New ReportParameter("tel", Tel)
        Dim p11 As New ReportParameter("ext", Ext)
        Dim p12 As New ReportParameter("correo", Email)
        Dim p13 As New ReportParameter("clave", clave)
        Dim p14 As New ReportParameter("fecha", fecha)
        Dim p15 As New ReportParameter("vencimiento", vencimiento)
        Dim p16 As New ReportParameter("elaboroCot", elaboroCot)
        Dim p17 As New ReportParameter("donde", donde)
        Dim p18 As New ReportParameter("precio", precio)
        Dim p19 As New ReportParameter("condiciones", condiciones)
        Dim p20 As New ReportParameter("entrega", entrega)
        Dim p21 As New ReportParameter("modalidad", modalidad)
        Dim p22 As New ReportParameter("observaciones", observaciones)
        Dim p23 As New ReportParameter("Serv", serv)
        Dim p24 As New ReportParameter("instrumento", instr)
        Dim p25 As New ReportParameter("puntos", puntos)
        Dim p26 As New ReportParameter("trazabilidad", tra)
        Dim p27 As New ReportParameter("metodo", met)
        Dim p28 As New ReportParameter("resultado", result)
        Dim p29 As New ReportParameter("ajuste", ajuste)
        Dim p30 As New ReportParameter("temporal", obser)
        Dim p31 As New ReportParameter("depto", depto)
        Dim p32 As New ReportParameter("emailG", correo)
        Dim p33 As New ReportParameter("rfc", rfc)
        Dim p34 As New ReportParameter("razon", razon)
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\cot.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p2, p3, p4, p5, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34})
        FrmReportes.ReportViewer1.RefreshReport()
        FrmReportes.Show()
        conexion2019.Close()
    End Sub
End Class








