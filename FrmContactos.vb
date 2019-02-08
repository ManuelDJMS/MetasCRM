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
            R = "select * from SetupCustomerDetails where CustomerId= " & clave & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader()
            If lector.Read() Then
                txtClaveRecopilada.Text = lector(0)
                '' MsgBox("Clave recopilada: " & txtClaveRecopilada.Text)
                txtNumeroDeCuenta.Text = lector(1)
                MsgBox(txtNumeroDeCuenta.Text)

                txtNombreDeContacto.Text = lector(2) & " " & lector(3) & " " & lector(4)
                MsgBox(txtNombreDeContacto.Text)

                txtTelefono.Text = lector(5)
                MsgBox(txtTelefono.Text)

                txtCelular.Text = lector(6)
                MsgBox(txtCelular.Text)

                txtCorreo1.Text = lector(7)
                MsgBox(txtCorreo1.Text)

                txtFax.Text = lector(8)
                MsgBox(txtFax.Text)

                txtNombreCompania.Text = lector(9)
                MsgBox(txtNombreCompania.Text)

                If lector(10).ToString.Trim.Equals("Y") Then
                    isActive = True
                    CBActivo.Checked = True
                    MsgBox(lector(10).ToString)
                Else
                    isActive = False
                    CBActivo.Checked = False
                End If

                'Dim aux As SqlDataReader
                'comando.CommandText = "select [CustomerSource] from [SetupCustomerSource] where id= " & Val(lector(11)) & ""
                'aux = comando.ExecuteReader
                'aux.Read()
                'txtOrigenContacto.Text = aux(0)
                'MsgBox(txtOrigenContacto.Text)
                'aux.Close()

                'Dim lector2 As SqlDataReader
                'comando.CommandText = "select [[CustomerType]] from [MasterCustomerType] where Id= " & Val(lector(12)) & ""
                'lector2 = comando.ExecuteReader
                'lector2.Read()
                'txtTipoDeCliente.Text = lector2(0)
                'MsgBox(txtTipoDeCliente.Text)
                'lector2.Close()

                txtTerminosDePago.Text = lector(13)
                MsgBox(txtTerminosDePago.Text)

                If lector(14).ToString.Trim.Equals("Y") Then
                    cbCOD.Checked = True
                    MsgBox(lector(14))
                Else
                    cbCOD.Checked = False
                End If
                If lector(15).ToString.Trim.Equals("Y") Then
                    cbTaxable.Checked = True
                    MsgBox(lector(15))
                Else
                    cbTaxable.Checked = False
                End If
                If lector(16).ToString.Trim.Equals("Y") Then
                    CBCalibrationDataRequiered.Checked = True
                    MsgBox(lector(16))
                Else
                    CBCalibrationDataRequiered.Checked = False
                End If
                If lector(17).ToString.Trim.Equals("Y") Then
                    CBOOTNoticeRequiered.Checked = True
                    MsgBox(lector(17))
                Else
                    CBOOTNoticeRequiered.Checked = False
                End If
                If lector(18).ToString.Trim.Equals("Y") Then
                    CBRequiresCalHistory.Checked = True
                    MsgBox(lector(18))
                Else
                    CBRequiresCalHistory.Checked = False
                End If

                txtCalidad.Text = lector(19)
                MsgBox(txtCalidad.Text)
                txtCalDueDate.Text = lector(20)
                MsgBox(txtCalDueDate.Text)
                txtNotasLab.Text = lector(21)
                MsgBox(txtNotasLab.Text)
                txtDefaultPO.Text = lector(26)
                MsgBox(txtDefaultPO.Text)
                txtModoDeEnvio.Text = lector(27)
                MsgBox(txtModoDeEnvio.Text)
                txtDescuentoDeCal.Text = lector(28)
                MsgBox(txtDescuentoDeCal.Text)
                txtTaxEx.Text = lector(29)
                MsgBox(txtTaxEx.Text)
                txtDepartamento.Text = lector(30)
                MsgBox(txtDepartamento.Text)
                txtCorreo2.Text = lector(31)
                MsgBox(txtCorreo2.Text)
                txtCategoria.Text = lector(32)
                MsgBox(txtCategoria.Text)
                txtIDFiscal.Text = lector(33)
                MsgBox(txtIDFiscal.Text)
                txtMoneda.Text = lector(34)
                MsgBox(txtMoneda.Text)
                txtOpcionesDePago.Text = lector(35)
                MsgBox(txtOpcionesDePago.Text)
                txtCuentaDeEnvio.Text = lector(36)
                MsgBox(txtCuentaDeEnvio.Text)
                txtHorarioDeTrabajo.Text = lector(37)
                MsgBox(txtHorarioDeTrabajo.Text)
                txtAvisoDeRecupeacion.Text = lector(38)
                MsgBox(txtAvisoDeRecupeacion.Text)

                If lector(40).ToString.Trim.Equals("Y") Then
                    CBOnlyDigitalCer.Checked = True
                    MsgBox(lector(40))
                Else
                    CBOnlyDigitalCer.Checked = False
                End If
                If lector(42).ToString.Trim.Equals("Y") Then
                    cbActivo1.Checked = True
                    MsgBox(lector(42))
                Else
                    cbActivo1.Checked = False
                End If

                txtKeyFiscal.Text = lector(43)
                MsgBox(txtKeyFiscal.Text)
                txtOrganizacion.Text = lector(44)
                MsgBox(txtOrganizacion.Text)

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
        R = "select [CustomerId], [FirstName], [CompanyName], [CustAccountNo], [Email], [POPickList], 
            [PaymentTerms], [CustomerSource], [CustomerType], [ShipVia], [IsTaxable], [IsCallDataReq] 
            from [MetAs_Live].[dbo].[SetupCustomerDetails] inner join [MetAs_Live].[dbo].[MasterPoPickList] 
            on [MetAs_Live].[dbo].[MasterPoPickList].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[DefaultPO] 
            left join [MetAs_Live].[dbo].[SetupCustomerSource] on [MetAs_Live].[dbo].[SetupCustomerSource].[id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[Source] 
            left join [MetAs_Live].[dbo].[MasterCustomerType] on [MetAs_Live].[dbo].[MasterCustomerType].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[AdminType] 
            left join [MetAs_Live].[dbo].[SetupShippingMode] on [MetAs_Live].[dbo].[SetupShippingMode].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[ShipMode] order by [FirstName]"
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
        R = "select [CustomerId], [FirstName], [CompanyName], [CustAccountNo], [Email], [POPickList], 
            [PaymentTerms], [CustomerSource], [CustomerType], [ShipVia], [isTaxable], [isCallDataReq] 
            From [MetAs_Live].[dbo].[SetupCustomerDetails] inner Join [MetAs_Live].[dbo].[MasterPoPickList] 
            On [MetAs_Live].[dbo].[MasterPoPickList].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[DefaultPO] 
            Left Join [MetAs_Live].[dbo].[SetupCustomerSource] on [MetAs_Live].[dbo].[SetupCustomerSource].[id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[Source] 
            Left Join [MetAs_Live].[dbo].[MasterCustomerType] on [MetAs_Live].[dbo].[MasterCustomerType].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[AdminType] 
            Left Join [MetAs_Live].[dbo].[SetupShippingMode] on [MetAs_Live].[dbo].[SetupShippingMode].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[ShipMode] 
            where SetupCustomerDetails.FirstName Like '%' + @clave + '%'"
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
            fila.Cells("FirstName").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub txtCompaniaB_TextChanged(sender As Object, e As EventArgs) Handles txtCompaniaB.TextChanged
        Dim R As String
        R = "select [CustomerId], [FirstName], [CompanyName], [CustAccountNo], [Email], [POPickList], 
            [PaymentTerms], [CustomerSource], [CustomerType], [ShipVia], [isTaxable], [isCallDataReq] 
            From [MetAs_Live].[dbo].[SetupCustomerDetails] inner Join [MetAs_Live].[dbo].[MasterPoPickList] 
            On [MetAs_Live].[dbo].[MasterPoPickList].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[DefaultPO] 
            Left Join [MetAs_Live].[dbo].[SetupCustomerSource] on [MetAs_Live].[dbo].[SetupCustomerSource].[id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[Source] 
            Left Join [MetAs_Live].[dbo].[MasterCustomerType] on [MetAs_Live].[dbo].[MasterCustomerType].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[AdminType] 
            Left Join [MetAs_Live].[dbo].[SetupShippingMode] on [MetAs_Live].[dbo].[SetupShippingMode].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[ShipMode] 
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
            fila.Cells("CompanyName").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub txtNumeroDeCuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroDeCuentaB.TextChanged
        ''código de consulta
        Dim R As String
        R = "select [CustomerId], [FirstName], [CompanyName], [CustAccountNo], [Email], [POPickList], 
            [PaymentTerms], [CustomerSource], [CustomerType], [ShipVia], [isTaxable], [isCallDataReq] 
            From [MetAs_Live].[dbo].[SetupCustomerDetails] inner Join [MetAs_Live].[dbo].[MasterPoPickList] 
            On [MetAs_Live].[dbo].[MasterPoPickList].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[DefaultPO] 
            Left Join [MetAs_Live].[dbo].[SetupCustomerSource] on [MetAs_Live].[dbo].[SetupCustomerSource].[id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[Source] 
            Left Join [MetAs_Live].[dbo].[MasterCustomerType] on [MetAs_Live].[dbo].[MasterCustomerType].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[AdminType] 
            Left Join [MetAs_Live].[dbo].[SetupShippingMode] on [MetAs_Live].[dbo].[SetupShippingMode].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[ShipMode] 
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
            fila.Cells("CustAccountNo").Style.BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub txtCorreoB_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoB.TextChanged
        ''código de consulta
        Dim R As String
        R = "select [CustomerId], [FirstName], [CompanyName], [CustAccountNo], [Email], [POPickList], 
            [PaymentTerms], [CustomerSource], [CustomerType], [ShipVia], [isTaxable], [isCallDataReq] 
            From [MetAs_Live].[dbo].[SetupCustomerDetails] inner Join [MetAs_Live].[dbo].[MasterPoPickList] 
            On [MetAs_Live].[dbo].[MasterPoPickList].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[DefaultPO] 
            Left Join [MetAs_Live].[dbo].[SetupCustomerSource] on [MetAs_Live].[dbo].[SetupCustomerSource].[id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[Source] 
            Left Join [MetAs_Live].[dbo].[MasterCustomerType] on [MetAs_Live].[dbo].[MasterCustomerType].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[AdminType] 
            Left Join [MetAs_Live].[dbo].[SetupShippingMode] on [MetAs_Live].[dbo].[SetupShippingMode].[Id] = [MetAs_Live].[dbo].[SetupCustomerDetails].[ShipMode] 
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
            fila.Cells("Email").Style.BackColor = Color.LightCyan
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
'dim a as String

    End Sub
End Class

