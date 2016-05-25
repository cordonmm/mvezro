<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProveedoresListado
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
        Me.dgProveedores = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoblaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoMovilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoContactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.ProveedorTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProveedorTableAdapter()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgProveedores
        '
        Me.dgProveedores.AllowUserToAddRows = False
        Me.dgProveedores.AllowUserToDeleteRows = False
        Me.dgProveedores.AutoGenerateColumns = False
        Me.dgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProveedores.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn, Me.PoblaciónDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.TelefonoMovilDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoContactoDataGridViewTextBoxColumn})
        Me.dgProveedores.DataSource = Me.ProveedorBindingSource
        Me.dgProveedores.Location = New System.Drawing.Point(23, 113)
        Me.dgProveedores.MultiSelect = False
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.ReadOnly = True
        Me.dgProveedores.RowHeadersVisible = False
        Me.dgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProveedores.Size = New System.Drawing.Size(965, 240)
        Me.dgProveedores.TabIndex = 65
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "CIF"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        Me.CifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PoblaciónDataGridViewTextBoxColumn
        '
        Me.PoblaciónDataGridViewTextBoxColumn.DataPropertyName = "población"
        Me.PoblaciónDataGridViewTextBoxColumn.HeaderText = "Población"
        Me.PoblaciónDataGridViewTextBoxColumn.Name = "PoblaciónDataGridViewTextBoxColumn"
        Me.PoblaciónDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoMovilDataGridViewTextBoxColumn
        '
        Me.TelefonoMovilDataGridViewTextBoxColumn.DataPropertyName = "telefonoMovil"
        Me.TelefonoMovilDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoMovilDataGridViewTextBoxColumn.Name = "TelefonoMovilDataGridViewTextBoxColumn"
        Me.TelefonoMovilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoContactoDataGridViewTextBoxColumn
        '
        Me.TelefonoContactoDataGridViewTextBoxColumn.DataPropertyName = "telefonoContacto"
        Me.TelefonoContactoDataGridViewTextBoxColumn.HeaderText = "Telefono P.Contacto"
        Me.TelefonoContactoDataGridViewTextBoxColumn.Name = "TelefonoContactoDataGridViewTextBoxColumn"
        Me.TelefonoContactoDataGridViewTextBoxColumn.ReadOnly = True
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
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(159, 73)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(302, 25)
        Me.txtBuscar.TabIndex = 67
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(23, 73)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(113, 19)
        Me.lblBuscar.TabIndex = 66
        Me.lblBuscar.Text = "Buscar Proveedor"
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'frmMantenimientoProveedoresListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1025, 427)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgProveedores)
        Me.Name = "frmMantenimientoProveedoresListado"
        Me.Text = "Listado de Proveedores"
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgProveedores As DataGridView
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As tallerDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PoblaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoMovilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoContactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
