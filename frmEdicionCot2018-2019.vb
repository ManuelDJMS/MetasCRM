Imports System.Data.SqlClient
Public Class frmEdicionCot2018_2019
    Dim bandera As Boolean
    Dim dt2 As New DataTable
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter

    Private Sub frmEdicionCot2018_2019_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),
            isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
            isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'), isnull(EntradaRegistroCot.Numcot,'-'), EntradaRegistroCot.Fecha,
            isnull(EntradaRegistroCot.Referencia,'-'), isnull(EntradaRegistroCot.Observaciones,'-'), isnull(EntradaRegistroCot.Numcond,'-'), isnull(Condiciones_p_cotizar.donde,'-'),
            isnull(Condiciones_p_cotizar.Precios,'-'), isnull(Condiciones_p_cotizar.tentrega,'-'), isnull(Condiciones_p_cotizar.modalidad,'-'), isnull([Claves-Elaboro-Cot].Nombre,'-'), 
            isnull(EntradaRegistroCot.ServicioEn,'-') from MetAsInf inner join [Contactos-Clientes-Usuarios] on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
            inner join EntradaRegistroCot on [Contactos-Clientes-Usuarios].ClaveContacto = EntradaRegistroCot.ClaveContacto
            inner join Condiciones_p_cotizar on EntradaRegistroCot.[Elaboró Cot] = Condiciones_p_cotizar.Numcond 
            inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot]= EntradaRegistroCot.[Elaboró Cot] where EntradaRegistroCot.Numcot =" & txtCotizacion.Text
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            lector2018.Read()
            txtClaveE.Text = lector2018(0)
            txtNombreEmpresa.Text = lector2018(1)
            txtDomicilio.Text = lector2018(2)
            txtCiudad.Text = lector2018(3)
            txtEstado.Text = lector2018(4)
            txtCveContacto.Text = lector2018(5)
            txtNombreC.Text = lector2018(6)
            txtTelefono.Text = lector2018(7)
            txtExt.Text = lector2018(8)
            TextCorreo.Text = lector2018(9)
            txtReferencia.Text = lector2018(12)
            txtObservaciones.Text = lector2018(13)
            txtNumCond.Text = lector2018(14)
            txtCotizo.Text = lector2018(19)
            cboServicio.Text = lector2018(20)
            lector2018.Close()
            R = "select *from [1Cotizar] where Numcot =" & Val(txtCotizacion.Text)
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, lector2018(2), lector2018(3), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(10), lector2018(9), lector2018(11))
            End While
            lector2018.Close()
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select Email from [Contactos-Clientes-Usuarios] where Email is not null"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            dgInicioNombres.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmEdicionCot2018-2019", "Error al cargar el formulario", Err.Number, cadena)
        End Try
        da.Dispose()
        conexion2018.Close()
    End Sub
    Private Sub txtCorreo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreo.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    MetodoMetasInf2018()
                    comando2018 = conexion2018.CreateCommand
                    Dim R As String
                    R = "select distinct isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),
                         isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
                         isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-')
                         from [Contactos-Clientes-Usuarios] inner join MetAsInf on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
                         where [Contactos-Clientes-Usuarios].Email ='" & txtCorreo.Text & "'"
                    comando2018.CommandText = R
                    lector2018 = comando2018.ExecuteReader
                    lector2018.Read()
                    txtClaveE.Text = lector2018(0)
                    txtNombreEmpresa.Text = lector2018(1)
                    txtDomicilio.Text = lector2018(2)
                    txtCiudad.Text = lector2018(3)
                    txtEstado.Text = lector2018(4)
                    txtCveContacto.Text = lector2018(5)
                    txtNombreC.Text = lector2018(6)
                    txtTelefono.Text = lector2018(7)
                    txtExt.Text = lector2018(8)
                    TextCorreo.Text = lector2018(9)
                    lector2018.Close()
                    conexion2018.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "El correo que ingreso no existe")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmEdicionCot2018-2019", "Error al presionar enter y buscar el correo", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub btMinimizar_Click(sender As Object, e As EventArgs) Handles btMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        Try
            MetodoMetasInf2019()
            fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
            Dim maximo As Integer
            Dim R As String
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
                'Codigo para guardar en 1Cotizar----------------------------------------------------
                For i = 0 To DGCotizaciones.Rows.Count - 2
                    R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & maximo + 1 & "," & Val(i + 1) & ",'" & DGCotizaciones.Item(2, i).Value & "',
                    '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
                    '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "',
                    '" & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                Next i
                MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
            Else
                Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
                Dim lector As SqlDataReader
                lector = comando.ExecuteReader
                lector.Read()
                lector.Close()
                R = "update EntradaRegistroCot set NumCot='" & Val(txtCotizacion19.Text) & "', Cliente = '" & txtNombreEmpresa.Text & "', 
                ClaveContacto='" & Val(txtCveContacto.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & txtReferencia.Text & "', 
                Numcond='" & Val(txtNumCond.Text) & "', Observaciones='" & txtObservaciones.Text & "', ServicioEn='" & cboServicio.Text & "', 
                TipodeCliente='1', CveEmpresa='" & Val(txtClaveE.Text) & "', [Elaboró Cot]=" & Val(txtCotizo2019.Text) & ", 
                ModoDeContabilizar='" & Val(txtConta.Text) & "' WHERE NumCot='" & Val(txtCotizacion19.Text) & "'"
                comando.CommandText = R
                comando.ExecuteNonQuery()
                For i = 0 To DGCotizaciones.Rows.Count - 2
                    R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & Val(txtCotizacion19.Text) & "," & Val(i + 1) & ",'" & DGCotizaciones.Item(2, i).Value & "',
                    '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
                    '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "',
                    '" & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                Next i
                MsgBox("Cotización actualizada y nuevas partidas agregadas, verifica registros en ACCESS", MsgBoxStyle.Information)
                conexion2019.Close()
            End If
            FrmCotizacion2018.txtClave.Text = ""
            FrmCotizacion2018.txtNombreE.Text = ""
            FrmCotizacion2018.DGCotizaciones.DataSource = Nothing
            FrmCotizacion2018.DGEmpresas.DataSource = Nothing
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmEdicionCot2018-2019", "Error al momento de guardar", Err.Number, cadena)
        End Try
    End Sub
End Class