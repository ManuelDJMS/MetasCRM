Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmUsuariosCotizadores
    Dim enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre As String
    Dim Asunto As String
    Dim bandera As Integer
    Dim CuerpoMensaje As String
    Dim referencia As String
    Dim monto As String
    Dim calibracion As String
    Dim FechaCalibracion, fechaModificada As String
    Dim NameFirma As String
    Dim fechaActual As String
    Dim Puesto As String
    Dim cca As String
    Dim destinataro As String
    Dim objOutlook As Object
    Dim quienEnvia As String
    Dim Ruta As String
    Dim resultado As String
    Dim seleccion As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox1.Text.Equals("Enero") Then
            consulta2(enero)
        ElseIf ComboBox1.Text.Equals("Febrero") Then
            consulta2(febrero)
        ElseIf ComboBox1.Text.Equals("Marzo") Then
            consulta2(marzo)
        ElseIf ComboBox1.Text.Equals("Abril") Then
            consulta2(abril)
        ElseIf ComboBox1.Text.Equals("Mayo") Then
            consulta2(mayo)
        ElseIf ComboBox1.Text.Equals("Junio") Then
            consulta2(junio)
        ElseIf ComboBox1.Text.Equals("Julio") Then
            consulta2(julio)
        ElseIf ComboBox1.Text.Equals("Agosto") Then
            consulta2(agosto)
        ElseIf ComboBox1.Text.Equals("Septiembre") Then
            consulta2(septiembre)
        ElseIf ComboBox1.Text.Equals("Octubre") Then
            consulta2(octubre)
        ElseIf ComboBox1.Text.Equals("Noviembre") Then
            consulta2(noviembre)
        ElseIf ComboBox1.Text.Equals("Diciembre") Then
            consulta2(diciembre)
        End If
    End Sub

    Dim objOutlookMsg As Object

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Dim x, y As Integer
    '    x = 1
    '    y = 0

    '    Dim Aplicacion As New Excel.Application
    '    Dim Libro As Excel.Workbook
    '    Dim Hoja As Excel.Worksheet
    '    Aplicacion = New Excel.Application
    '    Libro = Aplicacion.Workbooks.Open("C:\Users\Software TI\Documents\Access\Generador-Certificados-MDV-190521.xlsm")
    '    Hoja = Libro.Worksheets("Resultados")
    '    For i = 10 To 20
    '        y = x + 1
    '        'Hoja.Cells(i, 131) = "=SI(B10 <>DISP;"";SI(O(Calc!F10="";EG10="");"";SI.Error(BDPROMEDIO(Datos_Inst;2;Puntos!$A" & x & ":$A" & y & ");#¡ERROR!)))"
    '        Hoja.Cells(131, i) = "Hola"
    '        x = y + 1
    '    Next i

    '    ''----------------------------------
    '    Dim ms_Excel As New Excel.Application()
    '    Dim wbook As Excel.Workbook = ms_Excel.Workbooks.Open("C:\Users\Software TI\Documents\Access\Generador-Certificados-MDV-190521.xlsm") ' abre el libro por ende su proceso

    '    ms_Excel.Visible = False

    '    wbook.Saved = False
    '    wbook.Close() ' cierra el clibro y el proceso que este genero.
    '    ms_Excel.Quit()
    '    ms_Excel = Nothing
    '    '--------------------------------------------------------

    '    Aplicacion.Sheets(1).Protect(password:="", DrawingObjects:=True, Contents:=True, Scenarios:=True) 'Quita la Protección del Archivo
    '    Aplicacion.DisplayAlerts = False 'Elimina Los Mensajes De Alerta
    '    Aplicacion.ActiveWorkbook.Save() 'Guarda los Cambios 
    '    Aplicacion.Visible = True
    '    Aplicacion.ActiveWorkbook.ActiveSheet.PrintPreview()
    '    Aplicacion.Quit()

    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(Aplicacion)
    '    Aplicacion = Nothing
    '    ''----


    '    Libro.Close()
    '    Aplicacion.Quit()


    'End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text.Equals("Enero") Then
            consulta(enero)
            Button5.Text = "Enviados de Enero"
        ElseIf ComboBox1.Text.Equals("Febrero") Then
            consulta(febrero)
            Button5.Text = "Enviados de Febrero"
        ElseIf ComboBox1.Text.Equals("Marzo") Then
            consulta(marzo)
            Button5.Text = "Enviados de Marzo"
        ElseIf ComboBox1.Text.Equals("Abril") Then
            consulta(abril)
            Button5.Text = "Enviados de Abril"
        ElseIf ComboBox1.Text.Equals("Mayo") Then
            consulta(mayo)
            Button5.Text = "Enviados de Mayo"
        ElseIf ComboBox1.Text.Equals("Junio") Then
            consulta(junio)
            Button5.Text = "Enviados de Junio"
        ElseIf ComboBox1.Text.Equals("Julio") Then
            consulta(julio)
            Button5.Text = "Enviados de Julio"
        ElseIf ComboBox1.Text.Equals("Agosto") Then
            consulta(agosto)
            Button5.Text = "Enviados de Agosto"
        ElseIf ComboBox1.Text.Equals("Septiembre") Then
            consulta(septiembre)
            Button5.Text = "Enviados de Septiembre"
        ElseIf ComboBox1.Text.Equals("Octubre") Then
            consulta(octubre)
            Button5.Text = "Enviados de Octubre"
        ElseIf ComboBox1.Text.Equals("Noviembre") Then
            consulta(noviembre)
            Button5.Text = "Enviados de Noviembre"
        ElseIf ComboBox1.Text.Equals("Diciembre") Then
            consulta(diciembre)
            Button5.Text = "Enviados de Diciembre"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim seleccionado As Boolean
            Dim b As Boolean
            If DGRes.Rows.Count < 2 Then
                MsgBox("No hay correos seleccionados por mandar.", MsgBoxStyle.Critical, "Error del sistema.")
            Else
                '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(6).Value
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
                        seleccionado = DGRes.Rows(i).Cells(6).Value
                        If seleccionado = True Then
                            txtAsunto.Text = "Estimado(a) " & DGRes.Rows(i).Cells(4).Value.ToString() & ", esta por cumplirse 12 meses desde que MetAs calibró su equipo de medición."
                            Try
                                destinataro = DGRes.Rows(i).Cells(3).Value.ToString()
                                Asunto = txtAsunto.Text
                                CuerpoMensaje = "<html><body>"
                                CuerpoMensaje = CuerpoMensaje & "<span style=font-size:10.0pt;font-family:Helvetica>" & txtCuerpo.Text & "</span><br>"
                                CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>¿Desea que le enviemos una cotización formal?</b></span></p>"
                                CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>De antemano agradecemos el habernos contactado.</b></span></p><br>"
                                CuerpoMensaje = CuerpoMensaje & "</body></html>"
                                objOutlook = CreateObject("Outlook.Application")
                                objOutlookMsg = objOutlook.CreateItem(0)
                                If rb.Checked = True Then
                                    With objOutlookMsg
                                        .CC = cca
                                        .Subject = Asunto
                                        .HTMLBody = CuerpoMensaje
                                        .To = destinataro
                                        .Display
                                    End With
                                Else
                                    With objOutlookMsg
                                        .CC = cca
                                        .Subject = Asunto
                                        .HTMLBody = CuerpoMensaje
                                        .To = destinataro
                                        .Display
                                    End With
                                End If
                                objOutlookMsg = Nothing
                                objOutlook = Nothing

                            Catch ex As Exception
                                MsgBox("Ocurrio un error, comunicate con el administrador de sistemas.", MsgBoxStyle.Exclamation)
                                MsgBox("Descripciòn del error: " & ex.ToString)
                            End Try
                        End If
                    Next
                    'accion post
                Else
                    MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al enviar correos.")
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text.Equals("Enero") Then
            consulta(enero)
        ElseIf ComboBox1.Text.Equals("Febrero") Then
            consulta(febrero)
        ElseIf ComboBox1.Text.Equals("Marzo") Then
            consulta(marzo)
        ElseIf ComboBox1.Text.Equals("Abril") Then
            consulta(abril)
        ElseIf ComboBox1.Text.Equals("Mayo") Then
            consulta(mayo)
        ElseIf ComboBox1.Text.Equals("Junio") Then
            consulta(junio)
        ElseIf ComboBox1.Text.Equals("Julio") Then
            consulta(julio)
        ElseIf ComboBox1.Text.Equals("Agosto") Then
            consulta(agosto)
        ElseIf ComboBox1.Text.Equals("Septiembre") Then
            consulta(septiembre)
        ElseIf ComboBox1.Text.Equals("Octubre") Then
            consulta(octubre)
        ElseIf ComboBox1.Text.Equals("Noviembre") Then
            consulta(noviembre)
        ElseIf ComboBox1.Text.Equals("Diciembre") Then
            consulta(diciembre)
        End If
    End Sub


    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ''Boton de actualizar los seleccionados
            Dim seleccionado As Boolean
            Dim b As Boolean
            Dim R As String
            If DGRes.Rows.Count < 2 Then
                MsgBox("No hay correos seleccionados por mandar.", MsgBoxStyle.Critical, "Error del sistema.")
            Else
                '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(6).Value
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
                        seleccionado = DGRes.Rows(i).Cells(6).Value
                        If seleccionado = True Then
                            ''actualizar
                            MetodoMetasInf2018()
                            R = "update [INFORMES-SERVICIOS] set correoEnviado=1, HojasEnviadas='" & DGRes.Rows(i).Cells(7).Value.ToString & "', ObservacionesRec='" & DGRes.Rows(i).Cells(5).Value.ToString & "' where Folio = " & Val(DGRes.Rows(i).Cells(0).Value) & " and NumCot=" & Val(DGRes.Rows(i).Cells(2).Value) & " and Empresa ='" & DGRes.Rows(i).Cells(1).Value.ToString() & "'"
                            Dim comando As New SqlCommand(R, conexion2018)
                            comando.ExecuteNonQuery()
                            conexion2018.Close()
                            ''MsgBox("Actualizado")
                        End If
                    Next
                    If ComboBox1.Text.Equals("Enero") Then
                        consulta(enero)
                    ElseIf ComboBox1.Text.Equals("Febrero") Then
                        consulta(febrero)
                    ElseIf ComboBox1.Text.Equals("Marzo") Then
                        consulta(marzo)
                    ElseIf ComboBox1.Text.Equals("Abril") Then
                        consulta(abril)
                    ElseIf ComboBox1.Text.Equals("Mayo") Then
                        consulta(mayo)
                    ElseIf ComboBox1.Text.Equals("Junio") Then
                        consulta(junio)
                    ElseIf ComboBox1.Text.Equals("Julio") Then
                        consulta(julio)
                    ElseIf ComboBox1.Text.Equals("Agosto") Then
                        consulta(agosto)
                    ElseIf ComboBox1.Text.Equals("Septiembre") Then
                        consulta(septiembre)
                    ElseIf ComboBox1.Text.Equals("Octubre") Then
                        consulta(octubre)
                    ElseIf ComboBox1.Text.Equals("Noviembre") Then
                        consulta(noviembre)
                    ElseIf ComboBox1.Text.Equals("Diciembre") Then
                        consulta(diciembre)
                    End If
                Else
                    MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar.")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColorColumnas(DGRes)
        enero = "2018-01-01' and '2018-30-01"
        febrero = "2018-01-02' and '2018-28-02"
        marzo = "2018-01-03' and '2018-30-03"
        abril = "2018-01-04' and '2018-30-04"
        mayo = "2018-01-05' and '2018-30-05"
        junio = "2018-01-06' and '2018-30-06"
        julio = "2018-01-07' and '2018-30-07"
        agosto = "2018-01-08' and '2018-30-08"
        septiembre = "2018-01-09' and '2018-30-09"
        octubre = "2018-01-10' and '2018-30-10"
        noviembre = "2018-01-11' and '2018-30-11"
        diciembre = "2018-01-12' and '2018-30-12"

    End Sub
    Public Sub consulta(ByVal R As String)
        Try
            MetodoMetasInf2018()
            DGRes.Rows.Clear()
            Dim cadena As String
            'Dim desde, hasta As String
            'desde = DTPDesdde.Value.Date.Year & "-" & DTPDesdde.Value.Date.Day & "-" & DTPDesdde.Value.Date.Month
            'hasta = DTPHasta.Value.Date.Year & "-" & DTPHasta.Value.Date.Day & "-" & DTPHasta.Value.Date.Month
            cadena = "select distinct [INFORMES-SERVICIOS].Folio, Empresa, [Contactos-Clientes-Usuarios].Email, [INFORMES-SERVICIOS].NumCot , [INFORMES-SERVICIOS].Usuario, [INFORMES-SERVICIOS].ObservacionesRec,
                            [INFORMES-SERVICIOS].HojasEnviadas from [INFORMES-SERVICIOS] inner join [Contactos-Clientes-Usuarios] on
                            [INFORMES-SERVICIOS].Clavecontacto = [Contactos-Clientes-Usuarios].Clavecontacto 
                            where FECHARECEP between '" & R & "' 
                            and FECHACALIB between '" & R & "'
                            and ClavecontactoUsuario <> 0 and correoEnviado = 0"
            Dim comando As New SqlCommand(cadena, conexion2018)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(lector(0), lector(1), lector(3), lector(2), lector(4), lector(5), False, lector(6))
            End While
            'MsgBox("Consulta realizada correctamente")
            lector.Close()
            R = ""
            conexion2018.Close()
        Catch ex As Exception
            MsgBox("Error en lectura de datos.", MsgBoxStyle.Information)
        End Try
    End Sub


    Public Sub consulta2(ByVal R As String)
        Try
            MetodoMetasInf2018()
            DGRes.Rows.Clear()
            Dim cadena As String
            'Dim desde, hasta As String
            'desde = DTPDesdde.Value.Date.Year & "-" & DTPDesdde.Value.Date.Day & "-" & DTPDesdde.Value.Date.Month
            'hasta = DTPHasta.Value.Date.Year & "-" & DTPHasta.Value.Date.Day & "-" & DTPHasta.Value.Date.Month
            cadena = "select distinct [INFORMES-SERVICIOS].Folio, Empresa, [Contactos-Clientes-Usuarios].Email, [INFORMES-SERVICIOS].NumCot , [INFORMES-SERVICIOS].Usuario, [INFORMES-SERVICIOS].ObservacionesRec,
                            [INFORMES-SERVICIOS].HojasEnviadas from [INFORMES-SERVICIOS] inner join [Contactos-Clientes-Usuarios] on
                            [INFORMES-SERVICIOS].Clavecontacto = [Contactos-Clientes-Usuarios].Clavecontacto 
                            where FECHARECEP between '" & R & "' 
                            and FECHACALIB between '" & R & "'
                            and ClavecontactoUsuario <> 0 and correoEnviado = 1"
            Dim comando As New SqlCommand(cadena, conexion2018)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(lector(0), lector(1), lector(3), lector(2), lector(4), lector(5), False, lector(6))
            End While
            'MsgBox("Consulta realizada correctamente")
            lector.Close()
            R = ""
            conexion2018.Close()
        Catch ex As Exception
            MsgBox("Error en lectura de datos.", MsgBoxStyle.Information)
        End Try
    End Sub

End Class