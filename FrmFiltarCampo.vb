Public Class FrmFiltarCampo
    Dim objOutlook As Object
    Dim objOutlookMsg As Object
    Dim r As String
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub
    Private Sub BtSinCot_Click(sender As Object, e As EventArgs) Handles btSinCot.Click
        Dim seleccionado, b As Boolean
        For i As Integer = dgEmpresas.Rows.Count() - 1 To 0 Step -1
            seleccionado = dgEmpresas.Rows(i).Cells(0).Value
            If seleccionado = True Then
                b = True
                Exit For
            Else
                b = False
            End If
        Next
        '----------------------------------------------------------------------------------------------------
        If b = True Then
            For i As Integer = dgEmpresas.Rows.Count() - 1 To 0 Step -1
                seleccionado = dgEmpresas.Rows(i).Cells(0).Value
                If seleccionado = True Then
                    MetodoLIMS()
                    correos = correos & "; " & dgEmpresas.Rows(i).Cells(1).Value
                End If
            Next
            correos = RTrim(LTrim(correos.Substring(1, correos.Length - 1)))
            If banderaform = True Then
                'Aqui va el correo 
                r = "<html xmlns:v='urn:schemas-microsoft-com:vml'
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
                        <p style='font-size:110%;'>Buen día, es un gusto saludarle, se envió a su cuenta de correo electrónico la cotización solicitada con la siguiente información, con la siguiente información:<p>
                        
                        
                        <table>
                            <tr>
                                <td>Número de Cotización:</td>
                                <td>" & numcotfrm & "</td>
                            </tr>
                            <tr>
                                <td>Empresa:</td>
                                <td>" & empresafrm & "</td>
                            </tr>
                            <tr>
                                <td>Contacto:</td>
                                <td>" & Contacto & "</td>
                            </tr>
                            <tr>
                                <td>Referencia:</td>
                                <td>" & Referencia & "</td>
                            </tr>
                            <tr>
                                <td>Total:</td>
                                <td>" & Total & "</td>
                            </tr>
                        </table>
                        <p><span style=font-size:11.0pt;font-family:Helvetica>Le agradecería pudiera confirmar la recepción de la misma, o en que estatus se encuentra, esto con la finalidad de poder ofrecerle un mejor servicio, y atender todas y cada una de sus inquietudes.</span></p>
                        <p><span style=font-size:11.0pt;font-family:Helvetica>En espera de una respuesta favorable a este correo y agradeciendo todas sus atenciones quedo a sus órdenes</span></p>
                        <p style='color:#4169E1';><span style=font-size:11.0pt;font-family:Helvetica><b>Saludos Cordiales,</b></span></p><br>
                        <p style='color:#4169E1';><span style=font-size:11.0pt;font-family:Helvetica><b>Atentamente,</b></span></p><br>
                        <div Class=WordSection1>
                        <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><o:p>&nbsp;</o:p></span></p>
                        <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'>
                       Área de Ventas de Servicios de Calibración.<br>
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
                r = r & "</body></html>"
                objOutlook = CreateObject("Outlook.Application")
                objOutlookMsg = objOutlook.CreateItem(0)
                banderaform = False
                With objOutlookMsg
                    '.CC = cca
                    .Subject = "AVISO DE LLEGADA DE ENVÍO AL ALMACÉN DE METAS"
                    .HTMLBody = r
                    .To = correos
                    .Display
                End With
                'End If
                objOutlookMsg = Nothing
                objOutlook = Nothing

            Else
                bancorreo = 1
                correos2 = True
                FrmCompletarOV.Show()
            End If
            Me.Dispose()
        Else
            MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
        End If
    End Sub
End Class