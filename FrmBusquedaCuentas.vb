Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmBusquedaCuentas
    Private Sub FrmBusquedaCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'consultaGeneralCuentas()
        alternarColorColumnas(DGConsulta)
    End Sub

    Public Sub consultaGeneralCuentas()
        DGConsulta.Rows.Clear()
        Try
            MetodoLIMS()
            Dim r As String
            r = "select CustAccountNo, Organization, KeyFiscal from SetupCustomerDetails"
            Dim comando As New SqlCommand(r, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read
                DGConsulta.Rows.Add(lector(0), lector(1), lector(2))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de registros, llama al administrador general", MsgBoxStyle.Exclamation)
        End Try
        conexionLIMS.Close()
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

    Private Sub DGConsulta_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGConsulta.RowHeaderMouseClick
        Dim clave As String
        clave = DGConsulta.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtNumeroDeCuenta.Text = clave
        FrmNuevoContacto.txtNumeroDeCuenta.Text = clave
        Me.Dispose()
        'MsgBox(clave)
    End Sub
End Class