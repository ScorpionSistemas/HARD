<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRODBuscarDetalle
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
        Me.lblConsultadetalle = New System.Windows.Forms.Label
        Me.lblDetalle = New System.Windows.Forms.Label
        Me.dgvbuscarcodproducto = New System.Windows.Forms.DataGridView
        Me.btnVolver = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.pbxdetalle = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvbuscarcodproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConsultadetalle
        '
        Me.lblConsultadetalle.AutoSize = True
        Me.lblConsultadetalle.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultadetalle.Location = New System.Drawing.Point(128, 28)
        Me.lblConsultadetalle.Name = "lblConsultadetalle"
        Me.lblConsultadetalle.Size = New System.Drawing.Size(230, 20)
        Me.lblConsultadetalle.TabIndex = 31
        Me.lblConsultadetalle.Text = "ESTÁ CONSULTANDO EL DETALLE"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.Location = New System.Drawing.Point(398, 28)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(37, 20)
        Me.lblDetalle.TabIndex = 32
        Me.lblDetalle.Text = "Lbl2"
        Me.lblDetalle.Visible = False
        '
        'dgvbuscarcodproducto
        '
        Me.dgvbuscarcodproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbuscarcodproducto.Location = New System.Drawing.Point(12, 74)
        Me.dgvbuscarcodproducto.Name = "dgvbuscarcodproducto"
        Me.dgvbuscarcodproducto.Size = New System.Drawing.Size(664, 268)
        Me.dgvbuscarcodproducto.TabIndex = 33
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(378, 364)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(167, 49)
        Me.btnVolver.TabIndex = 34
        Me.btnVolver.Text = "Salir"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.AllowDrop = True
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(150, 364)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(168, 49)
        Me.btnImprimir.TabIndex = 35
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'pbxdetalle
        '
        Me.pbxdetalle.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxdetalle.Location = New System.Drawing.Point(485, 3)
        Me.pbxdetalle.Name = "pbxdetalle"
        Me.pbxdetalle.Size = New System.Drawing.Size(75, 65)
        Me.pbxdetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxdetalle.TabIndex = 36
        Me.pbxdetalle.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(597, 427)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(512, 427)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'FrmPRODBuscarDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(699, 449)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxdetalle)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvbuscarcodproducto)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.lblConsultadetalle)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(715, 487)
        Me.Name = "FrmPRODBuscarDetalle"
        Me.Text = "FrmBuscarDetalle"
        CType(Me.dgvbuscarcodproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConsultadetalle As System.Windows.Forms.Label
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents dgvbuscarcodproducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents pbxdetalle As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
