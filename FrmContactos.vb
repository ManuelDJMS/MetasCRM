Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FrmContactos
    Dim claveConsultaAdd As String
    Dim isActive, isCOD, isTaxable, isCallDataReq, isOOT, isCall, isDigitalCertified, isShipActive As Boolean
    Private Sub FrmContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        consultaGeneralContactos()
        alternarColorColumnas(DGConsulta)
        alternarColorColumnas(DGAdicionales)
        alternarColorColumnas(DGInstrumentos)

        cboRelacionadoConLlamada.Items.Add("Cotización")
        cboRelacionadoConLlamada.Items.Add("Información general")
        cboRelacionadoConLlamada.Items.Add("Descuento especial")
        cboRelacionadoConLlamada.Items.Add("Presupuesto")
        cboRelacionadoConLlamada.Items.Add("Otro")

        cboRelacionadoConTareas.Items.Add("Cotizaciones")
        cboRelacionadoConTareas.Items.Add("Documentos")
        cboRelacionadoConTareas.Items.Add("Permiso")
        cboRelacionadoConTareas.Items.Add("Personales")
        cboRelacionadoConTareas.Items.Add("Avisos")
        cboRelacionadoConTareas.Items.Add("Otros")
    End Sub
    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.Silver
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub


    Private Sub DGConsulta_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGConsulta.RowHeaderMouseClick
        Try
            Dim clave As String
            clave = DGConsulta.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtClaveRecopilada.Text = clave
            TextBox2.Text = clave
            consultaDatosContactos(clave)
            TabConsulta.SelectTab(1)
            'Evento click para la regilla---------------------------
        Catch ex As Exception
            MsgBox("Selecciona un registro válido de la regilla.", MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub DGInstrumentos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGInstrumentos.RowHeaderMouseClick
        Try
            Dim clave As String
            clave = DGInstrumentos.Rows(e.RowIndex).Cells(0).Value.ToString()
            MsgBox("Seleccionaste: " & clave)


        Catch ex As Exception
            MsgBox("Selecciona un registro válido de la regilla.", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub ConsultaDatosEquipos(ByVal claveInstrumento As Integer)
        Try
            conexionLIMS.Open()
            Dim R As String
            R = " select SetUpEquipment.[EquipId], SetupCustomerEquipmentMapping.CustomerId, SetupCustomerEquipmentMapping.[CustEquipMapId], SetUpEquipment.[EquipmentName], SetupCustomerEquipmentMapping.[InstrumentId]
	            ,SetupCustomerEquipmentMapping.[SrlNo], SetUpEquipment.[Model] ,SetUpEquipment.[Mfr] ,SetupCustomerEquipmentMapping.[Dept] ,SetupCustomerEquipmentMapping.[Location]
	            ,SetupCustomerEquipmentMapping.[CALDue] ,SetupCustomerEquipmentMapping.[IsActive],SetUpEquipment.[ItemNumber]
                ,SetUpEquipment.[AdditionalSepcification] from SetUpEquipment inner join SetupCustomerEquipmentMapping on SetupCustomerEquipmentMapping.EquipId=
	            SetUpEquipment.EquipId where SetupCustomerEquipmentMapping.CustomerId = " & claveInstrumento & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Error en la búsqueda.", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub consultaDatosContactos(ByVal clave As String)
        Try
            Dim vacio As String = "---"
            Dim cadenaCorreos As String
            MetodoLIMS()
            Dim R As String
            R = "select SetupCustomerDetails.[CustomerId]
                  ,SetupCustomerDetails.[CustAccountNo]
                  ,SetupCustomerDetails.[FirstName]
                  ,SetupCustomerDetails.[MiddleName]
                  ,SetupCustomerDetails.[LastName]
                  ,SetupCustomerDetails.[Phone]
                  ,SetupCustomerDetails.[Mobile]
                  ,SetupCustomerDetails.[Email]
                  ,SetupCustomerDetails.[Fax]
                  ,SetupCustomerDetails.[CompanyName]
                  ,SetupCustomerDetails.[IsActive]
                  ,SetupCustomerDetails.[Source]
                  ,SetupCustomerDetails.[AdminType]
                  ,SetupCustomerDetails.[PaymentTerms]
                  ,SetupCustomerDetails.[IsCod]
                  ,SetupCustomerDetails.[IsTaxable]
                  ,SetupCustomerDetails.[IsCallDataReq]
                  ,SetupCustomerDetails.[IsOOTNoticeReq]
                  ,SetupCustomerDetails.[IsCallHistoryReq]
                  ,SetupCustomerDetails.[QualityReqment]
                  ,SetupCustomerDetails.[CallDueDateAdj]
                  ,SetupCustomerDetails.[LabNotes]
                  ,SetupCustomerDetails.[CreatedBy]
                  ,SetupCustomerDetails.[CreatedOn]
                  ,SetupCustomerDetails.[ModifiedBy]
                  ,SetupCustomerDetails.[ModifiedOn]
                  ,SetupCustomerDetails.[DefaultPO]
                  ,SetupCustomerDetails.[ShipMode]
                  ,SetupCustomerDetails.[CalDiscount]
                  ,SetupCustomerDetails.[TaxExemption]
                  ,SetupCustomerDetails.[Department]
                  ,SetupCustomerDetails.[Email2]
                  ,SetupCustomerDetails.[CategoryCustomer]
                  ,SetupCustomerDetails.[TaxIDNo]
                  ,SetupCustomerDetails.[Currency]
                  ,SetupCustomerDetails.[PaymentOption]
                  ,SetupCustomerDetails.[ShipmentAccount]
                  ,SetupCustomerDetails.[WorkingHours]
                  ,SetupCustomerDetails.[RecallNotice]
                  ,SetupCustomerDetails.[AttachmentName]
                  ,SetupCustomerDetails.[IsDigitalCertificate]
                  ,SetupCustomerDetails.[Attachment]
                  ,SetupCustomerDetails.[IsShipAccActive]
                  ,SetupCustomerDetails.[KeyFiscal]
                  ,SetupCustomerDetails.[Organization]
	              ,SetupCustomerAddressDtls.[AddressId]
                  ,SetupCustomerAddressDtls.[CustomerId]
                  ,SetupCustomerAddressDtls.[ContAddress1]
                  ,SetupCustomerAddressDtls.[ContAddress2]
                  ,SetupCustomerAddressDtls.[ContAddress3]
                  ,SetupCustomerAddressDtls.[ContCity]
                  ,SetupCustomerAddressDtls.[ContState]
                  ,SetupCustomerAddressDtls.[ContZip]
                  ,SetupCustomerAddressDtls.[BillAddress1]
                  ,SetupCustomerAddressDtls.[BillAddress2]
                  ,SetupCustomerAddressDtls.[BillAddress3]
                  ,SetupCustomerAddressDtls.[BillCity]
                  ,SetupCustomerAddressDtls.[BillState]
                  ,SetupCustomerAddressDtls.[BillZip]
                  ,SetupCustomerAddressDtls.[ShipAddress1]
                  ,SetupCustomerAddressDtls.[ShipAddress2]
                  ,SetupCustomerAddressDtls.[ShipAddress3]
                  ,SetupCustomerAddressDtls.[ShipCity]
                  ,SetupCustomerAddressDtls.[ShipState]
                  ,SetupCustomerAddressDtls.[ShipZip]
                  ,SetupCustomerAddressDtls.[ContCountry]
                  ,SetupCustomerAddressDtls.[BillCountry]
                  ,SetupCustomerAddressDtls.[ShipCountry]
	              from SetupCustomerDetails
	              inner join SetupCustomerAddressDtls on SetupCustomerDetails.CustomerId =  SetupCustomerAddressDtls.CustomerId  where SetupCustomerDetails.[CustomerId]= " & clave & ""

            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader()
            If lector.Read() Then

                txtClaveRecopilada.Text = lector(0)
                txtNumeroDeCuenta.Text = lector(1)
                txtNombreDeContacto.Text = lector(2) & " " & lector(3) & " " & lector(4)
                EtiquetaNombreDeProspecto.Text = lector(2) & " " & lector(3) & " " & lector(4)
                EtiquetaNombreDeProspecto2.Text = lector(2) & " " & lector(3) & " " & lector(4)
                txtTelefono.Text = lector(5)
                txtCelular.Text = lector(6)
                txtCorreo1.Text = lector(7)
                txtFax.Text = lector(8)
                txtNombreCompania.Text = lector(9)
                txtDepartamento.Text = lector(30)

                txtDireccion.Text = lector(47)
                txtEdo.Text = lector(51)
                txtCiudad.Text = lector(50)
                txtDireccion2.Text = lector(48)
                txtDireccion3.Text = lector(49)
                txtCodigoPostal.Text = lector(52)
                txtPais.Text = lector(65)

                txtDireccion1DeFacturacion.Text = lector(53)
                txtEstadoDeFacturacion.Text = lector(57)
                txtCiudadDeFacturacion.Text = lector(56)
                txtDireccion2DeFacturacion.Text = lector(54)
                txtDireccion3DeFacturacion.Text = lector(55)
                txtCPDeFacturacion.Text = lector(58)
                txtPaisDeFacturacion.Text = lector(66)


                txtDireccion1DeEntrega.Text = lector(59)
                txtEstadoDeEntrega.Text = lector(63)
                txtCiudadDeEntrega.Text = lector(62)
                txtDireccion2DeEntrega.Text = lector(60)
                txtDireccion3DeEntrega.Text = lector(61)
                txtCPDeEntrega.Text = lector(64)
                txtPaisDeEntrega.Text = lector(67)



                If lector(10).ToString.Trim.Equals("Y") Then
                    isActive = True
                    cbActivo1.Checked = True
                Else
                    isActive = False
                    cbActivo1.Checked = False
                End If


                txtTerminosDePago.Text = lector(13)

                If lector(14).ToString.Trim.Equals("Y") Then
                    cbCOD.Checked = True
                Else
                    cbCOD.Checked = False
                End If
                If lector(15).ToString.Trim.Equals("Y") Then
                    cbTaxable.Checked = True
                Else
                    cbTaxable.Checked = False
                End If
                If lector(16).ToString.Trim.Equals("Y") Then
                    CBCalibrationDataRequiered.Checked = True
                Else
                    CBCalibrationDataRequiered.Checked = False
                End If
                If lector(17).ToString.Trim.Equals("Y") Then
                    CBOOTNoticeRequiered.Checked = True
                Else
                    CBOOTNoticeRequiered.Checked = False
                End If
                If lector(18).ToString.Trim.Equals("Y") Then
                    CBRequiresCalHistory.Checked = True
                Else
                    CBRequiresCalHistory.Checked = False
                End If


                If lector(19).ToString.Trim.Equals("0") Then
                    txtCalidad.Text = "Nuclear - 10CFR"
                ElseIf lector(19).ToString.Trim.Equals("1") Then
                    txtCalidad.Text = "ISO/IEC 17025, ANSI Z540"
                ElseIf lector(19).ToString.Trim.Equals("2") Then
                    txtCalidad.Text = "Ninguno"
                ElseIf lector(19).ToString.Trim.Equals("3") Then
                    txtCalidad.Text = "Aplicar requerimiento especial"
                ElseIf lector(19).ToString.Trim.Equals("4") Then
                    txtCalidad.Text = "MIL-STD-45662A"
                ElseIf lector(19).ToString.Trim.Equals("5") Then
                    txtCalidad.Text = "ISO 10012-1"
                Else
                    txtCalidad.Text = "Otro"
                End If


                If lector(20).ToString.Trim.Equals("0") Then
                    txtCalDueDate.Text = "Nuclear"
                ElseIf lector(20).ToString.Trim.Equals("1") Then
                    txtCalDueDate.Text = "ISO"
                ElseIf lector(20).toString.Trim.Equals("2") Then
                    txtCalDueDate.Text = "Ninguno"
                ElseIf lector(20).ToString.Trim.Equals("3") Then
                    txtCalDueDate.Text = "Aplica"
                ElseIf lector(20).ToString.Trim.Equals("4") Then
                    txtCalDueDate.Text = "MIL"
                ElseIf lector(20).ToString.Trim.Equals("5") Then
                    txtCalDueDate.Text = "ISO"
                Else
                    txtCalDueDate.Text = "Otro"
                End If


                If lector(11).ToString.Trim.Equals("1") Then
                    txtOrigenContacto.Text = "Llamada de venta"
                ElseIf lector(11).ToString.Trim.Equals("2") Then
                    txtOrigenContacto.Text = "Recomendación del cliente"
                ElseIf lector(11).ToString.Trim.Equals("3") Then
                    txtOrigenContacto.Text = "Internet"
                ElseIf lector(11).ToString.Trim.Equals("4") Then
                    txtOrigenContacto.Text = "Revista de comercio"
                ElseIf lector(11).ToString.Trim.Equals("5") Then
                    txtOrigenContacto.Text = "Contacto del empleado"
                ElseIf lector(11).ToString.Trim.Equals("6") Then
                    txtOrigenContacto.Text = "Otro"
                ElseIf lector(11).ToString.Trim.Equals("7") Then
                    txtOrigenContacto.Text = "Expo/Conferencias"
                Else
                    txtOrigenContacto.Text = "Publicidad"
                End If


                If lector(12).ToString.Trim.Equals("1") Then
                    txtTipoDeCliente.Text = "Comercial"
                ElseIf lector(12).ToString.Trim.Equals("2") Then
                    txtTipoDeCliente.Text = "Gobierno"
                Else
                    txtTipoDeCliente.Text = "Publica"
                End If








                txtTerminosDePago.Text = lector(13)
                txtCategoria.Text = lector(32)
                txtIDFiscal.Text = lector(33)

                txtOpcionesDePago.Text = lector(35)
                Label2.Text = lector(35)



                txtNotasLab.Text = lector(21)

                If lector(34).ToString.Trim.Equals("1") Then
                    txtMoneda.Text = "US Dolar"
                ElseIf lector(34).ToString.Trim.Equals("2") Then
                    txtMoneda.Text = "Libra"
                ElseIf lector(34).ToString.Trim.Equals("0") Then
                    txtMoneda.Text = "Peso Mexicano"
                Else
                    txtMoneda.Text = "Euro"
                End If


                If lector(26).ToString.Trim.Equals("1") Then
                    txtDefaultPO.Text = "Llamar antes de facturar"
                ElseIf lector(26).ToString.Trim.Equals("2") Then
                    txtDefaultPO.Text = "Llamar antes de enviar"
                ElseIf lector(26).ToString.Trim.Equals("3") Then
                    txtDefaultPO.Text = "No requerido"
                ElseIf lector(26).ToString.Trim.Equals("4") Then
                    txtDefaultPO.Text = "Gastos generales"
                ElseIf lector(26).ToString.Trim.Equals("5") Then
                    txtDefaultPO.Text = "Verbal"
                ElseIf lector(26).ToString.Trim.Equals("6") Then
                    txtDefaultPO.Text = "Otro"
                Else
                    txtDefaultPO.Text = "No definido"
                End If






                If lector(27).ToString.Trim.Equals("7") Then
                    txtModoDeEnvio.Text = "DHL Worldwide Express"
                ElseIf lector(27).ToString.Trim.Equals("11") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("12") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("13") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("14") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("15") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("16") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("17") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("18") Then
                    txtModoDeEnvio.Text = "FedEx"
                ElseIf lector(27).ToString.Trim.Equals("21") Then
                    txtModoDeEnvio.Text = "Local"
                ElseIf lector(27).ToString.Trim.Equals("22") Then
                    txtModoDeEnvio.Text = "En sitio"
                ElseIf lector(27).ToString.Trim.Equals("23") Then
                    txtModoDeEnvio.Text = "Recolección"
                ElseIf lector(27).ToString.Trim.Equals("27") Then
                    txtModoDeEnvio.Text = "UPS"
                ElseIf lector(27).ToString.Trim.Equals("28") Then
                    txtModoDeEnvio.Text = "UPS"
                ElseIf lector(27).ToString.Trim.Equals("29") Then
                    txtModoDeEnvio.Text = "UPS"
                ElseIf lector(27).ToString.Trim.Equals("30") Then
                    txtModoDeEnvio.Text = "UPS"
                ElseIf lector(27).ToString.Trim.Equals("31") Then
                    txtModoDeEnvio.Text = "UPS"
                ElseIf lector(27).ToString.Trim.Equals("32") Then
                    txtModoDeEnvio.Text = "UPS"
                Else
                    txtModoDeEnvio.Text = "No definido"
                End If



                txtDescuentoDeCal.Text = lector(28)
                txtTaxEx.Text = lector(29)
                txtCuentaDeEnvio.Text = lector(36)
                txtHorarioDeTrabajo.Text = lector(37)


                If lector(38).ToString.Trim.Equals("0") Then
                    txtAvisoDeRecupeacion.Text = "Llamada"
                ElseIf lector(38).ToString.Trim.Equals("1") Then
                    txtAvisoDeRecupeacion.Text = "Texto"
                Else
                    txtAvisoDeRecupeacion.Text = "Ambos"
                End If

                If lector(40).ToString.Trim.Equals("Y") Then
                    CBOnlyDigitalCer.Checked = True

                Else
                    CBOnlyDigitalCer.Checked = False
                End If

                If lector(42).ToString.Trim.Equals("Y") Then
                    cbActivo2.Checked = True
                Else
                    cbActivo2.Checked = False
                End If

                txtKeyFiscal.Text = lector(43)
                txtOrganizacion.Text = lector(44)
                lector.Close()
                conexionLIMS.Close()

                conexionLIMS.Open()
                DGAdicionales.Rows.Clear()
                Dim x As String
                MsgBox(clave)
                x = "select [CustomerEmailId], [FName], [LName], [Department], [EmailId] from [SetupCustomerEmails] where CustomerId= " & clave & ""
                Dim comandox As New SqlCommand(x, conexionLIMS)
                Dim lectorx As SqlDataReader
                lectorx = comandox.ExecuteReader
                While lectorx.Read()
                    DGAdicionales.Rows.Add(lectorx(0), lectorx(1), lectorx(2), lectorx(3), lectorx(4))
                End While
                lectorx.Close()
                conexionLIMS.Close()


                conexionLIMS.Open()
                DGInstrumentos.Rows.Clear()
                Dim y As String
                y = "select SetUpEquipment.[EquipId], SetupCustomerEquipmentMapping.CustomerId, SetupCustomerEquipmentMapping.[CustEquipMapId], 
                    SetUpEquipment.[EquipmentName], SetupCustomerEquipmentMapping.[InstrumentId]
	                ,SetupCustomerEquipmentMapping.[SrlNo], SetUpEquipment.[Model] ,SetUpEquipment.[Mfr] ,SetupCustomerEquipmentMapping.[Dept] 
                    ,SetupCustomerEquipmentMapping.[Location]
	                ,SetupCustomerEquipmentMapping.[CALDue]  ,SetupCustomerEquipmentMapping.[IsActive] from SetUpEquipment 
                    inner join SetupCustomerEquipmentMapping on SetupCustomerEquipmentMapping.EquipId=
	                SetUpEquipment.EquipId  where SetupCustomerEquipmentMapping.CustomerId = " & clave & ""
                Dim comandoy As New SqlCommand(y, conexionLIMS)
                Dim lectory As SqlDataReader
                lectory = comandoy.ExecuteReader
                While lectory.Read()
                    DGInstrumentos.Rows.Add(lectory(3), lectory(4), lectory(5), lectory(6), lectory(7), lectory(8), lectory(9), lectory(10), lectory(11))
                End While
                lectory.Close()
                conexionLIMS.Close()

                conexionLIMS.Open()
                Dim a As String
                a = "select SetUpEquipment.[EquipId], SetupCustomerEquipmentMapping.CustomerId, SetupCustomerEquipmentMapping.[CustEquipMapId], 
                    SetUpEquipment.[EquipmentName], SetupCustomerEquipmentMapping.[InstrumentId]
	                ,SetupCustomerEquipmentMapping.[SrlNo], SetUpEquipment.[Model] ,SetUpEquipment.[Mfr] ,SetupCustomerEquipmentMapping.[Dept] 
                    ,SetupCustomerEquipmentMapping.[Location]
	                ,SetupCustomerEquipmentMapping.[CALDue]  ,SetupCustomerEquipmentMapping.[IsActive] from SetUpEquipment 
                    inner join SetupCustomerEquipmentMapping on SetupCustomerEquipmentMapping.EquipId=
	                SetUpEquipment.EquipId  where SetupCustomerEquipmentMapping.CustomerId = " & clave & ""
                Dim comandoa As New SqlCommand(a, conexionLIMS)
                Dim lectora As SqlDataReader
                lectora = comandoy.ExecuteReader
                lectora.Close()
                conexionLIMS.Close()
            Else
                MsgBox("No existen datos de registro.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error de lectura.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabConsulta.SelectTab(2)
    End Sub

    Private Sub btAgregarTarea_Click(sender As Object, e As EventArgs) Handles btAgregarTarea.Click
        If txtAsuntoTarea.Text.Equals("") Or txtAsignadoTarea.Text.Equals("") Or cboRelacionadoConTareas.Text.Equals("") Then
            MsgBox("No se pueden dejar campos vacios.", MsgBoxStyle.Exclamation)
        Else
            Try
                MetodoMetasCotizador()
                Dim R As String
                R = "insert into [ActividadTareaContactos] (CustomerId, Asunto, Comentarios, FechaDeVencimiento, RelacionadoCon) values (" & txtClaveRecopilada.Text & ",'" & txtAsuntoTarea.Text & "','" & txtAsignadoTarea.Text & "','" & DTPFechaDeVencimiento.Value.ToShortDateString.ToString & "','" & cboRelacionadoConTareas.Text & "')"
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                MsgBox("Tarea registrada correctamente", MsgBoxStyle.Information)
                conexionMetasCotizador.Close()
                txtAsuntoTarea.Text = ""
                txtAsignadoTarea.Text = ""
            Catch ex As Exception
                MsgBox("Error al agregar llamada", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btAgregarLlamada_Click(sender As Object, e As EventArgs) Handles btAgregarLlamada.Click
        If txtAsuntoLlamada.Text.Equals("") Or txtComentariosLlamada.Text.Equals("") Or cboRelacionadoConLlamada.Text.Equals("") Then
            MsgBox("No se pueden dejar campos vacios.", MsgBoxStyle.Exclamation)
        Else
            Try
                MetodoMetasCotizador()
                Dim R As String
                R = "insert into [ActividadLlamadaContactos] (CustomerId, Asunto, Comentarios, FechaEstimadaDeLlamada, RelacionadoCon) values (" & txtClaveRecopilada.Text & ",'" & txtAsuntoLlamada.Text & "','" & txtComentariosLlamada.Text & "','" & DTPFechaEstimadaDeLlamada.Value.ToShortDateString.ToString & "','" & cboRelacionadoConLlamada.Text & "')"
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                MsgBox("Llamada registrada correctamente", MsgBoxStyle.Information)
                conexionMetasCotizador.Close()
                txtAsuntoLlamada.Text = ""
                txtComentariosLlamada.Text = ""
            Catch ex As Exception
                MsgBox("Error al agregar llamada", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        consultaGeneralContactos()
        txtNombreB.Text = ""
        txtNumeroDeCuentaB.Text = ""
        txtCompaniaB.Text = ""
        txtCorreoB.Text = ""
    End Sub

    Public Sub consultaGeneralContactos()
        Try
            MetodoLIMS()
            DGConsulta.Refresh()
            Dim R As String
            R = "  select [CustomerId] as idContacto, [FirstName] as [Nombre], [LastName] as [Apellidos], [CompanyName] as Empresa, [CustAccountNo] as [No. Cuenta], [Email] as Correo, [PaymentTerms] as [Terminos de pago], [CustomerType] as [Tipo de Contacto], [IsTaxable] as [¿Con IVA?] from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
                inner join [MetAs_Live-pruebas].[dbo].[MasterPoPickList] on [MetAs_Live-pruebas].[dbo].[MasterPoPickList].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[DefaultPO] 
                left join [MetAs_Live-pruebas].[dbo].[SetupCustomerSource] on [MetAs_Live-pruebas].[dbo].[SetupCustomerSource].[id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[Source] 
                left join [MetAs_Live-pruebas].[dbo].[MasterCustomerType] on [MetAs_Live-pruebas].[dbo].[MasterCustomerType].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[AdminType] 
                left join [MetAs_Live-pruebas].[dbo].[SetupShippingMode] on [MetAs_Live-pruebas].[dbo].[SetupShippingMode].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[ShipMode] 
                order by [FirstName]"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGConsulta.DataSource = dt
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Try
            Dim R As String
            DGConsulta.Rows.Clear()
            R = "select [CustomerId] as idContacto, [FirstName] as [Nombre], [LastName] as [Apellidos], [CompanyName] as Empresa, [CustAccountNo] as [No. Cuenta], [Email] as Correo, [PaymentTerms] as [Terminos de pago], [CustomerType] as [Tipo de Contacto], [IsTaxable] as [¿Con IVA?] from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
                inner join [MetAs_Live-pruebas].[dbo].[MasterPoPickList] on [MetAs_Live-pruebas].[dbo].[MasterPoPickList].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[DefaultPO] 
                left join [MetAs_Live-pruebas].[dbo].[SetupCustomerSource] on [MetAs_Live-pruebas].[dbo].[SetupCustomerSource].[id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[Source] 
                left join [MetAs_Live-pruebas].[dbo].[MasterCustomerType] on [MetAs_Live-pruebas].[dbo].[MasterCustomerType].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[AdminType] 
                left join [MetAs_Live-pruebas].[dbo].[SetupShippingMode] on [MetAs_Live-pruebas].[dbo].[SetupShippingMode].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[ShipMode] where SetupCustomerDetails.FirstName Like '%' + @clave + '%'"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@clave", txtNombreB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                'txtClaveEmpresa.Enabled = True
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Nombre").Style.BackColor = Color.LightCyan
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtCompaniaB_TextChanged(sender As Object, e As EventArgs) Handles txtCompaniaB.TextChanged
        Try
            Dim R As String
            DGConsulta.Rows.Clear()
            R = "select [CustomerId] as idContacto, [FirstName] as [Nombre], [LastName] as [Apellidos], [CompanyName] as Empresa, [CustAccountNo] as [No. Cuenta], [Email] as Correo, [PaymentTerms] as [Terminos de pago], [CustomerType] as [Tipo de Contacto], [IsTaxable] as [¿Con IVA?] from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
                inner join [MetAs_Live-pruebas].[dbo].[MasterPoPickList] on [MetAs_Live-pruebas].[dbo].[MasterPoPickList].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[DefaultPO] 
                left join [MetAs_Live-pruebas].[dbo].[SetupCustomerSource] on [MetAs_Live-pruebas].[dbo].[SetupCustomerSource].[id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[Source] 
                left join [MetAs_Live-pruebas].[dbo].[MasterCustomerType] on [MetAs_Live-pruebas].[dbo].[MasterCustomerType].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[AdminType] 
                left join [MetAs_Live-pruebas].[dbo].[SetupShippingMode] on [MetAs_Live-pruebas].[dbo].[SetupShippingMode].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[ShipMode] 
            where SetupCustomerDetails.CompanyName Like '%' + @clave + '%'"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@clave", txtCompaniaB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                'txtClaveEmpresa.Enabled = True
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Empresa").Style.BackColor = Color.LightCyan
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtNumeroDeCuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroDeCuentaB.TextChanged
        ''código de consulta
        Try
            Dim R As String
            DGConsulta.Rows.Clear()
            R = "select [CustomerId] as idContacto, [FirstName] as [Nombre], [LastName] as [Apellidos], [CompanyName] as Empresa, [CustAccountNo] as [No. Cuenta], [Email] as Correo, [PaymentTerms] as [Terminos de pago], [CustomerType] as [Tipo de Contacto], [IsTaxable] as [¿Con IVA?] from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
                inner join [MetAs_Live-pruebas].[dbo].[MasterPoPickList] on [MetAs_Live-pruebas].[dbo].[MasterPoPickList].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[DefaultPO] 
                left join [MetAs_Live-pruebas].[dbo].[SetupCustomerSource] on [MetAs_Live-pruebas].[dbo].[SetupCustomerSource].[id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[Source] 
                left join [MetAs_Live-pruebas].[dbo].[MasterCustomerType] on [MetAs_Live-pruebas].[dbo].[MasterCustomerType].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[AdminType] 
                left join [MetAs_Live-pruebas].[dbo].[SetupShippingMode] on [MetAs_Live-pruebas].[dbo].[SetupShippingMode].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[ShipMode] 
            where SetupCustomerDetails.CustAccountNo Like '%' + @clave + '%'"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@clave", txtNumeroDeCuentaB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                'txtClaveEmpresa.Enabled = True
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("No. Cuenta").Style.BackColor = Color.LightCyan
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub txtCorreoB_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoB.TextChanged
        ''código de consulta
        Try
            Dim R As String
            DGConsulta.Rows.Clear()
            R = "select [CustomerId] as idContacto, [FirstName] as [Nombre], [LastName] as [Apellidos], [CompanyName] as Empresa, [CustAccountNo] as [No. Cuenta], [Email] as Correo, [PaymentTerms] as [Terminos de pago], [CustomerType] as [Tipo de Contacto], [IsTaxable] as [¿Con IVA?] from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] 
                inner join [MetAs_Live-pruebas].[dbo].[MasterPoPickList] on [MetAs_Live-pruebas].[dbo].[MasterPoPickList].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[DefaultPO] 
                left join [MetAs_Live-pruebas].[dbo].[SetupCustomerSource] on [MetAs_Live-pruebas].[dbo].[SetupCustomerSource].[id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[Source] 
                left join [MetAs_Live-pruebas].[dbo].[MasterCustomerType] on [MetAs_Live-pruebas].[dbo].[MasterCustomerType].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[AdminType] 
                left join [MetAs_Live-pruebas].[dbo].[SetupShippingMode] on [MetAs_Live-pruebas].[dbo].[SetupShippingMode].[Id] = [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].[ShipMode]
            where SetupCustomerDetails.[Email] LIKE '%' + @clave + '%'"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@clave", txtCorreoB.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                'txtClaveEmpresa.Enabled = True
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Correo").Style.BackColor = Color.LightCyan
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub limpiarTextos()
        'Informacion Personal
        txtNombreCompania.Text = ""
        txtDepartamento.Text = ""
        txtKeyFiscal.Text = ""
        txtOrganizacion.Text = ""
        txtTelefono.Text = ""
        txtNumeroDeCuenta.Text = ""
        txtCelular.Text = ""
        txtExtension.Text = ""
        txtCorreo1.Text = ""
        txtFax.Text = ""

        ''Informacion de contacto
        txtDireccion.Text = ""
        txtNumExt.Text = ""
        txtColonia.Text = ""
        txtColonia.Text = ""
        txtEdo.Text = ""
        txtCiudad.Text = ""
        txtDireccion2.Text = ""
        txtDireccion3.Text = ""
        txtCodigoPostal.Text = ""
        txtPais.Text = ""
        '
        ''informacion de facturacion
        txtDireccion1DeFacturacion.Text = ""
        txtNumeroExteriorDeFacturacion.Text = ""
        txtColoniaDeFacturacion.Text = ""
        txtEstadoDeFacturacion.Text = ""
        txtCiudadDeFacturacion.Text = ""
        txtDireccion2DeFacturacion.Text = ""
        txtDireccion3DeFacturacion.Text = ""
        txtCPDeFacturacion.Text = ""
        txtPaisDeFacturacion.Text = ""

        ''Informacion de entrega
        txtDireccion1DeEntrega.Text = ""
        txtNumeroExteriorDeEntrega.Text = ""
        txtColoniaDeEntrega.Text = ""
        txtEstadoDeEntrega.Text = ""
        txtCiudadDeEntrega.Text = ""
        txtDireccion2DeEntrega.Text = ""
        txtDireccion3DeEntrega.Text = ""
        txtCPDeEntrega.Text = ""
        txtPaisDeEntrega.Text = ""

        ''Instrumentos

        txtInstrumentID.Text = ""
        txtSerialNo.Text = ""
        txtIDNumber.Text = ""
        txtDepartamentEquipment.Text = ""
        txtLocation.Text = ""
        txtCalDUE.Text = ""
        txtCalInterval.Text = ""
        txtCalCycle.Text = ""
        txtEquipmentID.Text = ""
        txtItemNumber.Text = ""
        txtEquipmenteName.Text = ""
        txtManufacture.Text = ""
        txtModel.Text = ""
        txtSerialNumber.Text = ""
        txtAditionalEspecs.Text = ""

        ''Informacion Adicional
        txtOrigenContacto.Text = ""
        txtTipoDeCliente.Text = ""
        txtTerminosDePago.Text = ""
        txtCategoria.Text = ""
        txtIDFiscal.Text = ""
        txtMoneda.Text = ""
        txtOpcionesDePago.Text = ""
        txtDefaultPO.Text = ""
        txtModoDeEnvio.Text = ""
        txtDescuentoDeCal.Text = ""
        txtTaxEx.Text = ""
        txtCuentaDeEnvio.Text = ""
        txtHorarioDeTrabajo.Text = ""
        txtAvisoDeRecupeacion.Text = ""
        txtCalidad.Text = ""
        txtCalDueDate.Text = ""
        txtNotasLab.Text = ""

        ''Faltan declarar los CB
        CBActivo.Checked = False
        CBOnSite.Checked = False
        CBDataIncluded.Checked = False
        CBCalibrationDataRequiered.Checked = False
        CBOOTNoticeRequiered.Checked = False
        CBRequiresCalHistory.Checked = False
        CBOnlyDigitalCer.Checked = False


    End Sub
End Class

