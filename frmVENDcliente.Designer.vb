<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENDcliente
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
        Me.dgvListacliente = New System.Windows.Forms.DataGridView
        Me.btnSalirCliente = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdatos = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvListacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListacliente
        '
        Me.dgvListacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListacliente.Location = New System.Drawing.Point(56, 87)
        Me.dgvListacliente.Name = "dgvListacliente"
        Me.dgvListacliente.Size = New System.Drawing.Size(766, 285)
        Me.dgvListacliente.TabIndex = 0
        '
        'btnSalirCliente
        '
        Me.btnSalirCliente.AllowDrop = True
        Me.btnSalirCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalirCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirCliente.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirCliente.Location = New System.Drawing.Point(381, 378)
        Me.btnSalirCliente.Name = "btnSalirCliente"
        Me.btnSalirCliente.Size = New System.Drawing.Size(167, 62)
        Me.btnSalirCliente.TabIndex = 13
        Me.btnSalirCliente.Text = "Salir"
        Me.btnSalirCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 26)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Lista de Clientes"
        '
        'txtdatos
        '
        Me.txtdatos.Location = New System.Drawing.Point(128, 399)
        Me.txtdatos.Name = "txtdatos"
        Me.txtdatos.Size = New System.Drawing.Size(178, 20)
        Me.txtdatos.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources._57776f817f6566ce110c90eadfb5dad0434e5229_original1
        Me.PictureBox1.Location = New System.Drawing.Point(538, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(769, 430)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(684, 430)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENDcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(871, 452)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtdatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalirCliente)
        Me.Controls.Add(Me.dgvListacliente)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(887, 490)
        Me.Name = "frmVENDcliente"
        Me.Text = "Lista de Clientes"
        CType(Me.dgvListacliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListacliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalirCliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdatos As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
