﻿Imports System.Data.SqlClient
Public Class frmCotizacionPorArticulo
    Dim bandera As Boolean
    Dim dt2 As New DataTable
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter

    Private Sub frmEdicionCot2018_2019_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasInf2018()
        Try
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select top 1 isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'),  isnull(MetAsInf.DomicilioConsig,'-'), isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),
                isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
                isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'), isnull(EntradaRegistroCot.Numcond,'-'),
                isnull(EntradaRegistroCot.Referencia,'-'), isnull(EntradaRegistroCot.ServicioEn,'-'), isnull([Claves-Elaboro-Cot].Nombre,'-'), isnull(EntradaRegistroCot.Observaciones) 
                From MetAsInf inner Join [Contactos-Clientes-Usuarios] On MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
                inner Join EntradaRegistroCot on [Contactos-Clientes-Usuarios].ClaveContacto = EntradaRegistroCot.ClaveContacto 
                inner join Condiciones_p_cotizar on EntradaRegistroCot.[Elaboró Cot] = Condiciones_p_cotizar.Numcond 
                inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot]= EntradaRegistroCot.[Elaboró Cot]
                where MetAsInf.Clavempresa =" & empresa & " order by EntradaRegistroCot.Numcot desc"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            lector2018.Read()
            txtClaveE.Text = lector2018(0)
            txtNombreEmpresa.Text = lector2018(1)
            lblDomicilio.Text = lector2018(2)
            lblCiudad.Text = lector2018(3)
            lblEstado.Text = lector2018(4)
            lblClave.Text = lector2018(5)
            lblContacto.Text = lector2018(6)
            lblTelefono.Text = lector2018(7)
            lblExt.Text = lector2018(8)
            lblCorreo.Text = lector2018(9)
            lblNumCond.Text = lector2018(10)
            txtReferencia.Text = lector2018(11)
            cboServicio.Text = lector2018(12)
            txtCotizo.Text = lector2018(13)
            txtObservaciones.Text = lector2018(14)
            lector2018.Close()
            ''------------------------------------
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8))
            End While
            lector2018.Close()
            lbPartidas.Text = "Total de Partidas: " + Convert.ToString(DGCotizaciones.Rows.Count - 1)
            'clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmCotizacionPorArticulo", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    'Private Sub txtEliminar_Click(sender As Object, e As EventArgs)
    '    For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
    '        Dim delete As Boolean
    '        delete = DGCotizaciones.Rows(i).Cells(0).Value
    '        If delete = True Then
    '            Dim row As DataGridViewRow
    '            row = DGCotizaciones.Rows(i)
    '            DGCotizaciones.Rows.Remove(row)
    '        End If
    '    Next
    '    lbPartidas.Text = "Total de Partidas: " + Convert.ToString(DGCotizaciones.Rows.Count - 1)
    'End Sub
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
                        lblDomicilio.Text = "-"
                    Else
                        lblDomicilio.Text = lector2018(2)
                    End If
                    If ((lector2018(3) Is DBNull.Value) OrElse (lector2018(3) Is Nothing)) Then
                        lblCiudad.Text = "-"
                    Else
                        lblCiudad.Text = lector2018(3)
                    End If
                    If ((lector2018(4) Is DBNull.Value) OrElse (lector2018(4) Is Nothing)) Then
                        lblEstado.Text = "-"
                    Else
                        lblEstado.Text = lector2018(4)
                    End If
                    If ((lector2018(5) Is DBNull.Value) OrElse (lector2018(5) Is Nothing)) Then
                        lblClave.Text = "-"
                    Else
                        lblClave.Text = lector2018(5)
                    End If
                    If ((lector2018(6) Is DBNull.Value) OrElse (lector2018(6) Is Nothing)) Then
                        lblContacto.Text = "-"
                    Else
                        lblContacto.Text = lector2018(6)
                    End If
                    If ((lector2018(7) Is DBNull.Value) OrElse (lector2018(7) Is Nothing)) Then
                        lblTelefono.Text = "-"
                    Else
                        lblTelefono.Text = lector2018(7)
                    End If
                    If ((lector2018(8) Is DBNull.Value) OrElse (lector2018(8) Is Nothing)) Then
                        lblExt.Text = "-"
                    Else
                        lblExt.Text = lector2018(8)
                    End If
                    If ((lector2018(9) Is DBNull.Value) OrElse (lector2018(9) Is Nothing)) Then
                        lblCorreo.Text = "-"
                    Else
                        lblCorreo.Text = lector2018(9)
                    End If
                    lector2018.Close()

            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmCotizacionPorArticulo", "Error al presionar enter y buscar el correo", Err.Number, cadena)
        End Try
    End Sub

    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        'Dim clase As New SqlConnection(conexionprueba)
        'ConexionLocal()

        Try
            DGCotizaciones.Rows.Clear()
            MetodoMetasInf2018()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa & "and Marca like '" & txtMarca.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8))
            End While
            lector2018.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmCotizacionPorArticulo", "Error al buscar marca", Err.Number, cadena)

        End Try
        da.Dispose()
        'cla
    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
        Try
            DGCotizaciones.Rows.Clear()
            MetodoMetasInf2018()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa & "and Modelo like '" & txtModelo.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8))
            End While
            lector2018.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmCotizacionPorArticulo", "Error al buscar modelo", Err.Number, cadena)
        End Try
        da.Dispose()
        'clase.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Me.Dispose()
    'End Sub
    'Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
    '    Me.Dispose()
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim seleccionado As Boolean
            seleccionado = DGCotizaciones.Rows(i).Cells(0).Value
            If seleccionado = True Then
                DGCarrito.Rows.Add(DGCotizaciones.Rows(i).Cells(1).Value, DGCotizaciones.Rows(i).Cells(2).Value, DGCotizaciones.Rows(i).Cells(3).Value, DGCotizaciones.Rows(i).Cells(4).Value, DGCotizaciones.Rows(i).Cells(5).Value, DGCotizaciones.Rows(i).Cells(6).Value, DGCotizaciones.Rows(i).Cells(7).Value, DGCotizaciones.Rows(i).Cells(8).Value, DGCotizaciones.Rows(i).Cells(9).Value)
            End If
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmCotizacion2018.PanelFiltrado.Enabled = True
        FrmCotizacion2018.lblCot.Visible = True
        FrmCotizacion2018.DGCotizaciones.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub btMinimizar_Click(sender As Object, e As EventArgs) Handles btMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        Try
            If DGCarrito.RowCount > 1 Then
                MetodoMetasInf2019()
                'fechaActual = DTPDesde.Value.Date.Year & "-" & DTPDesde.Value.Date.Day & "-" & DTPDesde.Value.Date.Month
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
                " & Val(lblClave.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(lblNumCond.Text) & ",
                '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & Val(txtTipoCliente.Text) & "," & Val(txtClaveE.Text) & ",
                " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                    'MsgBox("")
                    ''Finalizo insert de EntradaRegistroCot

                    'Codigo para guardar en 1Cotizar----------------------------------------------------
                    For i = 0 To DGCarrito.Rows.Count - 2
                        R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & maximo + 1 & "," & Val(i + 1) & ",'" & DGCarrito.Item(1, i).Value & "',
                    '" & "-" & "'," & Val(DGCarrito.Item(2, i).Value) & ",'" & DGCarrito.Item(3, i).Value & "',
                    '" & DGCarrito.Item(4, i).Value & "','" & DGCarrito.Item(5, i).Value & "','" & DGCarrito.Item(7, i).Value & "',
                    '" & DGCarrito.Item(6, i).Value & "'," & Val(DGCarrito.Item(9, i).Value) & "," & "0" & ")"
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
                ClaveContacto='" & Val(lblClave.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & txtReferencia.Text & "', 
                Numcond='" & Val(lblNumCond.Text) & "', Observaciones='" & txtObservaciones.Text & "', ServicioEn='" & cboServicio.Text & "', 
                TipodeCliente='1', CveEmpresa='" & Val(txtClaveE.Text) & "', [Elaboró Cot]=" & Val(txtCotizo2019.Text) & ", 
                ModoDeContabilizar='" & Val(txtConta.Text) & "' WHERE NumCot='" & Val(txtCotizacion19.Text) & "'"
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                    ' MsgBox("Cotizacion Actualizada")

                    For i = 0 To DGCarrito.Rows.Count - 2
                        R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & Val(txtCotizacion19.Text) & "," & Val(i + 1) & ",'" & DGCarrito.Item(1, i).Value & "',
                    '" & "-" & "'," & Val(DGCarrito.Item(2, i).Value) & ",'" & DGCarrito.Item(3, i).Value & "',
                    '" & DGCarrito.Item(4, i).Value & "','" & DGCarrito.Item(5, i).Value & "','" & DGCarrito.Item(7, i).Value & "','
                    " & DGCarrito.Item(6, i).Value & "'," & Val(DGCarrito.Item(9, i).Value) & "," & "0" & ")"
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
                ' FrmCotizacion2018.DGCarrit.DataSource = Nothing
                Me.Dispose()
            Else
                MessageBox.Show("No hay registros por guardar", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmCotizacionPorArticulo", "Error al momento de guardar", Err.Number, cadena)
        End Try
    End Sub
    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        Try
            DGCotizaciones.Rows.Clear()
            MetodoMetasInf2018()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa & "and ID like '" & TextID.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmCotizacionPorArticulo", "Error al buscar ID", Err.Number, cadena)
        End Try
    End Sub


End Class
