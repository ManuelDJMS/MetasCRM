Imports System.Data.SqlClient
Public Class FrmCotPorFolio
    Private Sub FrmCotPorFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim R As String
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            R = "select top 1 isnull(Folio,'-'),isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), 
		         isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), 
		         isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
                 isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'),
                 isnull(RFC,'-'), isnull(PaisConsig,'-') 
		         from [INFORMES-SERVICIOS] INNER JOIN MetAsInf on [INFORMES-SERVICIOS].ClaveContactoConsign=MetAsInf.Clavempresa
		         inner join [Contactos-Clientes-Usuarios] on [INFORMES-SERVICIOS].Clavecontacto = [Contactos-Clientes-Usuarios].Clavecontacto
		         where Folio=" & respuestafolio
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            lector2018.Read()
            TextFolio.Text = lector2018(0)
            lbClave.Text = lector2018(1)
            lbEmpresa.Text = lector2018(2)
            lbDomicilio.Text = lector2018(3)
            lbCiudad.Text = lector2018(4)
            lbEstado.Text = lector2018(5)
            lbClaveContacto.Text = lector2018(6)
            lbContacto.Text = lector2018(7)
            lbTelefono.Text = lector2018(8)
            lbExt.Text = lector2018(9)
            lbCorreo.Text = lector2018(10)
            lbRFC.Text = lector2018(11)
            lbPais.Text = lector2018(12)
            txtReferencia.Text = "Confirmación Metrológica No." + Convert.ToString(respuestafolio)
            lector2018.Close()
            '----------------------------Llenar el grid por folio---------------------------------------------
            R = "select isnull(ServCatalogo1,'-'),isnull(Tipo,'-'), isnull(Marca,'-'), isnull(Modelo,'-'), 
                 isnull(ID,'-'), isnull(Puntos,'-'),isnull(PUCalib,'-'),isnull(Alcance,'-'),isnull(Serie,'-'), 
                 isnull(Informe,'-'), FECHACALIB, MAGNITUD, INFORME from [INFORMES-SERVICIOS] where Folio=" & respuestafolio
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            Dim partida As Integer = 1
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, partida, lector2018(0), 1, lector2018(1), lector2018(2), lector2018(3),
                 lector2018(4), (lector2018(5) + " Referencia Certificado " + lector2018(11) + lector2018(12)), lector2018(6), "-", lector2018(7), lector2018(8), lector2018(9), lector2018(10))
                partida = partida + 1
            End While
            lector2018.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
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

    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
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
            lector.Close()
            R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
                CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & maximo + 1 & ",'" & lbEmpresa.Text & "',
                " & Val(lbClaveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(TextNumC.Text) & ",
                '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & Val(txtTipoCliente.Text) & "," & Val(lbClave.Text) & ",
                " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            'Codigo para guardar en 1Cotizar----------------------------------------------------
            For i = 0 To DGCotizaciones.Rows.Count - 2
                MsgBox(DGCotizaciones.Item(7, i).Value)
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
            ''Se hace update a una cot apartada, ya existente (UPDATE)
            R = "update EntradaRegistroCot set NumCot='" & Val(txtCotizacion19.Text) & "', Cliente = '" & lbEmpresa.Text & "', 
                ClaveContacto='" & Val(lbClaveContacto.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & txtReferencia.Text & "', 
                Numcond='" & Val(TextNumC.Text) & "', Observaciones='" & txtObservaciones.Text & "', ServicioEn='" & cboServicio.Text & "', 
                TipodeCliente='1', CveEmpresa='" & Val(lbClaveContacto.Text) & "', [Elaboró Cot]=" & Val(txtCotizo2019.Text) & ", 
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
    End Sub
End Class