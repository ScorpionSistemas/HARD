Public Class frmPROVListadoProveedores
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql As String
    Dim NroReg As Integer


    Private Sub frmBuscarporRazonSocial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

        Stringsql = "SELECT * from Proveedores"
        Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)

        Cn.Close()

        dgvBuscarRazonSocial.DataSource = Dt

    End Sub

    Private Sub btnBuscarporCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarporRazSoc.Click


        Try
            If txtBuscar.Text = "" Then
                MessageBox.Show("Debe completar el cuadro de texto para poder buscar", "Atencion")
                txtBuscar.Focus()
                Exit Sub
            Else

                NroReg = 0

                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()

                Stringsql = "SELECT * from Proveedores where RazonSocial like '%" & txtBuscar.Text & "%' "
                Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

                Dt.Clear()

                Da.Fill(Dt)

                Cn.Close()

                dgvBuscarRazonSocial.DataSource = Dt
            End If

        Catch ex As Exception
            Exit Sub

        End Try


    End Sub


    Private Sub btnImprimirListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirListado.Click
        frmPROVReporteProveedorRazonSocial.ShowDialog()

    End Sub

    Private Sub btnVolverProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverProveedores.Click

        If MsgBox("Desea volver al formulario Proveedores", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then


            frmPROVProveedores.ShowDialog()


        ElseIf MsgBoxResult.No Then
            Exit Sub

        End If

    End Sub

End Class