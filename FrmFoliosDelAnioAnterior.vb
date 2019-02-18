﻿Imports System.Data.SqlClient
Public Class FrmFoliosDelAnioAnterior
    Private Sub FrmFoliosDelAnioAnterior_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        ''Modulo para insertar en Folios 2019-------------
        MetodoMetasInf2019()
        Try
            Dim fechaActual As Date
            Dim fechaRec As Date
            Dim maximo As Integer
            Dim R As String
            fechaRec = DTPRecepcion.Value.Date
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
                  , [Sv7Curva], [Sv8Idioma], [Sv9Calendar], [SVAD10], [Fecha_Reg]) values(" & (DGConsulta.Item(1, i).Value) & "
                        ,'" & (DGConsulta.Item(2, i).Value) & "','" & DGConsulta.Item(3, i).Value & "'," & Val(DGConsulta.Item(4, i).Value) & "
                        ,'" & (DGConsulta.Item(5, i).Value) & "','" & DGConsulta.Item(6, i).Value & "','" & (DGConsulta.Item(7, i).Value) & "'
                        ,'" & DGConsulta.Item(8, i).Value & "'," & Val(DGConsulta.Item(9, i).Value) & ",'" & fechaRec & "'
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
                        ," & Val(DGConsulta.Item(53, i).Value) & ",'" & fechaActual & "')"
                MessageBox.Show(R)
                comando.CommandText = R
                comando.ExecuteNonQuery()
            Next i
            MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
            'Else
            'MsgBox("Ingresa el numero de foliio")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
        ''------------------------------------------------
    End Sub
    Private Sub btAgregarFila_Click(sender As Object, e As EventArgs) Handles btAgregarFila.Click
        Try
            DGConsulta.Rows.Add(False, DGConsulta.Item(1, 0).Value.ToString(), DGConsulta.Item(2, 0).Value.ToString(), "-", 0,
            DGConsulta.Item(5, 0).Value.ToString(), DGConsulta.Item(6, 0).Value.ToString(), DGConsulta.Item(7, 0).Value.ToString(),
            DGConsulta.Item(8, 0).Value.ToString(), DGConsulta.Item(9, 0).Value.ToString(), DGConsulta.Item(10, 0).Value.ToString(),
            "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", 0, "-", "-", "-", "-", "-", "-", DGConsulta.Item(37, 0).Value.ToString(), "-",
            DGConsulta.Item(39, 0).Value.ToString(), DGConsulta.Item(40, 0).Value.ToString(), DGConsulta.Item(41, 0).Value.ToString(), DGConsulta.Item(42, 0).Value.ToString(),
            DGConsulta.Item(43, 0).Value.ToString(), DGConsulta.Item(44, 0).Value.ToString(), DGConsulta.Item(45, 0).Value.ToString(),
            DGConsulta.Item(46, 0).Value.ToString(), DGConsulta.Item(47, 0).Value.ToString(), "-", "-", "-", "-", "-", "-", "-", "-", "-", "-")
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
                isnull(DirPaisEmision,'-'),isnull(DirCPEmision,'-') FROM [METASINF-2018].[dbo].[INFORMES-SERVICIOS] where ClavecontactoConsign =" & DGServicios.SelectedCells.Item(1).Value & " order by colonia desc"

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
End Class