Public Class FrmCotPorFolio
    Private Sub FrmCotPorFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim R As String
            MetodoMetasInf2018()
            comando2018 = conexion2018.CreateCommand
            R = "select top 1 isnull(Folio,'-'),isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), 
		         isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), 
		         isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
                 isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'),
                 isnull(RFC,'-'), isnull(PaisConsig,'-')
		         from [INFORMES-SERVICIOS] INNER JOIN MetAsInf on [INFORMES-SERVICIOS].ClaveContactoConsign=MetAsInf.Clavempresa
		         inner join [Contactos-Clientes-Usuarios] on [INFORMES-SERVICIOS].Clavecontacto = [Contactos-Clientes-Usuarios].Clavecontacto
		         where Folio=" & respuestafolio
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            lector2018.Read()
            TextFolio.Text = lector2018(0)
            lbClave.Text = lector2018(1)
            lbEmpresa.Text = lector2018(2)
            lbDomicilio.Text = lector2018(3)
            lbCiudad.Text = lector2018(4)
            lbEstado.Text = lector2018(5)
            lbClaveContacto.Text = lector2018(6)
            lbContacto.Text = lector2018(7)
            lbTelefono.Text = lector2018(8)
            lbExt.Text = lector2018(9)
            lbCorreo.Text = lector2018(10)
            lbRFC.Text = lector2018(11)
            lbPais.Text = lector2018(12)
            txtReferencia.Text = "Confirmación Metrológica No." + Convert.ToString(respuestafolio)
            lector2018.Close()
            '----------------------------Llenar el grid por folio---------------------------------------------
            R = "select isnull(ServCatalogo1,'-'),isnull(Tipo,'-'), isnull(Marca,'-'), isnull(Modelo,'-'), 
                 isnull(ID,'-'), isnull(Puntos,'-'),isnull(PUCalib,'-'),isnull(Alcance,'-'),isnull(Serie,'-'), 
                 isnull(Informe,'-'), FECHACALIB from [INFORMES-SERVICIOS] where Folio=" & respuestafolio
            comando2018.CommandText = R
            lector2018 = comando2018.ExecuteReader
            Dim partida As Integer = 1
            While lector2018.Read()
                DGCotizaciones.Rows.Add(False, partida, lector2018(0), 1, lector2018(1), lector2018(2), lector2018(3),
                 lector2018(4), lector2018(5), lector2018(6), lector2018(7), lector2018(8), lector2018(9), lector2018(10))
                partida = partida + 1
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
    End Sub
End Class