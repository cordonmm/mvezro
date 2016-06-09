<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadosArticulos
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
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.alfabetico = New MetroFramework.Controls.MetroRadioButton()
        Me.referencia = New MetroFramework.Controls.MetroRadioButton()
        Me.precioCompra = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.TallerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FamiliaTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FamiliaTableAdapter()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 74)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel5.TabIndex = 43
        Me.MetroLabel5.Text = "Familia"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.DataSource = Me.FamiliaBindingSource
        Me.MetroComboBox1.DisplayMember = "descripcion"
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(23, 96)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(256, 29)
        Me.MetroComboBox1.TabIndex = 42
        Me.MetroComboBox1.ValueMember = "Id"
        '
        'alfabetico
        '
        Me.alfabetico.AutoSize = True
        Me.alfabetico.Location = New System.Drawing.Point(337, 96)
        Me.alfabetico.Name = "alfabetico"
        Me.alfabetico.Size = New System.Drawing.Size(77, 15)
        Me.alfabetico.TabIndex = 44
        Me.alfabetico.TabStop = True
        Me.alfabetico.Text = "Alfabético"
        Me.alfabetico.UseVisualStyleBackColor = True
        '
        'referencia
        '
        Me.referencia.AutoSize = True
        Me.referencia.Location = New System.Drawing.Point(337, 129)
        Me.referencia.Name = "referencia"
        Me.referencia.Size = New System.Drawing.Size(99, 15)
        Me.referencia.TabIndex = 45
        Me.referencia.TabStop = True
        Me.referencia.Text = "Por Referencia"
        Me.referencia.UseVisualStyleBackColor = True
        '
        'precioCompra
        '
        Me.precioCompra.AutoSize = True
        Me.precioCompra.Location = New System.Drawing.Point(23, 188)
        Me.precioCompra.Name = "precioCompra"
        Me.precioCompra.Size = New System.Drawing.Size(165, 15)
        Me.precioCompra.TabIndex = 46
        Me.precioCompra.Text = "Imprimir precio de compra"
        Me.precioCompra.UseVisualStyleBackColor = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(338, 188)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 65
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(230, 188)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 64
        Me.MetroButton1.Text = "Imprimir"
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TallerDataSetBindingSource
        '
        Me.TallerDataSetBindingSource.DataSource = Me.TallerDataSet
        Me.TallerDataSetBindingSource.Position = 0
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataMember = "Familia"
        Me.FamiliaBindingSource.DataSource = Me.TallerDataSetBindingSource
        '
        'FamiliaTableAdapter
        '
        Me.FamiliaTableAdapter.ClearBeforeFill = True
        '
        'frmListadosArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(465, 267)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.precioCompra)
        Me.Controls.Add(Me.referencia)
        Me.Controls.Add(Me.alfabetico)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Name = "frmListadosArticulos"
        Me.Text = "Listado Artículos"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents alfabetico As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents referencia As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents precioCompra As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents TallerDataSetBindingSource As BindingSource
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents FamiliaTableAdapter As tallerDataSetTableAdapters.FamiliaTableAdapter
End Class
