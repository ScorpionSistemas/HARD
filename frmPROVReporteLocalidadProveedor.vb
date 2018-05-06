Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPROVReporteLocalidadProveedor
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql As String
    Dim NroReg As Integer
    Private Sub frmPROVReporteLocalidadProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Reporte As New CrystalProveedores()
        Try
            If frmPROVBusquedaLocalidadProv.txtBusqLocalidadProv.Text = "" Then


                NroReg = 0

                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()

                Stringsql = "SELECT * from Proveedores"
                Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

                Dt.Clear()

                Da.Fill(Dt)

                Cn.Close()
                Reporte.SetDataSource(Dt)
                crvProveedoresLocalidad.ReportSource = Reporte

            Else

                NroReg = 0

                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()

                Stringsql = "SELECT * from Proveedores where Localidad like '%" & frmPROVBusquedaLocalidadProv.txtBusqLocalidadProv.Text & "%' "
                Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

                Dt.Clear()

                Da.Fill(Dt)

                Cn.Close()
                Reporte.SetDataSource(Dt)
                crvProveedoresLocalidad.ReportSource = Reporte

            End If



        Catch ex As Exception
            Exit Sub

        End Try
    End Sub
End Class
