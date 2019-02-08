Imports System.Data.SqlClient
Public Class FrmFoliosDelAnioAnterior
    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        ''Modulo para insertar en Folios 2019-------------
        MetodoMetasInf2019()
        Try
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
                values ( " & Val(DGConsulta.Item(0, i).Value) & ",
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
                        ,' CONVERT(varchar(15), getdate(), 103)')"
                    ''MsgBox(R)
                    ''DGConsulta.Rows.Add(R)
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                Next i
                MsgBox("Guardado en 2019 correctamentee.", MsgBoxStyle.Information)
            Else
                MsgBox("Ingresa el numero de foliio")
            End If
            'Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
        ''------------------------------------------------
    End Sub
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btAgregarFila_Click(sender As Object, e As EventArgs) Handles btAgregarFila.Click
        Try
            DGConsulta.Rows.Add(False, DGConsulta.Item(1, 0).Value.ToString(), DGConsulta.Item(2, 0).Value.ToString(), "-", "-", "-",
            DGConsulta.Item(6, 0).Value.ToString(), DGConsulta.Item(7, 0).Value.ToString(), DGConsulta.Item(8, 0).Value.ToString(),
            DGConsulta.Item(9, 0).Value.ToString(), DGConsulta.Item(10, 0).Value.ToString(), DGConsulta.Item(11, 0).Value.ToString(),
            "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-",
            DGConsulta.Item(40, 0).Value.ToString(), "-", DGConsulta.Item(42, 0).Value.ToString(), DGConsulta.Item(43, 0).Value.ToString(),
            DGConsulta.Item(44, 0).Value.ToString(), DGConsulta.Item(45, 0).Value.ToString(), DGConsulta.Item(46, 0).Value.ToString(),
            DGConsulta.Item(47, 0).Value.ToString(), DGConsulta.Item(48, 0).Value.ToString(), "-", "-", "-", "-", "-", "-", "-", "-", "-", "-")
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
End Class

