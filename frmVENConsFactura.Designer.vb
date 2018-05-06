<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENConsFactura
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
        Me.lblFactura = New System.Windows.Forms.Label
        Me.lblConsultaxFactura = New System.Windows.Forms.Label
        Me.dgvFactura = New System.Windows.Forms.DataGridView
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.pbxConsultafactura = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxConsultafactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.Location = New System.Drawing.Point(414, 19)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(60, 21)
        Me.lblFactura.TabIndex = 16
        Me.lblFactura.Text = "Label2"
        Me.lblFactura.Visible = False
        '
        'lblConsultaxFactura
        '
        Me.lblConsultaxFactura.AutoSize = True
        Me.lblConsultaxFactura.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaxFactura.Location = New System.Drawing.Point(95, 19)
        Me.lblConsultaxFactura.Name = "lblConsultaxFactura"
        Me.lblConsultaxFactura.Size = New System.Drawing.Size(260, 24)
        Me.lblConsultaxFactura.TabIndex = 15
        Me.lblConsultaxFactura.Text = "Está consultando la factura:"
        '
        'dgvFactura
        '
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Location = New System.Drawing.Point(23, 101)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.Size = New System.Drawing.Size(756, 126)
        Me.dgvFactura.TabIndex = 14
        '
        'btnImprimir
        '
        Me.btnImprimir.AllowDrop = True
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(185, 233)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(181, 69)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.AllowDrop = True
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnsalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(385, 233)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(176, 69)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'pbxConsultafactura
        '
        Me.pbxConsultafactura.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxConsultafactura.Location = New System.Drawing.Point(519, 12)
        Me.pbxConsultafactura.Name = "pbxConsultafactura"
        Me.pbxConsultafactura.Size = New System.Drawing.Size(99, 82)
        Me.pbxConsultafactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxConsultafactura.TabIndex = 17
        Me.pbxConsultafactura.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(723, 292)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(638, 292)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENConsFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(825, 314)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxConsultafactura)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.lblConsultaxFactura)
        Me.Controls.Add(Me.dgvFactura)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnsalir)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(841, 352)
        Me.Name = "frmVENConsFactura"
        Me.Text = "Consulta por Factura"
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxConsultafactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents lblConsultaxFactura As System.Windows.Forms.Label
    Friend WithEvents dgvFactura As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents pbxConsultafactura As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
