Imports System.Data.OleDb
Public Class frmUSUBuscarUsuario
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim sqlstr As String
    Dim NroReg As Integer

    Private Sub LlenarTxt()
        txtNombre.Text = Dt.Rows(NroReg)("Nombre")
        txtApellido.Text = Dt.Rows(NroReg)("Apellido")
        txtDNI.Text = Dt.Rows(NroReg)("DNI")
        txtUsuario.Text = Dt.Rows(NroReg)("Usuario")
        txtContraseña.Text = Dt.Rows(NroReg)("Contraseña")
        txtRol.Text = Dt.Rows(NroReg)("Nivel")
    End Sub
    Private Sub btnBuscarNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarNombre.Click
        btnAceptar.Visible = True
        txtNombre.Focus()
        txtNombre.ReadOnly = False
        txtApellido.ReadOnly = True
        txtDNI.ReadOnly = True
        txtRol.ReadOnly = True
        txtUsuario.ReadOnly = True
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtRol.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub btnBuscarApellido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarApellido.Click
        btnAceptar.Visible = True
        txtApellido.Focus()
        txtNombre.ReadOnly = True
        txtApellido.ReadOnly = False
        txtDNI.ReadOnly = True
        txtRol.ReadOnly = True
        txtUsuario.ReadOnly = True
        txtNombre.Text = ""
        txtDNI.Text = ""
        txtRol.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtApellido.Text = ""
    End Sub

    Private Sub btnBuscarDNI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDNI.Click
        btnAceptar.Visible = True
        txtDNI.Focus()
        txtNombre.ReadOnly = True
        txtApellido.ReadOnly = True
        txtDNI.ReadOnly = False
        txtRol.ReadOnly = True
        txtUsuario.ReadOnly = True
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtRol.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtDNI.Text = ""

    End Sub

    Private Sub btnBuscarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarUsuario.Click
        btnAceptar.Visible = True
        txtUsuario.Focus()
        txtNombre.ReadOnly = True
        txtApellido.ReadOnly = True
        txtDNI.ReadOnly = True
        txtRol.ReadOnly = True
        txtUsuario.ReadOnly = False
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtRol.Text = ""
        txtContraseña.Text = ""
        txtUsuario.Text = ""
    End Sub

    Private Sub btnBuscarRol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarRol.Click
        btnAceptar.Visible = True
        txtRol.Focus()
        txtNombre.ReadOnly = True
        txtApellido.ReadOnly = True
        txtDNI.ReadOnly = True
        txtRol.ReadOnly = False
        txtUsuario.ReadOnly = True
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtRol.Text = ""
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        btnAceptar.Visible = False

        If txtNombre.ReadOnly = False Then
            If txtNombre.Text = "" Then
                MessageBox.Show("Debe completar con un nombre", "Atención")
                txtNombre.Focus()
                Exit Sub
            End If
            Try
                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()
                Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios where Nombre like '%" & txtNombre.Text & "%'", Cn.ConnectionString)

                Dt.Clear()
                Da.Fill(Dt)
                Cn.Close()
                LlenarTxt()
            Catch
                MessageBox.Show("El nombre no existe", "Atención")
                txtNombre.Focus()
                btnAceptar.Visible = True
                btnBack.Visible = False
            End Try
        End If

        If txtApellido.ReadOnly = False Then
            If txtApellido.Text = "" Then
                MessageBox.Show("Debe completar con un apellido", "Atención")
                txtApellido.Focus()
                Exit Sub
            End If
            Try
                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()
                Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios where Apellido like '%" & txtApellido.Text & "%'", Cn.ConnectionString)

                Dt.Clear()
                Da.Fill(Dt)
                Cn.Close()
                LlenarTxt()
            Catch
                MessageBox.Show("El apellido no existe", "Atención")
                txtNombre.Focus()
                btnAceptar.Visible = True
                btnBack.Visible = False
            End Try
        End If
        If txtDNI.ReadOnly = False Then
            If txtDNI.Text = "" Then
                MessageBox.Show("Debe completar con un DNI", "Atención")
                txtDNI.Focus()
                Exit Sub
            End If
            Try
                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()
                Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios where DNI=" & txtDNI.Text, Cn.ConnectionString)

                Dt.Clear()
                Da.Fill(Dt)
                Cn.Close()
                LlenarTxt()
            Catch
                MessageBox.Show("El DNI no existe", "Error")
                txtDNI.Focus()
                btnAceptar.Visible = True
            End Try

        End If
        If txtUsuario.ReadOnly = False Then
            If txtUsuario.Text = "" Then
                MessageBox.Show("Debe completar con un usuario", "Atención")
                txtUsuario.Focus()
                Exit Sub
            End If
            Try
                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()
                Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios where Usuario like '%" & txtUsuario.Text & "%'", Cn.ConnectionString)

                Dt.Clear()
                Da.Fill(Dt)
                Cn.Close()
                LlenarTxt()
            Catch
                MessageBox.Show("El usuario no existe", "Atención")
                txtNombre.Focus()
                btnAceptar.Visible = True
            End Try
        End If
        If txtRol.ReadOnly = False Then
            If txtRol.Text = "" Then
                MessageBox.Show("Debe completar con un rol", "Atención")
                txtRol.Focus()
                Exit Sub
            End If
            Try
                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
                Cn.Open()
                Da = New OleDb.OleDbDataAdapter("SELECT * from Usuarios where Nivel like '%" & txtRol.Text & "%'", Cn.ConnectionString)

                Dt.Clear()
                Da.Fill(Dt)
                Cn.Close()
                LlenarTxt()
            Catch
                MessageBox.Show("El Rol no existe", "Atención")
                txtNombre.Focus()
                btnAceptar.Visible = True
            End Try
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Try
            If NroReg <> Dt.Rows.Count - 1 Then
                NroReg = NroReg + 1
                LlenarTxt()
            Else
                Exit Sub

            End If
        Catch ex As Exception
            MessageBox.Show("Sin información", "ERROR")
        End Try
        
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnterior.Click

        Try
            If NroReg <> 0 Then
                NroReg = NroReg - 1
                LlenarTxt()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Sin información", "ERROR")
        End Try
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Try
            NroReg = Dt.Rows.Count - 1
            LlenarTxt()
        Catch ex As Exception
            MessageBox.Show("Sin información", "ERROR")
        End Try
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Try
            NroReg = 0
            LlenarTxt()
        Catch ex As Exception
            MessageBox.Show("Sin información", "ERROR")
        End Try
    End Sub

    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtApellido.Text = ""
        txtContraseña.Text = ""
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtRol.Text = ""
        txtUsuario.Text = ""
        btnAceptar.Visible = True

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class