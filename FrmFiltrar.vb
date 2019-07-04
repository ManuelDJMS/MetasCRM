Public Class FrmFiltrar
    Private Sub FrmFiltrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            Dim R As String
            R = "select x1.CustomerId, FirstName, (MiddleName + ' ' + LastName) as Apellidos, CompanyName, CustAccountNo, Email, ContAddress1, ContZip from [SetupCustomerDetails] x1 
                 inner join [SetupCustomerAddressDtls] x2 on x1.CustomerId=x2.CustomerId"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                dgEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(7))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
    Private Sub TextEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TextEmpresa.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            dgEmpresas.Rows.Clear()
            Dim R As String
            R = "select x1.CustomerId, FirstName, (MiddleName + ' ' + LastName) as Apellidos, CompanyName, CustAccountNo, Email, ContAddress1, ContZip from [SetupCustomerDetails] x1 
                 inner join [SetupCustomerAddressDtls] x2 on x1.CustomerId=x2.CustomerId where CompanyName like '" & TextEmpresa.Text & "%' and x1.CustomerId like '" & txtidCliente.Text &
                 "%' and Email like '" & TextCorreo.Text & "%' and ContAddress1 like '" & TextDireccion.Text & "%' and ContZip like '" & TextCP.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                dgEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(7))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TxtidCliente_TextChanged(sender As Object, e As EventArgs) Handles txtidCliente.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            dgEmpresas.Rows.Clear()
            Dim R As String
            R = "select x1.CustomerId, FirstName, (MiddleName + ' ' + LastName) as Apellidos, CompanyName, CustAccountNo, Email, ContAddress1, ContZip from [SetupCustomerDetails] x1 
                 inner join [SetupCustomerAddressDtls] x2 on x1.CustomerId=x2.CustomerId where CompanyName like '" & TextEmpresa.Text & "%' and x1.CustomerId like '" & txtidCliente.Text &
                 "%' and Email like '" & TextCorreo.Text & "%' and ContAddress1 like '" & TextDireccion.Text & "%' and ContZip like '" & TextCP.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                dgEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(7))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextCorreo.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            dgEmpresas.Rows.Clear()
            Dim R As String
            R = "select x1.CustomerId, FirstName, (MiddleName + ' ' + LastName) as Apellidos, CompanyName, CustAccountNo, Email, ContAddress1, ContZip from [SetupCustomerDetails] x1 
                 inner join [SetupCustomerAddressDtls] x2 on x1.CustomerId=x2.CustomerId where CompanyName like '" & TextEmpresa.Text & "%' and x1.CustomerId like '" & txtidCliente.Text &
                 "%' and Email like '" & TextCorreo.Text & "%' and ContAddress1 like '" & TextDireccion.Text & "%' and ContZip like '" & TextCP.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                dgEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(7))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextDireccion_TextChanged(sender As Object, e As EventArgs) Handles TextDireccion.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            dgEmpresas.Rows.Clear()
            Dim R As String
            R = "select x1.CustomerId, FirstName, (MiddleName + ' ' + LastName) as Apellidos, CompanyName, CustAccountNo, Email, ContAddress1, ContZip from [SetupCustomerDetails] x1 
                 inner join [SetupCustomerAddressDtls] x2 on x1.CustomerId=x2.CustomerId where CompanyName like '" & TextEmpresa.Text & "%' and x1.CustomerId like '" & txtidCliente.Text &
                 "%' and Email like '" & TextCorreo.Text & "%' and ContAddress1 like '" & TextDireccion.Text & "%' and ContZip like '" & TextCP.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                dgEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(7))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextCP_TextChanged(sender As Object, e As EventArgs) Handles TextCP.TextChanged
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            dgEmpresas.Rows.Clear()
            Dim R As String
            R = "select x1.CustomerId, FirstName, (MiddleName + ' ' + LastName) as Apellidos, CompanyName, CustAccountNo, Email, ContAddress1, ContZip from [SetupCustomerDetails] x1 
                 inner join [SetupCustomerAddressDtls] x2 on x1.CustomerId=x2.CustomerId where CompanyName like '" & TextEmpresa.Text & "%' and x1.CustomerId like '" & txtidCliente.Text &
                 "%' and Email like '" & TextCorreo.Text & "%' and ContAddress1 like '" & TextDireccion.Text & "%' and ContZip like '" & TextCP.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                dgEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6), lectorLIMS(7))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Dispose()
    End Sub

    Private Sub DgEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEmpresas.RowHeaderMouseClick
        Dim correos As String
        correos = dgEmpresas.Rows(e.RowIndex).Cells(5).Value.ToString()
        'MsgBox()
        'Dim vCadena As String = "Paseo del Norte #5 300-A Guadalajara Technology Park Carretera a Nogales km 12,5 San Juan de Ocotán"
        Dim vColeccion() As String = correos.Split(";")
        If vColeccion.Length > 1 Then
            For i = 0 To vColeccion.Length - 1
                FrmFiltarCampo.dgEmpresas.Rows.Add(False, vColeccion(i))
            Next
            empresa = dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            FrmFiltarCampo.Show()
        Else
            bancorreo = 1
            empresa = dgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
            FrmCompletarOV.Show()

        End If

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
    End Sub
End Class