Imports System.Data.OleDb

Public Class FrmPRODBuscarDetalle
    Dim Cn As New OleDb.OleDbConnection
    Public Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim odetalle As String
    Dim oCodProd As Integer
    Dim Strinsqlcod_prod As String
    Public codprod As String
    Public detalleprod As String


    Private Sub FrmBuscarDetalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        odetalle = FrmPRODBuscarProducto.txtProducto.Text

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlcod_prod = "SELECT DETALLE, PRECIO_UNITARIO FROM PRODUCTOS where DETALLE like '%" & odetalle & "%'"
        Da = New OleDb.OleDbDataAdapter(Strinsqlcod_prod, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvbuscarcodproducto.DataSource = Ds
        lblDetalle.Visible = True
        lblDetalle.Text = odetalle

    End Sub
    Private Sub dgvProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuscarcodproducto.CellContentClick

    End Sub

    Private Sub dgvProductos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvbuscarcodproducto.DoubleClick
        Dim variprod As Single
        Dim variprecio As Single
        variprod = dgvbuscarcodproducto.Item(0, dgvbuscarcodproducto.CurrentRow.Index).Value
        frmVENPrincipal.txtCproducto.Text = variprod

        variprecio = dgvbuscarcodproducto.Item(3, dgvbuscarcodproducto.CurrentRow.Index).Value
        frmVENPrincipal.txtPrecio.Text = variprecio

        Close()
    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmImpConsulDetalles.Show()
    End Sub
End Class