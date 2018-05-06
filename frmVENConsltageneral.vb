Public Class frmVENConsltageneral
    Dim Cn As New OleDb.OleDbConnection
    Dim Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim oFactura As String
    Dim Strinsqlgeneral As String

    Private Sub frmConsltageneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlgeneral = "SELECT COD_PRODUCTO,NRO_CLIENTE,NRO_FACTURA,FECHA,PRECIO,CANTIDAD,TOTAL  from Ventas "
        Da = New OleDb.OleDbDataAdapter(Strinsqlgeneral, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvGeneral.DataSource = Ds
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmVenIprimGeneral.ShowDialog()

    End Sub
End Class

