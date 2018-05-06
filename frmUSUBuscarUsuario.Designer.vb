<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSUBuscarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUSUBuscarUsuario))
        Me.btnBuscarNombre = New System.Windows.Forms.Button
        Me.btnBuscarApellido = New System.Windows.Forms.Button
        Me.btnBuscarDNI = New System.Windows.Forms.Button
        Me.btnBuscarUsuario = New System.Windows.Forms.Button
        Me.btnBuscarRol = New System.Windows.Forms.Button
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.lblDNI = New System.Windows.Forms.Label
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.lblContraseña = New System.Windows.Forms.Label
        Me.txtContraseña = New System.Windows.Forms.TextBox
        Me.txtRol = New System.Windows.Forms.TextBox
        Me.lblRol = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnPrimero = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnBuscarNombre
        '
        Me.btnBuscarNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarNombre.Image = CType(resources.GetObject("btnBuscarNombre.Image"), System.Drawing.Image)
        Me.btnBuscarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarNombre.Location = New System.Drawing.Point(12, 31)
        Me.btnBuscarNombre.Name = "btnBuscarNombre"
        Me.btnBuscarNombre.Size = New System.Drawing.Size(134, 41)
        Me.btnBuscarNombre.TabIndex = 0
        Me.btnBuscarNombre.Text = "Por Nombre"
        Me.btnBuscarNombre.UseVisualStyleBackColor = False
        '
        'btnBuscarApellido
        '
        Me.btnBuscarApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarApellido.Image = CType(resources.GetObject("btnBuscarApellido.Image"), System.Drawing.Image)
        Me.btnBuscarApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarApellido.Location = New System.Drawing.Point(12, 75)
        Me.btnBuscarApellido.Name = "btnBuscarApellido"
        Me.btnBuscarApellido.Size = New System.Drawing.Size(134, 41)
        Me.btnBuscarApellido.TabIndex = 1
        Me.btnBuscarApellido.Text = "Por Apellido"
        Me.btnBuscarApellido.UseVisualStyleBackColor = False
        '
        'btnBuscarDNI
        '
        Me.btnBuscarDNI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarDNI.Image = CType(resources.GetObject("btnBuscarDNI.Image"), System.Drawing.Image)
        Me.btnBuscarDNI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarDNI.Location = New System.Drawing.Point(12, 118)
        Me.btnBuscarDNI.Name = "btnBuscarDNI"
        Me.btnBuscarDNI.Size = New System.Drawing.Size(134, 41)
        Me.btnBuscarDNI.TabIndex = 2
        Me.btnBuscarDNI.Text = "Por DNI"
        Me.btnBuscarDNI.UseVisualStyleBackColor = False
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarUsuario.Image = CType(resources.GetObject("btnBuscarUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(12, 161)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(134, 41)
        Me.btnBuscarUsuario.TabIndex = 3
        Me.btnBuscarUsuario.Text = "Por Usuario"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = False
        '
        'btnBuscarRol
        '
        Me.btnBuscarRol.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarRol.Image = CType(resources.GetObject("btnBuscarRol.Image"), System.Drawing.Image)
        Me.btnBuscarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarRol.Location = New System.Drawing.Point(12, 205)
        Me.btnBuscarRol.Name = "btnBuscarRol"
        Me.btnBuscarRol.Size = New System.Drawing.Size(134, 41)
        Me.btnBuscarRol.TabIndex = 4
        Me.btnBuscarRol.Text = "Por Rol"
        Me.btnBuscarRol.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(52, 9)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(51, 20)
        Me.lblBuscar.TabIndex = 5
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(255, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 6
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(205, 45)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(206, 74)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 8
        Me.lblApellido.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(256, 71)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(153, 20)
        Me.txtApellido.TabIndex = 9
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(223, 103)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 10
        Me.lblDNI.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(256, 100)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.ReadOnly = True
        Me.txtDNI.Size = New System.Drawing.Size(153, 20)
        Me.txtDNI.TabIndex = 11
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(211, 132)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 12
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(255, 130)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(152, 20)
        Me.txtUsuario.TabIndex = 13
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(189, 161)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 14
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(255, 158)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.Size = New System.Drawing.Size(152, 20)
        Me.txtContraseña.TabIndex = 15
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(255, 187)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.ReadOnly = True
        Me.txtRol.Size = New System.Drawing.Size(154, 20)
        Me.txtRol.TabIndex = 16
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(226, 187)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(23, 13)
        Me.lblRol.TabIndex = 17
        Me.lblRol.Text = "Rol"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(161, 257)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(150, 61)
        Me.btnAceptar.TabIndex = 18
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(255, 214)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(32, 23)
        Me.btnPrimero.TabIndex = 19
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(293, 214)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(32, 23)
        Me.btnAnterior.TabIndex = 20
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(332, 214)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(32, 23)
        Me.btnSiguiente.TabIndex = 21
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(371, 214)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(32, 23)
        Me.btnUltimo.TabIndex = 22
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(6, 257)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(149, 61)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Salir"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.limpiar_chico
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(317, 257)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(150, 61)
        Me.btnLimpiar.TabIndex = 24
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(401, 336)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(316, 336)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmUSUBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(503, 358)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnBuscarRol)
        Me.Controls.Add(Me.btnBuscarUsuario)
        Me.Controls.Add(Me.btnBuscarDNI)
        Me.Controls.Add(Me.btnBuscarApellido)
        Me.Controls.Add(Me.btnBuscarNombre)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(519, 396)
        Me.Name = "frmUSUBuscarUsuario"
        Me.Text = "frmBuscar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarNombre As System.Windows.Forms.Button
    Friend WithEvents btnBuscarApellido As System.Windows.Forms.Button
    Friend WithEvents btnBuscarDNI As System.Windows.Forms.Button
    Friend WithEvents btnBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnBuscarRol As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
