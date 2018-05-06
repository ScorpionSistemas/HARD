<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENConsultas
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
        Me.gbxcliente = New System.Windows.Forms.GroupBox
        Me.btnBuscarcliente = New System.Windows.Forms.Button
        Me.txtBuscarfactura = New System.Windows.Forms.TextBox
        Me.gbxProducto = New System.Windows.Forms.GroupBox
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox
        Me.btnBuscarproducto = New System.Windows.Forms.Button
        Me.dtpBuscarfecha = New System.Windows.Forms.DateTimePicker
        Me.gbxFecha = New System.Windows.Forms.GroupBox
        Me.btnBuscarfecha = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSalirconsultas = New System.Windows.Forms.Button
        Me.btnCproducto = New System.Windows.Forms.Button
        Me.btnCfecha = New System.Windows.Forms.Button
        Me.btnCcliente = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.gbxcliente.SuspendLayout()
        Me.gbxProducto.SuspendLayout()
        Me.gbxFecha.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxcliente
        '
        Me.gbxcliente.Controls.Add(Me.btnBuscarcliente)
        Me.gbxcliente.Controls.Add(Me.txtBuscarfactura)
        Me.gbxcliente.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxcliente.Location = New System.Drawing.Point(360, 19)
        Me.gbxcliente.Name = "gbxcliente"
        Me.gbxcliente.Size = New System.Drawing.Size(425, 131)
        Me.gbxcliente.TabIndex = 4
        Me.gbxcliente.TabStop = False
        Me.gbxcliente.Text = "Ingrese Numero de Factura"
        Me.gbxcliente.Visible = False
        '
        'btnBuscarcliente
        '
        Me.btnBuscarcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarcliente.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarcliente.Location = New System.Drawing.Point(244, 48)
        Me.btnBuscarcliente.Name = "btnBuscarcliente"
        Me.btnBuscarcliente.Size = New System.Drawing.Size(143, 37)
        Me.btnBuscarcliente.TabIndex = 1
        Me.btnBuscarcliente.Text = "Buscar"
        Me.btnBuscarcliente.UseVisualStyleBackColor = False
        '
        'txtBuscarfactura
        '
        Me.txtBuscarfactura.Location = New System.Drawing.Point(41, 54)
        Me.txtBuscarfactura.Name = "txtBuscarfactura"
        Me.txtBuscarfactura.Size = New System.Drawing.Size(125, 26)
        Me.txtBuscarfactura.TabIndex = 0
        '
        'gbxProducto
        '
        Me.gbxProducto.Controls.Add(Me.txtBuscarProducto)
        Me.gbxProducto.Controls.Add(Me.btnBuscarproducto)
        Me.gbxProducto.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProducto.Location = New System.Drawing.Point(360, 19)
        Me.gbxProducto.Name = "gbxProducto"
        Me.gbxProducto.Size = New System.Drawing.Size(425, 131)
        Me.gbxProducto.TabIndex = 6
        Me.gbxProducto.TabStop = False
        Me.gbxProducto.Text = "Ingrese Numero del Producto"
        Me.gbxProducto.Visible = False
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(41, 54)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(125, 26)
        Me.txtBuscarProducto.TabIndex = 3
        '
        'btnBuscarproducto
        '
        Me.btnBuscarproducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarproducto.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarproducto.Location = New System.Drawing.Point(244, 48)
        Me.btnBuscarproducto.Name = "btnBuscarproducto"
        Me.btnBuscarproducto.Size = New System.Drawing.Size(143, 37)
        Me.btnBuscarproducto.TabIndex = 2
        Me.btnBuscarproducto.Text = "Buscar"
        Me.btnBuscarproducto.UseVisualStyleBackColor = False
        '
        'dtpBuscarfecha
        '
        Me.dtpBuscarfecha.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBuscarfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBuscarfecha.Location = New System.Drawing.Point(33, 59)
        Me.dtpBuscarfecha.Name = "dtpBuscarfecha"
        Me.dtpBuscarfecha.Size = New System.Drawing.Size(168, 26)
        Me.dtpBuscarfecha.TabIndex = 3
        '
        'gbxFecha
        '
        Me.gbxFecha.Controls.Add(Me.dtpBuscarfecha)
        Me.gbxFecha.Controls.Add(Me.btnBuscarfecha)
        Me.gbxFecha.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFecha.Location = New System.Drawing.Point(360, 19)
        Me.gbxFecha.Name = "gbxFecha"
        Me.gbxFecha.Size = New System.Drawing.Size(425, 131)
        Me.gbxFecha.TabIndex = 5
        Me.gbxFecha.TabStop = False
        Me.gbxFecha.Text = "Ingrese Fecha a Consultar"
        Me.gbxFecha.Visible = False
        '
        'btnBuscarfecha
        '
        Me.btnBuscarfecha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarfecha.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscarfecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarfecha.Location = New System.Drawing.Point(240, 53)
        Me.btnBuscarfecha.Name = "btnBuscarfecha"
        Me.btnBuscarfecha.Size = New System.Drawing.Size(143, 37)
        Me.btnBuscarfecha.TabIndex = 2
        Me.btnBuscarfecha.Text = "Buscar"
        Me.btnBuscarfecha.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.freelance_writer1
        Me.PictureBox1.Location = New System.Drawing.Point(443, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(61, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 70)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Consulta General"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSalirconsultas
        '
        Me.btnSalirconsultas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalirconsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirconsultas.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalirconsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirconsultas.Location = New System.Drawing.Point(494, 383)
        Me.btnSalirconsultas.Name = "btnSalirconsultas"
        Me.btnSalirconsultas.Size = New System.Drawing.Size(195, 77)
        Me.btnSalirconsultas.TabIndex = 3
        Me.btnSalirconsultas.Text = "Salir"
        Me.btnSalirconsultas.UseVisualStyleBackColor = False
        '
        'btnCproducto
        '
        Me.btnCproducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCproducto.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._71
        Me.btnCproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCproducto.Location = New System.Drawing.Point(61, 193)
        Me.btnCproducto.Name = "btnCproducto"
        Me.btnCproducto.Size = New System.Drawing.Size(224, 73)
        Me.btnCproducto.TabIndex = 2
        Me.btnCproducto.Text = "Consulta por Producto"
        Me.btnCproducto.UseVisualStyleBackColor = False
        '
        'btnCfecha
        '
        Me.btnCfecha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCfecha.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._31
        Me.btnCfecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCfecha.Location = New System.Drawing.Point(61, 117)
        Me.btnCfecha.Name = "btnCfecha"
        Me.btnCfecha.Size = New System.Drawing.Size(224, 70)
        Me.btnCfecha.TabIndex = 1
        Me.btnCfecha.Text = "Consulta por Fecha"
        Me.btnCfecha.UseVisualStyleBackColor = False
        '
        'btnCcliente
        '
        Me.btnCcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCcliente.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._5
        Me.btnCcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCcliente.Location = New System.Drawing.Point(61, 34)
        Me.btnCcliente.Name = "btnCcliente"
        Me.btnCcliente.Size = New System.Drawing.Size(224, 77)
        Me.btnCcliente.TabIndex = 0
        Me.btnCcliente.Text = "Consulta por Factura"
        Me.btnCcliente.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(725, 482)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(640, 482)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(827, 522)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbxProducto)
        Me.Controls.Add(Me.gbxFecha)
        Me.Controls.Add(Me.gbxcliente)
        Me.Controls.Add(Me.btnSalirconsultas)
        Me.Controls.Add(Me.btnCproducto)
        Me.Controls.Add(Me.btnCfecha)
        Me.Controls.Add(Me.btnCcliente)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(843, 560)
        Me.Name = "frmVENConsultas"
        Me.Text = "Consultas"
        Me.gbxcliente.ResumeLayout(False)
        Me.gbxcliente.PerformLayout()
        Me.gbxProducto.ResumeLayout(False)
        Me.gbxProducto.PerformLayout()
        Me.gbxFecha.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCcliente As System.Windows.Forms.Button
    Friend WithEvents btnCfecha As System.Windows.Forms.Button
    Friend WithEvents btnCproducto As System.Windows.Forms.Button
    Friend WithEvents btnSalirconsultas As System.Windows.Forms.Button
    Friend WithEvents gbxcliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbxProducto As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarcliente As System.Windows.Forms.Button
    Friend WithEvents txtBuscarfactura As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarproducto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBuscarfecha As System.Windows.Forms.Button
    Friend WithEvents dtpBuscarfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbxFecha As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
