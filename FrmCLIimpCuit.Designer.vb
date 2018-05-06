<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCLIimpCuit
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
        Me.CRImpcuit = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crimpcuit1 = New HARD_INSUMOS_INFORMATICOS.crimpcuit
        Me.SuspendLayout()
        '
        'CRImpcuit
        '
        Me.CRImpcuit.ActiveViewIndex = 0
        Me.CRImpcuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRImpcuit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRImpcuit.Location = New System.Drawing.Point(0, 0)
        Me.CRImpcuit.Name = "CRImpcuit"
        Me.CRImpcuit.ReportSource = Me.crimpcuit1
        Me.CRImpcuit.Size = New System.Drawing.Size(1012, 559)
        Me.CRImpcuit.TabIndex = 0
        '
        'FrmCLIimpCuit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 559)
        Me.Controls.Add(Me.CRImpcuit)
        Me.Name = "FrmCLIimpCuit"
        Me.Text = "FrmCLIimpCuit"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRImpcuit As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crimpcuit1 As HARD_INSUMOS_INFORMATICOS.crimpcuit
End Class
