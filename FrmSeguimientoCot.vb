Imports System.Data.SqlClient
Public Class FrmSeguimientoCot
    Dim fechadesde As DateTime
    Dim fechahasta As DateTime
    Dim objOutlook As Object
    Dim objOutlookMsg As Object
    Private Sub FrmSeguimientoCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralDeCotizaciones(DGRes)
    End Sub

    Private Sub DtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles DtpDesde.ValueChanged
        Try
            MetodoMetasCotizador()
            DGRes.Rows.Clear()
            fechadesde = Convert.ToDateTime(DtpDesde.Text).ToShortDateString
            fechahasta = Convert.ToDateTime(DtpHasta.Text).ToShortDateString
            Dim R As String = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
                inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0 and FechaDesde between '" & fechadesde & "' 
                            and '" & fechahasta & "'"

            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DtpHasta_ValueChanged(sender As Object, e As EventArgs) Handles DtpHasta.ValueChanged
        Try
            MetodoMetasCotizador()
            DGRes.Rows.Clear()
            fechadesde = Convert.ToDateTime(DtpDesde.Text).ToShortDateString
            fechahasta = Convert.ToDateTime(DtpHasta.Text).ToShortDateString
            Dim R As String = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
                inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0 and FechaDesde between '" & fechadesde & "' 
                            and '" & fechahasta & "'"

            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''Generar
        'Dim con As FrmCompletarOV
        'Dim cliente As String
        Dim cu, ca As Integer
        'Try
        Dim seleccionado As Boolean
        Dim R As String
        Dim b, RecDate, OnSite As Boolean
        RecDate = True
        OnSite = False '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
        For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
            seleccionado = DGRes.Rows(i).Cells(0).Value
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
                seleccionado = DGRes.Rows(i).Cells(0).Value
                If seleccionado = True Then
                    Dim correos As String
                    correos = DGRes.Rows(i).Cells(4).Value
                    Dim vColeccion() As String = correos.Split(";")
                    If vColeccion.Length > 1 Then
                        For ii = 0 To vColeccion.Length - 1
                            FrmFiltarCampo.dgEmpresas.Rows.Add(False, vColeccion(ii))
                        Next
                        banderaform = True
                        'empresa = DGRes.Rows(e.RowIndex).Cells(0).Value.ToString()
                        FrmFiltarCampo.Show()

                    Else
                        'Aqui va el correo 
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
                            .To = "sistemas3@metas.com.mx"
                            .Display
                        End With
                        'End If
                        objOutlookMsg = Nothing
                        objOutlook = Nothing

                    End If
                End If
            Next
            'frmEdicionCot2018_2019.Show()

        Else
            MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
        End If







        'If DGRes.Rows.Count < 2 Then
        '    MsgBox("No hay ordenes de venta seleccionadas.", MsgBoxStyle.Critical, "Error del sistema.")
        'Else
        '    '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
        '    For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
        '        seleccionado = DGRes.Rows(i).Cells(0).Value
        '        If seleccionado = True Then
        '            'b = True
        '            'Exit For

        '        Else
        '            MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
        '        End If
        '    Next
        '----------------------------------------------------------------------------------------------------
        'If b = True Then
        '    For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
        '        seleccionado = DGRes.Rows(i).Cells(0).Value
        '        Dim correos As String
        '        correos = DGRes.Rows(i).Cells(0).Value
        '        MsgBox(correos)
        '        Dim vColeccion() As String = correos.Split(";")
        '        If vColeccion.Length > 1 Then
        '            For ii = 0 To vColeccion.Length - 1
        '                FrmFiltarCampo.dgEmpresas.Rows.Add(False, vColeccion(ii))
        '            Next
        '            'empresa = DGRes.Rows(e.RowIndex).Cells(0).Value.ToString()
        '            FrmFiltarCampo.Show()
        '        Else


        '        End If
        '        Me.Dispose()
        '    Next
        'Else
        '    MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
        'End If
        'End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("FrmAutorizarSolicitudes", "Error al guardar la OV", Err.Number, cadena)
        'End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub
End Class