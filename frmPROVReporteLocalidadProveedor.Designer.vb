<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROVReporteLocalidadProveedor
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
        Me.crvProveedoresLocalidad = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvProveedoresLocalidad
        '
        Me.crvProveedoresLocalidad.ActiveViewIndex = -1
        Me.crvProveedoresLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvProveedoresLocalidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvProveedoresLocalidad.Location = New System.Drawing.Point(0, 0)
        Me.crvProveedoresLocalidad.Name = "crvProveedoresLocalidad"
        Me.crvProveedoresLocalidad.SelectionFormula = ""
        Me.crvProveedoresLocalidad.Size = New System.Drawing.Size(1176, 643)
        Me.crvProveedoresLocalidad.TabIndex = 0
        Me.crvProveedoresLocalidad.ViewTimeSelectionFormula = ""
        '
        'frmPROVReporteLocalidadProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 643)
        Me.Controls.Add(Me.crvProveedoresLocalidad)
        Me.Name = "frmPROVReporteLocalidadProveedor"
        Me.Text = "BUSQUEDA PROVEEDORES POR LOCALIDAD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvProveedoresLocalidad As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
