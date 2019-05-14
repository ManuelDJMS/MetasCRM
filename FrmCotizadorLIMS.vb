Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmCotizadorLIMS
    Dim R As String
    Private Sub FrmCotizadorLIMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Label2.Text.Equals("Parametro") Then
            MsgBox("Sin busqueda por parametro, normal")
            PanelNormal.Visible = True
            PanelCot.Visible = False
            'Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                DGEmpresas.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            '    cadena = Err.Description
            '    cadena = cadena.Replace("'", "")
            '    Bitacora("FrmCotizacion2018", "Error al cargar el formulario", Err.Number, cadena)
            'End Try
        Else
            MsgBox("Busqueda por parametro idProspecto")
            PanelNormal.Visible = False
            PanelCot.Visible = True
            consultaID(Label2.Text)
        End If

    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            PanelNormal.Visible = True
            PanelCot.Visible = False
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa
                where idProspecto like '" & txtClave.Text & "%'
                and Correo like '" & TextCorreo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                DGEmpresas.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub TextCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextCorreo.TextChanged
        Try
            PanelNormal.Visible = True
            PanelCot.Visible = False
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa
                where idProspecto like '" & txtClave.Text & "%'
                and Correo like '" & TextCorreo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                DGEmpresas.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub

    'Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        MetodoMetasCotizador()
    '        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
    '        DGEmpresas.Rows.Clear()
    '        If DGEmpresas.Rows.Count < 2 Then
    '        Else
    '            DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
    '        End If
    '        R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa
    '            where idProspecto like '" & txtClave.Text & "%'
    '            and Prospectos.Compania like '" & txtNombreE.Text & "%' and Correo like '" & TextCorreo.Text & "%'"
    '        comandoMetasCotizador.CommandText = R
    '        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
    '        While lectorMetasCotizador.Read()
    '            DGEmpresas.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5))
    '        End While
    '        lectorMetasCotizador.Close()
    '        conexionMetasCotizador.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
    '        cadena = Err.Description
    '        cadena = cadena.Replace("'", "")
    '        Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
    '    End Try
    'End Sub
    Public Sub consultaID(ByVal idProspecto As String)
        Try
            MetodoMetasCotizador()
            R = "select idProspecto, Nombre, Apellidos, Compania, Telefono, Correo FROM Prospectos where idProspecto = '" & idProspecto & "'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            txtclavee.Text = lector(0)
            txtNombreProspecto.Text = lector(1) & " " & lector(2)
            txtNombreCompania.Text = lector(3)
            txtTelefono.Text = lector(4)
            txtCorreo.Text = lector(5)
            lector.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        PanelNormal.Visible = True
        PanelCot.Visible = False
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                DGEmpresas.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub
End Class