Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class cotLIMS
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim COT As Integer
        COT = Val(txtCot.Text)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        Dim n As Integer = 0
        Dim desde, hasta As Date
        Dim nombre, puesto, tel, ext, correo, emp, dom, partida, can, equipId, Name, modelo, marca, item, acc As String
        Dim id As Integer
        Dim R As String
        R = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta, Nombre + ' ' + Apellidos as Nombre,Puesto, Telefono, Ext, Correo,
                [Empresas].Compania,DomicilioConsig,PartidaNo, Cantidad,EquipId
                from [MetasCotizador].[dbo].[Cotizaciones] 
                INNER JOIN [Prospectos] ON [Cotizaciones].idContacto =[Prospectos].[idProspecto]
                INNER JOIN [Empresas] ON  [Prospectos].idClaveEmpresa = [Empresas].Clavempresa
                INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot             
                WHERE [Cotizaciones].NumCot = '" & Val(txtCot.Text) & "'"
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        'While lectorMetasCotizador.Read()
        lectorMetasCotizador.Read()
        If ((lectorMetasCotizador(1) Is DBNull.Value) OrElse (lectorMetasCotizador(1) Is Nothing)) Then
                desde = "-"
            Else
                desde = lectorMetasCotizador(1)
            End If
        'MsgBox(desde)
        If ((lectorMetasCotizador(2) Is DBNull.Value) OrElse (lectorMetasCotizador(2) Is Nothing)) Then
                hasta = "-"
            Else
                hasta = lectorMetasCotizador(2)
            End If
        'MsgBox(hasta)
        If ((lectorMetasCotizador(3) Is DBNull.Value) OrElse (lectorMetasCotizador(3) Is Nothing)) Then
                nombre = "-"
            Else
                nombre = lectorMetasCotizador(3)
            End If
        'MsgBox(nombre)
        If ((lectorMetasCotizador(4) Is DBNull.Value) OrElse (lectorMetasCotizador(4) Is Nothing)) Then
                puesto = "-"
            Else
                puesto = lectorMetasCotizador(4)
            End If
        'MsgBox(puesto)
        If ((lectorMetasCotizador(5) Is DBNull.Value) OrElse (lectorMetasCotizador(5) Is Nothing)) Then
                tel = "-"
            Else
                tel = lectorMetasCotizador(5)
            End If
        ' MsgBox(tel)
        If ((lectorMetasCotizador(6) Is DBNull.Value) OrElse (lectorMetasCotizador(6) Is Nothing)) Then
                ext = "-"
            Else
                ext = lectorMetasCotizador(6)
            End If
        'MsgBox(ext)
        If ((lectorMetasCotizador(7) Is DBNull.Value) OrElse (lectorMetasCotizador(7) Is Nothing)) Then
                correo = "-"
            Else
                correo = lectorMetasCotizador(7)
            End If
        'MsgBox(correo)
        If ((lectorMetasCotizador(8) Is DBNull.Value) OrElse (lectorMetasCotizador(8) Is Nothing)) Then
                emp = "-"
            Else
                emp = lectorMetasCotizador(8)
            End If
        ' MsgBox(emp)
        If ((lectorMetasCotizador(9) Is DBNull.Value) OrElse (lectorMetasCotizador(9) Is Nothing)) Then
                dom = "-"
            Else
                dom = lectorMetasCotizador(9)
            End If
        'MsgBox(dom)
        If ((lectorMetasCotizador(10) Is DBNull.Value) OrElse (lectorMetasCotizador(10) Is Nothing)) Then
                partida = "-"
            Else
                partida = lectorMetasCotizador(10)
            End If
        'MsgBox(partida)
        If ((lectorMetasCotizador(11) Is DBNull.Value) OrElse (lectorMetasCotizador(11) Is Nothing)) Then
                can = "-"
            Else
                can = lectorMetasCotizador(11)
            End If
        'MsgBox(can)
        If ((lectorMetasCotizador(12) Is DBNull.Value) OrElse (lectorMetasCotizador(12) Is Nothing)) Then
            equipId = "-"
        Else
            equipId = lectorMetasCotizador(12)
        End If
        'MsgBox(equipId)
        MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            Dim L As String
        L = "SELECT EquipId,EquipmentName, Model, Mfr,ItemNumber,Accuracy from SetUpEquipment
                WHERE EquipId = '" & equipId & "'"
        'MsgBox(L)
        comandoLIMS.CommandText = L
            lectorLIMS = comandoLIMS.ExecuteReader
            lectorLIMS.Read()
            id = Val(lectorLIMS(0))
            Name = lectorLIMS(1)
            If ((lectorLIMS(2) Is DBNull.Value) OrElse (lectorLIMS(2) Is Nothing)) Then
                modelo = "-"
            Else
                modelo = lectorLIMS(2)
            End If
            marca = lectorLIMS(3)
        item = lectorLIMS(4)
        acc = lectorLIMS(5)
        'MsgBox(id)
        'MsgBox(Name)
        'MsgBox(modelo)
        'MsgBox(marca)
        'MsgBox(item)
        n = n + 1
        'End While
        lectorLIMS.Close()
        lectorMetasCotizador.Close()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexionMetasCotizador
        Adaptador.SelectCommand.CommandText = "cotLIMS"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@numCot", SqlDbType.VarChar)
        Dim param2 = New SqlParameter("@fechaDesde", SqlDbType.Date)
        Dim param3 = New SqlParameter("@fechaHasta", SqlDbType.Date)
        Dim param4 = New SqlParameter("@nombre", SqlDbType.VarChar)
        Dim param5 = New SqlParameter("@puesto", SqlDbType.VarChar)
        Dim param6 = New SqlParameter("@telefono", SqlDbType.VarChar)
        Dim param7 = New SqlParameter("@ext", SqlDbType.VarChar)
        Dim param8 = New SqlParameter("@correo", SqlDbType.VarChar)
        Dim param9 = New SqlParameter("@com", SqlDbType.VarChar)
        Dim param10 = New SqlParameter("@dom", SqlDbType.VarChar)
        Dim param11 = New SqlParameter("@partidad", SqlDbType.Int)
        Dim param12 = New SqlParameter("@cant", SqlDbType.Int)
        Dim param13 = New SqlParameter("@equiId", SqlDbType.Int)
        Dim param14 = New SqlParameter("@marca", SqlDbType.VarChar)
        Dim param15 = New SqlParameter("@modelo", SqlDbType.VarChar)
        Dim param16 = New SqlParameter("@acc", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param3.Direction = ParameterDirection.Input
        param4.Direction = ParameterDirection.Input
        param5.Direction = ParameterDirection.Input
        param6.Direction = ParameterDirection.Input
        param7.Direction = ParameterDirection.Input
        param8.Direction = ParameterDirection.Input
        param9.Direction = ParameterDirection.Input
        param10.Direction = ParameterDirection.Input
        param11.Direction = ParameterDirection.Input
        param12.Direction = ParameterDirection.Input
        param13.Direction = ParameterDirection.Input
        param14.Direction = ParameterDirection.Input
        param15.Direction = ParameterDirection.Input
        param16.Direction = ParameterDirection.Input
        param1.Value = COT
        param2.Value = desde
        param3.Value = hasta
        param4.Value = nombre
        param5.Value = puesto
        param6.Value = tel
        param7.Value = ext
        param8.Value = correo
        param9.Value = emp
        param10.Value = dom
        param11.Value = partida
        param12.Value = can
        param13.Value = equipId
        param14.Value = marca
        param15.Value = modelo
        param16.Value = acc
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)
        Adaptador.SelectCommand.Parameters.Add(param3)
        Adaptador.SelectCommand.Parameters.Add(param4)
        Adaptador.SelectCommand.Parameters.Add(param5)
        Adaptador.SelectCommand.Parameters.Add(param6)
        Adaptador.SelectCommand.Parameters.Add(param7)
        Adaptador.SelectCommand.Parameters.Add(param8)
        Adaptador.SelectCommand.Parameters.Add(param9)
        Adaptador.SelectCommand.Parameters.Add(param10)
        Adaptador.SelectCommand.Parameters.Add(param11)
        Adaptador.SelectCommand.Parameters.Add(param12)
        Adaptador.SelectCommand.Parameters.Add(param13)
        Adaptador.SelectCommand.Parameters.Add(param14)
        Adaptador.SelectCommand.Parameters.Add(param15)
        Adaptador.SelectCommand.Parameters.Add(param16)
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
        Dim p5 As New ReportParameter("cargo", puesto)
        Dim p6 As New ReportParameter("tel", tel)
        Dim p7 As New ReportParameter("ext", ext)
        Dim p8 As New ReportParameter("correo", correo)
        Dim p9 As New ReportParameter("empresa", emp)
        Dim p10 As New ReportParameter("dom", dom)
        Dim p11 As New ReportParameter("partidad", partida)
        Dim p12 As New ReportParameter("cantidad", can)
        Dim p13 As New ReportParameter("EquipId", equipId)
        Dim p14 As New ReportParameter("marca", marca)
        Dim p15 As New ReportParameter("modelo", modelo)
        Dim p16 As New ReportParameter("descripcion", acc)
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\a.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16})
        FrmReportes.ReportViewer1.RefreshReport()
        FrmReportes.Show()
        conexionMetasCotizador.Close()
    End Sub
End Class