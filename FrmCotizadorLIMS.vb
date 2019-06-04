Imports System.Data.SqlClient
Public Class FrmCotizadorLIMS
    Dim R As String
    Dim clave1 As String
    Private Sub FrmCotizadorLIMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If empresa = 0 Then
            Label20.Visible = False
            Label21.Visible = False
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            R = "select idProspecto, Nombre, Apellidos,  Prospectos.Compania, RFC, Correo,Telefono FROM Prospectos inner join Empresas on Prospectos.idClaveEmpresa=Empresas.Clavempresa"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                DGEmpresas.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Else
            PanelNormal.Enabled = False
            consultaID(empresa)
        End If
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId=SetUpEquipment.EquipId"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        While lectorLIMS.Read()
            DGCotizaciones.Rows.Add(False, lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
        End While
        lectorLIMS.Close()
        conexionLIMS.Close()
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            PanelNormal.Visible = True

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
        PanelNormal.Enabled = True
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

    Private Sub DGCotizaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizaciones.CellContentClick
        If e.ColumnIndex = DGCotizaciones.Columns.Item("s").Index Then
            DgAgregar.Rows.Add(DGCotizaciones.Rows(e.RowIndex).Cells(1).Value)

        End If
    End Sub

    Private Sub DGEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGEmpresas.RowHeaderMouseClick
        clave1 = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtNombreProspecto.Text = DGEmpresas.Rows(e.RowIndex).Cells(1).Value & " " & DGEmpresas.Rows(e.RowIndex).Cells(2).Value
        txtNombreCompania.Text = DGEmpresas.Rows(e.RowIndex).Cells(3).Value
        txtCorreo.Text = DGEmpresas.Rows(e.RowIndex).Cells(5).Value
        txtTelefono.Text = DGEmpresas.Rows(e.RowIndex).Cells(6).Value
        empresa = Val(DGEmpresas.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub BtCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        origen = "PROSPECCION"
        If DgAgregar.Rows.Count < 2 Then
            MsgBox("No hay articulos para Cotizar", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            For i As Integer = DgAgregar.Rows.Count() - 2 To 0 Step -1
                MetodoLIMS()
                comandoLIMS = conexionLIMS.CreateCommand
                R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price from  SetupCustomerEquipmentMapping 
                            inner join SetUpEquipment on SetupCustomerEquipmentMapping.EquipId=SetUpEquipment.EquipId inner join SetupEquipmentServiceMapping on  
                            SetupEquipment.EquipId=SetupEquipmentServiceMapping.EquipId where SetUpEquipment.EquipId=" & DgAgregar.Rows(i).Cells(0).Value
                comandoLIMS.CommandText = R
                lectorLIMS = comandoLIMS.ExecuteReader
                lectorLIMS.Read()
                frmEdicionCot2018_2019.DGCotizaciones.Rows.Add(i + 1, lectorLIMS(2), lectorLIMS(7), 1, lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(8), 0, lectorLIMS(1))
            Next
            frmEdicionCot2018_2019.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub TextArticulo_TextChanged(sender As Object, e As EventArgs) Handles TextArticulo.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub TxtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub TxtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por empresa", Err.Number, cadena)
        End Try
    End Sub
End Class