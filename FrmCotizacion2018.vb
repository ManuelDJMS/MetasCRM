Imports System.Data.SqlClient
Public Class FrmCotizacion2018
    Dim R As String
    Dim clave1 As String
    Private Sub FrmCotizacion2018_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email FROM SetupCustomerDetails"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Private Sub txtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged, TextBox1.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email FROM SetupCustomerDetails where CustomerId like '" & txtClave.Text & "%'
                and Organization like '" & txtNombreE.Text & "%' and Email like '" & TextCorreo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub
    Private Sub DGEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGEmpresas.RowHeaderMouseClick
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            clave1 = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            empresa = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId=SetUpEquipment.EquipId where CustomerId=" & clave1
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al cargar seleccionar la empresa", Err.Number, cadena)
        End Try
    End Sub
    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where CustomerId=" & clave1 & " and ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
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

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where CustomerId=" & clave1 & " and ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
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
    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email FROM SetupCustomerDetails where CustomerId like '" & txtClave.Text & "%'
                and Organization like '" & txtNombreE.Text & "%' and Email like '" & TextCorreo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
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
    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where CustomerId=" & clave1 & " and ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
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
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
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
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email FROM SetupCustomerDetails where CustomerId like '" & txtClave.Text & "%'
                and Organization like '" & txtNombreE.Text & "%' and Email like '" & TextCorreo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar la empresa", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click

        Dim seleccionado As Boolean
        Dim b As Boolean
        If DGCotizaciones.Rows.Count < 2 Then
            MsgBox("No hay articulos para Cotizar", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
            For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
                seleccionado = DGCotizaciones.Rows(i).Cells(0).Value
                If seleccionado = True Then
                    b = True
                    Exit For
                Else
                    b = False
                End If
            Next
            '----------------------------------------------------------------------------------------------------
            If b = True Then
                For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGCotizaciones.Rows(i).Cells(0).Value
                    If seleccionado = True Then
                        MetodoLIMS()
                        comandoLIMS = conexionLIMS.CreateCommand
                        R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price from  SetupCustomerEquipmentMapping 
                            inner join SetUpEquipment on SetupCustomerEquipmentMapping.EquipId=SetUpEquipment.EquipId inner join SetupEquipmentServiceMapping on  
                            SetupEquipment.EquipId=SetupEquipmentServiceMapping.EquipId where CustomerId=" & clave1 & "and SetUpEquipment.ItemNumber='" & DGCotizaciones.Rows(i).Cells(1).Value & "'"
                        comandoLIMS.CommandText = R
                        lectorLIMS = comandoLIMS.ExecuteReader
                        lectorLIMS.Read()
                        frmEdicionCot2018_2019.DGCotizaciones.Rows.Add(i + 1, lectorLIMS(2), lectorLIMS(7), 1, lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(8), 0, lectorLIMS(1))
                    End If
                Next
                frmEdicionCot2018_2019.Show()

            Else
                MsgBox("No ha seleccionado ningún artículo", MsgBoxStyle.Critical, "Error del sistema.")
            End If
        End If
        origen = "LIMS"

    End Sub

    Private Sub TextArticulo_TextChanged(sender As Object, e As EventArgs) Handles TextArticulo.TextChanged
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT CustomerId, SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from  SetupCustomerEquipmentMapping inner join SetUpEquipment on 
                 SetupCustomerEquipmentMapping.EquipId = SetUpEquipment.EquipId where CustomerId=" & clave1 & " and ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
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