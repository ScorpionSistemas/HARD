<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCLIcuit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvCuit = New System.Windows.Forms.DataGridView
        Me.txtcuit = New System.Windows.Forms.TextBox
        Me.lblIngreseCuit = New System.Windows.Forms.Label
        Me.lblListadoxCUIT = New System.Windows.Forms.Label
        Me.pbxListadoxcuit = New System.Windows.Forms.PictureBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnBuscar1 = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvCuit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxListadoxcuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCuit
        '
        Me.dgvCuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuit.Location = New System.Drawing.Point(12, 87)
        Me.dgvCuit.Name = "dgvCuit"
        Me.dgvCuit.Size = New System.Drawing.Size(779, 282)
        Me.dgvCuit.TabIndex = 0
        '
        'txtcuit
        '
        Me.txtcuit.Location = New System.Drawing.Point(12, 45)
        Me.txtcuit.Name = "txtcuit"
        Me.txtcuit.Size = New System.Drawing.Size(100, 20)
        Me.txtcuit.TabIndex = 1
        '
        'lblIngreseCuit
        '
        Me.lblIngreseCuit.AutoSize = True
        Me.lblIngreseCuit.Location = New System.Drawing.Point(11, 25)
        Me.lblIngreseCuit.Name = "lblIngreseCuit"
        Me.lblIngreseCuit.Size = New System.Drawing.Size(98, 13)
        Me.lblIngreseCuit.TabIndex = 2
        Me.lblIngreseCuit.Text = "Ingrese Nro de Cuit"
        '
        'lblListadoxCUIT
        '
        Me.lblListadoxCUIT.AutoSize = True
        Me.lblListadoxCUIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoxCUIT.Location = New System.Drawing.Point(264, 27)
        Me.lblListadoxCUIT.Name = "lblListadoxCUIT"
        Me.lblListadoxCUIT.Size = New System.Drawing.Size(215, 24)
        Me.lblListadoxCUIT.TabIndex = 35
        Me.lblListadoxCUIT.Text = "LISTADO POR C.U.I.T"
        '
        'pbxListadoxcuit
        '
        Me.pbxListadoxcuit.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxListadoxcuit.Location = New System.Drawing.Point(523, 9)
        Me.pbxListadoxcuit.Name = "pbxListadoxcuit"
        Me.pbxListadoxcuit.Size = New System.Drawing.Size(81, 72)
        Me.pbxListadoxcuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxListadoxcuit.TabIndex = 36
        Me.pbxListadoxcuit.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(425, 394)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 55)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(210, 394)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(168, 55)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Enabled = False
        Me.btnBuscar1.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscar1.Location = New System.Drawing.Point(128, 37)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(33, 35)
        Me.btnBuscar1.TabIndex = 3
        Me.btnBuscar1.UseVisualStyleBackColor = True
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(701, 439)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 38
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(616, 439)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 37
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'FrmCLIcuit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(803, 461)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxListadoxcuit)
        Me.Controls.Add(Me.lblListadoxCUIT)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnBuscar1)
        Me.Controls.Add(Me.lblIngreseCuit)
        Me.Controls.Add(Me.txtcuit)
        Me.Controls.Add(Me.dgvCuit)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(819, 499)
        Me.Name = "FrmCLIcuit"
        Me.Text = "Listado por Cuit"
        CType(Me.dgvCuit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxListadoxcuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCuit As System.Windows.Forms.DataGridView
    Friend WithEvents txtcuit As System.Windows.Forms.TextBox
    Friend WithEvents lblIngreseCuit As System.Windows.Forms.Label
    Friend WithEvents btnBuscar1 As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblListadoxCUIT As System.Windows.Forms.Label
    Friend WithEvents pbxListadoxcuit As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
