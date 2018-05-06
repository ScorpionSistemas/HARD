Imports System.Data.OleDb

Public Class FrmPRODBuscarProducto
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql, Producto As String
    Dim NroReg, cod_producto As Integer
    Public stringruta As String
    Public codprod As String
    Public detalleprod As String

    Private Sub LlenarTxt()
        txtCodProd.Text = Strings.LTrim(Dt.Rows(NroReg)("Codigo_de_Producto"))
        txtProducto.Text = (Dt.Rows(NroReg)("PRODUCTO"))

    End Sub


    Private Sub btnPrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrim.Click
        NroReg = 0
        LlenarTxt()
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        NroReg = Dt.Rows.Count - 1
        LlenarTxt()
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        If NroReg <> 0 Then
            NroReg = NroReg - 1
            LlenarTxt()
        Else
        End If
    End Sub


    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        If NroReg <> Dt.Rows.Count - 1 Then
            NroReg = NroReg + 1
            LlenarTxt()
        Else
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Cn.Close()
        FrmPRODProductos.Show()
        btnVolver.Visible = False
        Me.Close()

        txtProducto.ReadOnly = True
        txtCodProd.ReadOnly = True
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarT.Click
        txtProducto.Text = ""
        txtCodProd.Text = ""

    End Sub

    Private Sub FrmBuscarProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0
        btnVolver.Visible = True
    End Sub

    Private Sub btnBuscarCod_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCod.Click
        txtCodProd.ReadOnly = False
        txtCodProd.Focus()
        txtProducto.ReadOnly = True
        txtProducto.Text = ""
    End Sub

    Private Sub btnBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProducto.Click
        txtProducto.ReadOnly = False
        txtProducto.Focus()
        txtCodProd.ReadOnly = True
        txtCodProd.Text = ""

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtProducto.ReadOnly = False Then
            If txtProducto.Text = "" Then
                MessageBox.Show("El Campo del Producto esta Vacio", "ERROR")
                txtCodProd.Focus()
            End If
            FrmPRODBuscarDetalle.ShowDialog()
        End If
        If txtCodProd.ReadOnly = False Then
            If IsNumeric(txtCodProd.Text) Then
                FrmPRODBuscarCodProducto.ShowDialog()
            Else
                MessageBox.Show("El Campo Producto debe ser Numerico", "ERROR")
                txtCodProd.Text = ""
                txtCodProd.Focus()
                txtCodProd.ReadOnly = False
                txtProducto.ReadOnly = True
            End If
        End If
    End Sub


End Class