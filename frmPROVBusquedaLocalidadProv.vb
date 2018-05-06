Public Class frmPROVBusquedaLocalidadProv
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql As String
    Dim NroReg As Integer
    Private Sub frmBusquedaLocalidadProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

        Stringsql = "SELECT * from Proveedores"
        Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)

        Cn.Close()

        dgvLocalidadProv.DataSource = Dt

    End Sub

    Private Sub btnLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalidad.Click
        Try
            If txtBusqLocalidadProv.Text = "" Then
                MessageBox.Show("Debe completar el cuadro de texto para poder buscar", "Atencion")
                txtBusqLocalidadProv.Focus()
                Exit Sub
            Else

                NroReg = 0

                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()

                Stringsql = "SELECT * from Proveedores where Localidad like '%" & txtBusqLocalidadProv.Text & "%' "
                Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

                Dt.Clear()

                Da.Fill(Dt)

                Cn.Close()

                dgvLocalidadProv.DataSource = Dt
            End If

        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub btnBackProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackProv.Click
        If MsgBox("Desea volver al formulario Proveedores", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then


            frmPROVProveedores.ShowDialog()


        ElseIf MsgBoxResult.No Then
            Exit Sub

        End If

    End Sub
    Private Sub btnImpresionLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresionLocalidad.Click
        frmPROVReporteLocalidadProveedor.ShowDialog()

    End Sub
End Class