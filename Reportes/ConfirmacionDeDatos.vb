Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.Reflection
Public Class ConfirmacionDeDatos
    Private Sub cmdBuscar_Click_1(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim OV, numGuia As Integer
        OV = Val(txtOV.Text)
        numGuia = Val(txtNumGuia.Text)
        MetodoLIMS()
        MetodoMetasInf2019()
        comandoLIMS = conexionLIMS.CreateCommand
        'Dim fechaRecep As Date
        Dim razonSocial, rfc, domFacturacion, cdFac, estFac, paisFac, Compania, domContacto, cdCont, cpCon, estCont, paisCont,
               envio, domEnvio, cdEnvio, estEvi, CpEnvio, customerId, cusAccount, cpFac, Email As String
        'Dim customerId, cusAccount, cpFac As Integer
        Dim R As String
        R = "SELECT  [SOId],[SetupCustomerAddressDtls].[CustomerId],[SetupCustomerDetails].[CustAccountNo], [Organization] AS RZ,[TaxIDNo], [BillAddress1]+' '+[BillAddress2] +' '+[BillAddress3] AS DomFacturacion, [BillCity],[BillState],[BillZip],[BillCountry],
		[CompanyName],[ContAddress1] + ' '+ [ContAddress2] +' '+[ContAddress3] AS domContacto,[ContCity],[ContState],[ContZip],[ContCountry],[SalesOrderDetails].[ShipVia],
        [SalesOrderDetails].[ShipAddress1] +' '+[SalesOrderDetails].[ShipAddress2] +' '+[SalesOrderDetails].[ShipAddress3]AS domEnvio,[SalesOrderDetails].[ShipCity],[SalesOrderDetails].[ShipState],[SalesOrderDetails].[ShipZip], Email
        FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails]
        INNER JOIN [SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
        INNER JOIN [SalesOrderDetails] ON [SetupCustomerDetails].[CustomerId] =  [SalesOrderDetails].[CustomerId] where [SOId] ='" & OV & "'"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        lectorLIMS.Read()
        customerId = lectorLIMS(1)
        'MsgBox(customerId)
        cusAccount = lectorLIMS(2)
        'MsgBox(cusAccount)
        razonSocial = lectorLIMS(3)
        'MsgBox(razonSocial)
        rfc = lectorLIMS(4)
        'MsgBox(rfc)
        domFacturacion = lectorLIMS(5)
        'MsgBox(domFacturacion)
        cdFac = lectorLIMS(6)
        'MsgBox(cdFac)
        estFac = lectorLIMS(7)
        'MsgBox(estFac)
        cpFac = lectorLIMS(8)
        '  MsgBox(cpFac)
        paisFac = lectorLIMS(9)
        'MsgBox(paisFac)
        Compania = lectorLIMS(10)
        'MsgBox(Compania)
        domContacto = lectorLIMS(11)
        'MsgBox(domContacto)
        cdCont = lectorLIMS(12)
        'MsgBox(cdCont)
        estCont = lectorLIMS(13)
        'MsgBox(estCont)
        cpCon = lectorLIMS(14)
        'MsgBox(cpCon)
        paisCont = lectorLIMS(15)
        'MsgBox(paisCont)
        envio = lectorLIMS(16)
        'MsgBox(envio)
        Email = lectorLIMS(21)
        If lectorLIMS(16) = "" Then
            MessageBox.Show("Los datos de envío de la orden de venta " & OV & " aun no estan registrados en LIMS", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            domEnvio = lectorLIMS(17)
            'MsgBox(domEnvio)
            cdEnvio = lectorLIMS(18)
            'MsgBox(cdEnvio)
            estEvi = lectorLIMS(19)
            'MsgBox(estEvi)
            CpEnvio = lectorLIMS(20)
            'MsgBox(CpEnvio)
            conexionLIMS.Close()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexionLIMS
            Adaptador.SelectCommand.CommandText = "ConfirmacionDeDatos"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@SOId", SqlDbType.VarChar)
            Dim param2 = New SqlParameter("@customerId", SqlDbType.VarChar)
            Dim param3 = New SqlParameter("@cusAccount", SqlDbType.VarChar)
            Dim param4 = New SqlParameter("@razonSocial", SqlDbType.VarChar)
            Dim param5 = New SqlParameter("@rfc", SqlDbType.VarChar)
            Dim param6 = New SqlParameter("@facDom", SqlDbType.VarChar)
            Dim param7 = New SqlParameter("@facCiudad", SqlDbType.VarChar)
            Dim param8 = New SqlParameter("@facEstado", SqlDbType.VarChar)
            Dim param9 = New SqlParameter("@facCP", SqlDbType.VarChar)
            Dim param10 = New SqlParameter("@facPais", SqlDbType.VarChar)
            Dim param11 = New SqlParameter("@nomCertificado", SqlDbType.VarChar)
            Dim param12 = New SqlParameter("@CertDom", SqlDbType.VarChar)
            Dim param13 = New SqlParameter("@CertCiudad", SqlDbType.VarChar)
            Dim param14 = New SqlParameter("@CertEstado", SqlDbType.VarChar)
            Dim param15 = New SqlParameter("@CertCP", SqlDbType.VarChar)
            Dim param16 = New SqlParameter("@CertPais", SqlDbType.VarChar)
            Dim param17 = New SqlParameter("@EnvioPor", SqlDbType.VarChar)
            Dim param18 = New SqlParameter("@EnvDom", SqlDbType.VarChar)
            Dim param19 = New SqlParameter("@EnvCiudad", SqlDbType.VarChar)
            Dim param20 = New SqlParameter("@EnvEstado", SqlDbType.VarChar)
            Dim param21 = New SqlParameter("@EnvCP", SqlDbType.VarChar)
            Dim param22 = New SqlParameter("@numGuia", SqlDbType.VarChar)
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
            param17.Direction = ParameterDirection.Input
            param18.Direction = ParameterDirection.Input
            param19.Direction = ParameterDirection.Input
            param20.Direction = ParameterDirection.Input
            param21.Direction = ParameterDirection.Input
            param22.Direction = ParameterDirection.Input
            param1.Value = OV
            param2.Value = customerId
            param3.Value = cusAccount
            param4.Value = razonSocial
            param5.Value = rfc
            param6.Value = domFacturacion
            param7.Value = cdFac
            param8.Value = estFac
            param9.Value = cpFac
            param10.Value = paisFac
            param11.Value = Compania
            param12.Value = domContacto
            param13.Value = cdCont
            param14.Value = estCont
            param15.Value = cpCon
            param16.Value = paisCont
            param17.Value = envio
            param18.Value = domEnvio
            param19.Value = cdEnvio
            param20.Value = estEvi
            param21.Value = CpEnvio
            param22.Value = numGuia
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
            Adaptador.SelectCommand.Parameters.Add(param17)
            Adaptador.SelectCommand.Parameters.Add(param18)
            Adaptador.SelectCommand.Parameters.Add(param19)
            Adaptador.SelectCommand.Parameters.Add(param20)
            Adaptador.SelectCommand.Parameters.Add(param21)
            Adaptador.SelectCommand.Parameters.Add(param22)
            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("SOId", OV)
            Dim p2 As New ReportParameter("customerId", customerId)
            Dim p3 As New ReportParameter("cusAccount", cusAccount)
            Dim p4 As New ReportParameter("razonSocial", razonSocial)
            Dim p5 As New ReportParameter("rfc", rfc)
            Dim p6 As New ReportParameter("facDom", domFacturacion)
            Dim p7 As New ReportParameter("facCiudad", cdFac)
            Dim p8 As New ReportParameter("facEstado", estFac)
            Dim p9 As New ReportParameter("facCP", cpFac)
            Dim p10 As New ReportParameter("facPais", paisFac)
            Dim p11 As New ReportParameter("nomCertificado", Compania)
            Dim p12 As New ReportParameter("CertDom", domContacto)
            Dim p13 As New ReportParameter("CertCiudad", cdCont)
            Dim p14 As New ReportParameter("CertEstado", estCont)
            Dim p15 As New ReportParameter("CertCP", cpCon)
            Dim p16 As New ReportParameter("CertPais", paisCont)
            Dim p17 As New ReportParameter("EnvioPor", envio)
            Dim p18 As New ReportParameter("EnvDom", domEnvio)
            Dim p19 As New ReportParameter("EnvCiudad", cdEnvio)
            Dim p20 As New ReportParameter("EnvEstado", estEvi)
            Dim p21 As New ReportParameter("EnvCP", CpEnvio)
            Dim p22 As New ReportParameter("numGuia", numGuia)
            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
            FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\ConfirmacionDeDatos.rdlc"
            FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22})
            FrmReportes.ReportViewer1.RefreshReport()
            Dim nombreConfirmacion As String = "Confirmacion-OV-"
            nombreConfirmacion = nombreConfirmacion + OV.ToString
            'MsgBox(nombreConfirmacion)
            'Me.ReportEmbeddedResource = "MyAppNamespace.CotizacionModelo.rdlc"
            FrmReportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "MyAppNamespace.ConfirmacionDeDatos.rdlc"
            Dim pdfContent As Byte() = FrmReportes.ReportViewer1.LocalReport.Render("PDF")
            Dim pdfPath As String = "C:\Users\Software TI\Desktop\REPORTES\" & nombreConfirmacion & ".pdf"
            Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent, 0, pdfContent.Length)
            'pdfFile.Close()
            conexionLIMS.Close()







            MetodoLIMS()
            MetodoMetasInf2019()
            comandoLIMS = conexionLIMS.CreateCommand
            'Dim fechaRecep As Date
            Dim customerID2, cliente2, companyName2, telefono2, emanil2, terminosPago2 As String
            'Dim customerId, cusAccount, cpFac As Integer
            R = "SELECT [SalesOrderDetails].[SOId],[SalesOrderDetails].[CustomerId], [CompanyName],[FirstName] + ' ' + [MiddleName]+' '+[LastName] AS Cliente, [Phone], [Email], 
                    [SetupCustomerDetails].[PaymentTerms],ROW_NUMBER() OVER(ORDER BY [SalesOrderDetails].SOId ASC) AS Partidad, WOId, [WorkOrderDetails].[CustEquipMapId],[SetupCustomerEquipmentMapping].[InstrumentId], 
                    [EquipmentName]+','+[Model]+ '.  ' +[Mfr]+''+[SetupCustomerEquipmentMapping].[SrlNo] AS Equipo, [Accuracy], [Uncertainity], isnull([LabInst],'') as Accesorios
                    FROM [MetAs_Live-pruebas].[dbo].[SalesOrderDetails]
                    INNER JOIN [SetupCustomerDetails] ON [SalesOrderDetails].[CustomerId] = [SetupCustomerDetails].[CustomerId]
                    INNER JOIN [WorkOrderDetails] ON [SalesOrderDetails].[SOId] = [WorkOrderDetails].[SOId]
                    INNER JOIN [SetupCustomerEquipmentMapping] ON [WorkOrderDetails].[CustEquipMapId] = [SetupCustomerEquipmentMapping].[CustEquipMapId]
                    INNER JOIN [SetUpEquipment] ON [SetupCustomerEquipmentMapping].[EquipId] =  [SetUpEquipment].[EquipId] WHERE [SalesOrderDetails].[SOId] ='" & OV & "'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            lectorLIMS.Read()
            customerID2 = lectorLIMS(1)
            'MsgBox(customerID2)
            companyName2 = lectorLIMS(2)
            'MsgBox(companyName2)
            cliente2 = lectorLIMS(3)
            'MsgBox(cliente2)
            telefono2 = lectorLIMS(4)
            'MsgBox(telefono2)
            emanil2 = lectorLIMS(5)
            'MsgBox(emanil2)
            terminosPago2 = lectorLIMS(6)
            'MsgBox(terminosPago2)
            conexionLIMS.Close()

            Dim Adaptador2 As New SqlDataAdapter
            Adaptador2.SelectCommand = New SqlCommand
            Adaptador2.SelectCommand.Connection = conexionLIMS
            Adaptador2.SelectCommand.CommandText = "FormaDeTransito"
            Adaptador2.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1a = New SqlParameter("@SOId", SqlDbType.VarChar)
            Dim param2a = New SqlParameter("@CustomerId", SqlDbType.VarChar)
            Dim param7a = New SqlParameter("@Cliente", SqlDbType.VarChar)
            Dim param3a = New SqlParameter("@CompanyName", SqlDbType.VarChar)
            Dim param4a = New SqlParameter("@telefono", SqlDbType.VarChar)
            Dim param5a = New SqlParameter("@Email", SqlDbType.VarChar)
            Dim param6a = New SqlParameter("@terminosPago", SqlDbType.VarChar)
            param1a.Direction = ParameterDirection.Input
            param2a.Direction = ParameterDirection.Input
            param3a.Direction = ParameterDirection.Input
            param4a.Direction = ParameterDirection.Input
            param5a.Direction = ParameterDirection.Input
            param6a.Direction = ParameterDirection.Input
            param7a.Direction = ParameterDirection.Input
            param1a.Value = OV
            param2a.Value = customerID2
            param3a.Value = companyName2
            param4a.Value = telefono2
            param5a.Value = emanil2
            param6a.Value = terminosPago2
            param7a.Value = cliente2
            Adaptador2.SelectCommand.Parameters.Add(param1a)
            Adaptador2.SelectCommand.Parameters.Add(param2a)
            Adaptador2.SelectCommand.Parameters.Add(param3a)
            Adaptador2.SelectCommand.Parameters.Add(param4a)
            Adaptador2.SelectCommand.Parameters.Add(param5a)
            Adaptador2.SelectCommand.Parameters.Add(param6a)
            Adaptador2.SelectCommand.Parameters.Add(param7a)
            Dim Data2 As New DataSet
            Adaptador2.Fill(Data2)
            Data.DataSetName = "Data1"
            Dim Datasource2 As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1a As New ReportParameter("SOId", OV)
            Dim p2a As New ReportParameter("CustomerId", customerID2)
            Dim p3a As New ReportParameter("CompanyName", cliente2)
            Dim p4a As New ReportParameter("telefono", telefono2)
            Dim p5a As New ReportParameter("Email", emanil2)
            Dim p6a As New ReportParameter("terminosPago", terminosPago2)
            Dim p7a As New ReportParameter("Cliente", terminosPago2)
            Dim Reportes2 As New ReportDataSource("DataSet1", Data.Tables(0))
            FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\FomaDeTransito.rdlc"
            FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1a, p2a, p3a, p4a, p5a, p6a, p7a})
            FrmReportes.ReportViewer1.RefreshReport()
            Dim nombreFormaTransito As String = "Forma-de-Transito-OV-"
            nombreFormaTransito = nombreFormaTransito + OV.ToString
            MsgBox(nombreFormaTransito)
            FrmReportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "MyAppNamespace.FomaDeTransito.rdlc"
            Dim pdfContent2 As Byte() = FrmReportes.ReportViewer1.LocalReport.Render("PDF")
            Dim pdfPath2 As String = "C:\Users\Software TI\Desktop\REPORTES\Forma_Transito\" & nombreFormaTransito & ".pdf"
            Dim pdfFile2 As New System.IO.FileStream(pdfPath2, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent2, 0, pdfContent2.Length)
            pdfFile.Close()
            '------------------------------GENERACION DE LA NOTIFICACIÓN 2------------------------------------------------------
            Dim objOutlook As Object
            Dim objOutlookMsg As Object
            R = "<html xmlns:v='urn:schemas-microsoft-com:vml'
                        xmlns:o='urn:schemas-microsoft-com:office:office'
                        xmlns:w='urn:schemas-microsoft-com:office:word'
                        xmlns:m='http://schemas.microsoft.com/office/2004/12/omml'
                        xmlns='http://www.w3.org/TR/REC-html40'>
                    <head>
                        <meta http-equiv=Content-Type content='text/html; charset=utf-8'>
                        <meta name=ProgId content=Word.Document>
                        <meta name=Generator content='Microsoft Word 15'>
                        <meta name=Originator content='Microsoft Word 15'>
                        <link rel=File-List href='Manuel_archivos/filelist.xml'>
                        <link rel=Edit-Time-Data href='Manuel_archivos/editdata.mso'>
                        <style>
                            table 
                            {
                                font-family: arial, sans-serif;
                                border-collapse: collapse;
                                background-color: #B1D6FA;
                            }
                            td, th 
                            {
                                border: 1px solid #B1D6FA;
                                text-align: left;
                                padding: 8px;
                            }
                            tr:nth-child(even) 
                            {
                                background-color: #0000FF;
                            }
                            table.MsoNormalTable
            	            {
                                mso-style-name:'Tabla normal';
            	                mso-tstyle-rowband-size:0;
            	                mso-tstyle-colband-size:0;
            	                mso-style-noshow:yes;
            	                mso-style-priority:99;
            	                mso-style-parent:'';
            	                mso-padding-alt:0cm 5.4pt 0cm 5.4pt;
            	                mso-para-margin:0cm;
            	                mso-para-margin-bottom:.0001pt;
            	                mso-pagination:widow-orphan;
            	                font-size:11.0pt;
            	                font-family:'Calibri',sans-serif;
            	                mso-ascii-font-family:Calibri;
            	                mso-ascii-theme-font:minor-latin;
            	                mso-hansi-font-family:Calibri;
            	                mso-hansi-theme-font:minor-latin;
            	                mso-bidi-font-family:'Times New Roman';
            	                mso-bidi-theme-font:minor-bidi;
                            }
                        </style>
                    </head>
                    <body lang=ES-MX link='#0563C1' vlink='#954F72' style='tab-interval:35.4pt'>
                        <p style ='color:#4169E1';><span style=font-size:11.0pt;font-family:Helvetica><b>Estimado Cliente,</b></span></p>
                        <p>Hago de su conocimiento que estaré dando seguimiento a sus servicios de calibración,
para lo cual le solicito lo siguiente...(Verifique los PDF)</p>
                        <p style='color:#4169E1';><span style=font-size:11.0pt;font-family:Helvetica><b>Saludos Cordiales,</b></span></p><br>
                        <p style='color:#4169E1';><span style=font-size:11.0pt;font-family:Helvetica><b>Atentamente,</b></span></p><br>
                        <div Class=WordSection1>
                        <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><o:p>&nbsp;</o:p></span></p>
                        <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'>
                        Almacén y Envíos.<br>
                        Equipo de Almacén y Envíos<br>
                        </span><span style='font-family:' Bahnschrift Light',sans-serif'><a href='mailto:logistica@metas.mx'>logistica<span style='font-size:12.0pt'>@metas.mx</span></a></span><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><br>
                        Teléfono: 01 (341) 413 61 23<o:p></o:p></span></p>
                        <p class=MsoNormal>
                        <span style='mso-ignore:vglayout;position:
                            absolute;z-index:-1895824384;margin-left:4px;margin-top:12px;width:696px;
                            height:193px'><img border='0' src='file:///C:\Users\Software TI\Documents\GitHub\image002.png' width='xxxx' height='xxxx'></span>
                        <p class=MsoNormal style='text-align:justify;text-justify:inter-ideograph;
                            background:white'><b><span lang=ES style='font-size:8.0pt;color:#002060;
                            mso-ansi-language:ES'>AVISO DE CONFIDENCIALIDAD -</span></b><span lang=ES
                            style='font-size:8.0pt;color:#1F497D;mso-ansi-language:ES'>El presente
                            correo&nbsp; electrónico incluyendo sus anexos, contienen información
                            confidencial exclusivos de la persona o entidad a quien va dirigido, si usted
                            no es destinatario del mismo debe proceder a informar mediante correo
                            electrónico a la persona que lo envió y a borrar de su sistema el correo
                            original y sus anexos, sin conservar copias. El uso, difusión, distribución o
                            reproducción del presente mensaje, sin autorización, es prohibido y puede
                            configurar un delito. MetAs S.A. de C.V. pone a su disposición el aviso de
                            privacidad en la página web </span><span lang=ES style='mso-ansi-language:ES;
                            mso-fareast-language:ES'><a href='http://www.metas.com.mx/aviso-privacidad.html'><span lang=ES-MX style='font-size:8.0pt;color:blue;mso-ansi-language:ES-MX;
                            mso-fareast-language:ES-MX'>http://www.metas.com.mx/aviso-privacidad.html</span></a></span><span
                            lang=ES style='font-size:8.0pt;color:#9EB0AE;mso-ansi-language:ES'></span><span
                            lang=ES style='font-size:8.0pt;color:#1F497D;mso-ansi-language:ES'>y que puede
                            ser de la misma manera suministrada a petición. </span><span lang=ES-TRAD
                            style='font-size:8.0pt;color:#222222;mso-ansi-language:ES-TRAD'><o:p></o:p></span></p>
                        <p class=MsoAutoSig><o:p>&nbsp;</o:p></p>"
            R = R & "</body></html>"
            objOutlook = CreateObject("Outlook.Application")
            objOutlookMsg = objOutlook.CreateItem(0)
            With objOutlookMsg
                '.CC = cca
                .Subject = "Favor de confirmar los siguientes datos"
                .HTMLBody = R
                .To = Email
                .Attachments.Add(pdfPath)
                .Display
            End With
            'End If
            objOutlookMsg = Nothing
            objOutlook = Nothing

        End If
    End Sub
End Class