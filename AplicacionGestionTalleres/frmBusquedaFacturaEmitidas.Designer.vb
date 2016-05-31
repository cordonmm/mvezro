<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusquedaFacturaEmitidas
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
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.dgFacturaEmitidas = New System.Windows.Forms.DataGridView()
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ConsFacturaEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsFacturaETableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsFacturaETableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgFacturaEmitidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsFacturaEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(159, 72)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(302, 25)
        Me.txtBuscar.TabIndex = 70
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(23, 72)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(93, 19)
        Me.lblBuscar.TabIndex = 69
        Me.lblBuscar.Text = "Buscar Factura"
        '
        'dgFacturaEmitidas
        '
        Me.dgFacturaEmitidas.AllowUserToAddRows = False
        Me.dgFacturaEmitidas.AllowUserToDeleteRows = False
        Me.dgFacturaEmitidas.AutoGenerateColumns = False
        Me.dgFacturaEmitidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFacturaEmitidas.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgFacturaEmitidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturaEmitidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NumeroFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.dgFacturaEmitidas.DataSource = Me.ConsFacturaEBindingSource
        Me.dgFacturaEmitidas.Location = New System.Drawing.Point(23, 112)
        Me.dgFacturaEmitidas.MultiSelect = False
        Me.dgFacturaEmitidas.Name = "dgFacturaEmitidas"
        Me.dgFacturaEmitidas.ReadOnly = True
        Me.dgFacturaEmitidas.RowHeadersVisible = False
        Me.dgFacturaEmitidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFacturaEmitidas.Size = New System.Drawing.Size(965, 240)
        Me.dgFacturaEmitidas.TabIndex = 68
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsFacturaEBindingSource
        '
        Me.ConsFacturaEBindingSource.DataMember = "ConsFacturaE"
        Me.ConsFacturaEBindingSource.DataSource = Me.TallerDataSet
        '
        'ConsFacturaETableAdapter
        '
        Me.ConsFacturaETableAdapter.ClearBeforeFill = True
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
        'frmBusquedaFacturaEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1035, 420)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgFacturaEmitidas)
        Me.Name = "frmBusquedaFacturaEmitidas"
        Me.Text = "Listado de Facturas"
        CType(Me.dgFacturaEmitidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsFacturaEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgFacturaEmitidas As DataGridView
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ConsFacturaEBindingSource As BindingSource
    Friend WithEvents ConsFacturaETableAdapter As tallerDataSetTableAdapters.ConsFacturaETableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
