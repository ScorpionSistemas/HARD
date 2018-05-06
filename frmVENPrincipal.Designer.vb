<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVENPrincipal
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
        Me.gbxVentas = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnModi = New System.Windows.Forms.Button
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.txtCproducto = New System.Windows.Forms.TextBox
        Me.txtNcliente = New System.Windows.Forms.TextBox
        Me.txtNfactura = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnPrimero = New System.Windows.Forms.Button
        Me.txtNombrecliente = New System.Windows.Forms.TextBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnConsultas = New System.Windows.Forms.Button
        Me.btnNventa = New System.Windows.Forms.Button
        Me.btnBcliente = New System.Windows.Forms.Button
        Me.lvlNueva = New System.Windows.Forms.Label
        Me.lvlModificar = New System.Windows.Forms.Label
        Me.btnBproducto = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModiicarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnularVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaPorFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaPorProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformeDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.gbxVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxVentas
        '
        Me.gbxVentas.Controls.Add(Me.btnCancelar)
        Me.gbxVentas.Controls.Add(Me.dtpFecha)
        Me.gbxVentas.Controls.Add(Me.btnConfirmar)
        Me.gbxVentas.Controls.Add(Me.btnEliminar)
        Me.gbxVentas.Controls.Add(Me.btnLimpiar)
        Me.gbxVentas.Controls.Add(Me.btnModi)
        Me.gbxVentas.Controls.Add(Me.txtFecha)
        Me.gbxVentas.Controls.Add(Me.txtTotal)
        Me.gbxVentas.Controls.Add(Me.txtPrecio)
        Me.gbxVentas.Controls.Add(Me.txtCantidad)
        Me.gbxVentas.Controls.Add(Me.txtCproducto)
        Me.gbxVentas.Controls.Add(Me.txtNcliente)
        Me.gbxVentas.Controls.Add(Me.txtNfactura)
        Me.gbxVentas.Controls.Add(Me.Label8)
        Me.gbxVentas.Controls.Add(Me.Label7)
        Me.gbxVentas.Controls.Add(Me.Label6)
        Me.gbxVentas.Controls.Add(Me.Label5)
        Me.gbxVentas.Controls.Add(Me.Label4)
        Me.gbxVentas.Controls.Add(Me.Label3)
        Me.gbxVentas.Controls.Add(Me.Label2)
        Me.gbxVentas.Controls.Add(Me.btnUltimo)
        Me.gbxVentas.Controls.Add(Me.btnSiguiente)
        Me.gbxVentas.Controls.Add(Me.btnAnterior)
        Me.gbxVentas.Controls.Add(Me.btnPrimero)
        Me.gbxVentas.Controls.Add(Me.txtNombrecliente)
        Me.gbxVentas.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVentas.Location = New System.Drawing.Point(305, 83)
        Me.gbxVentas.Name = "gbxVentas"
        Me.gbxVentas.Size = New System.Drawing.Size(603, 373)
        Me.gbxVentas.TabIndex = 13
        Me.gbxVentas.TabStop = False
        Me.gbxVentas.Text = "Ventas"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(444, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 59)
        Me.btnCancelar.TabIndex = 148
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(199, 115)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(213, 25)
        Me.dtpFecha.TabIndex = 17
        Me.dtpFecha.Visible = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnConfirmar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(6, 293)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(153, 59)
        Me.btnConfirmar.TabIndex = 16
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        Me.btnConfirmar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEliminar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.ELIMINAR
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(162, 292)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(134, 59)
        Me.btnEliminar.TabIndex = 147
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        Me.btnEliminar.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnLimpiar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.limpiar_chico
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(302, 292)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(136, 59)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        Me.btnLimpiar.Visible = False
        '
        'btnModi
        '
        Me.btnModi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnModi.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar_icono_chico
        Me.btnModi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModi.Location = New System.Drawing.Point(3, 292)
        Me.btnModi.Name = "btnModi"
        Me.btnModi.Size = New System.Drawing.Size(150, 59)
        Me.btnModi.TabIndex = 146
        Me.btnModi.Text = "Modificar"
        Me.btnModi.UseVisualStyleBackColor = False
        Me.btnModi.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(199, 115)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(213, 25)
        Me.txtFecha.TabIndex = 145
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(199, 251)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(213, 25)
        Me.txtTotal.TabIndex = 144
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(199, 216)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(213, 25)
        Me.txtPrecio.TabIndex = 143
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(199, 182)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(213, 25)
        Me.txtCantidad.TabIndex = 142
        '
        'txtCproducto
        '
        Me.txtCproducto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCproducto.Location = New System.Drawing.Point(199, 149)
        Me.txtCproducto.Name = "txtCproducto"
        Me.txtCproducto.ReadOnly = True
        Me.txtCproducto.Size = New System.Drawing.Size(213, 25)
        Me.txtCproducto.TabIndex = 141
        '
        'txtNcliente
        '
        Me.txtNcliente.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNcliente.Location = New System.Drawing.Point(199, 81)
        Me.txtNcliente.Name = "txtNcliente"
        Me.txtNcliente.ReadOnly = True
        Me.txtNcliente.Size = New System.Drawing.Size(213, 25)
        Me.txtNcliente.TabIndex = 140
        '
        'txtNfactura
        '
        Me.txtNfactura.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNfactura.Location = New System.Drawing.Point(199, 46)
        Me.txtNfactura.Name = "txtNfactura"
        Me.txtNfactura.ReadOnly = True
        Me.txtNfactura.Size = New System.Drawing.Size(213, 25)
        Me.txtNfactura.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "Nro. de Factura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(53, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(60, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(60, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(60, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Codigo de Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(60, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(60, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Nro. de Cliente"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(329, 304)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(71, 36)
        Me.btnUltimo.TabIndex = 131
        Me.btnUltimo.Text = ">>>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(241, 303)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(71, 36)
        Me.btnSiguiente.TabIndex = 130
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAnterior.Location = New System.Drawing.Point(153, 303)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(71, 36)
        Me.btnAnterior.TabIndex = 129
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrimero.Location = New System.Drawing.Point(63, 304)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(71, 36)
        Me.btnPrimero.TabIndex = 128
        Me.btnPrimero.Text = "<<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'txtNombrecliente
        '
        Me.txtNombrecliente.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrecliente.Location = New System.Drawing.Point(199, 28)
        Me.txtNombrecliente.Name = "txtNombrecliente"
        Me.txtNombrecliente.ReadOnly = True
        Me.txtNombrecliente.Size = New System.Drawing.Size(213, 25)
        Me.txtNombrecliente.TabIndex = 140
        Me.txtNombrecliente.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar_icono_chico
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(35, 146)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(209, 72)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar o Anular Venta"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnConsultas
        '
        Me.btnConsultas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Location = New System.Drawing.Point(35, 242)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(209, 64)
        Me.btnConsultas.TabIndex = 10
        Me.btnConsultas.Text = "Consulta de Ventas"
        Me.btnConsultas.UseVisualStyleBackColor = False
        '
        'btnNventa
        '
        Me.btnNventa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNventa.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Agregar_icono_cruz_chiquito
        Me.btnNventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNventa.Location = New System.Drawing.Point(35, 63)
        Me.btnNventa.Name = "btnNventa"
        Me.btnNventa.Size = New System.Drawing.Size(209, 63)
        Me.btnNventa.TabIndex = 9
        Me.btnNventa.Text = "Nueva Venta"
        Me.btnNventa.UseVisualStyleBackColor = False
        '
        'btnBcliente
        '
        Me.btnBcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBcliente.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBcliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBcliente.Location = New System.Drawing.Point(867, 192)
        Me.btnBcliente.Name = "btnBcliente"
        Me.btnBcliente.Size = New System.Drawing.Size(109, 55)
        Me.btnBcliente.TabIndex = 14
        Me.btnBcliente.Text = "Buscar Cliente"
        Me.btnBcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBcliente.UseVisualStyleBackColor = False
        Me.btnBcliente.Visible = False
        '
        'lvlNueva
        '
        Me.lvlNueva.AutoSize = True
        Me.lvlNueva.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlNueva.Location = New System.Drawing.Point(401, 33)
        Me.lvlNueva.Name = "lvlNueva"
        Me.lvlNueva.Size = New System.Drawing.Size(373, 30)
        Me.lvlNueva.TabIndex = 15
        Me.lvlNueva.Text = "Puede Agregar Una Nueva Venta"
        Me.lvlNueva.Visible = False
        '
        'lvlModificar
        '
        Me.lvlModificar.AutoSize = True
        Me.lvlModificar.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlModificar.Location = New System.Drawing.Point(369, 33)
        Me.lvlModificar.Name = "lvlModificar"
        Me.lvlModificar.Size = New System.Drawing.Size(437, 30)
        Me.lvlModificar.TabIndex = 17
        Me.lvlModificar.Text = "Puede Modificar o Elimirar esta Venta"
        Me.lvlModificar.Visible = False
        '
        'btnBproducto
        '
        Me.btnBproducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBproducto.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        Me.btnBproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBproducto.Location = New System.Drawing.Point(867, 264)
        Me.btnBproducto.Name = "btnBproducto"
        Me.btnBproducto.Size = New System.Drawing.Size(109, 50)
        Me.btnBproducto.TabIndex = 18
        Me.btnBproducto.Text = "Buscar Producto"
        Me.btnBproducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBproducto.UseVisualStyleBackColor = False
        Me.btnBproducto.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(35, 384)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(209, 72)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 141
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.ModiicarVentasToolStripMenuItem, Me.AnularVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva Venta"
        '
        'ModiicarVentasToolStripMenuItem
        '
        Me.ModiicarVentasToolStripMenuItem.Name = "ModiicarVentasToolStripMenuItem"
        Me.ModiicarVentasToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ModiicarVentasToolStripMenuItem.Text = "Modiicar Venta"
        '
        'AnularVentaToolStripMenuItem
        '
        Me.AnularVentaToolStripMenuItem.Name = "AnularVentaToolStripMenuItem"
        Me.AnularVentaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AnularVentaToolStripMenuItem.Text = "Anular Venta"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaPorFacturaToolStripMenuItem, Me.ConsultaPorToolStripMenuItem, Me.ConsultaPorProductoToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultaPorFacturaToolStripMenuItem
        '
        Me.ConsultaPorFacturaToolStripMenuItem.Name = "ConsultaPorFacturaToolStripMenuItem"
        Me.ConsultaPorFacturaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConsultaPorFacturaToolStripMenuItem.Text = "Consulta por Factura"
        '
        'ConsultaPorToolStripMenuItem
        '
        Me.ConsultaPorToolStripMenuItem.Name = "ConsultaPorToolStripMenuItem"
        Me.ConsultaPorToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConsultaPorToolStripMenuItem.Text = "Consulta por Fecha"
        '
        'ConsultaPorProductoToolStripMenuItem
        '
        Me.ConsultaPorProductoToolStripMenuItem.Name = "ConsultaPorProductoToolStripMenuItem"
        Me.ConsultaPorProductoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConsultaPorProductoToolStripMenuItem.Text = "Consulta por Producto"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeDeVentasToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'InformeDeVentasToolStripMenuItem
        '
        Me.InformeDeVentasToolStripMenuItem.Name = "InformeDeVentasToolStripMenuItem"
        Me.InformeDeVentasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.InformeDeVentasToolStripMenuItem.Text = "Informe de Ventas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'lblUsuarioActivo
        '
        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(890, 480)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioActivo.TabIndex = 143
        Me.lblUsuarioActivo.Text = "Usuario Activo"
        '
        'lblUsrAct
        '
        Me.lblUsrAct.AutoSize = True
        Me.lblUsrAct.Location = New System.Drawing.Point(805, 480)
        Me.lblUsrAct.Name = "lblUsrAct"
        Me.lblUsrAct.Size = New System.Drawing.Size(79, 13)
        Me.lblUsrAct.TabIndex = 142
        Me.lblUsrAct.Text = "Usuario Activo:"
        '
        'frmVENPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(992, 502)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.btnBproducto)
        Me.Controls.Add(Me.lvlModificar)
        Me.Controls.Add(Me.lvlNueva)
        Me.Controls.Add(Me.btnBcliente)
        Me.Controls.Add(Me.gbxVentas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnNventa)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1008, 540)
        Me.Name = "frmVENPrincipal"
        Me.Text = "Ventas"
        Me.gbxVentas.ResumeLayout(False)
        Me.gbxVentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxVentas As System.Windows.Forms.GroupBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCproducto As System.Windows.Forms.TextBox
    Friend WithEvents txtNcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnConsultas As System.Windows.Forms.Button
    Friend WithEvents btnNventa As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModi As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBcliente As System.Windows.Forms.Button
    Friend WithEvents lvlNueva As System.Windows.Forms.Label
    Friend WithEvents lvlModificar As System.Windows.Forms.Label
    Friend WithEvents btnBproducto As System.Windows.Forms.Button
    Friend WithEvents txtNombrecliente As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModiicarVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaPorFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaPorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaPorProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformeDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
End Class
