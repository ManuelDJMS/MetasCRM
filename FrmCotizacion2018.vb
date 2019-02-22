Imports System.Data.SqlClient
Public Class FrmCotizacion2018
    Dim Adapter As New SqlDataAdapter
    Dim DataTable1 As New DataTable
    Dim dt2 As New DataTable
    Dim R As String
    Dim clave1 As String
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Private Sub FrmCotizacion2018_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoInformacionGeneral()
        Try
            dt2 = New DataTable
            With cmd
                .Connection = conexionInformacionGeneral
                .CommandText = "select MetAsInf.Clavempresa as [Clave de Empresa], MetasInf.Compania as [Cliente], MetAsInf.RFC, MetAsInf.EdooProv as [Estado] from MetAsInf"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DGEmpresas.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        End Try
        da.Dispose()
        conexionInformacionGeneral.Close()
    End Sub
    Private Sub txtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        Try
            MetodoInformacionGeneral()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            Dim R As String
            R = "select MetAsInf.Clavempresa as [Clave de Empresa], MetasInf.Compania as [Cliente], MetAsInf.RFC, MetAsInf.EdooProv as [Estado] from MetAsInf where MetAsInf.RazonSocial like '" & txtNombreE.Text & "%'"
            Dim comando As New SqlCommand(R, conexionInformacionGeneral)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGEmpresas.DataSource = dt
            da.Dispose()
            conexionInformacionGeneral.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
        End Try
    End Sub
    Private Sub DGInicial_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        'ConexionLocal()
        ''Dim clave As String
        'Try
        '    DGCotizaciones.Rows.Clear()
        '    clave1 = DGInicial.Rows(e.RowIndex).Cells(0).Value.ToString()
        '    comando = conexionLocale.CreateCommand
        '    Dim R As String
        '    R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, 
        '        EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot
        '        inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot]
        '        where EntradaRegistroCot.CveEmpresa=" & clave1
        '    comando.CommandText = R
        '    lector = comando.ExecuteReader
        '    DGCotizaciones.Rows.Clear()

        '    While lector.Read()
        '        DGCotizaciones.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        '    End While
        '    lector.Close()
        '    conexionLocale.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Ocurrio un error en la lectura de datos, llama al administrador de sistemas.")
        'End Try
        'Dim clase As New SqlConnection(conexionprueba)
        'clase.Open()
        MetodoMetasInf2018() ''MetasINF-2019
        Try
            clave1 = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, 
        '        EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot
        '        inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot]
        '        where EntradaRegistroCot.CveEmpresa=" & clave1
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            'DataArticulos.DataSource = dt2
            DGCotizaciones.DataSource = dt2
            'Parte para llenar el data de aarticulos-----------------------------------------------------------------------------------------
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select *from [1Cotizar] where Numcot =" & clave1
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            'DataArticulos.DataSource = dt2
            DGCotizaciones.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        End Try
        da.Dispose()
        conexion2018.Close()
    End Sub

    Private Sub DGEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGEmpresas.RowHeaderMouseClick
        MetodoMetasInf2018()
        'Try
        clave1 = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
        empresa = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
        dt2 = New DataTable
        With cmd
            .Connection = conexion2018
            .CommandText = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] where EntradaRegistroCot.CveEmpresa=" & clave1

        End With
        da.SelectCommand = cmd
        da.Fill(dt2)
        'DataArticulos.DataSource = dt2
        DGCotizaciones.DataSource = dt2
        ''Parte para llenar el data de aarticulos------------este es el que selecciona-----------------------------------------------------------------------------
        'dt2 = New DataTable
        'With cmd
        '    .Connection = conexion2018
        '    .CommandText = "select Tipo, Marca, Modelo, Alcance from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & clave1
        'End With
        'da.SelectCommand = cmd
        'da.Fill(dt2)
        ''DataArticulos.DataSource = dt2
        'DGCotizaciones.DataSource = dt2
        '' Catch ex As Exception
        ''sgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        ''End Try
        da.Dispose()
        conexion2018.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        'Dim clase As New SqlConnection(conexionprueba)
        MetodoMetasInf2018()
        Try
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If

            '   clase.Open()
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].Marca like '" & txtMarca.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DGCotizaciones.DataSource = dt2
            conexion2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")

        End Try
        da.Dispose()
        'clase.Close()

    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
        'Dim clase As New SqlConnection(conexionprueba)
        Try
            MetodoMetasInf2018()

            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If

            '   clase.Open()
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].Modelo like '" & txtModelo.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DGCotizaciones.DataSource = dt2
            conexion2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
        da.Dispose()
        'clase.Close()
    End Sub

    Private Sub DGCotizaciones_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGCotizaciones.RowHeaderMouseClick

        frmEdicionCot2018_2019.txtCotizacion.Text = DGCotizaciones.Rows(e.RowIndex).Cells(0).Value.ToString
        frmEdicionCot2018_2019.ShowDialog()

    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoInformacionGeneral()
            'DGInicial.Visible = False
            'DGCotizaciones.Rows.Clear()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            Dim R As String
            R = "select MetAsInf.Clavempresa as [Clave de Empresa], MetasInf.Compania as [Cliente], MetAsInf.RFC, MetAsInf.EdooProv as [Estado] from MetAsInf where MetAsInf.Clavempresa like '" & txtClave.Text & "%'"
            Dim comando As New SqlCommand(R, conexionInformacionGeneral)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGEmpresas.DataSource = dt

            da.Dispose()
            conexionInformacionGeneral.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema")
            'MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        '    e.Handled = True
        'End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rbCotizacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbCotizacion.CheckedChanged
        If (rbCotizacion.Checked) Then
            'DGArticulos.Visible = False
            DGCotizaciones.Visible = True
            txtMarca.Visible = True
            txtModelo.Visible = True
            lblMarca.Visible = True
            lblModelo.Visible = True
            lblCot.Visible = True
        End If
    End Sub

    Private Sub rbArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbArticulo.CheckedChanged
        If (rbArticulo.Checked) Then
            'DGCotizaciones.Visible = False
            'DGArticulos.Visible = True
            txtMarca.Visible = False
            txtModelo.Visible = False
            lblMarca.Visible = False
            lblModelo.Visible = False
            lblCot.Visible = False
            'MsgBox("oasasdasdsadsadas")
            'frmCotizacionArticulo.txtCotizacion.Text = DGCotizaciones.Rows(e.RowIndex).Cells(0).Value.ToString
            frmCotizacionPorArticulo.ShowDialog()
        End If
    End Sub

    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        'Dim clase As New SqlConnection(conexionprueba)
        Try
            MetodoMetasInf2018()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            dt2 = New DataTable
            With cmd
                .Connection = conexion2018
                .CommandText = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].ID like '" & TextID.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DGCotizaciones.DataSource = dt2
            conexion2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
        da.Dispose()
        'clase.Close()
    End Sub

    Private Sub rbTodosArt_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodosArt.CheckedChanged
        frmConsultaTodos.Show()
    End Sub

    Private Sub rbFolios_CheckedChanged(sender As Object, e As EventArgs) Handles rbFolios.CheckedChanged
        respuestafolio = InputBox("Folio", "Ingrese la confirmación metrológica:")

    End Sub
End Class