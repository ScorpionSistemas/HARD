Public Class frmVENConsFactura
    Dim Cn As New OleDb.OleDbConnection
    Dim Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim oFactura As String
    Dim Strinsqlfactura As String

    Private Sub frmConsFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        oFactura = frmVENConsultas.Factura
        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        'Strinsqlfactura = "SELECT NRO_FACTURA,NRO_CLIENTE,COD_PRODUCTO,FECHA,PRECIO,CANTIDAD,TOTAL  from Ventas where NRO_FACTURA like " & "'" & "%" & oFactura & "%" & "'"
        Strinsqlfactura = "SELECT NRO_FACTURA,NRO_CLIENTE,COD_PRODUCTO,FECHA,PRECIO,CANTIDAD,TOTAL  from Ventas where NRO_FACTURA = " & oFactura
        Da = New OleDb.OleDbDataAdapter(Strinsqlfactura, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvFactura.DataSource = Ds
        lblFactura.Visible = True
        lblFactura.Text = oFactura
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        frmVenImpFactura.ShowDialog()
    End Sub
End Class