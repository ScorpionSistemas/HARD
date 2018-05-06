<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSUABMUsuarios
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
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.lblDNI = New System.Windows.Forms.Label
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.lblContraseña = New System.Windows.Forms.Label
        Me.txtContraseña = New System.Windows.Forms.TextBox
        Me.lblRol = New System.Windows.Forms.Label
        Me.cmbRol = New System.Windows.Forms.ComboBox
        Me.lblTituloUsuarios = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnPrimero = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnConfAgregar = New System.Windows.Forms.Button
        Me.btnConfModificar = New System.Windows.Forms.Button
        Me.btnConfEliminar = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(313, 53)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(313, 86)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(182, 20)
        Me.txtApellido.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(263, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(263, 89)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "Apellido"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(281, 131)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 4
        Me.lblDNI.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(313, 128)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.ReadOnly = True
        Me.txtDNI.Size = New System.Drawing.Size(182, 20)
        Me.txtDNI.TabIndex = 5
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(264, 168)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 6
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(313, 165)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(182, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(246, 206)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 8
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(313, 203)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.Size = New System.Drawing.Size(182, 20)
        Me.txtContraseña.TabIndex = 9
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(284, 241)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(23, 13)
        Me.lblRol.TabIndex = 10
        Me.lblRol.Text = "Rol"
        '
        'cmbRol
        '
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"Administrador", "Altas", "Facturación", "Logística", "Vendedor"})
        Me.cmbRol.Location = New System.Drawing.Point(313, 238)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(182, 21)
        Me.cmbRol.TabIndex = 11
        '
        'lblTituloUsuarios
        '
        Me.lblTituloUsuarios.AutoSize = True
        Me.lblTituloUsuarios.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloUsuarios.Location = New System.Drawing.Point(181, 9)
        Me.lblTituloUsuarios.Name = "lblTituloUsuarios"
        Me.lblTituloUsuarios.Size = New System.Drawing.Size(287, 30)
        Me.lblTituloUsuarios.TabIndex = 12
        Me.lblTituloUsuarios.Text = "ADMINISTRAR USUARIOS"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.agregar
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(12, 53)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(180, 63)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(12, 122)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(180, 59)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.ELIMINAR
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(12, 187)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(180, 67)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(522, 120)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(119, 61)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(324, 278)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(39, 23)
        Me.btnPrimero.TabIndex = 17
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(369, 278)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(32, 23)
        Me.btnAnterior.TabIndex = 18
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(408, 278)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(32, 23)
        Me.btnSiguiente.TabIndex = 19
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(447, 278)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(40, 23)
        Me.btnUltimo.TabIndex = 20
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnConfAgregar
        '
        Me.btnConfAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfAgregar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnConfAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfAgregar.Location = New System.Drawing.Point(392, 340)
        Me.btnConfAgregar.Name = "btnConfAgregar"
        Me.btnConfAgregar.Size = New System.Drawing.Size(182, 51)
        Me.btnConfAgregar.TabIndex = 21
        Me.btnConfAgregar.Text = "Confirma Agregar"
        Me.btnConfAgregar.UseVisualStyleBackColor = False
        Me.btnConfAgregar.Visible = False
        '
        'btnConfModificar
        '
        Me.btnConfModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfModificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnConfModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfModificar.Location = New System.Drawing.Point(392, 336)
        Me.btnConfModificar.Name = "btnConfModificar"
        Me.btnConfModificar.Size = New System.Drawing.Size(182, 51)
        Me.btnConfModificar.TabIndex = 22
        Me.btnConfModificar.Text = "Confirma Modificar"
        Me.btnConfModificar.UseVisualStyleBackColor = False
        Me.btnConfModificar.Visible = False
        '
        'btnConfEliminar
        '
        Me.btnConfEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfEliminar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnConfEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfEliminar.Location = New System.Drawing.Point(392, 336)
        Me.btnConfEliminar.Name = "btnConfEliminar"
        Me.btnConfEliminar.Size = New System.Drawing.Size(182, 55)
        Me.btnConfEliminar.TabIndex = 23
        Me.btnConfEliminar.Text = "Confirma Eliminar"
        Me.btnConfEliminar.UseVisualStyleBackColor = False
        Me.btnConfEliminar.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(226, 338)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 55)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Cancelar"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 336)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(149, 61)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(566, 409)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        Me.lblUsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(481, 409)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        Me.lblUsrAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmUSUABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(668, 431)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfEliminar)
        Me.Controls.Add(Me.btnConfModificar)
        Me.Controls.Add(Me.btnConfAgregar)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblTituloUsuarios)
        Me.Controls.Add(Me.cmbRol)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(684, 469)
        Me.Name = "frmUSUABMUsuarios"
        Me.Text = "frmModuloABMUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblTituloUsuarios As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnConfAgregar As System.Windows.Forms.Button
    Friend WithEvents btnConfModificar As System.Windows.Forms.Button
    Friend WithEvents btnConfEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
