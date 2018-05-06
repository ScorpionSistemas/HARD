Imports System.Data.OleDb
Public Class frmUSUABMUsuarios

    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim sqlstr As String
    Dim DNI As String
    Dim DNIMod As String
    Dim NroReg As Integer

    Private Sub DeshabilitarBotones()
        btnAgregar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnBuscar.Visible = False
        btnPrimero.Visible = False
        btnSiguiente.Visible = False
        btnAnterior.Visible = False
        btnUltimo.Visible = False
    End Sub

    Private Sub HabilitarCajastexto()
        txtApellido.ReadOnly = False
        txtContraseña.ReadOnly = False
        txtDNI.ReadOnly = False
        txtNombre.ReadOnly = False
        txtUsuario.ReadOnly = False

    End Sub
    Private Sub HabilitarBotones()
        btnPrimero.Visible = True
        btnSiguiente.Visible = True
        btnAnterior.Visible = True
        btnUltimo.Visible = True
        btnAgregar.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnBuscar.Visible = True
    End Sub
    Private Sub DeshabilitarBotonesConfirmar()
        btnConfAgregar.Visible = False
        btnConfEliminar.Visible = False
        btnConfModificar.Visible = False

    End Sub
    Private Sub DeshabilitarCajasTexto()
        txtApellido.ReadOnly = True
        txtContraseña.ReadOnly = True
        txtDNI.ReadOnly = True
        txtNombre.ReadOnly = True
        txtUsuario.ReadOnly = True


    End Sub
    Private Sub LlenarTxt()
        txtNombre.Text = Dt.Rows(NroReg)("Nombre")
        txtApellido.Text = Dt.Rows(NroReg)("Apellido")
        cmbRol.Text = Dt.Rows(NroReg)("Nivel")
        txtDNI.Text = Dt.Rows(NroReg)("DNI")
        txtUsuario.Text = Dt.Rows(NroReg)("Usuario")
        txtContraseña.Text = Dt.Rows(NroReg)("Contraseña")
    End Sub

    Private Sub Vaciarcajas()
        txtApellido.Text = ""
        txtContraseña.Text = ""
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtUsuario.Text = ""
    End Sub


    Private Sub frmModuloABMUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0
        btnBack.Visible = False


        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

        Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios", Cn.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)

        Cn.Close()

        LlenarTxt()

    End Sub

    Private Sub BtnPrimero_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrimero.Click

        NroReg = 0
        LlenarTxt()

    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click

        If NroReg <> Dt.Rows.Count - 1 Then
            NroReg = NroReg + 1
            LlenarTxt()
        Else
            Exit Sub

        End If

    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If NroReg <> 0 Then
            NroReg = NroReg - 1
            LlenarTxt()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub BtnUltimo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUltimo.Click

        NroReg = Dt.Rows.Count - 1
        LlenarTxt()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        txtNombre.Focus()
        DeshabilitarBotones()
        HabilitarCajastexto()
        Vaciarcajas()
        btnConfAgregar.Visible = True
        btnBack.Visible = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a modificar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If

        If txtApellido.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a modificar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If
        If txtContraseña.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a modificar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If
        If txtDNI.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a modificar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If
        If txtUsuario.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a modificar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub
        End If


        DeshabilitarBotones()
        HabilitarCajastexto()
        btnConfModificar.Visible = True
        btnBack.Visible = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a eliminar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If

        If txtApellido.Text = "" Then
            MessageBox.Show("Seleccione primero un registro  a eliminar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If
        If txtContraseña.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a eliminar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If
        If txtDNI.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a eliminar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If
        If txtUsuario.Text = "" Then
            MessageBox.Show("Seleccione primero un registro a eliminar", "ERROR")
            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            DeshabilitarCajasTexto()
            btnBack.Visible = False
            Exit Sub

        End If

        DeshabilitarBotones()
        btnConfEliminar.Visible = True
        btnBack.Visible = True
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        DeshabilitarBotonesConfirmar()
        HabilitarBotones()
        DeshabilitarCajasTexto()
        btnBack.Visible = False


    End Sub

    Private Sub btnConfAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfAgregar.Click

        Dim SQLString As String
        Dim DBInsert As New OleDbCommand()

        If MsgBox("¿Confirma los valores a agregar?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
            DNI = txtDNI.Text
            If txtNombre.Text = "" Then
                MessageBox.Show("Debe completar el nombre", "Error")
                txtNombre.Focus()
                Exit Sub
            End If
            If txtApellido.Text = "" Then
                MessageBox.Show("Debe completar el apellido", "Error")
                txtApellido.Focus()
                Exit Sub
            End If

            If DNI.Length > 7 Then
            Else
                MessageBox.Show("Formato de DNI incorrecto", "Error")
                txtDNI.Focus()
                Exit Sub
            End If
            If txtUsuario.Text = "" Then
                MessageBox.Show("Debe completar un Usuario", "Error")
                txtUsuario.Focus()
                Exit Sub
            End If
            If txtContraseña.Text = "" Then
                MessageBox.Show("Debe completar una contraseña", "Error")
                txtContraseña.Focus()
                Exit Sub
            End If

            SQLString = "Insert Into Usuarios (Nombre, Apellido, Nivel, DNI, Usuario, Contraseña) " _
            & "Values (" _
            & "'" & txtNombre.Text & "', " _
            & "'" & txtApellido.Text & "', " _
            & "'" & cmbRol.Text & "', " _
            & "'" & txtDNI.Text & "', " _
            & "'" & txtUsuario.Text & "', " _
            & "'" & txtContraseña.Text & "') "

            DBInsert.CommandText = SQLString
            DBInsert.Connection = Cn


            Try
                Cn.Open()
            Catch ex As Exception

            End Try


            DBInsert.ExecuteNonQuery()

            Cn.Close()
            Cn.Open()
            Dt.Clear()

            Da.Fill(Dt)

            LlenarTxt()


            MessageBox.Show("Registro agregado con éxito")

        End If
        DeshabilitarBotonesConfirmar()
        HabilitarBotones()

    End Sub

    Private Sub btnConfModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfModificar.Click
        Dim SQLStrMod As String

        If MsgBox("¿Confirma los valores a agregar?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then

            DNIMod = txtDNI.Text

            If txtNombre.Text = "" Then
                MessageBox.Show("Debe completar el nombre", "Error")
                txtNombre.Focus()
                Exit Sub
            End If
            If txtApellido.Text = "" Then
                MessageBox.Show("Debe completar el apellido", "Error")
                txtApellido.Focus()
                Exit Sub
            End If

            If DNIMod.Length > 7 Then
            Else
                MessageBox.Show("Formato de DNI incorrecto", "Error")
                txtDNI.Focus()
                Exit Sub
            End If
            If txtUsuario.Text = "" Then
                MessageBox.Show("Debe completar un Usuario", "Error")
                txtUsuario.Focus()
                Exit Sub
            End If
            If txtContraseña.Text = "" Then
                MessageBox.Show("Debe completar una contraseña", "Error")
                txtContraseña.Focus()
                Exit Sub
            End If

            SQLStrMod = "Update Usuarios set " _
           & "Nombre=" & "'" & txtNombre.Text & "', " _
           & "Apellido=" & "'" & txtApellido.Text & "', " _
           & "Nivel=" & "'" & cmbRol.Text & "', " _
           & "DNI=" & "'" & txtDNI.Text & "', " _
           & "Usuario=" & "'" & txtUsuario.Text & "', " _
           & "Contraseña=" & "'" & txtContraseña.Text & "' where DNI=" & DNIMod

            Dim DBUpdate As New OleDb.OleDbCommand()

            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)

            Try
                Cn.Open()

            Catch ex As Exception

            End Try

            Try
                DBUpdate.CommandText = SQLStrMod

                DBUpdate.Connection = Cn

                DBUpdate.ExecuteNonQuery()
                Cn.Close()
                Dt.Clear()

                Da.Fill(Dt)


                MessageBox.Show("Se ha modificado el Registro")

            Catch ex As Exception

                MessageBox.Show("No se ha modificado el registro", "ERROR")
                NroReg = 0
                LlenarTxt()
            End Try

            DeshabilitarBotonesConfirmar()
            HabilitarBotones()
            btnBack.Visible = False
        End If
    End Sub

    Private Sub btnConfEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfEliminar.Click
        Dim Comando_Borrar As New OleDbCommand()

        If MsgBox("¿Está seguro de borrar este registo?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
            sqlstr = "delete * from Usuarios where DNI= " & txtDNI.Text()

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

            MessageBox.Show("Se ha eliminado el registro")

            Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios", Cn.ConnectionString)

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
        btnBack.Visible = False

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        frmUSUBuscarUsuario.ShowDialog()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class

