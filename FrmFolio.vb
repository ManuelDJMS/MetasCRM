Imports System.Data.SqlClient
Public Class FrmFolio
    Private Sub TextFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TextFolio.KeyDown
        '-------------------------Bloque Manuel--------------------------------------------------
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    MetodoMetasInf2019()
                    comando2019 = conexion2019.CreateCommand
                    Dim R As String
                    '---------------CONSULTA PARA SACAR LOS DATOS DEL CONSIG----------------------------
                    R = "select [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS].Folio,[METASINF-2019-3].[dbo].[MetAsInf].PaisConsig, [METASINF-2019-3].[dbo].[MetAsInf].CPConsig,[METASINF-2019-3].[dbo].[MetAsInf].EdoConsig,
                    [METASINF-2019-3].[dbo].[MetAsInf].CiudadConsig, [METASINF-2019-3].[dbo].[MetAsInf].DomicilioConsig 
                    from [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS] inner join [METASINF-2019-3].[dbo].[MetAsInf]
                    on [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS].ClavecontactoConsign=[METASINF-2019-3].[dbo].[MetAsInf].Clavempresa
                    where [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS].Folio =" & TextFolio.Text
                    comando2019.CommandText = R
                    lector2019 = comando2019.ExecuteReader
                    lector2019.Read()
                    If ((lector2019(1) Is DBNull.Value) OrElse (lector2019(1) Is Nothing)) Then
                        lblPaisConsig.Text = "-"
                    Else
                        lblPaisConsig.Text = lector2019(1)
                    End If

                    If ((lector2019(2) Is DBNull.Value) OrElse (lector2019(2) Is Nothing)) Then
                        lblCPConsig.Text = "-"
                    Else
                        lblCPConsig.Text = lector2019(2)
                    End If
                    If ((lector2019(3) Is DBNull.Value) OrElse (lector2019(3) Is Nothing)) Then
                        lblEstConsig.Text = "-"
                    Else
                        lblEstConsig.Text = lector2019(3)
                    End If
                    If ((lector2019(4) Is DBNull.Value) OrElse (lector2019(4) Is Nothing)) Then
                        lblMunConsig.Text = "-"
                    Else
                        lblMunConsig.Text = lector2019(4)
                    End If
                    If ((lector2019(5) Is DBNull.Value) OrElse (lector2019(5) Is Nothing)) Then
                        lblColConsig.Text = "-"
                    Else
                        lblColConsig.Text = lector2019(5)
                    End If
                    lector2019.Close()
                    '---------------TERMINA LA CONSULTA PARA SACAR LOS DATOS DEL CONSIG----------------------------
                    '-----------------------------------------------------------------------------------
                    '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
                    R = "SELECT distinct [INFORMES-SERVICIOS].Folio,[MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].idComentario,
                    [MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].Fecha,[MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].Descripcion 
                    FROM [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS] inner join [MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT]
                    on [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS].Folio=[MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].Folio 
                    where [INFORMES-SERVICIOS].Folio =" & TextFolio.Text
                    comando2019.CommandText = R
                    lector2019 = comando2019.ExecuteReader
                    While lector2019.Read()
                        DGHistorial.Rows.Add(lector2019(1), lector2019(2), lector2019(3))
                    End While
                    lector2019.Close()
                    'lbPartidas.Text = "Total de Partidas: " + Convert.ToString(DGCotizaciones.Rows.Count - 1)
                    '-----------------------------------------------------------------------------------
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
        '-------------------------Termina Bloque Manuel--------------------------------------------------
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub txtAgregarCom_Click(sender As Object, e As EventArgs) Handles txtAgregarCom.Click
        MetodoCotizador2019()
        Dim max As Integer
        Dim R As String
        Dim comando As New SqlCommand("select MAX(idComentario) from [COMENTARIOS-PREFACT]", conexioncot)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        max = lector(0)
        lector.Close()
        R = "insert into [COMENTARIOS-PREFACT] (idComentario, Folio, Fecha, Descripcion) 
            values (" & max + 1 & "," & Val(TextFolio.Text) & ",(CONVERT(varchar(10), getdate(), 103)),'" &
            txtComentarios.Text & "')"
        MsgBox(R)
        comando.CommandText = R
        comando.ExecuteNonQuery()
        '-------------------------------Actualizar DATAGRID despues de agregar un comentario----------------------------------------------
        DGHistorial.Rows.Clear()
        R = "SELECT distinct [INFORMES-SERVICIOS].Folio,[MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].idComentario,
                    [MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].Fecha,[MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].Descripcion 
                    FROM [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS] inner join [MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT]
                    on [METASINF-2019-3].[dbo].[INFORMES-SERVICIOS].Folio=[MetasCotizador-3].[dbo].[COMENTARIOS-PREFACT].Folio 
                    where [INFORMES-SERVICIOS].Folio =" & TextFolio.Text
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        While lector2019.Read()
            DGHistorial.Rows.Add(lector2019(1), lector2019(2), lector2019(3))
        End While
        lector2019.Close()
    End Sub

    Private Sub FrmFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        FrmBuscarEmpresaCom.Show()
    End Sub

End Class
