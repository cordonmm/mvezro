<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoProveedores))
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.informeFacturaEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProveedorTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProveedorTableAdapter()
        Me.informeFacturaETableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.informeFacturaETableAdapter()
        Me.ProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProductoTableAdapter()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.informeFacturaEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.tallerDataSet
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
        'informeFacturaEBindingSource
        '
        Me.informeFacturaEBindingSource.DataMember = "informeFacturaE"
        Me.informeFacturaEBindingSource.DataSource = Me.tallerDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ProveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(23, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(704, 482)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'informeFacturaETableAdapter
        '
        Me.informeFacturaETableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'frmListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 568)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListadoProveedores"
        Me.Text = "Listado Proveedores"
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.informeFacturaEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents tallerDataSet As tallerDataSet
    Friend WithEvents ProveedorTableAdapter As tallerDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents informeFacturaEBindingSource As BindingSource
    Friend WithEvents informeFacturaETableAdapter As tallerDataSetTableAdapters.informeFacturaETableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As tallerDataSetTableAdapters.ProductoTableAdapter
End Class
