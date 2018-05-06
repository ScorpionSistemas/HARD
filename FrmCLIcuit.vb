Public Class FrmCLIcuit
    Dim Cn As New OleDb.OleDbConnection

    Public Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim nroreg, nro_cliente, nrocliente As Integer
    Dim nrocuit As Double
    Dim StringSql, sqlstring, sqlstr, sqlstrborrar, sqlstrbuscar As String
    Public stringruta As String


    Private Sub Frmcuit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

    End Sub



    Private Sub Btnbuscar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
        nrocuit = Double.Parse(txtcuit.Text)

        sqlstr = "SELECT * from clientes where  CUIT= " & nrocuit

        Da = New OleDb.OleDbDataAdapter(sqlstr, Cn.ConnectionString)

        Dt.Clear()
        Da.Fill(Dt)
        dgvCuit.DataSource = Dt

        txtcuit.Text = ""

        btnBuscar1.Enabled = False




    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub txtcuit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcuit.TextChanged
        btnBuscar1.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmCLIimpCuit.ShowDialog()
    End Sub

End Class