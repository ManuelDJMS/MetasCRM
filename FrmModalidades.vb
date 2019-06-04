Imports System.Data.SqlClient
Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Public Class FrmModalidades
    Dim clave As String
    Private Sub FrmModalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralProspectos()
    End Sub
    Public Sub consultaGeneralProspectos()
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select Prospeccion.idProspeccion as [#Prospección], Prospeccion.idProspecto, Prospectos.Nombre, Prospectos.Apellidos, Prospectos.Compania, Prospeccion.Descripcion as [Descripción],
                    Prospeccion.Monto, Prospeccion.[Source] from Prospeccion inner join Prospectos on Prospeccion.idProspecto = Prospectos.idProspecto"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGConsulta.DataSource = dt
            DGConsulta.Columns(1).Visible = False
            DGConsulta.Columns(5).Width = 190
            For Each fila As DataGridViewRow In DGConsulta.Rows
                fila.Cells("Monto").Style.BackColor = Color.DarkSeaGreen
            Next
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        End Try
    End Sub

    Private Sub DGConsulta_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGConsulta.RowHeaderMouseClick
        Try
            clave = DGConsulta.Rows(e.RowIndex).Cells(1).Value.ToString()
            'TabConsulta.SelectTab(1)
            consultaDatosProspectos(clave)
        Catch ex As Exception
            MsgBox("Selecciona un registro válido de la regilla.", MsgBoxStyle.Information)
        End Try
    End Sub

    Sub consultaDatosProspectos(ByVal clave As String)
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select Prospeccion.idProspeccion, Prospeccion.Descripcion, Prospeccion.FechaCreacion, Prospeccion.FechaEdicion, Prospeccion.[Source], Prospeccion.Monto, Prospectos.idProspecto,Prospectos.Nombre,
                 Prospectos.Apellidos, Prospectos.Compania, Prospectos.Telefono, Prospectos.Direccion, Prospectos.Ciudad, Prospectos.Estado from Prospeccion 
                 inner join Prospectos on Prospeccion.idProspecto = Prospectos.idProspecto where Prospeccion.idProspecto = " & clave & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            txtidProspeccion.Text = lector(0)
            txtDescripcion.Text = lector(1)
            txtCreacion.Text = lector(2)
            txtEdicion.Text = lector(3)
            txtOrigen.Text = lector(4)
            txtMonto.Text = lector(5)
            txtidProspecto.Text = lector(6)
            txtNombre.Text = lector(7) & " " & lector(8)
            'txtidProspeccion.Text = lector(8)
            txtCompania.Text = lector(9)
            txtTelefoo.Text = lector(10)
            txtDireccion.Text = lector(11)
            txtCiudad.Text = lector(12)
            txtEdo.Text = lector(13)
            lector.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox("Error de lectura de datos.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim Admin As New FrmCotizadorLIMS
        'Admin.Label2.Text = txtidProspecto.Text
        empresa = Val(txtidProspecto.Text)
        MsgBox(empresa)
        Admin.Show()
    End Sub
End Class