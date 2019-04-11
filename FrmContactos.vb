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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub


    Private Sub DGConsulta_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGConsulta.RowHeaderMouseClick
        Try
            Dim clave As String
            clave = DGConsulta.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtClaveRecopilada.Text = clave
            consultaDatosContactos(clave)
            TabConsulta.SelectTab(1)
            'Evento click para la regilla---------------------------
        Catch ex As Exception
            MsgBox("Selecciona un registro válido de la regilla.", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub consultaDatosContactos(ByVal clave As String)
        Try
            Dim vacio As String = "---"
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

	  ,SetupCustomerEmails.[CustomerEmailId]
      ,SetupCustomerEmails.[CustomerId]
      ,SetupCustomerEmails.[FName]
      ,SetupCustomerEmails.[LName]
      ,SetupCustomerEmails.[Department]
      ,SetupCustomerEmails.[EmailId]
      ,SetupCustomerEmails.[MailSend]

	  ,SetupCustomerEquipmentMapping.[CustEquipMapId]
      ,SetupCustomerEquipmentMapping.[CustomerId]
      ,SetupCustomerEquipmentMapping.[EquipId]
      ,SetupCustomerEquipmentMapping.[InstrumentId]
      ,SetupCustomerEquipmentMapping.[SrlNo]
      ,SetupCustomerEquipmentMapping.[Dept]
      ,SetupCustomerEquipmentMapping.[Location]
      ,SetupCustomerEquipmentMapping.[CALInterval]
      ,SetupCustomerEquipmentMapping.[CALCycle]
      ,SetupCustomerEquipmentMapping.[CALDue]
      ,SetupCustomerEquipmentMapping.[IsActive]
      ,SetupCustomerEquipmentMapping.[OnSite]
      ,SetupCustomerEquipmentMapping.[ShortNotes]
      ,SetupCustomerEquipmentMapping.[AssetNo]

	  ,SetupCustomerSource.[id]
      ,SetupCustomerSource.[CustomerSource]

	  from SetupCustomerDetails
	  inner join SetupCustomerAddressDtls on SetupCustomerDetails.CustomerId =  SetupCustomerAddressDtls.CustomerId
	  inner join SetupCustomerEmails on SetupCustomerDetails.CustomerId = SetupCustomerEmails.CustomerId
	  inner join SetupCustomerEquipmentMapping on SetupCustomerDetails.CustomerId =  SetupCustomerEquipmentMapping.CustomerId
	  inner join SetupCustomerSource on SetupCustomerDetails.CustomerId =  SetupCustomerSource.id where SetupCustomerDetails.[CustomerId]= " & clave & ""

            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader()
            If lector.Read() Then

                txtClaveRecopilada.Text = lector(0)
                txtNumeroDeCuenta.Text = lector(1)
                txtNombreDeContacto.Text = lector(2) & " " & lector(3) & " " & lector(4)
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
                    CBActivo.Checked = True
                Else
                    isActive = False
                    CBActivo.Checked = False
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



                txtCalidad.Text = lector(19)
                txtCalDueDate.Text = lector(20)
                txtNotasLab.Text = lector(21)

                txtOrigenContacto.Text = lector(11)
                txtTipoDeCliente.Text = lector(12)
                txtTerminosDePago.Text = lector(13)
                txtCategoria.Text = lector(32)
                txtIDFiscal.Text = lector(33)
                txtMoneda.Text = lector(34)
                txtOpcionesDePago.Text = lector(35)

                txtDefaultPO.Text = lector(26)
                txtModoDeEnvio.Text = lector(27)
                txtDescuentoDeCal.Text = lector(28)
                txtTaxEx.Text = lector(29)
                txtCuentaDeEnvio.Text = lector(36)
                txtHorarioDeTrabajo.Text = lector(37)
                txtAvisoDeRecupeacion.Text = lector(38)


                If lector(40).ToString.Trim.Equals("Y") Then
                    CBOnlyDigitalCer.Checked = True

                Else
                    CBOnlyDigitalCer.Checked = False
                End If
                If lector(42).ToString.Trim.Equals("Y") Then
                    cbActivo1.Checked = True

                Else
                    cbActivo1.Checked = False
                End If

                txtKeyFiscal.Text = lector(43)

                txtOrganizacion.Text = lector(44)


                MsgBox("Fin de la lectura")
            Else
                MsgBox("No existen datos de registro.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        consultaGeneralContactos()
        txtNombreB.Text = ""
        txtNumeroDeCuentaB.Text = ""
        txtCompaniaB.Text = ""
        txtCorreoB.Text = ""
    End Sub

    Public Sub consultaGeneralContactos()
        ''Try
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
        'lector.Close()
        conexionLIMS.Close()
        '' Catch ex As Exception
        '' MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        ''End Try

    End Sub


    'Public Sub consultaGeneralContactos2()
    '    DGConsulta2.Rows.Clear()
    '    Dim R As String
    '    R = "select [CustAccountNo], [CustomerId], [FirstName], [MiddleName], [LastName], [CompanyName], [Phone], [Mobile], [Email], [Fax],  [IsActive], [CategoryCustomer] from SetupCustomerDetails"
    '    Dim comando As New SqlCommand(R, conexion)
    '    comando.CommandType = CommandType.Text
    '    Dim da As New SqlDataAdapter(comando)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    DGConsulta2.DataSource = dt

    '    For Each fila As DataGridViewRow In DGConsulta2.Rows
    '        fila.Cells("CustAccountNo").Style.BackColor = Color.Azure
    '    Next
    'End Sub

    Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Dim R As String
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
    End Sub

    Private Sub txtCompaniaB_TextChanged(sender As Object, e As EventArgs) Handles txtCompaniaB.TextChanged
        Dim R As String
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
    End Sub

    Private Sub txtNumeroDeCuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroDeCuentaB.TextChanged
        ''código de consulta
        Dim R As String
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
    End Sub

    Private Sub txtCorreoB_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoB.TextChanged
        ''código de consulta
        Dim R As String
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
    End Sub



    'Private Sub cbNombre1_Click(sender As Object, e As EventArgs)
    '    cbNombre1.Checked = True
    '    cbTelefono1.Checked = False
    '    cbCorreo1.Checked = False
    '    cbClave1.Checked = False

    '    LabelNombr.Visible = True
    '    LabelCorre.Visible = False
    '    LabelClav.Visible = False
    '    LabelTele.Visible = False

    '    txtNombre.Visible = True
    '    txtCorreo.Visible = False
    '    txtClave.Visible = False
    '    txtTel.Visible = False
    'End Sub

    'Private Sub cbTelefono1_Click(sender As Object, e As EventArgs)
    '    cbNombre1.Checked = False
    '    cbTelefono1.Checked = True
    '    cbCorreo1.Checked = False
    '    cbClave1.Checked = False

    '    LabelNombr.Visible = False
    '    LabelCorre.Visible = False
    '    LabelClav.Visible = False
    '    LabelTele.Visible = True

    '    txtNombre.Visible = False
    '    txtCorreo.Visible = False
    '    txtClave.Visible = False
    '    txtTel.Visible = True
    'End Sub

    'Private Sub cbClave1_Click(sender As Object, e As EventArgs)
    '    cbNombre1.Checked = False
    '    cbTelefono1.Checked = False
    '    cbCorreo1.Checked = False
    '    cbClave1.Checked = True

    '    LabelNombr.Visible = False
    '    LabelCorre.Visible = False
    '    LabelClav.Visible = True
    '    LabelTele.Visible = False

    '    txtNombre.Visible = False
    '    txtCorreo.Visible = False
    '    txtClave.Visible = True
    '    txtTel.Visible = False
    'End Sub

    'Private Sub cbCorreo1_Click(sender As Object, e As EventArgs)
    '    cbNombre1.Checked = False
    '    cbTelefono1.Checked = False
    '    cbCorreo1.Checked = True
    '    cbClave1.Checked = False

    '    LabelNombr.Visible = False
    '    LabelCorre.Visible = True
    '    LabelClav.Visible = False
    '    LabelTele.Visible = False

    '    txtNombre.Visible = False
    '    txtCorreo.Visible = True
    '    txtClave.Visible = False
    '    txtTel.Visible = False
    'End Sub
    Public Sub consultaAdicionales(ByVal claveContacto)
        DGAdicionales.Rows.Clear()
        'Try
        Dim R As String
            R = "select [CustomerEmailId], [FName], [LName], [Department], [EmailId] from [SetupCustomerEmails] where [CustomerId] =" & claveContacto & ""
        Dim comando As New SqlCommand(R, conexionLIMS)
        Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGAdicionales.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        ' Catch ex As Exception
        'MsgBox("El parametro que seleccionaste no corresponde a la consulta", MsgBoxStyle.Information)
        '  End Try
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

