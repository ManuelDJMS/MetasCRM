Public Class FrmHOME
    Private Sub FrmHOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel1, "Consulta y asigna datos dentro de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel2, "Agrega Clientes/Empresas para datos de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel3, "Relaciona los contactos con las empresas existentes, Tu tienes el control ;)")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel3, "Registra posibles contactos para cotizaciones sin registro de cliente")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel4, "Agrega, consulta y aprueba prospectos para cotizaciónes con MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel5, "Genera cotizaciones para los prospectos de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel6, "Registra y consulta los catálogos de calibraciones existentes dentro de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel7, "Genera cotizaciones para los clientes de MetAs")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel8, "Los equipos tambien tienen expediente")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel9, "Realiza y envia cotizaciones preformadas")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(Panel4, "Busca cotizaciones 2018 y exportalas a 2019 como nueva cotización")

    End Sub
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        'Dim Admin As New FrmContactos
        'Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        'Admin.Show()
        MsgBox("Modulo en mantenimiento")

        'Panel1.BackColor = Color.SteelBlue
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label17.ForeColor = Color.Black

        'Panel1.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel14.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        'Dim Admin As New FrmEmpresas
        'Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        'Admin.Show()
        Panel1.BackColor = Color.DimGray
        Panel2.BackColor = Color.SteelBlue
        Panel3.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel5.BackColor = Color.DimGray
        Panel6.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel8.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Label19.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        'FrmRelacionesContactoEmpresas.MdiParent = Me
        'FrmRelacionesContactoEmpresas.Show()
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.Gainsboro
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label11.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        'Dim Admin As New FrmProspectos
        'Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        'Admin.Show()
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.Gainsboro
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label13.ForeColor = Color.Black

        'PanelBuenosDias.Visible = False
        'PanelRecordatorioSemana.Visible = False
        'PanelRecordatoriosHoy.Visible = False
        'PanelTareasSemana.Visible = False
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        'Dim Admin As New FrmCotizadorLIMS
        'Admin.MdiParent = Me
        'Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text
        'Admin.Show()
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.SteelBlue
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label15.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.SteelBlue
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label17.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.SteelBlue
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.DimGray
        'Panel9.BackColor = Color.DimGray
        'Label19.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        'Panel1.BackColor = Color.DimGray
        'Panel2.BackColor = Color.DimGray
        'Panel3.BackColor = Color.DimGray
        'Panel4.BackColor = Color.DimGray
        'Panel5.BackColor = Color.DimGray
        'Panel6.BackColor = Color.DimGray
        'Panel7.BackColor = Color.DimGray
        'Panel8.BackColor = Color.SteelBlue
        'Panel9.BackColor = Color.DimGray
        'Label21.ForeColor = Color.Black
        MsgBox("Modulo en mantenimiento")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Admin As New FrmCotizacionInformal
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text ''------------------
        Admin.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.SteelBlue
        Panel5.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.DimGray
        Panel6.BackColor = Color.DimGray
        Panel8.BackColor = Color.DimGray
    End Sub

    Private Sub txtRol_Click(sender As Object, e As EventArgs) Handles txtRol.Click
        FrmNuevoContacto.Show()
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        Dim Admin As New FrmCotizacion2018
        Admin.MdiParent = Me
        Admin.txtNombreEmpleado.Text = txtNombreAdmin.Text ''------------
        Admin.Show()

        Panel1.BackColor = Color.DimGray
        Panel4.BackColor = Color.DimGray
        Panel9.BackColor = Color.DimGray
        Panel5.BackColor = Color.DimGray
        Panel7.BackColor = Color.DimGray
        Panel14.BackColor = Color.SteelBlue
        Panel6.BackColor = Color.DimGray
        Panel8.BackColor = Color.DimGray
    End Sub
End Class