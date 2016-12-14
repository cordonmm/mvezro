<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusquedaPresupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaPresupuesto))
        Me.dgPresupuestos = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsPresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet1 = New AplicacionGestionTalleres.tallerDataSet()
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ConsPresupuestoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.consPresupuestoTableAdapter()
        Me.chkFiltrar = New System.Windows.Forms.CheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPresupuestos
        '
        Me.dgPresupuestos.AllowUserToAddRows = False
        Me.dgPresupuestos.AllowUserToDeleteRows = False
        Me.dgPresupuestos.AutoGenerateColumns = False
        Me.dgPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPresupuestos.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPresupuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NumeroFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.dgPresupuestos.DataSource = Me.ConsPresupuestoBindingSource
        Me.dgPresupuestos.Location = New System.Drawing.Point(23, 112)
        Me.dgPresupuestos.MultiSelect = False
        Me.dgPresupuestos.Name = "dgPresupuestos"
        Me.dgPresupuestos.ReadOnly = True
        Me.dgPresupuestos.RowHeadersVisible = False
        Me.dgPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPresupuestos.Size = New System.Drawing.Size(965, 240)
        Me.dgPresupuestos.TabIndex = 68
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "numeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "CIF Cliente"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        Me.CifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email Cliente"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsPresupuestoBindingSource
        '
        Me.ConsPresupuestoBindingSource.DataMember = "consPresupuesto"
        Me.ConsPresupuestoBindingSource.DataSource = Me.TallerDataSet1
        '
        'TallerDataSet1
        '
        Me.TallerDataSet1.DataSetName = "tallerDataSet"
        Me.TallerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsPresupuestoTableAdapter
        '
        Me.ConsPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(945, 74)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(51, 17)
        Me.chkFiltrar.TabIndex = 97
        Me.chkFiltrar.Text = "Filtrar"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(743, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel1.TabIndex = 95
        Me.MetroLabel1.Text = "y"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(562, 72)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaInicio.TabIndex = 94
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(764, 72)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaFin.TabIndex = 96
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(517, 73)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 93
        Me.MetroLabel3.Text = "Entre"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(23, 72)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(122, 19)
        Me.lblBuscar.TabIndex = 91
        Me.lblBuscar.Text = "Buscar Presupuesto"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(159, 72)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(302, 25)
        Me.txtBuscar.TabIndex = 92
        '
        'frmBusquedaPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1035, 420)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgPresupuestos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBusquedaPresupuesto"
        Me.Text = "Listado de Presupuestos"
        CType(Me.dgPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPresupuestos As DataGridView
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TallerDataSet1 As tallerDataSet
    Friend WithEvents ConsPresupuestoBindingSource As BindingSource
    Friend WithEvents ConsPresupuestoTableAdapter As tallerDataSetTableAdapters.consPresupuestoTableAdapter
    Friend WithEvents chkFiltrar As CheckBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
End Class
