Imports System.Data.SqlClient
Public Class FrmCotizadorLIMS
    Dim R As String
    Dim clave1 As String
    Private Sub FrmCotizadorLIMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If empresa = 0 Then
        'Label20.Visible = False
        '    Label21.Visible = False
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email, Phone FROM SetupCustomerDetails"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        While lectorLIMS.Read()
            DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6))
        End While
        lectorLIMS.Close()
        'Else
        '    PanelNormal.Enabled = False
        '    consultaID(empresa)
        'End If


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
    Private Sub TextCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextCorreo.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email, Phone FROM SetupCustomerDetails 
                where CustomerId like '" & txtClave.Text & "%' and Email like '" & TextCorreo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
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
        origen = "LIMS"
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

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email, Phone FROM SetupCustomerDetails 
                where CustomerId like '" & txtClave.Text & "%' and Email like '" & TextCorreo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub
    Private Sub TabConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabConsulta.SelectedIndexChanged
        If TabConsulta.SelectedTab Is TabPage1 Then
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone, x2.Email from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x1
             inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] x3
             on x2.Customerid=x3.CustomerId"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        End If
    End Sub

    Private Sub DgEmpresa_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEmpresa.RowHeaderMouseClick
        If dgCot.Rows.Count < 2 Then
        Else
            dgCot.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            dgCot.Rows.Clear()
        End If
        empresa = Val(DGEmpresas.Rows(e.RowIndex).Cells(0).Value)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        R = "SELECT idContacto, x1.NumCot, PartidaNo, x1.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price, Cantidad, SrlNo, RelationItemNo, Creado from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[DetalleCotizaciones] x1
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipmentServiceMapping] x3
			  on x1.EquipId=x3.EquipId inner join [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(4), lectorMetasCotizador(8), lectorMetasCotizador(11), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(10), lectorMetasCotizador(12), lectorMetasCotizador(14))
        End While
        lectorMetasCotizador.Close()
        conexionMetasCotizador.Close()
    End Sub

    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgEmpresa.Rows.Clear()
            If dgEmpresa.Rows.Count < 2 Then
            Else
                dgEmpresa.Rows.RemoveAt(dgEmpresa.CurrentRow.Index)
            End If
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone,Email from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x1
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] x3
                on x2.Customerid=x3.CustomerId where CompanyName like '" & txtNombreE.Text & "%' and Email like '" & TextEmail.Text & "%' and ContAddress1 like '" & TextDom.Text &
                "%' and ContZip like '" & txtCP.Text & "%' and Phone like '" & TextTel.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
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

    Private Sub TextDom_TextChanged(sender As Object, e As EventArgs) Handles TextDom.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgEmpresa.Rows.Clear()
            If dgEmpresa.Rows.Count < 2 Then
            Else
                dgEmpresa.Rows.RemoveAt(dgEmpresa.CurrentRow.Index)
            End If
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone,Email from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x1
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] x3
                on x2.Customerid=x3.CustomerId where CompanyName like '" & txtNombreE.Text & "%' and Email like '" & TextEmail.Text & "%' and ContAddress1 like '" & TextDom.Text &
                "%' and ContZip like '" & txtCP.Text & "%' and Phone like '" & TextTel.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
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

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgEmpresa.Rows.Clear()
            If dgEmpresa.Rows.Count < 2 Then
            Else
                dgEmpresa.Rows.RemoveAt(dgEmpresa.CurrentRow.Index)
            End If
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone,Email from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x1
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] x3
                on x2.Customerid=x3.CustomerId where CompanyName like '" & txtNombreE.Text & "%' and Email like '" & TextEmail.Text & "%' and ContAddress1 like '" & TextDom.Text &
                "%' and ContZip like '" & txtCP.Text & "%' and Phone like '" & TextTel.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
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

    Private Sub TxtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgEmpresa.Rows.Clear()
            If dgEmpresa.Rows.Count < 2 Then
            Else
                dgEmpresa.Rows.RemoveAt(dgEmpresa.CurrentRow.Index)
            End If
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone,Email from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x1
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] x3
                on x2.Customerid=x3.CustomerId where CompanyName like '" & txtNombreE.Text & "%' and Email like '" & TextEmail.Text & "%' and ContAddress1 like '" & TextDom.Text &
                "%' and ContZip like '" & txtCP.Text & "%' and Phone like '" & TextTel.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
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

    Private Sub TextTel_TextChanged(sender As Object, e As EventArgs) Handles TextTel.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgEmpresa.Rows.Clear()
            If dgEmpresa.Rows.Count < 2 Then
            Else
                dgEmpresa.Rows.RemoveAt(dgEmpresa.CurrentRow.Index)
            End If
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone,Email from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x1
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerAddressDtls] x3
                on x2.Customerid=x3.CustomerId where CompanyName like '" & txtNombreE.Text & "%' and Email like '" & TextEmail.Text & "%' and ContAddress1 like '" & TextDom.Text &
                "%' and ContZip like '" & txtCP.Text & "%' and Phone like '" & TextTel.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
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

    Private Sub TextSKU_TextChanged(sender As Object, e As EventArgs) Handles TextSKU.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgCot.Rows.Clear()
            If dgCot.Rows.Count < 2 Then
            Else
                dgCot.Rows.RemoveAt(dgCot.CurrentRow.Index)
            End If
            R = "SELECT idContacto, x1.NumCot, PartidaNo, x1.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price, Cantidad, SrlNo, RelationItemNo, Creado from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[DetalleCotizaciones] x1
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipmentServiceMapping] x3
			  on x1.EquipId=x3.EquipId inner join [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa &
              " and ItemNumber like '" & TextSKU.Text & "%' and EquipmentName like '" & TextDescripcion.Text & "%' and Mfr like '" & TextMarca.Text & "%' and " &
              "Model like '" & TextModelo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(4), lectorMetasCotizador(8), lectorMetasCotizador(11), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(10), lectorMetasCotizador(12), lectorMetasCotizador(14))
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

    Private Sub TextDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TextDescripcion.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgCot.Rows.Clear()
            If dgCot.Rows.Count < 2 Then
            Else
                dgCot.Rows.RemoveAt(dgCot.CurrentRow.Index)
            End If
            R = "SELECT idContacto, x1.NumCot, PartidaNo, x1.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price, Cantidad, SrlNo, RelationItemNo, Creado from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[DetalleCotizaciones] x1
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipmentServiceMapping] x3
			  on x1.EquipId=x3.EquipId inner join [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa &
              " and ItemNumber like '" & TextSKU.Text & "%' and EquipmentName like '" & TextDescripcion.Text & "%' and Mfr like '" & TextMarca.Text & "%' and " &
              "Model like '" & TextModelo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(4), lectorMetasCotizador(8), lectorMetasCotizador(11), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(10), lectorMetasCotizador(12), lectorMetasCotizador(14))
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

    Private Sub TextMarca_TextChanged(sender As Object, e As EventArgs) Handles TextMarca.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgCot.Rows.Clear()
            If dgCot.Rows.Count < 2 Then
            Else
                dgCot.Rows.RemoveAt(dgCot.CurrentRow.Index)
            End If
            R = "SELECT idContacto, x1.NumCot, PartidaNo, x1.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price, Cantidad, SrlNo, RelationItemNo, Creado from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[DetalleCotizaciones] x1
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipmentServiceMapping] x3
			  on x1.EquipId=x3.EquipId inner join [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa &
              " and ItemNumber like '" & TextSKU.Text & "%' and EquipmentName like '" & TextDescripcion.Text & "%' and Mfr like '" & TextMarca.Text & "%' and " &
              "Model like '" & TextModelo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(4), lectorMetasCotizador(8), lectorMetasCotizador(11), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(10), lectorMetasCotizador(12), lectorMetasCotizador(14))
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

    Private Sub TextModelo_TextChanged(sender As Object, e As EventArgs) Handles TextModelo.TextChanged
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgCot.Rows.Clear()
            If dgCot.Rows.Count < 2 Then
            Else
                dgCot.Rows.RemoveAt(dgCot.CurrentRow.Index)
            End If
            R = "SELECT idContacto, x1.NumCot, PartidaNo, x1.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price, Cantidad, SrlNo, RelationItemNo, Creado from [SERVER3\COMPAC2].[MetasCotizador].[dbo].[DetalleCotizaciones] x1
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Pruebas].[dbo].[SetupEquipmentServiceMapping] x3
			  on x1.EquipId=x3.EquipId inner join [SERVER3\COMPAC2].[MetasCotizador].[dbo].[Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa &
              " and ItemNumber like '" & TextSKU.Text & "%' and EquipmentName like '" & TextDescripcion.Text & "%' and Mfr like '" & TextMarca.Text & "%' and " &
              "Model like '" & TextModelo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(4), lectorMetasCotizador(8), lectorMetasCotizador(11), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(10), lectorMetasCotizador(12), lectorMetasCotizador(14))
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
End Class