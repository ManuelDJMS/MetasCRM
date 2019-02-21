Imports System.Data.SqlClient
Public Class FrmFoliosDelAnioAnterior
    Dim tiempo As Integer
    Dim ultimo As String
    Private Sub FrmFoliosDelAnioAnterior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1200
        tiempo = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 1
        txtUltimoRegistro.Text = actualizarUltimoRegistro()
        actualizarMagnitud()
    End Sub
    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        ''Modulo para insertar en Folios 2019-------------
        MetodoMetasInf2019()
        'Try
        Dim fechaActual As Date
        Dim fechaRec As Date
        Dim maximo As Integer
        Dim R As String
        ''fechaRec = DTPRecepcion.Value.Date
        'fechaRec = Convert.ToDateTime(DTPRecepcion.Value.Year.ToString + "-" + DTPRecepcion.Value.Month.ToString + "-" + DTPRecepcion.Value.Day.ToString)
        fechaRec = DTPRecepcion.Value.ToString("yyyy/MM/dd")
        fechaActual = DTP.Value.Date
        'If txtFolio.Text.Trim.Equals("") Then
        Dim comando As New SqlCommand("select MAX(Numcot) from [INFORMES-SERVICIOS]", conexion2019)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        maximo = lector(0)
        lector.Close()
        'Codigo para guardar en InformesServicios----------------------------------------------------56
        For i = 0 To DGConsulta.Rows.Count - 2
            R = "insert into [INFORMES-SERVICIOS] ([Folio], [MAGNITUD], [INFORME], [Facturado], [ClavecontactoConsign], [Empresa], [Clavecontacto]
                  , [Usuario], [ClavecontactoUsuario], [FECHARECEP], [ServCatalogo1], [ServCatalogo2], [ServiciosAdicionales]
                  , [PUCalib], [PULab], [Pu-Facturado], [TIPO], [ALCANCE], [MARCA], [MODELO], [Serie], [ID], [Accesorios], [PUNTOS], [Patron1]
                  , [Patron2], [Patron3], [NumFuncionesCalibradas], [Etiquetas], [Hacer-etiq], [DatosdelInforme], [Observaciones], [CALIBRO]
                  , [NumEmisiones], [NumCot], [Status], [CveOperador], [REALIZO-MEDICION], [EmpresaEmision], [DirCalleEmision], [DirColEmision]
                  , [DirCiudadEmision], [DirEdoProvEmision], [DirPaisEmision], [DirCPEmision], [Sv1Ajuste], [Sv3Matto], [Sv5COM02], [Sv6IntervaloRe]
                  , [Sv7Curva], [Sv8Idioma], [Sv9Calendar], [SVAD10]) values(" & (DGConsulta.Item(1, i).Value) & "
                        ,'" & (DGConsulta.Item(2, i).Value) & "','" & DGConsulta.Item(3, i).Value & "'," & Val(DGConsulta.Item(4, i).Value) & "
                        ,'" & (DGConsulta.Item(5, i).Value) & "','" & DGConsulta.Item(6, i).Value & "','" & (DGConsulta.Item(7, i).Value) & "'
                        ,'" & DGConsulta.Item(8, i).Value & "'," & Val(DGConsulta.Item(9, i).Value) & ",CONVERT (date,'" & fechaRec & "')
                        ,'" & (DGConsulta.Item(11, i).Value) & "','" & (DGConsulta.Item(12, i).Value) & "'
                        ,'" & (DGConsulta.Item(13, i).Value) & "','" & (DGConsulta.Item(14, i).Value) & "'
                        ," & Val(DGConsulta.Item(15, i).Value) & "," & Val(DGConsulta.Item(16, i).Value) & "
                        ,'" & DGConsulta.Item(17, i).Value & "','" & (DGConsulta.Item(18, i).Value) & "','" & (DGConsulta.Item(19, i).Value) & "'
                        ,'" & (DGConsulta.Item(20, i).Value) & "','" & (DGConsulta.Item(21, i).Value) & "','" & (DGConsulta.Item(22, i).Value) & "'
                        ,'" & (DGConsulta.Item(23, i).Value) & "','" & (DGConsulta.Item(24, i).Value) & "','" & (DGConsulta.Item(25, i).Value) & "'
                        ,'" & (DGConsulta.Item(26, i).Value) & "','" & (DGConsulta.Item(27, i).Value) & "','" & (DGConsulta.Item(28, i).Value) & "'
                        ," & Val(DGConsulta.Item(29, i).Value) & ",'" & (DGConsulta.Item(30, i).Value) & "'," & Val(DGConsulta.Item(31, i).Value) & "
                        ,'" & (DGConsulta.Item(32, i).Value) & "','" & (DGConsulta.Item(33, i).Value) & "','" & (DGConsulta.Item(34, i).Value) & "'
                        ," & Val(DGConsulta.Item(35, i).Value) & "," & Val(DGConsulta.Item(36, i).Value) & ",'" & (DGConsulta.Item(37, i).Value) & "'
                        ," & Val(DGConsulta.Item(38, i).Value) & ",'" & (DGConsulta.Item(39, i).Value) & "','" & (DGConsulta.Item(40, i).Value) & "'
                        ,'" & (DGConsulta.Item(41, i).Value) & "','" & (DGConsulta.Item(42, i).Value) & "','" & (DGConsulta.Item(43, i).Value) & "'
                        ,'" & (DGConsulta.Item(44, i).Value) & "','" & (DGConsulta.Item(45, i).Value) & "','" & (DGConsulta.Item(46, i).Value) & "'
                        ,'" & DGConsulta.Item(47, i).Value & "'," & Val(DGConsulta.Item(48, i).Value) & "," & Val(DGConsulta.Item(49, i).Value) & "
                        ," & Val(DGConsulta.Item(50, i).Value) & "," & Val(DGConsulta.Item(51, i).Value) & "," & Val(DGConsulta.Item(52, i).Value) & "
                        ," & Val(DGConsulta.Item(53, i).Value) & ")"
            MessageBox.Show(R)
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next i
        MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
        Me.Dispose()
        'Else
        'MsgBox("Ingresa el numero de foliio")
        'End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
        ''------------------------------------------------
    End Sub
    Private Sub btAgregarFila_Click(sender As Object, e As EventArgs) Handles btAgregarFila.Click
        Try
            DGConsulta.Rows.Add(False, DGConsulta.Item(1, 0).Value.ToString(), DGConsulta.Item(2, 0).Value.ToString(), DGConsulta.Item(3, 0).Value.ToString(),
            DGConsulta.Item(4, 0).Value.ToString(), DGConsulta.Item(5, 0).Value.ToString(), DGConsulta.Item(6, 0).Value.ToString(), DGConsulta.Item(7, 0).Value.ToString(),
            DGConsulta.Item(8, 0).Value.ToString(), DGConsulta.Item(9, 0).Value.ToString(), DGConsulta.Item(10, 0).Value.ToString(),
            DGConsulta.Item(11, 0).Value.ToString(), DGConsulta.Item(12, 0).Value.ToString(), DGConsulta.Item(13, 0).Value.ToString(),
            DGConsulta.Item(14, 0).Value.ToString(), DGConsulta.Item(15, 0).Value.ToString(), DGConsulta.Item(16, 0).Value.ToString(),
            DGConsulta.Item(17, 0).Value.ToString(), DGConsulta.Item(18, 0).Value.ToString(), DGConsulta.Item(19, 0).Value.ToString(),
            DGConsulta.Item(20, 0).Value.ToString(), DGConsulta.Item(21, 0).Value.ToString(), DGConsulta.Item(22, 0).Value.ToString(),
            DGConsulta.Item(23, 0).Value.ToString(), DGConsulta.Item(24, 0).Value.ToString(), DGConsulta.Item(25, 0).Value.ToString(),
            DGConsulta.Item(26, 0).Value.ToString(), DGConsulta.Item(27, 0).Value.ToString(), DGConsulta.Item(28, 0).Value.ToString(),
            DGConsulta.Item(29, 0).Value.ToString(), DGConsulta.Item(30, 0).Value.ToString(), DGConsulta.Item(31, 0).Value.ToString(),
            DGConsulta.Item(32, 0).Value.ToString(), DGConsulta.Item(33, 0).Value.ToString(), DGConsulta.Item(34, 0).Value.ToString(),
            DGConsulta.Item(35, 0).Value.ToString(), DGConsulta.Item(36, 0).Value.ToString(), DGConsulta.Item(37, 0).Value.ToString(),
            DGConsulta.Item(38, 0).Value.ToString(), DGConsulta.Item(39, 0).Value.ToString(), DGConsulta.Item(40, 0).Value.ToString(),
            DGConsulta.Item(41, 0).Value.ToString(), DGConsulta.Item(42, 0).Value.ToString(), DGConsulta.Item(43, 0).Value.ToString(),
            DGConsulta.Item(44, 0).Value.ToString(), DGConsulta.Item(45, 0).Value.ToString(), DGConsulta.Item(46, 0).Value.ToString(),
            DGConsulta.Item(47, 0).Value.ToString(), DGConsulta.Item(48, 0).Value.ToString(), DGConsulta.Item(49, 0).Value.ToString(),
            DGConsulta.Item(50, 0).Value.ToString(), DGConsulta.Item(51, 0).Value.ToString(), DGConsulta.Item(52, 0).Value.ToString(),
            DGConsulta.Item(53, 0).Value.ToString())
            lbServicios.Text = "Total de Servicios: " + Convert.ToString(DGConsulta.Rows.Count - 1)
        Catch ex As Exception
            MsgBox("No se pueden agregar filas si no hay datos cargados anteriormente")
        End Try

    End Sub
    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        For i As Integer = DGConsulta.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = DGConsulta.Rows(i).Cells(0).Value
            If delete = True Then
                Dim row As DataGridViewRow
                row = DGConsulta.Rows(i)
                DGConsulta.Rows.Remove(row)
            End If
        Next
        lbServicios.Text = "Total de Servicios: " + Convert.ToString(DGConsulta.Rows.Count - 1)
    End Sub

    Private Sub TextFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TextFolio.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    MetodoMetasInf2018()
                    comando2018 = conexion2018.CreateCommand
                    Dim R As String
                    DGConsulta.Rows.Clear()
                    If DGConsulta.Rows.Count < 2 Then
                    Else
                        DGConsulta.Rows.RemoveAt(DGConsulta.CurrentRow.Index)
                    End If
                    R = "select distinct Folio, ClavecontactoConsign, RazonSocial, Compania, RFC, DomicilioConsig, PaisConsig, CiudadConsig, EdoConsig, CPConsig
                        from [INFORMES-SERVICIOS] INNER JOIN MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa
                        where Folio ='" & TextFolio.Text & "'"
                    comando2018.CommandText = R
                    lector2018 = comando2018.ExecuteReader
                    lector2018.Read()
                    If ((lector2018(0) Is DBNull.Value) OrElse (lector2018(0) Is Nothing)) Then
                        TextFolio.Text = "-"
                    Else
                        TextFolio.Text = lector2018(0)
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
                    lector2018.Close()
                    R = "SELECT isnull(Folio,'-'),isnull(ClavecontactoConsign,'-'),isnull(Empresa,'-'),isnull(Clavecontacto,'-'),isnull(Usuario,'-'),isnull(ClavecontactoUsuario,'-'),FECHARECEP,
                        isnull(CveOperador,'-'),isnull(EmpresaEmision,'-'),isnull(DirCalleEmision,'-'),isnull(DirColEmision,'-'),isnull(DirCiudadEmision,'-'),isnull(DirEdoProvEmision,'-'),
                        isnull(DirPaisEmision,'-'),isnull(DirCPEmision,'-') FROM [METASINF-2018].[dbo].[INFORMES-SERVICIOS] where Folio ='" & TextFolio.Text & "'"
                    comando2018.CommandText = R
                    lector2018 = comando2018.ExecuteReader
                    While lector2018.Read()
                        DGConsulta.Rows.Add(False, lector2018(0), "-", "-", "-", lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6),
                        "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", lector2018(7), "-", lector2018(8), lector2018(9), lector2018(10),
                        lector2018(11), lector2018(12), lector2018(13), lector2018(14), "-", "-", "-", "-", "-", "-", "-", "-", "-")
                    End While
                    lector2018.Close()
                    lbServicios.Text = "Total de Servicios: " + Convert.ToString(DGConsulta.Rows.Count - 1)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        DGServicios.Rows.Clear()
        FrmFiltrar.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub DGServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGServicios.CellContentClick
        Dim row As DataGridViewRow = DGServicios.Rows(e.RowIndex)
        Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
        If Convert.ToBoolean(cellSelecion.Value) = False Then
            Try
                Dim R As String
                Dim fecharecep As Date
                fecharecep = DTPRecepcion.Value.Date
                R = "SELECT distinct top 1 isnull(ClavecontactoConsign,'-'),isnull(Empresa,'-'),isnull(Clavecontacto,'-'),isnull(Usuario,'-'),isnull(ClavecontactoUsuario,'-'),
                isnull(CveOperador,'-'),isnull(EmpresaEmision,'-'),isnull(DirCalleEmision,'-'),isnull(DirColEmision,'-') as colonia,isnull(DirCiudadEmision,'-'),isnull(DirEdoProvEmision,'-'),
                isnull(DirPaisEmision,'-'),isnull(DirCPEmision,'-') FROM [METASINF-2019].[dbo].[INFORMES-SERVICIOS] where ClavecontactoConsign =" & DGServicios.SelectedCells.Item(1).Value & " order by colonia desc"
                comando2018.CommandText = R
                lector2018 = comando2018.ExecuteReader
                While lector2018.Read()
                    DGConsulta.Rows.Add(False, 0, "-", "-", 0, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), fecharecep,
                    DGServicios.SelectedCells.Item(7).Value, DGServicios.SelectedCells.Item(8).Value, "-", DGServicios.SelectedCells.Item(9).Value,
                    DGServicios.SelectedCells.Item(10).Value, "-", DGServicios.SelectedCells.Item(2).Value, "-", DGServicios.SelectedCells.Item(3).Value,
                    DGServicios.SelectedCells.Item(4).Value, DGServicios.SelectedCells.Item(5).Value, DGServicios.SelectedCells.Item(6).Value,
                    "-", "-", "-", "-", "-", "-", "-", 0, "-", "-", "-", "-", "-", "-", lector2018(5), "-", lector2018(6),
                    lector2018(7), lector2018(8), lector2018(9), lector2018(10), lector2018(11), lector2018(12), "-", "-", "-", "-", "-", "-", "-", "-", "-")
                End While
                lector2018.Close()
                lbServicios.Text = "Total de Servicios: " + Convert.ToString(DGConsulta.Rows.Count - 1)
            Catch ex As Exception
                MsgBox("No se pueden agregar filas si no hay datos cargados anteriormente")
            End Try
        Else
            row.DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub TextMarca_TextChanged(sender As Object, e As EventArgs) Handles TextMarca.TextChanged
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            DGServicios.Rows.Clear()
            If DGServicios.Rows.Count < 2 Then
            Else
                DGServicios.Rows.RemoveAt(DGServicios.CurrentRow.Index)
            End If
            Dim R As String
            R = "SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [INFORMES-SERVICIOS] where [INFORMES-SERVICIOS].ClavecontactoConsign =" & lbClave.Text &
                "and Marca like '" & TextMarca.Text & "%' and Modelo like'" & TextModelo.Text & "%' and Serie like'" & TextSerie.Text & "%' and ID like'" & TextID.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read
                DGServicios.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(9))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub TextModelo_TextChanged(sender As Object, e As EventArgs) Handles TextModelo.TextChanged
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            DGServicios.Rows.Clear()
            If DGServicios.Rows.Count < 2 Then
            Else
                DGServicios.Rows.RemoveAt(DGServicios.CurrentRow.Index)
            End If
            Dim R As String
            R = "SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [INFORMES-SERVICIOS] where [INFORMES-SERVICIOS].ClavecontactoConsign =" & lbClave.Text &
                "and Marca like '" & TextMarca.Text & "%' and Modelo like'" & TextModelo.Text & "%' and Serie like'" & TextSerie.Text & "%' and ID like'" & TextID.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGServicios.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(9))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(e)
        End Try
    End Sub

    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            DGServicios.Rows.Clear()
            If DGServicios.Rows.Count < 2 Then
            Else
                DGServicios.Rows.RemoveAt(DGServicios.CurrentRow.Index)
            End If
            Dim R As String
            R = "SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [INFORMES-SERVICIOS] where [INFORMES-SERVICIOS].ClavecontactoConsign =" & lbClave.Text &
                "and Marca like '" & TextMarca.Text & "%' and Modelo like'" & TextModelo.Text & "%' and Serie like'" & TextSerie.Text & "%' and ID like'" & TextID.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read
                DGServicios.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(9))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub TextSerie_TextChanged(sender As Object, e As EventArgs) Handles TextSerie.TextChanged
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            DGServicios.Rows.Clear()
            If DGServicios.Rows.Count < 2 Then
            Else
                DGServicios.Rows.RemoveAt(DGServicios.CurrentRow.Index)
            End If
            Dim R As String
            R = "SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [INFORMES-SERVICIOS] where [INFORMES-SERVICIOS].ClavecontactoConsign =" & lbClave.Text &
               "and Marca like '" & TextMarca.Text & "%' and Modelo like'" & TextModelo.Text & "%' and Serie like'" & TextSerie.Text & "%' and ID like'" & TextID.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read
                DGServicios.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(9))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Function actualizarUltimoRegistro()
        MetodoMetasInf2019()
        Dim valor As String
        Dim r As String = "select max(Folio) from [INFORMES-SERVICIOS]"
        Dim comando As New SqlCommand(r, conexion2019)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        valor = lector(0)
        Return valor
        lector.Close()
        conexion2019.Close()
    End Function

    'Function actualizarMagnitud1()
    '    MetodoMetasInf2019()
    '    Dim mag As String
    '    Dim r As String = "select max(Folio) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAAF-PV'"
    '    Dim comando As New SqlCommand(r, conexion2019)
    '    Dim lector As SqlDataReader
    '    lector = comando.ExecuteReader
    '    lector.Read()
    '    mag = lector(0)
    '    lector.Close()
    'End Function

    Sub actualizarMagnitud()

        Try
            MetodoMetasInf2019()
            Dim r As String
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAAF-PV'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label9.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MABF-TC'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label12.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MACF-HU'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label14.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MACF-TC'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label15.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MADC-EL'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label18.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MADC-TF'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label21.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MADEF-EL'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label23.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MADF-TF'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label30.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAEF-MA'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label32.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAFF-VO'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label34.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAGC-AC'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label37.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAGC-TF'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label40.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAGF-AC'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label43.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAGF-TF'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label46.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAIF-TR'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label55.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAJC-DE'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label57.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAJC-MA'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label59.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAJF-DE'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label61.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAJF-MA'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label63.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKC-HU'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label65.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKC-ME'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label67.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKC-PV'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label69.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKC-TC'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label47.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKF-HU'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label71.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKF-ME'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label73.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKF-PV'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label75.Text = lector2019(0)
            lector2019.Close()
            ''------------------------------------------------------------------------
            comando2019 = conexion2019.CreateCommand
            r = "select max(INFORME) from [INFORMES-SERVICIOS] where MAGNITUD = 'MAKF-TC'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Label77.Text = lector2019(0)
            lector2019.Close()
            conexion2019.Close()
        Catch ex As Exception
            MsgBox("Cambio")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmFiltarCampo.Show()
    End Sub

    Private Sub DGCotizaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizaciones.CellContentClick
        Dim row As DataGridViewRow = DGCotizaciones.Rows(e.RowIndex)
        Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
        If Convert.ToBoolean(cellSelecion.Value) = False Then
            Try
                Dim R As String
                Dim fecharecep As Date
                fecharecep = DTPRecepcion.Value.Date
                R = "SELECT distinct top 1 isnull(ClavecontactoConsign,'-'),isnull(Empresa,'-'),isnull(Clavecontacto,'-'),isnull(Usuario,'-'),isnull(ClavecontactoUsuario,'-'),
                isnull(CveOperador,'-'),isnull(EmpresaEmision,'-'),isnull(DirCalleEmision,'-'),isnull(DirColEmision,'-') as colonia,isnull(DirCiudadEmision,'-'),isnull(DirEdoProvEmision,'-'),
                isnull(DirPaisEmision,'-'),isnull(DirCPEmision,'-') FROM [METASINF-2018].[dbo].[INFORMES-SERVICIOS] where ClavecontactoConsign =" & DGCotizaciones.SelectedCells.Item(9).Value & " order by colonia desc"
                comando2018.CommandText = R
                lector2018 = comando2018.ExecuteReader
                While lector2018.Read()
                    DGConsulta.Rows.Add(False, 0, "-", "-", 0, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), fecharecep,
                    "-", "-", "-", "-", "-", "-", "-", 0, "-", "-", "-", "-", "-", "-", lector2018(5), "-", lector2018(6),
                    lector2018(7), lector2018(8), lector2018(9), lector2018(10), lector2018(11), lector2018(12), "-", "-", "-", "-", "-", "-", "-", "-", "-")
                End While
                lector2018.Close()
                lbServicios.Text = "Total de Servicios: " + Convert.ToString(DGConsulta.Rows.Count - 1)
            Catch ex As Exception
                MsgBox("No se pueden agregar filas si no hay datos cargados anteriormente")
            End Try
        Else
            row.DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        actualizarMagnitud()
    End Sub
End Class