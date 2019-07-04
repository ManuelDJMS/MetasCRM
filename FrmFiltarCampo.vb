Public Class FrmFiltarCampo
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub
    Private Sub BtSinCot_Click(sender As Object, e As EventArgs) Handles btSinCot.Click
        Dim seleccionado, b As Boolean
        For i As Integer = dgEmpresas.Rows.Count() - 1 To 0 Step -1
            seleccionado = dgEmpresas.Rows(i).Cells(0).Value
            If seleccionado = True Then
                b = True
                Exit For
            Else
                b = False
            End If
        Next
        '----------------------------------------------------------------------------------------------------
        If b = True Then
            For i As Integer = dgEmpresas.Rows.Count() - 1 To 0 Step -1
                seleccionado = dgEmpresas.Rows(i).Cells(0).Value
                If seleccionado = True Then
                    MetodoLIMS()
                    correos = correos & "; " & dgEmpresas.Rows(i).Cells(1).Value
                End If
            Next
            bancorreo = 1
            FrmCompletarOV.Show()
        Else
            MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
        End If
    End Sub
End Class