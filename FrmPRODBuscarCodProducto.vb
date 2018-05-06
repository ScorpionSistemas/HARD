Imports System.Data.OleDb

Public Class FrmPRODBuscarCodProducto
    Dim Cn As New OleDb.OleDbConnection
    Public Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim ocodproducto As String
    Dim Strinsqlcod_prod As String
    Public codprod As String
    Public detalleprod As String

    Private Sub FrmBuscarCodProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo
        ocodproducto = FrmPRODBuscarProducto.txtCodProd.Text

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlcod_prod = "SELECT * FROM PRODUCTOS WHERE CODIGO_DE_PRODUCTO= " & ocodproducto
        Da = New OleDb.OleDbDataAdapter(Strinsqlcod_prod, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvbuscarcodproducto.DataSource = Ds
        lblProd.Visible = True
        lblProd.Text = ocodproducto

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Close()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmPRODImpConsulCodPRODUCTOS.Show()
    End Sub
End Class