Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmCompletarOV
    Dim customerId As Integer
    Dim objOutlook As Object
    Dim objOutlookMsg As Object
    Dim DirEnv, estEnv, cdEnv, cpEnv As String
    Private Sub FrmCompletarOV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        Dim R As String
        If bancorreo = 1 Then
            R = "Select [SetupCustomerAddressDtls].[CustomerId], [CustAccountNo], [FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1], [ShipAddress1],[ShipCity],[ShipState],[ShipZip]
                FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] x1 INNER JOIN [SetupCustomerAddressDtls] ON x1.[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
		        where x1.[CustomerId] =" & empresa
            Label22.Visible = False
            NumOV.Visible = False
            Label13.Visible = False
            txtRefCot.Visible = False
            'bancorreo = 3
        ElseIf bancorreo = 2 Then
            R = "SELECT [SetupCustomerAddressDtls].[CustomerId],[CustAccountNo],[FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1], [ShipAddress1],[ShipCity],[ShipState],[ShipZip]
            FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
	        INNER JOIN [SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
		    where [CustAccountNo] = '" & var.Text & "'"
        End If
        Dim comando As New SqlCommand(R, conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()

        txtNombreCompania.Text = lector(5)
        'If correos2 = False Then
        '    txtCorreo.Text = correos
        'Else

        '    txtCorreo.Text = lector(4)
        'End If

        txtDireccion.Text = lector(7)
        terminosPago.Text = lector(6)
        numCuenta.Text = var.Text
        customerId = (lector(0))


        numCuenta.Text = lector(1)
        If correos2 = False Then
            txtCorreo.Text = lector(4)
            'MsgBox(txtCorreo.Text)
        Else
            txtCorreo.Text = correos
            'numCuenta.Text = var.Text

        End If
        DirEnv = lector(8)
        cdEnv = lector(9)
        estEnv = lector(10)
        cpEnv = lector(11)
        lector.Close()
        bancorreo = False
        correos = ""
        bancorreo = 0

        empresa = 0
        R = "SELECT [Id],[ShipVia] FROM [MetAs_Live-pruebas].[dbo].[SetupShippingMode]"
        Dim comando2 As New SqlCommand(R, conexionLIMS)
        Dim lector2 As SqlDataReader
        lector2 = comando2.ExecuteReader
        While lector2.Read()
            cboRecepcion.Items.Add(lector2(1))
            embarcarPor.Items.Add(lector2(1))
        End While
    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        Try
            MetodoLIMS()
            Dim R As String
            If NumOV.Text = "ov" Then
                If domEnvio.Checked = True Then
                    R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RecDate, DataRequested, OnSite,[PONo],[RecBy],[ReceivedVia],[ShipVia],[Remarks],[CreatedBy],[CreatedOn],[BoxCount],[Weight],[Volume],[PaymentTerms], [RefNo], [ShipAddress1],[ShipCity],[ShipState],[ShipZip]) 
                                            values(" & customerId & ",'" & numCuenta.Text & "','" & dtpFechaRecep.Value.ToShortDateString & "', '" & True & "','" & False & "', '" & txtOrdenCompra.Text & "','" & cboRecibidoPor.Text & "','" & cboRecepcion.Text & "', '" & embarcarPor.Text & "', '" & txtObservaciones.Text & "', 'USR00000008', '" & dtpFechaRecep.Value.ToShortDateString & "', '" & txtCantCajas.Text & "', '" & txtPeso.Text & "', '" & txtVolumen.Text & "','" & terminosPago.Text & "', ' ', '" & DirEnv.ToString & "', '" & cdEnv.ToString & "', '" & estEnv.ToString & "', '" & cpEnv.ToString & "')"
                    ''MsgBox(R)
                Else
                    R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RecDate, DataRequested, OnSite,[PONo],[RecBy],[ReceivedVia],[ShipVia],[Remarks],[CreatedBy],[CreatedOn],[BoxCount],[Weight],[Volume],[PaymentTerms], [RefNo]) 
                                        values(" & customerId & ",'" & numCuenta.Text & "','" & dtpFechaRecep.Value.ToShortDateString & "', '" & True & "','" & False & "', '" & txtOrdenCompra.Text & "','" & cboRecibidoPor.Text & "','" & cboRecepcion.Text & "', '" & embarcarPor.Text & "', '" & txtObservaciones.Text & "', 'USR00000008', '" & dtpFechaRecep.Value.ToShortDateString & "', '" & txtCantCajas.Text & "', '" & txtPeso.Text & "', '" & txtVolumen.Text & "','" & terminosPago.Text & "', ' ')"
                    ''MsgBox(R)
                End If
                Dim comando As New SqlCommand
                comando = conexionLIMS.CreateCommand
                comando.CommandText = R
                comando.ExecuteNonQuery()
                MsgBox("ORDEN DE VENTA GUARDADA")
            Else
                If domEnvio.Checked = True Then
                    R = "UPDATE [MetAs_Live-pruebas].[dbo].[SalesOrderDetails] set [PONo] = '" & txtOrdenCompra.Text & "', RecDate ='" & dtpFechaRecep.Value.ToShortDateString & "', [RecBy] = '" & cboRecibidoPor.Text & "', [BoxCount] = '" & txtCantCajas.Text & "', 
                [Weight] = '" & txtPeso.Text & "', [ReceivedVia] = '" & cboRecepcion.Text & "', [ShipVia] = '" & embarcarPor.Text & "', [Remarks] ='" & txtObservaciones.Text & "', [RefNo] = '" & txtRefCot.Text & "',
                [Volume] = '" & txtVolumen.Text & "',  [ShipAddress1] = '" & DirEnv.ToString & "', [ShipCity] = '" & cdEnv.ToString & "',[ShipState] = '" & estEnv.ToString & "', [ShipZip]  = '" & cpEnv.ToString & "'
                where [SOId] = " & Val(NumOV.Text) & ""
                Else
                    R = "UPDATE [MetAs_Live-pruebas].[dbo].[SalesOrderDetails] set [PONo] = '" & txtOrdenCompra.Text & "', RecDate ='" & dtpFechaRecep.Value.ToShortDateString & "', [RecBy] = '" & cboRecibidoPor.Text & "', [BoxCount] = '" & txtCantCajas.Text & "', 
                [Weight] = '" & txtPeso.Text & "', [ReceivedVia] = '" & cboRecepcion.Text & "', [ShipVia] = '" & embarcarPor.Text & "', [Remarks] ='" & txtObservaciones.Text & "', [RefNo] = '" & txtRefCot.Text & "',
                [Volume] = '" & txtVolumen.Text & "'
                where [SOId] = " & Val(NumOV.Text) & ""
                End If
                Dim coma As New SqlCommand(R, conexionLIMS)
                coma.ExecuteNonQuery()
                MsgBox("ORDEN DE VENTA " & NumOV.Text & " ACTUALIZADA")
            End If
            If txtCorreo.Text.Equals("") Then
                MsgBox("Se necesita al menos un correo electrónico.", MsgBoxStyle.Critical)
            Else
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
                        <p style='font-size:110%;'>Le informamos que ha llegado al almacén de MetAs un envío por parte de ustedes.<p>
                        <p style='font-size:110%;'>El proceso de su servicio iniciará.<p>
                        <table>
                            <tr>
                                <td>Click para:</td>
                            </tr>
                            <tr>
                                <td>Descargar acreditamientos EMA</td>

                            </tr>
                            <tr>
                                <td><a href='www.metas.com.mx/acreditacion.html'>www.metas.com.mx/acreditacion.html</a></td>

                            </tr>
                            <tr>
                                <td></td>

                            </tr>
                            <tr>
                                <td>Venta de instrumentos calibrados</td>
                            </tr>
                            <tr>
                                <td><a href='www.metas.com.mx/catalogo-instr-calib.htm'>www.metas.com.mx/catalogo-instr-calib.htm</a></td>

                            </tr>
                            <tr>
                                <td></td>

                            </tr>
                            <tr>
                                <td>Entérese de nuestros próximos  cursos de metrología</td>

                            </tr>
                            <tr>
                                <td><a href='www.metas.com.mx/calendariocursos.htm'>www.metas.com.mx/calendariocursos.htm</a></td>

                            </tr>
                            <tr>
                                <td></td>

                            </tr>
                        </table>
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
                    .Subject = "AVISO DE LLEGADA DE ENVÍO AL ALMACÉN DE METAS"
                    .HTMLBody = R
                    .To = txtCorreo.Text
                    .Display
                End With
                'End If
                objOutlookMsg = Nothing
                objOutlook = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCompletarOV", "Error al actualizar la OV", Err.Number, cadena)
        End Try
        Me.Dispose()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub
End Class