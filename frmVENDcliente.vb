Public Class frmVENDcliente
    Dim Cn As New OleDb.OleDbConnection
    Dim Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim oFactura As String
    Dim Strinsqlgeneral As String

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirCliente.Click
        Close()
    End Sub

    Private Sub frmDcliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick

    End Sub

    Private Sub frmDcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlgeneral = "SELECT NRO_CLIENTE,RAZON_SOCIAL,DOMICILIO,LOCALIDAD,CUIT,TELEFONO,EMAIL  from Clientes "
        Da = New OleDb.OleDbDataAdapter(Strinsqlgeneral, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvListacliente.DataSource = Ds


    End Sub

    Private Sub dgvListacliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListacliente.CellContentClick

    End Sub

    Private Sub dgvListacliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvListacliente.DoubleClick
        Dim variclien As Single
        Dim variNombre As String

        variNombre = dgvListacliente.Item(1, dgvListacliente.CurrentRow.Index).Value
        frmVENPrincipal.txtNombrecliente.Text = variNombre

        variclien = dgvListacliente.Item(0, dgvListacliente.CurrentRow.Index).Value
        frmVENPrincipal.txtNcliente.Text = variclien
        frmVENPrincipal.txtNombrecliente.Visible = True
        Close()
    End Sub
End Class

