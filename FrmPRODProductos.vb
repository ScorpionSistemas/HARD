Imports System.Data.OleDb

Public Class FrmPRODProductos
    Public TxtError_visible As String
    Dim Cn As New OleDb.OleDbConnection
    Public Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql As String
    Dim Resultado, Pedido, Precio_Unitario As Integer
    Dim NroReg, cod_producto As Integer
    Dim Ds As New DataSet
    Dim CODPRODUCTOMod As Integer
    Public stringruta As String
    Public codprod As String
    Public detalleprod As String

    Private Sub DeshabilitarBotonesTODOS()
        btnIngProd.Visible = False
        btnModProd.Visible = False
        btnElimProd.Visible = False
        btnPrim.Visible = False
        btnSig.Visible = False
        btnAnt.Visible = False
        btnUlt.Visible = False
        btnBuscar.Visible = False

    End Sub

    Private Sub DeshabilitarBotonesConfirmar()
        btnConfirm.Visible = False
        btnConfAgreg.Visible = False
        btnElimProd.Visible = False
        btnModProd.Visible = False
    End Sub

    Private Sub DeshabilitarCajasTexto()
        txtCodigoprod.ReadOnly = True
        txtDetalleprod.ReadOnly = True
        txtCantidadprod.ReadOnly = True
        txtPrecUniprod.ReadOnly = True
        txtProveedor.ReadOnly = True

    End Sub
    Private Sub HabilitarBotones()
        btnPrim.Visible = False
        btnSig.Visible = False
        btnAnt.Visible = False
        btnUlt.Visible = False
        btnIngProd.Visible = False
        btnModProd.Visible = False
        btnElimProd.Visible = False

    End Sub
    Private Sub HabilitarCajastexto()
        txtCodigoprod.ReadOnly = False
        txtDetalleprod.ReadOnly = False
        txtCantidadprod.ReadOnly = False
        txtPrecUniprod.ReadOnly = False
        txtProveedor.ReadOnly = False
    End Sub


    Private Sub Vaciarcajas()
        txtCodigoprod.Text = ""
        txtDetalleprod.Text = ""
        txtPrecUniprod.Text = ""
        txtCantidadprod.Text = ""
        txtProveedor.Text = ""

    End Sub

    Private Sub FrmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0
        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Da = New OleDb.OleDbDataAdapter("SELECT * from PRODUCTOS", Cn.ConnectionString)
        Dt.Clear()
        Da.Fill(Dt)
        Cn.Close()
        LlenarTxt()

    End Sub

    Private Sub LlenarTxt()
        txtCodigoprod.Text = Strings.LTrim(Dt.Rows(NroReg)("CODIGO_DE_PRODUCTO"))
        txtDetalleprod.Text = (Dt.Rows(NroReg)("DETALLE"))
        txtCantidadprod.Text = (Dt.Rows(NroReg)("CANTIDAD"))
        txtPrecUniprod.Text = (Dt.Rows(NroReg)("PRECIO_UNITARIO"))
        txtProveedor.Text = (Dt.Rows(NroReg)("PROVEEDOR"))

    End Sub

    Private Sub btnPrim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrim.Click
        NroReg = 0
        LlenarTxt()
    End Sub

    Private Sub btnUlt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        NroReg = Dt.Rows.Count - 1
        LlenarTxt()
    End Sub

    Private Sub btnAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        If NroReg <> 0 Then
            NroReg = NroReg - 1
            LlenarTxt()
        Else
        End If
    End Sub

    Private Sub btnSig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSig.Click
        If NroReg <> Dt.Rows.Count - 1 Then
            NroReg = NroReg + 1
            LlenarTxt()
        Else
        End If

    End Sub


    Private Sub btnIngProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngProd.Click
        Vaciarcajas()
        HabilitarCajastexto()
        DeshabilitarBotonesTODOS()
        btnConfAgreg.Visible = True
        BtnCanc.Visible = True
        btnVolverAlMenu.Visible = False
        'LogoBuscar.Visible = False
        'logoEliminar.Visible = False
        'Logomodificar.Visible = False


    End Sub


    Private Sub btnCodProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NroReg = 0

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\HARD.MDB")
        Cn.Open()


        Stringsql = "SELECT CODIGO_DE_PRODUCTO, DETALLE, PRECIO_UNITARIO, PROVEEDOR FROM PRODUCTOS;'" & "'SELECT Proveedores FROM Proveedores;´'"



        Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)

        LlenarTxt()


        FrmPRODBuscarProducto.ShowDialog()

    End Sub


    Private Sub btnModProd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModProd.Click
        DeshabilitarBotonesTODOS()
        HabilitarCajastexto()
        btnConfirm.Visible = True
        BtnCanc.Visible = True
        txtCodigoprod.ReadOnly = True
        btnVolverAlMenu.Visible = False
        'logoagregar.Visible = False
        'logoEliminar.Visible = False




    End Sub


    Private Sub btnConfirm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtDetalleprod.Text = "" Then
            MessageBox.Show("Debe completar el campo Detalle", "Atención", MessageBoxButtons.OK)
            txtDetalleprod.Clear()
            txtDetalleprod.Focus()
            Exit Sub
        End If

        If txtCantidadprod.Text = "" Then
            MessageBox.Show("Debe completar el campo Cantidad", "Atención", MessageBoxButtons.OK)
            txtCantidadprod.Clear()
            txtCantidadprod.Focus()
            Exit Sub
        End If

        If txtPrecUniprod.Text = "" Then
            MessageBox.Show("Debe completar el campo Precio Unitario", "Atención", MessageBoxButtons.OK)
            txtPrecUniprod.Clear()
            txtPrecUniprod.Focus()
            Exit Sub
        End If


        If txtCodigoprod.Text = "" Then
            MessageBox.Show("Debe completar campo Codigo de producto solo con numeros", "Atención", MessageBoxButtons.OK)
            txtPrecUniprod.Clear()
            txtPrecUniprod.Focus()
            Exit Sub
        End If

        If txtCantidadprod.Text = "" Then
            MessageBox.Show("Debe completar campo Stock solo con numeros", "Atención", MessageBoxButtons.OK)
            txtPrecUniprod.Clear()
            txtPrecUniprod.Focus()
            Exit Sub
        End If


        If MsgBox("¿Confirma los valores a agregar?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then

            Stringsql = "update PRODUCTOS set " _
            & "CODIGO_DE_PRODUCTO=" & "'" & txtCodigoprod.Text & "', " _
            & "DETALLE=" & "'" & txtDetalleprod.Text & "', " _
            & "CANTIDAD=" & "'" & txtCantidadprod.Text & "', " _
            & "PRECIO_UNITARIO=" & "'" & txtPrecUniprod.Text & "' where CODIGO_DE_PRODUCTO= " & txtCodigoprod.Text

            Dim DTdate As New OleDbCommand()
            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
            Try
                Cn.Open()
            Catch ex As Exception
            End Try

            ' Try
            DTdate.CommandText = Stringsql
            DTdate.Connection = Cn
            DTdate.ExecuteNonQuery()
            Cn.Close()
            Dt.Clear()
            Da.Fill(Dt)
            MessageBox.Show("Se ha modificado el Registro")
            ' Catch err As System.Exception
            'NroReg = 0
            'LlenarTxt()
            ' End Try
        End If
        Cn.Close()

        NroReg = 0
        LlenarTxt()


        DeshabilitarBotonesConfirmar()
        HabilitarBotones()
        DeshabilitarCajasTexto()
        BtnCanc.Visible = False


    End Sub

    Private Sub BtnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCanc.Click
        DeshabilitarBotonesConfirmar()
        HabilitarBotones()
        DeshabilitarCajasTexto()
        btnVolverAlMenu.Visible = True
    End Sub

    Private Sub btnElimProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimProd.Click
        'logoagregar.Visible = False
        'Logomodificar.Visible = False

        DeshabilitarBotonesTODOS()
        btnVolverAlMenu.Visible = False

        btnConfirm.Visible = True
        BtnCanc.Visible = True

        Dim Comando_Borrar As New OleDbCommand()

        Comando_Borrar.Connection = Cn

        If MsgBox("¿Está seguro de borrar este registo?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then

            Stringsql = "delete * from PRODUCTOS where CODIGO_DE_PRODUCTO= " & txtCodigoprod.Text() & ""

            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)

            Comando_Borrar.CommandText = Stringsql
            Comando_Borrar.Connection = Cn

            Try
                Cn.Open()
            Catch ex As Exception

            End Try

            Try
                Cn.Open()

            Catch ex As Exception

            End Try

            Comando_Borrar.ExecuteNonQuery()

            MessageBox.Show("Se ha eliminado el registro")

            Da = New OleDb.OleDbDataAdapter("SELECT * from PRODUCTOS", Cn.ConnectionString)

            Dt.Clear()
            Da.Fill(Dt)

            NroReg = 0
            LlenarTxt()

            Try
                Cn.Close()
            Catch ex As Exception

            End Try

        End If
        DeshabilitarBotonesConfirmar()
        HabilitarBotones()
        BtnCanc.Visible = False

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        FrmPRODBuscarProducto.ShowDialog()
    End Sub

    Private Sub btnConfAgreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfAgreg.Click
        'CREÉ NUEVO BOTÓN. Primero haces click en el botón agregar, te habilita los campos para escribir los datos
        'luego en el este botón de confirmar confirmas que vas a guardar los cambios

        Dim ComandoInsertar As New OleDbCommand()

        If MsgBox("Confirma los valores a agregar ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            ComandoInsertar.CommandText = Stringsql
            ComandoInsertar.Connection = Cn

            'VALIDAR CAMPOS // SIEMPRE VA PRIMERO
            'se validan los campos antes de que se guarden para ver si son correctos y no guardarlos con error
            '*************************

            If IsNumeric(txtCodigoprod.Text) Then
            Else
                MessageBox.Show("El CÓDIGO debe ser numérico", "Atención")
                txtCodigoprod.Clear()
                txtCodigoprod.Focus()
                Exit Sub
            End If

            If IsNumeric(txtCantidadprod.Text) Then
            Else
                MessageBox.Show("El STOCK debe ser numérico", "Atención")
                txtCantidadprod.Clear()
                txtCantidadprod.Focus()
                Exit Sub
            End If

            If IsNumeric(txtPrecUniprod.Text) Then
            Else
                MessageBox.Show("El PRECIO UNITARIO debe ser numérico", "Atención")
                txtPrecUniprod.Clear()
                txtPrecUniprod.Focus()
                Exit Sub
            End If

            Stringsql = "Insert Into PRODUCTOS(CODIGO_DE_PRODUCTO, DETALLE, CANTIDAD, PRECIO_UNITARIO)" _
            & "Values (" _
             & "'" & txtCodigoprod.Text & "', " _
             & "'" & txtDetalleprod.Text & "', " _
             & "'" & txtCantidadprod.Text & "', " _
             & "'" & txtPrecUniprod.Text & "') "

            ComandoInsertar.CommandText = Stringsql
            ComandoInsertar.Connection = Cn

            Try
                Cn.Open()
            Catch ex As Exception
            End Try
            ' Try
            ComandoInsertar.ExecuteNonQuery()


            Cn.Close()
            Cn.Open()
            Dt.Clear()

            Da.Fill(Dt)

            LlenarTxt()

            DeshabilitarBotonesTODOS()
            HabilitarCajastexto()
            Vaciarcajas()
            btnConfirm.Visible = True
            BtnCanc.Visible = True



            NroReg = Dt.Rows.Count
            cod_producto = NroReg + 1
            txtCodigoprod.Text = cod_producto

            txtCodigoprod.Text = ""
            txtDetalleprod.Text = ""
            txtCantidadprod.Text = ""
            txtPrecUniprod.Text = ""

            txtCodigoprod.ReadOnly = False
            txtDetalleprod.ReadOnly = False
            txtCantidadprod.ReadOnly = False
            txtPrecUniprod.ReadOnly = False



            btnPrim.Visible = False
            btnAnt.Visible = False
            btnSig.Visible = False
            btnUlt.Visible = False
            btnModProd.Visible = False
            btnElimProd.Visible = False
            btnIngProd.Visible = False

            BtnCanc.Visible = True
            btnConfirm.Visible = True

            TxtError_visible = False


            MessageBox.Show("Registro agregado con éxito")



            'TxtError.Visible = True
            ' TxtError.Text = err.Message


            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            BtnCanc.Visible = False


        End If
        Cn.Close()
    End Sub

    Private Sub btnVolverAlMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverAlMenu.Click

        frmALLMenu.Show()
        Me.Close()

    End Sub
End Class
