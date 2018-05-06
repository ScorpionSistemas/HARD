Public Class frmVENConsFecha
    Dim Cn As New OleDb.OleDbConnection
    Dim Ds As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim NroReg As Integer
    Dim oFecha As String
    Dim Strinsqlfecha As String

    Private Sub frmConsFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        oFecha = frmVENConsultas.Fecha
        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Strinsqlfecha = "SELECT FECHA,NRO_FACTURA,COD_PRODUCTO,NRO_CLIENTE,PRECIO,CANTIDAD,TOTAL  from Ventas where FECHA like " & "'" & "%" & oFecha & "%" & "'"
        Da = New OleDb.OleDbDataAdapter(Strinsqlfecha, Cn.ConnectionString)
        Ds.Clear()
        Da.Fill(Ds)
        dgvFecha.DataSource = Ds
        Label2.Visible = True
        Label2.Text = oFecha

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        frmVenImpFecha.ShowDialog()
    End Sub
End Class