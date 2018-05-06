Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmCLIimpLocalidad

    Private Sub frmImprLocalidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oRptPrueba As New CRImprLocalidad
        oRptPrueba.SetDataSource(FrmCLIlocalidad.Dt1)

        CrystalReportViewer1.ReportSource = oRptPrueba

    End Sub
End Class