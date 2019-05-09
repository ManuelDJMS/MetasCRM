Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class PantallaPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''MsgBox("Inicia el sistema")
    End Sub

    Private Sub btCotizador_Click(sender As Object, e As EventArgs) Handles btCotizador.Click
        FrmUsuariosCotizadores.ShowDialog()
    End Sub

    Private Sub AgregarNuevaEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''FrmLoginAdminVentas.ShowDialog()
        'FrmEmpresas.ShowDialog()
    End Sub

    Private Sub AutorizarSolicitudDeRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmAutorizarSolicitudes.ShowDialog()
    End Sub

    Private Sub AgregarNuevoContactoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''FrmLoginAdminVentas.ShowDialog()
        FrmContactos.ShowDialog()
    End Sub

    Private Sub AutorizarRegistroDeNuevoContactoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmLoginAdminGeneral.ShowDialog()
    End Sub

    Private Sub RelacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionesToolStripMenuItem.Click
        FrmRelacionesContactoEmpresas.ShowDialog()
    End Sub

    Private Sub ModificaciónDeRelacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónDeRelacionesToolStripMenuItem.Click
        FrmAutorizarSolicitudes.ShowDialog()
    End Sub

    Private Sub ContactosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContactosToolStripMenuItem1.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub RelaciónContactosEmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RelaciónContactosEmpresasToolStripMenuItem1.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub CotizacionesPorCONTACTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesPorCONTACTOToolStripMenuItem.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub CotizacionesPorEMPRESAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesPorEMPRESAToolStripMenuItem.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub RespaldarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarToolStripMenuItem.Click
        FrmLoginAdminGeneral.ShowDialog()
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        FrmLoginAdminGeneral.ShowDialog()
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub ImportarDesdeExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarDesdeExcelToolStripMenuItem.Click
        FrmLoginAdminVentas.ShowDialog()
    End Sub

    Private Sub LugarToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        FrmLugaresCondicion.ShowDialog()
    End Sub

    Private Sub NuevaCotizaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaCotizaciónToolStripMenuItem.Click
        Cotizaciones.ShowDialog()

    End Sub
End Class
