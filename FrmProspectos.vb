Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmProspectos
    Dim bandera, bandera2 As Integer
    Dim resultado As String
    Private Sub FrmProspectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        consultaGeneralProspectos()

        ''Dim contador As Programadores
        ''Que onda bro, cuando hice este código solo dios y yo sabiamos como funcionaba
        ''ahora ya no supe ni como lo hice, puedes calarle o de lo contrario dale al sumador
        ''contador = 3
        ''Atte: El Azael e.e

        cboRelacionadoConLlamada.Items.Add("Casos")
        cboRelacionadoConLlamada.Items.Add("Correo")
        cboRelacionadoConLlamada.Items.Add("Cotizaciones")
        cboRelacionadoConLlamada.Items.Add("Calibración")

        cboRelacionadoConTareas.Items.Add("Casos")
        cboRelacionadoConTareas.Items.Add("Correo")
        cboRelacionadoConTareas.Items.Add("Cotizaciones")
        cboRelacionadoConTareas.Items.Add("Calibración")

        cboStatusFiltrado.Items.Add("No calificado")
        cboStatusFiltrado.Items.Add("Nuevo")
        cboStatusFiltrado.Items.Add("Working")
        cboStatusFiltrado.Items.Add("Promoviendo")
        cboStatusFiltrado.Items.Add("Convertido")

        alternarColorColumnas(DGConsulta)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
        'Dim Admin As New FrmHOME
        'Admin.Show()
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
    Private Sub cbNombre_Click(sender As Object, e As EventArgs) Handles cbNombre.Click
        cbCorreo.Checked = False
        cbTelefono.Checked = False
        cbDireccion.Checked = False
        cbNombre.Checked = True
        ''---------------------------
        txtNombreP.Visible = True
        LabelNombre.Visible = True
        txtCorreoP.Visible = False
        LabelCorreo.Visible = False
        Label21.Visible = False
        txtTelefonoP.Visible = False
        Label25.Visible = False
        txtDireccionP.Visible = False

        cbCP.Checked = False
        labelPostal.Visible = False
        txtCP.Visible = False
    End Sub

    Private Sub cbCorreo_Click(sender As Object, e As EventArgs) Handles cbCorreo.Click
        cbCorreo.Checked = True
        cbTelefono.Checked = False
        cbDireccion.Checked = False
        cbNombre.Checked = False
        ''-------------------------
        txtNombreP.Visible = False
        LabelNombre.Visible = False
        txtCorreoP.Visible = True
        LabelCorreo.Visible = True
        Label21.Visible = False
        txtTelefonoP.Visible = False
        Label25.Visible = False
        txtDireccionP.Visible = False
        cbCP.Checked = False
        labelPostal.Visible = False
        txtCP.Visible = False
    End Sub

    Private Sub cbTelefono_Click(sender As Object, e As EventArgs) Handles cbTelefono.Click
        cbCorreo.Checked = False
        cbTelefono.Checked = True
        cbDireccion.Checked = False
        cbNombre.Checked = False
        ''-----------------------------
        txtNombreP.Visible = False
        LabelNombre.Visible = False
        txtCorreoP.Visible = False
        LabelCorreo.Visible = False
        Label21.Visible = True
        txtTelefonoP.Visible = True
        Label25.Visible = False
        txtDireccionP.Visible = False
        cbCP.Checked = False
        labelPostal.Visible = False
        txtCP.Visible = False
    End Sub

    Private Sub cbDireccion_Click(sender As Object, e As EventArgs) Handles cbDireccion.Click
        cbCorreo.Checked = False
        cbTelefono.Checked = False
        cbDireccion.Checked = True
        cbNombre.Checked = False
        ''---------------------------
        txtNombreP.Visible = False
        LabelNombre.Visible = False
        txtCorreoP.Visible = False
        LabelCorreo.Visible = False
        Label21.Visible = False
        txtTelefonoP.Visible = False
        Label25.Visible = True
        txtDireccionP.Visible = True
        cbCP.Checked = False
        labelPostal.Visible = False
        txtCP.Visible = False
    End Sub


    Private Sub cbCP_Click(sender As Object, e As EventArgs) Handles cbCP.Click
        cbCorreo.Checked = False
        cbTelefono.Checked = False
        cbDireccion.Checked = False
        cbNombre.Checked = False
        cbCP.Checked = True

        ''---------------------------
        txtNombreP.Visible = False
        LabelNombre.Visible = False
        txtCorreoP.Visible = False
        LabelCorreo.Visible = False
        Label21.Visible = False
        txtTelefonoP.Visible = False
        Label25.Visible = False
        txtDireccionP.Visible = False
        labelPostal.Visible = True
        txtCP.Visible = True
    End Sub

    Public Sub consultaGeneralProspectos()
        Try                      ''''Consulta de algunos campos solamente
            MetodoMetasCotizador()
            ' DGConsulta.Rows.Clear()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos order by idProspecto"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGConsulta.DataSource = dt
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub

    Private Sub txtTelefonoProspecto_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidaEMail(Cadena As String) As Boolean
        Dim Arroba As Long
        Dim Punto As Long
        ValidaEMail = False
        Arroba = InStr(1, Cadena, "@")
        Punto = InStr(5, Cadena, ".")
        If (Arroba > 0) And (Punto > 0) And (Punto > Arroba) Then ValidaEMail = True
    End Function

    Private Sub cbGeneral_CheckStateChanged(sender As Object, e As EventArgs)
        If bandera = 0 Then

            bandera = 1
        ElseIf bandera = 1 Then

            bandera = 0
        End If
    End Sub

    Private Sub cbAdicional_CheckStateChanged(sender As Object, e As EventArgs)
        If bandera2 = 0 Then

            bandera2 = 1
        ElseIf bandera2 = 1 Then

            bandera2 = 0
        End If
    End Sub

    Private Sub GBGeneral_Enter(sender As Object, e As EventArgs)

    End Sub

    Public Sub LimpiarTextos()
        txtNombreCompania.Text = ""
        txtCorreo.Text = ""
        txtPuesto.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtExt.Text = ""
        txtEstado.Text = ""
        txtDireccion.Text = ""
        txtNumExt.Text = ""
        txtColonia.Text = ""
        txtPais.Text = ""
        txtEdo.Text = ""
        txtCiudad.Text = ""
        txtCodigoPostal.Text = ""
        txtNotas.Text = ""
        txtOrigen.Text = ""
        txtTipoIndustri.Text = ""
        txtHorarioTrabajo.Text = ""

    End Sub

    'Public Sub habilitarTextos()
    '    cboSaludo.Enabled = True
    '    txtNombreProspecto.Enabled = True
    '    txtApellidosProspecto.Enabled = True
    '    txtTelefonoProspecto.Enabled = True
    '    txtExtProspecto.Enabled = True
    '    txtCelularProspecto.Enabled = True
    '    txtCorreoProspecto.Enabled = True
    '    txtPuestoProspecto.Enabled = True
    '    txtHorarioProspecto.Enabled = True
    '    txtCompaniaProspecto.Enabled = True
    '    txtDireccionProspecto.Enabled = True
    '    txtNumExtProspecto.Enabled = True
    '    txtCPProspecto.Enabled = True
    '    txtColoniaProspecto.Enabled = True
    '    cbPaisProspecto.Enabled = True
    '    txtEstadoProspecto.Enabled = True
    '    txtCiudadProspecto.Enabled = True
    '    txtNotasProspecto.Enabled = True
    'End Sub

    Private Sub txtNombreP_TextChanged(sender As Object, e As EventArgs) Handles txtNombreP.TextChanged
        Try
            ' DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.Nombre LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtNombreP.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtCorreoP.Text = ""
                txtTelefonoP.Text = ""
                txtDireccionP.Text = ""
                txtCP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtCorreoP_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoP.TextChanged
        Try
            ' DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.Correo LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtCorreoP.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreP.Text = ""
                txtTelefonoP.Text = ""
                txtDireccionP.Text = ""
                txtCP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtTelefonoP_TextChanged(sender As Object, e As EventArgs) Handles txtTelefonoP.TextChanged
        Try
            ''DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.Telefono LIKE '%' + @Parametro + '%' or Prospectos.Celular LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtTelefonoP.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreP.Text = ""
                txtCorreoP.Text = ""
                txtDireccionP.Text = ""
                txtCP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged
        Try
            '' DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.CP LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtCP.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreP.Text = ""
                txtTelefonoP.Text = ""
                txtCorreoP.Text = ""
                txtDireccionP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtDireccionP_TextChanged(sender As Object, e As EventArgs) Handles txtDireccionP.TextChanged
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.Direccion LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtDireccionP.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreP.Text = ""
                txtTelefonoP.Text = ""
                txtCorreoP.Text = ""
                txtCP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub txtCompania_TextChanged(sender As Object, e As EventArgs) Handles txtCompania.TextChanged
        Try
            'DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.Compania LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", txtCompania.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreP.Text = ""
                txtTelefonoP.Text = ""
                txtCorreoP.Text = ""
                txtCP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtClaveRecopila_TextChanged(sender As Object, e As EventArgs) Handles txtClaveRecopila.TextChanged

    End Sub

    'Private Sub DGConsulta_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGConsulta.RowHeaderMouseDoubleClick

    'End Sub

    Private Sub DGConsulta_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGConsulta.RowHeaderMouseClick
        Try
            Dim clave As String
            clave = DGConsulta.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtClaveRecopila.Text = clave
            consultaGeneralProspectos2(clave)
            EtiquetaNombreDeProspecto.Text = txtNombre.Text
            EtiquetaNombreDeProspecto2.Text = txtNombre.Text
            TabConsulta.SelectTab(1)
            ''Evento click para la regilla---------------------------
            If txtEstado.Text <> "Convertido" Then
                btCancelar.Enabled = True
                btGuardar.Enabled = True
                Button3.Enabled = True
            Else
                btCancelar.Enabled = False
                btGuardar.Enabled = False
                Button3.Enabled = True
            End If
            If EtiquetaNombreDeProspecto.Text <> "" Then
                btAgregarLlamada.Enabled = True
                txtAsuntoLlamada.Enabled = True
                txtComentariosLlamada.Enabled = True
                DTPFechaEstimadaDeLlamada.Enabled = True
                cboRelacionadoConLlamada.Enabled = True
                btAgregarTarea.Enabled = True
                txtAsuntoTarea.Enabled = True
                txtAsignadoTarea.Enabled = True
                DTPFechaDeVencimiento.Enabled = True
                cboRelacionadoConTareas.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Selecciona un registro válido de la regilla.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Admin As New FrmNuevoProspecto
        Admin.txtNombreEmplado.Text = txtNombreEmpleado.Text
        Admin.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DGConsulta.Refresh()
        consultaGeneralProspectos()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If txtEstado.Text.Equals("Convertido") Or txtClaveRecopila.Text.Trim.Equals("") Then
            MsgBox("No se puede modificar este prospecto, ya se encuentra convertido o no se ah asignado alguna clave", MsgBoxStyle.Critical)
        Else
            Try
                Dim Admin As New FrmNuevoProspecto
                Admin.txtNombreEmplado.Text = txtCreador.Text
                Admin.cboSaludo.Text = txtSaludo.Text
                Admin.txtClaveRecopilada.Text = txtClaveProspecto.Text
                Admin.txtNombreProspecto.Text = txtNombreMod.Text ''
                Admin.txtApellidosProspecto.Text = txtApellidos.Text ''
                Admin.txtTelefonoProspecto.Text = txtTelefono.Text ''
                Admin.txtExtProspecto.Text = txtExt.Text ''
                Admin.txtCelularProspecto.Text = txtCelular.Text ''
                Admin.txtCorreoProspecto.Text = txtCorreo.Text ''
                Admin.txtPuestoProspecto.Text = txtPuesto.Text
                Admin.txtHorarioProspecto.Text = txtHorarioTrabajo.Text
                Admin.txtCompaniaProspecto.Text = txtNombreCompania.Text ''
                Admin.txtDireccionProspecto.Text = txtDireccion.Text ''
                Admin.txtNumExtProspecto.Text = txtNumExt.Text ''
                Admin.txtCPProspecto.Text = txtCodigoPostal.Text ''
                Admin.txtColoniaProspecto.Text = txtColonia.Text ''
                Admin.cbPaisProspecto.Text = txtPais.Text ''
                Admin.txtEstadoProspecto.Text = txtEdo.Text ''
                Admin.txtCiudadProspecto.Text = txtCiudad.Text ''
                Admin.txtNotasProspecto.Text = txtNotas.Text ''
                Admin.cboStatus.Text = txtEstado.Text ''
                Admin.cboOrigen.Text = txtOrigen.Text ''
                Admin.cboTipoIndustria.Text = txtTipoIndustri.Text ''
                Admin.txtCreado.Text = txtCreado.Text
                Admin.txtModificado.Text = txtModificado.Text
                Admin.btGuardar.Text = "Actualizar datos"
                Admin.Label42.Text = "Modificar datos de prospecto"
                Admin.btCancelar.Visible = False
                Admin.btGuardarYnuevo.Visible = False
                Admin.txtUsuarioActual.Text = txtNombreEmpleado.Text
                Admin.ShowDialog()
            Catch ex As Exception
                MsgBox("Ocurrio un error en el envio de credenciales, verifica nuevamente.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        'If txtEstado.Text.Equals("Convertido") Or txtClaveRecopila.Text.Trim.Equals("") Then
        '    MsgBox("No se puede modificar este prospecto, ya se encuentra convertido o no se ah asignado alguna clave", MsgBoxStyle.Critical)
        'Else
        '    ''Mandar mensaje de que se convertira en contacto
        '    resultado = MsgBox("Este prospecto será convertido a contacto, ¿Deseas continuar con el proceso?", vbYesNo, "Prospectos dice")

        '    If resultado = vbYes Then
        '        'MsgBox("Continua")
        '        Dim control As New FrmNuevoContacto
        '        control.txtClaveRecopila.Text = txtClaveRecopila.Text
        '        control.txtNombreEmplado.Text = txtNombreEmpleado.Text
        '        control.txtUsuarioActual.Text = txtNombreEmpleado.Text
        '        control.txtNombre.Text = txtNombreMod.Text
        '        control.txtApellidoPaterno.Text = txtApellidos.Text
        '        '  control.txtApellidoMaterno.Text = ""
        '        control.txtCompania.Text = txtNombreCompania.Text
        '        ' control.txtDepartamento.Text = ""
        '        ' control.txtRFC.Text = ""
        '        ' control.txtOrganizacion.Text = ""
        '        control.cboStatus.Text = txtEstado.Text
        '        'control.txtNumeroDeCuenta.Text = ""
        '        control.txtCelular.Text = txtCelular.Text
        '        control.txtTelefono.Text = txtTelefono.Text
        '        control.txtExtension.Text = txtExt.Text
        '        control.txtCorreo1.Text = txtCorreo.Text
        '        ' control.txtCorreo2.Text = ""
        '        ' control.txtFax.Text = ""
        '        control.txtDireccion1.Text = txtDireccion.Text
        '        'control.txtDireccion2.Text = ""
        '        ' control.txtDireccion3.Text = ""
        '        control.txtEstado.Text = txtEdo.Text
        '        control.cboPais.Text = txtPais.Text
        '        control.txtColonia.Text = txtColonia.Text
        '        control.txtCiudad.Text = txtCiudad.Text
        '        control.txtCodigoPostal.Text = txtCodigoPostal.Text
        '        control.txtNumeroExterior.Text = txtNumExt.Text
        '        control.cboOrigen.Text = txtOrigen.Text
        '        control.cboTipoIndustria.Text = txtTipoIndustri.Text
        '        ' control.txtTerminosDePago.Text = txtNumExt.Text
        '        ' control.cboCategoria.Text = txtNumExt.Text
        '        'control.txtIDFiscal.Text = txtNumExt.Text
        '        'control.cboMoneda.Text = txtNumExt.Text
        '        'control.cboOpcionesDePago.Text = txtNumExt.Text
        '        'control.cboDefaultPO.Text = txtNumExt.Text
        '        'control.cboModoDeEnvio.Text = txtNumExt.Text
        '        'control.txtDescuentoDeCalibracion.Text = txtNumExt.Text
        '        ' control.txtTaxException.Text = txtNumExt.Text
        '        ' control.txtCuentaDeEnvio.Text = txtNumExt.Text
        '        ' control.txtHorarioDeTrabajo.Text = txtNumExt.Text
        '        'control.cboAvisoDeRecuperacion.Text = txtNumExt.Text
        '        ''control.cboRequerimientosDeCalidad.Text = txtNumExt.Text
        '        'control.cboVencimientoDeCalibracion.Text = txtNumExt.Text
        '        control.txtNotas.Text = txtNotas.Text
        '        'control.txtNombreDeArchivo.Text = txtNumExt.Text
        '        control.txtDireccion1Facturacion.Text = ""
        '        control.txtDireccion2Facturacion.Text = ""
        '        control.txtDireccion3Facturacion.Text = ""
        '        control.txtEstadoFacturacion.Text = ""
        '        control.cboPaisFacturacion.Text = ""
        '        control.txtColoniaFacturacion.Text = ""
        '        control.txtCiudadFacturacion.Text = ""
        '        control.txtCodigoPostalFacturacion.Text = ""
        '        control.txtNumExteriorFacturacion.Text = ""
        '        control.txtDireccion1Entrega.Text = ""
        '        control.txtDireccion2Entrega.Text = ""
        '        control.txtDireccion3Entrega.Text = ""
        '        control.txtEstadoEntrega.Text = ""
        '        control.cboPaisEntrega.Text = ""
        '        control.txtColoniaEntrega.Text = ""
        '        control.txtCiudadEntrega.Text = ""
        '        control.txtCodigoPostalEntrega.Text = ""
        '        control.txtNumExteriorEntrega.Text = ""
        '        control.Show()

        '    Else
        '        MsgBox("No continua")
        '    End If
        'End If
        FrmEmergenteConvertir.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EtiquetaNombreDeProspecto.Text = txtNombre.Text
        EtiquetaNombreDeProspecto2.Text = txtNombre.Text
        TabConsulta.SelectTab(2)
    End Sub

    Private Sub btAgregarLlamada_Click(sender As Object, e As EventArgs) Handles btAgregarLlamada.Click
        ''Verificar si el estado del prospecto no esta convertido o vacio
        If txtEstado.Text.Equals("Convertido") Or txtClaveRecopila.Text.Trim.Equals("") Then
            MsgBox("No se puede modificar este prospecto, ya se encuentra convertido o no se ah asignado alguna clave", MsgBoxStyle.Critical)
        Else
            ''Guardar los datos en la tabla de llamadasProspectos
            Try
                Dim FechaEstimada As String
                FechaEstimada = DTPFechaEstimadaDeLlamada.Value.Date.Year & "-" & DTPFechaEstimadaDeLlamada.Value.Date.Month & "-" & DTPFechaEstimadaDeLlamada.Value.Date.Day
                MsgBox(FechaEstimada)
                MetodoMetasCotizador()
                Dim R As String
                R = "insert into ActividadLlamadaProspectos (Asunto, Comentarios, FechaEstimadaDeLlamada, RelacionadoCon, idProspecto) 
                     values ('" & txtAsuntoLlamada.Text & "','" & txtComentariosLlamada.Text & "',
                     '" & FechaEstimada & "','" & cboRelacionadoConLlamada.Text & "'," & txtClaveRecopila.Text & ")"
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                MsgBox("Llamada guardada correctamente", MsgBoxStyle.OkOnly)
                limpiarRegistroLlamada()
                TabConsulta.SelectTab(1)
            Catch ex As Exception
                MsgBox("Ocurrio un error en la inserción de registros en la base de datos.", MsgBoxStyle.Exclamation)
            End Try
        End If
        conexionMetasCotizador.Close()
    End Sub

    Private Sub btAgregarTarea_Click(sender As Object, e As EventArgs) Handles btAgregarTarea.Click
        ''Verificar si el estado del prospecto no esta convertido o vacio
        If txtEstado.Text.Equals("Convertido") Or txtClaveRecopila.Text.Trim.Equals("") Then
            MsgBox("No se puede modificar este prospecto, ya se encuentra convertido o no se ah asignado alguna clave", MsgBoxStyle.Critical)
        Else
            ''Guardar los datos en la tabla de  TareasProspectos
            Try
                Dim FechaVencimiento As String
                FechaVencimiento = DTPFechaDeVencimiento.Value.Date.Year & "-" & DTPFechaDeVencimiento.Value.Date.Month & "-" & DTPFechaDeVencimiento.Value.Date.Day
                MsgBox(FechaVencimiento)
                MetodoMetasCotizador()
                Dim R As String
                R = "insert into ActividadTareaProspectos (Asunto, FechaDeVencimiento, AsignadoA, idProspecto, RelacionadoCon) 
                     values ('" & txtAsuntoTarea.Text & "','" & FechaVencimiento & "',
                     '" & txtAsignadoTarea.Text & "'," & txtClaveRecopila.Text & ",'" & cboRelacionadoConTareas.Text & "')"
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                MsgBox("Llamada guardada correctamente", MsgBoxStyle.OkOnly)
                limpiarRegistroTareas()
                TabConsulta.SelectTab(1)
            Catch ex As Exception
                MsgBox("Ocurrio un error en la inserción de registros en la base de datos.", MsgBoxStyle.Exclamation)
            End Try
        End If
        conexionMetasCotizador.Close()
    End Sub
    'Public Sub DeshabilitarTextos()
    '    cboSaludo.Enabled = False
    '    txtNombreProspecto.Enabled = False
    '    txtApellidosProspecto.Enabled = False
    '    txtTelefonoProspecto.Enabled = False
    '    txtExtProspecto.Enabled = False
    '    txtCelularProspecto.Enabled = False
    '    txtCorreoProspecto.Enabled = False
    '    txtPuestoProspecto.Enabled = False
    '    txtHorarioProspecto.Enabled = False
    '    txtCompaniaProspecto.Enabled = False
    '    txtDireccionProspecto.Enabled = False
    '    txtNumExtProspecto.Enabled = False
    '    txtCPProspecto.Enabled = False
    '    txtColoniaProspecto.Enabled = False
    '    cbPaisProspecto.Enabled = False
    '    txtEstadoProspecto.Enabled = False
    '    txtCiudadProspecto.Enabled = False
    '    txtNotasProspecto.Enabled = False
    'End Sub

    'Private Sub DGConsulta_DoubleClick(sender As Object, e As EventArgs) Handles DGConsulta.DoubleClick
    '    TabConsulta.SelectTab(1)
    '    txtClaveRecopila.Text = 1
    '    MsgBox("Realiza la consulta")

    'End Sub

    Public Sub consultaGeneralProspectos2(ByVal claveRecopilada As Integer)
        IndicadorNuevo.Image = My.Resources.gray
        IndicadorContactado.Image = My.Resources.gray
        IndicadorWorking.Image = My.Resources.gray
        IndicadorNo.Image = My.Resources.gray
        IndicadorConvertido.Image = My.Resources.gray
        ''-------------------------------------------
        IndicadorNuevo2.Image = My.Resources.gray
        IndicadorContactado2.Image = My.Resources.gray
        IndicadorWorking2.Image = My.Resources.gray
        IndicadorNo2.Image = My.Resources.gray
        IndicadorConvertido2.Image = My.Resources.gray
        Try                      ''''Consulta de algunos campos solamente
            MetodoMetasCotizador()
            Dim vacio As String = "-"
            Dim R As String
            R = "select * from Prospectos where Prospectos.idProspecto=" & claveRecopilada & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.Read() Then
                If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
                    txtClaveProspecto.Text = vacio
                Else
                    txtClaveProspecto.Text = lector(0)
                End If
                If ((lector(1) Is DBNull.Value) OrElse (lector(1) Is Nothing) Or (lector(2) Is DBNull.Value) OrElse (lector(2) Is Nothing)) Then
                    txtNombre.Text = vacio
                Else
                    txtNombre.Text = lector(1) & " " & lector(2)
                    txtNombreMod.Text = lector(1)
                    txtApellidos.Text = lector(2)
                End If
                'If ((lector(2) Is DBNull.Value) OrElse (lector(2) Is Nothing)) Then
                '    txtApellidos.Text = vacio
                'Else
                '    txtApellidos.Text = lector(2)
                'End If
                If ((lector(3) Is DBNull.Value) OrElse (lector(3) Is Nothing)) Then
                    txtTelefono.Text = vacio
                Else
                    txtTelefono.Text = lector(3)
                End If
                ''''''
                If ((lector(4) Is DBNull.Value) OrElse (lector(4) Is Nothing)) Then
                    txtExt.Text = vacio
                Else
                    txtExt.Text = lector(4)
                End If
                If ((lector(5) Is DBNull.Value) OrElse (lector(5) Is Nothing)) Then
                    txtCelular.Text = vacio
                Else
                    txtCelular.Text = lector(5)
                End If
                If ((lector(6) Is DBNull.Value) OrElse (lector(6) Is Nothing)) Then
                    txtCorreo.Text = vacio
                Else
                    txtCorreo.Text = lector(6)
                End If
                If ((lector(7) Is DBNull.Value) OrElse (lector(7) Is Nothing)) Then
                    txtPuesto.Text = vacio
                Else
                    txtPuesto.Text = lector(7)
                End If
                If ((lector(8) Is DBNull.Value) OrElse (lector(8) Is Nothing)) Then
                    txtHorarioTrabajo.Text = vacio
                Else
                    txtHorarioTrabajo.Text = lector(8)
                End If
                If ((lector(9) Is DBNull.Value) OrElse (lector(9) Is Nothing)) Then
                    txtNombreCompania.Text = vacio
                Else
                    txtNombreCompania.Text = lector(9)
                End If
                If ((lector(10) Is DBNull.Value) OrElse (lector(10) Is Nothing)) Then
                    txtDireccion.Text = vacio
                Else
                    txtDireccion.Text = lector(10)
                End If
                If ((lector(11) Is DBNull.Value) OrElse (lector(11) Is Nothing)) Then
                    txtNumExt.Text = vacio
                Else
                    txtNumExt.Text = lector(11)
                End If
                If ((lector(12) Is DBNull.Value) OrElse (lector(12) Is Nothing)) Then
                    txtCodigoPostal.Text = vacio
                Else
                    txtCodigoPostal.Text = lector(12)
                End If
                If ((lector(13) Is DBNull.Value) OrElse (lector(13) Is Nothing)) Then
                    txtColonia.Text = vacio
                Else
                    txtColonia.Text = lector(13)
                End If
                If ((lector(13) Is DBNull.Value) OrElse (lector(14) Is Nothing)) Then
                    txtPais.Text = vacio
                Else
                    txtPais.Text = lector(14)
                End If
                If ((lector(15) Is DBNull.Value) OrElse (lector(15) Is Nothing)) Then
                    txtEdo.Text = vacio
                Else
                    txtEdo.Text = lector(15)
                End If
                If ((lector(16) Is DBNull.Value) OrElse (lector(16) Is Nothing)) Then
                    txtCiudad.Text = vacio
                Else
                    txtCiudad.Text = lector(16)
                End If
                If ((lector(17) Is DBNull.Value) OrElse (lector(17) Is Nothing)) Then
                    txtNotas.Text = vacio
                Else
                    txtNotas.Text = lector(17)
                End If
                If ((lector(18) Is DBNull.Value) OrElse (lector(18) Is Nothing) Or (lector(19) Is DBNull.Value) OrElse (lector(19) Is Nothing)) Then
                    txtCreado.Text = vacio
                Else
                    txtCreado.Text = lector(18) & "-->" & lector(19)
                    txtCreador.Text = lector(18)
                End If

                If ((lector(20) Is DBNull.Value) OrElse (lector(20) Is Nothing) Or (lector(21) Is DBNull.Value) OrElse (lector(21) Is Nothing)) Then
                    txtModificado.Text = vacio
                Else
                    txtModificado.Text = lector(20) & "-->" & lector(21)
                End If
                If ((lector(22) Is DBNull.Value) OrElse (lector(22) Is Nothing)) Then
                    txtEstado.Text = vacio
                Else
                    ''Hacer la verficacion de los indicadores verdes o grises  
                    txtEstado.Text = lector(22)
                    If txtEstado.Text.Trim.Equals("No calificado") Then
                        ''---------------------------------------
                        IndicadorNuevo.Image = My.Resources.green
                        IndicadorContactado.Image = My.Resources.gray
                        IndicadorWorking.Image = My.Resources.gray
                        IndicadorNo.Image = My.Resources.gray
                        IndicadorConvertido.Image = My.Resources.gray
                        ''--
                        IndicadorNuevo2.Image = My.Resources.green
                        IndicadorContactado2.Image = My.Resources.gray
                        IndicadorWorking2.Image = My.Resources.gray
                        IndicadorNo2.Image = My.Resources.gray
                        IndicadorConvertido2.Image = My.Resources.gray
                        ''---------------------------------------------
                    ElseIf txtEstado.Text.Trim.Equals("Nuevo") Then
                        IndicadorNuevo.Image = My.Resources.green
                        IndicadorContactado.Image = My.Resources.green
                        IndicadorWorking.Image = My.Resources.gray
                        IndicadorNo.Image = My.Resources.gray
                        IndicadorConvertido.Image = My.Resources.gray
                        ''--
                        IndicadorNuevo2.Image = My.Resources.green
                        IndicadorContactado2.Image = My.Resources.green
                        IndicadorWorking2.Image = My.Resources.gray
                        IndicadorNo2.Image = My.Resources.gray
                        IndicadorConvertido2.Image = My.Resources.gray

                    ElseIf txtEstado.Text.Trim.Equals("Working") Then
                        IndicadorNuevo.Image = My.Resources.green
                        IndicadorContactado.Image = My.Resources.green
                        IndicadorWorking.Image = My.Resources.green
                        IndicadorNo.Image = My.Resources.gray
                        IndicadorConvertido.Image = My.Resources.gray
                        ''---
                        IndicadorNuevo2.Image = My.Resources.green
                        IndicadorContactado2.Image = My.Resources.green
                        IndicadorWorking2.Image = My.Resources.green
                        IndicadorNo2.Image = My.Resources.gray
                        IndicadorConvertido2.Image = My.Resources.gray

                    ElseIf txtEstado.Text.Trim.Equals("Promoviendo") Then
                        IndicadorNuevo.Image = My.Resources.green
                        IndicadorContactado.Image = My.Resources.green
                        IndicadorWorking.Image = My.Resources.green
                        IndicadorNo.Image = My.Resources.green
                        IndicadorConvertido.Image = My.Resources.gray
                        ''---
                        IndicadorNuevo2.Image = My.Resources.green
                        IndicadorContactado2.Image = My.Resources.green
                        IndicadorWorking2.Image = My.Resources.green
                        IndicadorNo2.Image = My.Resources.green
                        IndicadorConvertido2.Image = My.Resources.gray

                    ElseIf txtEstado.Text.Trim.Equals("Convertido") Then
                        IndicadorNuevo.Image = My.Resources.green
                        IndicadorContactado.Image = My.Resources.green
                        IndicadorWorking.Image = My.Resources.green
                        IndicadorNo.Image = My.Resources.green
                        IndicadorConvertido.Image = My.Resources.green
                        ''---
                        IndicadorNuevo2.Image = My.Resources.green
                        IndicadorContactado2.Image = My.Resources.green
                        IndicadorWorking2.Image = My.Resources.green
                        IndicadorNo2.Image = My.Resources.green
                        IndicadorConvertido2.Image = My.Resources.green
                    End If
                End If
                If ((lector(23) Is DBNull.Value) OrElse (lector(23) Is Nothing)) Then
                    txtOrigen.Text = vacio
                Else
                    txtOrigen.Text = lector(23)
                End If
                If ((lector(24) Is DBNull.Value) OrElse (lector(24) Is Nothing)) Then
                    txtTipoIndustri.Text = vacio
                Else
                    txtTipoIndustri.Text = lector(24)
                End If
                If ((lector(25) Is DBNull.Value) OrElse (lector(25) Is Nothing)) Then
                    txtSaludo.Text = vacio
                Else
                    txtSaludo.Text = lector(25)
                End If
                lector.Close()
            Else
                MsgBox("No hay registros", MsgBoxStyle.Information)
                lector.Close()
            End If
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, porfavor llama al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub limpiarRegistroLlamada()
        txtAsuntoLlamada.Text = ""
        txtComentariosLlamada.Text = ""
        cboRelacionadoConLlamada.Text = ""
        EtiquetaNombreDeProspecto.Text = ""
    End Sub

    Private Sub cboStatusFiltrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFiltrado.SelectedIndexChanged
        Try
            'DGConsulta.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String
            R = "select idProspecto as [Clave de prospecto], Nombre, Compania, Direccion as Dirección, Estado as [Estado o Provincia], Ciudad,  Telefono, Correo, Status, FechaCreacion, Notas from Prospectos where Prospectos.Status LIKE '%' + @Parametro + '%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@Parametro", cboStatusFiltrado.Text)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                DGConsulta.DataSource = Nothing
            Else
                DGConsulta.DataSource = dt
                txtNombreP.Text = ""
                txtTelefonoP.Text = ""
                txtCorreoP.Text = ""
                txtCP.Text = ""
            End If
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Clave de prospecto").Style.BackColor = Color.LightSteelBlue
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TabDetallesProspecto_Click(sender As Object, e As EventArgs) Handles TabDetallesProspecto.Click

    End Sub


    Public Sub limpiarRegistroTareas()
        txtAsuntoTarea.Text = ""
        txtAsignadoTarea.Text = ""
        cboRelacionadoConTareas.Text = ""
        EtiquetaNombreDeProspecto2.Text = ""
    End Sub
End Class