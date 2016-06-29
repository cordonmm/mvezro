<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadosRecibidas
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
        Me.fechaFin = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.fechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.cmbProveedor = New MetroFramework.Controls.MetroComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.idProveedor = New MetroFramework.Controls.MetroRadioButton()
        Me.todos = New MetroFramework.Controls.MetroRadioButton()
        Me.ProveedorTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProveedorTableAdapter()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fechaFin
        '
        Me.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaFin.Location = New System.Drawing.Point(270, 64)
        Me.fechaFin.Name = "fechaFin"
        Me.fechaFin.Size = New System.Drawing.Size(175, 20)
        Me.fechaFin.TabIndex = 80
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(249, 65)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel1.TabIndex = 79
        Me.MetroLabel1.Text = "y"
        '
        'fechaInicio
        '
        Me.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaInicio.Location = New System.Drawing.Point(68, 64)
        Me.fechaInicio.Name = "fechaInicio"
        Me.fechaInicio.Size = New System.Drawing.Size(175, 20)
        Me.fechaInicio.TabIndex = 78
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 65)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 77
        Me.MetroLabel3.Text = "Entre"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(343, 236)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 76
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(235, 236)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 75
        Me.MetroButton1.Text = "Imprimir"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorBindingSource
        Me.cmbProveedor.DisplayMember = "nombre"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.ItemHeight = 23
        Me.cmbProveedor.Location = New System.Drawing.Point(172, 170)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(273, 29)
        Me.cmbProveedor.TabIndex = 74
        Me.cmbProveedor.ValueMember = "Id"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'idProveedor
        '
        Me.idProveedor.AutoSize = True
        Me.idProveedor.Location = New System.Drawing.Point(23, 172)
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.Size = New System.Drawing.Size(143, 15)
        Me.idProveedor.TabIndex = 73
        Me.idProveedor.Text = "Seleccionar Proveedor:"
        Me.idProveedor.UseVisualStyleBackColor = True
        '
        'todos
        '
        Me.todos.AutoSize = True
        Me.todos.Checked = True
        Me.todos.Location = New System.Drawing.Point(23, 139)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(141, 15)
        Me.todos.TabIndex = 72
        Me.todos.TabStop = True
        Me.todos.Text = "Todos los Proveedores"
        Me.todos.UseVisualStyleBackColor = True
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'frmListadosRecibidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(477, 314)
        Me.Controls.Add(Me.fechaFin)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.fechaInicio)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.idProveedor)
        Me.Controls.Add(Me.todos)
        Me.Name = "frmListadosRecibidas"
        Me.Text = "Facturas Recibidas"
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fechaFin As DateTimePicker
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents fechaInicio As DateTimePicker
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbProveedor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents idProveedor As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents todos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As tallerDataSetTableAdapters.ProveedorTableAdapter
End Class
