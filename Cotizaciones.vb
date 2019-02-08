Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Cotizaciones
    Dim contador As Integer
    Dim contadorAux As String

    Private Sub Cotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConexionGlobalLocal()
        'consultaGeneralDinamica()
        'consultaLugarCondicion()
        'consultaPreciosCondicion()
        'consultaTerminosPago()
        'consultaTiemposEntrega()
        'consultaModalidad()
        txtReferencia.Enabled = True
        txtObservaciones.Enabled = True

        cboTerminos.Text = "--Selecciona--"
        cboLugar.Text = "--Selecciona--"
        cboTiempo.Text = "--Selecciona--"
        cboModalidad.Text = "--Selecciona--"
        cboMoneda.Text = "--Selecciona--"

    End Sub
    Public Sub consultaGeneralDinamica()
        'DG1.Rows.Clear()
        'Dim R As String
        ''R = "select idCat, NoCatalogo, 
        ''    Instrumento, Magnitud, Alcance, 
        ''    PuntosdeCalibracion, MetododeCalibracion, 
        ''    PatronesReferencia, CapacidadMedicion, PrecioBase,
        ''    PrecioOpcion, PrecioBUrgente, PrecioBCampo from CatalogoCalibraciones"
        'Dim comando As New SqlCommand(R, conexion)
        'comando.CommandType = CommandType.Text
        'Dim da As New SqlDataAdapter(comando)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'DG1.DataSource = dt

        'For Each fila As DataGridViewRow In DG1.Rows
        '    fila.Cells("NoCatalogo").Style.BackColor = Color.Azure
        'Next
    End Sub

    Private Sub txtCatalogo_TextChanged(sender As Object, e As EventArgs) Handles txtCatalogo.TextChanged
        Dim R As String
        R = "select idCat, NoCatalogo, Instrumento, Magnitud, Alcance, PuntosdeCalibracion, MetododeCalibracion, PatronesReferencia, CapacidadMedicion, PrecioBase, PrecioOpcion, PrecioBUrgente, PrecioBCampo from CatalogoCalibraciones where CatalogoCalibraciones.NoCatalogo LIKE '%' + @NombreCatalogo + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreCatalogo", txtCatalogo.Text)

        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable

        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            DG1.DataSource = Nothing
        Else
            DG1.DataSource = dt
            txtCatalogo.Enabled = True
            txtInstrumento.Text = ""
        End If
        For Each fila As DataGridViewRow In DG1.Rows
            fila.Cells("NoCatalogo").Style.BackColor = Color.Azure
        Next
    End Sub

    Private Sub txtInstrumento_TextChanged(sender As Object, e As EventArgs) Handles txtInstrumento.TextChanged
        Dim R As String
        R = "select idCat, NoCatalogo, Instrumento, Magnitud, Alcance, PuntosdeCalibracion, MetododeCalibracion, PatronesReferencia, CapacidadMedicion, PrecioBase, PrecioOpcion, PrecioBUrgente, PrecioBCampo from CatalogoCalibraciones where CatalogoCalibraciones.Instrumento LIKE '%' + @NombreInstrumento + '%'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@NombreInstrumento", txtInstrumento.Text)

        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable

        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            DG1.DataSource = Nothing
        Else
            DG1.DataSource = dt
            txtInstrumento.Enabled = True
            txtCatalogo.Text = ""
        End If
        For Each fila As DataGridViewRow In DG1.Rows
            fila.Cells("NoCatalogo").Style.BackColor = Color.Azure
        Next
    End Sub

    Private Sub DG1_DoubleClick(sender As Object, e As EventArgs) Handles DG1.DoubleClick
        Dim cuenta As Integer
        cuenta = 1
        Try
            If Convert.ToInt32(DG1.CurrentCell.Value) = False Then
                MsgBox("Selecciona solo la CLAVE del catalogo", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Selecciona solo la CLAVE del catalogo")
            End If
        Catch ex As Exception
            contador = contador + 1
            txtContador.Text = contador
            txtParametro.Text = DG1.CurrentCell.Value.ToString()
            DG2.Rows.Add(txtContador.Text, txtParametro.Text, cuenta)

            For Each fila As DataGridViewRow In DG2.Rows
                fila.Cells("CatalogoServ").Style.BackColor = Color.Azure
            Next
        End Try
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG1.EditingControlShowing
        Try
            RemoveHandler e.Control.KeyPress, AddressOf typeOnlynumbers
            AddHandler e.Control.KeyPress, AddressOf typeOnlynumbers

        Catch ex As Exception
            MessageBox.Show("Error something went wrong!!")
        End Try
    End Sub
    Sub typeOnlynumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) >= 33 And Asc(e.KeyChar) <= 47 Or
            Asc(e.KeyChar) >= 58 Then
            e.Handled = True
        End If

    End Sub
    'Public Sub consultaLugarCondicion()
    '    Dim R As String
    '    R = "select Descripcon from LugarCondicion"
    '    Dim comando As New SqlCommand(R, conexion)
    '    Dim lector As SqlDataReader
    '    lector = comando.ExecuteReader
    '    While lector.Read()
    '        cboLugar.Items.Add(lector(0))
    '    End While
    '    lector.Close()
    'End Sub
    'Public Sub consultaPreciosCondicion()
    '    Dim R As String
    '    R = "select Descripcion from MonedaCondicion"
    '    Dim comando As New SqlCommand(R, conexion)
    '    Dim lector As SqlDataReader
    '    lector = comando.ExecuteReader
    '    While lector.Read()
    '        cboMoneda.Items.Add(lector(0))
    '    End While
    '    lector.Close()
    'End Sub
    'Public Sub consultaTerminosPago()
    '    Dim R As String
    '    R = "select Descripcion from PagoCondicion"
    '    Dim comando As New SqlCommand(R, conexion)
    '    Dim lector As SqlDataReader
    '    lector = comando.ExecuteReader
    '    While lector.Read()
    '        cboTerminos.Items.Add(lector(0))
    '    End While
    '    lector.Close()
    'End Sub
    Public Sub consultaTiemposEntrega()
        Dim R As String
        R = "select Descripcion from TiemposEntregaCondicion"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read()
            cboTiempo.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub
    Public Sub consultaModalidad()
        Dim R As String
        R = "select Descripcion from ModalidadCondicion"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read()
            cboModalidad.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub txtCorreoBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreoBusqueda.KeyDown

    End Sub

    Private Sub txtCorreoBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoBusqueda.KeyPress

    End Sub

    Private Sub txtCorreoBusqueda_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCorreoBusqueda.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim vacio As String = "Campo vacio"
            Dim R, R2 As String
            'txtNombreEmpresa.Enabled = True
            R = "select * from Contactos where Contactos.Email LIKE '%" & txtCorreoBusqueda.Text & "%'"

            'select Empresas.Compania From Empresas inner Join RelacionContactosEmpresas On Empresas.Clavempresa= RelacionContactosEmpresas.idEmpresa inner Join Contactos on Contactos.ClaveContacto= RelacionContactosEmpresas.idContacto where Contactos.ClaveContacto ='1249'and RelacionContactosEmpresas.Confirma=1
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader

            If lector.Read() Then
                If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
                    txtClaveContacto.Text = vacio
                Else
                    txtClaveContacto.Text = lector(0)
                    txtCompania.Enabled = True
                End If
                If ((lector(1) Is DBNull.Value) OrElse (lector(1) Is Nothing)) Then
                    txtNombreContacto.Text = vacio
                Else
                    txtNombreContacto.Text = lector(1)
                End If

                If ((lector(2) Is DBNull.Value) OrElse (lector(2) Is Nothing)) Then
                    txtApellido.Text = vacio
                Else
                    txtApellido.Text = lector(2)
                End If

                If ((lector(4) Is DBNull.Value) OrElse (lector(4) Is Nothing)) Then
                    txtTelefonoContacto.Text = vacio
                Else
                    txtTelefonoContacto.Text = lector(4)
                End If
                If ((lector(5) Is DBNull.Value) OrElse (lector(5) Is Nothing)) Then
                    txtExtContacto.Text = vacio
                Else
                    txtExtContacto.Text = lector(5)
                End If

                If ((lector(7) Is DBNull.Value) OrElse (lector(7) Is Nothing)) Then
                    txtCorreoContacto.Text = vacio
                Else
                    txtCorreoContacto.Text = lector(7)
                End If

                lector.Close()
            Else
                MsgBox("No hay registros", MsgBoxStyle.Critical)
                lector.Close()
            End If
            txtCompania.Items.Clear()
            R2 = "select Empresas.Compania from Empresas 
                    inner join RelacionContactosEmpresas on Empresas.Clavempresa= RelacionContactosEmpresas.idEmpresa 
                    inner join Contactos on Contactos.ClaveContacto= RelacionContactosEmpresas.idContacto 
                    where RelacionContactosEmpresas.Confirma=1 and Contactos.ClaveContacto=" & txtClaveContacto.Text & ""
            Dim comandoR As New SqlCommand(R2, conexionMetasCotizador)
            Dim lectorR As SqlDataReader
            lectorR = comandoR.ExecuteReader()
            txtCompania.Text = "---SELECCIONA LA EMPRESA---"
            While lectorR.Read()
                txtCompania.Items.Add(lectorR(0))
            End While
            lectorR.Close()

        End If
    End Sub

    Private Sub txtCompania_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCompania.SelectedIndexChanged
        Dim R As String
        R = "select Empresas.Compania, Empresas.Clavempresa, 
            Empresas.RFC, Empresas.DomicilioConsig, 
            Empresas.CiudadConsig, Empresas.EdoConsig
            from Empresas where Empresas.Compania='" & txtCompania.Text & "'"
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader()
        lector.Read()
        txtC.Text = lector(0)
        txtClaveCompania.Text = lector(1)
        txtRFC.Text = lector(2)
        txtDomicilioConsig.Text = lector(3)
        txtCiudadConsig.Text = lector(4)
        txtEstadoConsig.Text = lector(5)

        lector.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DG2.Rows.Clear()
        contador = 0
        contadorAux = ""
        txtContador.Text = ""
    End Sub

    Private Sub cboTerminos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTerminos.SelectedIndexChanged
        MsgBox(cboTerminos.Text, MsgBoxStyle.Information)
    End Sub
End Class