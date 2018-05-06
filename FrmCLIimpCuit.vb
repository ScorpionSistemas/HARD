Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Public Class FrmCLIimpCuit
    Private Sub CRImpCuit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRImpcuit.Load

        Dim oRptcuit As New CRimpcuit
        oRptcuit.SetDataSource(FrmCLIcuit.Dt)

        CRImpCuit.ReportSource = oRptcuit

    End Sub
End Class