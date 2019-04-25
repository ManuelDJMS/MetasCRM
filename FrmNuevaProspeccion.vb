Imports System.Data.SqlClient
Public Class FrmNuevaProspeccion
    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Then
            MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
        Else
            ' Try
            conexionMetasCotizador.Open()
            Dim R, status As String
            status = "Nuevo"
            R = "insert into Prospeccion ([idProspecto], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) 
                values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.ExecuteNonQuery()
            MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)

            txtDescripcion.Text = ""
            Me.Dispose()
            '  Catch ex As Exception
            ' MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
            ' End Try
        End If
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Then
                        MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
                    Else
                        ' Try
                        conexionMetasCotizador.Open()
                        Dim R, status As String
                        status = "Nuevo"
                        R = "insert into Prospeccion ([idProspecto], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) 
                             values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
                        Dim comando As New SqlCommand(R, conexionMetasCotizador)
                        comando.ExecuteNonQuery()
                        MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                        txtDescripcion.Text = ""
                        Me.Dispose()
                        '  Catch ex As Exception
                        ' MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
                        ' End Try
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try

    End Sub
End Class