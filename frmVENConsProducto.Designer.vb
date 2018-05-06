<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENConsProducto
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
        Me.lvlProducto = New System.Windows.Forms.Label
        Me.lblConsultaProducto = New System.Windows.Forms.Label
        Me.dgvProducto = New System.Windows.Forms.DataGridView
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvlProducto
        '
        Me.lvlProducto.AutoSize = True
        Me.lvlProducto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlProducto.Location = New System.Drawing.Point(479, 22)
        Me.lvlProducto.Name = "lvlProducto"
        Me.lvlProducto.Size = New System.Drawing.Size(0, 18)
        Me.lvlProducto.TabIndex = 16
        Me.lvlProducto.Visible = False
        '
        'lblConsultaProducto
        '
        Me.lblConsultaProducto.AutoSize = True
        Me.lblConsultaProducto.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaProducto.Location = New System.Drawing.Point(85, 42)
        Me.lblConsultaProducto.Name = "lblConsultaProducto"
        Me.lblConsultaProducto.Size = New System.Drawing.Size(359, 24)
        Me.lblConsultaProducto.TabIndex = 15
        Me.lblConsultaProducto.Text = "Está consultando el siguiente producto"
        '
        'dgvProducto
        '
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Location = New System.Drawing.Point(59, 111)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Size = New System.Drawing.Size(726, 126)
        Me.dgvProducto.TabIndex = 14
        '
        'btnImprimir
        '
        Me.btnImprimir.AllowDrop = True
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(224, 243)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(168, 63)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.AllowDrop = True
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(419, 243)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(159, 63)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.PictureBox1.Location = New System.Drawing.Point(621, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(727, 306)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(642, 306)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENConsProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(829, 328)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lvlProducto)
        Me.Controls.Add(Me.lblConsultaProducto)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnsalir)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(845, 366)
        Me.Name = "frmVENConsProducto"
        Me.Text = "Consulta de Producto"
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvlProducto As System.Windows.Forms.Label
    Friend WithEvents lblConsultaProducto As System.Windows.Forms.Label
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
