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
        R = "SELECT [Contactos-Clientes-Usuarios].Nombre+ ' ' + [Contactos-Clientes-Usuarios].Apellidos as nombre, Cargo, [Contactos-Clientes-Usuarios].Compania, 
            [MetAsInf].DomicilioConsig+' '+ [MetAsInf].CiudadConsig+', '+[MetAsInf].EdooProv+'. '+ 
            [MetAsInf].PaisConsig +' CP '+ [MetAsInf].CPConsig AS Dom, Tel, Ext, [Contactos-Clientes-Usuarios].Email, EntradaRegistroCot.Numcot, EntradaRegistroCot.ClaveContacto, Fecha,
            [Claves-Elaboro-Cot].[Nombre], [PartidaNo],[Cant],[Tipo],[Marca],[Modelo],[Alcance],[Punitariocot],[Punitariocot] * [Cant] as subtotal  
            from [MetAsInf] 
            INNER JOIN [Contactos-Clientes-Usuarios] on [Contactos-Clientes-Usuarios].Clavempresa = [MetAsInf].Clavempresa 
            INNER JOIN EntradaRegistroCot on EntradaRegistroCot.ClaveContacto = [Contactos-Clientes-Usuarios].ClaveContacto
            INNER JOIN [1Cotizar] ON EntradaRegistroCot.[Numcot] = [1Cotizar].[Numcot]
            INNER JOIN [Claves-Elaboro-Cot] ON EntradaRegistroCot.[Elaboró Cot] = [Claves-Elaboro-Cot].[Clave-elaboro-cot] where EntradaRegistroCot.Numcot = '" & Val(txtCot.Text) & "'"
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        lector2019.Read()
        Dim nombre, cargo, Compania, Domicilio, Email, Tel, Ext, elaboroCot As String
        Dim clave As Integer
        Dim fecha, vencimiento As Date
        nombre = lector2019(0)
        cargo = lector2019(1)
        Compania = lector2019(2)
        Domicilio = lector2019(3)
        Tel = lector2019(4)
        Ext = lector2019(5)
        Email = lector2019(6)
        clave = Val(lector2019(8).ToString)
        fecha = lector2019(9)
        elaboroCot = lector2019(10)
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
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\cot.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p2, p3, p4, p5, p10, p11, p12, p13, p14, p15, p16})
        FrmReportes.ReportViewer1.RefreshReport()
        FrmReportes.Show()
        conexion2019.Close()
    End Sub
End Class








