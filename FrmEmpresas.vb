Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FrmEmpresas
    Private Sub FrmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        ''ConexionGlobal2()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs)
    '    Dim R As String
    '    DG.Rows.Clear()
    '    R = "exec consultaSinRepetir"
    '    Dim comando As New SqlCommand(R, conexion)
    '    Dim lector As SqlDataReader
    '    lector = comando.ExecuteReader
    '    While (lector.Read())
    '        DG.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12), lector(13), lector(14), lector(15), lector(16), lector(17), lector(18), lector(19), lector(20), lector(21))
    '    End While
    '    lector.Close()
    ' End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim save As New SaveFileDialog
    '    save.Filter = "Archivo Excel | *.xlsx"
    '    If save.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Exportar_Excel(DG, save.FileName)
    '        MsgBox("Archivo Excel generado correctamente", MsgBoxStyle.Information)
    '    Else
    '        MsgBox("Ocurrio algún error, verifica nuevamente", MsgBoxStyle.Exclamation)
    '    End If
    'End Sub

    'Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
    '    Dim xlApp As Object = CreateObject("Excel.Application")
    '    Dim xlWB As Object = xlApp.WorkBooks.add
    '    Dim xlWS As Object = xlWB.WorkSheets(1)

    '    For c As Integer = 0 To DG.Columns.Count - 1
    '        xlWS.cells(1, c + 1).value = DG.Columns(c).HeaderText
    '    Next

    '    For r As Integer = 0 To DG.RowCount - 1
    '        For c As Integer = 0 To DG.Columns.Count - 1
    '            xlWS.cells(r + 2, c + 1).value = DG.Item(c, r).Value
    '        Next
    '    Next

    '    xlWB.saveas(pth)
    '    xlWS = Nothing
    '    xlWB = Nothing
    '    xlApp.quit()
    '    xlApp = Nothing

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim stRuta As String = ""
    '    Dim openFD As New OpenFileDialog

    '    With openFD
    '        .Title = "Seleccionar archivos"
    '        .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
    '        .Multiselect = False
    '        .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
    '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '            stRuta = .FileName
    '        End If
    '    End With

    '    Try
    '        Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (stRuta & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
    '        Dim cnConex As New OleDbConnection(stConexion)
    '        Dim Cmd As New OleDbCommand("Select * From [Hoja1$]")
    '        Dim Ds As New DataSet
    '        Dim Da As New OleDbDataAdapter
    '        Dim Dt As New DataTable
    '        cnConex.Open()
    '        Cmd.Connection = cnConex
    '        Da.SelectCommand = Cmd
    '        Da.Fill(Ds)
    '        Dt = Ds.Tables(0)
    '        Me.DG2.DataSource = Dt
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub
End Class