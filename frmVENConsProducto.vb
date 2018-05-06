Public Class frmVENConsProducto
    Dim Cn As New OleDb.OleDbConnection
    Public Ds As New DataTable
    Public Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim oProducto As String
    Dim Strinsqlproducto As String

    Private Sub frmConsProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        oProducto = frmVENConsultas.Producto
        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlproducto = "SELECT COD_PRODUCTO,NRO_CLIENTE,NRO_FACTURA,FECHA,PRECIO,CANTIDAD,TOTAL  from Ventas where COD_PRODUCTO = " & oProducto
        Da = New OleDb.OleDbDataAdapter(Strinsqlproducto, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvProducto.DataSource = Ds
        lvlProducto.Visible = True
        LvlProducto.Text = oProducto
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        frmVENImpProducto.ShowDialog()
    End Sub
End Class