Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Cotizaciones
    Private Sub Cotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColorColumnas(DGRes)
    End Sub

    Public Sub consultaServicios(ByVal EquipID As Integer)
        txtEquipID.Text = EquipID
        Try
            MetodoLIMS()
            Dim R As String
            R = "select [SetupServices].ServicesId, [SetupServices].ServiceName, [SetupEquipmentServiceMapping].Price, [SetupServices].IsActive 
                from [SetupServices] inner join [SetupEquipmentServiceMapping] on [SetupServices].ServicesId = [SetupEquipmentServiceMapping].ServicesId
                where [SetupEquipmentServiceMapping].EquipId = " & EquipID & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read
                DGRes.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            conexionLIMS.Close()
            lector.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos.", MsgBoxStyle.Information)
        End Try
        For n As Integer = DGRes.Rows.Count - 1 To 0 Step -1

            Dim row As DataGridViewRow = DGRes.Rows(n)

            If (row.Cells(1).Value Is DBNull.Value) Then
                DGRes.Rows.Remove(row)
            End If
        Next
    End Sub


    Public Sub consultaDetalleCotizaciones(ByVal numCot As Integer)
        'Try
        MetodoMetasCotizador()
        Dim R As String
        R = "select [DetalleCotizaciones].idListaCotizacion from [DetalleCotizaciones] where [DetalleCotizaciones].NumCot =" & numCot & ""
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read
            frmEdicionCot2018_2019.DGServicios.Rows.Add(lector(0))
        End While
        conexionMetasCotizador.Close()
        lector.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos.", MsgBoxStyle.Information)
        'End Try
    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        Dim seleccionado As Boolean
        Dim b As Boolean
        If DGRes.Rows.Count < 2 Then
            MsgBox("No hay servicios seleccionados.", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
            For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                seleccionado = DGRes.Rows(i).Cells(4).Value
                If seleccionado = True Then
                    b = True
                    Exit For
                Else
                    b = False
                End If
            Next
            '----------------------------------------------------------------------------------------------------
            If b = True Then
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(4).Value
                    If seleccionado = True Then
                        frmEdicionCot2018_2019.DGServicios.Rows.Add(txtIDListaDetalle.Text, txtEquipID.Text, DGRes.Rows(i).Cells(0).Value, DGRes.Rows(i).Cells(1).Value)
                    End If
                Next
                'accion post
                Me.Dispose()
            Else
                MsgBox("No ha seleccionado ningún servicio", MsgBoxStyle.Critical, "Error del sistema.")
            End If
        End If
    End Sub

    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub


End Class