Public Class FrmFiltrar
    Private Sub FrmFiltrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoInformacionGeneral()
            comando2018 = conexionInformacionGeneral.CreateCommand
            Dim R As String
            R = "select distinct Clavempresa, Compania, RFC
                 FROM MetasInf"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                dgEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub

    Private Sub TextEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TextEmpresa.TextChanged
        Try
            MetodoInformacionGeneral()
            comando2018 = conexionInformacionGeneral.CreateCommand
            Dim R As String
            dgEmpresas.Rows.Clear()
            If dgEmpresas.Rows.Count < 2 Then
            Else
                dgEmpresas.Rows.RemoveAt(dgEmpresas.CurrentRow.Index)
            End If
            '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
            R = "select distinct Clavempresa, Compania, RFC
                 FROM MetAsInf where Compania like '" & TextEmpresa.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                dgEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
    Private Sub dgEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEmpresas.RowHeaderMouseClick
        Try
            MetodoInformacionGeneral()
            comandoInformacionGeneral = conexionInformacionGeneral.CreateCommand
            Dim R As String
            R = "select distinct Clavempresa, RazonSocial, Compania, RFC, DomicilioConsig, PaisConsig, CiudadConsig, EdoConsig, CPConsig
                        from MetAsInf where Clavempresa =" & dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            comandoInformacionGeneral.CommandText = R
            lector2019 = comandoInformacionGeneral.ExecuteReader
            lector2019.Read()
            If ((lector2019(0) Is DBNull.Value) OrElse (lector2019(0) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbClave.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbClave.Text = lector2019(0)
            End If
            If ((lector2019(1) Is DBNull.Value) OrElse (lector2019(1) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbRazonSocial.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbRazonSocial.Text = lector2019(1)
            End If
            If ((lector2019(2) Is DBNull.Value) OrElse (lector2019(2) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbEmpresa.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbEmpresa.Text = lector2019(2)
            End If
            If ((lector2019(3) Is DBNull.Value) OrElse (lector2019(3) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbRFC.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbRFC.Text = lector2019(3)
            End If
            If ((lector2019(4) Is DBNull.Value) OrElse (lector2019(4) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbDomicilio.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbDomicilio.Text = lector2019(4)
            End If
            If ((lector2019(5) Is DBNull.Value) OrElse (lector2019(5) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbPais.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbPais.Text = lector2019(5)
            End If
            If ((lector2019(6) Is DBNull.Value) OrElse (lector2019(6) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbCiudad.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbCiudad.Text = lector2019(6)
            End If
            If ((lector2019(7) Is DBNull.Value) OrElse (lector2019(7) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbEstado.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbEstado.Text = lector2019(7)
            End If
            If ((lector2019(8) Is DBNull.Value) OrElse (lector2019(8) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbCP.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbCP.Text = lector2019(8)
            End If
            lector2019.Close()
            MetodoMetasInf2018()
            comando2019 = conexion2018.CreateCommand
            R = "(
                    (SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                    isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                    isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [METASINF-2018].[dbo].[INFORMES-SERVICIOS] where ClavecontactoConsign=" & dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString() & ")
                    UNION 
                    (SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                    isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                    isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [METASINF-2019].[dbo].[INFORMES-SERVICIOS] where ClavecontactoConsign=" & dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString() & ")
                    union
                    (SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
                    isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,isnull([INFORMES-SERVICIOS].ServCatalogo2,'-')as ServCatalogo2,
                    isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [METASINF-2017].[dbo].[INFORMES-SERVICIOS] where ClavecontactoConsign=" & dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString() & ")
                 )"
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                'FrmFoliosDelAnioAnterior.DGServicios.Visible = True
                'FrmFoliosDelAnioAnterior.DGCotizaciones.Visible = False
                FrmFoliosDelAnioAnterior.DGServicios.Rows.Add(False, lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(9))
            End While
            lector2019.Close()
            FrmFoliosDelAnioAnterior.lbServicios.Text = "Total de Servicios: " + Convert.ToString(FrmFoliosDelAnioAnterior.DGConsulta.Rows.Count - 1)
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoInformacionGeneral()
            comando2018 = conexionInformacionGeneral.CreateCommand
            Dim R As String
            dgEmpresas.Rows.Clear()
            If dgEmpresas.Rows.Count < 2 Then
            Else
                dgEmpresas.Rows.RemoveAt(dgEmpresas.CurrentRow.Index)
            End If
            '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
            R = "select distinct Clavempresa, Compania, RFC
                 FROM MetAsInf where Clavempresa like '" & txtClave.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                dgEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
End Class