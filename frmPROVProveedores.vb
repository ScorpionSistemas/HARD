Public Class frmPROVProveedores
    Dim Cn As New OleDb.OleDbConnection
    Dim Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim Stringsql As String
    Dim NroReg, nro_proveedor As Integer

    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuarioActivo.Text = frmALLIngresoUsu.pUsuarioActivo

        NroReg = 0

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
        Cn.Open()

        Stringsql = "SELECT * from Proveedores order by CodigoProveedor"
        Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

        Dt.Clear()

        Da.Fill(Dt)

        Cn.Close()

        LlenarProveedores()



    End Sub
    Public Sub LlenarProveedores()
        txtCodigoprov.Text = Dt.Rows(NroReg)("CodigoProveedor")
        txtNombreprov.Text = Dt.Rows(NroReg)("RazonSocial")
        txtDomiciloprov.Text = Dt.Rows(NroReg)("Domicilio")
        txtLocalidadprov.Text = Dt.Rows(NroReg)("Localidad")
        txtCuitprov.Text = Dt.Rows(NroReg)("CUIT")
        txtTelprov.Text = Dt.Rows(NroReg)("Telefono")
        txtRubroprov.Text = Dt.Rows(NroReg)("Rubro")
        txtEmailprov.Text = Dt.Rows(NroReg)("E-mail")

    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        NroReg = 0
        LlenarProveedores()

    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        NroReg = Dt.Rows.Count - 1
        LlenarProveedores()


    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click

        If NroReg <> 0 Then
            NroReg = NroReg - 1
            LlenarProveedores()
        Else
            Exit Sub

        End If


    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click

        If NroReg <> Dt.Rows.Count - 1 Then
            NroReg = NroReg + 1
            LlenarProveedores()
        Else
            Exit Sub

        End If


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        NroReg = Dt.Rows.Count
        nro_proveedor = NroReg + 1
        txtCodigoprov.Text = nro_proveedor
        txtNombreprov.Focus()


        txtNombreprov.Text = ""
        txtDomiciloprov.Text = ""
        txtLocalidadprov.Text = ""
        txtCuitprov.Text = ""
        txtTelprov.Text = ""
        txtRubroprov.Text = ""
        txtEmailprov.Text = ""

        txtCodigoprov.ReadOnly = True
        txtNombreprov.ReadOnly = False
        txtDomiciloprov.ReadOnly = False
        txtLocalidadprov.ReadOnly = False
        txtCuitprov.ReadOnly = False
        txtTelprov.ReadOnly = False
        txtRubroprov.ReadOnly = False
        txtEmailprov.ReadOnly = False


        btnCodProv.Visible = False
        btnListadoProveedores.Visible = False
        btnPrimero.Visible = False
        btnAnterior.Visible = False
        btnSiguiente.Visible = False
        btnUltimo.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnNuevo.Visible = False
        btnVolverInicio.Visible = False
        txtBuscarCodigo.Visible = False
        btnBuscarxLocalProv.Visible = False

        btnCancelar.Visible = True
        btnConfirmarNuevo.Visible = True



    End Sub

    Private Sub btnConfirmarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarNuevo.Click

        If txtNombreprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Razon Social", "Atención", MessageBoxButtons.OK)
            txtNombreprov.Clear()
            txtNombreprov.Focus()
            Exit Sub
        Else

        End If

        If txtDomiciloprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Domicilio", "Atención", MessageBoxButtons.OK)
            txtDomiciloprov.Clear()
            txtDomiciloprov.Focus()
            Exit Sub
        Else
        End If

        If txtLocalidadprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Localidad", "Atención", MessageBoxButtons.OK)
            txtLocalidadprov.Clear()
            txtLocalidadprov.Focus()
            Exit Sub
        Else
        End If

        If txtCuitprov.Text = "" Then

            MessageBox.Show("Debe completar el campo CUIT", "Atención", MessageBoxButtons.OK)
            txtCuitprov.Clear()
            txtCuitprov.Focus()
            Exit Sub

        Else
        End If

        If IsNumeric(txtCuitprov.Text) Then
        Else
            MessageBox.Show("Debe completar campo CUIT solo con numeros", "Atención", MessageBoxButtons.OK)
            txtCuitprov.Clear()
            txtCuitprov.Focus()
            Exit Sub
        End If

        If txtTelprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Telefono", "Atención", MessageBoxButtons.OK)
            txtTelprov.Clear()
            txtTelprov.Focus()
            Exit Sub

        Else
        End If

        If IsNumeric(txtTelprov.Text) Then
        Else
            MessageBox.Show("Debe completar campo Telefono solo con numeros", "Atención", MessageBoxButtons.OK)
            txtTelprov.Clear()
            txtTelprov.Focus()
            Exit Sub
        End If



        If txtRubroprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Rubro", "Atención", MessageBoxButtons.OK)
            txtRubroprov.Clear()
            txtRubroprov.Focus()
            Exit Sub
        Else

        End If

        If txtEmailprov.Text = "" Then

            MessageBox.Show("Debe completar el campo E-mail", "Atención", MessageBoxButtons.OK)
            txtEmailprov.Clear()
            txtEmailprov.Focus()
            Exit Sub
        Else

        End If


        Dim Insertar As New OleDb.OleDbCommand()


        If MsgBox("¿Confirma los valores a agregar?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then



            Try
                Insertar.CommandText = ("insert into Proveedores values (" & txtCodigoprov.Text & ",'" & txtNombreprov.Text & "','" & txtDomiciloprov.Text & "','" & txtLocalidadprov.Text & "'," & txtCuitprov.Text & "," & txtTelprov.Text & ",'" & txtRubroprov.Text & "','" & txtEmailprov.Text & "')")

                Insertar.Connection = Cn

                Try
                    Cn.Open()

                Catch ex As Exception

                End Try

                Insertar.ExecuteNonQuery()

                Cn.Close()
                Cn.Open()
                Dt.Clear()

                Da.Fill(Dt)

                LlenarProveedores()

                MessageBox.Show("Se ha agregado un nuevo registro", "Atencion")


            Catch ex As Exception

                MessageBox.Show("No se pudo ingresar el registro", "ERROR")
                NroReg = 0
                LlenarProveedores()

                txtCodigoprov.ReadOnly = True
                txtNombreprov.ReadOnly = True
                txtDomiciloprov.ReadOnly = True
                txtLocalidadprov.ReadOnly = True
                txtCuitprov.ReadOnly = True
                txtTelprov.ReadOnly = True
                txtRubroprov.ReadOnly = True
                txtEmailprov.ReadOnly = True

                btnCodProv.Visible = True
                btnListadoProveedores.Visible = True
                btnPrimero.Visible = True
                btnAnterior.Visible = True
                btnSiguiente.Visible = True
                btnUltimo.Visible = True
                btnModificar.Visible = True
                btnEliminar.Visible = True
                btnNuevo.Visible = True
                btnVolverInicio.Visible = True
                txtBuscarCodigo.Visible = True
                btnBuscarxLocalProv.Visible = True


                btnCancelar.Visible = False
                btnConfirmarNuevo.Visible = False
                Exit Sub

            End Try


        ElseIf MsgBoxResult.No Then

            NroReg = Dt.Rows.Count
            nro_proveedor = NroReg + 1
            txtCodigoprov.Text = nro_proveedor

            txtNombreprov.Focus()
            Exit Sub

        End If



        txtCodigoprov.ReadOnly = True
        txtNombreprov.ReadOnly = True
        txtDomiciloprov.ReadOnly = True
        txtLocalidadprov.ReadOnly = True
        txtCuitprov.ReadOnly = True
        txtTelprov.ReadOnly = True
        txtRubroprov.ReadOnly = True
        txtEmailprov.ReadOnly = True

        btnCodProv.Visible = True
        btnListadoProveedores.Visible = True
        btnPrimero.Visible = True
        btnAnterior.Visible = True
        btnSiguiente.Visible = True
        btnUltimo.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnNuevo.Visible = True
        btnVolverInicio.Visible = True
        txtBuscarCodigo.Visible = True
        btnBuscarxLocalProv.Visible = True


        btnCancelar.Visible = False
        btnConfirmarNuevo.Visible = False


        Cn.Close()


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        If MsgBox("¿Desea cancelar la operacion?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then

            NroReg = 0

            txtCodigoprov.ReadOnly = True
            txtNombreprov.ReadOnly = True
            txtDomiciloprov.ReadOnly = True
            txtLocalidadprov.ReadOnly = True
            txtCuitprov.ReadOnly = True
            txtTelprov.ReadOnly = True
            txtRubroprov.ReadOnly = True
            txtEmailprov.ReadOnly = True

            btnCodProv.Visible = True
            btnListadoProveedores.Visible = True
            btnPrimero.Visible = True
            btnAnterior.Visible = True
            btnSiguiente.Visible = True
            btnUltimo.Visible = True
            btnModificar.Visible = True
            btnEliminar.Visible = True
            btnNuevo.Visible = True
            btnVolverInicio.Visible = True
            txtBuscarCodigo.Visible = True
            btnBuscarxLocalProv.Visible = True

            btnConfirmarModificar.Visible = False
            btnCancelar.Visible = False
            btnConfirmarNuevo.Visible = False

        ElseIf MsgBoxResult.No Then

            NroReg = Dt.Rows.Count
            nro_proveedor = NroReg + 1
            txtCodigoprov.Text = nro_proveedor

            txtNombreprov.Focus()
            Exit Sub

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        txtNombreprov.Focus()

        txtCodigoprov.ReadOnly = True
        txtNombreprov.ReadOnly = False
        txtDomiciloprov.ReadOnly = False
        txtLocalidadprov.ReadOnly = False
        txtCuitprov.ReadOnly = False
        txtTelprov.ReadOnly = False
        txtRubroprov.ReadOnly = False
        txtEmailprov.ReadOnly = False

        btnCodProv.Visible = False
        btnListadoProveedores.Visible = False
        btnPrimero.Visible = False
        btnAnterior.Visible = False
        btnSiguiente.Visible = False
        btnUltimo.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnNuevo.Visible = False
        btnVolverInicio.Visible = False
        txtBuscarCodigo.Visible = False
        btnBuscarxLocalProv.Visible = False


        btnCancelar.Visible = True
        btnConfirmarModificar.Visible = True

    End Sub


    Private Sub btnConfirmarModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmarModificar.Click
        If txtNombreprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Razon Social", "Atención", MessageBoxButtons.OK)
            txtNombreprov.Clear()
            txtNombreprov.Focus()
            Exit Sub
        Else

        End If

        If txtDomiciloprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Domicilio", "Atención", MessageBoxButtons.OK)
            txtDomiciloprov.Clear()
            txtDomiciloprov.Focus()
            Exit Sub
        Else
        End If

        If txtLocalidadprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Localidad", "Atención", MessageBoxButtons.OK)
            txtLocalidadprov.Clear()
            txtLocalidadprov.Focus()
            Exit Sub
        Else
        End If

        If txtCuitprov.Text = "" Then

            MessageBox.Show("Debe completar el campo CUIT", "Atención", MessageBoxButtons.OK)
            txtCuitprov.Clear()
            txtCuitprov.Focus()
            Exit Sub

        Else
        End If

        If IsNumeric(txtCuitprov.Text) Then
        Else
            MessageBox.Show("Debe completar campo CUIT solo con numeros", "Atención", MessageBoxButtons.OK)
            txtCuitprov.Clear()
            txtCuitprov.Focus()
            Exit Sub
        End If

        If txtTelprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Telefono", "Atención", MessageBoxButtons.OK)
            txtTelprov.Clear()
            txtTelprov.Focus()
            Exit Sub

        Else
        End If

        If IsNumeric(txtTelprov.Text) Then
        Else
            MessageBox.Show("Debe completar campo Telefono solo con numeros", "Atención", MessageBoxButtons.OK)
            txtTelprov.Clear()
            txtTelprov.Focus()
            Exit Sub
        End If



        If txtRubroprov.Text = "" Then

            MessageBox.Show("Debe completar el campo Rubro", "Atención", MessageBoxButtons.OK)
            txtRubroprov.Clear()
            txtRubroprov.Focus()
            Exit Sub
        Else

        End If

        If txtEmailprov.Text = "" Then

            MessageBox.Show("Debe completar el campo E-mail", "Atención", MessageBoxButtons.OK)
            txtEmailprov.Clear()
            txtEmailprov.Focus()
            Exit Sub
        Else

        End If



        Dim SqlStr As String

        If MsgBox("¿Confirma los valores modificados?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then



            SqlStr = "update Proveedores set CodigoProveedor=" & "'" & txtCodigoprov.Text & "', " & "RazonSocial=" & " '" & txtNombreprov.Text & "', " & "Domicilio=" & "'" & txtDomiciloprov.Text & "', " & "Localidad=" & "'" & txtLocalidadprov.Text & "', " & "CUIT=" & "'" & txtCuitprov.Text & "', " & "Telefono=" & "'" & txtTelprov.Text & "', " & "Rubro=" & "'" & txtRubroprov.Text & "', " & "E-mail=" & "'" & txtEmailprov.Text & "' where CodigoProveedor= " & txtCodigoprov.Text

            Dim Modificar As New OleDb.OleDbCommand()

            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)

            Try
                Cn.Open()

            Catch ex As Exception

            End Try
            Try
                Modificar.CommandText = SqlStr
                Modificar.Connection = Cn
                Modificar.ExecuteNonQuery()
                Cn.Close()

                Dt.Clear()
                Da.Fill(Dt)

                MessageBox.Show("Se han modificado correctamente los registros", "Atencion")


            Catch ex As Exception

                MessageBox.Show("No se pudieron modificar los registros", "ERROR")
                LlenarProveedores()

                txtCodigoprov.ReadOnly = True
                txtNombreprov.ReadOnly = True
                txtDomiciloprov.ReadOnly = True
                txtLocalidadprov.ReadOnly = True
                txtCuitprov.ReadOnly = True
                txtTelprov.ReadOnly = True
                txtRubroprov.ReadOnly = True
                txtEmailprov.ReadOnly = True

                btnCodProv.Visible = True
                btnListadoProveedores.Visible = True
                btnPrimero.Visible = True
                btnAnterior.Visible = True
                btnSiguiente.Visible = True
                btnUltimo.Visible = True
                btnModificar.Visible = True
                btnEliminar.Visible = True
                btnNuevo.Visible = True
                btnVolverInicio.Visible = True
                txtBuscarCodigo.Visible = True
                btnBuscarxLocalProv.Visible = True



                btnCancelar.Visible = False
                btnConfirmarModificar.Visible = False

                Exit Sub

            End Try


        ElseIf MsgBoxResult.No Then

            txtNombreprov.Focus()
            Exit Sub

        End If



        txtCodigoprov.ReadOnly = True
        txtNombreprov.ReadOnly = True
        txtDomiciloprov.ReadOnly = True
        txtLocalidadprov.ReadOnly = True
        txtCuitprov.ReadOnly = True
        txtTelprov.ReadOnly = True
        txtRubroprov.ReadOnly = True
        txtEmailprov.ReadOnly = True

        btnCodProv.Visible = True
        btnListadoProveedores.Visible = True
        btnPrimero.Visible = True
        btnAnterior.Visible = True
        btnSiguiente.Visible = True
        btnUltimo.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnNuevo.Visible = True
        btnVolverInicio.Visible = True
        txtBuscarCodigo.Visible = True
        btnBuscarxLocalProv.Visible = True


        btnCancelar.Visible = False
        btnConfirmarModificar.Visible = False


        Cn.Close()



    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        Dim SqlStr As String


        If MsgBox("¿Desea eluminar los registros?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.Yes Then

            Try

                SqlStr = "delete from Proveedores where CodigoProveedor = " & txtCodigoprov.Text

                Dim Borrar As New OleDb.OleDbCommand()

                Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)

                Try
                    Cn.Open()

                Catch ex As Exception

                End Try

                Borrar.CommandText = SqlStr
                Borrar.Connection = Cn
                Borrar.ExecuteNonQuery()
                Cn.Close()

                Dt.Clear()
                Da.Fill(Dt)

                MessageBox.Show("Se han eliminado los registros correctamente", "Atencion")
                NroReg = Dt.Rows.Count - 1
                LlenarProveedores()

            Catch ex As Exception

                MessageBox.Show("No se pudo elminar los registros", "ERROR")


                Exit Sub

            End Try


        ElseIf MsgBoxResult.No Then

            Exit Sub

        End If

    End Sub

    Private Sub btnCodProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodProv.Click

        If txtBuscarCodigo.Text = "" Then
            MessageBox.Show("Debe completar el cuadro de texto para poder buscar", "Atencion")
            txtBuscarCodigo.Focus()
            Exit Sub
        Else
        End If


        If IsNumeric(txtBuscarCodigo.Text) Then

            NroReg = 0

            Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frmALLIngresoUsu.pRuta)
            Cn.Open()

            Stringsql = "SELECT * from Proveedores where CodigoProveedor=" & txtBuscarCodigo.Text
            Da = New OleDb.OleDbDataAdapter(Stringsql, Cn.ConnectionString)

            Dt.Clear()

            Da.Fill(Dt)

            Cn.Close()

            LlenarProveedores()

        Else
            MessageBox.Show("El campo completado deben ser solo numeros", "Atencion")
            txtBuscarCodigo.Focus()

            Exit Sub

        End If



    End Sub



    Private Sub btnListadoProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoProveedores.Click
        Try

            frmPROVListadoProveedores.ShowDialog()

        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub btnBuscarxLocalProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarxLocalProv.Click
        Try

            frmPROVBusquedaLocalidadProv.ShowDialog()

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Private Sub btnVolverInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverInicio.Click
        Try

            frmALLMenu.Show()
            Me.Close()

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub
End Class
