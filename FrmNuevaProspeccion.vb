Imports System.Data.SqlClient
Public Class FrmNuevaProspeccion
    Dim ultimo As String
    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Then
            MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
        Else
            Try
                conexionMetasCotizador.Open()
                Dim R, status As String
                status = "Nuevo"
                R = "insert into Prospeccion ([idProspecto], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) 
                values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                txtDescripcion.Text = ""
                conexionMetasCotizador.Close()
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Then
                        MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
                    Else
                        Try
                            conexionMetasCotizador.Open()
                            Dim R, status As String
                            status = "Nuevo"
                            R = "insert into Prospeccion ([idProspecto], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) 
                             values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
                            Dim comando As New SqlCommand(R, conexionMetasCotizador)
                            comando.ExecuteNonQuery()
                            MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                            txtDescripcion.Text = ""
                            conexionMetasCotizador.Close()
                            Me.Dispose()
                        Catch ex As Exception
                            MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
                        End Try
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try

    End Sub

    Private Sub FrmNuevaProspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim desc As String
        'desc = InputBox("Ingresa la descripción", "Prospección")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Then
            MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
        Else
            Try
                conexionMetasCotizador.Open()
                Dim R, status As String
                status = "Nuevo"
                R = "insert into Prospeccion ([idProspecto], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) 
                values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                conexionMetasCotizador.Close()
                consultaUltimo()
                txtDescripcion.Text = ""
                Dim control As New FrmEmergenteConvertir
                control.txtidprospecto.Text = ultimo
                control.btGuardar.Text = "Guardar."
                control.ShowDialog()
            Catch ex As Exception
                MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Public Sub consultaUltimo()
        Try
            conexionMetasCotizador.Open()
            Dim R As String
            R = "  select Max(idProspeccion) from [MetasCotizador].[dbo].[Prospeccion]"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            ultimo = lector(0)
            MsgBox(ultimo)
            lector.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class