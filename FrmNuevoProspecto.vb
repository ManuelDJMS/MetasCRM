Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmNuevoProspecto
    Dim bandera, bandera2, bandera3 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Dispose()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        '  Try
        If btGuardar.Text.Trim.Equals("guardar") Then
            'Try
            If cbGeneral.Checked() = True And cbAdicional.Checked = True And cbinfoAdd.Checked = True Then
                MetodoMetasCotizador()
                Dim R As String
                        R = "update Prospectos set Nombre='" & txtNombreProspecto.Text.Trim & "',
                        TratoSaludo='" & cboSaludo.Text.Trim & "', 
                        Apellidos='" & txtApellidosProspecto.Text.Trim & "', 
                        Telefono='" & txtTelefonoProspecto.Text.Trim & "',
                        Ext='" & txtExtProspecto.Text.Trim & "',
                        Celular='" & txtCelularProspecto.Text.Trim & "',
                        Correo='" & txtCorreoProspecto.Text.Trim & "',
                        Puesto='" & txtPuestoProspecto.Text.Trim & "',
                        HorarioTrabajo='" & txtHorarioProspecto.Text.Trim & "',
                        Compania='" & txtCompaniaProspecto.Text.Trim & "',
                        Direccion='" & txtDireccionProspecto.Text.Trim & "',
                        NumExt='" & txtNumExtProspecto.Text.Trim & "',
                        CP='" & txtCPProspecto.Text.Trim & "',
                        Colonia='" & txtColoniaProspecto.Text.Trim & "',
                        Pais='" & cbPaisProspecto.Text.Trim & "',
                        Estado='" & txtEstadoProspecto.Text.Trim & "',
                        Ciudad='" & txtCiudadProspecto.Text.Trim & "',
                        Notas='" & txtNotasProspecto.Text.Trim & "',           
                        QuienModifico='" & txtUsuarioActual.Text.Trim & "',
                        FechaModificacion='" & DTPFechaActual.Value & "',
                        Status='" & cboStatus.Text.Trim & "',
                        OrigenProspecto='" & cboOrigen.Text.Trim & "',
                        TipoIndustria='" & cboTipoIndustria.Text.Trim & "' where idProspecto=" & Val(txtClaveRecopilada.Text) & ""
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                        MsgBox("Modificado correctamente", MsgBoxStyle.Information)
                        LimpiarTextos()
                        DeshabilitarTextos()
                Me.Dispose()
                conexionMetasCotizador.Close()
            Else
                        MsgBox("Finaliza la inserción de datos, marca las casillas de verificación", MsgBoxStyle.Exclamation)
                    End If
            ' Catch ex As Exception
            'Box("Ocurrio un error en la modificación del prospecto, verifica los datos e intenta nuevamente", MsgBoxStyle.Exclamation)
            'End Try
        Else
                If cbGeneral.Checked() = True And cbAdicional.Checked = True And cbinfoAdd.Checked = True Then
                    Dim quienModifico, FechaModificacion As String
                    quienModifico = "-"
                    FechaModificacion = "-"
                    'Insert en Prospectos
                    If txtNombreProspecto.Text.Trim.Equals("") Or txtApellidosProspecto.Text.Trim.Equals("") Or txtTelefonoProspecto.Text.Trim.Equals("") Or txtCorreoProspecto.Text.Trim.Equals("") Or txtCompaniaProspecto.Text.Trim.Equals("") Or txtDireccionProspecto.Text.Trim.Equals("") Or cboStatus.Text.Trim.Equals("") Then
                        MsgBox("Por favor completa los campos obligatorios.", MsgBoxStyle.Exclamation)
                    Else
                    MetodoMetasCotizador()
                    Dim R As String
                    R = "insert into Prospectos (Nombre, Apellidos, Telefono, Ext, Celular,
                    Correo, Puesto, HorarioTrabajo, Compania, Direccion, NumExt, CP, 
                    Colonia, Pais, Estado, Ciudad, Notas, QuienCreo, FechaCreacion, QuienModifico,
                    FechaModificacion, Status, OrigenProspecto, TipoIndustria) values ('" & txtNombreProspecto.Text.Trim & "','" & txtApellidosProspecto.Text.Trim & "','" & txtTelefonoProspecto.Text.Trim & "',
                    '" & txtExtProspecto.Text.Trim & "','" & txtCelularProspecto.Text.Trim & "',
                    '" & txtCorreoProspecto.Text.Trim & "',
                    '" & txtPuestoProspecto.Text.Trim & "',
                    '" & txtHorarioProspecto.Text.Trim & "',
                    '" & txtCompaniaProspecto.Text.Trim & "',
                    '" & txtDireccionProspecto.Text.Trim & "',
                    '" & txtNumExtProspecto.Text.Trim & "',
                    '" & txtCPProspecto.Text.Trim & "',
                    '" & txtColoniaProspecto.Text.Trim & "',
                    '" & cbPaisProspecto.Text.Trim & "',
                    '" & txtEstadoProspecto.Text.Trim & "',
                    '" & txtCiudadProspecto.Text.Trim & "',
                    '" & txtNotasProspecto.Text.Trim & "',
                    '" & txtNombreEmplado.Text.Trim & "',
                    '" & DTPFechaActual.Value & "','" & quienModifico & "','" & FechaModificacion & "',
                    '" & cboStatus.Text.Trim & "','" & cboOrigen.Text.Trim & "','" & cboTipoIndustria.Text.Trim & "')"

                    Dim comando As New SqlCommand(R, conexionMetasCotizador)
                    comando.ExecuteNonQuery()
                    conexionMetasCotizador.Close()
                    MsgBox("Guardado Correctamente", MsgBoxStyle.Information)
                        LimpiarTextos()
                        DeshabilitarTextos()
                        Me.Dispose()
                    End If
                Else
                    MsgBox("Finaliza la inserción de datos, marca las casillas de verificación", MsgBoxStyle.Exclamation)
                End If
            End If
        ' Catch ex As Exception
        'MsgBox("Ocurrio un error en la inserción de los datos.", MsgBoxStyle.Critical)
        ' End Try
    End Sub

    Private Sub btGuardarYnuevo_Click(sender As Object, e As EventArgs) Handles btGuardarYnuevo.Click
        Try
            Dim quienModifico, FechaModificacion As String
            quienModifico = "-"
            FechaModificacion = "-"
            'Insert en Prospectos
            If cbGeneral.Checked() = True And cbAdicional.Checked = True And cbinfoAdd.Checked = True Then

                If txtNombreProspecto.Text.Trim.Equals("") Or txtApellidosProspecto.Text.Trim.Equals("") Or txtTelefonoProspecto.Text.Trim.Equals("") Or txtCorreoProspecto.Text.Trim.Equals("") Or txtCompaniaProspecto.Text.Trim.Equals("") Or txtDireccionProspecto.Text.Trim.Equals("") Or cboStatus.Text.Trim.Equals("") Then
                    MsgBox("Completa los campos obligatorios.", MsgBoxStyle.Exclamation)
                Else
                    MetodoMetasCotizador()
                    Dim R As String
                    R = "insert into Prospectos (Nombre, Apellidos, Telefono, Ext, Celular,
                        Correo, Puesto, HorarioTrabajo, Compania, Direccion, NumExt, CP, 
                        Colonia, Pais, Estado, Ciudad, Notas, QuienCreo, FechaCreacion, QuienModifico,
                        FechaModificacion, Status, OrigenProspecto, TipoIndustria) 
                values ('" & txtNombreProspecto.Text.Trim & "'," & txtApellidosProspecto.Text.Trim & "'," & txtTelefonoProspecto.Text.Trim & "'," & txtExtProspecto.Text.Trim & "',
                " & txtCelularProspecto.Text.Trim & "',
                 " & txtCorreoProspecto.Text.Trim & "',
                " & txtPuestoProspecto.Text.Trim & "',
                 " & txtHorarioProspecto.Text.Trim & "',
                " & txtCompaniaProspecto.Text.Trim & "',
                 " & txtDireccionProspecto.Text.Trim & "',
                " & txtNumExtProspecto.Text.Trim & "',
                 " & txtCPProspecto.Text.Trim & "',
                " & txtColoniaProspecto.Text.Trim & "',
                 " & cbPaisProspecto.Text.Trim & "',
                " & txtEstadoProspecto.Text.Trim & "',
                " & txtCiudadProspecto.Text.Trim & "',
                " & txtNotasProspecto.Text.Trim & "',
                " & txtNombreEmplado.Text.Trim & "',
                " & DTPFechaActual.Value & "',
                " & quienModifico & "',
                " & FechaModificacion & "',
                " & cboStatus.Text.Trim & "',
                " & cboOrigen.Text.Trim & "',
                " & cboTipoIndustria.Text.Trim & "')"

                    Dim comando As New SqlCommand(R, conexionMetasCotizador)
                    comando.ExecuteNonQuery()
                    conexionMetasCotizador.Close()
                    MsgBox("Guardado Correctamente", MsgBoxStyle.Information)

                    LimpiarTextos()
                    habilitarTextos()

                    cbGeneral.Checked = False
                    cbAdicional.Checked = False
                    cbinfoAdd.Checked = False
                End If
            Else
                MsgBox("Finaliza la inserción de datos", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error en la inserción de los datos.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmNuevoProspecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MetodoLIMS()
        cboStatus.Items.Add("--Ninguno--")
        cboStatus.Items.Add("Nuevo")
        cboStatus.Items.Add("Working")
        cboStatus.Items.Add("No habilitado")
        cboStatus.Items.Add("Convertido")


        cboSaludo.Items.Add("Sr.")
        cboSaludo.Items.Add("Sra.")
        cboSaludo.Items.Add("Srta.")
        cboSaludo.Items.Add("Ing.")
        cboSaludo.Items.Add("Dr.")
        cboSaludo.Items.Add("Prof.")

        '' cargar datos de las tablas SetupCustomerSource
        '' cargar datos de las tablas SetupQualityRequierement
        Dim R As String
        R = "select CustomerSource from SetupCustomerSource"
        Dim comando As New SqlCommand(R, conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read()
            cboOrigen.Items.Add(lector(0))
        End While
        lector.Close()


        comando.CommandText = "select [CustomerType] from MasterCustomerType"
        lector = comando.ExecuteReader
        While lector.Read()
            cboTipoIndustria.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "select [StateName], [StateId] from [MasterStateCountry]"
        lector = comando.ExecuteReader
        While lector.Read()
            cbPaisProspecto.Items.Add(lector(0) & " - " & lector(1))
        End While
        lector.Close()

        conexionLIMS.Close()
    End Sub


    Private Sub txtTelefonoProspecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefonoProspecto.KeyPress, txtExtProspecto.KeyPress, txtCelularProspecto.KeyPress, txtNumExtProspecto.KeyPress, txtCPProspecto.KeyPress
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

    Private Sub txtCorreoProspecto_LostFocus(sender As Object, e As EventArgs) Handles txtCorreoProspecto.LostFocus
        If Not ValidaEMail(txtCorreoProspecto.Text) Then
            MsgBox("El Formato de correo es incorrecto", MsgBoxStyle.Information)
            txtCorreoProspecto.Text = ""
        End If
    End Sub

    Private Sub cbGeneral_CheckStateChanged(sender As Object, e As EventArgs) Handles cbGeneral.CheckStateChanged
        If bandera = 0 Then
            GBInfo.Enabled = False
            bandera = 1
        ElseIf bandera = 1 Then
            GBInfo.Enabled = True
            bandera = 0
        End If
    End Sub

    Private Sub cbAdicional_CheckStateChanged(sender As Object, e As EventArgs) Handles cbAdicional.CheckStateChanged
        If bandera2 = 0 Then
            GBGeneral.Enabled = False
            bandera2 = 1
        ElseIf bandera2 = 1 Then
            GBGeneral.Enabled = True
            bandera2 = 0
        End If
    End Sub

    Private Sub cbinfoAdd_CheckStateChanged(sender As Object, e As EventArgs) Handles cbinfoAdd.CheckStateChanged
        If bandera3 = 0 Then
            GBinfoAdd.Enabled = False
            bandera3 = 1
        ElseIf bandera3 = 1 Then
            GBinfoAdd.Enabled = True
            bandera3 = 0
        End If
    End Sub


    Public Sub LimpiarTextos()
        cboSaludo.Text = ""
        txtNombreProspecto.Text = ""
        txtApellidosProspecto.Text = ""
        txtTelefonoProspecto.Text = ""
        txtExtProspecto.Text = ""
        txtCelularProspecto.Text = ""
        txtCorreoProspecto.Text = ""
        txtPuestoProspecto.Text = ""
        txtHorarioProspecto.Text = ""
        txtCompaniaProspecto.Text = ""
        txtDireccionProspecto.Text = ""
        txtNumExtProspecto.Text = ""
        txtCPProspecto.Text = ""
        txtColoniaProspecto.Text = ""
        cbPaisProspecto.Text = ""
        txtEstadoProspecto.Text = ""
        txtCiudadProspecto.Text = ""
        txtNotasProspecto.Text = ""
        cboStatus.Text = ""
        cboOrigen.Text = ""
        cboTipoIndustria.Text = ""
        cbGeneral.Checked = False
        cbAdicional.Checked = False
        cbinfoAdd.Checked = False
    End Sub


    Public Sub habilitarTextos()
        cboSaludo.Enabled = True
        txtNombreProspecto.Enabled = True
        txtApellidosProspecto.Enabled = True
        txtTelefonoProspecto.Enabled = True
        txtExtProspecto.Enabled = True
        txtCelularProspecto.Enabled = True
        txtCorreoProspecto.Enabled = True
        txtPuestoProspecto.Enabled = True
        txtHorarioProspecto.Enabled = True
        txtCompaniaProspecto.Enabled = True
        txtDireccionProspecto.Enabled = True
        txtNumExtProspecto.Enabled = True
        txtCPProspecto.Enabled = True
        txtColoniaProspecto.Enabled = True
        cbPaisProspecto.Enabled = True
        txtEstadoProspecto.Enabled = True
        txtCiudadProspecto.Enabled = True
        txtNotasProspecto.Enabled = True
        cboStatus.Enabled = True
        cboOrigen.Enabled = True
        cboTipoIndustria.Enabled = True
    End Sub
    Public Sub DeshabilitarTextos()
        cboSaludo.Enabled = False
        txtNombreProspecto.Enabled = False
        txtApellidosProspecto.Enabled = False
        txtTelefonoProspecto.Enabled = False
        txtExtProspecto.Enabled = False
        txtCelularProspecto.Enabled = False
        txtCorreoProspecto.Enabled = False
        txtPuestoProspecto.Enabled = False
        txtHorarioProspecto.Enabled = False
        txtCompaniaProspecto.Enabled = False
        txtDireccionProspecto.Enabled = False
        txtNumExtProspecto.Enabled = False
        txtCPProspecto.Enabled = False
        txtColoniaProspecto.Enabled = False
        cbPaisProspecto.Enabled = False
        txtEstadoProspecto.Enabled = False
        txtCiudadProspecto.Enabled = False
        txtNotasProspecto.Enabled = False
        cboStatus.Enabled = False
        cboOrigen.Enabled = False
        cboTipoIndustria.Enabled = False
    End Sub


End Class