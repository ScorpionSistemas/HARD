Imports System.Data.OleDb
Public Class frmALLIngresoUsu

    Public pRuta As String
    Public pUsuarioActivo As String
    Public pContraseñaActiva As String

    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim DA As New OleDb.OleDbDataAdapter
    Dim sqlstr As String
    Dim NroReg As Integer

    Private Sub frmIngresoUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pRuta = "C:\HARD.mdb"
    End Sub

    Function validar_usuario(ByVal Usuario As String) As Boolean

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pRuta)
        Cn.Open()

        DA = New OleDb.OleDbDataAdapter("SELECT Usuario from Usuarios where Usuario = '" & txtUsuario.Text & "'", Cn.ConnectionString)

        Dt.Clear()

        DA.Fill(Dt)
        Cn.Close()

        If Dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Function validar_contraseña(ByVal Contraseña As String) As Boolean
        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pRuta)
        Cn.Open()

        DA = New OleDb.OleDbDataAdapter("SELECT Contraseña from Usuarios where Contraseña = '" & txtContraseña.Text & "'", Cn.ConnectionString)

        Dt.Clear()

        DA.Fill(Dt)
        Cn.Close()

        If Dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If txtUsuario.Text = "" Then
            MessageBox.Show("Debe completar el campo Usuario para continuar", "Atencion")
            txtUsuario.Focus()
            Exit Sub
        Else

        End If


        If txtContraseña.Text = "" Then
            MessageBox.Show("Debe completar el campo contraseña para continuar", "Atencion")
            txtContraseña.Focus()
            Exit Sub
        Else

        End If


        If validar_usuario(txtUsuario.Text) = True Then

            pUsuarioActivo = txtUsuario.Text

        Else
            MessageBox.Show("Usuario Incorrecto", "Error")
            Exit Sub
        End If

        If validar_contraseña(txtContraseña.Text) = True Then
            pContraseñaActiva = txtContraseña.Text
            frmALLMenu.ShowDialog()
            Me.Close()

        Else
            MessageBox.Show("Contraseña Incorrecta", "Error")
            Exit Sub
        End If

    End Sub

    Private Sub btnAceptar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAceptar.KeyPress
        If txtUsuario.Text = "" Then
            MessageBox.Show("Debe completar el campo Usuario para continuar", "Atencion")
            txtUsuario.Focus()
            Exit Sub
        Else

        End If


        If txtContraseña.Text = "" Then
            MessageBox.Show("Debe completar el campo contraseña para continuar", "Atencion")
            txtContraseña.Focus()
            Exit Sub
        Else

        End If


        If validar_usuario(txtUsuario.Text) = True Then

            pUsuarioActivo = txtUsuario.Text

        Else
            MessageBox.Show("Usuario Incorrecto", "Error")
            Exit Sub
        End If

        If validar_contraseña(txtContraseña.Text) = True Then
            pContraseñaActiva = txtContraseña.Text
            frmALLMenu.ShowDialog()
            Me.Close()

        Else
            MessageBox.Show("Contraseña Incorrecta", "Error")
            Exit Sub
        End If
    End Sub

End Class
