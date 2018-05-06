<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROVProveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCodigoprov = New System.Windows.Forms.TextBox
        Me.txtNombreprov = New System.Windows.Forms.TextBox
        Me.txtDomiciloprov = New System.Windows.Forms.TextBox
        Me.txtLocalidadprov = New System.Windows.Forms.TextBox
        Me.txtCuitprov = New System.Windows.Forms.TextBox
        Me.txtTelprov = New System.Windows.Forms.TextBox
        Me.txtRubroprov = New System.Windows.Forms.TextBox
        Me.txtEmailprov = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnCodProv = New System.Windows.Forms.Button
        Me.btnListadoProveedores = New System.Windows.Forms.Button
        Me.btnPrimero = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnConfirmarNuevo = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnConfirmarModificar = New System.Windows.Forms.Button
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox
        Me.btnBuscarxLocalProv = New System.Windows.Forms.Button
        Me.btnVolverInicio = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCodigoprov
        '
        Me.txtCodigoprov.Location = New System.Drawing.Point(225, 185)
        Me.txtCodigoprov.Name = "txtCodigoprov"
        Me.txtCodigoprov.ReadOnly = True
        Me.txtCodigoprov.Size = New System.Drawing.Size(216, 20)
        Me.txtCodigoprov.TabIndex = 0
        '
        'txtNombreprov
        '
        Me.txtNombreprov.Location = New System.Drawing.Point(225, 225)
        Me.txtNombreprov.Name = "txtNombreprov"
        Me.txtNombreprov.ReadOnly = True
        Me.txtNombreprov.Size = New System.Drawing.Size(216, 20)
        Me.txtNombreprov.TabIndex = 1
        '
        'txtDomiciloprov
        '
        Me.txtDomiciloprov.Location = New System.Drawing.Point(225, 265)
        Me.txtDomiciloprov.Name = "txtDomiciloprov"
        Me.txtDomiciloprov.ReadOnly = True
        Me.txtDomiciloprov.Size = New System.Drawing.Size(216, 20)
        Me.txtDomiciloprov.TabIndex = 2
        '
        'txtLocalidadprov
        '
        Me.txtLocalidadprov.Location = New System.Drawing.Point(225, 305)
        Me.txtLocalidadprov.Name = "txtLocalidadprov"
        Me.txtLocalidadprov.ReadOnly = True
        Me.txtLocalidadprov.Size = New System.Drawing.Size(216, 20)
        Me.txtLocalidadprov.TabIndex = 3
        '
        'txtCuitprov
        '
        Me.txtCuitprov.Location = New System.Drawing.Point(225, 345)
        Me.txtCuitprov.Name = "txtCuitprov"
        Me.txtCuitprov.ReadOnly = True
        Me.txtCuitprov.Size = New System.Drawing.Size(216, 20)
        Me.txtCuitprov.TabIndex = 4
        '
        'txtTelprov
        '
        Me.txtTelprov.Location = New System.Drawing.Point(225, 385)
        Me.txtTelprov.Name = "txtTelprov"
        Me.txtTelprov.ReadOnly = True
        Me.txtTelprov.Size = New System.Drawing.Size(216, 20)
        Me.txtTelprov.TabIndex = 5
        '
        'txtRubroprov
        '
        Me.txtRubroprov.Location = New System.Drawing.Point(225, 425)
        Me.txtRubroprov.Name = "txtRubroprov"
        Me.txtRubroprov.ReadOnly = True
        Me.txtRubroprov.Size = New System.Drawing.Size(216, 20)
        Me.txtRubroprov.TabIndex = 6
        '
        'txtEmailprov
        '
        Me.txtEmailprov.Location = New System.Drawing.Point(225, 465)
        Me.txtEmailprov.Name = "txtEmailprov"
        Me.txtEmailprov.ReadOnly = True
        Me.txtEmailprov.Size = New System.Drawing.Size(216, 20)
        Me.txtEmailprov.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nro. Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Razon Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nro. Cuit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Rubro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 457)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "E-mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(255, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 31)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "PROVEEDORES"
        '
        'btnCodProv
        '
        Me.btnCodProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCodProv.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnCodProv.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCodProv.Location = New System.Drawing.Point(488, 432)
        Me.btnCodProv.Name = "btnCodProv"
        Me.btnCodProv.Size = New System.Drawing.Size(122, 49)
        Me.btnCodProv.TabIndex = 17
        Me.btnCodProv.Text = "Buscar por Código"
        Me.btnCodProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCodProv.UseVisualStyleBackColor = False
        '
        'btnListadoProveedores
        '
        Me.btnListadoProveedores.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListadoProveedores.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnListadoProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnListadoProveedores.Location = New System.Drawing.Point(494, 196)
        Me.btnListadoProveedores.Name = "btnListadoProveedores"
        Me.btnListadoProveedores.Size = New System.Drawing.Size(122, 63)
        Me.btnListadoProveedores.TabIndex = 18
        Me.btnListadoProveedores.Text = "Búsqueda por Razon Social"
        Me.btnListadoProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListadoProveedores.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(209, 500)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(62, 23)
        Me.btnPrimero.TabIndex = 19
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(284, 500)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(45, 23)
        Me.btnAnterior.TabIndex = 20
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(335, 500)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(45, 23)
        Me.btnSiguiente.TabIndex = 21
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(389, 500)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(67, 23)
        Me.btnUltimo.TabIndex = 22
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNuevo.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.agregar
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(75, 68)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(160, 62)
        Me.btnNuevo.TabIndex = 23
        Me.btnNuevo.Text = "Agregar"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(247, 68)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(168, 62)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.ELIMINAR
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(421, 68)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(162, 62)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = "Eliminar "
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnConfirmarNuevo
        '
        Me.btnConfirmarNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmarNuevo.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnConfirmarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmarNuevo.Location = New System.Drawing.Point(353, 539)
        Me.btnConfirmarNuevo.Name = "btnConfirmarNuevo"
        Me.btnConfirmarNuevo.Size = New System.Drawing.Size(168, 55)
        Me.btnConfirmarNuevo.TabIndex = 26
        Me.btnConfirmarNuevo.Text = "Confirmar"
        Me.btnConfirmarNuevo.UseVisualStyleBackColor = False
        Me.btnConfirmarNuevo.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(184, 539)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(163, 55)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'btnConfirmarModificar
        '
        Me.btnConfirmarModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmarModificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnConfirmarModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmarModificar.Location = New System.Drawing.Point(353, 539)
        Me.btnConfirmarModificar.Name = "btnConfirmarModificar"
        Me.btnConfirmarModificar.Size = New System.Drawing.Size(168, 55)
        Me.btnConfirmarModificar.TabIndex = 28
        Me.btnConfirmarModificar.Text = "Confirmar"
        Me.btnConfirmarModificar.UseVisualStyleBackColor = False
        Me.btnConfirmarModificar.Visible = False
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(520, 400)
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(64, 20)
        Me.txtBuscarCodigo.TabIndex = 29
        Me.txtBuscarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarxLocalProv
        '
        Me.btnBuscarxLocalProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarxLocalProv.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscarxLocalProv.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarxLocalProv.Location = New System.Drawing.Point(494, 265)
        Me.btnBuscarxLocalProv.Name = "btnBuscarxLocalProv"
        Me.btnBuscarxLocalProv.Size = New System.Drawing.Size(122, 60)
        Me.btnBuscarxLocalProv.TabIndex = 30
        Me.btnBuscarxLocalProv.Text = "Búsqueda por Localidad"
        Me.btnBuscarxLocalProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscarxLocalProv.UseVisualStyleBackColor = False
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolverInicio.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnVolverInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverInicio.Location = New System.Drawing.Point(239, 630)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(202, 63)
        Me.btnVolverInicio.TabIndex = 31
        Me.btnVolverInicio.Text = "Volver al Inicio"
        Me.btnVolverInicio.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(559, 680)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(474, 680)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmPROVProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(661, 705)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.btnBuscarxLocalProv)
        Me.Controls.Add(Me.txtBuscarCodigo)
        Me.Controls.Add(Me.btnConfirmarModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmarNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnListadoProveedores)
        Me.Controls.Add(Me.btnCodProv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmailprov)
        Me.Controls.Add(Me.txtRubroprov)
        Me.Controls.Add(Me.txtTelprov)
        Me.Controls.Add(Me.txtCuitprov)
        Me.Controls.Add(Me.txtLocalidadprov)
        Me.Controls.Add(Me.txtDomiciloprov)
        Me.Controls.Add(Me.txtNombreprov)
        Me.Controls.Add(Me.txtCodigoprov)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(677, 743)
        Me.Name = "frmPROVProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigoprov As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreprov As System.Windows.Forms.TextBox
    Friend WithEvents txtDomiciloprov As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidadprov As System.Windows.Forms.TextBox
    Friend WithEvents txtCuitprov As System.Windows.Forms.TextBox
    Friend WithEvents txtTelprov As System.Windows.Forms.TextBox
    Friend WithEvents txtRubroprov As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailprov As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCodProv As System.Windows.Forms.Button
    Friend WithEvents btnListadoProveedores As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarModificar As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarxLocalProv As System.Windows.Forms.Button
    Friend WithEvents btnVolverInicio As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label

End Class
