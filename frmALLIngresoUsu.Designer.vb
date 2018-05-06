<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmALLIngresoUsu
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
        Me.lblTituloAccUsu = New System.Windows.Forms.Label
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.lblContraseña = New System.Windows.Forms.Label
        Me.txtContraseña = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.pbxIngresoUsu = New System.Windows.Forms.PictureBox
        CType(Me.pbxIngresoUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloAccUsu
        '
        Me.lblTituloAccUsu.AutoSize = True
        Me.lblTituloAccUsu.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAccUsu.Location = New System.Drawing.Point(69, 9)
        Me.lblTituloAccUsu.Name = "lblTituloAccUsu"
        Me.lblTituloAccUsu.Size = New System.Drawing.Size(128, 17)
        Me.lblTituloAccUsu.TabIndex = 0
        Me.lblTituloAccUsu.Text = "ACCESO AL SISTEMA"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(90, 113)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(81, 13)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Ingrese Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(56, 129)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(159, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(90, 159)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(98, 13)
        Me.lblContraseña.TabIndex = 3
        Me.lblContraseña.Text = "Ingrese contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(56, 175)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(159, 20)
        Me.txtContraseña.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(93, 215)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Ingresar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'pbxIngresoUsu
        '
        Me.pbxIngresoUsu.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.icono_login
        Me.pbxIngresoUsu.Location = New System.Drawing.Point(88, 29)
        Me.pbxIngresoUsu.Name = "pbxIngresoUsu"
        Me.pbxIngresoUsu.Size = New System.Drawing.Size(83, 81)
        Me.pbxIngresoUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIngresoUsu.TabIndex = 7
        Me.pbxIngresoUsu.TabStop = False
        '
        'frmALLIngresoUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(258, 250)
        Me.Controls.Add(Me.pbxIngresoUsu)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblTituloAccUsu)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(274, 288)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(274, 288)
        Me.Name = "frmALLIngresoUsu"
        Me.Text = "Administrar Usuarios"
        CType(Me.pbxIngresoUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloAccUsu As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents pbxIngresoUsu As System.Windows.Forms.PictureBox

End Class
