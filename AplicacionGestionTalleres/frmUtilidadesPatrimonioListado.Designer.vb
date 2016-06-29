<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilidadesPatrimonioListado
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
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dgPatrimonio = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsPatrimonioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.chkFiltrar = New System.Windows.Forms.CheckBox()
        Me.ConsPatrimonioTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.consPatrimonioTableAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgPatrimonio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsPatrimonioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(106, 71)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(369, 25)
        Me.txtBuscar.TabIndex = 73
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 71)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel4.TabIndex = 72
        Me.MetroLabel4.Text = "Buscar"
        '
        'dgPatrimonio
        '
        Me.dgPatrimonio.AllowUserToAddRows = False
        Me.dgPatrimonio.AllowUserToDeleteRows = False
        Me.dgPatrimonio.AutoGenerateColumns = False
        Me.dgPatrimonio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPatrimonio.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgPatrimonio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPatrimonio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NumeroFacturaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.IdentificadorDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn})
        Me.dgPatrimonio.DataSource = Me.ConsPatrimonioBindingSource
        Me.dgPatrimonio.Location = New System.Drawing.Point(23, 111)
        Me.dgPatrimonio.Name = "dgPatrimonio"
        Me.dgPatrimonio.ReadOnly = True
        Me.dgPatrimonio.RowHeadersVisible = False
        Me.dgPatrimonio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPatrimonio.Size = New System.Drawing.Size(965, 240)
        Me.dgPatrimonio.TabIndex = 71
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "numeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "Nº Factura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdentificadorDataGridViewTextBoxColumn
        '
        Me.IdentificadorDataGridViewTextBoxColumn.DataPropertyName = "identificador"
        Me.IdentificadorDataGridViewTextBoxColumn.HeaderText = "Ident."
        Me.IdentificadorDataGridViewTextBoxColumn.Name = "IdentificadorDataGridViewTextBoxColumn"
        Me.IdentificadorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsPatrimonioBindingSource
        '
        Me.ConsPatrimonioBindingSource.DataMember = "consPatrimonio"
        Me.ConsPatrimonioBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(754, 71)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaFin.TabIndex = 84
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(733, 72)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel1.TabIndex = 83
        Me.MetroLabel1.Text = "y"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(552, 71)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaInicio.TabIndex = 82
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(507, 72)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 81
        Me.MetroLabel3.Text = "Entre"
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(935, 73)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(51, 17)
        Me.chkFiltrar.TabIndex = 85
        Me.chkFiltrar.Text = "Filtrar"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'ConsPatrimonioTableAdapter
        '
        Me.ConsPatrimonioTableAdapter.ClearBeforeFill = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(911, 357)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 86
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmUtilidadesPatrimonioListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1015, 398)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.dgPatrimonio)
        Me.Name = "frmUtilidadesPatrimonioListado"
        Me.Text = "Listado Patrimonio"
        CType(Me.dgPatrimonio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsPatrimonioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgPatrimonio As DataGridView
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ConsPatrimonioBindingSource As BindingSource
    Friend WithEvents ConsPatrimonioTableAdapter As tallerDataSetTableAdapters.consPatrimonioTableAdapter
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents chkFiltrar As CheckBox
    Friend WithEvents btnImprimir As Button
End Class
