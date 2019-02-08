Imports System.Data.SqlClient
Public Class FrmFoliosDelAnioAnterior
    Private Sub FrmFoliosDelAnioAnterior_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        Dim manuel As String
        Try
            Dim pau As String
            Select Case e.KeyData
                Case Keys.Enter
                    MetodoMetasInf2018()
                    comando2018 = conexion2018.CreateCommand
                    Dim R As String
                    R = "select distinct Folio, ClavecontactoConsign, RazonSocial, Compania, RFC, DomicilioConsig, PaisConsig, CiudadConsig, EdoConsig, CPConsig,
                        FECHARECEP from [INFORMES-SERVICIOS] INNER JOIN MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa
                        where Folio ='" & txtFolio.Text & "'"
                    comando2018.CommandText = R
                    lector2018 = comando2018.ExecuteReader
                    lector2018.Read()
                    If ((lector2018(0) Is DBNull.Value) OrElse (lector2018(0) Is Nothing)) Then
                        txtFolio.Text = "-"
                    Else
                        txtFolio.Text = lector2018(0)
                    End If
                    If ((lector2018(1) Is DBNull.Value) OrElse (lector2018(1) Is Nothing)) Then
                        lbClave.Text = "-"
                    Else
                        lbClave.Text = lector2018(1)
                    End If
                    If ((lector2018(2) Is DBNull.Value) OrElse (lector2018(2) Is Nothing)) Then
                        lbRazonSocial.Text = "-"
                    Else
                        lbRazonSocial.Text = lector2018(2)
                    End If
                    If ((lector2018(3) Is DBNull.Value) OrElse (lector2018(3) Is Nothing)) Then
                        lbEmpresa.Text = "-"
                    Else
                        lbEmpresa.Text = lector2018(3)
                    End If
                    If ((lector2018(4) Is DBNull.Value) OrElse (lector2018(4) Is Nothing)) Then
                        lbRFC.Text = "-"
                    Else
                        lbRFC.Text = lector2018(4)
                    End If
                    If ((lector2018(5) Is DBNull.Value) OrElse (lector2018(5) Is Nothing)) Then
                        lbDomicilio.Text = "-"
                    Else
                        lbDomicilio.Text = lector2018(5)
                    End If
                    If ((lector2018(6) Is DBNull.Value) OrElse (lector2018(6) Is Nothing)) Then
                        lbPais.Text = "-"
                    Else
                        lbPais.Text = lector2018(6)
                    End If
                    If ((lector2018(7) Is DBNull.Value) OrElse (lector2018(7) Is Nothing)) Then
                        lbCiudad.Text = "-"
                    Else
                        lbCiudad.Text = lector2018(7)
                    End If
                    If ((lector2018(8) Is DBNull.Value) OrElse (lector2018(8) Is Nothing)) Then
                        lbEstado.Text = "-"
                    Else
                        lbEstado.Text = lector2018(8)
                    End If
                    If ((lector2018(9) Is DBNull.Value) OrElse (lector2018(9) Is Nothing)) Then
                        lbCP.Text = "-"
                    Else
                        lbCP.Text = lector2018(9)
                    End If
                    If ((lector2018(10) Is DBNull.Value) OrElse (lector2018(10) Is Nothing)) Then
                        lbfechaRecp.Text = "-"
                    Else
                        lbfechaRecp.Text = lector2018(10)
                    End If
                    lector2018.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        ''Modulo para insertar en Folios 2019-------------
        MetodoMetasInf2019()
        'Try
        'fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        MsgBox(DGConsulta.Item(55, 0).Value)
        Dim maximo As Integer
            Dim R As String

            If txtFolio.Text.Trim.Equals("") Then
                Dim comando As New SqlCommand("select MAX(Numcot) from [INFORMES-SERVICIOS]", conexion2019)
                Dim lector As SqlDataReader
                lector = comando.ExecuteReader
                lector.Read()
                maximo = lector(0)
                lector.Close()
                'Codigo para guardar en InformesServicios----------------------------------------------------56
                For i = 0 To DGConsulta.Rows.Count - 2
                R = "insert into [INFORMES-SERVICIOS] (
                   [Folio]
                  ,[MAGNITUD]
                  ,[INFORME]
                  ,[Facturado]
                  ,[ClavecontactoConsign]
                  ,[Empresa]
                  ,[Clavecontacto]
                  ,[Usuario]
                  ,[ClavecontactoUsuario]
                  ,[FECHARECEP]
                  ,[FECHACALIB]
                  ,[FECHA-EMISION]
                  ,[ServCatalogo1]
                  ,[ServCatalogo2]
                  ,[ServiciosAdicionales]
                  ,[PUCalib]
                  ,[PULab]
                  ,[Pu-Facturado]
                  ,[TIPO]
                  ,[ALCANCE]
                  ,[MARCA]
                  ,[MODELO]
                  ,[Serie]
                  ,[ID]
                  ,[Accesorios]
                  ,[PUNTOS]
                  ,[Patron1]
                  ,[Patron2]
                  ,[Patron3]
                  ,[NumFuncionesCalibradas]
                  ,[Etiquetas]
                  ,[Hacer-etiq]
                  ,[DatosdelInforme]
                  ,[Observaciones]
                  ,[CALIBRO]
                  ,[NumEmisiones]
                  ,[NumCot]
                  ,[Status]
                  ,[CveOperador]
                  ,[REALIZO-MEDICION]
                  ,[EmpresaEmision]
                  ,[DirCalleEmision]
                  ,[DirColEmision]
                  ,[DirCiudadEmision]
                  ,[DirEdoProvEmision]
                  ,[DirPaisEmision]
                  ,[DirCPEmision]
                  ,[Sv1Ajuste]
                  ,[Sv3Matto]
                  ,[Sv5COM02]
                  ,[Sv6IntervaloRe]
                  ,[Sv7Curva]
                  ,[Sv8Idioma]
                  ,[Sv9Calendar]
                  ,[SVAD10]
                  ,[Fecha_Reg]) 
        values (" & Val(DGConsulta.Item(0, i).Value) & ",
                        '" & (DGConsulta.Item(1, i).Value) & "'
                        ,'" & (DGConsulta.Item(2, i).Value) & "'
                        ," & Val(DGConsulta.Item(3, i).Value) & "
                        ," & Val(DGConsulta.Item(4, i).Value) & "
                        ,'" & (DGConsulta.Item(5, i).Value) & "'
                        ," & Val(DGConsulta.Item(6, i).Value) & "
                        ,'" & (DGConsulta.Item(7, i).Value) & "'
                        ," & Val(DGConsulta.Item(8, i).Value) & "
                        ,'" & (DGConsulta.Item(9, i).Value) & "'
                        ,'" & (DGConsulta.Item(10, i).Value) & "'
                        ,'" & (DGConsulta.Item(11, i).Value) & "'
                        ,'" & (DGConsulta.Item(12, i).Value) & "'
                        ,'" & (DGConsulta.Item(13, i).Value) & "'
                        ,'" & (DGConsulta.Item(14, i).Value) & "'
                        ," & Val(DGConsulta.Item(15, i).Value) & "
                        ," & Val(DGConsulta.Item(16, i).Value) & "
                        ," & Val(DGConsulta.Item(17, i).Value) & "
                        ,'" & (DGConsulta.Item(18, i).Value) & "'
                        ,'" & (DGConsulta.Item(19, i).Value) & "'
                        ,'" & (DGConsulta.Item(20, i).Value) & "'
                        ,'" & (DGConsulta.Item(21, i).Value) & "'
                        ,'" & (DGConsulta.Item(22, i).Value) & "'
                        ,'" & (DGConsulta.Item(23, i).Value) & "'
                        ,'" & (DGConsulta.Item(24, i).Value) & "'
                        ,'" & (DGConsulta.Item(25, i).Value) & "
                        ,'" & (DGConsulta.Item(26, i).Value) & "'
                        ,'" & (DGConsulta.Item(27, i).Value) & "'
                        ,'" & (DGConsulta.Item(28, i).Value) & "'
                        ," & Val(DGConsulta.Item(29, i).Value) & "
                        ,'" & (DGConsulta.Item(30, i).Value) & "'
                        ," & Val(DGConsulta.Item(31, i).Value) & "
                        ,'" & (DGConsulta.Item(32, i).Value) & "'
                        ,'" & (DGConsulta.Item(33, i).Value) & "'
                        ,'" & (DGConsulta.Item(34, i).Value) & "'
                        ," & Val(DGConsulta.Item(35, i).Value) & "
                        ," & Val(DGConsulta.Item(36, i).Value) & "
                        ,'" & (DGConsulta.Item(37, i).Value) & "'
                        ," & Val(DGConsulta.Item(38, i).Value) & "
                        ,'" & (DGConsulta.Item(39, i).Value) & "'
                        ,'" & (DGConsulta.Item(40, i).Value) & "'
                        ,'" & (DGConsulta.Item(41, i).Value) & "'
                        ,'" & (DGConsulta.Item(42, i).Value) & "'
                        ,'" & (DGConsulta.Item(43, i).Value) & "'
                        ,'" & (DGConsulta.Item(44, i).Value) & "'
                        ,'" & (DGConsulta.Item(45, i).Value) & "'
                        ,'" & (DGConsulta.Item(46, i).Value) & "'
                        ," & Val(DGConsulta.Item(47, i).Value) & "
                        ," & Val(DGConsulta.Item(48, i).Value) & "
                        ," & Val(DGConsulta.Item(49, i).Value) & "
                        ," & Val(DGConsulta.Item(50, i).Value) & "
                        ," & Val(DGConsulta.Item(51, i).Value) & "
                        ," & Val(DGConsulta.Item(52, i).Value) & "
                        ," & Val(DGConsulta.Item(53, i).Value) & "
                        ,'" & (DGConsulta.Item(54, i).Value) & "'
                        ,'" & (DGConsulta.Item(55, i).Value) & "')"
                Label2.Text = R
                comando.CommandText = R
                    comando.ExecuteNonQuery()
                Next i
                MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Ingresa el numero de folio")
            End If
            'Me.Dispose()
        'Catch ex As Exception
        'sgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
        ''------------------------------------------------
    End Sub

    ''
    ''MetodoMetasInf2019()
    ''   ' fechaActual = DTPDesde.Value.Date.Day & "-" & DTPDesde.Value.Date.Month & "-" & DTPDesde.Value.Date.Year
    ''   '' fechaActual = DTPDesde.Value
    ''   fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
    ''   'Dim fecha2, fecha3 As String
    ''   'fecha3 = DTPDesde.Value
    ''   'fecha2 = DTPDesde.Value.Date.ToString
    ''   MsgBox(fechaActual)
    ''   ' MsgBox(fecha2)
    ''   'MsgBox(fecha3)
    ''   Dim maximo As Integer
    ''   Dim R As String

    ''   ''Aqui va el insert de entrada Registro cot
    ''   If txtCotizacion19.Text.Trim.Equals("") Then
    ''       ''Es nueva cotizacion hasta el ultimo registro (select(MAX))
    ''       Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
    ''       Dim lector As SqlDataReader
    ''       lector = comando.ExecuteReader
    ''       lector.Read()
    ''       maximo = lector(0)
    ''       ' MsgBox("Ultimo registro: " & maximo + 1)
    ''       lector.Close()
    ''       R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
    ''           CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & maximo + 1 & ",'" & txtNombreEmpresa.Text & "',
    ''           " & Val(txtCveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(txtNumCond.Text) & ",
    ''           '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & Val(txtTipoCliente.Text) & "," & Val(txtClaveE.Text) & ",
    ''           " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
    ''       comando.CommandText = R
    ''       comando.ExecuteNonQuery()
    ''       'MsgBox("")
    ''       ''Finalizo insert de EntradaRegistroCot

    ''       'Codigo para guardar en 1Cotizar----------------------------------------------------
    ''       For i = 0 To DGCotizaciones.Rows.Count - 2
    ''           R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
    ''                ID, Punitariocot, Realizado) values (" & maximo + 1 & "," & Val(i + 1) & ",'" & DGCotizaciones.Item(2, i).Value & "',
    ''               '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
    ''               '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "','
    ''               " & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
    ''           ''MsgBox(R)
    ''           comando.CommandText = R
    ''           comando.ExecuteNonQuery()
    ''       Next i
    ''       MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
    ''       'lector2019.Close()
    ''   Else
    ''       Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
    ''       Dim lector As SqlDataReader
    ''       lector = comando.ExecuteReader
    ''       lector.Read()
    ''       lector.Close()

    ''       ''Se hace update a una cot apartada, ya existente (UPDATE)
    ''       R = "update EntradaRegistroCot set NumCot='" & Val(txtCotizacion19.Text) & "', Cliente = '" & txtNombreEmpresa.Text & "', 
    ''           ClaveContacto='" & Val(txtCveContacto.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & txtReferencia.Text & "', 
    ''           Numcond='" & Val(txtNumCond.Text) & "', Observaciones='" & txtObservaciones.Text & "', ServicioEn='" & cboServicio.Text & "', 
    ''           TipodeCliente='1', CveEmpresa='" & Val(txtClaveE.Text) & "', [Elaboró Cot]=" & Val(txtCotizo2019.Text) & ", 
    ''           ModoDeContabilizar='" & Val(txtConta.Text) & "' WHERE NumCot='" & Val(txtCotizacion19.Text) & "'"
    ''       comando.CommandText = R
    ''       comando.ExecuteNonQuery()
    ''       ' MsgBox("Cotizacion Actualizada")

    ''       For i = 0 To DGCotizaciones.Rows.Count - 2
    ''           R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
    ''                ID, Punitariocot, Realizado) values (" & Val(txtCotizacion19.Text) & "," & Val(i + 1) & ",'" & DGCotizaciones.Item(2, i).Value & "',
    ''               '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
    ''               '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "','
    ''               " & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
    ''           comando.CommandText = R
    ''           comando.ExecuteNonQuery()
    ''           'MsgBox("Partida " & i + 1 & "insertada")
    ''       Next i
    ''       MsgBox("Cotización actualizada y nuevas partidas agregadas, verifica registros en ACCESS", MsgBoxStyle.Information)
    ''       conexion2019.Close()
    ''   End If
    ''   FrmCotizacion2018.txtClave.Text = ""
    ''   FrmCotizacion2018.txtNombreE.Text = ""
    ''   FrmCotizacion2018.DGCotizaciones.DataSource = Nothing
    ''   FrmCotizacion2018.DGEmpresas.DataSource = Nothing
    ''   Me.Dispose()


    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
    End Sub
End Class

