<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeStock))
        Me.ConsProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsProductoTableAdapter1 = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        Me.ConsProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ConsProductoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpInformeStock.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(865, 481)
        Me.ReportViewer1.TabIndex = 0
        '
        'ConsProductoTableAdapter1
        '
        Me.ConsProductoTableAdapter1.ClearBeforeFill = True
        '
        'ConsProductoTableAdapter
        '
        Me.ConsProductoTableAdapter.ClearBeforeFill = True
        '
        'frmInformeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 603)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformeStock"
        Me.Text = "Informe stock"
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsProductoTableAdapter1 As tallerDataSetTableAdapters.ConsProductoTableAdapter
    Friend WithEvents ConsProductoBindingSource As BindingSource
    Friend WithEvents tallerDataSet As tallerDataSet
    Friend WithEvents ConsProductoTableAdapter As tallerDataSetTableAdapters.ConsProductoTableAdapter
End Class
