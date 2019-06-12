Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmNuevoContacto
    Dim source, AdminType, isCod, isTaxable, isCalDataReq, isOOT, isCalHistory, QualityRequerment, CalDueDateAdj, DefaultPO, ShipMode, isDigitalCertified,
                RecallNotice, MonedaSeleccionada, AccActive As String
    Dim contador, valorFinal As Integer
    Dim bandera, bandera2 As Integer

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Dispose()
    End Sub
    Private Sub FrmNuevoContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        If ban = False Then
            btGuardar.Text = "ACTUALIZAR"
            Me.Text = "Actualizar datos de contacto"
        Else
            '' cargar datos de las tablas SetupCustomerSource
            '' cargar datos de las tablas SetupQualityRequierement
            Dim R As String
            R = "Select CustomerSource from SetupCustomerSource"
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                cboOrigen.Items.Add(lector(0))
            End While
            lector.Close()

            'cadena = "Select QualityRqment from SetupQualityRequirement"
            comando.CommandText = "Select QualityRqment from SetupQualityRequirement"
            lector = comando.ExecuteReader
            While lector.Read()
                cboRequerimientosDeCalidad.Items.Add(lector(0))
            End While
            lector.Close()

            ''Reacomodar el nombre de los registros que se cambiarona español en las tablas del sistema 

            comando.CommandText = "Select [CustomerType] from MasterCustomerType"
            lector = comando.ExecuteReader
            While lector.Read()
                cboTipoIndustria.Items.Add(lector(0))
            End While
            lector.Close()

            comando.CommandText = "Select [POPickList] from [MasterPoPickList]"
            lector = comando.ExecuteReader
            While lector.Read()
                cboDefaultPO.Items.Add(lector(0))
                cboDefaultPO.Text = ""
            End While
            lector.Close()


            comando.CommandText = "Select [ShipVia] from [SetupShippingMode]"
            lector = comando.ExecuteReader
            While lector.Read()
                cboModoDeEnvio.Items.Add(lector(0))
            End While
            lector.Close()

            comando.CommandText = "Select [StateName], [StateId] from [StateMaster]"
            lector = comando.ExecuteReader
            While lector.Read()
                txtEstado.Items.Add(lector(0) & " - " & lector(1))
                txtEstadoFacturacion.Items.Add(lector(0) & " - " & lector(1))
                txtEstadoEntrega.Items.Add(lector(0) & " - " & lector(1))
            End While
            lector.Close()

            comando.CommandText = "Select [StateName], [StateId] from [MasterStateCountry]"
            lector = comando.ExecuteReader
            While lector.Read()
                cboPais.Items.Add(lector(0) & " - " & lector(1))
                cboPaisEntrega.Items.Add(lector(0) & " - " & lector(1))
                cboPaisFacturacion.Items.Add(lector(0) & " - " & lector(1))
            End While
            lector.Close()

            cboMoneda.Items.Add("Mexican Peso")
            cboMoneda.Items.Add("U.S. Dollar")
            cboMoneda.Items.Add("Pound Sterling")
            cboOpcionesDePago.Items.Add("Diario")
            cboOpcionesDePago.Items.Add("Semanal")
            cboOpcionesDePago.Items.Add("Mensual")
            cboOpcionesDePago.Items.Add("Anual")
            cboAvisoDeRecuperacion.Items.Add("Llamada")
            cboAvisoDeRecuperacion.Items.Add("Texto")
            cboAvisoDeRecuperacion.Items.Add("Ambos")
            cboVencimientoDeCalibracion.Items.Add("Ninguna")
            cboVencimientoDeCalibracion.Items.Add("Fin de semana (Domingo)")
            cboVencimientoDeCalibracion.Items.Add("Fin de mes")
            cboCategoria.Items.Add("Categoria 1")
            cboCategoria.Items.Add("Categoria 2")
            cboCategoria.Items.Add("Categoria 3")
            cboCategoria.Items.Add("Categoria 4")
            cboCategoria.Items.Add("Categoria 5")

            conexionLIMS.Close()
        End If
    End Sub

    Private Sub cboAvisoDeRecuperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvisoDeRecuperacion.SelectedIndexChanged
        aviso()
        'MsgBox(RecallNotice)
    End Sub
    Public Sub aviso()
        If cboAvisoDeRecuperacion.Text = "Llamada" Then
            RecallNotice = "0"
        ElseIf cboAvisoDeRecuperacion.Text = "Texto" Then
            RecallNotice = "1"
        ElseIf cboAvisoDeRecuperacion.Text = "Ambos" Then
            RecallNotice = "2"
        Else
            RecallNotice = "-"
        End If
    End Sub


    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        moneda()
        'MsgBox(MonedaSeleccionada)
    End Sub
    Public Sub moneda()
        If cboMoneda.Text = "Peso Mexicano" Then
            MonedaSeleccionada = "0"
        ElseIf cboMoneda.Text = "U.S. Dollar" Then
            MonedaSeleccionada = "1"
        ElseIf cboMoneda.Text = "Pound Sterling" Then
            MonedaSeleccionada = "2"
        Else
            MonedaSeleccionada = "-"
        End If
    End Sub

    Private Sub cboModoDeEnvio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModoDeEnvio.SelectedIndexChanged
        envio()
    End Sub
    Public Sub envio()
        Try
            MetodoLIMS()
            Dim r As String
            r = "select [Id] from [SetupShippingMode] where [ShipVia]='" & cboModoDeEnvio.Text & "'"
            Dim comando As New SqlCommand(r, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.Read() Then
                ShipMode = lector(0)
                'MsgBox(ShipMode)
            End If
            lector.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos de LIMS.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub cboDefaultPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDefaultPO.SelectedIndexChanged
        po()
    End Sub
    Public Sub po()
        Try
            MetodoLIMS()
            Dim r As String
            r = "select [Id] from [MasterPoPickList] where [POPickList]='" & cboDefaultPO.Text & "'"
            Dim comando As New SqlCommand(r, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.Read() Then
                DefaultPO = lector(0)
                ' MsgBox(DefaultPO)
            End If
            lector.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos de LIMS.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub cboVencimientoDeCalibracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVencimientoDeCalibracion.SelectedIndexChanged
        vencimiento()
        'Try
        '    ConexionGlobal()
        '    Dim r As String
        '    r = "select id from [SetupQualityRequirement]"
        '    Dim comando As New SqlCommand(r, conexion)
        '    Dim lector As SqlDataReader
        '    lector = comando.ExecuteReader
        '    If lector.Read() Then

        '    End If
        '    lector.Close()
        '    conexion.Close()

        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos de LIMS.", MsgBoxStyle.Exclamation)
        'End Try
        'MsgBox(CalDueDateAdj)
    End Sub
    Public Sub vencimiento()
        If cboVencimientoDeCalibracion.Text.Equals("Nunca") Then
            CalDueDateAdj = "0"
        ElseIf cboVencimientoDeCalibracion.Text.Equals("Fin de semana (Sabado)") Then
            CalDueDateAdj = "1"
        ElseIf cboVencimientoDeCalibracion.Text.Equals("Fin de mes") Then
            CalDueDateAdj = "2"
        Else
            CalDueDateAdj = "0"
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmBusquedaCuentas.ShowDialog()
    End Sub
    Private Sub txtNumeroDeCuenta_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNumeroDeCuenta.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                MetodoLIMS()
                Dim R As String
                R = "select Organization from SetupCustomerDetails where CustAccountNo='" & txtNumeroDeCuenta.Text & "'"
                Dim comando As New SqlCommand(R, conexionLIMS)
                Dim lector As SqlDataReader
                lector = comando.ExecuteReader
                If lector.Read() Then
                    txtOrganizacion.Text = lector(0)
                Else
                    txtOrganizacion.Text = ""
                End If
                lector.Close()
                conexionLIMS.Close()
            Catch ex As Exception
                MsgBox("Ocurrio un error en la lectura de datos, comunicate con el administrador general.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub cboRequerimientosDeCalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequerimientosDeCalidad.SelectedIndexChanged
        requerimientos()
    End Sub
    Public Sub requerimientos()
        Try
            MetodoLIMS()
            Dim r As String
            r = "select id from [SetupQualityRequirement] where [QualityRqment]='" & cboRequerimientosDeCalidad.Text & "'"
            Dim comando As New SqlCommand(r, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.Read() Then
                QualityRequerment = lector(0)
                'MsgBox(QualityRequerment)
            End If
            lector.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos de LIMS.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub borrarTextos()
        txtNombre.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtCompania.Text = ""
        txtDepartamento.Text = ""
        txtRFC.Text = ""
        txtOrganizacion.Text = ""
        cboStatus.Text = ""
        txtNumeroDeCuenta.Text = ""
        txtCelular.Text = ""
        txtTelefono.Text = ""
        txtExtension.Text = ""
        txtCorreo1.Text = ""
        txtCorreo2.Text = ""
        txtFax.Text = ""
        txtDireccion1.Text = ""
        txtDireccion2.Text = ""
        txtDireccion3.Text = ""
        txtEstado.Text = ""
        cboPais.Text = ""
        txtColonia.Text = ""
        txtCiudad.Text = ""
        txtCodigoPostal.Text = ""
        txtNumeroExterior.Text = ""
        txtDireccion1Facturacion.Text = ""
        txtDireccion2Facturacion.Text = ""
        txtDireccion3Facturacion.Text = ""
        txtEstadoFacturacion.Text = ""
        cboPaisFacturacion.Text = ""
        txtColoniaFacturacion.Text = ""
        txtCiudadFacturacion.Text = ""
        txtCodigoPostalFacturacion.Text = ""
        txtNumExteriorFacturacion.Text = ""
        txtDireccion1Entrega.Text = ""
        txtDireccion2Entrega.Text = ""
        txtDireccion3Entrega.Text = ""
        txtEstadoEntrega.Text = ""
        cboPaisEntrega.Text = ""
        txtColoniaEntrega.Text = ""
        txtCiudadEntrega.Text = ""
        txtCodigoPostalEntrega.Text = ""
        txtNumExteriorEntrega.Text = ""
        'adiministrative Information
        cboOrigen.Text = ""
        cboTipoIndustria.Text = ""
        txtTerminosDePago.Text = ""
        cboCategoria.Text = ""
        txtIDFiscal.Text = ""
        cboMoneda.Text = ""
        cboOpcionesDePago.Text = ""
        cboDefaultPO.Text = ""
        cboModoDeEnvio.Text = ""
        txtDescuentoDeCalibracion.Text = ""
        txtTaxException.Text = ""
        txtCuentaDeEnvio.Text = ""
        txtHorarioDeTrabajo.Text = ""
        cboAvisoDeRecuperacion.Text = ""
        cboRequerimientosDeCalidad.Text = ""
        cboVencimientoDeCalibracion.Text = ""
        txtNotas.Text = ""
        txtNombreDeArchivo.Text = ""
    End Sub

    Public Sub habilitarTextos()
        txtNombre.Enabled = True
        txtApellidoPaterno.Enabled = True
        txtApellidoMaterno.Enabled = True
        txtCompania.Enabled = True
        txtDepartamento.Enabled = True
        txtRFC.Enabled = True
        txtOrganizacion.Enabled = True
        cboStatus.Enabled = True
        txtNumeroDeCuenta.Enabled = True
        txtCelular.Enabled = True
        txtTelefono.Enabled = True
        txtExtension.Enabled = True
        txtCorreo1.Enabled = True
        txtCorreo2.Enabled = True
        txtFax.Enabled = True
        txtDireccion1.Enabled = True
        txtDireccion2.Enabled = True
        txtDireccion3.Enabled = True
        txtEstado.Enabled = True
        cboPais.Enabled = True
        txtColonia.Enabled = True
        txtCiudad.Enabled = True
        txtCodigoPostal.Enabled = True
        txtNumeroExterior.Enabled = True
        txtDireccion1Facturacion.Enabled = True
        txtDireccion2Facturacion.Enabled = True
        txtDireccion3Facturacion.Enabled = True
        txtEstadoFacturacion.Enabled = True
        cboPaisFacturacion.Enabled = True
        txtColoniaFacturacion.Enabled = True
        txtCiudadFacturacion.Enabled = True
        txtCodigoPostalFacturacion.Enabled = True
        txtNumExteriorFacturacion.Enabled = True
        txtDireccion1Entrega.Enabled = True
        txtDireccion2Entrega.Enabled = True
        txtDireccion3Entrega.Enabled = True
        txtEstadoEntrega.Enabled = True
        cboPaisEntrega.Enabled = True
        txtColoniaEntrega.Enabled = True
        txtCiudadEntrega.Enabled = True
        txtCodigoPostalEntrega.Enabled = True
        txtNumExteriorEntrega.Enabled = True
        cboOrigen.Enabled = True
        cboTipoIndustria.Enabled = True
        txtTerminosDePago.Enabled = True
        cboCategoria.Enabled = True
        txtIDFiscal.Enabled = True
        cboMoneda.Enabled = True
        cboOpcionesDePago.Enabled = True
        cboDefaultPO.Enabled = True
        cboModoDeEnvio.Enabled = True
        txtDescuentoDeCalibracion.Enabled = True
        txtTaxException.Enabled = True
        txtCuentaDeEnvio.Enabled = True
        txtHorarioDeTrabajo.Enabled = True
        cboAvisoDeRecuperacion.Enabled = True
        cboRequerimientosDeCalidad.Enabled = True
        cboVencimientoDeCalibracion.Enabled = True
        txtNotas.Enabled = True
        txtNombreDeArchivo.Enabled = True
    End Sub
    Public Sub deshabilitarTextos()
        txtNombre.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtCompania.Enabled = False
        txtDepartamento.Enabled = False
        txtRFC.Enabled = False
        txtOrganizacion.Enabled = False
        cboStatus.Enabled = False
        txtNumeroDeCuenta.Enabled = False
        txtCelular.Enabled = False
        txtTelefono.Enabled = False
        txtExtension.Enabled = False
        txtCorreo1.Enabled = False
        txtCorreo2.Enabled = False
        txtFax.Enabled = False
        txtDireccion1.Enabled = False
        txtDireccion2.Enabled = False
        txtDireccion3.Enabled = False
        txtEstado.Enabled = False
        cboPais.Enabled = False
        txtColonia.Enabled = False
        txtCiudad.Enabled = False
        txtCodigoPostal.Enabled = False
        txtNumeroExterior.Enabled = False
        txtDireccion1Facturacion.Enabled = False
        txtDireccion2Facturacion.Enabled = False
        txtDireccion3Facturacion.Enabled = False
        txtEstadoFacturacion.Enabled = False
        cboPaisFacturacion.Enabled = False
        txtColoniaFacturacion.Enabled = False
        txtCiudadFacturacion.Enabled = False
        txtCodigoPostalFacturacion.Enabled = False
        txtNumExteriorFacturacion.Enabled = False
        txtDireccion1Entrega.Enabled = False
        txtDireccion2Entrega.Enabled = False
        txtDireccion3Entrega.Enabled = False
        txtEstadoEntrega.Enabled = False
        cboPaisEntrega.Enabled = False
        txtColoniaEntrega.Enabled = False
        txtCiudadEntrega.Enabled = False
        txtCodigoPostalEntrega.Enabled = False
        txtNumExteriorEntrega.Enabled = False
        cboOrigen.Enabled = False
        cboTipoIndustria.Enabled = False
        txtTerminosDePago.Enabled = False
        cboCategoria.Enabled = False
        txtIDFiscal.Enabled = False
        cboMoneda.Enabled = False
        cboOpcionesDePago.Enabled = False
        cboDefaultPO.Enabled = False
        cboModoDeEnvio.Enabled = False
        txtDescuentoDeCalibracion.Enabled = False
        txtTaxException.Enabled = False
        txtCuentaDeEnvio.Enabled = False
        txtHorarioDeTrabajo.Enabled = False
        cboAvisoDeRecuperacion.Enabled = False
        cboRequerimientosDeCalidad.Enabled = False
        cboVencimientoDeCalibracion.Enabled = False
        txtNotas.Enabled = False
        txtNombreDeArchivo.Enabled = False
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        verificarFinal()
        MetodoLIMS()

        'Dim quienModifico, FechaModificacion As String
        '' quienModifico = "-"
        ''FechaModificacion = "-"
        Dim indicador1, indicador2 As String
            If cbActivo1.Checked = True Then
                indicador1 = "Y"
            Else
                indicador1 = "N"
            End If
            If cbActivo2.Checked = True Then
                indicador2 = "Y"
            Else
                indicador2 = "N"
            End If
            If cbCOD.Checked = True Then
                isCod = "Y"
            Else
                isCod = "N"
            End If
            If cbTaxable.Checked = True Then
                isTaxable = "Y"
            Else
                isTaxable = "N"
            End If
            If cbDatosRequeridos.Checked = True Then
                isCalDataReq = "Y"
            Else
                isCalDataReq = "N"
            End If
            If cbOOT.Checked = True Then
                isOOT = "Y"
            Else
                isOOT = "N"
            End If
            If cbHistorialDeCalibracion.Checked = True Then
                isCalHistory = "Y"
            Else
                isCalHistory = "N"
            End If
            If cbCertificado.Checked = True Then
                isDigitalCertified = "Y"
            Else
                isDigitalCertified = "N"
            End If
        If cbActivo2.Checked = True Then
            AccActive = "Y"
        Else
            AccActive = "N"
        End If
        source = "1"
        AdminType = "1"
        If btGuardar.Text = "Convertir" Then
            ''validar que no esten vacios los campos obligatorios, que se guarden en contactos
            If txtNombre.Text.Equals("") Or txtApellidoPaterno.Text.Equals("") Or txtApellidoMaterno.Text.Equals("") Or txtCompania.Text.Equals("") Or txtRFC.Text.Equals("") Or txtOrganizacion.Text.Equals("") Or cboStatus.Text.Equals("") Or txtNumeroDeCuenta.Text.Equals("") Or txtCelular.Text.Equals("") Or txtCorreo1.Text.Equals("") Or txtDireccion1.Text.Equals("") Or txtEstado.Text.Equals("") Or cboPais.Text.Equals("") Or txtColonia.Text.Equals("") Or txtCiudad.Text.Equals("") Or txtCodigoPostal.Text.Equals("") Or txtNumeroExterior.Text.Equals("") Or cboDefaultPO.Text.Equals("") Then
                MsgBox("Completa los campos obligatorios.", MsgBoxStyle.Exclamation)
            Else
                ''Inserta
                Try
                    ''--------------------------------------------------------------guardar en Tabla principal de contactos con la insercion 2da en las direcciones de contactos adicionales-----------------------------------------------------------------------------------
                    Dim cadena As String
                    cadena = "IF NOT EXISTS (SELECT CompanyName FROM SetupCustomerDetails WHERE SetupCustomerDetails.CompanyName='" & txtCompania.Text & "')
                     BEGIN
                           insert into SetupCustomerDetails (CustAccountNo, FirstName, MiddleName, LastName, Phone, Mobile, Email, 
                                Fax, CompanyName, IsActive, Source, AdminType, PaymentTerms, IsCod, IsTaxable, IsCallDataReq, 
                                IsOOTNoticeReq, IsCallHistoryReq, QualityReqment, CallDueDateAdj, LabNotes, CreatedBy, CreatedOn, 
                                 DefaultPO, ShipMode, CalDiscount, TaxExemption, Department, 
                                Email2, CategoryCustomer, TaxIDNo, Currency, PaymentOption, ShipmentAccount, 
                                WorkingHours, RecallNotice, IsDigitalCertificate, IsShipAccActive, 
                                KeyFiscal, Organization)  values ('" & txtNumeroDeCuenta.Text.Trim & "',
                                '" & txtNombre.Text.Trim & "',
                                '" & txtApellidoPaterno.Text.Trim & "',
                                '" & txtApellidoMaterno.Text.Trim & "',
                                '" & txtTelefono.Text.Trim & "',
                                '" & txtCelular.Text.Trim & "',
                                '" & txtCorreo1.Text.Trim & "',
                                '" & txtFax.Text.Trim & "',
                                '" & txtCompania.Text.Trim & "',
                                '" & indicador1 & "',
                                '" & source & "',
                                '" & AdminType & "',
                                '" & txtTerminosDePago.Text.Trim & "',
                                '" & isCod & "',
                                '" & isTaxable & "',
                                '" & isCalDataReq & "',
                                '" & isOOT & "',
                                '" & isCalHistory & "',
                                '" & QualityRequerment & "',
                                '" & CalDueDateAdj & "',
                                '" & txtNotas.Text.Trim & "',
                                '" & txtUsuarioActual.Text.Trim & "',
                                '" & DTPFechaActual.Value.Date & "',                         
                                '" & DefaultPO & "',
                                '" & ShipMode & "',
                                '" & txtDescuentoDeCalibracion.Text.Trim & "',
                                '" & txtTaxException.Text.Trim & "',
                                '" & txtDepartamento.Text.Trim & "',
                                '" & txtCorreo2.Text.Trim & "',
                                '" & cboCategoria.Text.Trim & "',
                                '" & txtIDFiscal.Text.Trim & "',
                                '" & MonedaSeleccionada & "',
                                '" & cboOpcionesDePago.Text.Trim & "',
                                '" & txtCuentaDeEnvio.Text.Trim & "',
                                '" & txtHorarioDeTrabajo.Text.Trim & "',
                                '" & RecallNotice & "',
                                '" & isDigitalCertified & "',
                                '" & AccActive & "',
                                '" & txtRFC.Text.Trim & "',
                                '" & txtOrganizacion.Text.Trim & "')             
                         SET NOCOUNT ON
                           insert into SetupCustomerAddressDtls (
                                 [CustomerId]
                                ,[ContAddress1]
                                ,[ContAddress2]
                                ,[ContAddress3]
                                ,[ContCity]
                                ,[ContState]
                                ,[ContZip]
                                ,[BillAddress1]
                                ,[BillAddress2]
                                ,[BillAddress3]  
                                ,[BillCity]  
                                ,[BillState]
                                ,[BillZip]                           
                                ,[ShipAddress1]  
                                ,[ShipAddress2]
                                ,[ShipAddress3]
                                ,[ShipCity]
                                ,[ShipState]
                                ,[ShipZip]
                          ,[ContCountry]
                          ,[BillCountry]
                                ,[ShipCountry]) values (
                                '" & valorFinal & "',
                                '" & txtDireccion1.Text.Trim & "',
                                '" & txtDireccion2.Text.Trim & "',
                                '" & txtDireccion3.Text.Trim & "',
                                '" & txtCiudad.Text.Trim & "',
                                '" & txtEstado.Text.Trim & "',
                                '" & txtCodigoPostal.Text.Trim & "',
                                '" & txtDireccion1Facturacion.Text.Trim & "',
                                '" & txtDireccion2Facturacion.Text.Trim & "',
                                '" & txtDireccion3Facturacion.Text.Trim & "',
                                '" & txtCiudadFacturacion.Text.Trim & "',
                                '" & txtEstadoFacturacion.Text.Trim & "',
                                '" & txtCodigoPostalFacturacion.Text.Trim & "',
                                '" & txtDireccion1Entrega.Text.Trim & "',
                                '" & txtDireccion2Entrega.Text.Trim & "',
                                '" & txtDireccion3Entrega.Text.Trim & "',
                                '" & txtCiudadEntrega.Text.Trim & "',
                                '" & txtEstadoEntrega.Text.Trim & "',
                                '" & txtCodigoPostalEntrega.Text.Trim & "',
                                '" & cboPais.Text.Trim & "',
                                '" & cboPaisFacturacion.Text.Trim & "',
                                '" & cboPaisEntrega.Text.Trim & "') END"
                    'MsgBox(cadena)
                    Dim comando As New SqlCommand(cadena, conexionLIMS)
                    If comando.ExecuteNonQuery() <> True Then
                        MsgBox("Contacto guardado correctamente en LIMS", MsgBoxStyle.Information)
                        ''actualizar el estado del prospecto
                        actualizarEstadoDeProspecto()
                        Me.Dispose()
                        Dim admin As New FrmProspectos
                        admin.MdiParent = FrmHOME
                        admin.Show()
                    Else
                        MsgBox("Ya existe el nombre de la compañia, no podemos agregar otro contacto con la misma empresa", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox("Ocurrio un error en insertar los datos, verifica nuevamente", MsgBoxStyle.Exclamation)
                End Try
            End If
        Else
            'MsgBox("si sirve")
            Try
                'MsgBox(cboMoneda.Text)
                moneda()
                aviso()
                vencimiento()
                requerimientos()
                po()
                envio()
                'MsgBox(MonedaSeleccionada)

                Dim cadena As String
                cadena = "Update SetupCustomerDetails Set 
                CustAccountNo = '" & txtNumeroDeCuenta.Text.Trim & "',
                FirstName = '" & txtNombre.Text.Trim & "',
                MiddleName ='" & txtApellidoPaterno.Text.Trim & "',
                LastName = '" & txtApellidoMaterno.Text.Trim & "',
                Phone ='" & txtTelefono.Text.Trim & "',
                Mobile ='" & txtCelular.Text.Trim & "',
                Email ='" & txtCorreo1.Text.Trim & "',
                Fax ='" & txtFax.Text.Trim & "',
                CompanyName ='" & txtCompania.Text.Trim & "',
                IsActive ='" & indicador1 & "',
                source ='" & source & "',
                AdminType ='" & AdminType & "',
                PaymentTerms ='" & txtTerminosDePago.Text.Trim & "',
                isCod ='" & isCod & "',
                isTaxable ='" & isTaxable & "',
                IsCallDataReq ='" & isCalDataReq & "',
                IsOOTNoticeReq ='" & isOOT & "',
                IsCallHistoryReq ='" & isCalHistory & "',
                QualityReqment ='" & QualityRequerment & "',
                CallDueDateAdj ='" & CalDueDateAdj & "',
                LabNotes ='" & txtNotas.Text.Trim & "',
                CreatedBy ='" & txtUsuarioActual.Text.Trim & "',
                CreatedOn ='" & DTPFechaActual.Value.Date & "',                         
                DefaultPO ='" & DefaultPO & "',
                ShipMode ='" & ShipMode & "',
                CalDiscount ='" & txtDescuentoDeCalibracion.Text.Trim & "',
                TaxExemption ='" & txtTaxException.Text.Trim & "',
                Department ='" & txtDepartamento.Text.Trim & "',
                Email2 ='" & txtCorreo2.Text.Trim & "',
                CategoryCustomer ='" & cboCategoria.Text.Trim & "',
                Currency ='" & MonedaSeleccionada & "',
                PaymentOption ='" & cboOpcionesDePago.Text.Trim & "',
                ShipmentAccount ='" & txtCuentaDeEnvio.Text.Trim & "',
                WorkingHours ='" & txtHorarioDeTrabajo.Text.Trim & "',
                RecallNotice ='" & RecallNotice & "',
                IsDigitalCertificate ='" & isDigitalCertified & "',
                IsShipAccActive ='" & AccActive & "',
                KeyFiscal ='" & txtRFC.Text.Trim & "',
                Organization ='" & txtOrganizacion.Text.Trim & "' 
                where [CustomerId] ='" & Val(ID.Text) & "'"
                'MsgBox(cadena)
                conexionLIMS.Open()
                Dim comando As New SqlCommand(cadena, conexionLIMS)
                lectorLIMS = comando.ExecuteReader
                lectorLIMS.Close()
                Dim cadena2 As String
                cadena2 = "Update SetupCustomerAddressDtls Set                                 
                [ContAddress1] = '" & txtDireccion1.Text.Trim & "',
                [ContAddress2] = '" & txtDireccion2.Text.Trim & "',
                [ContAddress3] = '" & txtDireccion3.Text.Trim & "',
                [ContCity] = '" & txtCiudad.Text.Trim & "',
                [ContState] = '" & txtEstado.Text.Trim & "',
                [ContZip] = '" & txtCodigoPostal.Text.Trim & "',
                [BillAddress1] = '" & txtDireccion1Facturacion.Text.Trim & "',
                [BillAddress2] = '" & txtDireccion2Facturacion.Text.Trim & "',
                [BillAddress3] = '" & txtDireccion3Facturacion.Text.Trim & "',
                [BillCity] = '" & txtCiudadFacturacion.Text.Trim & "',
                [BillState] = '" & txtEstadoFacturacion.Text.Trim & "',
                [BillZip] = '" & txtCodigoPostalFacturacion.Text.Trim & "',                   
                [ShipAddress1] = '" & txtDireccion1Entrega.Text.Trim & "',
                [ShipAddress2] = '" & txtDireccion2Entrega.Text.Trim & "',
                [ShipAddress3] = '" & txtDireccion3Entrega.Text.Trim & "',
                [ShipCity] = '" & txtCiudadEntrega.Text.Trim & "',
                [ShipState] = '" & txtEstadoEntrega.Text.Trim & "',
                [ShipZip] = '" & txtCodigoPostalEntrega.Text.Trim & "',
                [ContCountry] = '" & cboPais.Text.Trim & "',
                [BillCountry] = '" & cboPaisFacturacion.Text.Trim & "',
                [ShipCountry] ='" & cboPaisEntrega.Text.Trim & "' 
                where [CustomerId] ='" & Val(ID.Text) & "'"
                'MsgBox(cadena)
                Dim comando2 As New SqlCommand(cadena2, conexionLIMS)
                lectorLIMS = comando2.ExecuteReader
                lectorLIMS.Close()
                'MsgBox(cadena2)
                MsgBox("Contacto actualizado correctamente en LIMS", MsgBoxStyle.Information)
                ''actualizar el estado del prospecto
                'actualizarEstadoDeProspecto()
                Me.Dispose()
                'Dim admin As New 
                'admin.MdiParent = FrmHOME
                'admin.Show()
            Catch ex As Exception
                MsgBox("Ocurrio un error en insertar los datos, verifica nuevamente", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub cboOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigen.SelectedIndexChanged
        MetodoLIMS()
        Dim r As String
        r = "select id from SetupCustomerSource where [CustomerSource]='" & cboOrigen.Text & "'"
        Dim comando As New SqlCommand(r, conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.Read() Then
            source = lector(0)
            'MsgBox(source)
        Else
            source = "-"
        End If
        lector.Close()
        conexionLIMS.Close()
    End Sub

    Private Sub cboTipoIndustria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoIndustria.SelectedIndexChanged
        Try
            MetodoLIMS()
            Dim r As String
            r = "select Id from MasterCustomerType where MasterCustomerType.CustomerType='" & cboTipoIndustria.Text & "'"
            Dim comando As New SqlCommand(r, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.Read() Then
                AdminType = lector(0)
                'MsgBox(AdminType)
            Else
                MsgBox("No hay nada")
            End If
            lector.Close()
            conexionLIMS.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub verificarFinal()
        'Debemos hacer un Select count para saber el valor del registro para asignarlo a las diferentes tablas
        MetodoLIMS()
        Dim comando As New SqlCommand("SELECT MAX(CustomerId) as ultimo from SetupCustomerDetails", conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        valorFinal = lector(0)
        valorFinal = valorFinal + 1
        lector.Close()
        conexionLIMS.Close()
        'MsgBox(valorFinal)
    End Sub


    Private Sub actualizarEstadoDeProspecto() '''''''''''''''''''''''''''''''''''''Modificacion del estado del prospecto
        Try
            MetodoMetasCotizador()
            Dim r As String
            r = "update Prospectos set Status='" & "Convertido" & "' where Prospectos.idProspecto=" & Val(txtClaveRecopila.Text) & ""
            Dim comando As New SqlCommand(r, conexionMetasCotizador)
            comando.ExecuteNonQuery()
            MsgBox("Modificado el prospecto")
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la actualización de datos.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress,
        txtTelefono.KeyPress, txtExtension.KeyPress, txtFax.KeyPress, txtCodigoPostal.KeyPress, txtNumeroExterior.KeyPress,
        txtCodigoPostalEntrega.KeyPress, txtNumExteriorEntrega.KeyPress, txtCodigoPostalFacturacion.KeyPress, txtNumExteriorFacturacion.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckStateChange(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If bandera = 0 Then
            ''Copiar Datos
            DomicilioFacturacion()
            bandera = 1
        ElseIf bandera = 1 Then
            ''borra datos
            LimparDatosFacturacion()
            bandera = 0
        End If
    End Sub
    Private Sub CheckBox2_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckStateChanged
        If bandera2 = 0 Then
            ''Copiar Datos
            DomicilioEntrega()
            bandera2 = 1
        ElseIf bandera2 = 1 Then
            ''borra datos
            LimparDatosEntrega()
            bandera2 = 0
        End If
    End Sub

    Public Sub LimparDatosFacturacion()
        txtDireccion1Facturacion.Text = ""
        txtDireccion2Facturacion.Text = ""
        txtDireccion3Facturacion.Text = ""
        txtEstadoFacturacion.Text = ""
        cboPaisFacturacion.Text = ""
        txtColoniaFacturacion.Text = ""
        txtCiudadFacturacion.Text = ""
        txtCodigoPostalFacturacion.Text = ""
        txtNumExteriorFacturacion.Text = ""
    End Sub
    Public Sub LimparDatosEntrega()
        txtDireccion1Entrega.Text = ""
        txtDireccion2Entrega.Text = ""
        txtDireccion3Entrega.Text = ""
        txtEstadoEntrega.Text = ""
        cboPaisEntrega.Text = ""
        txtColoniaEntrega.Text = ""
        txtCiudadEntrega.Text = ""
        txtCodigoPostalEntrega.Text = ""
        txtNumExteriorEntrega.Text = ""

    End Sub
    Public Sub DomicilioEntrega()
        txtDireccion1Entrega.Text = txtDireccion1.Text
        txtDireccion2Entrega.Text = txtDireccion2.Text
        txtDireccion3Entrega.Text = txtDireccion3.Text
        txtEstadoEntrega.Text = txtEstado.Text
        cboPaisEntrega.Text = cboPais.Text
        txtColoniaEntrega.Text = txtColonia.Text
        txtCiudadEntrega.Text = txtCiudad.Text
        txtCodigoPostalEntrega.Text = txtCodigoPostal.Text
        txtNumExteriorEntrega.Text = txtNumeroExterior.Text
    End Sub
    Public Sub DomicilioFacturacion()
        txtDireccion1Facturacion.Text = txtDireccion1.Text
        txtDireccion2Facturacion.Text = txtDireccion2.Text
        txtDireccion3Facturacion.Text = txtDireccion3.Text
        txtEstadoFacturacion.Text = txtEstado.Text
        cboPaisFacturacion.Text = cboPais.Text
        txtColoniaFacturacion.Text = txtColonia.Text
        txtCiudadFacturacion.Text = txtCiudad.Text
        txtCodigoPostalFacturacion.Text = txtCodigoPostal.Text
        txtNumExteriorFacturacion.Text = txtNumeroExterior.Text
    End Sub


End Class