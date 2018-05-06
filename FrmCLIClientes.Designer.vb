<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCLIClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNro_cliente = New System.Windows.Forms.TextBox
        Me.txtRazon_social = New System.Windows.Forms.TextBox
        Me.txtCuit = New System.Windows.Forms.TextBox
        Me.txtDomicilio = New System.Windows.Forms.TextBox
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblNroCli = New System.Windows.Forms.Label
        Me.lblRazSoc = New System.Windows.Forms.Label
        Me.lblDomic = New System.Windows.Forms.Label
        Me.lblLocali = New System.Windows.Forms.Label
        Me.lblCuit = New System.Windows.Forms.Label
        Me.lblTel = New System.Windows.Forms.Label
        Me.lblMail = New System.Windows.Forms.Label
        Me.LBLClientes = New System.Windows.Forms.Label
        Me.btnPrimero = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorCuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.txtBuscacli = New System.Windows.Forms.TextBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.pbxClientes = New System.Windows.Forms.PictureBox
        Me.btnLupa = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnConfmodificar = New System.Windows.Forms.Button
        Me.btnConfagregar = New System.Windows.Forms.Button
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNro_cliente
        '
        Me.txtNro_cliente.Enabled = False
        Me.txtNro_cliente.Location = New System.Drawing.Point(366, 98)
        Me.txtNro_cliente.Name = "txtNro_cliente"
        Me.txtNro_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNro_cliente.TabIndex = 0
        '
        'txtRazon_social
        '
        Me.txtRazon_social.Location = New System.Drawing.Point(366, 137)
        Me.txtRazon_social.Name = "txtRazon_social"
        Me.txtRazon_social.ReadOnly = True
        Me.txtRazon_social.Size = New System.Drawing.Size(290, 20)
        Me.txtRazon_social.TabIndex = 1
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(366, 257)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.ReadOnly = True
        Me.txtCuit.Size = New System.Drawing.Size(100, 20)
        Me.txtCuit.TabIndex = 4
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(366, 176)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(290, 20)
        Me.txtDomicilio.TabIndex = 2
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(366, 217)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(157, 20)
        Me.txtLocalidad.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(366, 302)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(366, 344)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(235, 20)
        Me.txtEmail.TabIndex = 6
        '
        'lblNroCli
        '
        Me.lblNroCli.AutoSize = True
        Me.lblNroCli.Location = New System.Drawing.Point(264, 105)
        Me.lblNroCli.Name = "lblNroCli"
        Me.lblNroCli.Size = New System.Drawing.Size(74, 13)
        Me.lblNroCli.TabIndex = 8
        Me.lblNroCli.Text = "Nro de Cliente"
        '
        'lblRazSoc
        '
        Me.lblRazSoc.AutoSize = True
        Me.lblRazSoc.Location = New System.Drawing.Point(264, 144)
        Me.lblRazSoc.Name = "lblRazSoc"
        Me.lblRazSoc.Size = New System.Drawing.Size(70, 13)
        Me.lblRazSoc.TabIndex = 9
        Me.lblRazSoc.Text = "Razon Social"
        '
        'lblDomic
        '
        Me.lblDomic.AutoSize = True
        Me.lblDomic.Location = New System.Drawing.Point(264, 183)
        Me.lblDomic.Name = "lblDomic"
        Me.lblDomic.Size = New System.Drawing.Size(49, 13)
        Me.lblDomic.TabIndex = 10
        Me.lblDomic.Text = "Domicilio"
        '
        'lblLocali
        '
        Me.lblLocali.AutoSize = True
        Me.lblLocali.Location = New System.Drawing.Point(264, 224)
        Me.lblLocali.Name = "lblLocali"
        Me.lblLocali.Size = New System.Drawing.Size(53, 13)
        Me.lblLocali.TabIndex = 11
        Me.lblLocali.Text = "Localidad"
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Location = New System.Drawing.Point(264, 264)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(25, 13)
        Me.lblCuit.TabIndex = 12
        Me.lblCuit.Text = "Cuit"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(264, 309)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(49, 13)
        Me.lblTel.TabIndex = 13
        Me.lblTel.Text = "Telefono"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(264, 351)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(35, 13)
        Me.lblMail.TabIndex = 14
        Me.lblMail.Text = "E-mail"
        '
        'LBLClientes
        '
        Me.LBLClientes.AutoSize = True
        Me.LBLClientes.Font = New System.Drawing.Font("Franklin Gothic Demi", 17.0!)
        Me.LBLClientes.Location = New System.Drawing.Point(279, 27)
        Me.LBLClientes.Name = "LBLClientes"
        Me.LBLClientes.Size = New System.Drawing.Size(111, 29)
        Me.LBLClientes.TabIndex = 15
        Me.LBLClientes.Text = "CLIENTES"
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(301, 415)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(75, 23)
        Me.btnPrimero.TabIndex = 16
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(392, 415)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 17
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(485, 415)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 18
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(581, 415)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 23)
        Me.btnUltimo.TabIndex = 19
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeClientesToolStripMenuItem, Me.PorCuitToolStripMenuItem, Me.PorToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'PorCuitToolStripMenuItem
        '
        Me.PorCuitToolStripMenuItem.Name = "PorCuitToolStripMenuItem"
        Me.PorCuitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PorCuitToolStripMenuItem.Text = "Por Cuit"
        '
        'PorToolStripMenuItem
        '
        Me.PorToolStripMenuItem.Name = "PorToolStripMenuItem"
        Me.PorToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PorToolStripMenuItem.Text = "Por Localidad"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(62, 324)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(112, 13)
        Me.lblBuscar.TabIndex = 28
        Me.lblBuscar.Text = "Ingrese Nro de Cliente"
        Me.lblBuscar.Visible = False
        '
        'txtBuscacli
        '
        Me.txtBuscacli.Location = New System.Drawing.Point(65, 347)
        Me.txtBuscacli.Name = "txtBuscacli"
        Me.txtBuscacli.Size = New System.Drawing.Size(90, 20)
        Me.txtBuscacli.TabIndex = 29
        Me.txtBuscacli.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(35, 126)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(167, 60)
        Me.btnModificar.TabIndex = 22
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.agregar
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(35, 59)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(167, 64)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'pbxClientes
        '
        Me.pbxClientes.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.usuario_registrados
        Me.pbxClientes.Location = New System.Drawing.Point(581, 27)
        Me.pbxClientes.Name = "pbxClientes"
        Me.pbxClientes.Size = New System.Drawing.Size(100, 91)
        Me.pbxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxClientes.TabIndex = 31
        Me.pbxClientes.TabStop = False
        '
        'btnLupa
        '
        Me.btnLupa.Enabled = False
        Me.btnLupa.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnLupa.Location = New System.Drawing.Point(170, 340)
        Me.btnLupa.Name = "btnLupa"
        Me.btnLupa.Size = New System.Drawing.Size(34, 34)
        Me.btnLupa.TabIndex = 30
        Me.btnLupa.UseVisualStyleBackColor = True
        Me.btnLupa.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.buscarchico
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(37, 257)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(165, 57)
        Me.btnBuscar.TabIndex = 27
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(37, 391)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 59)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.ELIMINAR
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(35, 191)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(167, 60)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnConfmodificar
        '
        Me.btnConfmodificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfmodificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar
        Me.btnConfmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfmodificar.Location = New System.Drawing.Point(35, 126)
        Me.btnConfmodificar.Name = "btnConfmodificar"
        Me.btnConfmodificar.Size = New System.Drawing.Size(167, 60)
        Me.btnConfmodificar.TabIndex = 23
        Me.btnConfmodificar.Text = "Confirma Modificar"
        Me.btnConfmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfmodificar.UseVisualStyleBackColor = False
        Me.btnConfmodificar.Visible = False
        '
        'btnConfagregar
        '
        Me.btnConfagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfagregar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.agregar
        Me.btnConfagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfagregar.Location = New System.Drawing.Point(35, 59)
        Me.btnConfagregar.Name = "btnConfagregar"
        Me.btnConfagregar.Size = New System.Drawing.Size(167, 64)
        Me.btnConfagregar.TabIndex = 21
        Me.btnConfagregar.Text = "Confirma Agregar"
        Me.btnConfagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfagregar.UseVisualStyleBackColor = False
        Me.btnConfagregar.Visible = False
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(555, 453)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 32
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(640, 453)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 33
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'FrmCLIClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(742, 475)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxClientes)
        Me.Controls.Add(Me.btnLupa)
        Me.Controls.Add(Me.txtBuscacli)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnConfmodificar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnConfagregar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.LBLClientes)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblCuit)
        Me.Controls.Add(Me.lblLocali)
        Me.Controls.Add(Me.lblDomic)
        Me.Controls.Add(Me.lblRazSoc)
        Me.Controls.Add(Me.lblNroCli)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.txtRazon_social)
        Me.Controls.Add(Me.txtNro_cliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(758, 513)
        Me.Name = "FrmCLIClientes"
        Me.Text = "Ingreso de Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNro_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txtRazon_social As System.Windows.Forms.TextBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblNroCli As System.Windows.Forms.Label
    Friend WithEvents lblRazSoc As System.Windows.Forms.Label
    Friend WithEvents lblDomic As System.Windows.Forms.Label
    Friend WithEvents lblLocali As System.Windows.Forms.Label
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents LBLClientes As System.Windows.Forms.Label
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnConfagregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnConfmodificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscacli As System.Windows.Forms.TextBox
    Friend WithEvents btnLupa As System.Windows.Forms.Button
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorCuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbxClientes As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label

End Class
