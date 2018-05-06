<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRODBuscarCodProducto
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
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.dgvbuscarcodproducto = New System.Windows.Forms.DataGridView
        Me.btnVolver = New System.Windows.Forms.Button
        Me.lblConsultaProd = New System.Windows.Forms.Label
        Me.lblProd = New System.Windows.Forms.Label
        Me.pbxcodigoprod = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvbuscarcodproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxcodigoprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.AllowDrop = True
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(181, 342)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(176, 52)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'dgvbuscarcodproducto
        '
        Me.dgvbuscarcodproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbuscarcodproducto.Location = New System.Drawing.Point(12, 80)
        Me.dgvbuscarcodproducto.Name = "dgvbuscarcodproducto"
        Me.dgvbuscarcodproducto.Size = New System.Drawing.Size(700, 250)
        Me.dgvbuscarcodproducto.TabIndex = 28
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(416, 342)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(170, 52)
        Me.btnVolver.TabIndex = 29
        Me.btnVolver.Text = "Salir"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblConsultaProd
        '
        Me.lblConsultaProd.AutoSize = True
        Me.lblConsultaProd.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaProd.Location = New System.Drawing.Point(123, 25)
        Me.lblConsultaProd.Name = "lblConsultaProd"
        Me.lblConsultaProd.Size = New System.Drawing.Size(247, 20)
        Me.lblConsultaProd.TabIndex = 30
        Me.lblConsultaProd.Text = "ESTÁ CONSULTANDO EL PRODUCTO"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic)
        Me.lblProd.Location = New System.Drawing.Point(424, 27)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(37, 20)
        Me.lblProd.TabIndex = 31
        Me.lblProd.Text = "Lbl1"
        Me.lblProd.Visible = False
        '
        'pbxcodigoprod
        '
        Me.pbxcodigoprod.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxcodigoprod.Location = New System.Drawing.Point(526, 4)
        Me.pbxcodigoprod.Name = "pbxcodigoprod"
        Me.pbxcodigoprod.Size = New System.Drawing.Size(79, 70)
        Me.pbxcodigoprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxcodigoprod.TabIndex = 32
        Me.pbxcodigoprod.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(659, 412)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(574, 412)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'FrmPRODBuscarCodProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(754, 434)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxcodigoprod)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.lblConsultaProd)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvbuscarcodproducto)
        Me.Controls.Add(Me.btnImprimir)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(770, 472)
        Me.Name = "FrmPRODBuscarCodProducto"
        Me.Text = "Consulta Código Producto"
        CType(Me.dgvbuscarcodproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxcodigoprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dgvbuscarcodproducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblConsultaProd As System.Windows.Forms.Label
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents pbxcodigoprod As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
