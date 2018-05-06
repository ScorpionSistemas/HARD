<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCLIlocalidad
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
        Me.dgvLocalidad = New System.Windows.Forms.DataGridView
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox
        Me.lblBuscaLocali = New System.Windows.Forms.Label
        Me.lblLitsadoxlocalidad = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnBuscarlocalidad = New System.Windows.Forms.Button
        Me.pbxListxlocal = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxListxlocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLocalidad
        '
        Me.dgvLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidad.Location = New System.Drawing.Point(12, 87)
        Me.dgvLocalidad.Name = "dgvLocalidad"
        Me.dgvLocalidad.Size = New System.Drawing.Size(832, 332)
        Me.dgvLocalidad.TabIndex = 0
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(29, 42)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ShortcutsEnabled = False
        Me.txtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.txtLocalidad.TabIndex = 2
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Location = New System.Drawing.Point(29, 41)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(125, 21)
        Me.cmbLocalidad.TabIndex = 31
        '
        'lblBuscaLocali
        '
        Me.lblBuscaLocali.AutoSize = True
        Me.lblBuscaLocali.Location = New System.Drawing.Point(29, 17)
        Me.lblBuscaLocali.Name = "lblBuscaLocali"
        Me.lblBuscaLocali.Size = New System.Drawing.Size(92, 13)
        Me.lblBuscaLocali.TabIndex = 32
        Me.lblBuscaLocali.Text = "Busque Localidad"
        '
        'lblLitsadoxlocalidad
        '
        Me.lblLitsadoxlocalidad.AutoSize = True
        Me.lblLitsadoxlocalidad.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitsadoxlocalidad.Location = New System.Drawing.Point(299, 30)
        Me.lblLitsadoxlocalidad.Name = "lblLitsadoxlocalidad"
        Me.lblLitsadoxlocalidad.Size = New System.Drawing.Size(249, 26)
        Me.lblLitsadoxlocalidad.TabIndex = 33
        Me.lblLitsadoxlocalidad.Text = "LISTADO POR LOCALIDAD"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(440, 440)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 55)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(225, 440)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(168, 55)
        Me.btnImprimir.TabIndex = 29
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnBuscarlocalidad
        '
        Me.btnBuscarlocalidad.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBuscarlocalidad.Location = New System.Drawing.Point(174, 28)
        Me.btnBuscarlocalidad.Name = "btnBuscarlocalidad"
        Me.btnBuscarlocalidad.Size = New System.Drawing.Size(38, 34)
        Me.btnBuscarlocalidad.TabIndex = 1
        Me.btnBuscarlocalidad.UseVisualStyleBackColor = True
        '
        'pbxListxlocal
        '
        Me.pbxListxlocal.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.pbxListxlocal.Location = New System.Drawing.Point(659, 13)
        Me.pbxListxlocal.Name = "pbxListxlocal"
        Me.pbxListxlocal.Size = New System.Drawing.Size(78, 68)
        Me.pbxListxlocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxListxlocal.TabIndex = 34
        Me.pbxListxlocal.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(754, 485)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 40
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(669, 485)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 39
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'FrmCLIlocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(856, 507)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.pbxListxlocal)
        Me.Controls.Add(Me.lblLitsadoxlocalidad)
        Me.Controls.Add(Me.lblBuscaLocali)
        Me.Controls.Add(Me.cmbLocalidad)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.btnBuscarlocalidad)
        Me.Controls.Add(Me.dgvLocalidad)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(872, 545)
        Me.Name = "FrmCLIlocalidad"
        Me.Text = "Consulta por Localidad"
        CType(Me.dgvLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxListxlocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLocalidad As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarlocalidad As System.Windows.Forms.Button
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents cmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblBuscaLocali As System.Windows.Forms.Label
    Friend WithEvents lblLitsadoxlocalidad As System.Windows.Forms.Label
    Friend WithEvents pbxListxlocal As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
