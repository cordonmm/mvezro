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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeListadoFacturasE))
        Me.ConsFacturaEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsFacturaETableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsFacturaETableAdapter()
        CType(Me.ConsFacturaEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsFacturaEBindingSource
        '
        Me.ConsFacturaEBindingSource.DataMember = "ConsFacturaE"
        Me.ConsFacturaEBindingSource.DataSource = Me.tallerDataSet
        '
        'tallerDataSet
        '
        Me.tallerDataSet.DataSetName = "tallerDataSet"
        Me.tallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ConsFacturaEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpInformeListadoFacturasE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(681, 504)
        Me.ReportViewer1.TabIndex = 0
        '
        'ConsFacturaETableAdapter
        '
        Me.ConsFacturaETableAdapter.ClearBeforeFill = True
        '
        'frmInformeListadoFacturasE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 591)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformeListadoFacturasE"
        Me.Text = "Listado facturas emitidas"
        CType(Me.ConsFacturaEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsFacturaEBindingSource As BindingSource
    Friend WithEvents tallerDataSet As tallerDataSet
    Friend WithEvents ConsFacturaETableAdapter As tallerDataSetTableAdapters.ConsFacturaETableAdapter
End Class
