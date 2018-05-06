<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROVBusquedaLocalidadProv
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
        Me.btnLocalidad = New System.Windows.Forms.Button
        Me.txtBusqLocalidadProv = New System.Windows.Forms.TextBox
        Me.btnBackProv = New System.Windows.Forms.Button
        Me.btnImpresionLocalidad = New System.Windows.Forms.Button
        Me.dgvLocalidadProv = New System.Windows.Forms.DataGridView
        Me.gprBusqueda = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        CType(Me.dgvLocalidadProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gprBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLocalidad
        '
        Me.btnLocalidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLocalidad.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnLocalidad.Location = New System.Drawing.Point(222, 145)
        Me.btnLocalidad.Name = "btnLocalidad"
        Me.btnLocalidad.Size = New System.Drawing.Size(45, 36)
        Me.btnLocalidad.TabIndex = 0
        Me.btnLocalidad.UseVisualStyleBackColor = False
        '
        'txtBusqLocalidadProv
        '
        Me.txtBusqLocalidadProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqLocalidadProv.Location = New System.Drawing.Point(24, 152)
        Me.txtBusqLocalidadProv.Name = "txtBusqLocalidadProv"
        Me.txtBusqLocalidadProv.Size = New System.Drawing.Size(192, 23)
        Me.txtBusqLocalidadProv.TabIndex = 1
        '
        'btnBackProv
        '
        Me.btnBackProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackProv.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnBackProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackProv.Location = New System.Drawing.Point(420, 441)
        Me.btnBackProv.Name = "btnBackProv"
        Me.btnBackProv.Size = New System.Drawing.Size(162, 64)
        Me.btnBackProv.TabIndex = 2
        Me.btnBackProv.Text = "Salir"
        Me.btnBackProv.UseVisualStyleBackColor = False
        '
        'btnImpresionLocalidad
        '
        Me.btnImpresionLocalidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImpresionLocalidad.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.print
        Me.btnImpresionLocalidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpresionLocalidad.Location = New System.Drawing.Point(212, 441)
        Me.btnImpresionLocalidad.Name = "btnImpresionLocalidad"
        Me.btnImpresionLocalidad.Size = New System.Drawing.Size(171, 64)
        Me.btnImpresionLocalidad.TabIndex = 3
        Me.btnImpresionLocalidad.Text = "Imprimir"
        Me.btnImpresionLocalidad.UseVisualStyleBackColor = False
        '
        'dgvLocalidadProv
        '
        Me.dgvLocalidadProv.AllowUserToAddRows = False
        Me.dgvLocalidadProv.AllowUserToDeleteRows = False
        Me.dgvLocalidadProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidadProv.Location = New System.Drawing.Point(24, 187)
        Me.dgvLocalidadProv.Name = "dgvLocalidadProv"
        Me.dgvLocalidadProv.ReadOnly = True
        Me.dgvLocalidadProv.Size = New System.Drawing.Size(752, 248)
        Me.dgvLocalidadProv.TabIndex = 4
        '
        'gprBusqueda
        '
        Me.gprBusqueda.Controls.Add(Me.Label4)
        Me.gprBusqueda.Controls.Add(Me.Label3)
        Me.gprBusqueda.Controls.Add(Me.Label2)
        Me.gprBusqueda.Controls.Add(Me.Label1)
        Me.gprBusqueda.Location = New System.Drawing.Point(8, 16)
        Me.gprBusqueda.Name = "gprBusqueda"
        Me.gprBusqueda.Size = New System.Drawing.Size(808, 120)
        Me.gprBusqueda.TabIndex = 10
        Me.gprBusqueda.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(771, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "*Como resultado la lista de Proveedores se hará mas pequeña, la cual podra obtene" & _
            "rla dandole click en el botón Imprimir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "*Si desea obtener el listado total de Proveedores, no complete el cuadro de texto" & _
            " y de directamente al botón Imprimir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*Una vez compeltado dar click en Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(711, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "*Para buscar debe completar el cuadro de texto con la letra o palabra que conteng" & _
            "a la Localidad del Proveedor"
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(733, 495)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 42
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(648, 495)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 41
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmPROVBusquedaLocalidadProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(836, 517)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.gprBusqueda)
        Me.Controls.Add(Me.dgvLocalidadProv)
        Me.Controls.Add(Me.btnImpresionLocalidad)
        Me.Controls.Add(Me.btnBackProv)
        Me.Controls.Add(Me.txtBusqLocalidadProv)
        Me.Controls.Add(Me.btnLocalidad)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(852, 555)
        Me.Name = "frmPROVBusquedaLocalidadProv"
        Me.Text = "BUSCAR PROVEEDOR POR LOCALIDAD"
        CType(Me.dgvLocalidadProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gprBusqueda.ResumeLayout(False)
        Me.gprBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLocalidad As System.Windows.Forms.Button
    Friend WithEvents txtBusqLocalidadProv As System.Windows.Forms.TextBox
    Friend WithEvents btnBackProv As System.Windows.Forms.Button
    Friend WithEvents btnImpresionLocalidad As System.Windows.Forms.Button
    Friend WithEvents dgvLocalidadProv As System.Windows.Forms.DataGridView
    Friend WithEvents gprBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
