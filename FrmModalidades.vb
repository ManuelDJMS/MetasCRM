Imports System.Data.SqlClient
Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Public Class FrmModalidades
    Private Sub FrmModalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralProspectos()

    End Sub
    Public Sub consultaGeneralProspectos()
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select Prospeccion.idProspeccion as [#Prospección], Prospectos.Nombre, Prospectos.Apellidos, Prospectos.Compania, Prospeccion.Descripcion as [Descripción],
                    Prospeccion.Monto, Prospeccion.[Source] from Prospeccion inner join Prospectos on Prospeccion.idProspecto = Prospectos.idProspecto"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGConsulta.DataSource = dt
            DGConsulta.Columns(4).Width = 190
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Monto").Style.BackColor = Color.DarkSeaGreen
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub

End Class