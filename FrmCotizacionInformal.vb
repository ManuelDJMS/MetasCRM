Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class FrmCotizacionInformal
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
    Dim objOutlookMsg As Object
    Dim quienEnvia As String
    Dim Ruta As String
    Dim resultado As String

    Private Sub FrmCotizacionInformal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb.Enabled = False
        cbAdjuntos.Enabled = False
        DGConsultaCot2.Visible = False
        bandera = 0

        cboPrioridad.Text = "---Selecciona una prioridad---"
        cboPrioridad.Items.Add("Alta")
        cboPrioridad.Items.Add("Baja")
        cboPrioridad.Items.Add("Standard")
        cboPrioridad.Items.Add("Urgente")

        cboPrioridadC.Text = "---Selecciona una prioridad---"
        cboPrioridadC.Items.Add("Alta")
        cboPrioridadC.Items.Add("Baja")
        cboPrioridadC.Items.Add("Standard")
        cboPrioridadC.Items.Add("Urgente")

        cboPrioridadCot.Items.Add("Alta")
        cboPrioridadCot.Items.Add("Baja")
        cboPrioridadCot.Items.Add("Standard")
        cboPrioridadCot.Items.Add("Urgente")

        cboCategoria.Text = "---Selecciona un tipo de categoría---"
        cboCategoria.Items.Add("Categoría 1")
        cboCategoria.Items.Add("Categoría 2")
        cboCategoria.Items.Add("Categoría 3")
        cboCategoria.Items.Add("Categoría 4")

        cboCategoriaC.Text = "---Selecciona un tipo de categoría---"
        cboCategoriaC.Items.Add("Categoría 1")
        cboCategoriaC.Items.Add("Categoría 2")
        cboCategoriaC.Items.Add("Categoría 3")
        cboCategoriaC.Items.Add("Categoría 4")

        cboStatus.Text = "--Selecciona una opción---"
        ''Enviada, Modificada, Cancelada, Finalizada
        cboStatus.Items.Add("Enviada")
        cboStatus.Items.Add("En proceso")
        cboStatus.Items.Add("Cerrada Existosa")
        cboStatus.Items.Add("Cerrada NO Exitosa")



        txtStatusCot.Items.Add("En proceso")
        txtStatusCot.Items.Add("Cerrada Existosa")
        txtStatusCot.Items.Add("Cerrada NO Exitosa")

        txtAsunto.Text = "MetAs envia respuesta a solicitud de cotización."



        'resultado = MsgBox("¿La cotización sera para un cliente registrado en MetAs?", vbYesNo, "Cotización Informal")

        'If resultado = vbYes Then
        '    GBCliente.Visible = True
        '    GBPersona.Visible = False
        'Else
        GBCliente.Visible = False
        GBPersona.Visible = True
        'End If
        consultaGeneral()
    End Sub
    Private Sub btEnviar_Click(sender As Object, e As EventArgs) Handles btEnviar.Click
        'Try
        If txtDestinatario.Text.Equals("") Or txtAsunto.Text.Equals("") Or txtCuerpo.Text.Equals("") Or txtNombre.Text.Equals("") Or txtReferencia.Text.Equals("") Or txtMonto.Text.Equals("") Or txtAdicionalesS.Text.Equals("") Then
            MsgBox("Completa los campos obligatorios.", MsgBoxStyle.Critical)
        Else
            fechaActual = DTPFechaActual.Value
            NameFirma = "Departamento de Ventas"
            Puesto = "Ventas"
            destinataro = txtDestinatario.Text
            quienEnvia = "Sandra Justo"
            cca = txtcc.Text
            calibracion = DTP.Value
            referencia = txtReferencia.Text
            Asunto = txtAsunto.Text
            CuerpoMensaje = "<html><body>"
            CuerpoMensaje = CuerpoMensaje & "<p><span style=font-size:11.0pt;font-family:Helvetica><b>Buen día " & txtNombre.Text & ", en atención a su amable solicitud me permito enviarle una respuesta.</b></span></p>"
            ''CuerpoMensaje = CuerpoMensaje & "<span style=font-size:11.0pt;font-family:Helvetica>__________________________________________________________</span><br>"
            CuerpoMensaje = CuerpoMensaje & "<span style=font-size:10.0pt;font-family:Helvetica>" & txtCuerpo.Text & "</span><br>"
            ''CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'>Monto Total: <b>$" & txtMonto.Text & ".00</b><br>"
            ''CuerpoMensaje = CuerpoMensaje & "<span style=font-size:11.0pt;font-family:Helvetica>__________________________________________________________</span><br>"
            CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>Si usted desea una cotización formal, favor de confirmar por este mismo medio indicando datos completos de su empresa, así como especificaciones técnicas completa de su equipo.</b></span></p>"
            CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>De antemano agradecemos el habernos contactado.</b></span></p><br>"
            CuerpoMensaje = CuerpoMensaje & "<span style=font-size:9.0pt;font-family:Helvetica><b>Observaciones adicionales: </b></span><br>"
            CuerpoMensaje = CuerpoMensaje & "<span style=font-size:9.0pt;font-family:Helvetica>" & txtAdicionalesS.Text & "</span>"
            'CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>Nota ó Referencia: </b>" & referencia & "<br></span></p>"
            'CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>Fecha estimada para sus calibraciones: </b>" & calibracion & "<br></span></p>"

            CuerpoMensaje = CuerpoMensaje & "</body></html>"
            'establecemos las funciones
            'Dim resultado As String
            objOutlook = CreateObject("Outlook.Application")
            objOutlookMsg = objOutlook.CreateItem(0)
            If rb.Checked = True Then
                With objOutlookMsg
                    .CC = cca
                    .Subject = Asunto
                    .HTMLBody = CuerpoMensaje
                    .To = destinataro
                    .Display
                    .Attachments.Add(OpenFileDialog1.FileName)
                End With
            Else
                With objOutlookMsg
                    .CC = cca
                    .Subject = Asunto
                    .HTMLBody = CuerpoMensaje
                    .To = destinataro
                    .Display
                    '.Attachments.Add(OpenFileDialog1.FileName)
                End With
            End If
            objOutlookMsg = Nothing
            objOutlook = Nothing
            guardarCotizacionEnBD()

        End If
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error, comunicate con el administrador de sistemas.", MsgBoxStyle.Exclamation)
        '    MsgBox("Descripciòn del error: " & ex.ToString)
        'End Try

    End Sub
    Function GetBoiler(ByVal sFile As String) As String
        'Dick Kusleika
        Dim fso As Object
        Dim ts As Object
        fso = CreateObject("Scripting.FileSystemObject")
        ts = fso.GetFile(sFile).OpenAsTextStream(1, -2)
        GetBoiler = ts.readall
        ts.Close
    End Function
    Private Sub btSeleccionar_Click(sender As Object, e As EventArgs) Handles btSeleccionar.Click
        ' Try
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            LabelNombreArchivo.Text = OpenFileDialog1.FileName
            rb.Checked = True
            rb.Enabled = True
        End If
        ' Catch ex As Exception
        ' End Try
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Public Sub guardarCotizacionEnBD()
        MetodoMetasCotizador()
        'Try
        Dim R, status As String
        Dim modifico, cuenta As String
        modifico = "-"
        status = "Enviada"
        cuenta = "-"
        CuerpoMensaje = txtCuerpo.Text

        If CBFecha2.Checked = True Then
            FechaCalibracion = "-"
        Else
            FechaCalibracion = DTP.Value.ToString
        End If
        R = "insert into COTIZACIONES_INFORMALES (NombrePersona, Compania, Destinatario, Asunto,
                TipoDePrioridad, Referecia, FechaPropuestaParaCalibracion, MontoTotalPrecio,
                FechaDeCotizaciónInformal, ArchivoAdjunto, QuienMando, Observaciones, Modifico,
                CategoriaCliente, NumeroCuentaLims, Status, Informe, FechaCalibracionAnterior, Telefono, Ext, CuerpoMensaje) values
                ('" & txtNombre.Text & "','" & txtCompania.Text & "','" & txtDestinatario.Text & "',
                '" & txtAsunto.Text & "','" & cboPrioridad.Text & "','" & txtReferencia.Text & "',
                '" & FechaCalibracion & "','" & txtMonto.Text.Trim.TrimEnd.TrimStart & "','" & DTPFechaActual.Value & "','" & OpenFileDialog1.FileName & "',
                '" & txtNombreEmpleado.Text & "','" & txtObservacion.Text & "','" & modifico & "',
                '" & cboCategoria.Text & "','" & cuenta & "','" & status & "',
                '" & txtInforme.Text & "','" & DTPAnterior.Value & "','" & txtTel.Text.TrimEnd.Trim.TrimStart & "','" & txtExte.Text.TrimEnd.TrimStart & "','" & CuerpoMensaje & "')"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.ExecuteNonQuery()
        MsgBox("Cotización Guardada Correctamente")
        conexionMetasCotizador.Close()
        Me.Dispose()
        ' Catch ex As Exception
        'gBox("Ocurrio un error en la inserción de datos, verifica los datos insertados o llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
        'MsgBox("Descripciòn del error: " & ex.ToString)
        ' End Try

    End Sub

    ''-------------------------------------------- GroupBox de Clientes ---------------------------------------------------------------------------
    'Private Sub txtCuenta_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuenta.KeyUp
    '    ConexionGlobal()  ''CONEXION A LIMS, QUEDA PENDIENTE
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            Dim R As String
    '            R = "select FirstName, MiddleName, LastName, CompanyName, CategoryCustomer, KeyFiscal, Phone from SetupCustomerDetails where SetupCustomerDetails.CustAccountNo = " & txtCuenta.Text & ""
    '            Dim comando As New SqlCommand(R, conexion)
    '            Dim lector As SqlDataReader
    '            lector = comando.ExecuteReader
    '            If lector.Read() Then
    '                txtNombreC.Text = lector(0) & " " & lector(1) & " " & lector(2)
    '                txtCompaniaC.Text = lector(3)
    '                cboCategoriaC.Text = lector(4)
    '                txtRFC.Text = lector(5)
    '                txtTelefonoC.Text = lector(6)
    '                lector.Close()
    '                conexion.Close()
    '            Else
    '                MsgBox("No se encuentra el registro con el número: " & txtCuenta.Text, MsgBoxStyle.Information)
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
    '            MsgBox("Descripciòn del error: " & ex.ToString)
    '        End Try
    '    End If
    'End Sub

    'Public Sub guardarCotizacionClienteEnBD()
    '    ConexionGlobal2()
    '    Try ''fechaactual
    '        Dim R, status As String
    '        Dim modifico As String
    '        Dim Cuerpo As String
    '        Cuerpo = txtCuerpoC.Text + txtAdicionales.Text
    '        modifico = "-"
    '        status = "Enviada"
    '        CuerpoMensaje = txtCuerpo.Text

    '        If CBFecha.Checked = True Then
    '            FechaCalibracion = "-"
    '        Else
    '            FechaCalibracion = DTPCuandoC.Value.ToString
    '        End If
    '        R = "insert into COTIZACIONES_INFORMALES (NombrePersona, Compania, Destinatario, Asunto,
    '            TipoDePrioridad, Referecia, FechaPropuestaParaCalibracion, MontoTotalPrecio,
    '            FechaDeCotizaciónInformal, ArchivoAdjunto, QuienMando, Observaciones, Modifico,
    '            CategoriaCliente, NumeroCuentaLims, Status, Informe, FechaCalibracionAnterior, Telefono, Ext, CuerpoMensaje) values
    '            ('" & txtNombreC.Text & "','" & txtCompaniaC.Text & "','" & txtDestinatarioC.Text & "',
    '            '" & txtAsuntoC.Text & "','" & cboPrioridadC.Text & "','" & txtReferenciaC.Text & "',
    '            '" & FechaCalibracion & "','" & txtMontoTotalC.Text & "','" & DTPFechaActual.Value & "','" & OpenFileDialog1.FileName & "',
    '            '" & txtNombreEmpleado.Text & "','" & txtObservacionesC.Text & "','" & modifico & "',
    '            '" & cboCategoriaC.Text & "','" & txtCuenta.Text & "','" & status & "',
    '            '" & txtInformeC.Text & "','" & DTPAnterior.Value & "','" & txtTelefonoC.Text & "','" & txtExtC.Text & "','" & Cuerpo & "')"
    '        Dim comando As New SqlCommand(R, conexion2)
    '        comando.ExecuteNonQuery()
    '        MsgBox("Cotización Guardada Correctamente")
    '        conexion2.Close()
    '    Catch ex As Exception
    '        MsgBox("Ocurrio un error en la inserción de datos, verifica los datos insertados o llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
    '        MsgBox("Descripciòn del error: " & ex.ToString)
    '    End Try
    'End Sub

    Private Sub btSeleccionarArchivo_Click_1(sender As Object, e As EventArgs) Handles btSeleccionarArchivo.Click
        'Try
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            labelArchivo.Text = OpenFileDialog1.FileName
            cbAdjuntos.Checked = True
            cbAdjuntos.Enabled = True
        End If
        '   Catch ex As Exception
        '  MsgBox("Error en abrir el explorador de archivos.", MsgBoxStyle.Exclamation)
        '      MsgBox("Descripciòn del error: " & ex.ToString)
        ' End Try
    End Sub

    'Private Sub btEnviarC_Click_1(sender As Object, e As EventArgs) Handles btEnviarC.Click
    '    Try
    '        ''boton de Clientes PARTE DE CLIENTES, QUEDA DESHABILITADA POR EL MOMENTO

    '        If txtDestinatarioC.Text.Equals("") Or txtAsuntoC.Text.Equals("") Or txtCuerpoC.Text.Equals("") Or txtNombreC.Text.Equals("") Or txtReferenciaC.Text.Equals("") Or txtMontoTotalC.Text.Equals("") Or txtAdicionales.Text.Equals("") Then
    '            MsgBox("Completa los campos obligatorios.", MsgBoxStyle.Critical)
    '        Else
    '            fechaActual = DTPFechaActual.Value
    '            NameFirma = "Departamento de Ventas"
    '            Puesto = "Ventas"
    '            destinataro = txtDestinatarioC.Text
    '            quienEnvia = "Sandra Justo"
    '            cca = txtCCC.Text
    '            calibracion = DTPCuandoC.Value
    '            referencia = txtReferenciaC.Text
    '            Asunto = txtAsuntoC.Text
    '            CuerpoMensaje = "<html><body>"
    '            CuerpoMensaje = CuerpoMensaje & "<p><span style=font-size:11.0pt;font-family:Helvetica><b>Buen día " & txtNombreC.Text & ", en atención a su amable solicitud me permito enviarle una respuesta.</b></span></p>"
    '            ''  CuerpoMensaje = CuerpoMensaje & "<span style=font-size:11.0pt;font-family:Helvetica>__________________________________________________________</span><br>"
    '            CuerpoMensaje = CuerpoMensaje & "<span style=font-size:10.0pt;font-family:Helvetica>" & txtCuerpoC.Text & "</span>"
    '            '' CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'>Monto Total: <b>$" & txtMontoTotalC.Text & ".00</b><br>"
    '            '' CuerpoMensaje = CuerpoMensaje & "<span style=font-size:11.0pt;font-family:Helvetica>__________________________________________________________</span><br>"
    '            CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>Si usted desea una cotización formal, favor de confirmar por este mismo medio indicando datos completos de su empresa, así como especificaciones técnicas completa de su equipo.</b></span></p>"
    '            CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>De antemano agradecemos el habernos contactado.</b></span></p><br>"
    '            CuerpoMensaje = CuerpoMensaje & "<span style=font-size:9.0pt;font-family:Helvetica><b>Observaciones adicionales: </b></span><br>"
    '            CuerpoMensaje = CuerpoMensaje & "<span style=font-size:9.0pt;font-family:Helvetica>" & txtAdicionales.Text & "</span>"
    '            ' CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>Nota ó Referencia: </b>" & referencia & "<br></span></p>"
    '            ' CuerpoMensaje = CuerpoMensaje & "<p><span style='font-size:11.0pt;font-family:Helvetica'><b>Fecha estimada para sus calibraciones: </b>" & calibracion & "<br></span></p>"
    '            CuerpoMensaje = CuerpoMensaje & "</body></html>"
    '            ' establecemos las funciones
    '            Dim resultado As String
    '            objOutlook = CreateObject("Outlook.Application")
    '            objOutlookMsg = objOutlook.CreateItem(0)
    '            If cbAdjuntos.Checked = True Then
    '                With objOutlookMsg
    '                    .CC = cca
    '                    .Subject = Asunto
    '                    .HTMLBody = CuerpoMensaje
    '                    .To = destinataro
    '                    .Display
    '                    .Attachments.Add(OpenFileDialog1.FileName)
    '                End With
    '            Else
    '                With objOutlookMsg
    '                    .CC = cca
    '                    .Subject = Asunto
    '                    .HTMLBody = CuerpoMensaje
    '                    .To = destinataro
    '                    .Display
    '                    '.Attachments.Add(OpenFileDialog1.FileName)
    '                End With
    '            End If
    '            objOutlookMsg = Nothing
    '            objOutlook = Nothing
    '            guardarCotizacionClienteEnBD()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Ocurrio un error, comunicate con el administrador de sistemas.", MsgBoxStyle.Exclamation)
    '        MsgBox("Descripciòn del error: " & ex.ToString)
    '    End Try
    'End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Image = My.Resources.search_hover
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.search
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DGConsultaCot.Rows.Clear()
        DGConsultaCot.Visible = True
        DGConsultaCot2.Visible = False
        Dim Incio As String = FechaInicio.Value.Date
        Dim Final As String = FechaFinal.Value.Date

        ' Try
        MetodoMetasCotizador()
        ''Busqueda de cotizaciones por fecha
        Dim R As String
        'R = "select * from COTIZACIONES_INFORMALES where COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal between '" & Incio & "' and '" & Final & "'"
        R = "select * from COTIZACIONES_INFORMALES where COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal >= '" & Incio & "' and COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal <='" & Final & "'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read()
            DGConsultaCot.Rows.Add(lector(1), lector(2), lector(15), lector(0), lector(9), lector(7), lector(16), lector(8))
        End While
        lector.Close()
        conexionMetasCotizador.Close()
        ' Catch ex As Exception
        'MsgBox(" Ocurrio un error en la conexión de base de datos.", MsgBoxStyle.Exclamation)
        'MsgBox(" Descripciòn del error: " & ex.ToString)
        ' End Try
        For Each fila As DataGridViewRow In DGConsultaCot.Rows
            fila.Cells(" NumCot").Style.BackColor = Color.LightSteelBlue
        Next
    End Sub

    Public Sub consultaGeneral()
        ''AZAEL TENIA COMENTADO EL TRY Y CATCH 
        'DGConsultaCot.Rows.Clear()
        'Dim Incio As String = FechaInicio.Value.Date
        'Dim Final As String = FechaFinal.Value.Date
        'Try
        '    MetodoMetasCotizador()
        '    'conexion2.Open()
        '    Dim R As String
        '    R = " select * from COTIZACIONES_INFORMALES"
        '    Dim comando As New SqlCommand(R, conexionMetasCotizador)
        '    Dim lector As SqlDataReader
        '    lector = comando.ExecuteReader
        '    While lector.Read()
        '        DGConsultaCot.Rows.Add(lector(1), lector(2), lector(15), lector(0), lector(9), lector(7), lector(16), lector(8))
        '    End While
        '    lector.Close()
        '    conexionMetasCotizador.Close()
        'Catch ex As Exception
        '    MsgBox(" Ocurrio un error en la conexión de base de datos.", MsgBoxStyle.Exclamation)
        '    MsgBox(" Descripciòn del error: " & ex.ToString)
        'End Try
        'For Each fila As DataGridViewRow In DGConsultaCot.Rows
        '    fila.Cells(" NumCot").Style.BackColor = Color.LightSteelBlue
        'Next
    End Sub

    Private Sub txtClaveCot_TextChanged(sender As Object, e As EventArgs) Handles txtClaveCot.TextChanged


    End Sub

    Private Sub txtClaveCot_KeyUp(sender As Object, e As KeyEventArgs) Handles txtClaveCot.KeyUp
        'ConexionGlobal()
        If e.KeyCode = Keys.Enter Then
            '  Try
            MetodoMetasCotizador()
            Dim R As String
            R = " select * from COTIZACIONES_INFORMALES where COTIZACIONES_INFORMALES.idCotizacionInformal=" & txtClaveCot.Text & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.Read() Then
                txtNombreCot.Text = lector(1)
                txtCompaniaCot.Text = lector(2)
                cboPrioridadCot.Text = lector(5)
                txtReferenciaCot.Text = lector(6)
                txtFechaPropuestaCot.Text = lector(7)
                txtMontoCot.Text = lector(8)
                txtFechaCreacionCot.Text = lector(9)
                txtArchivoCot.Text = lector(10)
                labelCreo.Text = lector(11) & " --> " & lector(9)
                txtObservacionCot.Text = lector(12)
                txtQuienModifico.Text = lector(13)
                LabelEdito.Text = lector(13) & "--> " & lector(19)
                txtCategoriaCot.Text = lector(14)
                txtCuenta.Text = lector(15)
                txtStatusCot.Text = lector(16)
                txtInformeCot.Text = lector(17)
                txtFechaAnteriorCot.Text = lector(18)

                lector.Close()
                conexionMetasCotizador.Close()
            Else
                MsgBox("No existen datos de la Cotización número: " & txtClaveCot.Text, MsgBoxStyle.Exclamation)
            End If
            ' Catch ex As Exception
            ' MsgBox("Ocurrio un error, llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
            ' MsgBox("Descripciòn del error: " & ex.ToString)
            'End Try
        End If
    End Sub

    Private Sub btGuardarModificacion_Click(sender As Object, e As EventArgs) Handles btGuardarModificacion.Click
        MetodoMetasCotizador()
        ' Try ''fechaactual
        Dim R As String
        Dim modifico As String
        modifico = txtNombreEmpleado.Text

        If CBModificarFechadeCalibracion.Checked = True Then
            fechaModificada = DTPFechaActualizada.Value
        Else
            fechaModificada = txtFechaPropuestaCot.Text
        End If

        R = "update COTIZACIONES_INFORMALES set [TipoDePrioridad]= '" & cboPrioridadCot.Text & "', [Status]='" & txtStatusCot.Text & "', [Referecia]='" & txtReferenciaCot.Text & "', [MontoTotalPrecio]=" & txtMontoCot.Text & ", [FechaPropuestaParaCalibracion]='" & fechaModificada & "', [Modifico]='" & txtNombreEmpleado.Text & "', [FechaModificacion]='" & DTPFechaActual.Value & "' where COTIZACIONES_INFORMALES.idCotizacionInformal=" & Val(txtClaveCot.Text) & ""
        '' update COTIZACIONES_INFORMALES set [TipoDePrioridad]= 'X', [Status]='X', [Referecia]='X', [MontoTotalPrecio]=666, [FechaPropuestaParaCalibracion]='x' where COTIZACIONES_INFORMALES.idCotizacionInformal=1
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.ExecuteNonQuery()
        MsgBox("Cotización Modificada Correctamente", MsgBoxStyle.Information)
        conexionMetasCotizador.Close()
        borrarTextos()
        '  Catch ex As Exception
        ' MsgBox("Ocurrio un error en la actualización de datos, VERIFICA QUE LA CLAVE SEA CORRECTA o llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
        'Box("Descripciòn del error: " & ex.ToString)
        'End Try
    End Sub

    Private Sub txtNameBusq_TextChanged(sender As Object, e As EventArgs) Handles txtNameBusq.TextChanged
        'Try
        MetodoMetasCotizador()
        DGConsultaCot.Visible = False
        DGConsultaCot2.Visible = True
        Dim R As String
        Dim Incio As String = FechaInicio.Value.Date
        Dim Final As String = FechaFinal.Value.Date
        R = "select NombrePersona, Compania, NumeroCuentaLIMS, idCotizacionInformal, [FechaDeCotizaciónInformal], [FechaPropuestaParaCalibracion], [Status], [MontoTotalPrecio] from [COTIZACIONES_INFORMALES] where COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal >= '" & Incio & "' and COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal <='" & Final & "' and [COTIZACIONES_INFORMALES].NombrePersona Like '%' + @Nombre + '%'"
        '[COTIZACIONES_INFORMALES].NombrePersona Like '%' + @Nombre + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@Nombre", txtNameBusq.Text)
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            DGConsultaCot2.DataSource = Nothing
        Else
            DGConsultaCot2.DataSource = dt
            'txtClaveEmpresa.Enabled = True
        End If
        For Each fila As DataGridViewRow In DGConsultaCot2.Rows
            fila.Cells("idCotizacionInformal").Style.BackColor = Color.LightSteelBlue
        Next
        conexionMetasCotizador.Close()
        ' Catch ex As Exception
        ' MsgBox("Ocurrio un error en la lectura de datos del NOMBRE, porfavor verificalo, o llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
        'MsgBox("Descripciòn del error: " & ex.ToString)
        '  End Try
    End Sub

    'Private Sub CBFecha_Click(sender As Object, e As EventArgs) Handles CBFecha.Click
    '    CBFecha.Checked = True
    '    CBFecha.Enabled = False
    '    DTPCuandoC.Enabled = False
    '    ' FechaCalibracion = "Sin fecha" '' guardar essta variable en insert de clientes
    'End Sub



    Private Sub CBModificarFechadeCalibracion_Click(sender As Object, e As EventArgs) Handles CBModificarFechadeCalibracion.Click
        If bandera = 0 And CBModificarFechadeCalibracion.Checked = False Then
            bandera = 1
            CBModificarFechadeCalibracion.Checked = True
            DTPFechaActualizada.Visible = True
            DTPFechaActualizada.Enabled = True
        ElseIf bandera = 1 And CBModificarFechadeCalibracion.Checked = True Then
            CBModificarFechadeCalibracion.Checked = False
            bandera = 0
            DTPFechaActualizada.Visible = False
            DTPFechaActualizada.Enabled = False
        Else
            'bandera = 1
            'CBModificarFechadeCalibracion.Checked = True
            ''CBModificarFechadeCalibracion.Enabled = False
        End If
    End Sub

    Private Sub borrarTextos()
        txtFechaCreacionCot.Text = ""
        txtClaveCot.Text = ""
        txtNombreCot.Text = ""
        txtCompaniaCot.Text = ""
        cboPrioridadCot.Text = ""
        txtStatusCot.Text = ""
        txtCategoriaCot.Text = ""
        txtReferenciaCot.Text = ""
        txtArchivoCot.Text = ""
        txtMontoCot.Text = ""
        CBModificarFechadeCalibracion.Checked = False
        DTPFechaActualizada.Visible = False
        txtFechaPropuestaCot.Text = ""
        txtFechaAnteriorCot.Text = ""
        txtInformeCot.Text = ""
        txtObservacionCot.Text = ""
        labelCreo.Text = "-"
        LabelEdito.Text = "-"
        txtNameBusq.Text = ""
        cboStatus.Text = "---Selecciona una opciòn---"
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        DGConsultaCot2.Visible = False
        DGConsultaCot.Visible = True
        DGConsultaCot.Rows.Clear()
        'Try
        MetodoMetasCotizador()
        Dim R As String
        Dim Incio As String = FechaInicio.Value.Date
        Dim Final As String = FechaFinal.Value.Date
        R = "select * from COTIZACIONES_INFORMALES where COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal >= '" & Incio & "' and COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal <='" & Final & "' and  COTIZACIONES_INFORMALES.Status= '" & cboStatus.Text & "'"
        ''where COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal >= '" & Incio & "' and COTIZACIONES_INFORMALES.FechaDeCotizaciónInformal <='" & Final & "' and [COTIZACIONES_INFORMALES].NombrePersona Like '%' + @Nombre + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read()
            DGConsultaCot.Rows.Add(lector(1), lector(2), lector(15), lector(0), lector(9), lector(7), lector(16), lector(8))
        End While
        lector.Close()
        conexionMetasCotizador.Close()
        '  Catch ex As Exception
        'MsgBox(" Ocurrio un error en la conexión de base de datos.", MsgBoxStyle.Exclamation)
        'sgBox("Descripciòn del error: " & ex.ToString)
        'End Try
        For Each fila As DataGridViewRow In DGConsultaCot.Rows
            fila.Cells("NumCot").Style.BackColor = Color.LightSteelBlue
        Next
    End Sub

    ' Private Sub CBFecha2_Click(sender As Object, e As EventArgs) Handles CBFecha2.Click
    'CBFecha2.Checked = True
    'CBFecha2.Enabled = False
    'DTP.Enabled = False
    ' End Sub


    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress, txtTel.KeyPress, txtExte.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'Private Function ValidaEMail(Cadena As String) As Boolean
    '    Dim Arroba As Long
    '    Dim Punto As Long
    '    ValidaEMail = False
    '    Arroba = InStr(1, Cadena, "@")
    '    Punto = InStr(5, Cadena, ".")
    '    If (Arroba > 1) And (Punto > 1) And (Punto < Arroba) Then
    '        ValidaEMail = True
    '    End If
    'End Function

    'Private Sub txtDestinatario_LostFocus(sender As Object, e As EventArgs) Handles txtDestinatario.LostFocus
    '    If Not ValidaEMail(txtDestinatario.Text) Then
    '        MsgBox("El Formato de correo es incorrecto", MsgBoxStyle.Information)
    '        txtDestinatario.Text = ""
    '    End If
    'End Sub

    'Private Sub txtCCC_LostFocus(sender As Object, e As EventArgs) Handles txtcc.LostFocus
    '    If Not ValidaEMail(txtcc.Text) Then
    '        MsgBox("El Formato de correo es incorrecto", MsgBoxStyle.Information)
    '        txtcc.Text = ""
    '    End If
    'End Sub

    Private Sub CBFecha2_CheckStateChanged(sender As Object, e As EventArgs) Handles CBFecha2.CheckStateChanged
        ' MsgBox(bandera)
        If bandera = 1 Then
            'MsgBox("Activado")
            CBFecha2.Checked = True
            'CBFecha2.Enabled = False
            DTP.Enabled = False
            bandera = 0
        ElseIf bandera = 0 Then
            'MsgBox("Desactivado")
            CBFecha2.Checked = False
            'CBFecha2.Enabled = True
            DTP.Enabled = True
            bandera = 1
        End If
    End Sub
End Class