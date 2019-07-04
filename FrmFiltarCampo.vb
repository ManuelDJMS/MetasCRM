Public Class FrmFiltarCampo
    Private Sub FrmFiltrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub

    Private Sub TextEmpresa_TextChanged(sender As Object, e As EventArgs)
        'Try
        '    MetodoMetasInf2018()
        '    comando2018 = conexion2018.CreateCommand
        '    Dim R As String
        '    dgEmpresas.Rows.Clear()
        '    If dgEmpresas.Rows.Count < 2 Then
        '    Else
        '        dgEmpresas.Rows.RemoveAt(dgEmpresas.CurrentRow.Index)
        '    End If
        '    comando2018 = conexion2018.CreateCommand
        '    '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
        '    R = "select distinct ClavecontactoConsign, Compania, RFC
        '         FROM [INFORMES-SERVICIOS] inner join MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa where Compania like '" & TextEmpresa.Text & "%'"
        '    comando2018.CommandText = R
        '    lector2018 = comando2018.ExecuteReader
        '    While lector2018.Read()
        '        dgEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2))
        '    End While
        '    lector2018.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("FrmCotPorFolio", "Error al cargar el formulario", Err.Number, cadena)
        'End Try
    End Sub
    Private Sub dgEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEmpresas.RowHeaderMouseClick


    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs)
        'Try
        '    MetodoMetasInf2018()
        '    comando2018 = conexion2018.CreateCommand
        '    Dim R As String
        '    dgEmpresas.Rows.Clear()
        '    If dgEmpresas.Rows.Count < 2 Then
        '    Else
        '        dgEmpresas.Rows.RemoveAt(dgEmpresas.CurrentRow.Index)
        '    End If
        '    comando2018 = conexion2018.CreateCommand
        '    '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
        '    R = "select distinct ClavecontactoConsign, Compania, RFC
        '         FROM [INFORMES-SERVICIOS] inner join MetAsInf on [INFORMES-SERVICIOS].ClavecontactoConsign=MetAsInf.Clavempresa where ClavecontactoConsign like '" & txtClave.Text & "%'"
        '    comando2018.CommandText = R
        '    lector2018 = comando2018.ExecuteReader
        '    While lector2018.Read()
        '        dgEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2))
        '    End While
        '    lector2018.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("FrmCotPorFolio", "Error al cargar el formulario", Err.Number, cadena)
        'End Try
    End Sub
End Class