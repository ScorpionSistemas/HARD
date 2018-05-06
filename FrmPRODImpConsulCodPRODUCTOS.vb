Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports CrystalDecisions.Shared


Public Class FrmPRODImpConsulCodPRODUCTOS

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oRptPrueba As New CrystalCodPRODUCTOS()

        oRptPrueba.SetDataSource(FrmPRODBuscarCodProducto.Ds)

        CRVCodPRODUCTOS.ReportSource = oRptPrueba
    End Sub

End Class