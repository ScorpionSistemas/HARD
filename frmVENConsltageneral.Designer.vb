<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENConsltageneral
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
        Me.lblListadeVentas = New System.Windows.Forms.Label
        Me.dgvGeneral = New System.Windows.Forms.DataGridView
        Me.pbxListadeventas = New System.Windows.Forms.PictureBox
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxListadeventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblListadeVentas
        '
        Me.lblListadeVentas.AutoSize = True
        Me.lblListadeVentas.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadeVentas.Location = New System.Drawing.Point(205, 20)
        Me.lblListadeVentas.Name = "lblListadeVentas"
        Me.lblListadeVentas.Size = New System.Drawing.Size(355, 26)
        Me.lblListadeVentas.TabIndex = 13
        Me.lblListadeVentas.Text = "Está consultando la Lista de ventas"
        '
        'dgvGeneral
        '
        Me.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeneral.Location = New System.Drawing.Point(31, 85)
        Me.dgvGeneral.Name = "dgvGeneral"
        Me.dgvGeneral.Size = New System.Drawing.Size(769, 253)
        Me.dgvGeneral.TabIndex = 14
        '
        'pbxListadeventas
        '
        Me.pbxListadeventas.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxListadeventas.Location = New System.Drawing.Point(592, 2)
        Me.pbxListadeventas.Name = "pbxListadeventas"
        Me.pbxListadeventas.Size = New System.Drawing.Size(90, 77)
        Me.pbxListadeventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxListadeventas.TabIndex = 15
        Me.pbxListadeventas.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.AllowDrop = True
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(210, 344)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(165, 58)
        Me.btnImprimir.TabIndex = 12
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
        Me.btnsalir.Location = New System.Drawing.Point(410, 344)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(158, 58)
        Me.btnsalir.TabIndex = 11
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(728, 392)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(643, 392)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENConsltageneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(830, 414)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxListadeventas)
        Me.Controls.Add(Me.dgvGeneral)
        Me.Controls.Add(Me.lblListadeVentas)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnsalir)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(846, 452)
        Me.Name = "frmVENConsltageneral"
        Me.Text = "Consulta Genetal"
        CType(Me.dgvGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxListadeventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblListadeVentas As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents dgvGeneral As System.Windows.Forms.DataGridView
    Friend WithEvents pbxListadeventas As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
