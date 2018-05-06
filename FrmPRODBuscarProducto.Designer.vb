<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRODBuscarProducto
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
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.btnBuscarProducto = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.btnPrim = New System.Windows.Forms.Button
        Me.btnAnt = New System.Windows.Forms.Button
        Me.btnSig = New System.Windows.Forms.Button
        Me.btnUlt = New System.Windows.Forms.Button
        Me.btnBuscarCod = New System.Windows.Forms.Button
        Me.codigo_producto = New System.Windows.Forms.Label
        Me.txtCodProd = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnLimpiarT = New System.Windows.Forms.Button
        Me.btnVolver = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(143, 24)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(201, 26)
        Me.lblBuscar.TabIndex = 6
        Me.lblBuscar.Text = "BUSCAR PRODUCTO"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(57, 104)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscarProducto.TabIndex = 7
        Me.btnBuscarProducto.Text = "Por Producto"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(252, 110)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Producto"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(312, 107)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(154, 20)
        Me.txtProducto.TabIndex = 9
        '
        'btnPrim
        '
        Me.btnPrim.Location = New System.Drawing.Point(172, 224)
        Me.btnPrim.Name = "btnPrim"
        Me.btnPrim.Size = New System.Drawing.Size(40, 30)
        Me.btnPrim.TabIndex = 14
        Me.btnPrim.Text = "<< "
        Me.btnPrim.UseVisualStyleBackColor = True
        Me.btnPrim.Visible = False
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(230, 224)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(38, 30)
        Me.btnAnt.TabIndex = 15
        Me.btnAnt.Text = "< "
        Me.btnAnt.UseVisualStyleBackColor = True
        Me.btnAnt.Visible = False
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(274, 224)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(38, 30)
        Me.btnSig.TabIndex = 16
        Me.btnSig.Text = " >"
        Me.btnSig.UseVisualStyleBackColor = True
        Me.btnSig.Visible = False
        '
        'btnUlt
        '
        Me.btnUlt.Location = New System.Drawing.Point(329, 224)
        Me.btnUlt.Name = "btnUlt"
        Me.btnUlt.Size = New System.Drawing.Size(40, 30)
        Me.btnUlt.TabIndex = 17
        Me.btnUlt.Text = ">>"
        Me.btnUlt.UseVisualStyleBackColor = True
        Me.btnUlt.Visible = False
        '
        'btnBuscarCod
        '
        Me.btnBuscarCod.Location = New System.Drawing.Point(57, 163)
        Me.btnBuscarCod.Name = "btnBuscarCod"
        Me.btnBuscarCod.Size = New System.Drawing.Size(98, 24)
        Me.btnBuscarCod.TabIndex = 21
        Me.btnBuscarCod.Text = "Por Codigo"
        Me.btnBuscarCod.UseVisualStyleBackColor = True
        '
        'codigo_producto
        '
        Me.codigo_producto.AutoSize = True
        Me.codigo_producto.Location = New System.Drawing.Point(205, 163)
        Me.codigo_producto.Name = "codigo_producto"
        Me.codigo_producto.Size = New System.Drawing.Size(101, 13)
        Me.codigo_producto.TabIndex = 22
        Me.codigo_producto.Text = "Código de Producto"
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(312, 163)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(154, 20)
        Me.txtCodProd.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.buscar_icono
        Me.PictureBox1.Location = New System.Drawing.Point(360, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(209, 293)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 54)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiarT
        '
        Me.btnLimpiarT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiarT.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.limpiar_chico
        Me.btnLimpiarT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarT.Location = New System.Drawing.Point(274, 364)
        Me.btnLimpiarT.Name = "btnLimpiarT"
        Me.btnLimpiarT.Size = New System.Drawing.Size(171, 51)
        Me.btnLimpiarT.TabIndex = 25
        Me.btnLimpiarT.Text = "Limpiar Todo"
        Me.btnLimpiarT.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(92, 364)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(166, 51)
        Me.btnVolver.TabIndex = 24
        Me.btnVolver.Text = "Salir"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(437, 445)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(352, 445)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'FrmPRODBuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(530, 467)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiarT)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.codigo_producto)
        Me.Controls.Add(Me.btnBuscarCod)
        Me.Controls.Add(Me.btnUlt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnPrim)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.lblBuscar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(546, 505)
        Me.Name = "FrmPRODBuscarProducto"
        Me.Text = "FrmBuscarProducto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnPrim As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnUlt As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCod As System.Windows.Forms.Button
    Friend WithEvents codigo_producto As System.Windows.Forms.Label
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarT As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
