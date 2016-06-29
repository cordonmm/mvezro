<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadosEmitidas
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
        Me.idCliente = New MetroFramework.Controls.MetroRadioButton()
        Me.todos = New MetroFramework.Controls.MetroRadioButton()
        Me.cmbCliente = New MetroFramework.Controls.MetroComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.fechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.fechaFin = New System.Windows.Forms.DateTimePicker()
        Me.ClienteTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ClienteTableAdapter()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idCliente
        '
        Me.idCliente.AutoSize = True
        Me.idCliente.Location = New System.Drawing.Point(43, 199)
        Me.idCliente.Name = "idCliente"
        Me.idCliente.Size = New System.Drawing.Size(126, 15)
        Me.idCliente.TabIndex = 47
        Me.idCliente.Text = "Seleccionar Cliente:"
        Me.idCliente.UseVisualStyleBackColor = True
        '
        'todos
        '
        Me.todos.AutoSize = True
        Me.todos.Checked = True
        Me.todos.Location = New System.Drawing.Point(43, 166)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(118, 15)
        Me.todos.TabIndex = 46
        Me.todos.TabStop = True
        Me.todos.Text = "Todos los Clientes"
        Me.todos.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.DataSource = Me.ClienteBindingSource
        Me.cmbCliente.DisplayMember = "nombre"
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.ItemHeight = 23
        Me.cmbCliente.Location = New System.Drawing.Point(175, 197)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(290, 29)
        Me.cmbCliente.TabIndex = 48
        Me.cmbCliente.ValueMember = "Id"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(363, 263)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 67
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(255, 263)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 66
        Me.MetroButton1.Text = "Imprimir"
        '
        'fechaInicio
        '
        Me.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaInicio.Location = New System.Drawing.Point(88, 91)
        Me.fechaInicio.Name = "fechaInicio"
        Me.fechaInicio.Size = New System.Drawing.Size(175, 20)
        Me.fechaInicio.TabIndex = 69
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(43, 92)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 68
        Me.MetroLabel3.Text = "Entre"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(269, 92)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel1.TabIndex = 70
        Me.MetroLabel1.Text = "y"
        '
        'fechaFin
        '
        Me.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaFin.Location = New System.Drawing.Point(290, 91)
        Me.fechaFin.Name = "fechaFin"
        Me.fechaFin.Size = New System.Drawing.Size(175, 20)
        Me.fechaFin.TabIndex = 71
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'frmListadosEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(497, 328)
        Me.Controls.Add(Me.fechaFin)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.fechaInicio)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.idCliente)
        Me.Controls.Add(Me.todos)
        Me.Name = "frmListadosEmitidas"
        Me.Text = "Facturas Emitidas"
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idCliente As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents todos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents cmbCliente As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents fechaInicio As DateTimePicker
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents fechaFin As DateTimePicker
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As tallerDataSetTableAdapters.ClienteTableAdapter
End Class
