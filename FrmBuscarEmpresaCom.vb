Public Class FrmBuscarEmpresaCom
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
        'ultima prueba de git
    End Sub

    Private Sub FrmBuscarEmpresaCom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasMetrologos()
            comandoMetrologos = conexionMetrologos.CreateCommand
            Dim R As String
            '---------------CONSULTA PARA SACAR LOS COMENTARIOS DE LA PREFACTURA----------------------------
            R = "select CCODIGOCLIENTE, CRAZONSOCIAL, CRFC, CNOMBRECALLE, CNUMEROEXTERIOR, CNUMEROINTERIOR, CCOLONIA, CCODIGOPOSTAL, CTELEFONO1
                 FROM admClientes inner join admDomicilios on admClientes.CIDCLIENTEPROVEEDOR=admDomicilios.CIDCATALOGO"
            comandoMetrologos.CommandText = R
            lectorMetrologos = comandoMetrologos.ExecuteReader
            While lectorMetrologos.Read()
                dgEmpresas.Rows.Add(lectorMetrologos(1), lectorMetrologos(2), lectorMetrologos(3), lectorMetrologos(6), lectorMetrologos(7))
            End While
            lectorMetrologos.Close()
            'lbPartidas.Text = "Total de Partidas: " + Convert.ToString(DGCotizaciones.Rows.Count - 1)
            '-----------------------------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
End Class