Public Class FrmCLIlistado
    Dim Cn As New OleDb.OleDbConnection

    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim nroreg, nro_cliente, nrocliente As Integer
    Dim StringSql, sqlstring, sqlstr, sqlstrborrar, sqlstrbuscar As String
    Public stringruta As String
    Private Sub Frmlistado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

        sqlstr = "SELECT * from clientes order by nro_cliente"

        Da = New OleDb.OleDbDataAdapter(sqlstr, Cn.ConnectionString)
        Dt.Clear()
        Da.Fill(Dt)


        dgvListado.DataSource = Dt
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblListadoxclientes.Click

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmImpListado.ShowDialog()
    End Sub
End Class