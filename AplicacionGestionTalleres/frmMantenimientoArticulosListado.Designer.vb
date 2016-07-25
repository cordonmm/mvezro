<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoArticulosListado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoArticulosListado))
        Me.txtArticulo = New MetroFramework.Controls.MetroTextBox()
        Me.lblArticulo = New MetroFramework.Controls.MetroLabel()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.FamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PvpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ConsProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(159, 72)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(302, 25)
        Me.txtArticulo.TabIndex = 73
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(23, 72)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(97, 19)
        Me.lblArticulo.TabIndex = 72
        Me.lblArticulo.Text = "Buscar Articulo"
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.AllowUserToDeleteRows = False
        Me.dgArticulos.AllowUserToResizeRows = False
        Me.dgArticulos.AutoGenerateColumns = False
        Me.dgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgArticulos.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FamiliaDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PvpDataGridViewTextBoxColumn})
        Me.dgArticulos.DataSource = Me.ConsProductoBindingSource
        Me.dgArticulos.Location = New System.Drawing.Point(23, 112)
        Me.dgArticulos.MultiSelect = False
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ReadOnly = True
        Me.dgArticulos.RowHeadersVisible = False
        Me.dgArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(965, 240)
        Me.dgArticulos.TabIndex = 71
        '
        'FamiliaDataGridViewTextBoxColumn
        '
        Me.FamiliaDataGridViewTextBoxColumn.DataPropertyName = "Familia"
        Me.FamiliaDataGridViewTextBoxColumn.HeaderText = "Familia"
        Me.FamiliaDataGridViewTextBoxColumn.Name = "FamiliaDataGridViewTextBoxColumn"
        Me.FamiliaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PvpDataGridViewTextBoxColumn
        '
        Me.PvpDataGridViewTextBoxColumn.DataPropertyName = "pvp"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PvpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PvpDataGridViewTextBoxColumn.HeaderText = "PVP"
        Me.PvpDataGridViewTextBoxColumn.Name = "PvpDataGridViewTextBoxColumn"
        Me.PvpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsProductoBindingSource
        '
        Me.ConsProductoBindingSource.DataMember = "ConsProducto"
        Me.ConsProductoBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsProductoTableAdapter
        '
        Me.ConsProductoTableAdapter.ClearBeforeFill = True
        '
        'frmMantenimientoArticulosListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1017, 408)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.dgArticulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMantenimientoArticulosListado"
        Me.Text = "Listado Artículos"
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArticulo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblArticulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ConsProductoBindingSource As BindingSource
    Friend WithEvents ConsProductoTableAdapter As tallerDataSetTableAdapters.ConsProductoTableAdapter
    Friend WithEvents FamiliaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PvpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
