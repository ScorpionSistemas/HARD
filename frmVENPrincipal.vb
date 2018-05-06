Imports System.Data.OleDb

Public Class frmVENPrincipal
    Dim factura_nro As String
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim sqlstr, sqlstrbuscar As String
    Dim NroReg As Integer
    Dim buscaFactura As Integer

    Private Sub LlenarTxt()
        txtNfactura.Text = Dt.Rows(NroReg)("NRO_FACTURA")
        txtNcliente.Text = Dt.Rows(NroReg)("NRO_CLIENTE")
        txtFecha.Text = Dt.Rows(NroReg)("FECHA")
        txtCproducto.Text = Dt.Rows(NroReg)("COD_PRODUCTO")
        txtCantidad.Text = Dt.Rows(NroReg)("CANTIDAD")
        txtPrecio.Text = Dt.Rows(NroReg)("PRECIO")
        txtTotal.Text = Dt.Rows(NroReg)("TOTAL")
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0
        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()
        Da = New OleDb.OleDbDataAdapter("SELECT * from Ventas order by NRO_FACTURA", Cn.ConnectionString)
        Dt.Clear()
        Da.Fill(Dt)
        Cn.Close()
        LlenarTxt()

        'Dim vari As Single
        'If vari = frmDcliente.dgvListacliente.Item(0, frmDcliente.dgvListacliente.CurrentRow.Index).Value Then
        'vari = txtNcliente.Text
        'End If

    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        NroReg = Dt.Rows.Count - 1
        LlenarTxt()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        NroReg = 0
        LlenarTxt()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If NroReg <> 0 Then
            NroReg = NroReg - 1
            LlenarTxt()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If NroReg <> Dt.Rows.Count - 1 Then
            NroReg = NroReg + 1
            LlenarTxt()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        btnBcliente.Visible = True
        btnBproducto.Visible = True
        lvlModificar.Visible = True
        'pbxVentas.Visible = True
        btnPrimero.Visible = False
        btnUltimo.Visible = False
        btnSiguiente.Visible = False
        btnAnterior.Visible = False
        btnModi.Visible = True
        btnCancelar.Visible = True
        btnEliminar.Visible = True

        txtNcliente.ReadOnly = False
        txtFecha.ReadOnly = False
        txtCproducto.ReadOnly = False
        txtCantidad.ReadOnly = False
        txtPrecio.ReadOnly = False
        txtTotal.ReadOnly = False

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnPrimero.Visible = True
        btnUltimo.Visible = True
        btnSiguiente.Visible = True
        btnAnterior.Visible = True
        btnModi.Visible = False
        btnCancelar.Visible = False
        btnEliminar.Visible = False
        txtNcliente.ReadOnly = True
        txtFecha.ReadOnly = True
        txtCproducto.ReadOnly = True
        txtCantidad.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtTotal.ReadOnly = True
        btnLimpiar.Visible = False
        btnConfirmar.Visible = False
        dtpFecha.Visible = False
        lvlNueva.Visible = False
        lvlModificar.Visible = False
        btnBcliente.Visible = False
        btnBproducto.Visible = False
        txtNombrecliente.Visible = False

        NroReg = 0
        LlenarTxt()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Comando_Borrar As New OleDbCommand()
        If MsgBox("Esta seguro de borrar este registo?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            sqlstr = "delete * from Ventas where NRO_FACTURA= " & txtNfactura.Text
            Comando_Borrar.CommandText = sqlstr
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
            MessageBox.Show("Se ha eliminado un registro")
            Da = New OleDb.OleDbDataAdapter("SELECT * from Ventas order by NRO_FACTURA", Cn.ConnectionString)
            Dt.Clear()
            Da.Fill(Dt)
            NroReg = 0
            LlenarTxt()
            Try
                Cn.Close()
            Catch ex As Exception
            End Try
        End If
        btnPrimero.Visible = True
        btnUltimo.Visible = True
        btnSiguiente.Visible = True
        btnAnterior.Visible = True
        btnModi.Visible = False
        btnCancelar.Visible = False
        btnEliminar.Visible = False
        txtNcliente.ReadOnly = True
        txtFecha.ReadOnly = True
        txtCproducto.ReadOnly = True
        txtCantidad.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtTotal.ReadOnly = True

        NroReg = 0
        LlenarTxt()

    End Sub

    Private Sub btnModi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModi.Click
        If MsgBox("Confirma los valores modificados ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            If IsNumeric(txtNcliente.Text) Then
            Else
                MessageBox.Show("El numero de Cliente debe ser Numérico", "ERROR")
                txtNcliente.Text = ""
                txtNcliente.Focus()
                Exit Sub
            End If
            If IsDate(txtFecha.Text) Then
            Else
                MessageBox.Show("Formato de fecha incorrecta", "ERROR")
                txtFecha.Text = ""
                txtFecha.Focus()
                Exit Sub
            End If
            If IsNumeric(txtCproducto.Text) Then
            Else
                MessageBox.Show("El Producto debe ser Numérico", "ERROR")
                txtCproducto.Text = ""
                txtCproducto.Focus()
                Exit Sub
            End If
            If IsNumeric(txtCantidad.Text) Then
            Else
                MessageBox.Show("El valor de Cantidad debe ser Numérico", "ERROR")
                txtCantidad.Text = ""
                txtCantidad.Focus()
                Exit Sub
            End If
            If IsNumeric(txtPrecio.Text) Then
            Else
                MessageBox.Show("El Precio debe ser Numérico", "ERROR")
                txtPrecio.Text = ""
                txtPrecio.Focus()
                Exit Sub
            End If
            sqlstr = "update Ventas set " _
            & "NRO_FACTURA=" & "'" & txtNfactura.Text & "', " _
            & "FECHA=" & "'" & txtFecha.Text & "', " _
            & "COD_PRODUCTO=" & "'" & txtCproducto.Text & "', " _
            & "CANTIDAD=" & "'" & txtCantidad.Text & "', " _
            & "PRECIO=" & "'" & txtPrecio.Text & "', " _
            & "TOTAL = " & "'" & txtTotal.Text & "' where NRO_CLIENTE= " & txtNcliente.Text

            Dim DTdate As New OleDbCommand()
            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
            Try
                Cn.Open()
            Catch ex As Exception
            End Try

            ' Try
            DTdate.CommandText = sqlstr
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

        btnPrimero.Visible = True
        btnUltimo.Visible = True
        btnSiguiente.Visible = True
        btnAnterior.Visible = True
        btnModi.Visible = False
        btnCancelar.Visible = False
        btnEliminar.Visible = False
        txtNcliente.ReadOnly = True
        txtFecha.ReadOnly = True
        txtCproducto.ReadOnly = True
        txtCantidad.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtTotal.ReadOnly = True
        lvlNueva.Visible = False
        lvlModificar.Visible = False
        btnBcliente.Visible = False
        btnBproducto.Visible = False

        NroReg = 0
        LlenarTxt()

    End Sub

    Private Sub btnNventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNventa.Click
        btnBcliente.Visible = True
        btnBproducto.Visible = True
        lvlNueva.Visible = True
        'pbxVentas.Visible = True
        btnConfirmar.Visible = True
        btnPrimero.Visible = False
        btnUltimo.Visible = False
        btnSiguiente.Visible = False
        btnAnterior.Visible = False
        btnCancelar.Visible = True
        btnLimpiar.Visible = True
        txtNcliente.ReadOnly = False
        'txtFecha.Visible = False
        dtpFecha.Visible = True
        txtCproducto.ReadOnly = False
        txtCantidad.ReadOnly = False
        txtPrecio.ReadOnly = False
        txtTotal.ReadOnly = False


        NroReg = Dt.Rows.Count - 1
        txtNfactura.Text = Dt.Rows(NroReg)("NRO_FACTURA")
        txtNfactura.Text = txtNfactura.Text + 1


        txtNcliente.Text = ""
        txtFecha.Text = ""
        txtCproducto.Text = ""
        txtCantidad.Text = ""
        txtPrecio.Text = ""
        txtTotal.Text = ""
        txtNcliente.Focus()

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtNcliente.Text = ""
        txtFecha.Text = ""
        txtCproducto.Text = ""
        txtCantidad.Text = ""
        txtPrecio.Text = ""
        txtTotal.Text = ""
        txtNcliente.Focus()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        'Dim sqlstring As String
        Dim DBagrega As New OleDbCommand()

        If MsgBox("Confirma los valores a agregar ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then

            If IsNumeric(txtNcliente.Text) Then
            Else
                MessageBox.Show("El numero de Cliente debe ser Numérico", "ERROR")
                txtNcliente.Text = ""
                txtNcliente.Focus()
                Exit Sub
            End If
            If IsNumeric(txtCproducto.Text) Then
            Else
                MessageBox.Show("El Producto debe ser Numérico", "ERROR")
                txtCproducto.Text = ""
                txtCproducto.Focus()
                Exit Sub
            End If
            If IsNumeric(txtCantidad.Text) Then
            Else
                MessageBox.Show("El valor de Cantidad debe ser Numérico", "ERROR")
                txtCantidad.Text = ""
                txtCantidad.Focus()
                Exit Sub
            End If
            If IsNumeric(txtPrecio.Text) Then
            Else
                MessageBox.Show("El Precio debe ser Numérico", "ERROR")
                txtPrecio.Text = ""
                txtPrecio.Focus()
                Exit Sub
            End If

            sqlstr = "Insert Into Ventas(NRO_FACTURA,NRO_CLIENTE,FECHA,COD_PRODUCTO,CANTIDAD,PRECIO,TOTAL) " _
                & "Values (" _
                & "'" & txtNfactura.Text & "', " _
                & "'" & txtNcliente.Text & "', " _
                & "'" & dtpFecha.Value & "', " _
                & "'" & txtCantidad.Text & "', " _
                & "'" & txtCantidad.Text & "', " _
                & "'" & txtPrecio.Text & "', " _
                & "'" & txtTotal.Text & "') "

            DBagrega.CommandText = sqlstr
            DBagrega.Connection = Cn

            Try
                Cn.Open()
            Catch ex As Exception
            End Try
            DBagrega.ExecuteNonQuery()
            Cn.Close()
            Cn.Open()
            Dt.Clear()
            Da.Fill(Dt)
            NroReg = 0
            LlenarTxt()
            MessageBox.Show("Se ha agregado un Registro")

            btnPrimero.Visible = True
            btnUltimo.Visible = True
            btnSiguiente.Visible = True
            btnAnterior.Visible = True
            btnModi.Visible = False
            btnCancelar.Visible = False
            btnLimpiar.Visible = False
            btnConfirmar.Visible = False
            btnEliminar.Visible = False
            txtNcliente.ReadOnly = True
            txtFecha.ReadOnly = True
            txtCproducto.ReadOnly = True
            txtCantidad.ReadOnly = True
            txtPrecio.ReadOnly = True
            txtTotal.ReadOnly = True
            lvlNueva.Visible = False
            lvlModificar.Visible = False
            btnBcliente.Visible = False
            btnBproducto.Visible = False
            txtNombrecliente.Visible = False
            dtpFecha.Visible = False


        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If MsgBox("Esta Seguro de Salir de Ventas ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            Close()
        Else
            btnNventa.Focus()
        End If
    End Sub

    Private Sub btnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultas.Click
        frmVENConsultas.ShowDialog()
    End Sub

    Private Sub btnBcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBcliente.Click
        frmVENDcliente.ShowDialog()
    End Sub

    Private Sub btnBproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBproducto.Click
        frmVENListaproductos.ShowDialog()
    End Sub

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged
        txtTotal.Text = txtPrecio.Text

    End Sub

    Private Sub ConsultaPorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaPorToolStripMenuItem.Click
        frmVENConsultas.gbxcliente.Visible = False
        frmVENConsultas.gbxFecha.Visible = True
        frmVENConsultas.gbxProducto.Visible = False
        frmVENConsultas.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        If MsgBox("Esta Seguro de Salir de Ventas ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            Close()
        Else
            btnNventa.Focus()
        End If
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        btnBcliente.Visible = True
        btnBproducto.Visible = True
        lvlNueva.Visible = True
        'pbxVentas.Visible = True
        btnConfirmar.Visible = True
        btnPrimero.Visible = False
        btnUltimo.Visible = False
        btnSiguiente.Visible = False
        btnAnterior.Visible = False
        btnCancelar.Visible = True
        btnLimpiar.Visible = True
        txtNcliente.ReadOnly = False
        'txtFecha.Visible = False
        dtpFecha.Visible = True
        txtCproducto.ReadOnly = False
        txtCantidad.ReadOnly = False
        txtPrecio.ReadOnly = False
        txtTotal.ReadOnly = False


        NroReg = Dt.Rows.Count - 1
        txtNfactura.Text = Dt.Rows(NroReg)("NRO_FACTURA")
        txtNfactura.Text = txtNfactura.Text + 1


        txtNcliente.Text = ""
        txtFecha.Text = ""
        txtCproducto.Text = ""
        txtCantidad.Text = ""
        txtPrecio.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub ModiicarVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModiicarVentasToolStripMenuItem.Click
        btnBcliente.Visible = True
        btnBproducto.Visible = True
        lvlModificar.Visible = True
        'pbxVentas.Visible = True
        btnPrimero.Visible = False
        btnUltimo.Visible = False
        btnSiguiente.Visible = False
        btnAnterior.Visible = False
        btnModi.Visible = True
        btnCancelar.Visible = True
        btnEliminar.Visible = True

        txtNcliente.ReadOnly = False
        txtFecha.ReadOnly = False
        txtCproducto.ReadOnly = False
        txtCantidad.ReadOnly = False
        txtPrecio.ReadOnly = False
        txtTotal.ReadOnly = False
    End Sub

    Private Sub AnularVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularVentaToolStripMenuItem.Click
        Dim Comando_Borrar As New OleDbCommand()
        If MsgBox("Esta seguro de borrar este registo?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            sqlstr = "delete * from Ventas where NRO_FACTURA= " & txtNfactura.Text
            Comando_Borrar.CommandText = sqlstr
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
            MessageBox.Show("Se ha eliminado un registro")
            Da = New OleDb.OleDbDataAdapter("SELECT * from Ventas order by NRO_FACTURA", Cn.ConnectionString)
            Dt.Clear()
            Da.Fill(Dt)
            NroReg = 0
            LlenarTxt()
            Try
                Cn.Close()
            Catch ex As Exception
            End Try
        End If
        btnPrimero.Visible = True
        btnUltimo.Visible = True
        btnSiguiente.Visible = True
        btnAnterior.Visible = True
        btnModi.Visible = False
        btnCancelar.Visible = False
        btnEliminar.Visible = False
        txtNcliente.ReadOnly = True
        txtFecha.ReadOnly = True
        txtCproducto.ReadOnly = True
        txtCantidad.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtTotal.ReadOnly = True

        NroReg = 0
        LlenarTxt()
    End Sub

    Private Sub InformeDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeVentasToolStripMenuItem.Click
        frmVENConsltageneral.ShowDialog()
    End Sub

    Private Sub ConsultaPorFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaPorFacturaToolStripMenuItem.Click
        frmVENConsultas.gbxcliente.Visible = True
        frmVENConsultas.gbxFecha.Visible = False
        frmVENConsultas.gbxProducto.Visible = False
        frmVENConsultas.ShowDialog()
    End Sub

    Private Sub ConsultaPorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaPorProductoToolStripMenuItem.Click
        frmVENConsultas.gbxcliente.Visible = False
        frmVENConsultas.gbxFecha.Visible = False
        frmVENConsultas.gbxProducto.Visible = True
        frmVENConsultas.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class