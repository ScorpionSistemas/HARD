<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROVReporteProveedorRazonSocial
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
        Me.crvReporteProveedoresRazSoc = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReporteProveedoresRazSoc
        '
        Me.crvReporteProveedoresRazSoc.ActiveViewIndex = -1
        Me.crvReporteProveedoresRazSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporteProveedoresRazSoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporteProveedoresRazSoc.Location = New System.Drawing.Point(0, 0)
        Me.crvReporteProveedoresRazSoc.Name = "crvReporteProveedoresRazSoc"
        Me.crvReporteProveedoresRazSoc.SelectionFormula = ""
        Me.crvReporteProveedoresRazSoc.Size = New System.Drawing.Size(1259, 645)
        Me.crvReporteProveedoresRazSoc.TabIndex = 0
        Me.crvReporteProveedoresRazSoc.ViewTimeSelectionFormula = ""
        '
        'frmPROVReporteProveedorRazonSocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 645)
        Me.Controls.Add(Me.crvReporteProveedoresRazSoc)
        Me.Name = "frmPROVReporteProveedorRazonSocial"
        Me.Text = "REPORTE PROVEEDORES BUSQUEDA POR RAZON SOCIAL"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReporteProveedoresRazSoc As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
