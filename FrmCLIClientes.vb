Imports System.Data.OleDb

Public Class FrmCLIClientes
    Dim Cn As New OleDb.OleDbConnection

    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim nroreg, nro_cliente, nrocliente As Integer
    Dim StringSql, sqlstring, sqlstr, sqlstrborrar, sqlstrbuscar As String
    Public stringruta As String
    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

        StringSql = "SELECT * from clientes order by nro_cliente"

        Da = New OleDb.OleDbDataAdapter(StringSql, Cn.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)


        NroReg = 0

        LlenarTxt()

    End Sub
    Private Sub LlenarTxt()

        'aca muestro los datos en los textbox 

        txtNro_cliente.Text = Dt.Rows(Nroreg)("Nro_cliente")
        txtRazon_social.Text = Dt.Rows(NroReg)("razon_social")
        txtDomicilio.Text = Dt.Rows(NroReg)("domicilio")
        txtLocalidad.Text = Dt.Rows(NroReg)("localidad")
        txtCuit.Text = Dt.Rows(NroReg)("cuit")
        txtTelefono.Text = Dt.Rows(NroReg)("telefono")
        txtEmail.Text = Dt.Rows(NroReg)("email")

    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        nroreg = Dt.Rows.Count - 1
        LlenarTxt()

    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If nroreg <> Dt.Rows.Count - 1 Then
            nroreg = nroreg + 1
            LlenarTxt()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If nroreg <> 0 Then
            nroreg = nroreg - 1
            LlenarTxt()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        nroreg = 0
        LlenarTxt()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        nroreg = Dt.Rows.Count - 1
        txtNro_cliente.Text = Dt.Rows(nroreg)("Nro_cliente")
        txtNro_cliente.Text = txtNro_cliente.Text + 1
        txtRazon_social.Text = ""
        txtDomicilio.Text = ""
        txtLocalidad.Text = ""
        txtCuit.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        ' LlenarTxt()
        btnAgregar.Visible = False
        btnConfagregar.Visible = True
        txtRazon_social.Focus()
        txtRazon_social.ReadOnly = False
        txtDomicilio.ReadOnly = False
        txtLocalidad.ReadOnly = False
        txtCuit.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtEmail.ReadOnly = False
    End Sub

    Private Sub txtRazon_social_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazon_social.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtRazon_social.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If

    End Sub

    Private Sub txtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomicilio.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtDomicilio.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub txtLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocalidad.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtLocalidad.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub txtCuit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuit.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtCuit.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtTelefono.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtEmail.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub btnConfagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfagregar.Click

        Dim sqlstring As String
        Dim DBagregar As New OleDbCommand()
        If MsgBox("Confirma los valores a agregar ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then


            If IsNumeric(txtCuit.Text) Then
            Else
                MessageBox.Show("El Cuit debe ser numérico", "ERROR")
                txtCuit.Focus()
                Exit Sub
            End If
            If IsNumeric(txtTelefono.Text) Then
            Else
                MessageBox.Show("El Telefono debe ser numérico", "ERROR")
                txtTelefono.Focus()
                Exit Sub
            End If
        Else

            nroreg = 0
            LlenarTxt()
            btnAgregar.Visible = True
            btnConfagregar.Visible = False
            Exit Sub
        End If

        sqlstring = "Insert Into clientes(nro_cliente,razon_social,domicilio,localidad,cuit,telefono,email) " _
            & "Values (" _
            & "'" & txtNro_cliente.Text & "', " _
            & "'" & txtRazon_social.Text & "', " _
            & "'" & txtDomicilio.Text & "', " _
            & "'" & txtLocalidad.Text & "', " _
            & "'" & txtCuit.Text & "', " _
            & "'" & txtTelefono.Text & "', " _
            & "'" & txtEmail.Text & "') "

        DBagregar.CommandText = sqlstring
        DBagregar.Connection = Cn

        Try
            Cn.Open()

        Catch ex As Exception

        End Try



        DBagregar.ExecuteNonQuery()



        Cn.Close()
        Cn.Open()
        Dt.Clear()

        Da.Fill(Dt)
        nroreg = 0
        LlenarTxt()

        txtRazon_social.ReadOnly = True
        txtDomicilio.ReadOnly = True
        txtLocalidad.ReadOnly = True
        txtCuit.ReadOnly = True
        txtTelefono.ReadOnly = True
        txtEmail.ReadOnly = True
        MessageBox.Show("Se ha agregado un Registro")
        btnAgregar.Visible = True
        btnConfagregar.Visible = False

    End Sub

    Private Sub btnConfmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfmodificar.Click


        If MsgBox("Confirma los valores modificados ?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then
            If IsNumeric(txtCuit.Text) Then
            Else
                MessageBox.Show("El Cuit debe ser numérico", "ERROR")
                txtCuit.Focus()
                Exit Sub
            End If
            If IsNumeric(txtTelefono.Text) Then
            Else
                MessageBox.Show("El Telefono debe ser numérico", "ERROR")
                txtTelefono.Focus()
                Exit Sub
            End If
        Else
            nroreg = 0
            LlenarTxt()
            btnModificar.Visible = True
            btnConfmodificar.Visible = False
            Exit Sub
        End If
        sqlstr = "update clientes set " _
            & "nro_cliente=" & "'" & txtNro_cliente.Text & "', " _
            & "razon_social=" & "'" & txtRazon_social.Text & "', " _
            & "domicilio=" & "'" & txtDomicilio.Text & "', " _
            & "localidad=" & "'" & txtLocalidad.Text & "', " _
            & "cuit=" & "'" & txtCuit.Text & "', " _
            & "telefono=" & "'" & txtTelefono.Text & "', " _
            & "email = " & "'" & txtEmail.Text & "'  where nro_cliente= " & txtNro_cliente.Text



        Dim DBUpdate As New OleDbCommand()

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Try
            Cn.Open()

        Catch ex As Exception

        End Try


        Try


            DBUpdate.CommandText = sqlstr


            DBUpdate.Connection = Cn

            DBUpdate.ExecuteNonQuery()
            Cn.Close()
            Dt.Clear()

            Da.Fill(Dt)


            MessageBox.Show("Se ha modificado el Registro")


        Catch err As System.Exception


            nroreg = 0
            LlenarTxt()


        End Try
        txtRazon_social.ReadOnly = True
        txtDomicilio.ReadOnly = True
        txtLocalidad.ReadOnly = True
        txtCuit.ReadOnly = True
        txtTelefono.ReadOnly = True
        txtEmail.ReadOnly = True
        btnModificar.Visible = True
        btnConfmodificar.Visible = False

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim borrar As New OleDbCommand()


        If MsgBox("Esta seguro de borrar este registo?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then


            sqlstrborrar = "delete * from clientes where nro_cliente= " & txtNro_cliente.Text


            borrar.CommandText = sqlstrborrar

            borrar.Connection = Cn

            Try
                Cn.Open()
            Catch ex As Exception

            End Try



            Try
                Cn.Open()

            Catch ex As Exception

            End Try

            borrar.ExecuteNonQuery()

            MessageBox.Show("Se ha eliminado un registro")

            Da = New OleDb.OleDbDataAdapter("SELECT * from clientes order by nro_cliente", Cn.ConnectionString)

            Dt.Clear()
            Da.Fill(Dt)


            nroreg = 0
            LlenarTxt()

            Try
                Cn.Close()
            Catch ex As Exception

            End Try
        Else
            nroreg = 0
            LlenarTxt()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        btnModificar.Visible = False
        btnConfmodificar.Visible = True
        txtRazon_social.ReadOnly = False
        txtDomicilio.ReadOnly = False
        txtLocalidad.ReadOnly = False
        txtCuit.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtEmail.ReadOnly = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        btnLupa.Visible = True
        lblBuscar.Visible = True
        txtBuscacli.Visible = True
    End Sub

    Private Sub btnLupa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLupa.Click

        nrocliente = Integer.Parse(txtBuscacli.Text)

        sqlstrbuscar = "SELECT nro_cliente,razon_social,domicilio,localidad,cuit,telefono,email from clientes  where nro_cliente = " & nrocliente

        Da = New OleDb.OleDbDataAdapter(sqlstrbuscar, Cn.ConnectionString)
        'Label9.Text = nrocliente
        Try
            Dt.Clear()
            Da.Fill(Dt)
            LlenarTxt()

        Catch ex As Exception
            MessageBox.Show("El registro no exite", "Error")

            txtBuscacli.Clear()
            txtBuscacli.Focus()
        End Try
        txtBuscacli.Text = ""

        btnLupa.Enabled = False




    End Sub

    Private Sub PorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorToolStripMenuItem.Click
        FrmCLIlocalidad.ShowDialog()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        FrmCLIlistado.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PorCuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorCuitToolStripMenuItem.Click
        FrmCLIcuit.ShowDialog()
    End Sub

    Private Sub txtBuscacli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscacli.TextChanged
        btnLupa.Enabled = True
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLClientes.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCuit.Click

    End Sub
End Class
