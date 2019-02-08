Imports System.Data.SqlClient
Public Class frmEdicionCot2018_2019
    Dim bandera As Boolean
    Dim dt2 As New DataTable
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter

    Private Sub frmEdicionCot2018_2019_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasInf2018()
        comando2018 = conexion2018.CreateCommand
        Dim R As String
        R = "select MetAsInf.Clavempresa, MetAsInf.Compania, MetAsInf.DomicilioConsig, MetAsInf.CiudadConsig, MetAsInf.EdoConsig,
         [Contactos-Clientes-Usuarios].ClaveContacto, [Contactos-Clientes-Usuarios].Nombre, [Contactos-Clientes-Usuarios].Tel,
         [Contactos-Clientes-Usuarios].Ext, [Contactos-Clientes-Usuarios].Email, EntradaRegistroCot.Numcot, EntradaRegistroCot.Fecha,
         EntradaRegistroCot.Referencia, EntradaRegistroCot.Observaciones, EntradaRegistroCot.Numcond, Condiciones_p_cotizar.donde,
         Condiciones_p_cotizar.Precios, Condiciones_p_cotizar.tentrega, Condiciones_p_cotizar.modalidad, [Claves-Elaboro-Cot].Nombre, 
        EntradaRegistroCot.ServicioEn 
         from MetAsInf inner join [Contactos-Clientes-Usuarios] on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
         inner join EntradaRegistroCot on [Contactos-Clientes-Usuarios].ClaveContacto = EntradaRegistroCot.ClaveContacto
         inner join Condiciones_p_cotizar on EntradaRegistroCot.[Elaboró Cot] = Condiciones_p_cotizar.Numcond 
         inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot]= EntradaRegistroCot.[Elaboró Cot] where EntradaRegistroCot.Numcot =" & txtCotizacion.Text
        comando2018.CommandText = R
        lector2018 = comando2018.ExecuteReader
        lector2018.Read()
        If ((lector2018(0) Is DBNull.Value) OrElse (lector2018(0) Is Nothing)) Then
            txtClaveE.Text = "-"
        Else
            txtClaveE.Text = lector2018(0)
        End If
        If ((lector2018(1) Is DBNull.Value) OrElse (lector2018(1) Is Nothing)) Then
            txtNombreEmpresa.Text = "-"
        Else
            txtNombreEmpresa.Text = lector2018(1)
        End If

        If ((lector2018(2) Is DBNull.Value) OrElse (lector2018(2) Is Nothing)) Then
            txtDomicilio.Text = "-"
        Else
            txtDomicilio.Text = lector2018(1)
        End If
        If ((lector2018(3) Is DBNull.Value) OrElse (lector2018(3) Is Nothing)) Then
            txtCiudad.Text = "-"
        Else
            txtCiudad.Text = lector2018(3) = lector2018(3)
        End If
        If ((lector2018(4) Is DBNull.Value) OrElse (lector2018(4) Is Nothing)) Then
            txtEstado.Text = "-"
        Else
            txtEstado.Text = lector2018(4)
        End If
        If ((lector2018(5) Is DBNull.Value) OrElse (lector2018(5) Is Nothing)) Then
            txtCveContacto.Text = "-"
        Else
            txtCveContacto.Text = lector2018(5)
        End If
        If ((lector2018(6) Is DBNull.Value) OrElse (lector2018(6) Is Nothing)) Then
            txtNombreC.Text = "-"
        Else
            txtNombreC.Text = lector2018(6)
        End If
        If ((lector2018(7) Is DBNull.Value) OrElse (lector2018(7) Is Nothing)) Then
            txtTelefono.Text = "-"
        Else
            txtTelefono.Text = lector2018(7)
        End If
        If ((lector2018(8) Is DBNull.Value) OrElse (lector2018(8) Is Nothing)) Then
            txtExt.Text = "-"
        Else
            txtExt.Text = lector2018(8)
        End If
        If ((lector2018(9) Is DBNull.Value) OrElse (lector2018(9) Is Nothing)) Then
            TextCorreo.Text = "-"
        Else
            TextCorreo.Text = lector2018(9)
        End If
        If ((lector2018(12) Is DBNull.Value) OrElse (lector2018(12) Is Nothing)) Then
            txtReferencia.Text = "-"
        Else
            txtReferencia.Text = lector2018(12)
        End If
        If ((lector2018(13) Is DBNull.Value) OrElse (lector2018(13) Is Nothing)) Then
            txtObservaciones.Text = "-"
        Else
            txtObservaciones.Text = lector2018(13)
        End If
        If ((lector2018(14) Is DBNull.Value) OrElse (lector2018(14) Is Nothing)) Then
            txtNumCond.Text = "-"
        Else
            txtNumCond.Text = lector2018(14)
        End If
        If ((lector2018(19) Is DBNull.Value) OrElse (lector2018(19) Is Nothing)) Then
            txtCotizo.Text = "-"
        Else
            txtCotizo.Text = lector2018(19)
        End If
        If ((lector2018(20) Is DBNull.Value) OrElse (lector2018(20) Is Nothing)) Then
            cboServicio.Text = "-"
        Else
            cboServicio.Text = lector2018(20)
        End If
        lector2018.Close()
        R = "select *from [1Cotizar] where Numcot =" & Val(txtCotizacion.Text)

        comando2018.CommandText = R
        lector2018 = comando2018.ExecuteReader
        While lector2018.Read()
            DGCotizaciones.Rows.Add(False, lector2018(2), lector2018(3), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(10), lector2018(9), lector2018(11))
        End While
        lector2018.Close()

        'clase.Open()
        Try
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select Email from [Contactos-Clientes-Usuarios] where Email is not null"

            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            'DataArticulos.DataSource = dt2
            dgInicioNombres.DataSource = dt2

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        End Try
        da.Dispose()
        'clase.Close()
        conexion2018.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MetodoMetasInf2019()
        ' fechaActual = DTPDesde.Value.Date.Day & "-" & DTPDesde.Value.Date.Month & "-" & DTPDesde.Value.Date.Year
        '' fechaActual = DTPDesde.Value
        fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        'Dim fecha2, fecha3 As String
        'fecha3 = DTPDesde.Value
        'fecha2 = DTPDesde.Value.Date.ToString
        MsgBox(fechaActual)
        ' MsgBox(fecha2)
        'MsgBox(fecha3)
        Dim maximo As Integer
        Dim R As String

        ''Aqui va el insert de entrada Registro cot
        If txtCotizacion19.Text.Trim.Equals("") Then
            ''Es nueva cotizacion hasta el ultimo registro (select(MAX))
            Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            maximo = lector(0)
            ' MsgBox("Ultimo registro: " & maximo + 1)
            lector.Close()
            R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
                CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & maximo + 1 & ",'" & txtNombreEmpresa.Text & "',
                " & Val(txtCveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(txtNumCond.Text) & ",
                '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & Val(txtTipoCliente.Text) & "," & Val(txtClaveE.Text) & ",
                " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            'MsgBox("")
            ''Finalizo insert de EntradaRegistroCot

            'Codigo para guardar en 1Cotizar----------------------------------------------------
            For i = 0 To DGCotizaciones.Rows.Count - 2
                R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & maximo + 1 & "," & Val(i + 1) & ",'" & DGCotizaciones.Item(2, i).Value & "',
                    '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
                    '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "','
                    " & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
                ''MsgBox(R)
                comando.CommandText = R
                comando.ExecuteNonQuery()
            Next i
            MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
            'lector2019.Close()
        Else
            Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            lector.Close()

            ''Se hace update a una cot apartada, ya existente (UPDATE)
            R = "update EntradaRegistroCot set NumCot='" & Val(txtCotizacion19.Text) & "', Cliente = '" & txtNombreEmpresa.Text & "', 
                ClaveContacto='" & Val(txtCveContacto.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & txtReferencia.Text & "', 
                Numcond='" & Val(txtNumCond.Text) & "', Observaciones='" & txtObservaciones.Text & "', ServicioEn='" & cboServicio.Text & "', 
                TipodeCliente='1', CveEmpresa='" & Val(txtClaveE.Text) & "', [Elaboró Cot]=" & Val(txtCotizo2019.Text) & ", 
                ModoDeContabilizar='" & Val(txtConta.Text) & "' WHERE NumCot='" & Val(txtCotizacion19.Text) & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            ' MsgBox("Cotizacion Actualizada")

            For i = 0 To DGCotizaciones.Rows.Count - 2
                R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & Val(txtCotizacion19.Text) & "," & Val(i + 1) & ",'" & DGCotizaciones.Item(2, i).Value & "',
                    '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
                    '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "','
                    " & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
                comando.CommandText = R
                comando.ExecuteNonQuery()
                'MsgBox("Partida " & i + 1 & "insertada")
            Next i
            MsgBox("Cotización actualizada y nuevas partidas agregadas, verifica registros en ACCESS", MsgBoxStyle.Information)
            conexion2019.Close()
        End If
        FrmCotizacion2018.txtClave.Text = ""
        FrmCotizacion2018.txtNombreE.Text = ""
        FrmCotizacion2018.DGCotizaciones.DataSource = Nothing
        FrmCotizacion2018.DGEmpresas.DataSource = Nothing
        Me.Dispose()
    End Sub
    Private Sub txtCorreo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreo.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    MetodoMetasInf2018()
                    comando2018 = conexion2018.CreateCommand
                    Dim R As String
                    R = " select distinct MetAsInf.Clavempresa, MetAsInf.Compania, MetAsInf.DomicilioConsig, MetAsInf.CiudadConsig, MetAsInf.EdoConsig,
                     [Contactos-Clientes-Usuarios].ClaveContacto, [Contactos-Clientes-Usuarios].Nombre, [Contactos-Clientes-Usuarios].Tel,
                     [Contactos-Clientes-Usuarios].Ext, [Contactos-Clientes-Usuarios].Email
                     from [Contactos-Clientes-Usuarios] inner join MetAsInf on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
                     where [Contactos-Clientes-Usuarios].Email ='" & txtCorreo.Text & "'"
                    comando2018.CommandText = R
                    lector2018 = comando2018.ExecuteReader
                    lector2018.Read()
                    If ((lector2018(0) Is DBNull.Value) OrElse (lector2018(0) Is Nothing)) Then
                        txtClaveE.Text = "-"
                    Else
                        txtClaveE.Text = lector2018(0)
                    End If
                    If ((lector2018(1) Is DBNull.Value) OrElse (lector2018(1) Is Nothing)) Then
                        txtNombreEmpresa.Text = "-"
                    Else
                        txtNombreEmpresa.Text = lector2018(1)
                    End If

                    If ((lector2018(2) Is DBNull.Value) OrElse (lector2018(2) Is Nothing)) Then
                        txtDomicilio.Text = "-"
                    Else
                        txtDomicilio.Text = lector2018(2)
                    End If
                    If ((lector2018(3) Is DBNull.Value) OrElse (lector2018(3) Is Nothing)) Then
                        txtCiudad.Text = "-"
                    Else
                        txtCiudad.Text = lector2018(3)
                    End If
                    If ((lector2018(4) Is DBNull.Value) OrElse (lector2018(4) Is Nothing)) Then
                        txtEstado.Text = "-"
                    Else
                        txtEstado.Text = lector2018(4)
                    End If
                    If ((lector2018(5) Is DBNull.Value) OrElse (lector2018(5) Is Nothing)) Then
                        txtCveContacto.Text = "-"
                    Else
                        txtCveContacto.Text = lector2018(5)
                    End If
                    If ((lector2018(6) Is DBNull.Value) OrElse (lector2018(6) Is Nothing)) Then
                        txtNombreC.Text = "-"
                    Else
                        txtNombreC.Text = lector2018(6)
                    End If
                    If ((lector2018(7) Is DBNull.Value) OrElse (lector2018(7) Is Nothing)) Then
                        txtTelefono.Text = "-"
                    Else
                        txtTelefono.Text = lector2018(7)
                    End If
                    If ((lector2018(8) Is DBNull.Value) OrElse (lector2018(8) Is Nothing)) Then
                        txtExt.Text = "-"
                    Else
                        txtExt.Text = lector2018(8)
                    End If
                    If ((lector2018(9) Is DBNull.Value) OrElse (lector2018(9) Is Nothing)) Then
                        TextCorreo.Text = "-"
                    Else
                        TextCorreo.Text = lector2018(9)
                    End If
                    lector2018.Close()
                    conexion2018.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "El correo que ingreso no existe")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs) Handles txtEliminar.Click
        For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = DGCotizaciones.Rows(i).Cells(0).Value
            If delete = True Then
                Dim row As DataGridViewRow
                row = DGCotizaciones.Rows(i)
                DGCotizaciones.Rows.Remove(row)
            End If
        Next
    End Sub

    'Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged
    '    MetodoMetasInf2018()
    '    conexion2018.Open()
    '    Dim R As String
    '    R = "select Email from [Contactos-Clientes-Usuarios] where Email is not null and Email like '" & txtCorreo.Text & "%'"
    '    Dim comando As New SqlCommand(R, conexion2018)
    '    comando.CommandType = CommandType.Text
    '    Dim da As New SqlDataAdapter(comando)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    dgInicioNombres.DataSource = dt
    '    da.Dispose()
    '    conexion2018.Close()
    '    txtCorreo.AutoCompleteCustomSource.Add(dgInicioNombres.SelectedCells.Item(0).Value)
    'End Sub
End Class