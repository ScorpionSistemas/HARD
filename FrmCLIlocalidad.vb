Public Class FrmCLIlocalidad
    Dim Cn As New OleDb.OleDbConnection
    Public Dt1 As New DataTable
    Public Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim nroreg, nro_cliente, nrocliente As Integer
    Dim nrocuit As Double
    Dim StringSql, sqlstring, sqlstr, sqlstrborrar, sqlstrbuscar, strlocal, local As String
    Public stringruta As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarlocalidad.Click
        'txtLocalidad.Text = cmbLocalidad.Text
        local = cmbLocalidad.Text
        nroreg = 0
        sqlstr = "SELECT nro_cliente,razon_social,domicilio,localidad,cuit,telefono,email from Clientes where LOCALIDAD =  '" & local & "'"
        Da = New OleDb.OleDbDataAdapter(sqlstr, Cn.ConnectionString)
        Dt1.Clear()
        Da.Fill(Dt1)

        dgvLocalidad.DataSource = Dt1
        Cn.Close()
        cmbLocalidad.Text = ""

    End Sub

    Private Sub cmbLocalidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLocalidad.Click

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        nroreg = 0

        strlocal = "select distinct localidad from clientes"
        Da = New OleDb.OleDbDataAdapter(strlocal, Cn.ConnectionString)

        Dt.Clear()
        Da.Fill(Dt)

        cmbLocalidad.DataSource = Dt
        cmbLocalidad.DisplayMember = "localidad"
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        Cn.Close()
    End Sub

    Private Sub Frmlocalidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        nroreg = 0

        strlocal = "select distinct localidad from clientes"
        Da = New OleDb.OleDbDataAdapter(strlocal, Cn.ConnectionString)

        Dt.Clear()
        Da.Fill(Dt)

        cmbLocalidad.DataSource = Dt
        cmbLocalidad.DisplayMember = "localidad"
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        frmCLIimpLocalidad.ShowDialog()

    End Sub

    Private Sub dgvLocalidad_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLocalidad.CellContentClick

    End Sub
End Class