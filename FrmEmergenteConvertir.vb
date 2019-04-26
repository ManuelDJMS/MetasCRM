Imports System.Data.SqlClient
Public Class FrmEmergenteConvertir
    Private Sub FrmEmergenteConvertir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Or txtMonto.Text.Equals("") Or txtOrdenCompra.Text.Equals("") Then
            MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
        Else
            If btGuardar.Text.Equals("Guardar") Then
                'Guarda desde prospecto
                Try
                    conexionMetasCotizador.Open()
                    Dim R, status, TiempoUltimoActividad As String
                    status = "Nuevo"
                    TiempoUltimoActividad = "Sin definir"
                    R = "insert into Oportunidades ([Descripcion], [OrdenDeCompra], [FechaCreacion], [FechaEdicion], [Status], [Monto], [TiempoUltAct], idProspecto) values('" & txtDescripcion.Text & "','" & txtOrdenCompra.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "'," & txtMonto.Text & ",'" & TiempoUltimoActividad & "'," & txtidprospecto.Text & ")"
                    Dim comando As New SqlCommand(R, conexionMetasCotizador)
                    comando.ExecuteNonQuery()
                    MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                    MsgBox("Guarda oportunidad desde prospectos")
                    txtDescripcion.Text = ""
                    txtOrdenCompra.Text = ""
                    txtMonto.Text = ""
                    Me.Dispose()
                    conexionMetasCotizador.Close()
                Catch ex As Exception
                    MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
                End Try
            Else
                ''Guarda normal con prospeccion
                Try
                    conexionMetasCotizador.Open()
                    Dim R, status, TiempoUltimoActividad As String
                    status = "Nuevo"
                    TiempoUltimoActividad = "Sin definir"
                    R = "insert into Oportunidades ([idProspeccion], [Descripcion], [OrdenDeCompra], [FechaCreacion], [FechaEdicion], [Status], [Monto], [TiempoUltAct]) values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "','" & txtOrdenCompra.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "'," & txtMonto.Text & ",'" & TiempoUltimoActividad & "')"
                    Dim comando As New SqlCommand(R, conexionMetasCotizador)
                    comando.ExecuteNonQuery()
                    MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                    MsgBox("Guarda oportunidad con prospeccion")
                    txtDescripcion.Text = ""
                    txtOrdenCompra.Text = ""
                    txtMonto.Text = ""
                    Me.Dispose()
                    conexionMetasCotizador.Close()
                Catch ex As Exception
                    MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress, txtOrdenCompra.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class


