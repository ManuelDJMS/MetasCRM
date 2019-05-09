Imports System.Data.SqlClient
Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Public Class FrmModalidades
    Private Sub FrmModalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        MetodoMetasCotizador()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Codigo para guardar en 1Cotizar----------------------------------------------------
        MetodoLIMS()

        Dim R As String
        For i = 0 To DataGridView2.Rows.Count - 2
            R = "insert into [SetupCustomerEquipmentMapping] ([CustomerId], [EquipId], [InstrumentId], [SrlNo],
                [Dept], [Location], [CALInterval], [CALCycle], [IsActive], [OnSite], [ShortNotes], [AssetNo]) values 
                (" & Val(DataGridView2.Item(0, i).Value) & "," & DataGridView2.Item(1, i).Value & ",'" & DataGridView2.Item(2, i).Value & "','" & DataGridView2.Item(3, i).Value & "','" & DataGridView2.Item(4, i).Value & "','" & DataGridView2.Item(5, i).Value & "'," & Val(DataGridView2.Item(6, i).Value) & ",'" & DataGridView2.Item(7, i).Value & "','" & DataGridView2.Item(8, i).Value & "','" & DataGridView2.Item(9, i).Value & "','" & DataGridView2.Item(10, i).Value & "','" & DataGridView2.Item(11, i).Value & "')"
            'MsgBox(R)
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.ExecuteNonQuery()
        Next i
        MsgBox("OK")
        conexionLIMS.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        importarExcel(DataGridView2)
    End Sub

    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            'xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            xSheet = "Hoja1"
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            ' Try
            da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
            tabla.DataMember = "MyData"
            conn.Close()
            'Catch ex As Exception
            'MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            'Finally
            'conn.Close()
            'End Try
        End If
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub
End Class