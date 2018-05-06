Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports CrystalDecisions.Shared

Public Class frmVENImpProducto
 

    Private Sub frmVENImpProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oRepProducto As New CrystalVenProducto
        oRepProducto.SetDataSource(FrmCLIcuit.Dt)



    End Sub

End Class