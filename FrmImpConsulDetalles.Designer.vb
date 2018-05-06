<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpConsulDetalles
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
        Me.CRVDetallePRODUCTOS = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRVDetallePRODUCTOS
        '
        Me.CRVDetallePRODUCTOS.ActiveViewIndex = -1
        Me.CRVDetallePRODUCTOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVDetallePRODUCTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVDetallePRODUCTOS.Location = New System.Drawing.Point(0, 0)
        Me.CRVDetallePRODUCTOS.Name = "CRVDetallePRODUCTOS"
        Me.CRVDetallePRODUCTOS.SelectionFormula = ""
        Me.CRVDetallePRODUCTOS.Size = New System.Drawing.Size(1012, 559)
        Me.CRVDetallePRODUCTOS.TabIndex = 0
        Me.CRVDetallePRODUCTOS.ViewTimeSelectionFormula = ""
        '
        'FrmImpConsulDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 559)
        Me.Controls.Add(Me.CRVDetallePRODUCTOS)
        Me.Name = "FrmImpConsulDetalles"
        Me.Text = "FrmImpConsulDetalles"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVDetallePRODUCTOS As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
