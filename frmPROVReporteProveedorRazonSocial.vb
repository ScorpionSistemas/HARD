
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPROVReporteProveedorRazonSocial
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql As String
    Dim NroReg As Integer
    Private Sub frmPROVReporteProveedorRazonSocial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Reporte As New CrystalProveedores()

        If frmPROVListadoProveedores.txtBuscar.Text = "" Then


            NroReg = 0

            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
            Cn.Open()

            Stringsql = "SELECT * from Proveedores"
            Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

            Dt.Clear()

            Da.Fill(Dt)


            Reporte.SetDataSource(Dt)
            crvReporteProveedoresRazSoc.ReportSource = Reporte
            Cn.Close()


        Else

            NroReg = 0

            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
            Cn.Open()

            Stringsql = "SELECT * from Proveedores where RazonSocial like '%" & frmPROVListadoProveedores.txtBuscar.Text & "%' "
            Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

            Dt.Clear()

            Da.Fill(Dt)

            Cn.Close()

            Reporte.SetDataSource(Dt)
            crvReporteProveedoresRazSoc.ReportSource = Reporte


        End If

    End Sub


End Class
