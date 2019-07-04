Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmCotizadorLIMS
    Dim R As String
    Dim clave1 As String
    Private Sub FrmCotizadorLIMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email, Phone FROM SetupCustomerDetails"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        While lectorLIMS.Read()
            DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6))
        End While
        lectorLIMS.Close()
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
            frmEdicionCot2018_2019.ShowDialog()
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
             inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] x3
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
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipmentServiceMapping] x3
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
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] x3
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
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] x3
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
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] x3
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
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] x3
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
                inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupCustomerAddressDtls] x3
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
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipmentServiceMapping] x3
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
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipmentServiceMapping] x3
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
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipmentServiceMapping] x3
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
              inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join [DATABASESERVER\COMPAC].[MetAs_Live-Clouding].[dbo].[SetupEquipmentServiceMapping] x3
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim COT As Integer
        COT = InputBox("Ingrese el número de Cotización", "Folios")
        'COT = Val(txtCot.Text)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        ' Dim n As Integer = 0
        Dim desde, hasta As Date
        Dim nombre, puesto, tel, ext, correo, emp, dom, lugar, moneda, cotizo, correoEla, depto,
        pago, entrega, modalidad, obser, calmetho, services, domFac, rfc As String
        Dim cve As Integer
        Dim R As String
        Dim fir As Image
        'Dim name, mfr, model, service, price, subt As String
        R = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, isnull([Department], '-') AS Departament, isnull([Phone], '-') as Phone, isnull([SetupCustomerDetails].[Email], '-') as Email,
        isnull([CompanyName],'-') as CompanyName, [ContAddress1] + ' '+  [ContCity] +', '+ [ContState]+'. ' + [ContCountry] +'. CP '+ [ContZip] AS DomCont, ROW_NUMBER() OVER(ORDER BY PartidaNo ASC) AS Partidad, Cantidad,[DetalleCotizaciones].[EquipId],
        [SetUpEquipment].[EquipmentName]+', '+[Mfr] +', '+[Model] +'. ' + (CASE WHEN  [identificadorInventarioCliente] = '-' COLLATE SQL_Latin1_General_CP1_CI_AS  THEN [identificadorInventarioCliente]  COLLATE SQL_Latin1_General_CP1_CI_AS 
        ELSE [identificadorInventarioCliente] COLLATE SQL_Latin1_General_CP1_CI_AS  END) AS Comparacion,[SetupServices].[ServiceName],[ServiceDescription] +', ' + [TurnAroundTime]+' dias para calibración' as Descrip, [SetupEquipmentServiceMapping].[Price], [SetupEquipmentServiceMapping].[Price] * Cantidad AS sub,
        [idUsuarioAdministrador], [Usuarios].[Nombre], [LugarCondicion].[Descripcon] AS lugar, [MonedaCondicion].[Descripcion] AS moneda, 
        [PagoCondicion].[Descripcion] AS pago, [ModalidadCondicion].[Descripcion] AS modalidad,
        [Cotizaciones].[Observaciones],[CalibrationMethod], [ServiceDescription], [BillAddress1] +' '+ [BillCity] +', '+ [BillState]+'. '+[BillCountry]+' CP '+[BillZip] AS domFac, [TaxIDNo],
        [Usuarios].[Email], [Usuarios].[Depto]
                    from [MetasCotizador].[dbo].[Cotizaciones]
        INNER JOIN [Usuarios] ON [Cotizaciones].[idUsuarioCotizacion] = [Usuarios].[idUsuarioAdministrador]
        INNER JOIN " & servidor & " [SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
        INNER JOIN " & servidor & " [SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                    INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
        INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].[idListaCotizacion] = [ServiciosEnCotizaciones].[idListaCotizacion]
        INNER JOIN " & servidor & " [SetupServices] ON [ServiciosEnCotizaciones].[idServicio] = [SetupServices].[ServicesId]
        INNER JOIN [LugarCondicion] ON [Cotizaciones].[idLugarCondicion] = [LugarCondicion].[idLugarCondicion]
        INNER JOIN [MonedaCondicion] ON [Cotizaciones].[idMonedaCondicion] = [MonedaCondicion].[idMonedaCondicion]
        INNER JOIN [PagoCondicion] ON [Cotizaciones].[idPagoCondicion] = [PagoCondicion].[idPagoCondicion]
        INNER JOIN [TiemposEntregaCondicion] ON [Cotizaciones].[idTiempoEntregaCondicion] = [TiemposEntregaCondicion].[idTiempoEntregaCondicion]
        INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
        INNER JOIN " & servidor & " [SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
        INNER JOIN " & servidor & " [SetupEquipmentServiceMapping] ON [SetUpEquipment].[EquipId] =[SetupEquipmentServiceMapping].[EquipId]
                        WHERE [Cotizaciones].NumCot = '" & COT & "'"
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        'While lectorMetasCotizador.Read()
        lectorMetasCotizador.Read()
        desde = lectorMetasCotizador(1)
        ' MsgBox(desde)
        hasta = lectorMetasCotizador(2)
        ' MsgBox(hasta)
        nombre = lectorMetasCotizador(3)
        ' MsgBox(nombre)
        puesto = lectorMetasCotizador(4)
        'MsgBox(puesto)
        tel = lectorMetasCotizador(5)
        '  MsgBox(tel)
        correo = lectorMetasCotizador(6)
        'MsgBox(correo)
        emp = lectorMetasCotizador(7)
        ' MsgBox(emp)
        dom = lectorMetasCotizador(8)
        ' MsgBox(dom)
        cve = lectorMetasCotizador(17)
        'MsgBox(cve)
        cotizo = lectorMetasCotizador(18)
        ' MsgBox(cotizo)
        lugar = lectorMetasCotizador(19)
        ' MsgBox(lugar)
        moneda = lectorMetasCotizador(20)
        'MsgBox(moneda)
        pago = lectorMetasCotizador(21)
        'MsgBox(pago)
        modalidad = lectorMetasCotizador(22)
        'MsgBox(modalidad)
        obser = lectorMetasCotizador(23)
        ' MsgBox(obser)
        calmetho = lectorMetasCotizador(24)
        'MsgBox(calmetho)
        services = lectorMetasCotizador(25)
        ' MsgBox(services)
        domFac = lectorMetasCotizador(26)

        rfc = lectorMetasCotizador(27)
        correoEla = lectorMetasCotizador(28)
        depto = lectorMetasCotizador(29)
        entrega = "-"
        lectorMetasCotizador.Close()
        'MsgBox(rfc)
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexionMetasCotizador
        Adaptador.SelectCommand.CommandText = "cotLIMS4"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@numCot", SqlDbType.VarChar)
        Dim param2 = New SqlParameter("@fechaDesde", SqlDbType.Date)
        Dim param3 = New SqlParameter("@fechaHasta", SqlDbType.Date)
        Dim param4 = New SqlParameter("@nombre", SqlDbType.VarChar)
        Dim param5 = New SqlParameter("@puesto", SqlDbType.VarChar)
        Dim param6 = New SqlParameter("@telefono", SqlDbType.VarChar)
        Dim param8 = New SqlParameter("@correo", SqlDbType.VarChar)
        Dim param9 = New SqlParameter("@com", SqlDbType.VarChar)
        Dim param10 = New SqlParameter("@dom", SqlDbType.VarChar)
        Dim param11 = New SqlParameter("@cveElaboro", SqlDbType.Int)
        Dim param12 = New SqlParameter("@elaborocot", SqlDbType.VarChar)
        Dim param13 = New SqlParameter("@correoElaboro", SqlDbType.VarChar)
        Dim param14 = New SqlParameter("@depto", SqlDbType.VarChar)
        Dim param15 = New SqlParameter("@lugar", SqlDbType.VarChar)
        Dim param16 = New SqlParameter("@moneda", SqlDbType.VarChar)
        Dim param17 = New SqlParameter("@pago", SqlDbType.VarChar)
        'Dim param18 = New SqlParameter("@entrega", SqlDbType.VarChar)
        Dim param19 = New SqlParameter("@modalidad", SqlDbType.VarChar)
        Dim param20 = New SqlParameter("@obser", SqlDbType.VarChar)
        Dim param21 = New SqlParameter("@calMetodo", SqlDbType.VarChar)
        Dim param22 = New SqlParameter("@serDescripcion", SqlDbType.VarChar)
        Dim param23 = New SqlParameter("@domFactura", SqlDbType.VarChar)
        Dim param24 = New SqlParameter("@rfc", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param3.Direction = ParameterDirection.Input
        param4.Direction = ParameterDirection.Input
        param5.Direction = ParameterDirection.Input
        param6.Direction = ParameterDirection.Input
        'param7.Direction = ParameterDirection.Input
        param8.Direction = ParameterDirection.Input
        param9.Direction = ParameterDirection.Input
        param10.Direction = ParameterDirection.Input
        param11.Direction = ParameterDirection.Input
        param12.Direction = ParameterDirection.Input
        param13.Direction = ParameterDirection.Input
        param14.Direction = ParameterDirection.Input
        param15.Direction = ParameterDirection.Input
        param16.Direction = ParameterDirection.Input
        param17.Direction = ParameterDirection.Input
        'param18.Direction = ParameterDirection.Input
        param19.Direction = ParameterDirection.Input
        param20.Direction = ParameterDirection.Input
        param21.Direction = ParameterDirection.Input
        param22.Direction = ParameterDirection.Input
        param23.Direction = ParameterDirection.Input
        param24.Direction = ParameterDirection.Input
        param1.Value = COT
        param2.Value = desde
        param3.Value = hasta
        param4.Value = nombre
        param5.Value = puesto
        param6.Value = tel
        'param7.Value = ext
        param8.Value = correo
        param9.Value = emp
        param10.Value = dom
        param11.Value = cve
        param12.Value = cotizo
        param13.Value = correoEla
        param14.Value = depto
        param15.Value = lugar
        param16.Value = moneda
        param17.Value = pago
        'param18.Value = entrega
        param19.Value = modalidad
        param20.Value = obser
        param21.Value = calmetho
        param22.Value = services
        param23.Value = domFac
        param24.Value = rfc
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)
        Adaptador.SelectCommand.Parameters.Add(param3)
        Adaptador.SelectCommand.Parameters.Add(param4)
        Adaptador.SelectCommand.Parameters.Add(param5)
        Adaptador.SelectCommand.Parameters.Add(param6)
        'Adaptador.SelectCommand.Parameters.Add(param7)
        Adaptador.SelectCommand.Parameters.Add(param8)
        Adaptador.SelectCommand.Parameters.Add(param9)
        Adaptador.SelectCommand.Parameters.Add(param10)
        Adaptador.SelectCommand.Parameters.Add(param11)
        Adaptador.SelectCommand.Parameters.Add(param12)
        Adaptador.SelectCommand.Parameters.Add(param13)
        Adaptador.SelectCommand.Parameters.Add(param14)
        Adaptador.SelectCommand.Parameters.Add(param15)
        Adaptador.SelectCommand.Parameters.Add(param16)
        Adaptador.SelectCommand.Parameters.Add(param17)
        'Adaptador.SelectCommand.Parameters.Add(param18)
        Adaptador.SelectCommand.Parameters.Add(param19)
        Adaptador.SelectCommand.Parameters.Add(param20)
        Adaptador.SelectCommand.Parameters.Add(param21)
        Adaptador.SelectCommand.Parameters.Add(param22)
        Adaptador.SelectCommand.Parameters.Add(param23)
        Adaptador.SelectCommand.Parameters.Add(param24)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("numCot", COT)
        Dim p2 As New ReportParameter("fechaDesde", desde)
        Dim p3 As New ReportParameter("fechaHasta", hasta)
        Dim p4 As New ReportParameter("nombre", nombre)
        Dim p5 As New ReportParameter("puesto", puesto)
        Dim p6 As New ReportParameter("telefono", tel)
        'Dim p7 As New ReportParameter("ext", ext)
        Dim p8 As New ReportParameter("correo", correo)
        Dim p9 As New ReportParameter("com", emp)
        Dim p10 As New ReportParameter("dom", dom)
        Dim p11 As New ReportParameter("cveElaboro", cve)
        Dim p12 As New ReportParameter("elaborocot", cotizo)
        Dim p13 As New ReportParameter("correoElaboro", correoEla)
        Dim p14 As New ReportParameter("depto", depto)
        Dim p15 As New ReportParameter("lugar", lugar)
        Dim p16 As New ReportParameter("moneda", moneda)
        Dim p17 As New ReportParameter("pago", pago)
        'Dim p18 As New ReportParameter("entrega", entrega)
        Dim p19 As New ReportParameter("modalidad", modalidad)
        Dim p20 As New ReportParameter("obser", obser)
        Dim p21 As New ReportParameter("calMetodo", calmetho)
        Dim p22 As New ReportParameter("serDescription", services)
        Dim p23 As New ReportParameter("domFac", domFac)
        Dim p24 As New ReportParameter("rfc", rfc)

        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\CotizacionModelo.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17,
                                                             p19, p20, p21, p22, p23, p24})
        FrmReportes.ReportViewer1.RefreshReport()
        FrmReportes.Show()
        conexionMetasCotizador.Close()
    End Sub

    Private Sub DgCot_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCot.RowHeaderMouseClick
        Dim COT As Integer
        COT = Val(dgCot.Rows(e.RowIndex).Cells(0).Value)
        MsgBox(COT)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        ' Dim n As Integer = 0
        Dim desde, hasta As Date
        Dim nombre, puesto, tel, ext, correo, emp, dom, lugar, moneda, cotizo, correoEla, depto,
        pago, entrega, modalidad, obser, calmetho, services, domFac, rfc As String
        Dim cve As Integer
        Dim R As String
        Dim fir As Image
        'Dim name, mfr, model, service, price, subt As String
        R = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, isnull([Department], '-') AS Departament, isnull([Phone], '-') as Phone, isnull([SetupCustomerDetails].[Email], '-') as Email,
        isnull([CompanyName],'-') as CompanyName, [ContAddress1] + ' '+  [ContCity] +', '+ [ContState]+'. ' + [ContCountry] +'. CP '+ [ContZip] AS DomCont, ROW_NUMBER() OVER(ORDER BY PartidaNo ASC) AS Partidad, Cantidad,[DetalleCotizaciones].[EquipId],
        [SetUpEquipment].[EquipmentName]+', '+[Mfr] +', '+[Model] +'. ' + (CASE WHEN  [identificadorInventarioCliente] = '-' COLLATE SQL_Latin1_General_CP1_CI_AS  THEN [identificadorInventarioCliente]  COLLATE SQL_Latin1_General_CP1_CI_AS 
        ELSE [identificadorInventarioCliente] COLLATE SQL_Latin1_General_CP1_CI_AS  END) AS Comparacion,[SetupServices].[ServiceName],[ServiceDescription] +', ' + [TurnAroundTime]+' dias para calibración' as Descrip, [SetupEquipmentServiceMapping].[Price], [SetupEquipmentServiceMapping].[Price] * Cantidad AS sub,
        [idUsuarioAdministrador], [Usuarios].[Nombre], [LugarCondicion].[Descripcon] AS lugar, [MonedaCondicion].[Descripcion] AS moneda, 
        [PagoCondicion].[Descripcion] AS pago, [ModalidadCondicion].[Descripcion] AS modalidad,
        [Cotizaciones].[Observaciones],[CalibrationMethod], [ServiceDescription], [BillAddress1] +' '+ [BillCity] +', '+ [BillState]+'. '+[BillCountry]+' CP '+[BillZip] AS domFac, [TaxIDNo],
        [Usuarios].[Email], [Usuarios].[Depto]
                    from [MetasCotizador].[dbo].[Cotizaciones]
        INNER JOIN [Usuarios] ON [Cotizaciones].[idUsuarioCotizacion] = [Usuarios].[idUsuarioAdministrador]
        INNER JOIN " & servidor & " [SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
        INNER JOIN " & servidor & " [SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                    INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
        INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].[idListaCotizacion] = [ServiciosEnCotizaciones].[idListaCotizacion]
        INNER JOIN " & servidor & " [SetupServices] ON [ServiciosEnCotizaciones].[idServicio] = [SetupServices].[ServicesId]
        INNER JOIN [LugarCondicion] ON [Cotizaciones].[idLugarCondicion] = [LugarCondicion].[idLugarCondicion]
        INNER JOIN [MonedaCondicion] ON [Cotizaciones].[idMonedaCondicion] = [MonedaCondicion].[idMonedaCondicion]
        INNER JOIN [PagoCondicion] ON [Cotizaciones].[idPagoCondicion] = [PagoCondicion].[idPagoCondicion]
        INNER JOIN [TiemposEntregaCondicion] ON [Cotizaciones].[idTiempoEntregaCondicion] = [TiemposEntregaCondicion].[idTiempoEntregaCondicion]
        INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
        INNER JOIN " & servidor & " [SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
        INNER JOIN " & servidor & " [SetupEquipmentServiceMapping] ON [SetUpEquipment].[EquipId] =[SetupEquipmentServiceMapping].[EquipId]
                        WHERE [Cotizaciones].NumCot = '" & COT & "'"
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        'While lectorMetasCotizador.Read()
        lectorMetasCotizador.Read()
        desde = lectorMetasCotizador(1)
        ' MsgBox(desde)
        hasta = lectorMetasCotizador(2)
        ' MsgBox(hasta)
        nombre = lectorMetasCotizador(3)
        ' MsgBox(nombre)
        puesto = lectorMetasCotizador(4)
        'MsgBox(puesto)
        tel = lectorMetasCotizador(5)
        '  MsgBox(tel)
        correo = lectorMetasCotizador(6)
        'MsgBox(correo)
        emp = lectorMetasCotizador(7)
        ' MsgBox(emp)
        dom = lectorMetasCotizador(8)
        ' MsgBox(dom)
        cve = lectorMetasCotizador(17)
        'MsgBox(cve)
        cotizo = lectorMetasCotizador(18)
        ' MsgBox(cotizo)
        lugar = lectorMetasCotizador(19)
        ' MsgBox(lugar)
        moneda = lectorMetasCotizador(20)
        'MsgBox(moneda)
        pago = lectorMetasCotizador(21)
        'MsgBox(pago)
        modalidad = lectorMetasCotizador(22)
        'MsgBox(modalidad)
        obser = lectorMetasCotizador(23)
        ' MsgBox(obser)
        calmetho = lectorMetasCotizador(24)
        'MsgBox(calmetho)
        services = lectorMetasCotizador(25)
        ' MsgBox(services)
        domFac = lectorMetasCotizador(26)

        rfc = lectorMetasCotizador(27)
        correoEla = lectorMetasCotizador(28)
        depto = lectorMetasCotizador(29)
        entrega = "-"
        lectorMetasCotizador.Close()
        'MsgBox(rfc)
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexionMetasCotizador
        Adaptador.SelectCommand.CommandText = "cotLIMS4"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@numCot", SqlDbType.VarChar)
        Dim param2 = New SqlParameter("@fechaDesde", SqlDbType.Date)
        Dim param3 = New SqlParameter("@fechaHasta", SqlDbType.Date)
        Dim param4 = New SqlParameter("@nombre", SqlDbType.VarChar)
        Dim param5 = New SqlParameter("@puesto", SqlDbType.VarChar)
        Dim param6 = New SqlParameter("@telefono", SqlDbType.VarChar)
        Dim param8 = New SqlParameter("@correo", SqlDbType.VarChar)
        Dim param9 = New SqlParameter("@com", SqlDbType.VarChar)
        Dim param10 = New SqlParameter("@dom", SqlDbType.VarChar)
        Dim param11 = New SqlParameter("@cveElaboro", SqlDbType.Int)
        Dim param12 = New SqlParameter("@elaborocot", SqlDbType.VarChar)
        Dim param13 = New SqlParameter("@correoElaboro", SqlDbType.VarChar)
        Dim param14 = New SqlParameter("@depto", SqlDbType.VarChar)
        Dim param15 = New SqlParameter("@lugar", SqlDbType.VarChar)
        Dim param16 = New SqlParameter("@moneda", SqlDbType.VarChar)
        Dim param17 = New SqlParameter("@pago", SqlDbType.VarChar)
        'Dim param18 = New SqlParameter("@entrega", SqlDbType.VarChar)
        Dim param19 = New SqlParameter("@modalidad", SqlDbType.VarChar)
        Dim param20 = New SqlParameter("@obser", SqlDbType.VarChar)
        Dim param21 = New SqlParameter("@calMetodo", SqlDbType.VarChar)
        Dim param22 = New SqlParameter("@serDescripcion", SqlDbType.VarChar)
        Dim param23 = New SqlParameter("@domFactura", SqlDbType.VarChar)
        Dim param24 = New SqlParameter("@rfc", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param3.Direction = ParameterDirection.Input
        param4.Direction = ParameterDirection.Input
        param5.Direction = ParameterDirection.Input
        param6.Direction = ParameterDirection.Input
        'param7.Direction = ParameterDirection.Input
        param8.Direction = ParameterDirection.Input
        param9.Direction = ParameterDirection.Input
        param10.Direction = ParameterDirection.Input
        param11.Direction = ParameterDirection.Input
        param12.Direction = ParameterDirection.Input
        param13.Direction = ParameterDirection.Input
        param14.Direction = ParameterDirection.Input
        param15.Direction = ParameterDirection.Input
        param16.Direction = ParameterDirection.Input
        param17.Direction = ParameterDirection.Input
        'param18.Direction = ParameterDirection.Input
        param19.Direction = ParameterDirection.Input
        param20.Direction = ParameterDirection.Input
        param21.Direction = ParameterDirection.Input
        param22.Direction = ParameterDirection.Input
        param23.Direction = ParameterDirection.Input
        param24.Direction = ParameterDirection.Input
        param1.Value = COT
        param2.Value = desde
        param3.Value = hasta
        param4.Value = nombre
        param5.Value = puesto
        param6.Value = tel
        'param7.Value = ext
        param8.Value = correo
        param9.Value = emp
        param10.Value = dom
        param11.Value = cve
        param12.Value = cotizo
        param13.Value = correoEla
        param14.Value = depto
        param15.Value = lugar
        param16.Value = moneda
        param17.Value = pago
        'param18.Value = entrega
        param19.Value = modalidad
        param20.Value = obser
        param21.Value = calmetho
        param22.Value = services
        param23.Value = domFac
        param24.Value = rfc
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)
        Adaptador.SelectCommand.Parameters.Add(param3)
        Adaptador.SelectCommand.Parameters.Add(param4)
        Adaptador.SelectCommand.Parameters.Add(param5)
        Adaptador.SelectCommand.Parameters.Add(param6)
        'Adaptador.SelectCommand.Parameters.Add(param7)
        Adaptador.SelectCommand.Parameters.Add(param8)
        Adaptador.SelectCommand.Parameters.Add(param9)
        Adaptador.SelectCommand.Parameters.Add(param10)
        Adaptador.SelectCommand.Parameters.Add(param11)
        Adaptador.SelectCommand.Parameters.Add(param12)
        Adaptador.SelectCommand.Parameters.Add(param13)
        Adaptador.SelectCommand.Parameters.Add(param14)
        Adaptador.SelectCommand.Parameters.Add(param15)
        Adaptador.SelectCommand.Parameters.Add(param16)
        Adaptador.SelectCommand.Parameters.Add(param17)
        'Adaptador.SelectCommand.Parameters.Add(param18)
        Adaptador.SelectCommand.Parameters.Add(param19)
        Adaptador.SelectCommand.Parameters.Add(param20)
        Adaptador.SelectCommand.Parameters.Add(param21)
        Adaptador.SelectCommand.Parameters.Add(param22)
        Adaptador.SelectCommand.Parameters.Add(param23)
        Adaptador.SelectCommand.Parameters.Add(param24)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("numCot", COT)
        Dim p2 As New ReportParameter("fechaDesde", desde)
        Dim p3 As New ReportParameter("fechaHasta", hasta)
        Dim p4 As New ReportParameter("nombre", nombre)
        Dim p5 As New ReportParameter("puesto", puesto)
        Dim p6 As New ReportParameter("telefono", tel)
        'Dim p7 As New ReportParameter("ext", ext)
        Dim p8 As New ReportParameter("correo", correo)
        Dim p9 As New ReportParameter("com", emp)
        Dim p10 As New ReportParameter("dom", dom)
        Dim p11 As New ReportParameter("cveElaboro", cve)
        Dim p12 As New ReportParameter("elaborocot", cotizo)
        Dim p13 As New ReportParameter("correoElaboro", correoEla)
        Dim p14 As New ReportParameter("depto", depto)
        Dim p15 As New ReportParameter("lugar", lugar)
        Dim p16 As New ReportParameter("moneda", moneda)
        Dim p17 As New ReportParameter("pago", pago)
        'Dim p18 As New ReportParameter("entrega", entrega)
        Dim p19 As New ReportParameter("modalidad", modalidad)
        Dim p20 As New ReportParameter("obser", obser)
        Dim p21 As New ReportParameter("calMetodo", calmetho)
        Dim p22 As New ReportParameter("serDescription", services)
        Dim p23 As New ReportParameter("domFac", domFac)
        Dim p24 As New ReportParameter("rfc", rfc)

        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\CotizacionModelo.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17,
                                                             p19, p20, p21, p22, p23, p24})
        FrmReportes.ReportViewer1.RefreshReport()
        FrmReportes.Show()
        conexionMetasCotizador.Close()
    End Sub

    'Private Sub DGCotizaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizaciones.CellClick
    '    If e.ColumnIndex = 0 Then
    '        For Each fila In DGCotizaciones.Rows
    '            fila.Cells(21).Value = fila.Cells(15).Value * fila.Cells(20).Value
    '            If Convert.ToBoolean(fila.Cells(0).Value) = True Then
    '                fila.Cells(0).Value = False
    '            End If
    '            If Convert.ToBoolean(fila.Cells(0).Value) = True Then
    '                MsgBox(fila.Cells(0).Value)
    '            End If
    '        Next
    '    End If
    'End Sub
End Class