Public Class FrmFiltrar
    Private Sub FrmFiltrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select distinct ClavecontactoConsign, Compania, RFC
                 FROM [INFORMES-SERVICIOS] inner join MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa"
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
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            dgEmpresas.Rows.Clear()
            If dgEmpresas.Rows.Count < 2 Then
            Else
                dgEmpresas.Rows.RemoveAt(dgEmpresas.CurrentRow.Index)
            End If
            comando2018 = conexion2018.CreateCommand
            '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
            R = "select distinct ClavecontactoConsign, Compania, RFC
                 FROM [INFORMES-SERVICIOS] inner join MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa where Compania like '" & TextEmpresa.Text & "%'"
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
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select distinct Folio, ClavecontactoConsign, RazonSocial, Compania, RFC, DomicilioConsig, PaisConsig, CiudadConsig, EdoConsig, CPConsig
                        from [INFORMES-SERVICIOS] INNER JOIN MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa
                        where ClavecontactoConsign ='" & dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString() & "'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            lector2018.Read()
            If ((lector2018(0) Is DBNull.Value) OrElse (lector2018(0) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.TextFolio.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.TextFolio.Text = lector2018(0)
            End If
            If ((lector2018(1) Is DBNull.Value) OrElse (lector2018(1) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbClave.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbClave.Text = lector2018(1)
            End If
            If ((lector2018(2) Is DBNull.Value) OrElse (lector2018(2) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbRazonSocial.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbRazonSocial.Text = lector2018(2)
            End If
            If ((lector2018(3) Is DBNull.Value) OrElse (lector2018(3) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbEmpresa.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbEmpresa.Text = lector2018(3)
            End If
            If ((lector2018(4) Is DBNull.Value) OrElse (lector2018(4) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbRFC.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbRFC.Text = lector2018(4)
            End If
            If ((lector2018(5) Is DBNull.Value) OrElse (lector2018(5) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbDomicilio.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbDomicilio.Text = lector2018(5)
            End If
            If ((lector2018(6) Is DBNull.Value) OrElse (lector2018(6) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbPais.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbPais.Text = lector2018(6)
            End If
            If ((lector2018(7) Is DBNull.Value) OrElse (lector2018(7) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbCiudad.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbCiudad.Text = lector2018(7)
            End If
            If ((lector2018(8) Is DBNull.Value) OrElse (lector2018(8) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbEstado.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbEstado.Text = lector2018(8)
            End If
            If ((lector2018(9) Is DBNull.Value) OrElse (lector2018(9) Is Nothing)) Then
                FrmFoliosDelAnioAnterior.lbCP.Text = "-"
            Else
                FrmFoliosDelAnioAnterior.lbCP.Text = lector2018(9)
            End If
            lector2018.Close()
            R = "SELECT distinct isnull([INFORMES-SERVICIOS].ClavecontactoConsign, '-'),isnull([INFORMES-SERVICIOS].TIPO,'-') as Tipo, isnull([INFORMES-SERVICIOS].MARCA,'-')as Marca, isnull([INFORMES-SERVICIOS].MODELO,'-') as Modelo,
              isnull([INFORMES-SERVICIOS].Serie,'-')as Serie,isnull([INFORMES-SERVICIOS].ID,'-')as ID,isnull([INFORMES-SERVICIOS].ServCatalogo1,'-')as ServCatalogo1,
              isnull([INFORMES-SERVICIOS].PUCalib,0)as PUCalib, isnull([INFORMES-SERVICIOS].PULab,0) as PULab from [INFORMES-SERVICIOS] where [INFORMES-SERVICIOS].ClavecontactoConsign =" & dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                FrmFoliosDelAnioAnterior.DGServicios.Rows.Add(False, lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8))
            End While
            lector2018.Close()
            FrmFoliosDelAnioAnterior.lbServicios.Text = "Total de Servicios: " + Convert.ToString(FrmFoliosDelAnioAnterior.DGConsulta.Rows.Count - 1)
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            dgEmpresas.Rows.Clear()
            If dgEmpresas.Rows.Count < 2 Then
            Else
                dgEmpresas.Rows.RemoveAt(dgEmpresas.CurrentRow.Index)
            End If
            comando2018 = conexion2018.CreateCommand
            '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
            R = "select distinct ClavecontactoConsign, Compania, RFC
                 FROM [INFORMES-SERVICIOS] inner join MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa where ClavecontactoConsign like '" & txtClave.Text & "%'"
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