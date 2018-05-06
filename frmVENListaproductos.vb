Public Class frmVENListaproductos
    Dim Cn As New OleDb.OleDbConnection
    Dim Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim oFactura As String
    Dim Strinsqlgeneral As String
    Private Sub frmListaproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlgeneral = "SELECT CODIGO_DE_PRODUCTO,DETALLE,CANTIDAD,PRECIO_UNITARIO,NUMERO_PROVEEDOR  from PRODUCTOS "
        Da = New OleDb.OleDbDataAdapter(Strinsqlgeneral, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvProductos.DataSource = Ds
    End Sub

    Private Sub btnSalirproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirproducto.Click
        Close()
    End Sub

    Private Sub dgvProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub dgvProductos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProductos.DoubleClick
        Dim variprod As Single
        Dim variprecio As Single
        variprod = dgvProductos.Item(0, dgvProductos.CurrentRow.Index).Value
        frmVENPrincipal.txtCproducto.Text = variprod

        variprecio = dgvProductos.Item(3, dgvProductos.CurrentRow.Index).Value
        frmVENPrincipal.txtPrecio.Text = variprecio

        Close()
    End Sub
End Class

