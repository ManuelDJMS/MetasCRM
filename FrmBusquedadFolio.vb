
Public Class FrmBusquedadFolio
    Private Sub FrmBusquedadFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Parte para llenar el data de aarticulos------------este es el que selecciona-----------------------------------------------------------------------------
        MetodoMetasInf2019()
        comando2019 = conexion2019.CreateCommand
        Dim R As String
        R = "select [MetasCotizador-3].[dbo].[PRE-FACTURA].Fecha, [MetasCotizador-3].[dbo].[PRE-FACTURA].Folio,
        [METASINF-2019-3].[dbo].[MetAsInf].Compania, [MetasCotizador-3].[dbo].[PRE-FACTURA].Total
        from [MetasCotizador-3].[dbo].[PRE-FACTURA] inner join [METASINF-2019-3].[dbo].[MetAsInf] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveEmpresa= [METASINF-2019-3].[dbo].[MetAsInf].Clavempresa
        inner join  [METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveContacto=[METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios].ClaveContacto"
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        While lector2019.Read()
            dgFolios.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3))
        End While
        lector2019.Close()
        'clase.Close()
    End Sub
    Private Sub dtHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtHasta.ValueChanged
        Try
            Dim fechadesde, fechahasta As String
            fechadesde = dtDesde.Value.Year.ToString + "-" + dtDesde.Value.Month.ToString + "-" + dtDesde.Value.Day.ToString
            fechahasta = dtHasta.Value.Year.ToString + "-" + dtHasta.Value.Month.ToString + "-" + dtHasta.Value.Day.ToString
            dgFolios.Rows.Clear()
            MetodoMetasInf2019()
            'If dgFolios.Rows.Count < 2 Then
            'Else
            '    dgFolios.Rows.RemoveAt(dgFolios.CurrentRow.Index)
            'End If
            comando2019 = conexion2019.CreateCommand
            Dim R As String
            R = "select [MetasCotizador-3].[dbo].[PRE-FACTURA].Fecha, [MetasCotizador-3].[dbo].[PRE-FACTURA].Folio,
        [METASINF-2019-3].[dbo].[MetAsInf].Compania, [MetasCotizador-3].[dbo].[PRE-FACTURA].Total
        from [MetasCotizador-3].[dbo].[PRE-FACTURA] inner join [METASINF-2019-3].[dbo].[MetAsInf] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveEmpresa= [METASINF-2019-3].[dbo].[MetAsInf].Clavempresa
        inner join  [METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveContacto=[METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios].ClaveContacto WHERE FECHA BETWEEN '" & fechadesde & "' and '" & fechahasta & "'"

            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                dgFolios.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextCliente_TextChanged(sender As Object, e As EventArgs) Handles TextCliente.TextChanged
        Try
            dgFolios.Rows.Clear()
            MetodoMetasInf2019()
            If dgFolios.Rows.Count < 2 Then
            Else
                dgFolios.Rows.RemoveAt(dgFolios.CurrentRow.Index)
            End If
            comando2019 = conexion2019.CreateCommand
            Dim R As String
            R = "select [MetasCotizador-3].[dbo].[PRE-FACTURA].Fecha, [MetasCotizador-3].[dbo].[PRE-FACTURA].Folio,
        [METASINF-2019-3].[dbo].[MetAsInf].Compania, [MetasCotizador-3].[dbo].[PRE-FACTURA].Total
        from [MetasCotizador-3].[dbo].[PRE-FACTURA] inner join [METASINF-2019-3].[dbo].[MetAsInf] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveEmpresa= [METASINF-2019-3].[dbo].[MetAsInf].Clavempresa
        inner join  [METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveContacto=[METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios].ClaveContacto WHERE [METASINF-2019-3].[dbo].[MetAsInf].Compania like '" & TextCliente.Text & "%' and Folio like'" & TextFolio.Text & "%'"
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                dgFolios.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextFolio_TextChanged(sender As Object, e As EventArgs) Handles TextFolio.TextChanged
        Try
            dgFolios.Rows.Clear()
            MetodoMetasInf2019()
            If dgFolios.Rows.Count < 2 Then
            Else
                dgFolios.Rows.RemoveAt(dgFolios.CurrentRow.Index)
            End If
            comando2019 = conexion2019.CreateCommand
            Dim R As String
            R = "select [MetasCotizador-3].[dbo].[PRE-FACTURA].Fecha, [MetasCotizador-3].[dbo].[PRE-FACTURA].Folio,
        [METASINF-2019-3].[dbo].[MetAsInf].Compania, [MetasCotizador-3].[dbo].[PRE-FACTURA].Total
        from [MetasCotizador-3].[dbo].[PRE-FACTURA] inner join [METASINF-2019-3].[dbo].[MetAsInf] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveEmpresa= [METASINF-2019-3].[dbo].[MetAsInf].Clavempresa
        inner join  [METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveContacto=[METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios].ClaveContacto WHERE folio like '" & TextFolio.Text & "%' and [METASINF-2019-3].[dbo].[MetAsInf].Compania like '" & TextCliente.Text & "%'"
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                dgFolios.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub dtDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtDesde.ValueChanged
        'Try
        Dim fechadesde, fechahasta As String
        fechadesde = dtDesde.Value.Year.ToString + "-" + dtDesde.Value.Month.ToString + "-" + dtDesde.Value.Day.ToString
        fechahasta = dtHasta.Value.Year.ToString + "-" + dtHasta.Value.Month.ToString + "-" + dtHasta.Value.Day.ToString
        dgFolios.Rows.Clear()
        MetodoMetasInf2019()
        'If dgFolios.Rows.Count < 2 Then
        'Else
        '    dgFolios.Rows.RemoveAt(dgFolios.CurrentRow.Index)
        'End If
        comando2019 = conexion2019.CreateCommand
        Dim R As String
        R = "select [MetasCotizador-3].[dbo].[PRE-FACTURA].Fecha, [MetasCotizador-3].[dbo].[PRE-FACTURA].Folio,
        [METASINF-2019-3].[dbo].[MetAsInf].Compania, [MetasCotizador-3].[dbo].[PRE-FACTURA].Total
        from [MetasCotizador-3].[dbo].[PRE-FACTURA] inner join [METASINF-2019-3].[dbo].[MetAsInf] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveEmpresa= [METASINF-2019-3].[dbo].[MetAsInf].Clavempresa
        inner join  [METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios] on [MetasCotizador-3].[dbo].[PRE-FACTURA].ClaveContacto=[METASINF-2019-3].[dbo].[Contactos-Clientes-Usuarios].ClaveContacto WHERE FECHA BETWEEN '" & fechadesde & "' and '" & fechahasta & "'"

        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        While lector2019.Read()
            dgFolios.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3))
        End While
        lector2019.Close()


        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
    End Sub

    Private Sub dgFolios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgFolios.RowHeaderMouseClick
        MsgBox("hola")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        'Dim vCadena As String = "Paseo del Norte #5 300-A Guadalajara Technology Park Carretera a Nogales km 12,5 San Juan de Ocotán"
        'Dim vColeccion() As String = vCadena.Split(" ")
        'Dim direccion As String
        'Dim colonia As String
        'Dim ban As Integer
        'For i = 0 To vColeccion.Length - 1
        '    If vColeccion(i).Equals("Col") Then
        '        ban = i
        '    End If
        'Next
        ''--------------------CICLO PARA SACAR LA DIRECCION-------------------------
        'For ii = 0 To ban - 1
        '    direccion = direccion + " " + vColeccion(ii)
        'Next
        ''------------------------------------------------------------------------
        ''--------------------CICLO PARA SACAR LA COLONIA-------------------------
        'For ii = ban To vColeccion.Length - 1
        '    colonia = colonia + " " + vColeccion(ii)
        'Next
        ''------------------------------------------------------------------------
        'MsgBox(direccion)
        'MsgBox(colonia) codigo para separar la colonia y la calle
        FrmFolio.Show()
    End Sub
End Class
