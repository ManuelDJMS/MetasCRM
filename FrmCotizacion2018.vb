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
        Try
            MetodoInformacionGeneral()
            comando2018 = conexionInformacionGeneral.CreateCommand
            Dim R As String
            R = "select distinct Clavempresa, Compania, RFC, EdooProv FROM MetasInf"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Private Sub txtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        Try
            MetodoInformacionGeneral()
            comando2018 = conexionInformacionGeneral.CreateCommand
            Dim R As String
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select distinct Clavempresa, Compania, RFC, EdooProv
                 FROM MetAsInf where Compania like '" & txtNombreE.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub
    Private Sub DGEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGEmpresas.RowHeaderMouseClick
        Try
            MetodoMetasInf2018()
            DGCotizaciones.Rows.Clear()
            clave1 = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            empresa = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, 
            [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot inner join 
            [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] where EntradaRegistroCot.CveEmpresa=" & clave1
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al cargar seleccionar la empresa", Err.Number, cadena)
        End Try
    End Sub
    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        Try
            MetodoMetasInf2018()
            DGCotizaciones.Rows.Clear()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot 
                 inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where 
                 EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].Marca like '" & txtMarca.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
        Try
            MetodoMetasInf2018()
            DGCotizaciones.Rows.Clear()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot 
                 inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where 
                 EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].Modelo like '" & txtModelo.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por modelo", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DGCotizaciones_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGCotizaciones.RowHeaderMouseClick
        frmEdicionCot2018_2019.txtCotizacion.Text = DGCotizaciones.Rows(e.RowIndex).Cells(0).Value.ToString
        frmEdicionCot2018_2019.ShowDialog()
    End Sub
    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoInformacionGeneral()
            comando2018 = conexionInformacionGeneral.CreateCommand
            Dim R As String
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select distinct Clavempresa, Compania, RFC, EdooProv
                 FROM MetAsInf where Clavempresa like '" & txtClave.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGEmpresas.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al cargar buscar por clave", Err.Number, cadena)
        End Try
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
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
            PanelFiltrado.Enabled = False
            lblCot.Visible = False
            DGCotizaciones.Enabled = False
            frmCotizacionPorArticulo.Show()
            rbArticulo.Checked = False
        End If
    End Sub

    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        Try
            MetodoMetasInf2018()
            DGCotizaciones.Rows.Clear()
            comando2018 = conexion2018.CreateCommand
            Dim R As String
            R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot 
                 inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where 
                 EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].Id like '" & TextID.Text & "%'"
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            While lector2018.Read()
                DGCotizaciones.Rows.Add(lector2018(0), lector2018(1), lector2018(2), lector2018(3), lector2018(4))
            End While
            lector2018.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por ID", Err.Number, cadena)
        End Try
    End Sub

    Private Sub rbTodosArt_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodosArt.CheckedChanged
        PanelFiltrado.Enabled = False
        lblCot.Visible = False
        DGCotizaciones.Enabled = False
        rbTodosArt.Checked = False
        frmConsultaTodos.Show()
    End Sub

    Private Sub rbFolios_CheckedChanged(sender As Object, e As EventArgs) Handles rbFolios.CheckedChanged
        PanelFiltrado.Enabled = False
        lblCot.Visible = False
        DGCotizaciones.Enabled = False
        rbFolios.Checked = False
        FrmCotPorFolio.Show()
    End Sub
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
    End Sub
End Class