<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRODProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPRODProductos))
        Me.codigo_producto = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCodigoprod = New System.Windows.Forms.TextBox
        Me.txtDetalleprod = New System.Windows.Forms.TextBox
        Me.txtCantidadprod = New System.Windows.Forms.TextBox
        Me.txtPrecUniprod = New System.Windows.Forms.TextBox
        Me.btnPrim = New System.Windows.Forms.Button
        Me.btnAnt = New System.Windows.Forms.Button
        Me.btnSig = New System.Windows.Forms.Button
        Me.btnUlt = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataSet1 = New System.Data.DataSet
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnVolverAlMenu = New System.Windows.Forms.Button
        Me.btnConfAgreg = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.BtnCanc = New System.Windows.Forms.Button
        Me.btnElimProd = New System.Windows.Forms.Button
        Me.btnModProd = New System.Windows.Forms.Button
        Me.btnIngProd = New System.Windows.Forms.Button
        Me.lblUsuarioActivo = New System.Windows.Forms.Label
        Me.lblUsrAct = New System.Windows.Forms.Label
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'codigo_producto
        '
        resources.ApplyResources(Me.codigo_producto, "codigo_producto")
        Me.codigo_producto.Name = "codigo_producto"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtCodigoprod
        '
        resources.ApplyResources(Me.txtCodigoprod, "txtCodigoprod")
        Me.txtCodigoprod.Name = "txtCodigoprod"
        Me.txtCodigoprod.ReadOnly = True
        '
        'txtDetalleprod
        '
        resources.ApplyResources(Me.txtDetalleprod, "txtDetalleprod")
        Me.txtDetalleprod.Name = "txtDetalleprod"
        Me.txtDetalleprod.ReadOnly = True
        '
        'txtCantidadprod
        '
        resources.ApplyResources(Me.txtCantidadprod, "txtCantidadprod")
        Me.txtCantidadprod.Name = "txtCantidadprod"
        Me.txtCantidadprod.ReadOnly = True
        '
        'txtPrecUniprod
        '
        resources.ApplyResources(Me.txtPrecUniprod, "txtPrecUniprod")
        Me.txtPrecUniprod.Name = "txtPrecUniprod"
        Me.txtPrecUniprod.ReadOnly = True
        '
        'btnPrim
        '
        resources.ApplyResources(Me.btnPrim, "btnPrim")
        Me.btnPrim.Name = "btnPrim"
        Me.btnPrim.UseVisualStyleBackColor = True
        '
        'btnAnt
        '
        resources.ApplyResources(Me.btnAnt, "btnAnt")
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        resources.ApplyResources(Me.btnSig, "btnSig")
        Me.btnSig.Name = "btnSig"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnUlt
        '
        resources.ApplyResources(Me.btnUlt, "btnUlt")
        Me.btnUlt.Name = "btnUlt"
        Me.btnUlt.UseVisualStyleBackColor = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        resources.ApplyResources(Me.btnConfirm, "btnConfirm")
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolverAlMenu.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.salir
        resources.ApplyResources(Me.btnVolverAlMenu, "btnVolverAlMenu")
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = False
        '
        'btnConfAgreg
        '
        Me.btnConfAgreg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfAgreg.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Check_icon
        resources.ApplyResources(Me.btnConfAgreg, "btnConfAgreg")
        Me.btnConfAgreg.Name = "btnConfAgreg"
        Me.btnConfAgreg.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.lupa1
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'BtnCanc
        '
        Me.BtnCanc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCanc.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Actions_dialog_cancel_icon
        resources.ApplyResources(Me.BtnCanc, "BtnCanc")
        Me.BtnCanc.Name = "BtnCanc"
        Me.BtnCanc.UseVisualStyleBackColor = False
        '
        'btnElimProd
        '
        Me.btnElimProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnElimProd.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.ELIMINAR
        resources.ApplyResources(Me.btnElimProd, "btnElimProd")
        Me.btnElimProd.Name = "btnElimProd"
        Me.btnElimProd.UseVisualStyleBackColor = False
        '
        'btnModProd
        '
        Me.btnModProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModProd.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.modificar_icono_chico
        resources.ApplyResources(Me.btnModProd, "btnModProd")
        Me.btnModProd.Name = "btnModProd"
        Me.btnModProd.UseVisualStyleBackColor = False
        '
        'btnIngProd
        '
        Me.btnIngProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIngProd.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.Agregar_icono_cruz_chiquito
        resources.ApplyResources(Me.btnIngProd, "btnIngProd")
        Me.btnIngProd.Name = "btnIngProd"
        Me.btnIngProd.UseVisualStyleBackColor = False
        '
        'lblUsuarioActivo
        '
        resources.ApplyResources(Me.lblUsuarioActivo, "lblUsuarioActivo")
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        '
        'lblUsrAct
        '
        resources.ApplyResources(Me.lblUsrAct, "lblUsrAct")
        Me.lblUsrAct.Name = "lblUsrAct"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.btnLimpiar, "btnLimpiar")
        Me.btnLimpiar.Image = Global.HARD_INSUMOS_INFORMATICOS.My.Resources.Resources.limpiar_chico
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtProveedor
        '
        resources.ApplyResources(Me.txtProveedor, "txtProveedor")
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'FrmPRODProductos
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblUsuarioActivo)
        Me.Controls.Add(Me.lblUsrAct)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Controls.Add(Me.btnConfAgreg)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.BtnCanc)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUlt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnPrim)
        Me.Controls.Add(Me.txtPrecUniprod)
        Me.Controls.Add(Me.txtCantidadprod)
        Me.Controls.Add(Me.txtDetalleprod)
        Me.Controls.Add(Me.txtCodigoprod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codigo_producto)
        Me.Controls.Add(Me.btnElimProd)
        Me.Controls.Add(Me.btnModProd)
        Me.Controls.Add(Me.btnIngProd)
        Me.MaximizeBox = False
        Me.Name = "FrmPRODProductos"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngProd As System.Windows.Forms.Button
    Friend WithEvents btnModProd As System.Windows.Forms.Button
    Friend WithEvents btnElimProd As System.Windows.Forms.Button
    Friend WithEvents codigo_producto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoprod As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleprod As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadprod As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecUniprod As System.Windows.Forms.TextBox
    Friend WithEvents btnPrim As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnUlt As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents BtnCanc As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnConfAgreg As System.Windows.Forms.Button
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents lblUsrAct As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
