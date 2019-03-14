Imports System.IO
Imports System.Data.SqlClient
Public Class FrmLoginAdminGeneral
    Public variable As String
    Dim version As String
    Private Sub FrmLoginAdminGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConexionGlobal2()
        ''Solamente Usuarios que tengan autorizacion de Administradores Generales de sistemas
        LeerArchivo()
    End Sub
    Sub LeerArchivo()
        Dim leer As New StreamReader("\\10.10.10.7\Public-2\INSTALACIONES COTIZADOR\Metas Cotizador\version.txt")
        Try
            'Se abre el txt para ver la version
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                variable = (linea)
            End While
            leer.Close()
            If Not variable = lbVersion.Text Then 'Verifica si la version es igual a la del txt
                MsgBox("Existe una nueva actualizacion", MsgBoxStyle.Exclamation, "METAS COTIZADOR")
                Dim OpenFileDialog As New OpenFileDialog
                Process.Start("\\10.10.10.7\Public-2\INSTALACIONES COTIZADOR\Metas Cotizador\MetasCotizador.msp")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        logearUsuariosAdministradoresSistemas(txtUsuario.Text, txtContrasena.Text)

        'If (rbAdministradorSistemas.Checked) Then
        '    logearUsuariosAdministradoresSistemas(txtUsuario.Text, txtContrasena.Text)
        'ElseIf (rbAdministrador.Checked) Then
        '    logearAdmin(txtUsuario.Text, txtContrasena.Text)
        'ElseIf (rbUsuariosCotizaciones.Checked) Then
        '    logearCotizador(txtUsuario.Text, txtContrasena.Text)
        'End If
        ''FrmEmpresas.ShowDialog()
    End Sub

    Sub logearUsuariosAdministradoresSistemas(ByVal Username As String, ByRef Contrasena As String)
        Try
            MetodoMetasInf2019()
            'conexion2.Open()
            Dim Comando1 As New SqlCommand("select [Login], Rol, NombreUsuario from Usuarios where [Login]= @UserName and [Password] = @Pass", conexion2019)
            Comando1.Parameters.AddWithValue("Username", Username)
            Comando1.Parameters.AddWithValue("Pass", Contrasena)
            Dim adapter1 As New SqlDataAdapter(Comando1)
            Dim datatable1 As New DataTable
            adapter1.Fill(datatable1)
            If (datatable1.Rows.Count = 1) Then
                Me.Hide()
                If (datatable1.Rows(0)(1).ToString = "Empleado") Then
                    Dim Admin As New FrmHOME
                    Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
                    Admin.txtRol.Text = "Sistema Cotizador"
                    Admin.ShowDialog()
                ElseIf (datatable1.Rows(0)(1).ToString = "Administrador") Then
                    Dim Admin As New FrmHOME 'Validar otra interfaz solo con datos que puede manejar Sandra
                    Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
                    Admin.txtRol.Text = "Administrador General del Sistema"
                    Admin.ShowDialog()
                Else
                    Dim Admin As New FrmUsuariosCotizadores  ' Manejar otra interaz igual a HOME pero solo de COTS
                    Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
                    Admin.ShowDialog()

                End If
            Else
                MessageBox.Show("Usuario y/o Contraseña son Incorrectos")
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            conexion2019.Close()
        End Try
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    logearUsuariosAdministradoresSistemas(txtUsuario.Text, txtContrasena.Text)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try

    End Sub

    '
    'Sub logearUsuariosAdministradoresSistemas(ByVal Username As String, ByRef Contrasena As String)
    '    Try
    '        MetodoLIMS()
    '        'conexion2.Open()
    '        Dim Comando1 As New SqlCommand("select UserName, RoleName, Fname, Mname, Lname from UserMaster where UserName= @UserName and Password = @Pass", conexionLIMS)
    '        Comando1.Parameters.AddWithValue("Username", Username)
    '        Comando1.Parameters.AddWithValue("Pass", Contrasena)
    '        Dim adapter1 As New SqlDataAdapter(Comando1)
    '        Dim datatable1 As New DataTable
    '        adapter1.Fill(datatable1)
    '        If (datatable1.Rows.Count = 1) Then
    '            Me.Hide()
    '            If (datatable1.Rows(0)(1).ToString = "ROL00000001") Then
    '                Dim Admin As New FrmHOME
    '                Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString & " " & datatable1.Rows(0)(3).ToString & " " & datatable1.Rows(0)(4).ToString
    '                Admin.txtRol.Text = "Administrador General de Sistemas"
    '                Admin.ShowDialog()
    '            ElseIf (datatable1.Rows(0)(1).ToString = "ROL00000002") Then
    '                Dim Admin As New FrmHOME 'Validar otra interfaz solo con datos que puede manejar Sandra
    '                Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString & " " & datatable1.Rows(0)(3).ToString & " " & datatable1.Rows(0)(4).ToString
    '                Admin.txtRol.Text = "Administrador de Ventas"
    '                Admin.ShowDialog()
    '            Else
    '                Dim Admin As New FrmUsuariosCotizadores  ' Manejar otra interaz igual a HOME pero solo de COTS
    '                Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
    '                Admin.ShowDialog()

    '            End If
    '        Else
    '            MessageBox.Show("Usuario y/o Contraseña son Incorrectos")
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.Message)
    '    Finally
    '        conexionLIMS.Close()
    '    End Try
    'End Sub
    '


    'Sub logearAdmin(ByVal Username As String, ByRef Contrasena As String)
    '    Try
    '        conexion.Open()
    '        Dim Comando1 As New SqlCommand("select Username, TipoUsuario, Nombre from UsuariosAdministradores where Username= @Username and Contrasena = @Pass", conexion)
    '        Comando1.Parameters.AddWithValue("Username", Username)
    '        Comando1.Parameters.AddWithValue("Pass", Contrasena)
    '        MsgBox("Usuario: " & Username)
    '        MsgBox("Contrasena: " & Contrasena)
    '        Dim adapter1 As New SqlDataAdapter(Comando1)
    '        Dim datatable1 As New DataTable
    '        adapter1.Fill(datatable1)
    '        If (datatable1.Rows.Count = 1) Then
    '            Me.Hide()
    '            If (datatable1.Rows(0)(1).ToString = "UsuarioAdministrador") Then
    '                Dim Admin As New FrmLoginAdminVentas
    '                Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
    '                Admin.ShowDialog()
    '                'txtUsuario.Text = ""
    '                'txtContrasena.Text = ""

    '                'rbAdministradorSistemas.Checked = False
    '                'rbAdministrador.Checked = False
    '                'rbUsuariosCotizaciones.Checked = False
    '            Else
    '                MessageBox.Show("Usuario y/o Contraseña son Incorrectos")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.Message)
    '    Finally
    '        conexion.Close()
    '    End Try
    'End Sub


    'Sub logearCotizador(ByVal Username As String, ByRef Contrasena As String)
    '    Try
    '        conexion.Open()
    '        Dim Comando1 As New SqlCommand("select Username, TipoUsuario, Nombre from UsuariosCotizaciones where Username= @Username and Contrasena = @Pass", conexion)
    '        Comando1.Parameters.AddWithValue("Username", Username)
    '        Comando1.Parameters.AddWithValue("Pass", Contrasena)
    '        MsgBox("Usuario: " & Username)
    '        MsgBox("Contrasena: " & Contrasena)
    '        Dim adapter1 As New SqlDataAdapter(Comando1)
    '        Dim datatable1 As New DataTable
    '        adapter1.Fill(datatable1)
    '        If (datatable1.Rows.Count = 1) Then
    '            Me.Hide()
    '            If (datatable1.Rows(0)(1).ToString = "UsuarioCotizaciones") Then
    '                Dim Admin As New FrmUsuariosCotizadores
    '                Admin.txtNombreAdmin.Text = datatable1.Rows(0)(2).ToString
    '                Admin.ShowDialog()
    '                'txtUsuario.Text = ""
    '                'txtContrasena.Text = ""

    '                'rbAdministradorSistemas.Checked = False
    '                'rbAdministrador.Checked = False
    '                'rbUsuariosCotizaciones.Checked = False
    '            Else
    '                MessageBox.Show("Usuario y/o Contraseña son Incorrectos")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.Message)
    '    Finally
    '        conexion.Close()
    '    End Try
    'End Sub

End Class