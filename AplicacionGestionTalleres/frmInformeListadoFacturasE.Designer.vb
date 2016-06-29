<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeListadoFacturasE
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.informeFacturaEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.informeFacturaETableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.informeFacturaETableAdapter()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.informeFacturaEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.informeFacturaEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpInformeListadoFacturasE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(827, 476)
        Me.ReportViewer1.TabIndex = 0
        '
        'tallerDataSet
        '
        Me.tallerDataSet.DataSetName = "tallerDataSet"
        Me.tallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'informeFacturaEBindingSource
        '
        Me.informeFacturaEBindingSource.DataMember = "informeFacturaE"
        Me.informeFacturaEBindingSource.DataSource = Me.tallerDataSet
        '
        'informeFacturaETableAdapter
        '
        Me.informeFacturaETableAdapter.ClearBeforeFill = True
        '
        'frmInformeListadoFacturasE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 563)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmInformeListadoFacturasE"
        Me.Text = "Listado facturas emitidas"
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.informeFacturaEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents informeFacturaEBindingSource As BindingSource
    Friend WithEvents tallerDataSet As tallerDataSet
    Friend WithEvents informeFacturaETableAdapter As tallerDataSetTableAdapters.informeFacturaETableAdapter
End Class
