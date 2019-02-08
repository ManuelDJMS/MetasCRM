Public Class FrmFiltrar
    Private Sub FrmFiltrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
            R = "select CCODIGOCLIENTE, CRAZONSOCIAL, CRFC, CNOMBRECALLE, CNUMEROEXTERIOR, CNUMEROINTERIOR, CCOLONIA, CCODIGOPOSTAL, CTELEFONO1
                 FROM admClientes inner join admDomicilios on admClientes.CIDCLIENTEPROVEEDOR=admDomicilios.CIDCATALOGO"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                dgEmpresas.Rows.Add(lector2018(1), lector2018(2), lector2018(3), lector2018(6), lector2018(7))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
End Class