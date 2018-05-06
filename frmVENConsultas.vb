Public Class frmVENConsultas
    Public Producto As String
    Public Factura As String
    Public Fecha As String



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirconsultas.Click
        Close()
    End Sub

    Private Sub frmConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo
    End Sub

    Private Sub btnCcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCcliente.Click
        gbxcliente.Visible = True
        gbxFecha.Visible = False
        gbxProducto.Visible = False
    End Sub

    Private Sub btnCfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCfecha.Click
        gbxFecha.Visible = True
        gbxProducto.Visible = False
        gbxcliente.Visible = False
    End Sub

    Private Sub btnCproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCproducto.Click
        gbxProducto.Visible = True
        gbxFecha.Visible = False
        gbxcliente.Visible = False

    End Sub

    Private Sub btnBuscarproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarproducto.Click
        If txtBuscarProducto.Text = "" Then
            MessageBox.Show("El Campo del Producto esta Vacio", "ERROR")
            txtBuscarProducto.Focus()
        End If
        If IsNumeric(txtBuscarProducto.Text) Then
            Producto = txtBuscarProducto.Text
            frmVENConsProducto.ShowDialog()
        Else
            MessageBox.Show("El Campo Producto debe ser Numerico", "ERROR")
            txtBuscarProducto.Text = ""
            txtBuscarProducto.Focus()
        End If
    End Sub

    Private Sub btnBuscarfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarfecha.Click
        fecha = dtpBuscarfecha.Text
        frmVENConsFecha.ShowDialog()
    End Sub

    Private Sub btnBuscarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarcliente.Click
        If txtBuscarfactura.Text = "" Then
            MessageBox.Show("El Campo de Factura esta Vacio", "ERROR")
            txtBuscarfactura.Focus()
        End If
        If IsNumeric(txtBuscarfactura.Text) Then
            Factura = txtBuscarfactura.Text
            frmVENConsFactura.ShowDialog()
        Else
            MessageBox.Show("El Campo de Factura debe ser Numerico", "ERROR")
            txtBuscarfactura.Text = ""
            txtBuscarfactura.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmVENConsltageneral.ShowDialog()
    End Sub

    Private Sub gbxcliente_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxcliente.Enter

    End Sub
End Class