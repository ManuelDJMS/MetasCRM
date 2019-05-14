Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmCotizadorLIMS
    Dim R As String
    Private Sub FrmCotizadorLIMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa
                where idProspecto like '" & txtClave.Text & "%'
                and Prospectos.Compania like '" & txtNombreE.Text & "%' and Correo like '" & TextCorreo.Text & "%'"
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
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa
                where idProspecto like '" & txtClave.Text & "%'
                and Prospectos.Compania like '" & txtNombreE.Text & "%' and Correo like '" & TextCorreo.Text & "%'"
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

    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa
                where idProspecto like '" & txtClave.Text & "%'
                and Prospectos.Compania like '" & txtNombreE.Text & "%' and Correo like '" & TextCorreo.Text & "%'"
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub
End Class