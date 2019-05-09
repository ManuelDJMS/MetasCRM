Imports System.Data.SqlClient
Public Class frmEdicionCot2018_2019
    Dim R As String
    Dim subtotal As Decimal
    Dim total As Decimal
    Dim iva As Decimal

    Private Sub frmEdicionCot2018_2019_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        MetodoLIMS()
        DTPHasta.Value.AddDays(30)
        comandoLIMS = conexionLIMS.CreateCommand
            R = "select [SetupCustomerDetails].CustomerId, isnull(Organization,'-'), isnull(concat(FirstName, ' ' , MiddleName, ' ', LastName),'-') as Nombre, 
                isnull(ContAddress1,'-'), isnull(ContCity,'-'), isnull(ContState,'-'), isnull(Phone,'-'), isnull(Email,'-') 
                from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] inner join  
                SetupCustomerAddressDtls on [SetupCustomerDetails].CustomerId=[SetupCustomerAddressDtls].CustomerId
                where [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].CustomerId=" & empresa
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            lectorLIMS.Read()
            txtCveContacto.Text = lectorLIMS(0)
            txtNombreEmpresa.Text = lectorLIMS(1)
            txtNombreC.Text = lectorLIMS(2)
            txtDomicilio.Text = lectorLIMS(3)
            txtCiudad.Text = lectorLIMS(4)
            txtEstado.Text = lectorLIMS(5)
            txtTelefono.Text = lectorLIMS(6)
            TextCorreo.Text = lectorLIMS(7)
            lectorLIMS.Close()
            conexionLIMS.Close()

            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo cuando ------------------------
        comandoMetasCotizador.CommandText = "select * from CuandoCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
            Cbcuando.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from CuandoCondicion where idCuandoCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        Cbcuando.Tag = lectorMetasCotizador(0)
        Cbcuando.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo documentps ------------------------
        comandoMetasCotizador.CommandText = "select * from DocumentosCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            ComboDocCond.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from DocumentosCondicion where idDocumentoCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        ComboDocCond.Tag = lectorMetasCotizador(0)
        ComboDocCond.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo Leyenda ------------------------
        comandoMetasCotizador.CommandText = "select * from LeyendaCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CboLeyenda.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from LeyendaCondicion where idLeyendaCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboLeyenda.Tag = lectorMetasCotizador(0)
        CboLeyenda.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo Lugar ------------------------
        comandoMetasCotizador.CommandText = "select * from LugarCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            cboServicio.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from LugarCondicion where idLugarCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        cboServicio.Tag = lectorMetasCotizador(0)
        cboServicio.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo modalidad ------------------------
        comandoMetasCotizador.CommandText = "select * from ModalidadCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CbModalidad.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from ModalidadCondicion where idModalidadCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CbModalidad.Tag = lectorMetasCotizador(0)
        CbModalidad.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo  modo de contabilizar ------------------------
        comandoMetasCotizador.CommandText = "select * from Modo_de_Contabilizar"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CboContabilizar.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from Modo_de_Contabilizar where idModoCont=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboContabilizar.Tag = lectorMetasCotizador(0)
        CboContabilizar.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        lectorMetasCotizador.Close()
        '-----------------Combo moneda ------------------------
        comandoMetasCotizador.CommandText = "select * from MonedaCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CboMoneda.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from MonedaCondicion where idMonedaCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboMoneda.Tag = lectorMetasCotizador(0)
        CboMoneda.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo Pago------------------------
        comandoMetasCotizador.CommandText = "select * from PagoCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CCondPago.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from PagoCondicion where idPagoCondicion=2"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CCondPago.Tag = lectorMetasCotizador(0)
        CCondPago.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo tiempo ------------------------
        comandoMetasCotizador.CommandText = "select * from TiemposEntregaCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CboTiempo.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from TiemposEntregaCondicion where idTiempoEntregaCondicion=2"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboTiempo.Tag = lectorMetasCotizador(0)
        CboTiempo.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        '-----------------Combo validez ------------------------
        comandoMetasCotizador.CommandText = "select * from ValidezCondicion"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            CboValidez.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = "select * from ValidezCondicion where idValidezCondicion=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboValidez.Tag = lectorMetasCotizador(0)
        CboValidez.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("frmEdicionCot2018-2019", "Error al cargar el formulario", Err.Number, cadena)
        'End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs)
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
<<<<<<< HEAD
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        MetodoMetasCotizador()
        Dim maximo As Integer
        Dim R As String
        Dim comando As New SqlCommand("select MAX(Numcot) from [INFORMES-SERVICIOS]", conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        maximo = lector(0)
        lector.Close()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        fecharecepcion = Convert.ToDateTime(DTPHasta.Text).ToShortDateString
        For Each fila In DGCotizaciones.Rows
            subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
        Next
        iva = (subtotal * 0.16)
        total = subtotal + iva
        R = "insert into Cotizaciones (NumCot,idContacto,Origen,idLugarCondicion,idCuandoCondicion,idModalidadCondicion,idTiempoEntregaCondicion,idPagoCondicion,idLeyendaCondicion,
        idValidezCondicion,idMonedaCondicion,idDocumentoCondicion,idModoCont,Referencia,FechaDesde,FechaHasta,Observaciones,idUsuarioCotizacion,Subtotal,IVA,Total)
             values (" & maximo & "," & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
             Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
             txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "'," & Val(txtCotizo2019.Text) & "," & subtotal & "," & iva & "," & total & ")"
        comandoMetasCotizador.CommandText = R
        comandoMetasCotizador.ExecuteNonQuery()

        For i = 0 To DGCotizaciones.Rows.Count - 2
            R = "insert into DetalleCotizaciones (NumCot,EquipId, PartidaNo,Cantidad, CantidadReal) values (" & maximo & "',
                '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
                '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "',
                '" & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
            comandoMetasCotizador.CommandText = R
            comandoMetasCotizador.ExecuteNonQuery()
        Next i
        ''--------------------------------------------------------------------------------------------------------------------------------

        MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)

            FrmCotizacion2018.txtClave.Text = ""
            FrmCotizacion2018.txtNombreE.Text = ""
            FrmCotizacion2018.DGCotizaciones.DataSource = Nothing
            FrmCotizacion2018.DGEmpresas.DataSource = Nothing
            Me.Dispose()
=======
        '''--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'MetodoMetasCotizador()
        'comandoLIMS = conexionLIMS.CreateCommand
        'fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        'fecharecepcion = Convert.ToDateTime(DTPHasta.Text).ToShortDateString
        'R = "insert into Cotizaciones (idContacto, Origen, idLugarCondicion, idCuandoCondicion, idModalidadCondicion, 
        '    idTiempoEntregaCondicion, idPagoCondicion, idLeyendaCondicion, idValidezCondicion, idMonedaCondicion, idDocumentoCondicion, 
        '    idModoCont, Referencia, FechaDesde, FechaHasta, Observaciones, idUsuarioCotizacion, idLugarDeCalibracion, Subtotal, IVA, Total)
        '     values (" & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
        '     Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
        '     txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "'," & Val(txtCotizo2019.Text) & "," & cbl & ""
        'Try
        '    '----------------------------A partir de aqui se busca en LIMS la empresa....si no se agrega-------------------------------------
        '    Dim R As String
        '    Dim empresa As Integer
        '    '//////////////////Aqui se busca la empresa en lims\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        '    MetodoLIMS()
        '    comandoLIMS = conexionLIMS.CreateCommand
        '    R = "select isnull(CustomerId,'-') from SetupCustomerDetails where KeyFiscal='" & txtNumCond.Text & "' or Organization='" & txtNombreEmpresa.Text & "'"
        '    lectorLIMS = comandoLIMS.ExecuteReader
        '    lectorLIMS.Read()
        '    empresa = lectorLIMS(0)
        '    lectorLIMS.Close()
        '    conexionLIMS.Close()
        '    '/////////////////////////////////////////////////////////////////////////////////
        '    If empresa = "-" Then '------------Decision para guardar o no la empresa------------------------
        '        MetodoLIMS()
        '        R = "select "

        '        fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        '        R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
        '            CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & txtNombreEmpresa.Text & "',
        '            " & Val(txtCveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(txtNumCond.Text) & ",
        '            '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & empresa & "," & Val(txtTelefono.Text) & ",
        '            " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
        '        comandoMetasCotizador.CommandText = R
        '        comandoMetasCotizador.ExecuteNonQuery()
        '        'Codigo para guardar en 1Cotizar----------------------------------------------------
        '        For i = 0 To DGCotizaciones.Rows.Count - 2
        '            R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
        '             ID, Punitariocot, Realizado) values (" & DGCotizaciones.Item(2, i).Value & "',
        '            '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
        '            '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "',
        '            '" & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
        '            comandoMetasCotizador.CommandText = R
        '            comandoMetasCotizador.ExecuteNonQuery()
        '        Next i
        '    End If
        '    '--------------------------------------------------------------------------------------------------------------------------------

        '    MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)

        '    FrmCotizacion2018.txtClave.Text = ""
        '    FrmCotizacion2018.txtNombreE.Text = ""
        '    FrmCotizacion2018.DGCotizaciones.DataSource = Nothing
        '    FrmCotizacion2018.DGEmpresas.DataSource = Nothing
        '    Me.Dispose()
>>>>>>> 2412b40b41190dbb14dd736368c347ee40daad2e
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("frmEdicionCot2018-2019", "Error al momento de guardar", Err.Number, cadena)
        'End Try
<<<<<<< HEAD
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        MsgBox(CbModalidad.Tag.ToString)
=======
        '''--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'MsgBox(CbModalidad.Tag.ToString)
>>>>>>> 2412b40b41190dbb14dd736368c347ee40daad2e
    End Sub

    Private Sub CboValidez_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboValidez.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo validez ------------------------
        comandoMetasCotizador.CommandText = "select * from ValidezCondicion where Descripcion='" & CboValidez.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboValidez.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()

    End Sub

    Private Sub Cbcuando_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcuando.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo cuando ------------------------
        comandoMetasCotizador.CommandText = "select * from CuandoCondicion where Descripcion='" & Cbcuando.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        Cbcuando.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub ComboDocCond_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDocCond.SelectedIndexChanged
        '-----------------Combo documentps ------------------------
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = "select * from DocumentosCondicion where DescripcionDocumento='" & ComboDocCond.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        ComboDocCond.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboLeyenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboLeyenda.SelectedIndexChanged
        '-----------------Combo Leyenda ------------------------
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = "select * from LeyendaCondicion where Descripcion='" & CboLeyenda.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboLeyenda.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo Lugar ------------------------
        comandoMetasCotizador.CommandText = "select * from LugarCondicion where Descripcon='" & cboServicio.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        cboServicio.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbModalidad.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo modalidad ------------------------
        comandoMetasCotizador.CommandText = "select * from ModalidadCondicion where Descripcion='" & CbModalidad.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CbModalidad.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboContabilizar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboContabilizar.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo  modo de contabilizar ------------------------
        comandoMetasCotizador.CommandText = "select * from Modo_de_Contabilizar where Descripcion='" & CboContabilizar.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboContabilizar.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMoneda.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo moneda ------------------------
        comandoMetasCotizador.CommandText = "select * from MonedaCondicion where Descripcion='" & CboMoneda.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboMoneda.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CCondPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CCondPago.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo Pago------------------------
        comandoMetasCotizador.CommandText = "select * from PagoCondicion where Descripcion='" & CCondPago.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CCondPago.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboTiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTiempo.SelectedIndexChanged
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo tiempo ------------------------
        comandoMetasCotizador.CommandText = "select * from TiemposEntregaCondicion where Descripcion='" & CboTiempo.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboTiempo.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

End Class