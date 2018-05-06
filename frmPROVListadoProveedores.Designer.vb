<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROVListadoProveedores
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
        Me.btnBuscarporRazSoc = New System.Windows.Forms.Button
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgvBuscarRazonSocial = New System.Windows.Forms.DataGridView
        Me.btnVolverProveedores = New System.Windows.Forms.Button
        Me.btnImprimirListado = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gprBusqueda = New System.Windows.Forms.GroupBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvBuscarRazonSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gprBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscarporRazSoc
        '
        Me.btnBuscarporRazSoc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarporRazSoc.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscarporRazSoc.Location = New System.Drawing.Point(278, 134)
        Me.btnBuscarporRazSoc.Name = "btnBuscarporRazSoc"
        Me.btnBuscarporRazSoc.Size = New System.Drawing.Size(50, 35)
        Me.btnBuscarporRazSoc.TabIndex = 0
        Me.btnBuscarporRazSoc.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(32, 136)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(240, 23)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvBuscarRazonSocial
        '
        Me.dgvBuscarRazonSocial.AllowUserToAddRows = False
        Me.dgvBuscarRazonSocial.AllowUserToDeleteRows = False
        Me.dgvBuscarRazonSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscarRazonSocial.Location = New System.Drawing.Point(32, 175)
        Me.dgvBuscarRazonSocial.Name = "dgvBuscarRazonSocial"
        Me.dgvBuscarRazonSocial.ReadOnly = True
        Me.dgvBuscarRazonSocial.Size = New System.Drawing.Size(800, 273)
        Me.dgvBuscarRazonSocial.TabIndex = 2
        '
        'btnVolverProveedores
        '
        Me.btnVolverProveedores.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolverProveedores.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnVolverProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverProveedores.Location = New System.Drawing.Point(425, 456)
        Me.btnVolverProveedores.Name = "btnVolverProveedores"
        Me.btnVolverProveedores.Size = New System.Drawing.Size(160, 54)
        Me.btnVolverProveedores.TabIndex = 3
        Me.btnVolverProveedores.Text = "Salir"
        Me.btnVolverProveedores.UseVisualStyleBackColor = False
        '
        'btnImprimirListado
        '
        Me.btnImprimirListado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimirListado.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimirListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirListado.Location = New System.Drawing.Point(211, 456)
        Me.btnImprimirListado.Name = "btnImprimirListado"
        Me.btnImprimirListado.Size = New System.Drawing.Size(174, 54)
        Me.btnImprimirListado.TabIndex = 4
        Me.btnImprimirListado.Text = "Imprimir"
        Me.btnImprimirListado.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(733, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "*Para buscar debe completar el cuadro de texto con la letra o palabra que conteng" & _
            "a la Razon Social del Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*Una vez compeltado dar click en Buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "*Si desea obtener el listado total de Proveedores, no complete el cuadro de texto" & _
            " y de directamente al botón Imprimir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(771, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "*Como resultado la lista de Proveedores se hará mas pequeña, la cual podra obtene" & _
            "rla dandole click en el botón Imprimir"
        '
        'gprBusqueda
        '
        Me.gprBusqueda.Controls.Add(Me.Label4)
        Me.gprBusqueda.Controls.Add(Me.Label3)
        Me.gprBusqueda.Controls.Add(Me.Label2)
        Me.gprBusqueda.Controls.Add(Me.Label1)
        Me.gprBusqueda.Location = New System.Drawing.Point(24, 8)
        Me.gprBusqueda.Name = "gprBusqueda"
        Me.gprBusqueda.Size = New System.Drawing.Size(808, 120)
        Me.gprBusqueda.TabIndex = 9
        Me.gprBusqueda.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(813, 506)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(728, 506)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmPROVListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(915, 528)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.gprBusqueda)
        Me.Controls.Add(Me.btnImprimirListado)
        Me.Controls.Add(Me.btnVolverProveedores)
        Me.Controls.Add(Me.dgvBuscarRazonSocial)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscarporRazSoc)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(931, 566)
        Me.Name = "frmPROVListadoProveedores"
        Me.Text = "BUSCAR PROVEEDOR POR RAZON SOCIAL"
        CType(Me.dgvBuscarRazonSocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gprBusqueda.ResumeLayout(False)
        Me.gprBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarporRazSoc As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvBuscarRazonSocial As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverProveedores As System.Windows.Forms.Button
    Friend WithEvents btnImprimirListado As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gprBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
