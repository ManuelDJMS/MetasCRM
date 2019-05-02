Imports System.Data.SqlClient
Public Class FrmEmergenteConvertir
    Dim ultimo As String
    Private Sub FrmEmergenteConvertir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If txtidprospecto.Text.Equals("") Or txtDescripcion.Text.Equals("") Or txtMonto.Text.Equals("") Then
            MsgBox("No podemos guardar campos vacios.", MsgBoxStyle.Critical)
        Else
            If btGuardar.Text.Equals("Guardar") Then
                'Guarda desde prospecto
                Try
                    conexionMetasCotizador.Open()
                    Dim R, status, TiempoUltimoActividad As String
                    status = "Nuevo"
                    TiempoUltimoActividad = "Sin definir"
                    ''-------------------inserta en prospecciones -----------
                    Dim X, s As String
                    Dim monto As Double
                    monto = 0.0
                    s = "Por actualizar"
                    Dim status2 As String = "Por Actualizar"
                    Dim origen As String = "Por Actualizar"
                    X = "insert into Prospeccion ([idProspecto], [Descripcion], [FechaCreacion], [FechaEdicion], [Status], [Source], [Monto]) values(" & txtidprospecto.Text & ",'" & s & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status2 & "','" & origen & "'," & monto & ")"
                    Dim comando2 As New SqlCommand(X, conexionMetasCotizador)
                    comando2.ExecuteNonQuery()
                    conexionMetasCotizador.Close()
                    ''------------------------------
                    consultaUltimo()
                    conexionMetasCotizador.Open()
                    R = "insert into Oportunidades ([idProspeccion], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) values(" & ultimo & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
                    Dim comando As New SqlCommand(R, conexionMetasCotizador)
                    comando.ExecuteNonQuery()
                    conexionMetasCotizador.Close()

                    ''--------------------------------

                    conexionMetasCotizador.Open()
                    Dim cadena As String
                    Dim statuss As String = "Nuevo"
                    Dim surce As String = "Otro"
                    cadena = "update Prospeccion Set [Descripcion]='" & txtDescripcion.Text & "', Status = '" & statuss & "', Source ='" & surce & "', Monto=" & txtMonto.Text & " where idProspeccion='" & ultimo & "'"
                    Dim comandoA As New SqlCommand(cadena, conexionMetasCotizador)
                    comandoA.ExecuteNonQuery()
                    ''---------------------------------

                    MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                    MsgBox("Guarda oportunidad desde prospectos")
                    txtDescripcion.Text = ""
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
                    Dim R, status As String
                    status = "Nuevo"
                    R = "insert into Oportunidades ([idProspeccion], [Descripcion], [FechaCreacion], [FechaEdicion], [Status]) values(" & txtidprospecto.Text & ",'" & txtDescripcion.Text & "', (CONVERT(varchar(10), getdate(), 103)),(CONVERT(varchar(10), getdate(), 103)),'" & status & "')"
                    Dim comando As New SqlCommand(R, conexionMetasCotizador)
                    comando.ExecuteNonQuery()
                    conexionMetasCotizador.Close()

                    ''--------------------------------
                    consultaUltimo()
                    conexionMetasCotizador.Open()
                    Dim cadena As String
                    Dim statuss As String = "Nuevo"
                    Dim surce As String = "Otro"
                    cadena = "update Prospeccion set Status = '" & statuss & "', Source ='" & surce & "', Monto=" & txtMonto.Text & " where idProspeccion='" & ultimo & "'"
                    Dim comandoA As New SqlCommand(cadena, conexionMetasCotizador)
                    comandoA.ExecuteNonQuery()
                    ''---------------------------------

                    MsgBox("Oportunidad guardada correctamente", MsgBoxStyle.Information)
                    MsgBox("Guarda oportunidad con prospeccion")
                    txtDescripcion.Text = ""
                    txtMonto.Text = ""
                    Me.Dispose()
                    conexionMetasCotizador.Close()
                Catch ex As Exception
                    MsgBox("Ocurrio un error.", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub consultaUltimo()
        Try
            conexionMetasCotizador.Open()
            Dim R As String
            R = "select Max(idProspeccion) from [MetasCotizador].[dbo].[Prospeccion]"
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


