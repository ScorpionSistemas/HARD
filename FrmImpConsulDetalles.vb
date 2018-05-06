Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class FrmImpConsulDetalles

    Private Sub FrmImpConsulDetalles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oRptPrueba As New CrystalDetPRODUCTOS()

        oRptPrueba.SetDataSource(FrmPRODBuscarDetalle.Ds)

        CRVDetallePRODUCTOS.ReportSource = oRptPrueba
    End Sub

    
End Class