<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInformeGastos
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ConsInformePatrimonioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsInformePatrimonioTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsInformePatrimonioTableAdapter()
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsInformePatrimonioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ConsInformePatrimonioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpGastos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(23, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 475)
        Me.ReportViewer1.TabIndex = 0
        '
        'tallerDataSet
        '
        Me.tallerDataSet.DataSetName = "tallerDataSet"
        Me.tallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsInformePatrimonioBindingSource
        '
        Me.ConsInformePatrimonioBindingSource.DataMember = "ConsInformePatrimonio"
        Me.ConsInformePatrimonioBindingSource.DataSource = Me.tallerDataSet
        '
        'ConsInformePatrimonioTableAdapter
        '
        Me.ConsInformePatrimonioTableAdapter.ClearBeforeFill = True
        '
        'frmInformeGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 600)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmInformeGastos"
        Me.Text = "Gastos"
        CType(Me.tallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsInformePatrimonioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsInformePatrimonioBindingSource As BindingSource
    Friend WithEvents tallerDataSet As tallerDataSet
    Friend WithEvents ConsInformePatrimonioTableAdapter As tallerDataSetTableAdapters.ConsInformePatrimonioTableAdapter
End Class
