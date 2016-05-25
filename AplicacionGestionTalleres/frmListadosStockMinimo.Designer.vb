<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadosStockMinimo
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
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FamiliaTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FamiliaTableAdapter()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MetroComboBox1
        '
        Me.MetroComboBox1.DataSource = Me.FamiliaBindingSource
        Me.MetroComboBox1.DisplayMember = "descripcion"
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(172, 109)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(273, 29)
        Me.MetroComboBox1.TabIndex = 84
        Me.MetroComboBox1.ValueMember = "Id"
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(23, 111)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(127, 15)
        Me.MetroRadioButton2.TabIndex = 83
        Me.MetroRadioButton2.Text = "Seleccionar Familia:"
        Me.MetroRadioButton2.UseVisualStyleBackColor = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Checked = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(23, 78)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(123, 15)
        Me.MetroRadioButton1.TabIndex = 82
        Me.MetroRadioButton1.TabStop = True
        Me.MetroRadioButton1.Text = "Todos los Artículos"
        Me.MetroRadioButton1.UseVisualStyleBackColor = True
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataMember = "Familia"
        Me.FamiliaBindingSource.DataSource = Me.TallerDataSet
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
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroRadioButton2)
        Me.Controls.Add(Me.MetroRadioButton1)
        Me.Name = "frmListadosStockMinimo"
        Me.Text = "Artículos Stock bajo Mínimo"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents FamiliaTableAdapter As tallerDataSetTableAdapters.FamiliaTableAdapter
End Class
