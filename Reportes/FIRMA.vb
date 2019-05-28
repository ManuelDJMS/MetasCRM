Imports System.Data.SqlClient
Imports System.IO

Public Class FIRMA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MetodoMetasInf2019()
        comando2019 = conexion2019.CreateCommand
        Dim R As String
        Dim nom As String
        Dim fir As String
        R = "select * from [Claves-Elaboro-Cot] where [Clave-elaboro-cot] = 1"
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        lector2019.Read()
        nom = lector2019(1)
        fir = CByte(lector2019(5))
        MsgBox(nom)
        MsgBox(fir)
    End Sub
End Class