<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadosStockMinimo
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
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.cmbFamilia = New MetroFramework.Controls.MetroComboBox()
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.rbIdFamilia = New MetroFramework.Controls.MetroRadioButton()
        Me.rbTodos = New MetroFramework.Controls.MetroRadioButton()
        Me.FamiliaTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FamiliaTableAdapter()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(343, 175)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 86
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(235, 175)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 85
        Me.MetroButton1.Text = "Imprimir"
        '
        'cmbFamilia
        '
        Me.cmbFamilia.DataSource = Me.FamiliaBindingSource
        Me.cmbFamilia.DisplayMember = "descripcion"
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.ItemHeight = 23
        Me.cmbFamilia.Location = New System.Drawing.Point(172, 109)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(273, 29)
        Me.cmbFamilia.TabIndex = 84
        Me.cmbFamilia.ValueMember = "Id"
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataMember = "Familia"
        Me.FamiliaBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbIdFamilia
        '
        Me.rbIdFamilia.AutoSize = True
        Me.rbIdFamilia.Location = New System.Drawing.Point(23, 111)
        Me.rbIdFamilia.Name = "rbIdFamilia"
        Me.rbIdFamilia.Size = New System.Drawing.Size(127, 15)
        Me.rbIdFamilia.TabIndex = 83
        Me.rbIdFamilia.Text = "Seleccionar Familia:"
        Me.rbIdFamilia.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(23, 78)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(123, 15)
        Me.rbTodos.TabIndex = 82
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos los Artículos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'FamiliaTableAdapter
        '
        Me.FamiliaTableAdapter.ClearBeforeFill = True
        '
        'frmListadosStockMinimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(467, 242)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.cmbFamilia)
        Me.Controls.Add(Me.rbIdFamilia)
        Me.Controls.Add(Me.rbTodos)
        Me.Name = "frmListadosStockMinimo"
        Me.Text = "Artículos Stock bajo Mínimo"
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbFamilia As MetroFramework.Controls.MetroComboBox
    Friend WithEvents rbIdFamilia As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbTodos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents FamiliaTableAdapter As tallerDataSetTableAdapters.FamiliaTableAdapter
End Class
