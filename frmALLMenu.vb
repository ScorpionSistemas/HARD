Imports System.Data.OleDb
Public Class frmALLMenu
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim sqlstr As String
    Dim NroReg As Integer
    Dim pRol As String

    Private Sub frmMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmALLIngresoUsu.Close()
    End Sub
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmALLIngresoUsu.Hide()
        lblUsuActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios where Usuario= '" & lblUsuActivo.Text & "'", Cn.ConnectionString)

        Dt.Clear()
        DA.Fill(Dt)
        Cn.Close()

        pRol = Dt.Rows(NroReg)("Nivel")

        If pRol = "Vendedor" Then
            MenuAdministrar.Enabled = False
            MenuClientes.Enabled = False
            MenuProductos.Enabled = False
            MenuProveedores.Enabled = False
            SubMenuUsuarios.Enabled = False
        End If
        If pRol = "Altas" Then
            MenuAdministrar.Enabled = False
            MenuProductos.Enabled = False
            SubMenuUsuarios.Enabled = False
            MenuVentas.Enabled = False
        End If
        If pRol = "Facturacion" Then
            MenuAdministrar.Enabled = False
            MenuClientes.Enabled = False
            MenuProveedores.Enabled = False
            SubMenuUsuarios.Enabled = False

        End If
        If pRol = "Logistica" Then
            MenuAdministrar.Enabled = False
            MenuClientes.Enabled = False
            MenuProveedores.Enabled = False
            SubMenuUsuarios.Enabled = False
        End If
    End Sub

    Private Sub MenuSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuSalir.Click
        Close()
        frmALLIngresoUsu.Close()
    End Sub

    Private Sub SunMenuUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SunMenuUsuarios.Click
        frmUSUABMUsuarios.Show()
    End Sub

    Private Sub MenuProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProductos.Click
        FrmPRODProductos.Show()
    End Sub

    Private Sub MenuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientes.Click
        FrmCLIClientes.Show()
    End Sub

    Private Sub MenuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProveedores.Click
        frmPROVProveedores.Show()
    End Sub

    Private Sub MenuVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVentas.Click
        frmVENPrincipal.Show()
    End Sub

    Private Sub SubmenuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmenuProveedores.Click
        frmREPOImprTotalProveed.Show()
    End Sub

    Private Sub SubMenuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuClientes.Click
        frmREPOImprTotalClientes.Show()
    End Sub

    Private Sub SubMenuVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuVentas.Click
        frmREPORImprTotalVentas.Show()
    End Sub

    Private Sub SubMenuProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuProductos.Click
        frmREPOImprTotalProductos.Show()
    End Sub

    Private Sub SubMenuUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuUsuarios.Click
        frmREPOImprTotalUsuarios.Show()
    End Sub
End Class