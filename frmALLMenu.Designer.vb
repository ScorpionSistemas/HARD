<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmALLMenu
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
        Me.lblUsuActivo = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuAdministrar = New System.Windows.Forms.ToolStripMenuItem
        Me.SunMenuUsuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuProveedores = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuVentas = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuProductos = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReportes = New System.Windows.Forms.ToolStripMenuItem
        Me.SubmenuProveedores = New System.Windows.Forms.ToolStripMenuItem
        Me.SubMenuClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.SubMenuVentas = New System.Windows.Forms.ToolStripMenuItem
        Me.SubMenuProductos = New System.Windows.Forms.ToolStripMenuItem
        Me.SubMenuUsuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem
        Me.lblMostrarUsuario = New System.Windows.Forms.Label
        Me.lblLogo = New System.Windows.Forms.Label
        Me.lblInsumos = New System.Windows.Forms.Label
        Me.pbxMenu = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuActivo
        '
        Me.lblUsuActivo.AutoSize = True
        Me.lblUsuActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuActivo.Location = New System.Drawing.Point(413, 313)
        Me.lblUsuActivo.Name = "lblUsuActivo"
        Me.lblUsuActivo.Size = New System.Drawing.Size(89, 13)
        Me.lblUsuActivo.TabIndex = 0
        Me.lblUsuActivo.Text = "Usuario activo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdministrar, Me.MenuProveedores, Me.MenuClientes, Me.MenuVentas, Me.MenuProductos, Me.MenuReportes, Me.MenuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuAdministrar
        '
        Me.MenuAdministrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SunMenuUsuarios})
        Me.MenuAdministrar.Name = "MenuAdministrar"
        Me.MenuAdministrar.Size = New System.Drawing.Size(81, 20)
        Me.MenuAdministrar.Text = "Administrar"
        '
        'SunMenuUsuarios
        '
        Me.SunMenuUsuarios.Name = "SunMenuUsuarios"
        Me.SunMenuUsuarios.Size = New System.Drawing.Size(119, 22)
        Me.SunMenuUsuarios.Text = "Usuarios"
        '
        'MenuProveedores
        '
        Me.MenuProveedores.Name = "MenuProveedores"
        Me.MenuProveedores.Size = New System.Drawing.Size(84, 20)
        Me.MenuProveedores.Text = "Proveedores"
        '
        'MenuClientes
        '
        Me.MenuClientes.Name = "MenuClientes"
        Me.MenuClientes.Size = New System.Drawing.Size(61, 20)
        Me.MenuClientes.Text = "Clientes"
        '
        'MenuVentas
        '
        Me.MenuVentas.Name = "MenuVentas"
        Me.MenuVentas.Size = New System.Drawing.Size(54, 20)
        Me.MenuVentas.Text = "Ventas"
        '
        'MenuProductos
        '
        Me.MenuProductos.Name = "MenuProductos"
        Me.MenuProductos.Size = New System.Drawing.Size(73, 20)
        Me.MenuProductos.Text = "Productos"
        '
        'MenuReportes
        '
        Me.MenuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmenuProveedores, Me.SubMenuClientes, Me.SubMenuVentas, Me.SubMenuProductos, Me.SubMenuUsuarios})
        Me.MenuReportes.Name = "MenuReportes"
        Me.MenuReportes.Size = New System.Drawing.Size(65, 20)
        Me.MenuReportes.Text = "Reportes"
        '
        'SubmenuProveedores
        '
        Me.SubmenuProveedores.Name = "SubmenuProveedores"
        Me.SubmenuProveedores.Size = New System.Drawing.Size(196, 22)
        Me.SubmenuProveedores.Text = "Listado de proveedores"
        '
        'SubMenuClientes
        '
        Me.SubMenuClientes.Name = "SubMenuClientes"
        Me.SubMenuClientes.Size = New System.Drawing.Size(196, 22)
        Me.SubMenuClientes.Text = "Listado de clientes"
        '
        'SubMenuVentas
        '
        Me.SubMenuVentas.Name = "SubMenuVentas"
        Me.SubMenuVentas.Size = New System.Drawing.Size(196, 22)
        Me.SubMenuVentas.Text = "Listado de Ventas"
        '
        'SubMenuProductos
        '
        Me.SubMenuProductos.Name = "SubMenuProductos"
        Me.SubMenuProductos.Size = New System.Drawing.Size(196, 22)
        Me.SubMenuProductos.Text = "Listado de productos"
        '
        'SubMenuUsuarios
        '
        Me.SubMenuUsuarios.Name = "SubMenuUsuarios"
        Me.SubMenuUsuarios.Size = New System.Drawing.Size(196, 22)
        Me.SubMenuUsuarios.Text = "Listado de Usuarios"
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(41, 20)
        Me.MenuSalir.Text = "Salir"
        '
        'lblMostrarUsuario
        '
        Me.lblMostrarUsuario.AutoSize = True
        Me.lblMostrarUsuario.Location = New System.Drawing.Point(361, 313)
        Me.lblMostrarUsuario.Name = "lblMostrarUsuario"
        Me.lblMostrarUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblMostrarUsuario.TabIndex = 1
        Me.lblMostrarUsuario.Text = "Usuario:"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(213, 220)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(92, 39)
        Me.lblLogo.TabIndex = 4
        Me.lblLogo.Text = "HARD "
        '
        'lblInsumos
        '
        Me.lblInsumos.AutoSize = True
        Me.lblInsumos.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsumos.Location = New System.Drawing.Point(168, 259)
        Me.lblInsumos.Name = "lblInsumos"
        Me.lblInsumos.Size = New System.Drawing.Size(181, 20)
        Me.lblInsumos.TabIndex = 5
        Me.lblInsumos.Text = "INSUMOS INFORMÁTICOS"
        '
        'pbxMenu
        '
        Me.pbxMenu.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.be0d90adc07b618bb80cf60cf1e5010f__computer_repair_services_laptop_repair
        Me.pbxMenu.Location = New System.Drawing.Point(148, 57)
        Me.pbxMenu.Name = "pbxMenu"
        Me.pbxMenu.Size = New System.Drawing.Size(228, 176)
        Me.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMenu.TabIndex = 6
        Me.pbxMenu.TabStop = False
        '
        'frmALLMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(514, 339)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.pbxMenu)
        Me.Controls.Add(Me.lblInsumos)
        Me.Controls.Add(Me.lblMostrarUsuario)
        Me.Controls.Add(Me.lblUsuActivo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(530, 377)
        Me.Name = "frmALLMenu"
        Me.Text = "frmMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuActivo As System.Windows.Forms.Label
    Friend WithEvents lblMostrarUsuario As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuAdministrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SunMenuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubmenuProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenuVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenuProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblInsumos As System.Windows.Forms.Label
    Friend WithEvents pbxMenu As System.Windows.Forms.PictureBox
End Class
