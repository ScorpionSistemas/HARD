<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENListaproductos
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalirproducto = New System.Windows.Forms.Button
        Me.pbxlistaprod = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxlistaprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(47, 87)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(761, 271)
        Me.dgvProductos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(338, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Lista  de Productos"
        '
        'btnSalirproducto
        '
        Me.btnSalirproducto.AllowDrop = True
        Me.btnSalirproducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalirproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirproducto.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalirproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirproducto.Location = New System.Drawing.Point(369, 372)
        Me.btnSalirproducto.Name = "btnSalirproducto"
        Me.btnSalirproducto.Size = New System.Drawing.Size(167, 52)
        Me.btnSalirproducto.TabIndex = 15
        Me.btnSalirproducto.Text = "Salir"
        Me.btnSalirproducto.UseVisualStyleBackColor = False
        '
        'pbxlistaprod
        '
        Me.pbxlistaprod.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxlistaprod.Location = New System.Drawing.Point(579, 1)
        Me.pbxlistaprod.Name = "pbxlistaprod"
        Me.pbxlistaprod.Size = New System.Drawing.Size(101, 80)
        Me.pbxlistaprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxlistaprod.TabIndex = 17
        Me.pbxlistaprod.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(772, 414)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(687, 414)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENListaproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(874, 436)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxlistaprod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalirproducto)
        Me.Controls.Add(Me.dgvProductos)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(890, 474)
        Me.Name = "frmVENListaproductos"
        Me.Text = "Lista de Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxlistaprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalirproducto As System.Windows.Forms.Button
    Friend WithEvents pbxlistaprod As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
