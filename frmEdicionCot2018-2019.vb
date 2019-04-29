Imports System.Data.SqlClient
Public Class frmEdicionCot2018_2019
    Dim R As String

    Private Sub frmEdicionCot2018_2019_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "select [SetupCustomerDetails].CustomerId, isnull(Organization,'-'), isnull(concat(FirstName, ' ' , MiddleName, ' ', LastName),'-') as Nombre, 
                isnull(ContAddress1,'-'), isnull(ContCity,'-'), isnull(ContState,'-'), isnull(Phone,'-'), isnull(Email,'-') 
                from [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] inner join  
                SetupCustomerAddressDtls on [SetupCustomerDetails].CustomerId=[SetupCustomerAddressDtls].CustomerId
                where [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].CustomerId=" & empresa
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            lectorLIMS.Read()
            txtCveContacto.Text = lectorLIMS(0)
            txtNombreEmpresa.Text = lectorLIMS(1)
            txtNombreC.Text = lectorLIMS(2)
            txtDomicilio.Text = lectorLIMS(3)
            txtCiudad.Text = lectorLIMS(4)
            txtEstado.Text = lectorLIMS(5)
            txtTelefono.Text = lectorLIMS(6)
            TextCorreo.Text = lectorLIMS(7)
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmEdicionCot2018-2019", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs)
        For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = DGCotizaciones.Rows(i).Cells(0).Value
            If delete = True Then
                Dim row As DataGridViewRow
                row = DGCotizaciones.Rows(i)
                DGCotizaciones.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub btMinimizar_Click(sender As Object, e As EventArgs) Handles btMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click

        'Try
        '    '----------------------------A partir de aqui se busca en LIMS la empresa....si no se agrega-------------------------------------
        '    Dim R As String
        '    Dim empresa As Integer
        '    '//////////////////Aqui se busca la empresa en lims\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        '    MetodoLIMS()
        '    comandoLIMS = conexionLIMS.CreateCommand
        '    R = "select isnull(CustomerId,'-') from SetupCustomerDetails where KeyFiscal='" & txtNumCond.Text & "' or Organization='" & txtNombreEmpresa.Text & "'"
        '    lectorLIMS = comandoLIMS.ExecuteReader
        '    lectorLIMS.Read()
        '    empresa = lectorLIMS(0)
        '    lectorLIMS.Close()
        '    conexionLIMS.Close()
        '    '/////////////////////////////////////////////////////////////////////////////////
        '    If empresa = "-" Then '------------Decision para guardar o no la empresa------------------------
        '        MetodoLIMS()
        '        R = "select "




        '        fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        '        R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
        '            CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & txtNombreEmpresa.Text & "',
        '            " & Val(txtCveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(txtNumCond.Text) & ",
        '            '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & empresa & "," & Val(txtTelefono.Text) & ",
        '            " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
        '        comandoMetasCotizador.CommandText = R
        '        comandoMetasCotizador.ExecuteNonQuery()
        '        'Codigo para guardar en 1Cotizar----------------------------------------------------
        '        For i = 0 To DGCotizaciones.Rows.Count - 2
        '            R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
        '             ID, Punitariocot, Realizado) values (" & DGCotizaciones.Item(2, i).Value & "',
        '            '" & "-" & "'," & Val(DGCotizaciones.Item(3, i).Value) & ",'" & DGCotizaciones.Item(4, i).Value & "',
        '            '" & DGCotizaciones.Item(5, i).Value & "','" & DGCotizaciones.Item(6, i).Value & "','" & DGCotizaciones.Item(8, i).Value & "',
        '            '" & DGCotizaciones.Item(7, i).Value & "'," & Val(DGCotizaciones.Item(10, i).Value) & "," & "0" & ")"
        '            comandoMetasCotizador.CommandText = R
        '            comandoMetasCotizador.ExecuteNonQuery()
        '        Next i
        '    End If
        '    '--------------------------------------------------------------------------------------------------------------------------------

        '    MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)

        '    FrmCotizacion2018.txtClave.Text = ""
        '    FrmCotizacion2018.txtNombreE.Text = ""
        '    FrmCotizacion2018.DGCotizaciones.DataSource = Nothing
        '    FrmCotizacion2018.DGEmpresas.DataSource = Nothing
        '    Me.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("frmEdicionCot2018-2019", "Error al momento de guardar", Err.Number, cadena)
        'End Try
        MsgBox(CbModalidad.Tag.ToString)
    End Sub
End Class