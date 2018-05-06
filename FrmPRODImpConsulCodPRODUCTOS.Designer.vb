<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRODImpConsulCodPRODUCTOS
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
        Me.CRVCodPRODUCTOS = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRVCodPRODUCTOS
        '
        Me.CRVCodPRODUCTOS.ActiveViewIndex = -1
        Me.CRVCodPRODUCTOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVCodPRODUCTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVCodPRODUCTOS.Location = New System.Drawing.Point(0, 0)
        Me.CRVCodPRODUCTOS.Name = "CRVCodPRODUCTOS"
        Me.CRVCodPRODUCTOS.SelectionFormula = ""
        Me.CRVCodPRODUCTOS.Size = New System.Drawing.Size(1012, 559)
        Me.CRVCodPRODUCTOS.TabIndex = 0
        Me.CRVCodPRODUCTOS.ViewTimeSelectionFormula = ""
        '
        'FrmPRODImpConsulCodPRODUCTOS
        '
        Me.ClientSize = New System.Drawing.Size(1012, 559)
        Me.Controls.Add(Me.CRVCodPRODUCTOS)
        Me.Name = "FrmPRODImpConsulCodPRODUCTOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVCodPRODUCTOS As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
