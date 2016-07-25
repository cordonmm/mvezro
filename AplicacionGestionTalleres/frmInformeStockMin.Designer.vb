<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeStockMin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeStockMin))
        Me.ConsProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProductoTableAdapter()
        Me.ConsProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsProductoBindingSource
        '
        Me.ConsProductoBindingSource.DataMember = "ConsProducto"
        Me.ConsProductoBindingSource.DataSource = Me.tallerDataSet
        '
        'tallerDataSet
        '
        Me.tallerDataSet.DataSetName = "tallerDataSet"
        Me.tallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.tallerDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ConsProductoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpInformeStockMin.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(23, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(710, 483)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ConsProductoTableAdapter
        '
        Me.ConsProductoTableAdapter.ClearBeforeFill = True
        '
        'frmInformeStockMin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 569)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformeStockMin"
        Me.Text = "Informe Stock Mínimo"
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents tallerDataSet As tallerDataSet
    Friend WithEvents ProductoTableAdapter As tallerDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents ConsProductoBindingSource As BindingSource
    Friend WithEvents ConsProductoTableAdapter As tallerDataSetTableAdapters.ConsProductoTableAdapter
End Class
